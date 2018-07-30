Public Class Main

    Dim FFmpegProcessID As Integer = -1
    
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'myVideoEditor.AboutBox()
        ComboBox_format.SelectedIndex = 0
        TextBox_videoInput.AllowDrop = True
        TextBox_videoOutput.AllowDrop = True
        TextBox_ffmpegPath.Text = getKeyValue("PATH", "FFmpeg", "")
        TextBox_initialInputFolder.Text = getKeyValue("PATH", "InputFolder", "")
        TextBox_initialOutputFolder.Text = getKeyValue("PATH", "OutputFolder", "")
    End Sub

    Private Function checkParameters() As Boolean
        Try

            If TextBox_ffmpegPath.Text = "" Or TextBox_videoInput.Text = "" Or TextBox_videoOutput.Text = "" Then
                MsgBox("Missing parameters !")
                Return False
            End If

            If Not IO.File.Exists(TextBox_videoInput.Text) Then Return False
            If TextBox_videoInput_2.Text <> "" And Not IO.File.Exists(TextBox_videoInput_2.Text) Then Return False

            If IO.File.Exists(TextBox_videoOutput.Text) Then
                Dim res As MsgBoxResult = MsgBox("File already exists, overwrite it ?", MsgBoxStyle.YesNo)
                If Not res = MsgBoxResult.Yes Then
                    Return False
                Else
                    IO.File.Delete(TextBox_videoOutput.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Private Sub btn_addTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addTask.Click
        If Not checkParameters() = True Then Exit Sub

        Dim taskNumber As Integer = ListView_tasks.Items.Count

        If TextBox_videoInput_2.Text <> "" Then
            ListView_tasks.Items.Add(TextBox_videoInput.Text & " / " & TextBox_videoInput_2.Text)
        Else
            ListView_tasks.Items.Add(TextBox_videoInput.Text)
        End If

        ListView_tasks.Items(taskNumber).SubItems.Add(TextBox_videoOutput.Text)
        ListView_tasks.Items(taskNumber).SubItems.Add("Waiting")
        ListView_tasks.Items(taskNumber).SubItems.Add(buildCmd())
    End Sub

    Private Function buildCmd() As String
        Dim cmd As String = ""

        cmd = TextBox_ffmpegPath.Text & " -ss " & NumericUpDown_offset.Value.ToString & " -i "
        If TextBox_videoInput_2.Text <> "" Then
            cmd = cmd & "concat:" & TextBox_videoInput.Text & "|" & TextBox_videoInput_2.Text
        Else
            cmd = cmd & TextBox_videoInput.Text
        End If

        If NumericUpDown_nbFrames.Value <> 0 Then cmd = cmd & " -frames " & NumericUpDown_nbFrames.Value.ToString()

        If ComboBox_format.SelectedIndex = 0 Then
            cmd = cmd & " -vcodec copy " & TextBox_videoOutput.Text
        Else
            cmd = cmd & " -vcodec " & ComboBox_format.SelectedItem.ToString().ToLower & " " & TextBox_videoOutput.Text
        End If

        'MsgBox(cmd)

        Return cmd
    End Function

    Private Sub Timer_tasks_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_tasks.Tick
        If procExists(FFmpegProcessID) Then AddDbgMessage("FFmpegProcessID already running") : Exit Sub
        If ListView_tasks.Items.Count = 0 Then AddDbgMessage("No task to run") : Exit Sub

        Dim taskToExecute As Integer = -1
        For n = 0 To ListView_tasks.Items.Count - 1
            If ListView_tasks.Items(n).SubItems(2).Text = "Started" Then ListView_tasks.Items(n).SubItems(2).Text = "Completed"
            If ListView_tasks.Items(n).SubItems(2).Text = "Waiting" Then
                taskToExecute = n
                ListView_tasks.Items(n).SubItems(2).Text = "Started"
                Exit For
            End If
        Next

        If taskToExecute = -1 Then AddDbgMessage("All tasks completed") : Exit Sub

        FFmpegProcessID = Shell(ListView_tasks.Items(taskToExecute).SubItems(3).Text, AppWinStyle.Hide)
    End Sub

    Private Sub AddDbgMessage(ByVal msg As String)
        If ListBox_debug.Items.Count > 100 Then ListBox_debug.Items.RemoveAt(0)

        ListBox_debug.Items.Add(TimeString & " - " & msg)
    End Sub

    Private Sub btn_slct_input_file_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_slct_input_file.Click
        If getKeyValue("PATH", "InputFolder", "") <> "" Then fileSelecter.InitialDirectory = getKeyValue("PATH", "InputFolder", "")
        fileSelecter.FileName = ""
        fileSelecter.ShowDialog()
        TextBox_videoInput.Text = fileSelecter.FileName
    End Sub

    Private Sub btn_slct_output_file_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_slct_output_file.Click
        If getKeyValue("PATH", "OutputFolder", "") <> "" Then fileSelecter.InitialDirectory = getKeyValue("PATH", "OutputFolder", "")
        fileSelecter.FileName = ""
        fileSelecter.CheckFileExists = False
        fileSelecter.ShowDialog()
        TextBox_videoOutput.Text = fileSelecter.FileName
    End Sub

    Private Sub btn_slctFFmpegPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_slctFFmpegPath.Click
        fileSelecter.Filter = "Executables (*.exe)|*.exe"
        fileSelecter.ShowDialog()
        TextBox_ffmpegPath.Text = fileSelecter.FileName
    End Sub

    Private Sub btn_slctInitialInputFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_slctInitialInputFolder.Click
        folderSelecter.ShowDialog()
        TextBox_initialInputFolder.Text = folderSelecter.SelectedPath
    End Sub

    Private Sub btn_slctInitialOutputFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_slctInitialOutputFolder.Click
        folderSelecter.ShowDialog()
        TextBox_initialOutputFolder.Text = folderSelecter.SelectedPath
    End Sub

    Private Sub btn_slct_input_file_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_slct_input_file_2.Click
        If getKeyValue("PATH", "InputFolder", "") <> "" Then fileSelecter.InitialDirectory = getKeyValue("PATH", "InputFolder", "")
        fileSelecter.FileName = ""
        fileSelecter.ShowDialog()
        TextBox_videoInput_2.Text = fileSelecter.FileName
    End Sub

    Private Sub TextBox_videoInput_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_videoInput.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            TextBox_videoInput.Text = path
        Next
    End Sub

    Private Sub TextBox_videoInput_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_videoInput.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub TextBox_videoOutput_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_videoOutput.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            TextBox_videoOutput.Text = path
        Next
    End Sub

    Private Sub TextBox_videoOutput_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_videoOutput.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub btn_apply_config_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_apply_config.Click
        setKeyValue("PATH", "FFmpeg", TextBox_ffmpegPath.Text)
        setKeyValue("PATH", "InputFolder", TextBox_initialInputFolder.Text)
        setKeyValue("PATH", "OutputFolder", TextBox_initialOutputFolder.Text)
    End Sub

    Private Sub btn_analyse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_analyse.Click
        Try

            Dim mi As New mediainfo.mediainfo
            mi.Open(TextBox_videoInput.Text)
            Dim tst As String = mi.Get_(StreamKind.Visual, 0, "Width")
            MsgBox(tst)

        Catch ex As Exception
            MsgBox("coming soon !")
        End Try
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.myVideoEditor = New AxmyVideoEditorLib.AxmyVideoEditor()
        Me.TabPage_config = New System.Windows.Forms.TabPage()
        Me.ListBox_debug = New System.Windows.Forms.ListBox()
        Me.btn_slctFFmpegPath = New System.Windows.Forms.Button()
        Me.btn_slctInitialOutputFolder = New System.Windows.Forms.Button()
        Me.btn_slctInitialInputFolder = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_initialOutputFolder = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_initialInputFolder = New System.Windows.Forms.TextBox()
        Me.btn_apply_config = New System.Windows.Forms.Button()
        Me.label_ffmpegPath = New System.Windows.Forms.Label()
        Me.TextBox_ffmpegPath = New System.Windows.Forms.TextBox()
        Me.TabPage_analysis = New System.Windows.Forms.TabPage()
        Me.TabPage_currentTasks = New System.Windows.Forms.TabPage()
        Me.ListView_tasks = New System.Windows.Forms.ListView()
        Me.Column_source = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column_dest = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column_state = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column_cmd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl_main = New System.Windows.Forms.TabControl()
        Me.TabPage_addtask = New System.Windows.Forms.TabPage()
        Me.btn_slct_input_file_2 = New System.Windows.Forms.Button()
        Me.TextBox_videoInput_2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_slct_input_file = New System.Windows.Forms.Button()
        Me.btn_slct_output_file = New System.Windows.Forms.Button()
        Me.NumericUpDown_nbFrames = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown_offset = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_addTask = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_format = New System.Windows.Forms.ComboBox()
        Me.Label_outputFile = New System.Windows.Forms.Label()
        Me.TextBox_videoOutput = New System.Windows.Forms.TextBox()
        Me.TextBox_videoInput = New System.Windows.Forms.TextBox()
        Me.btn_analyse = New System.Windows.Forms.Button()
        Me.Label_inputFile = New System.Windows.Forms.Label()
        Me.fileSelecter = New System.Windows.Forms.OpenFileDialog()
        Me.folderSelecter = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer_tasks = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.myVideoEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_config.SuspendLayout()
        Me.TabPage_analysis.SuspendLayout()
        Me.TabPage_currentTasks.SuspendLayout()
        Me.TabControl_main.SuspendLayout()
        Me.TabPage_addtask.SuspendLayout()
        CType(Me.NumericUpDown_nbFrames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_offset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'myVideoEditor
        '
        Me.myVideoEditor.Enabled = True
        Me.myVideoEditor.Location = New System.Drawing.Point(30, 40)
        Me.myVideoEditor.Name = "myVideoEditor"
        Me.myVideoEditor.OcxState = CType(resources.GetObject("myVideoEditor.OcxState"), System.Windows.Forms.AxHost.State)
        Me.myVideoEditor.Size = New System.Drawing.Size(80, 65)
        Me.myVideoEditor.TabIndex = 0
        Me.myVideoEditor.Visible = False
        '
        'TabPage_config
        '
        Me.TabPage_config.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage_config.Controls.Add(Me.ListBox_debug)
        Me.TabPage_config.Controls.Add(Me.btn_slctFFmpegPath)
        Me.TabPage_config.Controls.Add(Me.btn_slctInitialOutputFolder)
        Me.TabPage_config.Controls.Add(Me.btn_slctInitialInputFolder)
        Me.TabPage_config.Controls.Add(Me.Label6)
        Me.TabPage_config.Controls.Add(Me.TextBox_initialOutputFolder)
        Me.TabPage_config.Controls.Add(Me.Label5)
        Me.TabPage_config.Controls.Add(Me.TextBox_initialInputFolder)
        Me.TabPage_config.Controls.Add(Me.btn_apply_config)
        Me.TabPage_config.Controls.Add(Me.label_ffmpegPath)
        Me.TabPage_config.Controls.Add(Me.TextBox_ffmpegPath)
        Me.TabPage_config.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_config.Name = "TabPage_config"
        Me.TabPage_config.Size = New System.Drawing.Size(690, 279)
        Me.TabPage_config.TabIndex = 2
        Me.TabPage_config.Text = "Config"
        '
        'ListBox_debug
        '
        Me.ListBox_debug.FormattingEnabled = True
        Me.ListBox_debug.Location = New System.Drawing.Point(111, 134)
        Me.ListBox_debug.Name = "ListBox_debug"
        Me.ListBox_debug.Size = New System.Drawing.Size(384, 134)
        Me.ListBox_debug.TabIndex = 10
        Me.ListBox_debug.Visible = False
        '
        'btn_slctFFmpegPath
        '
        Me.btn_slctFFmpegPath.BackgroundImage = CType(resources.GetObject("btn_slctFFmpegPath.BackgroundImage"), System.Drawing.Image)
        Me.btn_slctFFmpegPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_slctFFmpegPath.FlatAppearance.BorderSize = 0
        Me.btn_slctFFmpegPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_slctFFmpegPath.Location = New System.Drawing.Point(654, 13)
        Me.btn_slctFFmpegPath.Name = "btn_slctFFmpegPath"
        Me.btn_slctFFmpegPath.Size = New System.Drawing.Size(28, 23)
        Me.btn_slctFFmpegPath.TabIndex = 9
        Me.btn_slctFFmpegPath.UseVisualStyleBackColor = True
        '
        'btn_slctInitialOutputFolder
        '
        Me.btn_slctInitialOutputFolder.BackgroundImage = CType(resources.GetObject("btn_slctInitialOutputFolder.BackgroundImage"), System.Drawing.Image)
        Me.btn_slctInitialOutputFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_slctInitialOutputFolder.FlatAppearance.BorderSize = 0
        Me.btn_slctInitialOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_slctInitialOutputFolder.Location = New System.Drawing.Point(654, 75)
        Me.btn_slctInitialOutputFolder.Name = "btn_slctInitialOutputFolder"
        Me.btn_slctInitialOutputFolder.Size = New System.Drawing.Size(28, 23)
        Me.btn_slctInitialOutputFolder.TabIndex = 8
        Me.btn_slctInitialOutputFolder.UseVisualStyleBackColor = True
        '
        'btn_slctInitialInputFolder
        '
        Me.btn_slctInitialInputFolder.BackgroundImage = CType(resources.GetObject("btn_slctInitialInputFolder.BackgroundImage"), System.Drawing.Image)
        Me.btn_slctInitialInputFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_slctInitialInputFolder.FlatAppearance.BorderSize = 0
        Me.btn_slctInitialInputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_slctInitialInputFolder.Location = New System.Drawing.Point(654, 46)
        Me.btn_slctInitialInputFolder.Name = "btn_slctInitialInputFolder"
        Me.btn_slctInitialInputFolder.Size = New System.Drawing.Size(28, 23)
        Me.btn_slctInitialInputFolder.TabIndex = 7
        Me.btn_slctInitialInputFolder.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Initial output folder : "
        '
        'TextBox_initialOutputFolder
        '
        Me.TextBox_initialOutputFolder.Location = New System.Drawing.Point(111, 75)
        Me.TextBox_initialOutputFolder.Name = "TextBox_initialOutputFolder"
        Me.TextBox_initialOutputFolder.Size = New System.Drawing.Size(537, 20)
        Me.TextBox_initialOutputFolder.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Initial input folder : "
        '
        'TextBox_initialInputFolder
        '
        Me.TextBox_initialInputFolder.Location = New System.Drawing.Point(111, 46)
        Me.TextBox_initialInputFolder.Name = "TextBox_initialInputFolder"
        Me.TextBox_initialInputFolder.Size = New System.Drawing.Size(537, 20)
        Me.TextBox_initialInputFolder.TabIndex = 3
        '
        'btn_apply_config
        '
        Me.btn_apply_config.Location = New System.Drawing.Point(555, 111)
        Me.btn_apply_config.Name = "btn_apply_config"
        Me.btn_apply_config.Size = New System.Drawing.Size(93, 23)
        Me.btn_apply_config.TabIndex = 2
        Me.btn_apply_config.Text = "Apply changes"
        Me.btn_apply_config.UseVisualStyleBackColor = True
        '
        'label_ffmpegPath
        '
        Me.label_ffmpegPath.AutoSize = True
        Me.label_ffmpegPath.Location = New System.Drawing.Point(20, 18)
        Me.label_ffmpegPath.Name = "label_ffmpegPath"
        Me.label_ffmpegPath.Size = New System.Drawing.Size(85, 13)
        Me.label_ffmpegPath.TabIndex = 1
        Me.label_ffmpegPath.Text = "Path to ffmpeg : "
        '
        'TextBox_ffmpegPath
        '
        Me.TextBox_ffmpegPath.Location = New System.Drawing.Point(111, 15)
        Me.TextBox_ffmpegPath.Name = "TextBox_ffmpegPath"
        Me.TextBox_ffmpegPath.Size = New System.Drawing.Size(537, 20)
        Me.TextBox_ffmpegPath.TabIndex = 0
        '
        'TabPage_analysis
        '
        Me.TabPage_analysis.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage_analysis.Controls.Add(Me.Label1)
        Me.TabPage_analysis.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_analysis.Name = "TabPage_analysis"
        Me.TabPage_analysis.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_analysis.Size = New System.Drawing.Size(690, 279)
        Me.TabPage_analysis.TabIndex = 1
        Me.TabPage_analysis.Text = "Analysis"
        '
        'TabPage_currentTasks
        '
        Me.TabPage_currentTasks.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage_currentTasks.Controls.Add(Me.ListView_tasks)
        Me.TabPage_currentTasks.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_currentTasks.Name = "TabPage_currentTasks"
        Me.TabPage_currentTasks.Size = New System.Drawing.Size(690, 279)
        Me.TabPage_currentTasks.TabIndex = 3
        Me.TabPage_currentTasks.Text = "Ongoing Tasks"
        '
        'ListView_tasks
        '
        Me.ListView_tasks.BackColor = System.Drawing.Color.PowderBlue
        Me.ListView_tasks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Column_source, Me.Column_dest, Me.Column_state, Me.Column_cmd})
        Me.ListView_tasks.Location = New System.Drawing.Point(-4, 0)
        Me.ListView_tasks.Name = "ListView_tasks"
        Me.ListView_tasks.Size = New System.Drawing.Size(1341, 393)
        Me.ListView_tasks.TabIndex = 0
        Me.ListView_tasks.UseCompatibleStateImageBehavior = False
        Me.ListView_tasks.View = System.Windows.Forms.View.Details
        '
        'Column_source
        '
        Me.Column_source.Text = "Source File"
        Me.Column_source.Width = 258
        '
        'Column_dest
        '
        Me.Column_dest.Text = "Output File"
        Me.Column_dest.Width = 268
        '
        'Column_state
        '
        Me.Column_state.Text = "State"
        Me.Column_state.Width = 169
        '
        'Column_cmd
        '
        Me.Column_cmd.Text = "CMD"
        Me.Column_cmd.Width = 98
        '
        'TabControl_main
        '
        Me.TabControl_main.AllowDrop = True
        Me.TabControl_main.Controls.Add(Me.TabPage_addtask)
        Me.TabControl_main.Controls.Add(Me.TabPage_currentTasks)
        Me.TabControl_main.Controls.Add(Me.TabPage_analysis)
        Me.TabControl_main.Controls.Add(Me.TabPage_config)
        Me.TabControl_main.Location = New System.Drawing.Point(1, 0)
        Me.TabControl_main.Name = "TabControl_main"
        Me.TabControl_main.SelectedIndex = 0
        Me.TabControl_main.Size = New System.Drawing.Size(698, 305)
        Me.TabControl_main.TabIndex = 1
        '
        'TabPage_addtask
        '
        Me.TabPage_addtask.AllowDrop = True
        Me.TabPage_addtask.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage_addtask.Controls.Add(Me.btn_slct_input_file_2)
        Me.TabPage_addtask.Controls.Add(Me.TextBox_videoInput_2)
        Me.TabPage_addtask.Controls.Add(Me.Label7)
        Me.TabPage_addtask.Controls.Add(Me.btn_slct_input_file)
        Me.TabPage_addtask.Controls.Add(Me.btn_slct_output_file)
        Me.TabPage_addtask.Controls.Add(Me.NumericUpDown_nbFrames)
        Me.TabPage_addtask.Controls.Add(Me.Label4)
        Me.TabPage_addtask.Controls.Add(Me.NumericUpDown_offset)
        Me.TabPage_addtask.Controls.Add(Me.Label3)
        Me.TabPage_addtask.Controls.Add(Me.btn_addTask)
        Me.TabPage_addtask.Controls.Add(Me.Label2)
        Me.TabPage_addtask.Controls.Add(Me.ComboBox_format)
        Me.TabPage_addtask.Controls.Add(Me.Label_outputFile)
        Me.TabPage_addtask.Controls.Add(Me.TextBox_videoOutput)
        Me.TabPage_addtask.Controls.Add(Me.TextBox_videoInput)
        Me.TabPage_addtask.Controls.Add(Me.btn_analyse)
        Me.TabPage_addtask.Controls.Add(Me.Label_inputFile)
        Me.TabPage_addtask.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_addtask.Name = "TabPage_addtask"
        Me.TabPage_addtask.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_addtask.Size = New System.Drawing.Size(690, 279)
        Me.TabPage_addtask.TabIndex = 0
        Me.TabPage_addtask.Text = "Add task"
        '
        'btn_slct_input_file_2
        '
        Me.btn_slct_input_file_2.BackgroundImage = CType(resources.GetObject("btn_slct_input_file_2.BackgroundImage"), System.Drawing.Image)
        Me.btn_slct_input_file_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_slct_input_file_2.FlatAppearance.BorderSize = 0
        Me.btn_slct_input_file_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_slct_input_file_2.Location = New System.Drawing.Point(440, 50)
        Me.btn_slct_input_file_2.Name = "btn_slct_input_file_2"
        Me.btn_slct_input_file_2.Size = New System.Drawing.Size(27, 21)
        Me.btn_slct_input_file_2.TabIndex = 18
        Me.btn_slct_input_file_2.UseVisualStyleBackColor = True
        '
        'TextBox_videoInput_2
        '
        Me.TextBox_videoInput_2.AllowDrop = True
        Me.TextBox_videoInput_2.BackColor = System.Drawing.Color.White
        Me.TextBox_videoInput_2.Location = New System.Drawing.Point(95, 51)
        Me.TextBox_videoInput_2.Name = "TextBox_videoInput_2"
        Me.TextBox_videoInput_2.Size = New System.Drawing.Size(337, 20)
        Me.TextBox_videoInput_2.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "(2nd Input file) : "
        '
        'btn_slct_input_file
        '
        Me.btn_slct_input_file.BackgroundImage = CType(resources.GetObject("btn_slct_input_file.BackgroundImage"), System.Drawing.Image)
        Me.btn_slct_input_file.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_slct_input_file.FlatAppearance.BorderSize = 0
        Me.btn_slct_input_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_slct_input_file.Location = New System.Drawing.Point(440, 25)
        Me.btn_slct_input_file.Name = "btn_slct_input_file"
        Me.btn_slct_input_file.Size = New System.Drawing.Size(27, 21)
        Me.btn_slct_input_file.TabIndex = 15
        Me.btn_slct_input_file.UseVisualStyleBackColor = True
        '
        'btn_slct_output_file
        '
        Me.btn_slct_output_file.BackgroundImage = CType(resources.GetObject("btn_slct_output_file.BackgroundImage"), System.Drawing.Image)
        Me.btn_slct_output_file.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_slct_output_file.FlatAppearance.BorderSize = 0
        Me.btn_slct_output_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_slct_output_file.Location = New System.Drawing.Point(440, 76)
        Me.btn_slct_output_file.Name = "btn_slct_output_file"
        Me.btn_slct_output_file.Size = New System.Drawing.Size(27, 21)
        Me.btn_slct_output_file.TabIndex = 14
        Me.btn_slct_output_file.UseVisualStyleBackColor = True
        '
        'NumericUpDown_nbFrames
        '
        Me.NumericUpDown_nbFrames.Location = New System.Drawing.Point(365, 149)
        Me.NumericUpDown_nbFrames.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDown_nbFrames.Name = "NumericUpDown_nbFrames"
        Me.NumericUpDown_nbFrames.Size = New System.Drawing.Size(67, 20)
        Me.NumericUpDown_nbFrames.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nb frames (0 for all) : "
        '
        'NumericUpDown_offset
        '
        Me.NumericUpDown_offset.Location = New System.Drawing.Point(365, 123)
        Me.NumericUpDown_offset.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_offset.Name = "NumericUpDown_offset"
        Me.NumericUpDown_offset.Size = New System.Drawing.Size(67, 20)
        Me.NumericUpDown_offset.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Offset (s) : "
        '
        'btn_addTask
        '
        Me.btn_addTask.BackColor = System.Drawing.Color.LightBlue
        Me.btn_addTask.Location = New System.Drawing.Point(619, 245)
        Me.btn_addTask.Name = "btn_addTask"
        Me.btn_addTask.Size = New System.Drawing.Size(65, 28)
        Me.btn_addTask.TabIndex = 9
        Me.btn_addTask.Text = "Add Task"
        Me.btn_addTask.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Format : "
        '
        'ComboBox_format
        '
        Me.ComboBox_format.FormattingEnabled = True
        Me.ComboBox_format.Items.AddRange(New Object() {"Do not change format", "DVVideo", "libx264", "ProRes", "Jpeg2000", "MPEG4", "AMV", "RawVideo"})
        Me.ComboBox_format.Location = New System.Drawing.Point(275, 189)
        Me.ComboBox_format.Name = "ComboBox_format"
        Me.ComboBox_format.Size = New System.Drawing.Size(157, 21)
        Me.ComboBox_format.TabIndex = 7
        '
        'Label_outputFile
        '
        Me.Label_outputFile.AutoSize = True
        Me.Label_outputFile.Location = New System.Drawing.Point(25, 80)
        Me.Label_outputFile.Name = "Label_outputFile"
        Me.Label_outputFile.Size = New System.Drawing.Size(64, 13)
        Me.Label_outputFile.TabIndex = 4
        Me.Label_outputFile.Text = "Output file : "
        '
        'TextBox_videoOutput
        '
        Me.TextBox_videoOutput.BackColor = System.Drawing.Color.White
        Me.TextBox_videoOutput.Location = New System.Drawing.Point(95, 77)
        Me.TextBox_videoOutput.Name = "TextBox_videoOutput"
        Me.TextBox_videoOutput.Size = New System.Drawing.Size(337, 20)
        Me.TextBox_videoOutput.TabIndex = 3
        '
        'TextBox_videoInput
        '
        Me.TextBox_videoInput.AllowDrop = True
        Me.TextBox_videoInput.BackColor = System.Drawing.Color.White
        Me.TextBox_videoInput.Location = New System.Drawing.Point(95, 26)
        Me.TextBox_videoInput.Name = "TextBox_videoInput"
        Me.TextBox_videoInput.Size = New System.Drawing.Size(337, 20)
        Me.TextBox_videoInput.TabIndex = 0
        '
        'btn_analyse
        '
        Me.btn_analyse.BackColor = System.Drawing.Color.LightBlue
        Me.btn_analyse.Location = New System.Drawing.Point(496, 21)
        Me.btn_analyse.Name = "btn_analyse"
        Me.btn_analyse.Size = New System.Drawing.Size(124, 28)
        Me.btn_analyse.TabIndex = 2
        Me.btn_analyse.Text = "Analyse (coming soon)"
        Me.btn_analyse.UseVisualStyleBackColor = False
        '
        'Label_inputFile
        '
        Me.Label_inputFile.AutoSize = True
        Me.Label_inputFile.Location = New System.Drawing.Point(33, 29)
        Me.Label_inputFile.Name = "Label_inputFile"
        Me.Label_inputFile.Size = New System.Drawing.Size(56, 13)
        Me.Label_inputFile.TabIndex = 1
        Me.Label_inputFile.Text = "Input file : "
        '
        'fileSelecter
        '
        Me.fileSelecter.FileName = "OpenFileDialog1"
        '
        'Timer_tasks
        '
        Me.Timer_tasks.Enabled = True
        Me.Timer_tasks.Interval = 5000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMING SOON"
        '
        'Main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(696, 302)
        Me.Controls.Add(Me.TabControl_main)
        Me.Controls.Add(Me.myVideoEditor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "My Video Editor"
        CType(Me.myVideoEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_config.ResumeLayout(False)
        Me.TabPage_config.PerformLayout()
        Me.TabPage_analysis.ResumeLayout(False)
        Me.TabPage_analysis.PerformLayout()
        Me.TabPage_currentTasks.ResumeLayout(False)
        Me.TabControl_main.ResumeLayout(False)
        Me.TabPage_addtask.ResumeLayout(False)
        Me.TabPage_addtask.PerformLayout()
        CType(Me.NumericUpDown_nbFrames, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_offset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents myVideoEditor As AxmyVideoEditorLib.AxmyVideoEditor
    Friend WithEvents TabPage_config As System.Windows.Forms.TabPage
    Friend WithEvents label_ffmpegPath As System.Windows.Forms.Label
    Friend WithEvents TextBox_ffmpegPath As System.Windows.Forms.TextBox
    Friend WithEvents TabPage_analysis As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_currentTasks As System.Windows.Forms.TabPage
    Friend WithEvents ListView_tasks As System.Windows.Forms.ListView
    Friend WithEvents Column_source As System.Windows.Forms.ColumnHeader
    Friend WithEvents Column_dest As System.Windows.Forms.ColumnHeader
    Friend WithEvents Column_state As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabControl_main As System.Windows.Forms.TabControl
    Friend WithEvents btn_apply_config As System.Windows.Forms.Button
    Friend WithEvents TabPage_addtask As System.Windows.Forms.TabPage
    Friend WithEvents NumericUpDown_offset As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_addTask As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_format As System.Windows.Forms.ComboBox
    Friend WithEvents Label_outputFile As System.Windows.Forms.Label
    Friend WithEvents TextBox_videoOutput As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_videoInput As System.Windows.Forms.TextBox
    Friend WithEvents btn_analyse As System.Windows.Forms.Button
    Friend WithEvents Label_inputFile As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_nbFrames As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fileSelecter As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_slct_input_file As System.Windows.Forms.Button
    Friend WithEvents btn_slct_output_file As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_initialOutputFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_initialInputFolder As System.Windows.Forms.TextBox
    Friend WithEvents btn_slctInitialOutputFolder As System.Windows.Forms.Button
    Friend WithEvents btn_slctInitialInputFolder As System.Windows.Forms.Button
    Friend WithEvents btn_slctFFmpegPath As System.Windows.Forms.Button
    Friend WithEvents folderSelecter As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btn_slct_input_file_2 As System.Windows.Forms.Button
    Friend WithEvents TextBox_videoInput_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer_tasks As System.Windows.Forms.Timer
    Friend WithEvents Column_cmd As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListBox_debug As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

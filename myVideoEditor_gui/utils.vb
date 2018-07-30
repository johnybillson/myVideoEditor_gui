Imports Microsoft.Win32

Module utils
    Dim rk As RegistryKey = My.Computer.Registry.CurrentUser.CreateSubKey("myVideoEditor")

    Public Sub setKeyValue(ByVal key As String, ByVal subKey As String, ByVal defaultValue As String)
        Dim subRegKey As RegistryKey = rk.CreateSubKey(key)
        subRegKey.SetValue(subKey, defaultValue)
    End Sub

    Public Function getKeyValue(ByVal key As String, ByVal subKey As String, ByVal defaultValue As String)
        Dim subRegKey As RegistryKey = rk.CreateSubKey(key)
        Return subRegKey.GetValue(subKey, defaultValue)
    End Function

    Public Function procExists(ByVal procID As Integer) As Boolean
        If procID = -1 Then Return False
        For Each Process As Process In Process.GetProcesses()
            If Process.Id = procID Then Return True
        Next
        Return False
    End Function
End Module

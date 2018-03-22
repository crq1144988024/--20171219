Module UserLoginPara
    Public g_UserLoginPara As T_UserLoginPara
    Structure T_UserLoginPara
        Dim LastUsername As Integer
        Dim Username() As String
        Dim Password() As String
        Public Sub Init()
            ReDim Username(20)
            ReDim Password(20)
            Dim i As Integer
            For i = 0 To 20
                g_UserLoginPara.Username(i) = "1"
                g_UserLoginPara.Password(i) = "1"
            Next
        End Sub
    End Structure
    Public Function ReadUserLoginPara() As Boolean
        Dim filenum As Integer
        If System.IO.File.Exists(Application.StartupPath() & "\Login.ulp") = False Then
            Return False
        Else
            filenum = FreeFile()
            FileOpen(filenum, Application.StartupPath() & "\Login.ulp", OpenMode.Binary, , , Len(g_UserLoginPara))
            FileGet(filenum, g_UserLoginPara, 1)
            FileClose(filenum)
            Return True
        End If
    End Function
    Public Function SaveUserLoginPara() As Boolean
        Dim filenum As Integer
        If System.IO.File.Exists(Application.StartupPath() & "\Login.ulp") = False Then
            Return False
        Else
            filenum = FreeFile()
            FileOpen(filenum, Application.StartupPath() & "\Login.ulp", OpenMode.Binary, , , Len(g_UserLoginPara))
            FilePut(filenum, g_UserLoginPara, 1)
            FileClose(filenum)
            Return True
        End If
    End Function

End Module

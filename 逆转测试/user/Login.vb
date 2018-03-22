Public Class Login
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        g_UserLoginPara.Init()
        ReadUserLoginPara()
        Dim i As Integer
        For i = 0 To 20
            If g_UserLoginPara.Username(i) <> "#" Then
                CobName.Items.Add(g_UserLoginPara.Username(i))
            End If
        Next
        CobName.SelectedIndex = g_UserLoginPara.LastUsername
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        End
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim i As Integer
        For i = 0 To 20
            If g_UserLoginPara.Username(i) = CobName.Text Then
                If g_UserLoginPara.Password(i) = TxtPassword.Text Then
                    frmMain.Show()
                    frmMain.tooluser.Text = CobName.Text
                    If CobName.Text <> "Administrator" Then
                        frmMain.ToolStripButton1.Enabled = False
                        frmMain.ToolStripButton3.Enabled = False
                        frmMain.ToolStripButton4.Enabled = False
                        frmMain.ToolStripButton5.Enabled = False
                    End If
                    g_UserLoginPara.LastUsername = CobName.SelectedIndex
                    SaveUserLoginPara()
                    frmMain.tooluser.Text = CobName.Text
                    Me.Hide()
                Else
                    MsgBox("密码输入错误！")
                End If
                Exit Sub
            End If
        Next
        MsgBox("用户名不存在！")
    End Sub
End Class
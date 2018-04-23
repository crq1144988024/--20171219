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
        frmMain.添加用户ToolStripMenuItem.Enabled = False
        frmMain.删除用户ToolStripMenuItem.Enabled = False
        frmMain.修改密码ToolStripMenuItem.Enabled = False
        frmMain.ToolStripButton2.Enabled = False
        frmMain.ToolStripButton3.Enabled = False
        frmMain.ToolStripButton4.Enabled = False
        frmMain.ToolStripButton5.Enabled = False
        frmMain.ToolStripButton7.Enabled = False
        frmMain.tooluser.Text = "默认用户"
        Me.Close()
        End
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim i As Integer
        For i = 0 To 20
            If g_UserLoginPara.Username(i) = CobName.Text Then
                If g_UserLoginPara.Password(i) = TxtPassword.Text Then

                    '  frmMain.tooluser.Text = CobName.Text
                    If CobName.Text = "Administrator" Then
                        frmMain.添加用户ToolStripMenuItem.Enabled = True
                        frmMain.删除用户ToolStripMenuItem.Enabled = True
                        frmMain.修改密码ToolStripMenuItem.Enabled = True
                        frmMain.ToolStripButton2.Enabled = True
                        frmMain.ToolStripButton3.Enabled = True
                        frmMain.ToolStripButton4.Enabled = True
                        frmMain.ToolStripButton5.Enabled = True
                        frmMain.ToolStripButton7.Enabled = True
                    Else
                        frmMain.添加用户ToolStripMenuItem.Enabled = False
                        frmMain.删除用户ToolStripMenuItem.Enabled = False
                        frmMain.修改密码ToolStripMenuItem.Enabled = False
                        frmMain.ToolStripButton2.Enabled = False
                        frmMain.ToolStripButton3.Enabled = False
                        frmMain.ToolStripButton4.Enabled = False
                        frmMain.ToolStripButton5.Enabled = False
                        frmMain.ToolStripButton7.Enabled = False
                    End If
                    g_UserLoginPara.LastUsername = CobName.SelectedIndex
                    SaveUserLoginPara()
                    frmMain.tooluser.Text = CobName.Text
                    frmMain.Show()
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
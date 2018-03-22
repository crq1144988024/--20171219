Public Class DeleteUser
    Private Sub DeleteUser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer
        For i = 1 To 20
            If g_UserLoginPara.Username(i) <> "#" Then
                ComboBox1.Items.Add(g_UserLoginPara.Username(i))
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 1 To 20
            If g_UserLoginPara.Username(i) = ComboBox1.Text Then
                If g_UserLoginPara.LastUsername <> ComboBox1.SelectedIndex + 1 Then
                    g_UserLoginPara.Username(i) = "#"
                    g_UserLoginPara.Password(i) = "#"
                    SaveUserLoginPara()

                    MsgBox("删除用户成功！")
                Else
                    MsgBox("不能删除正在登录的用户！")
                End If


            End If
        Next
        ComboBox1.Items.Clear()
        For i = 1 To 20
            If g_UserLoginPara.Username(i) <> "#" Then
                ComboBox1.Items.Add(g_UserLoginPara.Username(i))
            End If
        Next
        ComboBox1.Text = ""
    End Sub
End Class
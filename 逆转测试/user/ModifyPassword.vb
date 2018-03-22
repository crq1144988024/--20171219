Public Class ModifyPassword
    Private Sub ModifyPassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer
        For i = 0 To 20
            If g_UserLoginPara.Username(i) <> "#" Then
                ComboBox1.Items.Add(g_UserLoginPara.Username(i))
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        If TextBox3.Text = TextBox4.Text Then
            For i = 0 To 20
                If g_UserLoginPara.Username(i) = ComboBox1.Text Then
                    If g_UserLoginPara.Password(i) = TextBox2.Text Then
                        g_UserLoginPara.Password(i) = TextBox3.Text
                        SaveUserLoginPara()

                        MsgBox("新密码修改成功！")

                        TextBox2.Text = ""
                        TextBox3.Text = ""
                        TextBox4.Text = ""
                    Else

                        MsgBox("旧密码输入错误！")

                    End If
                    Exit Sub
                End If
            Next
        Else

            MsgBox("确认密码与新密码不一致！")

        End If
    End Sub
End Class
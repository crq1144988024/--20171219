Public Class AddUser
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim SuccessFlag As Boolean
        SuccessFlag = True
        If TextBox2.Text = TextBox3.Text Then
            For i = 0 To 20
                If g_UserLoginPara.Username(i) = TextBox1.Text Then
                    SuccessFlag = False

                    MsgBox("用户名已经存在！")

                End If
            Next
            If SuccessFlag = True Then
                For i = 0 To 20
                    If g_UserLoginPara.Username(i) = "#" Then
                        g_UserLoginPara.Username(i) = TextBox1.Text
                        g_UserLoginPara.Password(i) = TextBox2.Text
                        SaveUserLoginPara()

                        MsgBox("新用户添加成功！")

                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        TextBox3.Text = ""
                        Exit Sub
                    End If
                Next
            End If
        Else

            MsgBox("两次输入的密码不一致！")

        End If
    End Sub
End Class
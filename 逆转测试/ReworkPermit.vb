Public Class ReworkPermit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "123" Then
            ComboBox1.Enabled = True
        Else
            MsgBox("密码错误")
            TextBox1.Text = ""
        End If
    End Sub


    Private Sub ReworkPermit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = ""
        ComboBox1.Enabled = False
    End Sub
End Class
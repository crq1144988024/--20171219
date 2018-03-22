Public Class frmZero

    Private Sub frmZero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "2qazwsx3" Or TextBox1.Text = "2Qazwsx3" Or TextBox1.Text = "1" Then
            frmMain.ToolStripButton5.Visible = True
            Me.Close()
        Else
            MsgBox("密码错误！")
        End If
    End Sub
End Class
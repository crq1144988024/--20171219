Public Class frmcountChange
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As Integer

        frmMain.lblok.Text = okcount.Text
        frmMain.lblng.Text = ngcount.Text
        str = Val(okcount.Text) + Val(ngcount.Text)
        frmMain.lblall.Text = str
        Me.Close()
    End Sub
End Class
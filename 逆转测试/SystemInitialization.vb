Public Class SystemInitialization

    Private Sub SystemInitialization_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        ProgressBar1.Value = 30
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
InitialLable:
        Try
            Application.DoEvents()
            Call OpenConn() '刷新型号及产品参数数据库
        Catch ex As Exception
            GoTo InitialLable
        End Try
        ProgressBar1.Value = 100
        Me.Close()
    End Sub
End Class
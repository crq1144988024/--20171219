Public Class SystemInitialization
    '数据库链接
    Public DatabaseCon As New SqlClient.SqlConnection("server=JUSTPLAY-PC\SQL;DataBase=datasave1;integrated security=true")
    Private Sub SystemInitialization_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        ProgressBar1.Value = 30
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
InitialLable:
        Try
            Application.DoEvents()
            DatabaseCon.Open()
            '刷新型号及产品参数数据库
        Catch ex As Exception
            GoTo InitialLable
        End Try
        ProgressBar1.Value = 100
        DatabaseCon.Close()

        Me.Close()
    End Sub
End Class
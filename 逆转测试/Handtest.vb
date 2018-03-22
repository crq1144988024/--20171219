Imports System.Data.Linq
Imports System.Math
Imports TELib

Public Class Handtest
    Dim tempjxli As Double
    Dim tempjxjx As Double
    Dim jxliclear As Double
    Dim jxjxclear As Double

    Private Sub Handtest_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Timer1.Enabled = False
        frmMain.Timhand.Enabled = False
        frmMain.lblwy.Text = "0"
        frmMain.lblfqlleft.Text = "0"
        frmMain.lblfqlright.Text = "0"
        d2210_decel_stop(m_UseAxis, 0.1) '停止运动
    End Sub

    Private Sub Handtest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        jxjxclear = frmMain.DAQjxjx.Read
        jxliclear = frmMain.DAQjxl.Read
        frmMain.Timhand.Enabled = True
        Timer1.Enabled = True
    End Sub

    Private Sub postiverun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles postiverun.Click
        Dir1 = 1 '右移
        Call move_start()
    End Sub

    Private Sub negativerun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles negativerun.Click
        Dir1 = 0 '逆转
        Call move_start()
    End Sub

    Private Sub runstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles runstop.Click
        d2210_decel_stop(m_UseAxis, 0.1) '停止运动
    End Sub

    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        bytessend(0) = 1
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
        bytessend(0) = 0
    End Sub

    Private Sub Button4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseDown
        bytessend(2) = 1
    End Sub

    Private Sub Button4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseUp
        bytessend(2) = 0
    End Sub

    Private Sub Button6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseDown
        bytessend(4) = 1
    End Sub

    Private Sub Button6_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseUp
        bytessend(4) = 0
    End Sub

    Private Sub Button5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseDown
        bytessend(6) = 1
    End Sub

    Private Sub Button5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseUp
        bytessend(6) = 0
    End Sub

    Private Sub Button3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseDown
        bytessend(8) = 1
    End Sub

    Private Sub Button3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseUp
        bytessend(8) = 0
    End Sub

    Private Sub Button7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseDown
        bytessend(10) = 1
    End Sub

    Private Sub Button7_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseUp
        bytessend(10) = 0
    End Sub

    Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
        bytessend(1) = 1
    End Sub

    Private Sub Button2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseUp
        bytessend(1) = 0
    End Sub

    Private Sub Button12_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button12.MouseDown
        bytessend(3) = 1
    End Sub

    Private Sub Button12_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button12.MouseUp
        bytessend(3) = 0
    End Sub

    Private Sub Button10_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button10.MouseDown
        bytessend(5) = 1
    End Sub

    Private Sub Button10_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button10.MouseUp
        bytessend(5) = 0
    End Sub

    Private Sub Button9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button9.MouseDown
        bytessend(7) = 1
    End Sub

    Private Sub Button9_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button9.MouseUp
        bytessend(7) = 0
    End Sub

    Private Sub Button11_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button11.MouseDown
        bytessend(9) = 1
    End Sub

    Private Sub Button11_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button11.MouseUp
        bytessend(9) = 0
    End Sub

    Private Sub Button8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button8.MouseDown
        bytessend(11) = 1
    End Sub

    Private Sub Button8_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button8.MouseUp
        bytessend(11) = 0
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tempjxli = Abs(frmMain.DAQjxl.Read - jxliclear)

        If bytessend(7) = 1 Then
            If tempjxli > 1 Then
                tempjxli -= 1
                TextBox2.Text = Format(Val(tempjxli * Val(paranew(24)) + 20 + 18), "0.00") '18N为工装自身重力，上拉时，取相对零点时已计算工装；下拉时，力方向不一样，需人为补偿工装重力
            Else
                TextBox2.Text = Format(Val(tempjxli * 26 + 18), "0.00")
            End If
        Else
            If tempjxli > 1 Then
                tempjxli -= 1
                TextBox2.Text = Format(Val(tempjxli * Val(paranew(24)) + 20), "0.00")
            Else
                TextBox2.Text = Format(Val(tempjxli * 26), "0.00")
            End If
        End If

        Dim temppos As Double

        TextBox1.Text = ""
        temppos = frmMain.readpos
        TextBox1.Text = Format(temppos - jxjxclear, "0.000")

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        jxliclear = frmMain.DAQjxl.Read
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        jxjxclear = frmMain.DAQjxjx.Read
    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        jxjxclear = frmMain.readpos
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub
End Class
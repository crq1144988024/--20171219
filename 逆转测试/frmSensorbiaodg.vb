Public Class frmSensorbiaodg
    Dim leftfqlclear As Double '左反驱力清零相对值
    Dim rightfqlclear As Double
    Dim wyclear As Double
    Dim jxjxclear As Double
    Dim jxliclear As Double
    Dim tempfqll As Double '左反驱力
    Dim tempfqlr As Double
    Dim tempwy As Double
    Dim tempjxli As Double
    Dim tempjxjx As Double

    Private Sub frmSensorbiaodg_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Timerbd.Enabled = False
        'frmMain.ToolStripButton5.Visible = False’标定按钮
        frmMain.TimlvbofTickenable = True
        ' frmMain.Timlvbof.Enabled = True
    End Sub

    Private Sub frmSensorbiaodg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        wyzerojizhun.Text = paranew(33) '零位判断基准电压
        leftfqlcoef.Text = paranew(21) '左反驱力标定系数
        rightfqlcoef.Text = paranew(22) '右反驱力标定系数
        wycoef.Text = paranew(23) '位移标定系数
        jxlicoef.Text = paranew(24) '径向力标定系数
        jxjxcoef.Text = paranew(25) '’径向间隙标定系数
        frmMain.TimlvbofTickenable = True
        ' frmMain.Timlvbof.Enabled = False
        jxcount = 0
        Timerbd.Enabled = True
    End Sub

    Private Sub leftfqlclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leftfqlclr.Click
        leftfqlclear = frmMain.DAQfqlleft.Read
    End Sub

    Private Sub rightfqlclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rightfqlclr.Click
        rightfqlclear = frmMain.DAQfqlright.Read
    End Sub

    Private Sub wyclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wyclr.Click
        wyclear = frmMain.DAQwy.Read
    End Sub

    Private Sub jxliclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jxliclr.Click
        jxliclear = frmMain.DAQjxl.Read
    End Sub

    Private Sub jxjxclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jxjxclr.Click
        jxjxclear = frmMain.readpos
    End Sub

    Private Sub Timerbd_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerbd.Tick
        tempfqll = frmMain.DAQfqlleft.Read - leftfqlclear
        Textfqll.Text = Format(tempfqll, "0.0000")
        tempfqlr = frmMain.DAQfqlright.Read - rightfqlclear
        Textfqlr.Text = Format(tempfqlr, "0.0000")
        tempwy = frmMain.DAQwy.Read - wyclear
        Textwy.Text = Format(tempwy, "0.0000")
        tempjxli = frmMain.DAQjxl.Read - jxliclear
        Textjxli.Text = Format(tempjxli, "0.0000")

        '新传感器采用串口模块，直接读数字量
        If tempjxli > 1 Then
            tempjxli -= 1
            Textjxli_N.Text = Format(Val(tempjxli * Val(paranew(24)) + 20), "0.00")
        Else
            Textjxli_N.Text = Format(Val(tempjxli * 26), "0.00")
        End If

        Dim temppos As Double
        Dim temp_pos As Double

        TextBox1.Text = ""
        temppos = frmMain.readpos
        If temppos < 0 Or temppos > 100 Then
            temppos = 0
        End If
        Textjxjx.Text = temppos
        temp_pos = Format(temppos - jxjxclear, "0.000")
        TextBox1.Text = temp_pos

        Textfqll_N.Text = Val(Format(tempfqll * Val(leftfqlcoef.Text), "0.00"))
        Textfqlr_N.Text = Val(Format(tempfqlr * Val(rightfqlcoef.Text), "0.00"))
        Textwy_mm.Text = Val(Format(tempwy * Val(wycoef.Text), "0.00"))
        Textjxli_N.Text = Val(Format(tempjxli * Val(jxlicoef.Text), "0.00"))
        Textjxjx.Text = Val(Format(temp_pos * Val(jxjxcoef.Text), "0.00"))


        'tempjxjx = frmMain.DAQjxjx.Read - jxjxclear
        'Textjxjx.Text = Format(tempjxjx, "0.0000")
        '原来间隙位移传感器，线性不好，分段标定数
        'If tempjxjx > 0.74 Then
        '    tempjxjx -= 0.74
        '    TextBox1.Text = Format(Val(tempjxjx * Val(paranew(25)) + 0.9916), "0.000")
        'Else
        '    TextBox1.Text = Format(Val(tempjxjx * 1.34), "0.000")
        'End If
        'Dim i As Integer
        'jxvel(10) = tempjxjx
        'svel = 0
        'If jxcount >= 10 Then

        'Else
        '    jxcount += 1
        '    For i = 9 To 10 - jxcount Step -1
        '        jxvel(i) = jxvel(i + 1)
        '        svel += jxvel(i)
        '    Next
        '    tempjxjx = svel / jxcount
        'End If

        ''新换传感器，按线性对待
        'TextBox1.Text = Format(Val(tempjxjx * Val(paranew(25))), "0.000")



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        leftfql.Text = Textfqll.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        rightfql.Text = Textfqlr.Text
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        wy.Text = Textwy.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        jxli.Text = Textjxli.Text
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        jxjx.Text = Textjxjx.Text
    End Sub

    Private Sub posrun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles posrun.Click
        Dir1 = 1 '正转
        Call move_start()
    End Sub

    Private Sub negrun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles negrun.Click
        Dir1 = 0 '逆转
        Call move_start()
    End Sub

    Private Sub runstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        d2210_decel_stop(m_UseAxis, 0.1) '停止运动
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        Dim num As Integer

        num = frmMain.typesel.Items.Count
        paranew(21) = leftfqlcoef.Text
        paranew(22) = rightfqlcoef.Text
        paranew(23) = wycoef.Text
        paranew(24) = jxlicoef.Text
        paranew(25) = jxjxcoef.Text
        OpenConn()
        For i = 0 To num - 1
            GlobalVariable.PiecePARA = New DataClasses_pieceparaDataContext()

            Dim updateCust = (From cust In GlobalVariable.PiecePARA.piecepara
                              Where cust.工件类别 = frmMain.typesel.Items(i).ToString()).ToList()(0)
            updateCust.左反驱力标定 = paranew(21)
            updateCust.右反驱力标定 = paranew(22)
            updateCust.位移标定 = paranew(33)
            updateCust.径向力标定 = paranew(24)
            updateCust.零位判断基准电压 = paranew(33)
            updateCust.径向间隙标定 = paranew(25)




            Try
                GlobalVariable.PiecePARA.SubmitChanges()
            Catch
                ' Handle exception.  
            End Try
        Next
        ' MyOledbCommand.CommandText = "Update piecepara set " _
        '  & "左反驱力标定= '" & paranew(21) & "', " _
        '  & "右反驱力标定= '" & paranew(22) & "', " _
        '  & "位移标定= '" & paranew(23) & "', " _
        '  & "径向力标定= '" & paranew(24) & "', " _
        ' & "零位判断基准电压= '" & paranew(33) & "', " _
        '  & "径向间隙标定= '" & paranew(25) & "' where 工件类别 = '" & frmMain.typesel.Items(i) & "'"
        '   MyOledbCommand.Connection = OleDbConnpara
        '  MyOledbCommand.ExecuteNonQuery()

        CloseConn()
        ' frmMain.ToolStripButton5.Visible = False
        Me.Close()
    End Sub

    Private Sub wyzerojizhun_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wyzerojizhun.TextChanged
        paranew(33) = wyzerojizhun.Text
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim temppos As Double

        TextBox1.Text = ""
        temppos = frmMain.readpos
        TextBox1.Text = Format(temppos, "0.000")
    End Sub

    Private Sub negrun_MouseDown(sender As Object, e As MouseEventArgs) Handles negrun.MouseDown
        Dir1 = 0 '逆转
        Call move_start()
    End Sub

    Private Sub negrun_MouseUp(sender As Object, e As MouseEventArgs) Handles negrun.MouseUp
        d2210_decel_stop(m_UseAxis, 0.1) '停止运动
    End Sub

    Private Sub posrun_MouseDown(sender As Object, e As MouseEventArgs) Handles posrun.MouseDown
        Dir1 = 1 '右移
        Call move_start()
    End Sub

    Private Sub posrun_MouseUp(sender As Object, e As MouseEventArgs) Handles posrun.MouseUp
        d2210_decel_stop(m_UseAxis, 0.1) '停止运动
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Dim temppos As Double

        If temppos < 0 Or temppos > 100 Then
            temppos = 0
        End If
        temppos = frmMain.readpos

        jxjx.Text = Format(temppos, "0.000")
    End Sub
End Class
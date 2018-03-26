Imports System.IO
Imports System.Data.OleDb  'Therrasim Librarite e OLEDB

Public Class frmPreferset

    Private Sub frmPreferset_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If frmMain.typesel.Text = prefpiecetype Then
            Call OpenConn()
            database.DataGridView1.DataSource = GlobalVariable.Datatable_para
            ''  database.DataGridView1.DataSource = MyDataSet.Tables(0)
            Call readparanew(prefpiecetype)
            jianxicheckinte = Val(paranew(17)) '间隙检测，频率直接变成间隔，频率需要知道总产量，现场商榷
            Call setparamainagan()
            Call CloseConn()
            'Select Case paranew(34)
            '    Case "1"
            '        bytessend(23) = 1
            '        bytessend(24) = 0
            '        bytessend(25) = 0
            '        bytessend(26) = 0
            '    Case "2"
            '        bytessend(24) = 1
            '        bytessend(23) = 0
            '        bytessend(25) = 0
            '        bytessend(26) = 0
            '    Case "3"
            '        bytessend(25) = 1
            '        bytessend(24) = 0
            '        bytessend(23) = 0
            '        bytessend(26) = 0
            '    Case "4"
            '        bytessend(26) = 1
            '        bytessend(24) = 0
            '        bytessend(25) = 0
            '        bytessend(23) = 0
            'End Select
        End If
    End Sub

    '赋值操作-主界面
    Public Sub setparamainagan()
        Dim db As DataGridView = frmMain.datatest
        Dim i As Integer
        Dim t As Integer = 1

        For i = 0 To 3
            db.Rows(i).Cells(1).Value = "   " & Trim(paranew(i + t))
            db.Rows(i).Cells(2).Value = "   " & Trim(paranew(i + t + 1))
            t += 1
        Next i
        t = 1
        For i = 5 To 8
            db.Rows(i).Cells(1).Value = "   " & Trim(paranew(i - 5 + t))
            db.Rows(i).Cells(2).Value = "   " & Trim(paranew(i - 5 + t + 1))
            t += 1
        Next i
        db.Rows(4).Cells(1).Value = "   " & Trim(paranew(11))
        db.Rows(4).Cells(2).Value = "   " & Trim(paranew(12))
        db.Rows(9).Cells(1).Value = "   " & Trim(paranew(11))
        db.Rows(9).Cells(2).Value = "   " & Trim(paranew(12))
        db.Rows(10).Cells(1).Value = "   " & Trim(paranew(9))
        db.Rows(10).Cells(2).Value = "   " & Trim(paranew(10))
        db.Rows(11).Cells(1).Value = "   " & Trim(paranew(35))
        db.Rows(11).Cells(2).Value = "   " & Trim(paranew(36))
        db.Rows(12).Cells(1).Value = "   " & Trim(paranew(13))
        db.Rows(12).Cells(2).Value = "   " & Trim(paranew(14))
        db.Rows(13).Cells(1).Value = "   " & Trim(paranew(15))
        db.Rows(13).Cells(2).Value = "   " & Trim(paranew(16))
        db.Rows(14).Cells(1).Value = "   " & Trim(paranew(13))
        db.Rows(14).Cells(2).Value = "   " & Trim(paranew(14))
        db.Rows(15).Cells(1).Value = "   " & Trim(paranew(15))
        db.Rows(15).Cells(2).Value = "   " & Trim(paranew(16))
    End Sub

    Private Sub frmPreferset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        d2210_decel_stop(m_UseAxis, 0.1) '停止运动
        If Paraset.RowCount < 1 Then
            For i = 0 To 8
                Paraset.Rows.Add()
            Next i
        End If
        Paraset.Rows(0).Cells(0).Value = "反驱力最大值"
        Paraset.Rows(1).Cells(0).Value = "反驱力最小值"
        Paraset.Rows(2).Cells(0).Value = "反驱力波动量"
        Paraset.Rows(3).Cells(0).Value = "反驱力平均值"
        Paraset.Rows(5).Cells(0).Value = "反驱动位移"
        Paraset.Rows(4).Cells(0).Value = "左右波动量差值"
        Paraset.Rows(6).Cells(0).Value = "齿条径向间隙"
        Paraset.Rows(7).Cells(0).Value = "齿条径向力"
        Paraset.Rows(8).Cells(0).Value = "左右反驱力平均值差值"
        For i = 0 To 8
            If i = 5 Or i = 6 Then
                Paraset.Rows(i).Cells(3).Value = "      mm"
            Else
                Paraset.Rows(i).Cells(3).Value = "      N"
            End If
        Next i
        TextBox10.Text = ""
        TextBox18.Text = ""
        GroupBox2.Visible = False
        GroupBox2.Enabled = False

        SetPrefer.Visible = False
        GroupBox1.Visible = False
        GroupBox3.Visible = False
        Call OpenConn()
        '' database.DataGridView1.DataSource = MyDataSet.Tables(0)
        database.DataGridView1.DataSource = GlobalVariable.Datatable_para
        countpiecepara = database.DataGridView1.RowCount - 1
        piecetype.Items.Clear()
        For i = 0 To countpiecepara - 1
            piecetype.Items.Add(database.DataGridView1.Rows(i).Cells(0).Value)
        Next i
        Call CloseConn()
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        prefpiecetype = piecetype.SelectedItem
        Call deletepiecetype(prefpiecetype)
        OpenConn()
        '' database.DataGridView1.DataSource = MyDataSet.Tables(0)
        database.DataGridView1.DataSource = GlobalVariable.Datatable_para
        piecetype.Items.Clear()
        frmMain.typesel.Items.Clear()
        countpiecepara = database.DataGridView1.RowCount - 1
        For i = 0 To countpiecepara - 1
            piecetype.Items.Add(database.DataGridView1.Rows(i).Cells(0).Value)
            frmMain.typesel.Items.Add(database.DataGridView1.Rows(i).Cells(0).Value)
        Next
        piecetype.Text = piecetype.Items(0)
        prefpiecetype = piecetype.Text
        CloseConn()
    End Sub

    Private Sub Addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addnew.Click
        Dim i As Integer
        Dim filenum As String
        Dim mysw As System.IO.StreamWriter

        If TextBox1.Text <> "" Then
            prefpiecetype = TextBox1.Text


            OpenConn()
            database.DataGridView1.DataSource = GlobalVariable.Datatable_para
            '' database.DataGridView1.DataSource = MyDataSet.Tables(0)
            piecetype.Items.Clear()
            frmMain.typesel.Items.Clear()
            countpiecepara = database.DataGridView1.RowCount - 1
            For i = 0 To countpiecepara - 1
                piecetype.Items.Add(database.DataGridView1.Rows(i).Cells(0).Value)
                frmMain.typesel.Items.Add(database.DataGridView1.Rows(i).Cells(0).Value)
            Next
            CloseConn()
            Call writeparanew()
            Call writeadvparanew()
            piecetype.Text = prefpiecetype
            TextBox1.Text = ""
        End If
        filenum = Apppath & "\Sys\" & prefpiecetype & ".txt"
        If Dir(filenum) <> "" Then File.Delete(filenum)
        mysw = New System.IO.StreamWriter(filenum, True)
        mysw.WriteLine(0)
        mysw.WriteLine(0)
        mysw.WriteLine(0)
        mysw.Close()
    End Sub

    Private Sub piecetype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piecetype.SelectedIndexChanged
        prefpiecetype = piecetype.SelectedItem
        Call OpenConn()
        '' database.DataGridView1.DataSource = MyDataSet.Tables(0)
        database.DataGridView1.DataSource = GlobalVariable.Datatable_para
        Call readparanew(prefpiecetype)
        Call setpara()
        Call CloseConn()
    End Sub

    Private Sub parasave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parasave.Click
        Dim i As Integer
        Dim t As Integer = 1

        For i = 0 To 7
            paranew(i + t) = Trim(Paraset.Rows(i).Cells(1).Value)
            paranew(i + t + 1) = Trim(Paraset.Rows(i).Cells(2).Value)
            t += 1
        Next i
        paranew(35) = Trim(Paraset.Rows(8).Cells(1).Value)
        paranew(36) = Trim(Paraset.Rows(8).Cells(2).Value)
        If ComboBox2.Text = "关闭" Then
            paranew(47) = 0
        Else
            paranew(47) = 1
        End If
        Call writeparanew()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox10.Text = "2qazwsx3" Or TextBox10.Text = "123" Then
            SetPrefer.Visible = True
            GroupBox1.Visible = True
            GroupBox3.Visible = True

        Else
            MsgBox("密码错误，请重新输入", vbOKOnly, "密码错误")
            TextBox10.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Val(fqlcoef.Text) = 0 Then
            MsgBox("反驱力调整系数应大于0", vbOKOnly, "超出范围")
            fqlcoef.Text = "1"
            Exit Sub
        End If
        paranew(26) = Trim(TextBox11.Text)
        paranew(27) = Trim(TextBox12.Text)
        paranew(28) = Trim(TextBox13.Text)
        paranew(30) = Trim(TextBox2.Text)
        paranew(37) = Trim(TextBox3.Text)
        paranew(38) = Trim(TextBox4.Text)
        paranew(39) = Trim(TextBox5.Text)
        paranew(40) = Trim(TextBox6.Text)
        paranew(41) = Trim(TextBox7.Text)
        paranew(42) = Trim(TextBox8.Text)
        paranew(31) = Trim(fqlcoef.Text)
        paranew(32) = Trim(jxexpcoef.Text)
        paranew(43) = Trim(TextBox14.Text)
        paranew(44) = Trim(TextBox9.Text)
        paranew(46) = Trim(TextBox15.Text)
        paranew(48) = Trim(TextBox16.Text)
        paranew(49) = Trim(TextBox17.Text)
        If ComboBox1.Text = "关闭" Then
            paranew(45) = 0
        Else
            paranew(45) = 1
        End If
        Call writeadvparanew()
        GroupBox2.Visible = False
        GroupBox2.Enabled = False
    End Sub

    'Private Sub TextBox11_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress
    '    If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
    '        If e.KeyChar = "." And InStr(TextBox11.Text, ".") > 0 Then
    '            e.Handled = True
    '        Else
    '            e.Handled = False
    '        End If
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub TextBox12_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox12.KeyPress
    '    If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
    '        If e.KeyChar = "." And InStr(TextBox12.Text, ".") > 0 Then
    '            e.Handled = True
    '        Else
    '            e.Handled = False
    '        End If
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub TextBox13_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox13.KeyPress
    '    If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
    '        If e.KeyChar = "." And InStr(TextBox13.Text, ".") > 0 Then
    '            e.Handled = True
    '        Else
    '            e.Handled = False
    '        End If
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub TextBox2_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(TextBox2.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub fqlcoef_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fqlcoef.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(fqlcoef.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub jxexpcoef_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles jxexpcoef.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(jxexpcoef.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub runspeed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles runspeed.TextChanged
        If Val(runspeed.Text) > 2 Then
            MsgBox("运行速度应小于2cm/s", vbOKOnly, "超出范围")
            runspeed.Text = "2"
        End If
        paranew(18) = Trim(runspeed.Text)
    End Sub

    Private Sub runspeed_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles runspeed.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(runspeed.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textbox14_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox14.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(runspeed.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textbox15_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox15.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(runspeed.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub freqjx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles freqjx.TextChanged
        If Val(freqjx.Text) >= 1 And Val(freqjx.Text) <= 10000 Then
        Else
            MsgBox("间隙检测频率为1~100%", vbOKOnly, "超出范围")
            freqjx.Text = "1"
        End If
        paranew(17) = Trim(freqjx.Text)
        cotjianxi = 0
    End Sub

    Private Sub freqjx_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles freqjx.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(freqjx.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub turnload_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles turnload.TextChanged
        If Val(turnload.Text) > 400 Then
            MsgBox("换向力应小于400N", vbOKOnly, "超出范围")
            turnload.Text = "400"
        End If
        paranew(19) = Trim(turnload.Text)
    End Sub

    Private Sub turnload_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles turnload.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(turnload.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub maxturnload_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maxturnload.TextChanged
        If Val(maxturnload.Text) > 1800 Then
            MsgBox("最大换向力应小于1800N", vbOKOnly, "超出范围")
            maxturnload.Text = "1800"
        End If
        paranew(29) = Trim(maxturnload.Text)
    End Sub

    Private Sub maxturnload_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles maxturnload.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(maxturnload.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub fqlcoef_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fqlcoef.TextChanged
        If Val(fqlcoef.Text) > 1 Or Val(fqlcoef.Text) < 0 Then
            MsgBox("反驱力调整系数大于0且不超过1", vbOKOnly, "超出范围")
            fqlcoef.Text = "1"
        End If
        paranew(31) = Trim(fqlcoef.Text)
    End Sub

    Private Sub jxexpcoef_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jxexpcoef.TextChanged
        If Val(jxexpcoef.Text) > 1 Or Val(jxexpcoef.Text) < 0 Then
            MsgBox("间隙检测调整系数大于0且不超过1", vbOKOnly, "超出范围")
            jxexpcoef.Text = "1"
        End If
        paranew(32) = Trim(jxexpcoef.Text)
    End Sub

    '赋值操作-参数设置界面
    Public Sub setpara()
        Dim db As DataGridView = Paraset
        Dim i As Integer
        Dim t As Integer = 1

        For i = 0 To 7
            db.Rows(i).Cells(1).Value = Trim(paranew(i + t))
            db.Rows(i).Cells(2).Value = Trim(paranew(i + t + 1))
            t += 1
        Next i
        db.Rows(8).Cells(1).Value = Trim(paranew(35))
        db.Rows(8).Cells(2).Value = Trim(paranew(36))
        freqjx.Text = Trim(paranew(17))
        runspeed.Text = Trim(paranew(18))
        turnload.Text = Trim(paranew(19))
        maxturnload.Text = Trim(paranew(29))
        TextBox11.Text = paranew(26)
        TextBox12.Text = paranew(27)
        TextBox13.Text = paranew(28)
        TextBox2.Text = paranew(30)
        fqlcoef.Text = paranew(31)
        jxexpcoef.Text = paranew(32)
        jxposition.Text = paranew(34)
        TextBox3.Text = paranew(37)
        TextBox4.Text = paranew(38)
        TextBox5.Text = paranew(39)
        TextBox6.Text = paranew(40)
        TextBox7.Text = paranew(41)
        TextBox8.Text = paranew(42)
        TextBox14.Text = paranew(43)
        TextBox9.Text = paranew(44)
        TextBox15.Text = paranew(46)
        If paranew(45) = 0 Then
            ComboBox1.SelectedIndex = 1
        Else
            ComboBox1.SelectedIndex = 0
        End If
        ComboBox2.SelectedIndex = Val(paranew(47))
        TextBox16.Text = paranew(48)
        TextBox17.Text = paranew(49)
    End Sub

    '工件类别删除
    Public Sub deletepiecetype(ByVal petype As String)
        '' OpenConn()


        GlobalVariable.PiecePARA = New DataClasses_pieceparaDataContext()

        Dim deleteCust = (From cust In GlobalVariable.PiecePARA.piecepara
                          Where cust.工件类别 = prefpiecetype).ToList()(0)

        GlobalVariable.PiecePARA.piecepara.DeleteOnSubmit(deleteCust)

        Try
            GlobalVariable.PiecePARA.SubmitChanges()
        Catch
            ' Handle exception.  
        End Try



        '' MyOledbCommand.CommandText = "Delete From piecepara where 工件类别 = '" & prefpiecetype & "'"
        'MyOledbCommand.Connection = OleDbConnpara
        'MyOledbCommand.ExecuteNonQuery()
        CloseConn()
    End Sub

    '参数存储
    Public Sub writeparanew()

        GlobalVariable.PiecePARA = New DataClasses_pieceparaDataContext()

        Dim updateCust = (From cust In GlobalVariable.PiecePARA.piecepara
                          Where cust.工件类别 = prefpiecetype).ToList()(0)

        updateCust.反驱力最大值上限 = paranew(1)
        updateCust.反驱力最大值下限 = paranew(2)
        updateCust.反驱力最小值上限 = paranew(3)
        updateCust.反驱力最小值下限 = paranew(4)
        updateCust.反驱力波动量上限 = paranew(5)
        updateCust.反驱力波动量下限 = paranew(6)
        updateCust.反驱力平均值上限 = paranew(7)
        updateCust.反驱力平均值下限 = paranew(8)
        updateCust.左右波动量差值上限 = paranew(9)
        updateCust.左右波动量差值下限 = paranew(10)
        updateCust.反驱动位移上限 = paranew(11)
        updateCust.反驱动位移下限 = paranew(12)
        updateCust.齿条径向间隙上限 = paranew(13)
        updateCust.齿条径向间隙下限 = paranew(14)
        updateCust.齿条径向力上限 = paranew(15)
        updateCust.齿条径向力下限 = paranew(16)
        updateCust.间隙检测抽检间隔 = paranew(17)
        updateCust.测试速度 = paranew(18)
        updateCust.换向力 = paranew(19)
        updateCust.最大换向力 = paranew(29)
        updateCust.扫条码使能 = paranew(20)

        updateCust.左反驱力标定 = paranew(21)
        updateCust.右反驱力标定 = paranew(22)
        updateCust.位移标定 = paranew(23)
        updateCust.径向力标定 = paranew(24)
        updateCust.零位判断基准电压 = paranew(33)
        updateCust.间隙检测位置 = paranew(34)
        updateCust.左右平均力差值上限 = paranew(35)
        updateCust.左右平均力差值下限 = paranew(36)
        updateCust.中位记号笔使能 = paranew(47)
        updateCust.径向间隙标定 = paranew(25)

        Try
            GlobalVariable.PiecePARA.SubmitChanges()
        Catch
            ' Handle exception.  
        End Try
        Return
        OpenConn()
        MyOledbCommand.CommandText = "Update piecepara set " _
        & "反驱力最大值上限= '" & paranew(1) & "', " _
        & "反驱力最大值下限= '" & paranew(2) & "', " _
        & "反驱力最小值上限= '" & paranew(3) & "', " _
        & "反驱力最小值下限= '" & paranew(4) & "', " _
        & "反驱力波动量上限= '" & paranew(5) & "', " _
        & "反驱力波动量下限= '" & paranew(6) & "', " _
        & "反驱力平均值上限= '" & paranew(7) & "', " _
        & "反驱力平均值下限= '" & paranew(8) & "', " _
        & "左右波动量差值上限= '" & paranew(9) & "', " _
        & "左右波动量差值下限= '" & paranew(10) & "', " _
        & "反驱动位移上限= '" & paranew(11) & "', " _
        & "反驱动位移下限= '" & paranew(12) & "', " _
        & "齿条径向间隙上限= '" & paranew(13) & "', " _
        & "齿条径向间隙下限= '" & paranew(14) & "', " _
        & "齿条径向力上限= '" & paranew(15) & "', " _
        & "齿条径向力下限= '" & paranew(16) & "', " _
        & "间隙检测抽检间隔= '" & paranew(17) & "', " _
        & "测试速度= '" & paranew(18) & "', " _
        & "换向力= '" & paranew(19) & "', " _
        & "最大换向力= '" & paranew(29) & "', " _
        & "扫条码使能= '" & paranew(20) & "', " _
        & "左反驱力标定= '" & paranew(21) & "', " _
        & "右反驱力标定= '" & paranew(22) & "', " _
        & "位移标定= '" & paranew(23) & "', " _
        & "径向力标定= '" & paranew(24) & "', " _
        & "零位判断基准电压= '" & paranew(33) & "', " _
        & "间隙检测位置= '" & paranew(34) & "', " _
        & "左右平均力差值上限= '" & paranew(35) & "', " _
        & "左右平均力差值下限= '" & paranew(36) & "', " _
        & "中位记号笔使能= '" & paranew(47) & "', " _
        & "径向间隙标定= '" & paranew(25) & "' where 工件类别 = '" & prefpiecetype & "'"
        MyOledbCommand.Connection = OleDbConnpara
        MyOledbCommand.ExecuteNonQuery()
        CloseConn()
    End Sub

    '高级参数存储
    Public Sub writeadvparanew()
        GlobalVariable.PiecePARA = New DataClasses_pieceparaDataContext()

        Dim updateCust = (From cust In GlobalVariable.PiecePARA.piecepara
                          Where cust.工件类别 = prefpiecetype).ToList()(0)
        updateCust.零点偏置 = paranew(26)
        updateCust.左反驱力调整 = paranew(27)
        updateCust.有效测试位移百分比 = paranew(30)
        updateCust.反驱力调整系数 = paranew(31)
        updateCust.间隙检测调整系数 = paranew(32)
        updateCust.间隙下拉力补偿参数 = paranew(37)
        updateCust.间隙上拉力补偿参数 = paranew(38)
        updateCust.下拉间隙补偿参数 = paranew(39)
        updateCust.上拉间隙补偿参数 = paranew(40)
        updateCust.超时设置 = paranew(41)
        updateCust.回中补偿电压 = paranew(42)
        updateCust.图像滤波百分比 = paranew(43)
        updateCust.阈值补偿 = paranew(44)
        updateCust.是否滤波 = paranew(45)
        updateCust.量化点数 = paranew(46)
        updateCust.右反驱位移补偿参数 = paranew(48)
        updateCust.左反驱位移补偿参数 = paranew(49)
        updateCust.右反驱力调整 = paranew(28)



        Try
            GlobalVariable.PiecePARA.SubmitChanges()
        Catch
            ' Handle exception.  
        End Try
        Return
        OpenConn()
        MyOledbCommand.CommandText = "Update piecepara set " _
        & "零点偏置= '" & paranew(26) & "', " _
        & "左反驱力调整= '" & paranew(27) & "', " _
        & "有效测试位移百分比= '" & paranew(30) & "', " _
        & "反驱力调整系数= '" & paranew(31) & "', " _
        & "间隙检测调整系数= '" & paranew(32) & "', " _
        & "间隙下拉力补偿参数= '" & paranew(37) & "', " _
        & "间隙上拉力补偿参数= '" & paranew(38) & "', " _
        & "下拉间隙补偿参数= '" & paranew(39) & "', " _
        & "上拉间隙补偿参数= '" & paranew(40) & "', " _
        & "超时设置= '" & paranew(41) & "', " _
        & "回中补偿电压= '" & paranew(42) & "', " _
        & "图像滤波百分比= '" & paranew(43) & "', " _
        & "阈值补偿= '" & paranew(44) & "', " _
        & "是否滤波= '" & paranew(45) & "', " _
        & "量化点数= '" & paranew(46) & "', " _
        & "右反驱位移补偿参数= '" & paranew(48) & "', " _
        & "左反驱位移补偿参数= '" & paranew(49) & "', " _
        & "右反驱力调整= '" & paranew(28) & "' where 工件类别 = '" & prefpiecetype & "'"
        MyOledbCommand.Connection = OleDbConnpara
        MyOledbCommand.ExecuteNonQuery()
        CloseConn()
    End Sub

    Private Sub jxposition_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jxposition.TextChanged
        paranew(34) = jxposition.Text
    End Sub

    Private Sub Button3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseDown
        bytessend(698) = 1 'PLC清除数据必需信号
    End Sub

    Private Sub Button3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseUp
        bytessend(698) = 0
    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged
        If Val(TextBox14.Text) <= 100 And Val(TextBox14.Text) >= 0 Then

        Else
            MsgBox("百分比应为介于0~100之间的整数", vbOKOnly, "超出范围")
            TextBox14.Text = 50
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        frmMain.ComboBox1.SelectedIndex = ComboBox3.SelectedIndex
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox18.Text = "123" Then
            GroupBox2.Enabled = True
            GroupBox2.Visible = True

        Else
            MsgBox("密码错误，请重新输入", vbOKOnly, "密码错误")
            TextBox18.Focus()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
Imports System.Data.OleDb  'Therrasim Librarite e OLEDB
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.ToolStripMenuItem

Public Class frmQueryData
    Dim Sqlstring As String
    Dim countdata1 As Integer
    Dim testrange(18) As String

    Private Sub frmQueryData_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Myconn.Close()
        'DelayS(0.5)
        'OleDbConnrecd.Open()
    End Sub

    Private Sub frmQueryData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' OleDbConnrecd.Close()
        'DelayS(0.5)
        ' Myconn.Open(Connstringnew)
        For i = 0 To 14
            dataRecord.Rows.Add()
        Next i
        dataRecord.Rows(0).Cells(0).Value = "右反驱力最大值"
        dataRecord.Rows(1).Cells(0).Value = "右反驱力最小值"
        dataRecord.Rows(2).Cells(0).Value = "右反驱力波动量"
        dataRecord.Rows(3).Cells(0).Value = "右反驱力平均值"
        dataRecord.Rows(4).Cells(0).Value = "右反驱动位移"
        dataRecord.Rows(5).Cells(0).Value = "左反驱力最大值"
        dataRecord.Rows(6).Cells(0).Value = "左反驱力最小值"
        dataRecord.Rows(7).Cells(0).Value = "左反驱力波动量"
        dataRecord.Rows(8).Cells(0).Value = "左反驱力平均值"
        dataRecord.Rows(9).Cells(0).Value = "左反驱动位移"
        dataRecord.Rows(10).Cells(0).Value = "左右波动量差值"
        dataRecord.Rows(11).Cells(0).Value = "左右反驱力平均值差值"
        dataRecord.Rows(12).Cells(0).Value = "上拉齿条衬套径向间隙"
        dataRecord.Rows(13).Cells(0).Value = "上拉齿条衬套径向力"
        dataRecord.Rows(14).Cells(0).Value = "下拉齿条衬套径向间隙"
        dataRecord.Rows(15).Cells(0).Value = "下拉齿条衬套径向力"
        For i = 0 To 15
            If i = 4 Or i = 9 Or i = 12 Or i = 14 Then
                dataRecord.Rows(i).Cells(4).Value = "    mm"
            Else
                dataRecord.Rows(i).Cells(4).Value = "    N"
            End If
        Next i
        'dataRecord.Rows(14).Visible = False
        Listdata.Items.Clear()
        chaxun.Axes.Bottom.SetMinMax(-100, 100)
        chaxun.Axes.Left.SetMinMax(-300, 300)
        chaxun.Axes.Left.Increment = 0.1
        chaxun.Axes.Bottom.Increment = 0.1
        chaxun.Axes.Left.Title.Caption = "反驱力 (N)"
        chaxun.Axes.Bottom.Title.Caption = "位移 (mm)"
        FastLine1.Color = Color.Maroon
        FastLine1.LinePen.Width = 1
        FastLine1.Clear()
        FastLine2.Color = Color.Maroon
        FastLine2.LinePen.Width = 1
        FastLine2.Clear()
        chaxun.Series(0).XValues.Order = Steema.TeeChart.Styles.ValueListOrder.None
        chaxun.Series(0).YValues.Order = Steema.TeeChart.Styles.ValueListOrder.None
        chaxun.Series(1).XValues.Order = Steema.TeeChart.Styles.ValueListOrder.None
        chaxun.Series(1).YValues.Order = Steema.TeeChart.Styles.ValueListOrder.None
        statime.Value = Now.Year & "-" & Now.Month & "-" & Now.Day
        endtime.Value = Now.Year & "-" & Now.Month & "-" & Now.Day
    End Sub

    Private Sub oksel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oksel.Click
        Dim i As Integer
        Dim j1 As String
        Dim j2 As String
        Dim j3 As String

        Listdata.Items.Clear()
        If statime.Value > endtime.Value Then
            MsgBox("请确保结束日期大于开始日期")
        End If
        j1 = statime.Text
        j2 = endtime.Text
        j3 = "OK"
        ''Call OpenConncx()
        ''Sqlstring = "Select * from piecedatasave where 日期>='" & j1 & "' and 日期<='" & j2 & "' and 结果='" & j3 & "'"
        ''MyRec.Open(Sqlstring, Myconn, 1, 1)
        ''countdata1 = MyRec.RecordCount - 1
        ''For i = 0 To countdata1
        ''    Listdata.Items.Add(MyRec("编号").Value)
        ''    MyRec.MoveNext()
        ''Next
        ''Call CloseConncx()

        GlobalVariable.Piecedatasave = New DataClasses_PIECEDATASAVEDataContext()
        Dim companyNameQuery = From cust In GlobalVariable.Piecedatasave.piecedatasave Where cust.日期 >= j1 AndAlso cust.日期 <= j2 AndAlso cust.结果 = j3 Select cust
        For Each customer In companyNameQuery
            Listdata.Items.Add(customer.编号)
        Next
    End Sub

    Private Sub ngsel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ngsel.Click
        Dim i As Integer
        Dim j1 As String
        Dim j2 As String
        Dim j3 As String

        Listdata.Items.Clear()
        If statime.Value > endtime.Value Then
            MsgBox("请确保结束日期大于开始日期")
        End If
        j1 = statime.Text
        j2 = endtime.Text
        j3 = "NG"
        'Call OpenConncx()
        '’Sqlstring = "Select * from piecedatasave where 日期>='" & j1 & "' and 日期<='" & j2 & "' and 结果='" & j3 & "'"
        '' MyRec.Open(Sqlstring, Myconn, 1, 1)
        '' countdata1 = MyRec.RecordCount - 1

        GlobalVariable.Piecedatasave = New DataClasses_PIECEDATASAVEDataContext()
        Dim companyNameQuery = From cust In GlobalVariable.Piecedatasave.piecedatasave Where cust.日期 >= j1 AndAlso cust.日期 <= j2 AndAlso cust.结果 = j3 Select cust
        For Each customer In companyNameQuery
            Listdata.Items.Add(customer.编号)
        Next

        'For i = 0 To countdata1
        '    Listdata.Items.Add(MyRec("编号").Value)
        '    MyRec.MoveNext()
        'Next
        'Call CloseConncx()
    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Dim i As Integer
        Dim j1 As String

        Listdata.Items.Clear()
        j1 = gjz.Text
        'Call OpenConncx()
        'Sqlstring = "Select * from piecedatasave where 日期='" & j1 & "' or 结果='" & j1 & "' or 编号='" & j1 & "'or 工件类别='" & j1 & "' or 条码='" & j1 & "'"
        'MyRec.Open(Sqlstring, Myconn, 1, 1)
        'countdata1 = MyRec.RecordCount - 1
        'For i = 0 To countdata1
        '    Listdata.Items.Add(MyRec("编号").Value)
        '    MyRec.MoveNext()
        'Next
        'Call CloseConncx()
        GlobalVariable.Piecedatasave = New DataClasses_PIECEDATASAVEDataContext()
        Dim companyNameQuery = From cust In GlobalVariable.Piecedatasave.piecedatasave Where cust.日期 = j1 OrElse cust.结果 = j1 OrElse cust.编号 = j1 OrElse cust.工件类别 = j1 OrElse cust.条码 = j1 Select cust

        For Each customer In companyNameQuery
            Listdata.Items.Add(customer.编号)
        Next
    End Sub

    Private Sub Listdata_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Listdata.SelectedIndexChanged
        Dim id As String
        Dim data(3000) As Double
        Dim filenam As String
        Dim str As String
        Dim mysr As System.IO.StreamReader
        Dim huituload() As Double '读取曲线扭矩
        Dim huitupos() As Double '曲线角度
        Dim huitudot As Integer '绘图总点数
        Dim huitudotst1 As Integer '边界点
        Dim huitudotend1 As Integer '边界点
        Dim piedatecx As String '工件保存日期
        Dim pienumbcx As String '工件保存编号
        Dim yy, mm, dd As String

        ''  Call OpenConncx()
        id = Listdata.Text '所要查询工件
        GlobalVariable.Piecedatasave = New DataClasses_PIECEDATASAVEDataContext()
        Dim companyNameQuery = From cust In GlobalVariable.Piecedatasave.piecedatasave Where cust.编号 = id Select cust
        Dim CUST_ONE As piecedatasave
        For Each customer In companyNameQuery
            CUST_ONE = customer
        Next

        ''Sqlstring = "Select * from piecedatasave where 编号='" & id & "'"
        '' MyRec.Open(Sqlstring, Myconn, 1, 1)
        '' pienumber.Text = MyRec("编号").Value
        pienumber.Text = CUST_ONE.编号
        pienumbcx = pienumber.Text
        '' piedate.Text = MyRec("日期").Value
        piedate.Text = CUST_ONE.日期
        piedatecx = piedate.Text
        yy = Mid(piedatecx, 1, 4) & "年"
        If Val(Mid(piedatecx, 6, 2)) < 10 Then
            mm = Mid(piedatecx, 7, 1) & "月"
        Else
            mm = Mid(piedatecx, 6, 2) & "月"
        End If
        If Val(Mid(piedatecx, 9, 2)) < 10 Then
            dd = Mid(piedatecx, 10, 1) & "日"
        Else
            dd = Mid(piedatecx, 9, 2) & "日"
        End If
        '' pietype.Text = MyRec("工件类别").Value
        '' pieresult.Text = MyRec("结果").Value
        pietype.Text = CUST_ONE.工件类别
        pieresult.Text = CUST_ONE.结果

        ''Dim tiao_ma As String = MyRec("条码").Value
        Dim tiao_ma As String = CUST_ONE.条码
        ''If (tiao_ma).ToString = "" Then
        If String.IsNullOrEmpty(tiao_ma) OrElse tiao_ma = "" Then
            Label6.Enabled = False
            pietm.Text = ""
        Else
            Label6.Enabled = True
            pietm.Text = tiao_ma
        End If

        Call OpenConn() '读取产品型号对应的测试项判断范围
        ' database.DataGridView1.DataSource = MyDataSet.Tables(0)
        database.DataGridView1.DataSource = GlobalVariable.Datatable_para
        Dim irow As Integer
        Dim i As Integer
        For irow = 0 To countpiecepara - 1
            If database.DataGridView1.Rows(irow).Cells(0).Value = pietype.Text Then
                Exit For
            End If
        Next irow
        For i = 0 To 16
            testrange(i) = database.DataGridView1.Rows(irow).Cells(i).Value
        Next
        testrange(17) = database.DataGridView1.Rows(irow).Cells(35).Value
        testrange(18) = database.DataGridView1.Rows(irow).Cells(36).Value
        Call CloseConn()
        ''Call setparacx()
        ''dataRecord.Rows(0).Cells(3).Value = "   " + MyRec("右反驱力最大值").Value
        ''dataRecord.Rows(1).Cells(3).Value = "   " + MyRec("右反驱力最小值").Value
        ''dataRecord.Rows(2).Cells(3).Value = "   " + MyRec("右反驱力波动量").Value
        ''dataRecord.Rows(3).Cells(3).Value = "   " + MyRec("右反驱力平均值").Value
        ''dataRecord.Rows(4).Cells(3).Value = "   " + MyRec("右反驱动位移").Value
        ''dataRecord.Rows(5).Cells(3).Value = "   " + MyRec("左反驱力最大值").Value
        ''dataRecord.Rows(6).Cells(3).Value = "   " + MyRec("左反驱力最小值").Value
        ''dataRecord.Rows(7).Cells(3).Value = "   " + MyRec("左反驱力波动量").Value
        ''dataRecord.Rows(8).Cells(3).Value = "   " + MyRec("左反驱力平均值").Value
        ''dataRecord.Rows(9).Cells(3).Value = "   " + MyRec("左反驱动位移").Value
        ''dataRecord.Rows(10).Cells(3).Value = "   " + MyRec("左右波动量差值").Value
        ''dataRecord.Rows(11).Cells(3).Value = "   " + MyRec("左右反驱力平均值差值").Value
        ''dataRecord.Rows(12).Cells(3).Value = "   " + MyRec("上拉齿条径向间隙").Value
        ''dataRecord.Rows(13).Cells(3).Value = "   " + MyRec("上拉齿条径向力").Value
        ''dataRecord.Rows(14).Cells(3).Value = "   " + MyRec("下拉齿条径向间隙").Value
        ''dataRecord.Rows(15).Cells(3).Value = "   " + MyRec("下拉齿条径向力").Value
        ''Call CloseConncx()

        dataRecord.Rows(0).Cells(3).Value = "   " + CUST_ONE.右反驱力最大值
        dataRecord.Rows(1).Cells(3).Value = "   " + CUST_ONE.右反驱力最小值
        dataRecord.Rows(2).Cells(3).Value = "   " + CUST_ONE.右反驱力波动量
        dataRecord.Rows(3).Cells(3).Value = "   " + CUST_ONE.右反驱力平均值
        dataRecord.Rows(4).Cells(3).Value = "   " + CUST_ONE.右反驱动位移
        dataRecord.Rows(5).Cells(3).Value = "   " + CUST_ONE.左反驱力最大值
        dataRecord.Rows(6).Cells(3).Value = "   " + CUST_ONE.左反驱力最小值
        dataRecord.Rows(7).Cells(3).Value = "   " + CUST_ONE.左反驱力波动量
        dataRecord.Rows(8).Cells(3).Value = "   " + CUST_ONE.左反驱力平均值
        dataRecord.Rows(9).Cells(3).Value = "   " + CUST_ONE.左反驱动位移
        dataRecord.Rows(10).Cells(3).Value = "   " + CUST_ONE.左右波动量差值
        dataRecord.Rows(11).Cells(3).Value = "   " + CUST_ONE.左右反驱力平均值差值
        dataRecord.Rows(12).Cells(3).Value = "   " + CUST_ONE.上拉齿条径向间隙
        dataRecord.Rows(13).Cells(3).Value = "   " + CUST_ONE.上拉齿条径向力
        dataRecord.Rows(14).Cells(3).Value = "   " + CUST_ONE.下拉齿条径向间隙
        dataRecord.Rows(15).Cells(3).Value = "   " + CUST_ONE.下拉齿条径向力


        FastLine1.Clear()
        FastLine2.Clear()
        filenam = Apppath & "\Sys\recorddata\" & yy & "\" & mm & "\" & dd & "\" & pienumbcx & ".txt"
        mysr = New System.IO.StreamReader(filenam, True)
        i = 0
        Do
            Dim line$ = mysr.ReadLine
            str = line
            data(i) = Val(str)
            i += 1
        Loop Until mysr.EndOfStream = True
        mysr.Close()
        huitudot = data(0)
        huitudotend1 = data(1)
        huitudotst1 = data(2)
        ReDim huituload(huitudot)
        ReDim huitupos(huitudot)
        For i = 0 To (huitudot - 1)
            huituload(i) = data(i + 3)
            huitupos(i) = data(i + 3 + huitudot)
        Next
        For i = 0 To huitudotend1 - 1
            FastLine1.Add(huitupos(i), huituload(i))
        Next
        For i = huitudotst1 To huitudot - 1
            FastLine2.Add(huitupos(i), huituload(i))
        Next
    End Sub

    '查询界面赋测试项判断范围
    Public Sub setparacx()
        Dim db As DataGridView = dataRecord
        Dim i As Integer
        Dim t As Integer = 1

        For i = 0 To 3
            db.Rows(i).Cells(1).Value = "   " & Trim(testrange(i + t))
            db.Rows(i).Cells(2).Value = "   " & Trim(testrange(i + t + 1))
            t += 1
        Next i
        t = 1
        For i = 5 To 8
            db.Rows(i).Cells(1).Value = "   " & Trim(testrange(i - 5 + t))
            db.Rows(i).Cells(2).Value = "   " & Trim(testrange(i - 5 + t + 1))
            t += 1
        Next i
        db.Rows(4).Cells(1).Value = "   " & Trim(testrange(11))
        db.Rows(4).Cells(2).Value = "   " & Trim(testrange(12))
        db.Rows(9).Cells(1).Value = "   " & Trim(testrange(11))
        db.Rows(9).Cells(2).Value = "   " & Trim(testrange(12))
        db.Rows(10).Cells(1).Value = "   " & Trim(testrange(9))
        db.Rows(10).Cells(2).Value = "   " & Trim(testrange(10))
        db.Rows(12).Cells(1).Value = "   " & Trim(testrange(13))
        db.Rows(12).Cells(2).Value = "   " & Trim(testrange(14))
        db.Rows(13).Cells(1).Value = "   " & Trim(testrange(15))
        db.Rows(13).Cells(2).Value = "   " & Trim(testrange(16))
        db.Rows(14).Cells(1).Value = "   " & Trim(testrange(13))
        db.Rows(14).Cells(2).Value = "   " & Trim(testrange(14))
        db.Rows(15).Cells(1).Value = "   " & Trim(testrange(15))
        db.Rows(15).Cells(2).Value = "   " & Trim(testrange(16))
        db.Rows(11).Cells(1).Value = "   " & Trim(testrange(17))
        db.Rows(11).Cells(2).Value = "   " & Trim(testrange(18))
    End Sub

    Private Sub pietype_TextChanged(sender As Object, e As EventArgs) Handles pietype.TextChanged

    End Sub
End Class
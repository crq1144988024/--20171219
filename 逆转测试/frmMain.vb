Imports TELib
Imports System.Windows.Forms
Imports VB = Microsoft.VisualBasic
Imports ListControls
Imports System.Math
Imports System.Threading
Imports System
Imports System.IO
Imports LdzCStation
Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.Data.OleDb  'Therrasim Librarite e OLEDB
Imports ADODB
Imports System.Data.Linq

Public Class frmMain
    Private Declare Function CreateCompatibleDC Lib "GDI32" (ByVal hDC As Integer) As Integer
    Private Declare Function csdsdsd Lib "GDI32" () As Integer

    Private Declare Function CreateCompatibleBitmap Lib "GDI32" (ByVal hDC As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer) As Integer
    Private Declare Function SelectObject Lib "GDI32" (ByVal hDC As Integer, ByVal hObject As Integer) As Integer
    Private Declare Function BitBlt Lib "GDI32" (ByVal srchDC As Integer, ByVal srcX As Integer, ByVal srcY As Integer, ByVal srcW As Integer, ByVal srcH As Integer, ByVal desthDC As Integer, ByVal destX As Integer, ByVal destY As Integer, ByVal op As Integer) As Integer
    Private Declare Function DeleteDC Lib "GDI32" (ByVal hDC As Integer) As Integer
    Private Declare Function DeleteObject Lib "GDI32" (ByVal hObj As Integer) As Integer
    Declare Function GetDC Lib "user32" Alias "GetDC" (ByVal hwnd As Integer) As Integer
    Const SRCCOPY As Integer = &HCC0020
    Private gridcolorR As Integer
    Private gridcolorG As Integer
    Private gridcolorB As Integer
    Private backcolorR As Integer
    Private backcolorG As Integer
    Private backcolorB As Integer

    Public lefytli As Double = 0
    ''' <summary>
    ''' 间隙测试使能
    ''' </summary>
    Public TestTickenable As Boolean
    ''' <summary>
    ''' '滤波处理使能
    ''' </summary>
    Public TimlvbofTickenable As Boolean
    ''' <summary>
    '''  '手动触发使能
    ''' </summary>
    Public TimHandTickenable As Boolean
    ''' <summary>
    ''' '回零使能
    ''' </summary>
    Public TimgohomezeroTickeanble As Boolean

    Dim ThreadCom As New Thread(AddressOf WaitData) '通讯线程

    Dim ThreadAcq As New Thread(AddressOf AcqAndJudge) '通讯线程
    Dim ThreadCom_displacement As New Thread(AddressOf Waitrs232Data) 'com位移传感器线程
    Private Delegate Sub voiddelegate()
    Dim s As Socket = Nothing
    Dim barcode(27) As Byte '读取条码
    Dim barcodestr As String '条码
    Dim volwy As Double '位移电压值

    Dim backzero As Integer = 0 '归零位信号
    Dim zeroflag As Integer = 0 '保证到归零位后只置为一次
    Dim zeromoveflag As Integer '动作状态，保证正反转命令只发送一次
    Dim moveright As Integer
    Dim moveleft As Integer
    Dim zerored1 As Integer
    Dim zerored2 As Integer
    Public Sub AcqAndJudge()
        While True
            Me.Invoke(New voiddelegate(AddressOf ShowAcqAndJudge))
        End While
    End Sub

    Private Sub 添加用户ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加用户ToolStripMenuItem.Click
        AddUser.ShowDialog()


    End Sub

    Private Sub 删除用户ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除用户ToolStripMenuItem.Click
        DeleteUser.ShowDialog()
    End Sub

    Private Sub 修改密码ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 修改密码ToolStripMenuItem.Click
        ModifyPassword.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        s.Close()   ' socket 通信关闭

        ThreadCom.Abort() '\通信线程关闭
        ThreadCom_displacement.Abort() '\通信线程关闭
        ThreadAcq.Abort() '\通信线程关闭
        Application.DoEvents()
        PortClose()  '串口关闭
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmQueryData.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmPreferset.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Handtest.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        frmSensorbiaodg.ShowDialog()
    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim filenum As String
        Dim mysw As System.IO.StreamWriter

        d2210_decel_stop(m_UseAxis, 0.1) '停止运动
        filenum = Apppath & "\Sys\piecetype.txt"  '产品型号
        If Dir(filenum) <> "" Then File.Delete(filenum) '如果文件存在删除此文件（产品型号）
        mysw = New System.IO.StreamWriter(filenum, True)
        mysw.WriteLine(typesel.Text)     '记录当前产品型号  text控件
        mysw.WriteLine(ComboBox1.SelectedIndex) '记录生产模式的选项
        mysw.Close()
        database.Close()
        s.Close()   ' socket 通信关闭

        ThreadCom.Abort() '\通信线程关闭
        ThreadCom_displacement.Abort() '\通信线程关闭
        ThreadAcq.Abort() '\通信线程关闭
        Application.DoEvents()
        PortClose()  '串口关闭
        ' OleDbConnpara.Close()  '关闭数据库
        ' OleDbConnpara.Dispose() '释放资源
        ' OleDbConnrecd.Close()
        ' OleDbConnrecd.Dispose()
        End
    End Sub
    Private Sub set_chart()
        FastLine1.Clear() '调整teechart图像控件
        FastLine1.Color = Color.Maroon
        FastLine1.LinePen.Width = 1
        FastLine2.Clear()
        FastLine2.Color = Color.Maroon
        FastLine2.LinePen.Width = 1
        tcCurve.Axes.Left.SetMinMax(-300, +300)
        tcCurve.Axes.Bottom.SetMinMax(-120, 120)
        tcCurve.Axes.Left.Increment = 0.1
        tcCurve.Axes.Bottom.Increment = 0.1
        tcCurve.Axes.Left.Title.Caption = "反驱力 (N)"
        tcCurve.Axes.Bottom.Title.Caption = "位移 (mm)"


        tcCurve.Series(0).XValues.Order = Steema.TeeChart.Styles.ValueListOrder.None
        tcCurve.Series(0).YValues.Order = Steema.TeeChart.Styles.ValueListOrder.None
        tcCurve.Series(1).XValues.Order = Steema.TeeChart.Styles.ValueListOrder.None
        tcCurve.Series(1).YValues.Order = Steema.TeeChart.Styles.ValueListOrder.None
    End Sub
    Private Sub set_initialize_datagridview_now()
        For i = 0 To 14
            datatest.Rows.Add()   '添加14行空行
        Next i
        datatest.Rows(0).Cells(0).Value = "右反驱力最大值"
        datatest.Rows(1).Cells(0).Value = "右反驱力最小值"
        datatest.Rows(2).Cells(0).Value = "右反驱力波动量"
        datatest.Rows(3).Cells(0).Value = "右反驱力平均值"
        datatest.Rows(4).Cells(0).Value = "右反驱动位移"
        datatest.Rows(5).Cells(0).Value = "左反驱力最大值"
        datatest.Rows(6).Cells(0).Value = "左反驱力最小值"
        datatest.Rows(7).Cells(0).Value = "左反驱力波动量"
        datatest.Rows(8).Cells(0).Value = "左反驱力平均值"
        datatest.Rows(9).Cells(0).Value = "左反驱动位移"
        datatest.Rows(10).Cells(0).Value = "左右波动量差值"
        datatest.Rows(11).Cells(0).Value = "左右反驱力平均值差值"
        datatest.Rows(12).Cells(0).Value = "上拉齿条衬套径向间隙"
        datatest.Rows(13).Cells(0).Value = "上拉齿条衬套径向力"
        datatest.Rows(14).Cells(0).Value = "下拉齿条衬套径向间隙"
        datatest.Rows(15).Cells(0).Value = "下拉齿条衬套径向力"
        For i = 0 To 15
            If i = 4 Or i = 9 Or i = 12 Or i = 14 Then '添加单位
                datatest.Rows(i).Cells(4).Value = "   mm"
            Else
                datatest.Rows(i).Cells(4).Value = "   N"
            End If
        Next i
    End Sub
    Private Sub set_initialize_DMC2210()
        Dim n As Short
        n = d2210_board_init()  '初始化运动控制卡
        If (n <= 0) Or (n > 8) Then '正常的卡数在1- 8之间
            MsgBox("初始化DMC2210卡失败！", vbOKOnly, "出错")
        End If
        m_UseAxis = 0 '默认选择X轴
        d2210_set_pulse_outmode(0, 5)
        d2210_counter_config(0, 1)
    End Sub
    Private Sub set_initialize_Combox_piecepara()
        countpiecepara = database.DataGridView1.RowCount - 1   '工件类别个数（从0开始）=表中行数减一
        For i = 0 To countpiecepara - 1
            typesel.Items.Add(database.DataGridView1.Rows(i).Cells(0).Value)  '把数据库中（表格控件中的）数值填入combox产品型号控件中
        Next i
    End Sub
    Private Sub set_initialize_Time()
        mypiecedata.initialize()

        mypiecedata.datasaverec(1) = Now.ToString("yyyy-MM-dd")
        Call CreateFile() '按日期建立当天数据存放用的文件夹
        tooltime.Text = Now  '显示当前时间

    End Sub
    Private Sub set_piecepara_now()
        Dim i As Integer

        Dim filenam As String
        Dim str As String
        Dim mysr As System.IO.StreamReader
        Dim strtemp(1) As String

        filenam = Apppath & "\Sys\piecetype.txt"
        mysr = New System.IO.StreamReader(filenam, True)
        i = 0
        Do
            Dim line$ = mysr.ReadLine
            strtemp(i) = line
            i += 1
        Loop Until mysr.EndOfStream = True
        str = strtemp(0)                          '产品型号暂存
        If Val(strtemp(1)) = 0 Then ComboBox1.SelectedIndex = 0 '读取生产模式是0还是1
        If Val(strtemp(1)) = 1 Then ComboBox1.SelectedIndex = 1
        typesel.Text = str                       '产品型号读取
        mysr.Close()                             '关闭读取数据流
    End Sub


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemInitialization.ShowDialog()
        frmPreferset.ComboBox6.SelectedIndex = 0 '是否返工设置

        添加用户ToolStripMenuItem.Enabled = False
        删除用户ToolStripMenuItem.Enabled = False
        修改密码ToolStripMenuItem.Enabled = False
        ToolStripButton2.Enabled = False
        ToolStripButton3.Enabled = False
        ToolStripButton4.Enabled = False
        ToolStripButton5.Enabled = False
        ToolStripButton7.Enabled = False

        bytessend(22) = 0 '间隙抽检只有两个状态——1,不做；2,做
        'OleDbConnpara.Open() '打开数据库
        'OleDbConnrecd.Open() '打卡数据库

        set_chart() '调整图表控件
        ' Me.Visible = False  '隐藏窗体
        'Login.ShowDialog()   '加载登录对话框

        set_initialize_datagridview_now() '设置datagridview now图表显示
        'datatest.Rows(14).Visible = False '间隙只测总差值，此处多余，预留

        set_initialize_Time() '初始化时间及读取当前时间


        Call OpenConn() '刷新型号及产品参数数据库
        database.DataGridView1.DataSource = GlobalVariable.Datatable_para '绑定数据库
        set_initialize_Combox_piecepara() '初始化Combox型号控件
        ''database.DataGridView1.DataSource = MyDataSet.Tables(0) '绑定数据集当中的第一个表
        ' Call CloseConn() '关闭数据库连接

        set_initialize_DMC2210() '初始化板卡


        count1 = 1 '全程计数
        clearwy = DAQwy.Read '位移零位
        '’clearfqlleft = DAQfqlleft.Read '左反驱零位
        '’clearfqlright = DAQfqlright.Read '右反驱零位

        set_piecepara_now() '设置当前产品型号

        ' Return
        ComboBox1.Enabled = False                  '在线离线控件使能关闭
        PortOpen()                                  '打开串口
        Application.DoEvents()
        ThreadCom.Start() '通信线程开始
        Application.DoEvents()
        ThreadAcq.Start() '通信线程开始
        Application.DoEvents()
        ThreadCom_displacement.Start() '通信线程开始
        Application.DoEvents()
        FastLine1.Clear()                           'treechart1清除
        FastLine2.Clear()
        'TimlvbofTickenable = True
        TimlvbofTickenable = True
        ' Timlvbof.Enabled = True                         '定时器使能
    End Sub

    Private Sub countclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countclr.Click
        Dim t As Integer
        t = MsgBox("      确定计数清零！", MsgBoxStyle.YesNo)
        If t = MsgBoxResult.Yes Then
            lblok.Text = "0"
            lblng.Text = "0"
            lblall.Text = "0"
        End If
    End Sub

    Public Sub maincapture()
        Dim hDC, hMDC As Integer
        Dim hBMP, hBMPOld As Integer
        Dim sw, sh As Integer
        hDC = GetDC(0) '获取当前屏幕句柄
        hMDC = CreateCompatibleDC(hDC) '创建与屏幕兼容的内存

        sw = Screen.PrimaryScreen.Bounds.Width
        sh = Screen.PrimaryScreen.Bounds.Height

        hBMP = CreateCompatibleBitmap(hDC, sw, sh) '//下面建立一个与屏幕显示兼容的位图，
        hBMPOld = SelectObject(hMDC, hBMP) '//只有选入了位图的内存显示设备才有地方绘图，画到指定的位图上


        BitBlt(hMDC, 0, 0, sw, sh, hDC, 40, 103, SRCCOPY) ' 把图画进hMDC
        hBMP = SelectObject(hMDC, hBMPOld)  '双缓冲技术  
        Pic1.Image = Image.FromHbitmap(New IntPtr(hBMP)) 'hBMP位最后图像   hBMPOld为中间图像
        DeleteDC(hDC)
        DeleteDC(hMDC)
        DeleteObject(hBMP)
        Dim sPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location) & "\Photo\"
        Dim bmp As Bitmap = Pic1.Image

        Dim yy As String
        Dim mm As String
        Dim dd As String
        Dim dd1 As String
        Dim mm1 As String
        Dim protype As String
        yy = Now.Year & "年"
        mm = Now.Month & "月"
        dd = Now.Day & "日"
        mm1 = (Now.Month - 1) & "月"
        protype = typesel.Text
        If Dir(sPath + "\" + protype, vbDirectory) = "" Then
            MkDir(sPath + "\" + protype)
        End If
        If Dir(sPath + "\" + protype + "\" + yy, vbDirectory) = "" Then
            MkDir(sPath + "\" + protype + "\" + yy)
        End If
        If Dir(sPath + "\" + protype + "\" + yy + "\" + mm, vbDirectory) = "" Then
            MkDir(sPath + "\" + protype + "\" + yy + "\" + mm)
        End If
        If Dir(sPath + "\" + protype + "\" + yy + "\" + mm + "\" + dd, vbDirectory) = "" Then
            MkDir(sPath + "\" + protype + "\" + yy + "\" + mm + "\" + dd)
        End If
        If Dir(sPath + "\" + protype + "\" + yy + "\" + mm + "\" + dd + "\合格品", vbDirectory) = "" Then
            MkDir(sPath + "\" + protype + "\" + yy + "\" + mm + "\" + dd + "\合格品")
        End If
        If Dir(sPath + "\" + protype + "\" + yy + "\" + mm + "\" + dd + "\不合格品", vbDirectory) = "" Then
            MkDir(sPath + "\" + protype + "\" + yy + "\" + mm + "\" + dd + "\不合格品")
        End If
        If Format(Now, "HHmmss") <= 83000 Then  '按早8:30进行分班
            If Now.Day = 1 Then
                If Now.Month = 2 Or Now.Month = 4 Or Now.Month = 6 Or Now.Month = 8 Or Now.Month = 9 Or Now.Month = 11 Or Now.Month = 1 Then
                    dd1 = "31日"
                    If (Now.Month - 1) = 0 Then
                        mm1 = "12月"
                        yy = (Now.Year - 1) & "年"
                    End If
                    If ngflag = 0 Then
                        bmp.Save(sPath + "\" + protype + "\" + yy + "\" + mm1 + "\" + dd1 + "\合格品" + "\" + mypiecedata.datasaverec(0) + ".jpg")
                    Else
                        bmp.Save(sPath + "\" + protype + "\" + yy + "\" + mm1 + "\" + dd1 + "\不合格品" + "\" + mypiecedata.datasaverec(0) + ".jpg")
                    End If
                End If
                If Now.Month = 5 Or Now.Month = 7 Or Now.Month = 10 Or Now.Month = 12 Then
                    dd1 = "30日"
                    If ngflag = 0 Then
                        bmp.Save(sPath + "\" + protype + "\" + yy + "\" + mm1 + "\" + dd1 + "\合格品" + "\" + mypiecedata.datasaverec(0) + ".jpg")
                    Else
                        bmp.Save(sPath + "\" + protype + "\" + yy + "\" + mm1 + "\" + dd1 + "\不合格品" + "\" + mypiecedata.datasaverec(0) + ".jpg")
                    End If
                End If
                If Now.Month = 3 Then
                    If Now.Year Mod 4 = 0 Then
                        dd1 = "29日"
                    Else
                        dd1 = "28日"
                    End If
                    If ngflag = 0 Then
                        bmp.Save(sPath + "\" + protype + "\" + yy + "\" + mm1 + "\" + dd1 + "\合格品" + "\" + mypiecedata.datasaverec(0) + ".jpg")
                    Else
                        bmp.Save(sPath + "\" + protype + "\" + yy + "\" + mm1 + "\" + dd1 + "\不合格品" + "\" + mypiecedata.datasaverec(0) + ".jpg")
                    End If
                End If
            Else
                dd1 = (Now.Day - 1) & "日"
                If ngflag = 0 Then
                    bmp.Save(sPath + "\" + protype + "\" + yy + "\" + mm + "\" + dd1 + "\合格品" + "\" + mypiecedata.datasaverec(0) + ".jpg")
                Else
                    bmp.Save(sPath + "\" + protype + "\" + yy + "\" + mm + "\" + dd1 + "\不合格品" + "\" + mypiecedata.datasaverec(0) + ".jpg")
                End If
            End If
        Else
            If ngflag = 0 Then
                bmp.Save(sPath & "\" & protype & "\" & yy & "\" & mm & "\" & dd & "\合格品" & "\" & mypiecedata.datasaverec(0) & ".jpg")
            Else
                bmp.Save(sPath + "\" + protype + "\" + yy + "\" + mm + "\" + dd + "\不合格品" + "\" + mypiecedata.datasaverec(0) + ".jpg")
            End If
        End If
    End Sub

    Private Sub countchag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countchag.Click
        frmcountChange.Show() '合格与不合格计数修改
    End Sub

    Private Sub typesel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles typesel.SelectedIndexChanged
        Dim data(2) As Integer
        Dim filenam As String
        Dim str As String
        Dim mysr As System.IO.StreamReader
        Dim i As Integer

        prefpiecetype = typesel.SelectedItem  '产品型号字符串
        mypiecedata.datasaverec(2) = prefpiecetype
        Call OpenConn()                                         '打开数据库
        database.DataGridView1.DataSource = GlobalVariable.Datatable_para
        ''database.DataGridView1.DataSource = MyDataSet.Tables(0) '绑定数据源
        Call readparanew(prefpiecetype)                         '读取数据
        jianxicheckinte = Val(paranew(17))                      '间隙检测，频率直接变成间隔，频率需要知道总产量，现场商榷
        Call setparamain()                                      '设置表格参数
        Call CloseConn()                                        '关闭数据库连接
        Select Case paranew(34)                                 '间隙检测位置
            Case "1"
                bytessend(23) = 1
                bytessend(24) = 0
                bytessend(25) = 0
                bytessend(26) = 0
            Case "2"
                bytessend(24) = 1
                bytessend(23) = 0
                bytessend(25) = 0
                bytessend(26) = 0
            Case "3"
                bytessend(25) = 1
                bytessend(24) = 0
                bytessend(23) = 0
                bytessend(26) = 0
            Case "4"
                bytessend(26) = 1
                bytessend(24) = 0
                bytessend(25) = 0
                bytessend(23) = 0
        End Select
        filenam = Apppath & "\Sys\" & prefpiecetype & ".txt" '读取当前型号text文本 3组数据  合格  不合格 总数
        mysr = New System.IO.StreamReader(filenam, True)
        i = 0
        Do
            Dim line$ = mysr.ReadLine
            str = line
            data(i) = Val(str)
            i += 1
        Loop Until mysr.EndOfStream = True
        mysr.Close()
        my_oknum = data(0)
        my_ngnum = data(1)
        my_allnum = data(2)
        lblok.Text = my_oknum
        lblng.Text = my_ngnum
        lblall.Text = my_allnum
    End Sub

    '按日期建立当天数据存放用的文件夹
    Public Sub CreateFile()
        Dim sPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location) & "\Sys\recorddata\"
        Dim yy As String
        Dim mm As String
        Dim dd As String

        yy = Now.Year & "年"
        mm = Now.Month & "月"
        dd = Now.Day & "日"
        If Dir(sPath + "\" + yy, vbDirectory) = "" Then
            MkDir(sPath + "\" + yy)
        End If
        If Dir(sPath + "\" + yy + "\" + mm, vbDirectory) = "" Then
            MkDir(sPath + "\" + yy + "\" + mm)
        End If
        If Dir(sPath + "\" + yy + "\" + mm + "\" + dd, vbDirectory) = "" Then
            MkDir(sPath + "\" + yy + "\" + mm + "\" + dd)
        End If
    End Sub
    Public Sub Waitrs232Data()
        While True
            Try
                ComRec()

                'Me.Invoke(New fanqu(AddressOf DataProcess))

            Catch ex As Exception

            End Try
        End While

    End Sub


    '通信线程
    Public Sub WaitData()
        '     Return


        s = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim localEndPoint As New IPEndPoint(IPAddress.Parse("192.168.20.101"), 3000)
        s.Bind(localEndPoint)
        s.Listen(100)
        Dim ss As Socket
netlis:
        ss = s.Accept()
        While True
            Try
                plccoms = 1
                ss.Receive(bytesrecd)
                Me.Invoke(New fanqu(AddressOf DataProcess))
                ss.Send(bytessend)
            Catch ex As Exception
                plccoms = 0
                GoTo netlis
            End Try
        End While
        ss.Close()
    End Sub

    Private Sub Timlvbof_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timlvbof.Tick
        Dim i As Integer

        '新滤波方法
        'lvboleft(10) = DAQfqlleft.Read - clearfqlleft
        'svelleft = 0
        'lvboright(10) = DAQfqlright.Read - clearfqlright
        'svelright = 0

        'If icount >= 10 Then
        '    For i = 0 To 9
        '        lvboleft(i) = lvboleft(i + 1)
        '        svelleft += lvboleft(i)
        '        lvboright(i) = lvboright(i + 1)
        '        svelright += lvboright(i)
        '    Next
        '    vdatafqlleft = svelleft / 10
        '    vdatafqlright = svelright / 10 * (-1)
        'Else
        '    icount += 1
        '    For i = 10 - icount To 9
        '        lvboleft(i) = lvboleft(i + 1)
        '        svelleft += lvboleft(i)
        '        lvboright(i) = lvboright(i + 1)
        '        svelright += lvboright(i)
        '    Next
        '    vdatafqlleft = svelleft / icount
        '    vdatafqlright = svelright / icount * (-1)
        'End If

        '原滤波方法, 应该没有实际意义

    End Sub

    Private Sub Timtest_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timtest.Tick
        On Error Resume Next


    End Sub
    ''' <summary>
    ''' 复位所有数据
    ''' </summary>
    Public Sub reset()
        If bytesrecd(44) = 1 Then '复位
            d2210_decel_stop(m_UseAxis, 0.1) '停止运动
            runflag = False
            TestTickenable = False
            ' Timtest.Enabled = False
            moveflag = -1
            bytessend(697) = 0
            bytessend(690) = 0
            If cotjianxi >= jianxicheckinte Then cotjianxi = 0
            zeromoveflag = 0
            moveleft = 0
            moveright = 0
            backzero = 0
            zerored1 = 0
            zerored2 = 0
            handstop = 1
            lblresult.Text = "Result"
            lblresult.BackColor = Color.Yellow
            lblfqlleft.Text = "0"
            lblfqlright.Text = "0"
            lblwy.Text = "0"
            For i = 0 To 15
                okorngflag(i) = True
                datatest.Rows(i).Cells(3).Value = ""
                datatest.Rows(i).Cells(3).Style.BackColor = Color.White
            Next
            FastLine1.Clear()
            FastLine2.Clear()
            For i = 100 To 143
                bytessend(i) = 0
            Next
            bytessend(22) = 0
            moveflag = 0
            countAflag = 0
            count1 = 1
            count2 = 0
            countA = 0
            count3 = 0
            count4 = 0
            ngflag = 0
            maxwy2 = 0
            maxwy3 = 0
            maxwy4 = 0
            eftcot1 = 0
            eftcot2 = 0
            ordersend2 = 0
            ordersend3 = 0
            ordersend5 = 0
            ordersend6 = 0
            ordersend8 = 0
            ordersend9 = 0
            ordersend11 = 0
            ordersend12 = 0
            ordersend13 = 0
            ordersend14 = 0
            ordersend15 = 0
            ordersend16 = 0
            ordersend17 = 0
            ordersend18 = 0
            ordersend19 = 0
            ordersend20 = 0
            ordersend21 = 0
            ordersend22 = 0
            ordersend23 = 0
            ordersend24 = 0
            ordersend25 = 0

            sst1 = 0
            sst2 = 0
            sst3 = 0
            sst4 = 0
            sst5 = 0
            sst6 = 0
            countzero = 0
            checkzeroflag = False
            checkdownflag = False
            checkupflag = False
            begintest = False
            movetestflag = 0
            'TimlvbofTickenable = True
            TimlvbofTickenable = True
            ' Timlvbof.Enabled = True
            If fqjianxiexp = True Then fqjianxiexp = False
        End If
    End Sub


    Public Sub monitor_left_right()
        lvboleft(10) = Abs(DAQfqlleft.Read - clearfqlleft)
        svel = 0
        ' For i = 9 To 0 Step -1
        '  lvboleft(i) = lvboleft(i + 1)
        ' svel += lvboleft(i)
        'Next
        'vdatafqlleft = svel / 10 '求1-11的平均值 left
        vdatafqlleft = lvboleft(10)
        lvboright(10) = Abs(DAQfqlright.Read - clearfqlright)
        svel = 0
        ' For i = 9 To 0 Step -1
        ' lvboright(i) = lvboright(i + 1)
        ' svel += lvboright(i)
        ' Next
        'vdatafqlright = svel / 10 * (-1) '求1-11的平均值 right
        vdatafqlright = lvboright(10)
        sensorfqlleft = Val(Format(lvboleft(10) * Val(paranew(21)), "0.00"))  '与标定数据相乘
        sensorfqlright = Val(Format(lvboright(10) * Val(paranew(22)), "0.00"))
        If Abs(sensorfqlleft) >= Val(paranew(29)) Or Abs(sensorfqlright) >= Val(paranew(29)) Then '大于最大换向力停止动作
            If ordersend25 = 0 Then  '保证停止函数执行一次
                d2210_decel_stop(m_UseAxis, 0) '停止运动
                moveflag = -1
                TimlvbofTickenable = True
                ' Timlvbof.Enabled = False
                ordersend25 = 1
                '报警信息应该只显示文字部分，具体电压值为临时监视用
                MsgBox("反驱力超过最大换向力，请手动恢复机器于初始位置重新实验(" & sensorfqlleft & "/" & clearfqlleft & "/" & vdatafqlleft & "/" & clearfqlright & "/" & vdatafqlright & ")", vbOKOnly, "反驱力超范围")
            End If
        End If

    End Sub
    Public Sub monitor_emergency_stop()
        If bytesrecd(45) = 1 Then '急停
            d2210_decel_stop(m_UseAxis, 0.1) '停止运动
            runflag = False
            moveflag = -1
            TestTickenable = False
            '  Timtest.Enabled = False
        End If
        If bytesrecd(40) = 1 Then '运转准备 控制开

            If bytesrecd(42) = 1 Then '手动
                typesel.Enabled = True
                countclr.Enabled = True
                TestTickenable = False
                ' Timtest.Enabled = False
                ToolStripButton2.Enabled = True
                ToolStripButton3.Enabled = True
                ToolStripButton4.Enabled = True
                ToolStripButton7.Enabled = True
                ToolStripButton5.Enabled = True
                runflag = False '在手动条件下  禁止显示数值传感器
                moveflag = -1
                If handstop = 1 Then ' 自动切换到手动时应停止动作
                    d2210_decel_stop(m_UseAxis, 0.1) '停止运动
                    'DelayS(0.1)
                    Thread.Sleep(100)

                    handstop = 0
                End If
            End If
            If bytesrecd(43) = 1 Then '自动
                typesel.Enabled = False
                countclr.Enabled = False
                ToolStripButton2.Enabled = False
                ToolStripButton3.Enabled = False
                ToolStripButton4.Enabled = False
                ToolStripButton7.Enabled = False
                ToolStripButton5.Enabled = False
                If bytesrecd(39) = 1 Then '光栅报警
                    d2210_decel_stop(m_UseAxis, 0.1) '停止运动
                    'DelayS(0.1)
                    runflag = False
                    moveflag = -1
                End If
            End If
            If bytesrecd(46) = 0 Then
                movetestflag = 0
                bytessend(19) = 0 '实验结果 1合格 2不合格
                bytessend(21) = 0 '反驱结束
                bytessend(22) = 0 '测点使能
                bytessend(27) = 0 '上拉间隙结束
                bytessend(28) = 0 '下拉间隙结束
                bytessend(29) = 0 '0点采集完毕
                TestTickenable = False
                ' Timtest.Enabled = False
            End If
            If bytesrecd(46) = 1 And movetestflag = 0 Then '此处若加扫码完成标识，必须复位信号并且复位界面显示信息，报警标识未用，现场确定哪些信号
                ' Timlvbof.Enabled = True
                TimlvbofTickenable = True
                TestTickenable = True
                ' Timtest.Enabled = True
            End If

        End If
        If bytesrecd(41) = 1 Then
            d2210_decel_stop(m_UseAxis, 0)
            toolstate.Text = "系统处于待机状态"
        End If
    End Sub

    Private Delegate Sub fanqu()
    Dim li_sensors_times As Boolean
    Dim lileft_sensorszero As Boolean
    Dim liright_sensorszero As Boolean
    ''' <summary>
    ''' 线程监控  传感器数据及流程步 以及相关安全动作
    ''' </summary>
    Public Sub ShowAcqAndJudge()
        Dim lblfqlleft_now_adjiust As Double
        Dim lblfqlright_now_adjiust As Double
        Dim lblwy_now_adjiust As Double

        Dim lblfqlleft_now_weijianlingdain As Double
        Dim lblfqlright_now_weijianlingdain As Double

        monitor_emergency_stop() '紧急情况监控
        Application.DoEvents()


        If TimlvbofTickenable Then
            monitor_left_right() '左右监控以及  PLC链接状态监控
            Application.DoEvents()


        End If
        If lileft_sensorszero = False Or liright_sensorszero = False Then
            lblfqlleft_now_weijianlingdain = Val(Format(Val(DAQfqlleft.Read) * Val(paranew(21)), "0.00"))
            lblfqlright_now_weijianlingdain = Val(Format(Val(DAQfqlright.Read) * Val(paranew(22)), "0.00"))
        End If
        If lileft_sensorszero = False And lblfqlleft_now_weijianlingdain < 10 Then
            clearfqlleft = DAQfqlleft.Read '左反驱零位
            lileft_sensorszero = True
        End If

        If liright_sensorszero = False And lblfqlright_now_weijianlingdain < 10 Then
            clearfqlright = DAQfqlright.Read '右反驱零位
            liright_sensorszero = True
        End If
        TextBox4.Text = moveflag.ToString()
        If TestTickenable Then


            datasensorfqlleft = Val(Format(Val(vdatafqlleft) * Val(paranew(21)), "0.00")) + Val(paranew(26)) '加上零点偏置
            datasensorfqlright = Val(Format(Val(vdatafqlright) * Val(paranew(22)), "0.00")) + Val(paranew(26))
            vdatawy = DAQwy.Read - clearwy ''位移电压= 读取的值-位移零位
            If vdatawy >= 0 Then
                If vdatawy >= 0.2859 Then '位移分段，10mm为分段界限
                    vdatawy -= 0.2859
                    datasensorwy = Format(Val(vdatawy) * Val(paranew(23)) + 10, "0.00")  'paranew(23)位移标定
                Else
                    datasensorwy = Format(Val(vdatawy) * 34.977, "0.00")
                End If
            Else
                If vdatawy <= -0.2859 Then
                    vdatawy += 0.2859
                    datasensorwy = Format(Val(vdatawy) * Val(paranew(23)) - 10, "0.00")
                Else
                    datasensorwy = Format(Val(vdatawy) * 34.977, "0.00")
                End If
            End If


            Application.DoEvents()
            If begintest = False Then '自动测试开始——保证只调用一次主测试函数及状态设置

                'bytessend(697) = 1 '自动实验后光栅使能
                bytessend(690) = 0
                If paranew(47) = 1 Then '中位记号笔使能
                    bytessend(680) = 1
                Else
                    bytessend(680) = 0
                End If
                handstop = 1  '手动动作
                lblresult.Text = "Result"
                lblresult.BackColor = Color.Yellow
                lblfqlleft.Text = "0"
                lblfqlright.Text = "0"
                lblwy.Text = "0"
                For i = 0 To 15
                    okorngflag(i) = True '各测试项判断结果以及超时判断
                    datatest.Rows(i).Cells(3).Value = ""
                    datatest.Rows(i).Cells(3).Style.BackColor = Color.White
                Next
                FastLine1.Clear()
                FastLine2.Clear()
                For i = 100 To 143
                    bytessend(i) = 0
                Next
                bytessend(22) = 0 '实验结果(合格1 不合格2)
                cotjianxi += 1    '间隙检测计数，测试后复位重新计数
                TStart = GetTimeCount() / 1000
                moveflag = 1    '正反转控制
                runflag = True  '自动动作标识
                begintest = True  '自动测试调用结束置位——保证只调用一次主测试函数及状态设置
                Application.DoEvents()
            End If

            If runflag = True Then
                lblwy.Text = datasensorwy           '显示位移

                Ttotal = GetTimeCount() / 1000 - TStart  '一次实验总时间
                If Ttotal > Val(paranew(41)) Then  '超时设置
                    bytessend(690) = 1    '设备超时

                Else
                    bytessend(690) = 0    '设备未超时
                End If

                lblfqlleft_now_adjiust = Format((datasensorfqlleft - Val(paranew(27))) * Val(paranew(31)), "0.00")   '27左反驱力调整力 31左反驱力调整系数
                lblfqlright_now_adjiust = Format((datasensorfqlright - Val(paranew(28))) * Val(paranew(31)), "0.00") '右反驱力调整
                lblwy_now_adjiust = datasensorwy '显示位移
                If li_sensors_times = True Then

                    lbltime.Text = Format(Ttotal, "0.00") '显示时间
                    lblwy.Text = lblwy_now_adjiust           '显示位移
                    lblfqlleft.Text = lblfqlleft_now_adjiust  '27左反驱力调整力 31左反驱力调整系数
                    lblfqlright.Text = lblfqlright_now_adjiust '右反驱力调整
                    mypiecedata.mcountdata = count1 '全程计数
                    datawy(count1) = datasensorwy '数组采集数据  一共5000组
                    li_sensors_times = False
                    Application.DoEvents()
                End If

            End If
            Application.DoEvents()

            'Return
            '  TextBox1.Text = moveflag.ToString()
            Select Case moveflag

                Case 1 '中位向右
                    Dir1 = 1 '转逆转方向
                    Call move_start()
                    ordersend25 = 0
                    moveflag = 2 '步骤
                    Application.DoEvents()
                Case 2 '右第一次到达
                    datasensor(count1) = -Val(lblfqlleft_now_adjiust) '为画图显示方便，左反驱力取成负值
                    ' TextBox2.Text = datasensor(count1).ToString() + " === " + ((-1) * Val(paranew(19))).ToString() + "\\\\\" + count1.ToString()
                    'If -Val(datasensorfqlleft) <= -400.0 Then
                    '    d2210_decel_stop(m_UseAxis, 0) '停止运动
                    '    TextBox2.Text = "停止运动"
                    'End If

                    If datasensor(count1) <= (-1) * Val(paranew(19)) Then
                        d2210_decel_stop(m_UseAxis, 0) '停止运动
                        If ordersend12 = 0 Then
                            count2 = count1 - 2 '- 2
                            maxwy2 = datawy(count2) '？？？？？？？？？？？？？？？？？？？？？？
                            ordersend18 = 1
                            ordersend12 = 1
                        End If
                    End If

                    If ordersend18 = 1 Then
                        If sst1 = 2 Then
                            moveflag = 3
                        End If
                        sst1 += 1   '循环两次加一
                    End If
                    Thread.SpinWait(10)
                Case 3 '右向左
                    ' MsgBox("右向左1")
                    If ordersend2 = 0 Then '只执行一次就完事
                        Dir1 = 0
                        Call move_start()
                        ordersend2 = 1
                        'gBox("右向左2")
                        Application.DoEvents()
                    End If

                    datasensor(count1) = Val(lblfqlright_now_adjiust) '31为反驱力调整系数

                    If Val(lblfqlright_now_adjiust) >= 30 Then
                        If ordersend3 = 0 Then
                            eftcot1 = count1 + 20 '+ 3 '有效测试，右边刚接触上的采样点 ？？？？？？？？？？？？？？？？？？？？？？
                            ordersend3 = 1
                            Application.DoEvents()
                        End If
                        If Val(lblfqlright_now_adjiust) < Val(paranew(19)) Then FastLine1.Add(datawy(count1), datasensor(count1)) 'paranew(19) 换向力  符合换向力范围 就画曲线 
                        'If Val(lblfqlright_now_adjiust) < 198 Then FastLine1.Add(datawy(count1), datasensor(count1)) '干扰影响，采用阈值处理
                        ' Label3.Text = datasensor(count1)
                        If datasensor(count1) >= Val(paranew(19)) Then '大于设置的换向力 就停止运动
                            d2210_decel_stop(m_UseAxis, 0) '停止运动
                            ' MsgBox(ordersend13.ToString())
                            If ordersend13 = 0 Then
                                ' MsgBox("右向左3")
                                count3 = count1 - 3 ' - 2
                                maxwy3 = datawy(count3) '？？？？？？？？？？？？？？？？？？？？？？
                                ordersend13 = 1
                                ordersend17 = 1
                            End If
                            zerowybc = maxwy2 - (maxwy2 - maxwy3) / 2 '回中位移  右是+  左是-
                        End If
                    End If
                    Application.DoEvents()
                    If ordersend17 = 1 Then
                        If sst2 = 2 Then
                            moveflag = 4
                        End If
                        sst2 += 1
                    End If
                    Thread.SpinWait(10)
                Case 4 '左第一次到达后换向，即左向右动
                    If ordersend5 = 0 Then
                        Dir1 = 1
                        Call move_start()
                        ordersend5 = 1
                    End If
                    datasensor(count1) = -Val(lblfqlleft_now_adjiust)
                    If Val(lblfqlleft_now_adjiust) >= 30 Then
                        If ordersend6 = 0 Then
                            eftcot2 = count1 + 3 '+ 13 '？？？？？？？？？？？？？？？？？？？？？？
                            ordersend6 = 1
                        End If
                        If Val(lblfqlleft_now_adjiust) < Val(paranew(19)) Then FastLine2.Add(datawy(count1), datasensor(count1))
                        'If Val(lblfqlleft_now_adjiust) < 198 Then FastLine2.Add(datawy(count1), datasensor(count1)) '干扰影响，采用阈值处理
                        If datasensor(count1) <= (-1) * Val(paranew(19)) Then
                            d2210_decel_stop(m_UseAxis, 0) '停止运动
                            If ordersend14 = 0 Then
                                count4 = count1 - 20 ''- 2
                                maxwy4 = datawy(count4) '？？？？？？？？？？？？？？？？？？？？？？
                                ordersend19 = 1
                                ordersend14 = 1
                                sst3 = 0
                            End If
                        End If
                    End If
                    If ordersend19 = 1 Then
                        If sst3 = 2 Then
                            moveflag = 13
                        End If
                        sst3 += 1
                    End If
                    Thread.SpinWait(10)
                Case 13 '计算有效位移对应的采样点
                    For i = eftcot1 To count3 'eftcot1 =右向左 有力接触大于30N时候 过了50*3ms后的点  count3=左向右 停止前 50*2ms
                        If datawy(i) <= (maxwy2 - maxwy3) * Val(paranew(30)) / 200 + zerowybc Then '百分比，所以要除以100，转换为小数  paranew(30)有效测试位移百分比
                            eftcot1 = i
                            Exit For
                        End If
                    Next
                    For i = count3 To eftcot1 Step -1 '如果有效位移百分比位95%截取靠近左侧 剩余的5%位移
                        If datawy(i) >= (maxwy2 - maxwy3) * Val(-paranew(30)) / 200 + zerowybc Then
                            count3 = i
                            Exit For
                        End If
                    Next
                    For i = eftcot2 To count4 '左向右动
                        If datawy(i) >= (maxwy2 - maxwy3) * Val(-paranew(30)) / 200 + zerowybc Then
                            eftcot2 = i
                            Exit For
                        End If
                    Next
                    For i = count4 To eftcot2 Step -1
                        If datawy(i) <= (maxwy2 - maxwy3) * Val(paranew(30)) / 200 + zerowybc Then
                            count4 = i
                            Exit For
                        End If
                    Next
                    mypiecedata.huitustart = eftcot1
                    mypiecedata.huituend1 = count3
                    mypiecedata.huitustart1 = eftcot2
                    mypiecedata.huituend = count4
                    Call avgfqlR() '右反驱力平均值
                    Call avgfqlL() '左反驱力平均值
                    pdavgfqlL = Format(pdavgfqlL, "0.00")
                    pdavgfqlR = Format(pdavgfqlR, "0.00")
                    '重新画曲线
                    FastLine1.Clear()
                    FastLine2.Clear()
                    If paranew(45) = 1 Then '1-滤波处理；0-不处理
                        lvbortemp1 = pdavgfqlR - (pdavgfqlR - (Val(paranew(4)) - Val(paranew(44)))) * (100 - Val(paranew(43))) / 100  '4反驱力最小值下限   44阈值补偿  43图像滤波百分比
                        lvbortemp2 = pdavgfqlR + ((Val(paranew(1)) + Val(paranew(44))) - pdavgfqlR) * (100 - Val(paranew(43))) / 100
                        For i = mypiecedata.huitustart To mypiecedata.huituend1
                            If datasensor(i) >= (paranew(4) - paranew(44)) And datasensor(i) <= (paranew(1) + paranew(44)) Then
                                If datasensor(i) >= lvbortemp1 And datasensor(i) <= lvbortemp2 Then

                                Else
                                    datasensor(i) = (datasensor(i) + (Val(paranew(46) - 1)) * pdavgfqlR) / Val(paranew(46)) 'paranew(46)  量化点数
                                End If
                            End If
                            FastLine1.Add(datawy(i) - zerowybc, datasensor(i))
                        Next

                        lvboltemp1 = pdavgfqlL - (pdavgfqlL + (Val(paranew(1)) + Val(paranew(44)))) * (100 - Val(paranew(43))) / 100
                        lvboltemp2 = pdavgfqlL + (Abs(pdavgfqlL) - (Val(paranew(4)) - Val(paranew(44)))) * (100 - Val(paranew(43))) / 100
                        For i = mypiecedata.huitustart1 To mypiecedata.huituend
                            If datasensor(i) <= -(paranew(4) - paranew(44)) And datasensor(i) >= -(paranew(1) + paranew(44)) Then
                                If datasensor(i) >= lvboltemp1 And datasensor(i) <= lvboltemp2 Then

                                Else
                                    datasensor(i) = (datasensor(i) + (Val(paranew(46) - 1)) * pdavgfqlL) / Val(paranew(46))
                                End If
                            End If
                            FastLine2.Add(datawy(i) - zerowybc, datasensor(i))
                        Next
                    Else        ' 不进行滤波处理
                        For i = mypiecedata.huitustart To mypiecedata.huituend1
                            FastLine1.Add(datawy(i) - zerowybc, datasensor(i))
                        Next
                        For i = mypiecedata.huitustart1 To mypiecedata.huituend
                            FastLine2.Add(datawy(i) - zerowybc, datasensor(i))
                        Next
                    End If
                    moveflag = 5
                Case 5 '右第二次到达，需要判断是否间隙抽检。出于安全，先向左运动一点，保证左侧反驱力等于零且齿条还在可以检测的位置，再判断是否满足抽检条件
                    If ordersend8 = 0 Then
                        Dir1 = 0
                        Call move_start2()
                        ordersend8 = 1
                    End If
                    If Val(lblfqlleft_now_adjiust) <= 30 And ordersend9 = 0 Then
                        d2210_decel_stop(m_UseAxis, 0) '停止运动
                        If sst4 = 2 Then
                            ordersend9 = 1
                        End If
                        sst4 += 1
                    End If
                    If ordersend9 = 1 Then
                        Call OkOrNg() '各项检测调用
                        For i = 0 To 11
                            If okorngflag(i) = False Then '各测试项判断结果以及超时判断
                                flagok = False   'OK/NG判断标识
                                Exit For
                            Else
                                flagok = True
                            End If
                        Next
                        jianxilizero = DAQjxl.Read   '起始间隙力电压——零位
                        moveflag = 6
                    End If
                Case 6 '判断是否满足抽检条件
                    If cotjianxi = jianxicheckinte And flagok = True Then '满足抽检
                        bytessend(22) = 2     '测点使能（1不做  2做）
                        If bytesrecd(49) = 1 Then '传感器0点

                            If checkzeroflag = False Then '原位，保证值只采集一次
                                jianxizero = readpos()
                                checkzeroflag = True
                            End If
                            bytessend(29) = 1 '0点采集完毕
                        End If
                        If bytesrecd(48) = 1 Then
                            If checkdownflag = False Then '下拉
                                vdatajingxi = readpos()  '串口数据
                                pdjingxjianxidown = jianxizero - vdatajingxi '间隙后的差值

                                vdatajingxli = Abs(DAQjxl.Read - jianxilizero)
                                If vdatajingxli > 1 Then
                                    vdatajingxli -= 1
                                    pdjingxlidown = Format(Val(vdatajingxli * Val(paranew(24)) + 20 + 18), "0.00") '18N为工装自身重力，下拉需补偿
                                Else
                                    pdjingxlidown = Format(Val(vdatajingxli * 26 + 18), "0.00")
                                End If
                                pdjingxlidown = pdjingxlidown + Val(paranew(37))
                                checkdownflag = True
                                checkzeroflag = False
                                bytessend(29) = 0 '0点采集完毕
                                jianxizero = 0 '间隙检测时气缸刚接触工件时的位移
                            End If
                            bytessend(28) = 1 '下拉测间隙结束

                        End If
                        If bytesrecd(47) = 1 Then
                            If checkupflag = False Then '上拉
                                vdatajingxi = readpos() '串口数据
                                pdjingxjianxiup = vdatajingxi - jianxizero  '间隙后的差值

                                vdatajingxli = Abs(DAQjxl.Read - jianxilizero)
                                If vdatajingxli > 1 Then
                                    vdatajingxli -= 1
                                    pdjingxliup = Format(Val(vdatajingxli * Val(paranew(24)) + 20), "0.00") '24 径向力标定
                                Else
                                    pdjingxliup = Format(Val(vdatajingxli * 26), "0.00")
                                End If
                                pdjingxliup = pdjingxliup + Val(paranew(38)) '38间隙上拉力补偿参数
                                checkupflag = True '上拉检测完成标识
                                checkzeroflag = False '原位采集完成标识
                                bytessend(29) = 0 '0点采集完毕
                                jianxizero = 0 '间隙检测时气缸刚接触工件时的位移
                            End If
                            bytessend(27) = 1 '上拉测间隙结束
                        End If
                        If checkupflag = True AndAlso checkdownflag = True Then '保证实验完成(原位、上拉、下拉)
                            Call PdOkOrNg(Abs(pdjingxjianxiup) + Val(paranew(40)), 13, 16, 12) '上拉间隙 (判定数据，判定上下限，存储位置，显示行数)
                            Call PdOkOrNg(Abs(pdjingxliup), 15, 17, 13) '上拉力
                            Call PdOkOrNg(Abs(pdjingxjianxidown) + Val(paranew(39)), 13, 18, 14) '下拉间隙
                            Call PdOkOrNg(Abs(pdjingxlidown), 15, 19, 15) '下拉力
                            If okorngflag(12) = True AndAlso okorngflag(13) = True AndAlso okorngflag(15) = True AndAlso okorngflag(14) = True AndAlso flagok = True Then
                                flagok = True
                                moveflag = 7
                            Else
                                flagok = False
                                moveflag = 14
                            End If
                            fqjianxiexp = True '检测执行标识——保存数据用
                            cotjianxi = 0 '若时序真存在问题，此处可能出现不清零的情况
                            bytessend(22) = 0 '测点使能（1不做  2做）
                        End If
                    Else
                        bytessend(22) = 1 '测点使能（1不做  2做）
                        If cotjianxi <> jianxicheckinte Then
                            moveflag = 8
                        Else
                            If flagok = False Then
                                cotjianxi = 0
                                moveflag = 8
                            End If
                        End If
                    End If
                Case 7 '抽检合格
                    If bytesrecd(50) = 1 Then '齿条可以回中信号
                        Dir1 = 0
                        Call move_start()
                        moveflag = 9
                    End If
                Case 14
                    If bytesrecd(50) = 1 Then '抽检不合格，等待回中信号 ’齿条可以回中
                        Dir1 = 0
                        Call move_start()
                        moveflag = 9
                    End If
                Case 8 '不满足抽检条件
                    Dir1 = 0
                    Call move_start()
                    moveflag = 9
                Case 9
                    If (vdatawy + clearwy) < Val(paranew(33)) + 0.5 And ordersend24 = 0 Then '33零位判断基准电压
                        Call changespeed() '回中速度改变
                        ordersend24 = 1
                    End If
                    If (vdatawy + clearwy) <= (Val(paranew(33)) - Val(paranew(42))) And ordersend21 = 0 Then '33零位判断基准电压
                        d2210_decel_stop(m_UseAxis, 0) '停止运动
                        ordersend21 = 1
                    End If
                    If ordersend21 = 1 Then
                        ordersend22 += 1
                    End If
                    If ordersend22 = 3 Then moveflag = 20
                Case 20
                    Dir1 = 1
                    Call move_return() '回零
                    moveflag = 23
                Case 21 '未用
                    If (vdatawy + clearwy) >= (Val(paranew(33)) + Val(paranew(42))) And ordersend21 = 0 Then '42回中补偿电压
                        d2210_decel_stop(m_UseAxis, 0) '停止运动
                        ordersend21 = 1
                    End If
                    If ordersend21 = 1 Then
                        ordersend22 += 1
                    End If
                    If ordersend22 = 3 Then moveflag = 22
                Case 22  '未用
                    Dir1 = 0
                    Call move_return()  '回零
                    moveflag = 23
                Case 23
                    If vdatawy + clearwy >= Val(paranew(33)) Then
                        d2210_decel_stop(m_UseAxis, 0) '停止运动
                        runflag = False '自动动作标识
                        ordersend15 = 1
                    End If
                    If ordersend15 = 1 Then
                        If sst6 = 2 Then
                            moveflag = 12
                        End If
                        sst6 += 1
                    End If
                'Case 10 '回中后，右侧工装仍接触工件，需向右运动部分
                '    Dir1 = 1
                '    Call move_return()
                '    moveflag = 11
                'Case 11
                '    If Abs(datawy(count1) - datawy(countzero)) >= 10 Then '若回中效果不好，可加补偿位移
                '        d2210_decel_stop(m_UseAxis, 0) '停止运动
                '        runflag = False
                '        ordersend15 = 1
                '    End If
                '    If ordersend15 = 1 Then
                '        If sst6 = 2 Then
                '            moveflag = 12
                '        End If
                '        sst6 += 1
                '    End If
                Case 12
                    If flagok = True Then
                        ngflag = 0
                        lblresult.BackColor = Color.Lime
                        lblresult.Text = "OK"
                        lblok.Text = Val(lblok.Text) + 1
                        countpiece = Val(lblok.Text)
                        mypiecedata.datasaverec(4) = "OK"
                        lblall.Text = Val(lblok.Text) + Val(lblng.Text)
                        moveflag = 122
                        Call datasave(countpiece)
                    Else
                        ngflag = 1
                        lblresult.BackColor = Color.Red
                        lblresult.Text = "NG"
                        lblng.Text = Val(lblng.Text) + 1
                        countpieceng = Val(lblng.Text)
                        mypiecedata.datasaverec(4) = "NG"
                        lblall.Text = Val(lblok.Text) + Val(lblng.Text)
                        moveflag = 122
                        Call datasave(countpieceng)
                    End If
                    counter = 0

                    Call setparamain()  '赋值操作-主界面

                'moveflag = 122
                Case 122
                    counter += 1
                    If counter >= 10 Then
                        moveflag = 121
                    End If
                Case 121

                    Call maincapture() '保存曲线截图到本地
                    '上传实验结果到PLC, 进而到追溯系统, OK / NG后发, 防止信息丢失
                    Call singletobin(mypiecedata.datasaverec(5), 100, 101, 102, 103)
                    Call singletobin(mypiecedata.datasaverec(6), 104, 105, 106, 107)
                    Call singletobin(mypiecedata.datasaverec(7), 108, 109, 110, 111)
                    Call singletobin(mypiecedata.datasaverec(8), 112, 113, 114, 115)
                    Call singletobin(mypiecedata.datasaverec(9), 116, 117, 118, 119)
                    Call singletobin(mypiecedata.datasaverec(10), 120, 121, 122, 123)
                    Call singletobin(mypiecedata.datasaverec(11), 124, 125, 126, 127)
                    Call singletobin(mypiecedata.datasaverec(12), 128, 129, 130, 131)
                    Call singletobin(mypiecedata.datasaverec(13), 132, 133, 134, 135)
                    Call singletobin(mypiecedata.datasaverec(14), 136, 137, 138, 139)
                    Call singletobin(mypiecedata.datasaverec(15), 140, 141, 142, 143)
                    Call singletobin(mypiecedata.datasaverec(20), 144, 145, 146, 147)
                    If fqjianxiexp = True Then '检测执行标识——保存数据用
                        Call singletobin(mypiecedata.datasaverec(16), 148, 149, 150, 151)
                        Call singletobin(mypiecedata.datasaverec(17), 152, 153, 154, 155)
                        Call singletobin(mypiecedata.datasaverec(18), 156, 157, 158, 159)
                        Call singletobin(mypiecedata.datasaverec(19), 160, 161, 162, 163)
                    End If

                    If mypiecedata.datasaverec(4) = "OK" Then bytessend(19) = 1
                    If mypiecedata.datasaverec(4) = "NG" Then bytessend(19) = 2
                    bytessend(21) = 1 '反驱结束，需复位
                    movetestflag = 1

                    frmPreferset.ComboBox6.SelectedIndex = 0 '返工设置选择
                    moveflag = 0
                    bytessend(697) = 0
                    countAflag = 0
                    count1 = 1
                    count2 = 0
                    countA = 0
                    count3 = 0
                    count4 = 0
                    countzero = 0
                    ngflag = 0
                    maxwy2 = 0
                    maxwy3 = 0
                    maxwy4 = 0
                    eftcot1 = 0
                    eftcot2 = 0
                    ordersend2 = 0
                    ordersend3 = 0
                    ordersend5 = 0
                    ordersend6 = 0
                    ordersend8 = 0
                    ordersend9 = 0
                    ordersend11 = 0
                    ordersend12 = 0
                    ordersend13 = 0
                    ordersend14 = 0
                    ordersend15 = 0
                    ordersend16 = 0
                    ordersend17 = 0
                    ordersend18 = 0
                    ordersend19 = 0
                    ordersend20 = 0
                    ordersend21 = 0
                    ordersend22 = 0
                    ordersend23 = 0
                    ordersend24 = 0
                    ordersend25 = 0
                    sst1 = 0
                    sst2 = 0
                    sst3 = 0
                    sst4 = 0
                    sst5 = 0
                    sst6 = 0
                    checkzeroflag = False
                    checkdownflag = False
                    checkupflag = False
                    begintest = False
                    For i = 0 To 15
                        okorngflag(i) = True
                    Next
                    If fqjianxiexp = True Then fqjianxiexp = False
                    TestTickenable = False
                    'Timtest.Enabled = False
            End Select




            ThreadCount = ThreadCount + 1
            TestEnd = timeGetTime()
            If (TestEnd - TestStart) >= 5 Then
                TestStart = TestEnd
                li_sensors_times = True
                If (count1 < 5000) Then

                    count1 += 1
                End If
            End If
            'If (TestEnd - TestStart) >= 1000 Then
            'TestStart = TestEnd
            'ToolStripStatusLabel9.Text = ThreadCount
            '  ThreadCount = 0
            ' End If
        End If
        Application.DoEvents()
        reset() '复位数据
        bytessend(18) = frmPreferset.ComboBox6.SelectedIndex '返工设置选择
        Application.DoEvents()


    End Sub
    '数据处理 另开线程一直监控
    Private Sub DataProcess()
        On Error Resume Next
        Dim i As Integer

        If plccoms = 1 Then '通讯状态
            plccomsstate.BackColor = Color.Green
        Else
            plccomsstate.BackColor = Color.Red
        End If



        volwy = Format(DAQwy.Read, "000.00")
        If volwy < volzerowy - 0.1 Or volwy > volzerowy + 0.1 Then
            bytessend(696) = 0 '
        Else
            bytessend(696) = 1 '设备已归零
        End If
        If scancodeflag Then ''扫码标识——默认工序是必须扫码，赋真值
            For i = 0 To 27
                barcode(i) = bytesrecd(2 + i) '地址2开始为条码信息，现条码长度为28位
            Next
            barcodestr = Trim(Encoding.Default.GetString(barcode))
            mypiecedata.datasaverec(3) = barcodestr
            tiaoma.Text = barcodestr
        Else
            tiaoma.Text = ""
        End If

        TextBOX_num_state.Text = bytesrecd(0).ToString() '显示状态数字
        tooltime.Text = Now
        Select Case bytesrecd(0) '状态显示


            Case 0
                state.Text = ""
                trouble.Text = ""
            Case 1
                trouble.Text = "急停按下"
            Case 2
                trouble.Text = "控制关按下"
            Case 3
                trouble.Text = "气压低报警，检查气源压力或压力继电器设定值，处理完后复位"
            Case 4
                trouble.Text = "光栅报警，请在手动模式下复位"
            Case 5
                trouble.Text = "三相电相序报警，根据相序保护器信息提示灯，处理完报警后复位"
            Case 6
                trouble.Text = "伺服控制器报警，将伺服控制器上电后复位"
            Case 10
                state.Text = "请将开关置于手动模式下，电缸归零"
            Case 11
                state.Text = "电缸已归零，可以开始自动实验"
            Case 20
                trouble.Text = "壳体夹紧气缸工作位异常，请检查工作端敏感元件后复位"
            Case 21
                trouble.Text = "壳体夹紧气缸返回位异常，请检查返回端敏感元件后复位"
            Case 22
                trouble.Text = "壳体夹紧气缸敏感元件损坏，请检查气缸前进、后退动作是否正常"
            Case 24
                trouble.Text = "间隙检测横移气缸工作位异常，请检查工作端敏感元件后复位"
            Case 25
                trouble.Text = "间隙检测横移气缸返回位异常，请检查返回端敏感元件后复位"
            Case 26
                trouble.Text = "间隙检测横移气缸敏感元件损坏，请检查气缸前进、后退动作是否正常"
            Case 28
                trouble.Text = "间隙检测压下气缸工作位异常，请检查工作端敏感元件后复位"
            Case 29
                trouble.Text = "间隙检测压下气缸返回位异常，请检查返回端敏感元件后复位"
            Case 30
                trouble.Text = "间隙检测压下气缸敏感元件损坏，请检查气缸前进、后退动作是否正常"
            Case 32
                trouble.Text = "加载气缸工作位异常，请检查工作端敏感元件后复位"
            Case 33
                trouble.Text = "加载气缸返回位异常，请检查返回端敏感元件后复位"
            Case 34
                trouble.Text = "加载气缸敏感元件损坏，请检查气缸前进、后退动作是否正常"
            Case 36
                trouble.Text = "加载下限位导杆气缸工作位异常，请检查工作端敏感元件后复位"
            Case 37
                trouble.Text = "加载下限位导杆气缸返回位异常，请检查返回端敏感元件后复位"
            Case 38
                trouble.Text = "加载下限位导杆气缸敏感元件损坏，请检查气缸前进、后退动作是否正常"
            Case 40
                trouble.Text = "加载横移气缸工作位异常，请检查工作端敏感元件后复位"
            Case 41
                trouble.Text = "加载横移气缸返回位异常，请检查返回端敏感元件后复位"
            Case 42
                trouble.Text = "加载横移气缸敏感元件损坏，请检查气缸前进、后退动作是否正常"
            Case 44
                trouble.Text = "壳体夹紧气缸二工作位异常，请检查工作端敏感元件后复位"
            Case 45
                trouble.Text = "壳体夹紧气缸二返回位异常，请检查返回端敏感元件后复位"
            Case 46
                trouble.Text = "壳体夹紧气缸二敏感元件损坏，请检查气缸前进、后退动作是否正常"
            Case 60
                trouble.Text = "伺服电机左移限位，手动向右移动"
            Case 61
                trouble.Text = "伺服电机右移限位，手动向左移动"
            Case 62
                trouble.Text = "伺服电机限位开关损坏，先确定左、右移动是否有动作，若无动作检查丝杠；若有动作更换开关"
            Case 199
                state.Text = "请复位"
            Case 200
                state.Text = "请放壳体，并拨自动开关"
            Case 201
                state.Text = "请扫条码"

            Case 202
                state.Text = "重复加工，允许开始"
            Case 203
                state.Text = "重复加工，不能开始"
            Case 204
                state.Text = "该条码信息未录入追溯系统，请从初始工位重新开始"
            Case 205
                state.Text = "未知，请复位，重新实验"
            Case 206
                state.Text = "设备未在原位"
            Case 207
                state.Text = "存储异常，等待相关人员处理完毕后复位"
            Case 208
                state.Text = "等待第二次上传数据"
            Case 209
                state.Text = "自动测试中"
            Case 210
                state.Text = "实验开始"
            Case 211
                state.Text = "请取不合格笔做标记"
            Case 212
                state.Text = "请将不合格品放入返修料道"
            Case 213
                state.Text = "请取中位画线笔做标记"
            Case 214
                state.Text = "传至下一工序"
            Case 216
                state.Text = "请放回不合格记号笔"
            Case 217
                state.Text = "请放回中位画线记号笔"
            Case 100
                state.Text = "工位1未做"
            Case 101
                state.Text = "工位2未做"
            Case 102
                state.Text = "工位3未做"
            Case 103
                state.Text = "工位4未做"
            Case 104
                state.Text = "工位5未做"
            Case 105
                state.Text = "工位6未做"
            Case 106
                state.Text = "工位7未做"
            Case 107
                state.Text = "工位7-2未做"
            Case 108
                state.Text = "工位8未做"
            Case 109
                state.Text = "工位8-2未做"
            Case 110
                state.Text = "工位9未做"
            Case 111
                state.Text = "工位10未做"
            Case 112
                state.Text = "工位11未做"
            Case 113
                state.Text = "工位12未做"
            Case 114
                state.Text = "工位13未做"
            Case 115
                state.Text = "工位14未做"
            Case 116
                state.Text = "工位15未做"
            Case 117
                state.Text = "工位16未做"
            Case 118
                state.Text = "工位17未做"
            Case 119
                state.Text = "工位18未做"
            Case 120
                state.Text = "已做工位1，但为NG品"
            Case 121
                state.Text = "已做工位2，但为NG品"
            Case 122
                state.Text = "已做工位3，但为NG品"
            Case 123
                state.Text = "已做工位4，但为NG品"
            Case 124
                state.Text = "已做工位5，但为NG品"
            Case 125
                state.Text = "已做工位6，但为NG品"
            Case 126
                state.Text = "已做工位7，但为NG品"
            Case 127
                state.Text = "已做工位7-2，但为NG品"
            Case 128
                state.Text = "已做工位8，但为NG品"
            Case 129
                state.Text = "已做工位8-2，但为NG品"
            Case 130
                state.Text = "已做工位9，但为NG品"
            Case 131
                state.Text = "已做工位10，但为NG品"
            Case 132
                state.Text = "已做工位11，但为NG品"
            Case 133
                state.Text = "已做工位12，但为NG品"
            Case 134
                state.Text = "已做工位13，但为NG品"
            Case 135
                state.Text = "已做工位14，但为NG品"
            Case 136
                state.Text = "已做工位15，但为NG品"
            Case 137
                state.Text = "已做工位16，但为NG品"
            Case 138
                state.Text = "已做工位17，但为NG品"
            Case 139
                state.Text = "已做工位18，但为NG品"
        End Select
    End Sub

    '单精度浮点数转为二进制字符串(32位)，进而存放到对应字节中发送到PLC
    Public Sub singletobin(ByVal datatemp As Single, ByVal byt0 As Integer, ByVal byt1 As Integer, ByVal byt2 As Integer, ByVal byt3 As Integer) '浮点数，存放对应字节地址



        Dim datatempdot As Double '小数部分
        Dim datatempint As Single '整数部分
        Dim bintemp As String '用字符串表示二进制
        Dim bintempindex As String '指数二进制
        Dim binresult As String '按照IEEE标准（1,8,23）二进制字符串
        Dim cotleft As Integer '大于1计算指数用
        Dim cotright As Integer '小于1计算指数用
        Dim cotmove As Integer '小数点移动位数
        Dim i, j As Integer
        Dim str1, str2, str3, str4 As String

        bintemp = ""
        bintempindex = ""
        binresult = ""
        If datatemp = 0 Then
            For i = 0 To 31
                binresult += "0"
            Next
        Else
            If datatemp >= 0 Then
                binresult = "0"
            Else
                binresult = "1" '负数，计算绝对值，符号位取1
                datatemp *= (-1)
            End If
            datatempint = Int(datatemp) '整数部分
            Do While (datatempint > 0)
                bintemp = IIf(datatempint Mod 2 = 1, "1", "0") + bintemp '对 datatempint 求余数 如果为1 ‘1’  如果为0 ‘0’
                datatempint \= 2 '除以2
            Loop
            cotleft = Len(bintemp)
            datatempdot = datatemp - Int(datatemp) '小数部分
            bintemp += "." '加个点  在整数后边
            For i = 0 To 19 '涉及到小数可能无限循环下去，所以统一都计算20次，够的后边全为0，不够的强行截止
                datatempdot *= 2
                bintemp += IIf(datatempdot >= 1, "1", "d")
                datatempdot -= Int(datatempdot)
            Next
            j = Len(bintemp)
            If Int(datatemp) > 0 Then '确定小数点左移、右移
                cotmove = cotleft - 1 + 127 '与127计算，即移码运算
            Else
                cotright = InStr(Mid(bintemp, 2, j - 1), "1") '截取字符串 2~ j-1  后 查找字符串“1”
                cotmove = 127 - cotright
            End If
            Do While (cotmove > 0) '计算指数，8位
                bintempindex = IIf(cotmove Mod 2 = 1, "1", "0") + bintempindex
                cotmove \= 2
            Loop
            i = Len(bintempindex)
            If i < 8 Then
                For i = 0 To 8 - Len(bintempindex) - 1
                    bintempindex = "0" + bintempindex
                Next
            End If
            binresult += bintempindex
            If Int(datatemp) > 0 Then
                binresult += Mid(bintemp, 2, cotleft - 1) + Mid(bintemp, cotleft + 2, j - cotleft - 1)
            Else
                binresult += Mid(bintemp, cotright + 2, j - cotright - 1)
            End If
            If Len(binresult) >= 32 Then '4个字节，补齐32位
                binresult = Mid(binresult, 1, 32)
            Else
                For i = 0 To 32 - Len(binresult) - 1
                    binresult += "0"
                Next
            End If
        End If
        str1 = Mid(binresult, 1, 8)
        str2 = Mid(binresult, 9, 8)
        str3 = Mid(binresult, 17, 8)
        str4 = Mid(binresult, 25, 8)
        bytessend(byt0) = Val(Mid(str1, 8, 1)) + Val(Mid(str1, 7, 1)) * 2 + Val(Mid(str1, 6, 1)) * 2 ^ 2 + Val(Mid(str1, 5, 1)) * 2 ^ 3 + Val(Mid(str1, 4, 1)) * 2 ^ 4 + Val(Mid(str1, 3, 1)) * 2 ^ 5 + Val(Mid(str1, 2, 1)) * 2 ^ 6 + Val(Mid(str1, 1, 1)) * 2 ^ 7
        bytessend(byt1) = Val(Mid(str2, 8, 1)) + Val(Mid(str2, 7, 1)) * 2 + Val(Mid(str2, 6, 1)) * 2 ^ 2 + Val(Mid(str2, 5, 1)) * 2 ^ 3 + Val(Mid(str2, 4, 1)) * 2 ^ 4 + Val(Mid(str2, 3, 1)) * 2 ^ 5 + Val(Mid(str2, 2, 1)) * 2 ^ 6 + Val(Mid(str2, 1, 1)) * 2 ^ 7
        bytessend(byt2) = Val(Mid(str3, 8, 1)) + Val(Mid(str3, 7, 1)) * 2 + Val(Mid(str3, 6, 1)) * 2 ^ 2 + Val(Mid(str3, 5, 1)) * 2 ^ 3 + Val(Mid(str3, 4, 1)) * 2 ^ 4 + Val(Mid(str3, 3, 1)) * 2 ^ 5 + Val(Mid(str3, 2, 1)) * 2 ^ 6 + Val(Mid(str3, 1, 1)) * 2 ^ 7
        bytessend(byt3) = Val(Mid(str4, 8, 1)) + Val(Mid(str4, 7, 1)) * 2 + Val(Mid(str4, 6, 1)) * 2 ^ 2 + Val(Mid(str4, 5, 1)) * 2 ^ 3 + Val(Mid(str4, 4, 1)) * 2 ^ 4 + Val(Mid(str4, 3, 1)) * 2 ^ 5 + Val(Mid(str4, 2, 1)) * 2 ^ 6 + Val(Mid(str4, 1, 1)) * 2 ^ 7
    End Sub

    Private Sub Timhand_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timhand.Tick
        Call acqcurrentdata()
        Application.DoEvents()
        lblfqlleft.Text = Format(datasensorfqlleft - Val(paranew(27)), "0")
        lblfqlright.Text = Format(datasensorfqlright - Val(paranew(28)), "0")
        lblwy.Text = Format(datasensorwy, "0.00")
        ' TextBox3.Text = "左压力" + datasensorfqlleft.ToString() + " 左压力调整 -/ " + Val(paranew(27)).ToString() + " * 左压力零点偏置" + Val(paranew(26)).ToString() +
        '    "右压力" + datasensorfqlright.ToString() + " 右压力调整 -/ " + Val(paranew(28)).ToString() + " * 右压力零点偏置" + Val(paranew(26)).ToString()
        ''手动调试可换向
        'leftchg = Val(lblfqlleft.Text)
        'If leftchg >= Val(paranew(19)) And leftchgflag = 0 Then
        '    leftchgflag = 1
        '    rightchgflag = 0
        '    d2210_decel_stop(m_UseAxis, 0.1) '停止运动
        '    DelayS(0.1)
        '    Dir1 = 0 '逆转
        '    Call move_start()
        'End If
        'rightchg = Val(lblfqlright.Text)
        'If rightchg >= Val(paranew(19)) And rightchgflag = 0 Then
        '    rightchgflag = 1
        '    leftchgflag = 0
        '    d2210_decel_stop(m_UseAxis, 0.1) '停止运动
        '    DelayS(0.1)
        '    Dir1 = 1 '右移
        '    Call move_start()
        'End If

    End Sub

    '赋值操作-主界面
    Public Sub setparamain()
        Dim db As DataGridView = datatest
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

    '实验结果保存
    Public Sub datasave(ByVal ogcount As Integer) '输入的参数是  合格或者不合格的数量
        Dim counttemp As String

        If ngflag = 1 Then
            counttemp = Now.ToString("yyyyMMddHHmmss") & Format(ogcount, "00000")
            mypiecedata.datasaverec(0) = counttemp & "Ng"
        Else
            counttemp = Now.ToString("yyyyMMddHHmmss") & Format(ogcount, "00000")
            mypiecedata.datasaverec(0) = counttemp
        End If
        bianhao.Text = mypiecedata.datasaverec(0) '产品编号输入TEXTbox框
        my_oknum = Val(lblok.Text)
        my_ngnum = Val(lblng.Text)
        my_allnum = Val(lblall.Text)
        Call savecount(my_oknum, my_ngnum, my_allnum) '计数保存

        Call saveerycheckresult() '保存实验结果——不包含间隙检测结果

        If fqjianxiexp Then
            Call savejianxiexp() '保存间隙检测结果
        End If
        Call saveshowdata(mypiecedata.datasaverec(0)) '保存采样数据，统一用编号命名，防止采用条码重做后覆盖数据
    End Sub

    '计数保存，防止中途关闭软件重启后数据丢失
    Public Sub savecount(ByVal temp1 As Integer, ByVal temp2 As Integer, ByVal temp3 As Integer)
        Dim filenum As String
        Dim mysw As System.IO.StreamWriter

        filenum = Apppath & "\Sys\" & prefpiecetype & ".txt"
        If Dir(filenum) <> "" Then File.Delete(filenum)
        mysw = New System.IO.StreamWriter(filenum, True)
        mysw.WriteLine(temp1)
        mysw.WriteLine(temp2)
        mysw.WriteLine(temp3)
        mysw.Close()
    End Sub

    '保存各测试项结果
    Public Sub saveerycheckresult()
        'OpenConnNew()
        GlobalVariable.Piecedatasave = New DataClasses_PIECEDATASAVEDataContext()

        If scancodeflag = True Then
            Dim cust1 As New piecedatasave1 With {
                        .编号 = mypiecedata.datasaverec(0),
                        .日期 = mypiecedata.datasaverec(1),
                        .工件类别 = mypiecedata.datasaverec(2),
                        .条码 = mypiecedata.datasaverec(3),
                        .结果 = mypiecedata.datasaverec(4),
                        .右反驱力最大值 = mypiecedata.datasaverec(5),
                        .右反驱力最小值 = mypiecedata.datasaverec(6),
                        .右反驱力波动量 = mypiecedata.datasaverec(7),
                        .右反驱力平均值 = mypiecedata.datasaverec(8),
                        .右反驱动位移 = mypiecedata.datasaverec(9),
                        .左反驱力最大值 = mypiecedata.datasaverec(10),
                        .左反驱力最小值 = mypiecedata.datasaverec(11),
                        .左反驱力波动量 = mypiecedata.datasaverec(12),
                        .左反驱力平均值 = mypiecedata.datasaverec(13),
                        .左反驱动位移 = mypiecedata.datasaverec(14),
                        .左右反驱力平均值差值 = mypiecedata.datasaverec(20),
                        .左右波动量差值 = mypiecedata.datasaverec(15)
                    }

            GlobalVariable.Piecedatasave.piecedatasave1.InsertOnSubmit(cust1)
            GlobalVariable.Piecedatasave.SubmitChanges()


        Else
            Dim cust2 As New piecedatasave1 With {
                        .编号 = mypiecedata.datasaverec(0),
                        .日期 = mypiecedata.datasaverec(1),
                        .工件类别 = mypiecedata.datasaverec(2),
                        .结果 = mypiecedata.datasaverec(4),
                       .右反驱力最大值 = mypiecedata.datasaverec(5),
                       .右反驱力最小值 = mypiecedata.datasaverec(6),
                       .右反驱力波动量 = mypiecedata.datasaverec(7),
                       .右反驱力平均值 = mypiecedata.datasaverec(8),
                       .右反驱动位移 = mypiecedata.datasaverec(9),
                       .左反驱力最大值 = mypiecedata.datasaverec(10),
                       .左反驱力最小值 = mypiecedata.datasaverec(11),
                       .左反驱力波动量 = mypiecedata.datasaverec(12),
                       .左反驱力平均值 = mypiecedata.datasaverec(13),
                       .左反驱动位移 = mypiecedata.datasaverec(14),
                       .左右反驱力平均值差值 = mypiecedata.datasaverec(20),
                       .左右波动量差值 = mypiecedata.datasaverec(15)
                   }
            GlobalVariable.Piecedatasave.piecedatasave1.InsertOnSubmit(cust2)
            GlobalVariable.Piecedatasave.SubmitChanges()
        End If

        Return

        If scancodeflag = True Then
            MyOledbCommand.CommandText = "insert into piecedatasave (编号,日期,工件类别,条码,结果) values ('" + mypiecedata.datasaverec(0) + "','" + mypiecedata.datasaverec(1) + "','" + mypiecedata.datasaverec(2) + "','" + mypiecedata.datasaverec(3) + "','" + mypiecedata.datasaverec(4) + "')"
        Else
            MyOledbCommand.CommandText = "insert into piecedatasave (编号,日期,工件类别,结果) values ('" + mypiecedata.datasaverec(0) + "','" + mypiecedata.datasaverec(1) + "','" + mypiecedata.datasaverec(2) + "','" + mypiecedata.datasaverec(4) + "')"
        End If
        MyOledbCommand.Connection = OleDbConnrecd
        MyOledbCommand.ExecuteNonQuery()
        MyOledbCommand.CommandText = "Update piecedatasave set " _
            & "右反驱力最大值= '" & mypiecedata.datasaverec(5) & "', " _
            & "右反驱力最小值= '" & mypiecedata.datasaverec(6) & "', " _
            & "右反驱力波动量= '" & mypiecedata.datasaverec(7) & "', " _
            & "右反驱力平均值= '" & mypiecedata.datasaverec(8) & "', " _
            & "右反驱动位移= '" & mypiecedata.datasaverec(9) & "', " _
            & "左反驱力最大值= '" & mypiecedata.datasaverec(10) & "', " _
            & "左反驱力最小值= '" & mypiecedata.datasaverec(11) & "', " _
            & "左反驱力波动量= '" & mypiecedata.datasaverec(12) & "', " _
            & "左反驱力平均值= '" & mypiecedata.datasaverec(13) & "', " _
            & "左反驱动位移= '" & mypiecedata.datasaverec(14) & "', " _
            & "左右反驱力平均值差值= '" & mypiecedata.datasaverec(20) & "', " _
            & "左右波动量差值= '" & mypiecedata.datasaverec(15) & "' where 编号 = '" & mypiecedata.datasaverec(0) & "'"
        MyOledbCommand.Connection = OleDbConnrecd
        MyOledbCommand.ExecuteNonQuery()
        'CloseConnNew()
    End Sub

    '保存间隙检测结果
    Public Sub savejianxiexp()


        GlobalVariable.Piecedatasave = New DataClasses_PIECEDATASAVEDataContext()




        Try
            Dim updateCust = (From cust In GlobalVariable.Piecedatasave.piecedatasave1
                              Where cust.编号 = mypiecedata.datasaverec(0)).ToList()(0)
            updateCust.上拉齿条径向间隙 = mypiecedata.datasaverec(16)
            updateCust.上拉齿条径向力 = mypiecedata.datasaverec(17)
            updateCust.下拉齿条径向间隙 = mypiecedata.datasaverec(18)
            updateCust.下拉齿条径向力 = mypiecedata.datasaverec(19)

            GlobalVariable.Piecedatasave.SubmitChanges()
        Catch
            MessageBox.Show("保存间隙检测结果失败")
            ' Handle exception.  
        End Try
        Return
        'OpenConnNew()
        MyOledbCommand.Connection = OleDbConnrecd
        'MyOledbCommand.ExecuteNonQuery()
        MyOledbCommand.CommandText = "Update piecedatasave set " _
        & "上拉齿条径向间隙= '" & mypiecedata.datasaverec(16) & "', " _
        & "上拉齿条径向力= '" & mypiecedata.datasaverec(17) & "', " _
        & "下拉齿条径向间隙= '" & mypiecedata.datasaverec(18) & "', " _
        & "下拉齿条径向力= '" & mypiecedata.datasaverec(19) & "' where 编号 = '" & mypiecedata.datasaverec(0) & "'"
        MyOledbCommand.Connection = OleDbConnrecd
        MyOledbCommand.ExecuteNonQuery()
        'CloseConnNew()
    End Sub

    '保存查询界面重新画图数据-点数(huituend-huitustart)+扭矩+角度，先全部扭矩再全部角度
    Public Sub saveshowdata(ByVal savenumtemp As String)
        ReDim datasaveload(mypiecedata.mcountdata) '保存采样点——力值
        ReDim datasavepos(mypiecedata.mcountdata) '保存采样点——位移值
        Dim i As Integer
        Dim filenum As String
        Dim mysw As System.IO.StreamWriter
        Dim yy As String
        Dim mm As String
        Dim dd As String

        For i = 0 To mypiecedata.mcountdata
            datasaveload(i) = Format(datasensor(i), "0.00")
            datasavepos(i) = Format(datawy(i), "0.00")
        Next i
        countcxsave = mypiecedata.huituend - mypiecedata.huitustart + 1
        countcxhuituend1 = mypiecedata.huituend1 - mypiecedata.huitustart + 1
        countcxhuitustart1 = mypiecedata.huitustart1 - mypiecedata.huitustart + 1
        yy = Now.Year & "年"
        mm = Now.Month & "月"
        dd = Now.Day & "日"
        filenum = Apppath & "\Sys\recorddata\" & yy & "\" & mm & "\" & dd & "\" & savenumtemp & ".txt"
        If Dir(filenum) <> "" Then File.Delete(filenum)
        mysw = New System.IO.StreamWriter(filenum, True)
        mysw.WriteLine(countcxsave) '重画曲线时有效点数-查询读取曲线用
        mysw.WriteLine(countcxhuituend1) '边界点
        mysw.WriteLine(countcxhuitustart1) '边界点
        For i = mypiecedata.huitustart To mypiecedata.huituend
            mysw.WriteLine(datasaveload(i))
        Next
        For i = mypiecedata.huitustart To mypiecedata.huituend
            mysw.WriteLine(datasavepos(i))
        Next
        mysw.Close()
    End Sub
    ''' <summary>
    '''   '采集当前反驱力以及位移
    ''' </summary>
    Public Sub acqcurrentdata()
        'Dim i As Integer
        On Error Resume Next
        Dim leftlinow As Double
        Dim rightlinow As Double

        leftlinow = Abs(DAQfqlleft.Read - clearfqlleft)
        ' svel = 0
        ' For i = 9 To 0 Step -1
        '  lvboleft(i) = lvboleft(i + 1)
        ' svel += lvboleft(i)
        'Next
        'vdatafqlleft = svel / 10 '求1-11的平均值 left
        ' vdatafqlleft = lvboleft(10)
        rightlinow = Abs(DAQfqlright.Read - clearfqlright)
        ' svel = 0
        ' For i = 9 To 0 Step -1
        ' lvboright(i) = lvboright(i + 1)
        ' svel += lvboright(i)
        ' Next
        'vdatafqlright = svel / 10 * (-1) '求1-11的平均值 right
        ' vdatafqlright = lvboright(10)

        '左反驱力
        'vdatafqlleft *= -1
        datasensorfqlleft = Val(Format(Val(leftlinow) * Val(paranew(21)), "0.00")) + Val(paranew(26)) '不进行滤波
        'filterarr(9) = Format(Val(vdatafqlleft) * Val(paranew(21)), "0.00")
        'For i = 1 To 9
        '    filterarr(i - 1) = filterarr(i)
        'Next
        'scot = 0
        'For i = 0 To 9
        '    scot += filterarr(i)
        'Next
        'datasensorfqlleft = scot / 10 + Val(paranew(26))

        '右反驱力
        vdatafqlright *= -1
        datasensorfqlright = Val(Format(Val(rightlinow) * Val(paranew(22)), "0.00")) + Val(paranew(26))
        'filterarr(9) = Format(Val(vdatafqlright) * Val(paranew(22)), "0.00")
        'For i = 1 To 9
        '    filterarr(i - 1) = filterarr(i)
        'Next
        'scot = 0
        'For i = 0 To 9
        '    scot += filterarr(i)
        'Next
        'datasensorfqlright = scot / 10 + Val(paranew(26))
        'TextBox3.Text = datasensorfqlleft.ToString() + "当前电压" + DAQfqlleft.Read.ToString() + "//零点" + clearfqlleft.ToString() + "//" + Val(Format(Val(leftlinow) * Val(paranew(21)), "0.00")).ToString() + "零点偏置" + Val(paranew(26)).ToString() +
        '"右侧 " + DAQfqlright.Read.ToString() + "//零点 " + clearfqlright.ToString()
        '位移
        '待确定滤波效果，由于位移在中位时为零，两侧运动有正负区分，滤波会引入误差
        '若位移不需要滤波，则力的滤波算法也必须去掉
        vdatawy = DAQwy.Read - clearwy
        If vdatawy > 0.2859 Then '位移分段，10mm为分段界限
            vdatawy -= 0.2859
            datasensorwy = Format(Val(vdatawy) * Val(paranew(23)) + 10, "0.00")
        Else
            datasensorwy = Format(Val(vdatawy) * 34.977, "0.00")
        End If
        'datasensorwy = Format(Val(vdatawy) * Val(paranew(23)), "0.00")


        'filterarr(9) = Format(Val(vdatawy) * Val(paranew(23)), "0.00")
        'For i = 1 To 9
        '    filterarr(i - 1) = filterarr(i)
        'Next
        'scot = 0
        'For i = 0 To 9
        '    scot += filterarr(i)
        'Next
        'datasensorwy = scot / 10 + Val(paranew(26))

    End Sub

    '判定具体指标合格否，注意x1在传递时是否正确，不正确则改为ByRef或去掉
    Public Sub PdOkOrNg(ByVal x1 As Double, ByVal x2 As Integer, ByVal x3 As Integer, ByVal x4 As Integer) '(判定数据，判定上下限，存储位置，显示行数)
        Dim t10, t11 As Double
        Dim pdtemp As Double

        t10 = Val(paranew(x2 + 1))
        t11 = Val(paranew(x2))
        datatest.Rows(x4).Cells(3).Value = Format(x1, "0.000") '显示数据
        mypiecedata.datasaverec(x3) = Format(x1, "0.000")  '存储数据
        pdtemp = Val(Format(x1, "0.000"))
        If pdtemp >= t10 And pdtemp <= t11 Then '判断数据
            okorngflag(x4) = True
            datatest.Rows(x4).Cells(3).Style.BackColor = Color.Lime
        Else
            okorngflag(x4) = False
            datatest.Rows(x4).Cells(3).Style.BackColor = Color.Red
        End If
    End Sub

    '各测试项检测
    '右侧为eftcot1——count3
    '左侧为eftcot2——count4
    Public Sub OkOrNg()
        Call maxfqlR() '右反驱力最大值
        Call minfqlR() '右反驱力最小值
        Call fqlbdR() '右反驱力波动量
        'Call avgfqlR() '右反驱力平均值——现由于波形要做处理，所以将该算法移到重画图之前
        Call wyR() '右反驱动位移
        Call maxfqlL() '左反驱力最大值
        Call minfqlL() '左反驱力最小值
        Call fqlbdL() '左反驱力波动量
        'Call avgfqlL() '左反驱力平均值
        Call wyL() '左反驱动位移
        Call bothbdcha() '左右波动量差值
        Call bothaqlavg() '左右反驱力平均值差值
        'cotjianxi += 1
        'If cotjianxi >= jianxicheckinte Then
        '    bytessend(22) = 2
        '    DelayS(0.05)
        '    Call jianxiexp() '间隙检测
        '    cotjianxi = 0
        '    fqjianxiexp = True '检测执行标识——保存数据用
        'End If
        datatest.Rows(3).Cells(3).Value = Format(Abs(pdavgfqlR), "0.00") '显示数据
        If okorngflag(3) = True Then
            datatest.Rows(3).Cells(3).Style.BackColor = Color.Lime
        Else
            datatest.Rows(3).Cells(3).Style.BackColor = Color.Red
        End If
        datatest.Rows(8).Cells(3).Value = Format(Abs(pdavgfqlL), "0.00") '显示数据
        If okorngflag(8) = True Then
            datatest.Rows(8).Cells(3).Style.BackColor = Color.Lime
        Else
            datatest.Rows(8).Cells(3).Style.BackColor = Color.Red
        End If
    End Sub

    '右反驱力最大值
    Public Sub maxfqlR()
        Dim f3 As Integer

        pdmaxfqlR = -1
        For f3 = eftcot1 To count3
            If pdmaxfqlR < datasensor(f3) Then
                pdmaxfqlR = datasensor(f3)
            End If
        Next f3
        Call PdOkOrNg(Abs(pdmaxfqlR), 1, 5, 0) '(判定数据，判定上下限，存储位置，显示行数)
    End Sub

    '右反驱力最小值
    Public Sub minfqlR()
        Dim f3 As Integer

        pdminfqlR = 500
        For f3 = eftcot1 To count3
            If pdminfqlR > datasensor(f3) Then
                pdminfqlR = datasensor(f3)
            End If
        Next f3
        Call PdOkOrNg(Abs(pdminfqlR), 3, 6, 1) '(判定数据，判定上下限，存储位置，显示行数)
    End Sub

    '右反驱力波动量
    Public Sub fqlbdR()
        Dim f3 As Integer

        pdmaxfqlR = -1
        For f3 = eftcot1 To count3
            If pdmaxfqlR < datasensor(f3) Then
                pdmaxfqlR = datasensor(f3)
            End If
        Next f3
        pdminfqlR = 500
        For f3 = eftcot1 To count3
            If pdminfqlR > datasensor(f3) Then
                pdminfqlR = datasensor(f3)
            End If
        Next f3
        pdbdfqlR = Abs(pdmaxfqlR - pdminfqlR)
        Call PdOkOrNg(pdbdfqlR, 5, 7, 2) '(判定数据，判定上下限，存储位置，显示行数)
    End Sub

    '右反驱力平均值
    Public Sub avgfqlR()
        Dim f3 As Integer

        pdavgfqlR = 0
        For f3 = eftcot1 To count3
            pdavgfqlR += datasensor(f3)
        Next f3
        pdavgfqlR = pdavgfqlR / (count3 - eftcot1 + 1)

        Dim t10, t11 As Double
        Dim pdtemp As Double
        t10 = Val(paranew(8)) '反驱力平均值下限
        t11 = Val(paranew(7)) '反驱力平均值上限
        mypiecedata.datasaverec(8) = Format(Abs(pdavgfqlR), "0.00")  '存储数据
        pdtemp = Val(Format(Abs(pdavgfqlR), "0.00"))
        If pdtemp >= t10 And pdtemp <= t11 Then '判断数据
            okorngflag(3) = True
        Else
            okorngflag(3) = False
        End If
        'Call PdOkOrNg(Abs(pdavgfqlR), 7, 8, 3) '(判定数据，判定上下限，存储位置，显示行数)
    End Sub

    '右反驱动位移
    Public Sub wyR()
        pdwyR = 0
        pdwyR = maxwy2 - maxwy3
        Call PdOkOrNg(Abs(pdwyR) + Val(paranew(48)), 11, 9, 4) '(判定数据，判定上下限，存储位置，显示行数)
    End Sub

    '左反驱力最大值
    '实际意义上的最大值，即对应波形的波谷
    Public Sub maxfqlL()
        Dim f3 As Integer

        pdmaxfqlL = 1
        For f3 = eftcot2 To count4
            If pdmaxfqlL > datasensor(f3) Then
                pdmaxfqlL = datasensor(f3)
            End If
        Next f3
        Call PdOkOrNg(Abs(pdmaxfqlL), 1, 10, 5) '(判定数据，判定上下限，存储位置，显示行数)
    End Sub

    '左反驱力最小值
    Public Sub minfqlL()
        Dim f3 As Integer

        pdminfqlL = -500
        For f3 = eftcot2 To count4
            If pdminfqlL < datasensor(f3) Then
                pdminfqlL = datasensor(f3)
            End If
        Next f3
        Call PdOkOrNg(Abs(pdminfqlL), 3, 11, 6) '(判定数据，判定上下限，存储位置，显示行数)
    End Sub

    '左反驱力波动量
    Public Sub fqlbdL()
        Dim f3 As Integer

        pdmaxfqlL = -500
        For f3 = eftcot2 To count4
            If pdmaxfqlL < datasensor(f3) Then
                pdmaxfqlL = datasensor(f3)
            End If
        Next f3
        pdminfqlL = 1
        For f3 = eftcot2 To count4
            If pdminfqlL > datasensor(f3) Then
                pdminfqlL = datasensor(f3)
            End If
        Next f3
        pdbdfqlL = Abs(pdmaxfqlL - pdminfqlL)
        Call PdOkOrNg(pdbdfqlL, 5, 12, 7) '(判定数据，判定上下限，存储位置，显示行数)
    End Sub

    '左反驱力平均值
    Public Sub avgfqlL()
        Dim f3 As Integer

        pdavgfqlL = 0
        For f3 = eftcot2 To count4 '有可能差一个数，起始数
            pdavgfqlL += datasensor(f3)
        Next f3
        pdavgfqlL = pdavgfqlL / (count4 - eftcot2 + 1)

        Dim t10, t11 As Double
        Dim pdtemp As Double

        t10 = Val(paranew(8))
        t11 = Val(paranew(7))
        mypiecedata.datasaverec(13) = Format(Abs(pdavgfqlL), "0.00")  '存储数据
        pdtemp = Val(Format(Abs(pdavgfqlL), "0.00"))
        If pdtemp >= t10 And pdtemp <= t11 Then '判断数据
            okorngflag(8) = True
        Else
            okorngflag(8) = False
        End If
        'Call PdOkOrNg(Abs(pdavgfqlL), 7, 13, 8) '(判定数据，判定上下限，存储位置，显示行数)
    End Sub

    '左反驱动位移
    Public Sub wyL()
        pdwyL = 0
        pdwyL = maxwy4 - maxwy3
        Call PdOkOrNg(Abs(pdwyL) + Val(paranew(49)), 11, 14, 9) '(判定数据，判定上下限，存储位置，显示行数)
    End Sub

    '左右波动量差值
    Public Sub bothbdcha()
        pdbothbd = 0
        pdbothbd = Abs(pdbdfqlR - pdbdfqlL)
        Call PdOkOrNg(Abs(pdbothbd), 9, 15, 10) '(判定数据，判定上下限，存储位置，显示行数)
    End Sub

    '左右反驱力平均值差值
    Public Sub bothaqlavg()
        pdbothavgfql = 0
        pdbothavgfql = Abs(pdavgfqlR - Abs(pdavgfqlL))
        Call PdOkOrNg(Abs(pdbothavgfql), 35, 20, 11) '(判定数据，判定上下限，存储位置，显示行数)
    End Sub

    '间隙检测
    Public Sub jianxiexp()
        Dim checkupflag As Boolean '上拉检测完成标识
        Dim checkdownflag As Boolean '下拉检测完成标识
        Dim checkzeroflag As Boolean '原位采集完成标识

        Do Until checkupflag = True AndAlso checkdownflag = True AndAlso checkzeroflag = True '保证实验完成(原位、上拉、下拉)
            Do While bytesrecd(48) = 1 AndAlso checkzeroflag = False '48下拉测间隙开始                原位， 保证值只采集一次
                vdatajingxi = DAQjxjx.Read
                jianxilizero = DAQjxl.Read
                jianxizero = Format(vdatajingxi * Val(paranew(25)), "0.00") '25 径向间隙标定
                checkzeroflag = True
                bytessend(307) = 1 '什么时候复位现场待确定
            Loop
            Do While bytesrecd(46) = 1 AndAlso checkupflag = False '上拉 46上拉测间隙开始
                vdatajingxi = DAQjxjx.Read
                pdjingxjianxiup = Format(vdatajingxi * Val(paranew(25)), "0.00") - jianxizero
                pdjingxjianxiup *= Val(paranew(32))  '32 间隙检测调整系数
                vdatajingxli = DAQjxl.Read - jianxilizero
                pdjingxliup = Format(vdatajingxli * Val(paranew(24)), "0.00") '24径向力标定
                pdjingxliup *= Val(paranew(32))
                checkupflag = True
                bytessend(27) = 1 '27上拉测间隙结束
                DelayS(0.1)
                bytessend(27) = 0
            Loop
            Do While bytesrecd(47) = 1 AndAlso checkdownflag = False '下拉
                vdatajingxi = DAQjxjx.Read
                pdjingxjianxidown = Format(vdatajingxi * Val(paranew(25)), "0.00") - jianxizero
                pdjingxjianxidown *= Val(paranew(32))
                vdatajingxli = DAQjxl.Read - jianxilizero
                pdjingxlidown = Format(vdatajingxli * Val(paranew(24)), "0.00")
                pdjingxlidown *= Val(paranew(32))
                checkdownflag = True
                bytessend(28) = 1
                DelayS(0.1)
                bytessend(28) = 0
            Loop
        Loop
        Call PdOkOrNg(Abs(pdjingxjianxiup), 13, 16, 11) '上拉间隙 (判定数据，判定上下限，存储位置，显示行数)
        Call PdOkOrNg(Abs(pdjingxliup), 15, 17, 12) '上拉力
        Call PdOkOrNg(Abs(pdjingxjianxidown), 13, 18, 13) '下拉间隙
        Call PdOkOrNg(Abs(pdjingxlidown), 15, 19, 14) '下拉力
    End Sub

    '系统归零
    '为保证一致性，必须先运动到归零位处再运动到零位！
    '应该考虑到可能回到中位后没停住，需要向相反方向运动继续，直到回零
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        If bytesrecd(1) = 0 Then '无工件可归零
            volwy = Format(DAQwy.Read, "0.00")
            volzerowy = Val(paranew(33))
            If volwy > volzerowy Then moveleft = 1 '在中位右侧需向左运动
            If volwy < volzerowy Then moveright = 1 '在中位左侧需向右运动
            Timzero.Enabled = True
        Else
            MsgBox("请取走工件，重新归零", vbOKOnly, "Err")
        End If
    End Sub

    Private Sub Timzero_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timzero.Tick

        volwy = Format(DAQwy.Read, "0.00")
        '现采用机械上绝对零位，即零位位移传感器电压是绝对值
        If moveleft = 1 Then '在中位右侧需向左运动
            If zeromoveflag = 0 Then
                zeromoveflag = 1
                'Dir1 = 0
                'Call move_start3()
                d2210_set_profile(0, 50, 20000, 0.5, 0.1)
                d2210_t_vmove(0, 0)
            End If
            If bytesrecd(61) = 1 And zeromoveflag = 1 Then '归零位  61 电缸左限位(归零位)

                zeromoveflag = 2
                d2210_decel_stop(m_UseAxis, 0) '停止运动
                zerored1 = 1
            End If
            If zerored1 = 1 And zerored2 <= 3 Then
                zerored2 += 1
            End If
            If zerored2 = 3 Then
                'Dir1 = 1
                'Call move_start1()
                d2210_set_profile(0, 50, 9000, 0.5, 0.1)
                d2210_t_vmove(0, 1)
                zerored2 = 4
            End If
            If volwy >= Val(paranew(33)) And zerored2 = 4 Then '零位判断基准电压
                d2210_decel_stop(m_UseAxis, 0) '停止运动
                clearwy = DAQwy.Read '零位电压作为基准值
                'clearfqlleft = DAQfqlleft.Read '现场会出现回零带工件操作，导致左侧压力相对零点不准确，压头接触工件了
                'clearfqlright = DAQfqlright.Read
                zeromoveflag = 0
                zerored1 = 0
                zerored2 = 0
                moveleft = 0
                moveright = 0
                Timzero.Enabled = False
            End If
        End If
        If moveright = 1 Then
            If zeromoveflag = 0 Then
                zeromoveflag = 1
                'Dir1 = 1 '在中位左侧需向右运动
                'Call move_start1()
                d2210_set_profile(0, 50, 20000, 0.5, 0.1)
                d2210_t_vmove(0, 1)
            End If
            If volwy >= Val(paranew(33)) Then
                d2210_decel_stop(m_UseAxis, 0) '停止运动
                clearwy = DAQwy.Read '零位电压作为基准值
                'clearfqlleft = DAQfqlleft.Read
                'clearfqlright = DAQfqlright.Read
                zeromoveflag = 0
                moveleft = 0
                moveright = 0
                Timzero.Enabled = False
            End If
        End If

        ''原代码，利用归零位、零位开关归零
        'If moveleft = 1 Then '在中位右侧需向左运动
        '    If zeromoveflag = 0 Then
        '        zeromoveflag = 1
        '        Dir1 = 0
        '        Call move_start1()
        '    End If
        '    If bytesrecd(61) = 1 And zeromoveflag = 1 Then '归零位
        '        zeromoveflag = 2
        '        backzero = 1
        '        d2210_decel_stop(m_UseAxis, 0) '停止运动
        '        zerored1 = 1
        '    End If
        'End If
        'If zerored1 = 1 Then
        '    If zerored2 = 3 Then
        '        Dir1 = 1
        '        Call move_start1()
        '    End If
        '    zerored2 += 1
        'End If
        'If moveright = 1 Then zeromoveflag = 3
        'If moveright = 1 And zeromoveflag = 3 Then
        '    zeromoveflag = 4
        '    backzero = 1
        '    Dir1 = 1 '在中位左侧需向右运动
        '    Call move_start1()
        'End If
        'If backzero = 1 And bytesrecd(60) = 1 Then '零位
        '    d2210_decel_stop(m_UseAxis, 0) '停止运动
        '    clearwy = DAQwy.Read '零位电压作为基准值
        '    clearfqlleft = DAQfqlleft.Read
        '    clearfqlright = DAQfqlright.Read
        '    zeromoveflag = 0
        '    backzero = 0
        '    zerored1 = 0
        '    zerored2 = 0
        '    moveleft = 0
        '    moveright = 0
        '    Timzero.Enabled = False
        'End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem
            Case "在线"
                paranew(20) = "有效"
                scancodeflag = True
                Label17.Enabled = True
                bytessend(699) = 0 '使用追溯系统
            Case "离线"
                paranew(20) = "无效"
                scancodeflag = False
                Label17.Enabled = False
                bytessend(699) = 1 '不使用追溯系统
        End Select
    End Sub

    Private Sub plccomsstate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plccomsstate.Click
        frmZero.Show() '通过密码输入窗口   显示标定按钮
    End Sub

    Public Sub PortOpen()
        Try
            SerialPort1.Open()
        Catch ex As Exception
            '  SerialPort1.Close()

            MsgBox("串口被占用或串口错误！", MsgBoxStyle.Information, "提示！")
        End Try
    End Sub

    Public Sub PortClose()
        Try
            SerialPort1.Close()
        Catch ex As Exception
            MsgBox("串口被占用或串口错误！", MsgBoxStyle.Information, "提示！")
        End Try
    End Sub

    Public Function ComRec() As String
        Dim Rxstr As String
        Try
            ComSnd("SR,00,002" + vbCrLf)
            ' Return postemp
            DelayS(0.01)
            Rxstr = SerialPort1.ReadLine
            'Application.DoEvents()
            glo_Rxstr = Rxstr
            Return Rxstr

        Catch ex As TimeoutException
            Rxstr = SerialPort1.ReadExisting
            'Application.DoEvents()
            glo_Rxstr = "null"
            Return Rxstr
        End Try
    End Function

    Public Sub ComSnd(ByVal snd As String)
        If SerialPort1.IsOpen Then

            SerialPort1.Write(snd)
        Else
            SerialPort1.Open()
            SerialPort1.Write(snd)
            '  MsgBox("端口被关闭！")
        End If


    End Sub

    Public Function readpos()
        Dim Rxstr As String
        Dim postemp As Double


        Rxstr = glo_Rxstr
        postemp = Val(Mid(Rxstr, 11, 9))


        Return postemp
    End Function

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub DAQfqlleft_DAQPilotError(ByVal sender As System.Object, ByVal e As AxDAQPILOTAXLib._IDAQPilotEngineEvents_DAQPilotErrorEvent) Handles DAQfqlleft.DAQPilotError

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        '  Dim customers As Table(Of piecedatasave) = piecedatasave


        Dim companyNameQuery = From cust In GlobalVariable.Piecedatasave.piecedatasave1 Where cust.上拉齿条径向力 = "1" Select cust.结果



        For Each customer In companyNameQuery
            MessageBox.Show(customer.ToString())
        Next
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        If bytessend(20) = 0 Then
            bytessend(20) = 1
        Else
            bytessend(20) = 0
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Login.ShowDialog()   '加载登录对话框
    End Sub
End Class

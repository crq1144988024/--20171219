Imports TELib
Imports ListControls
Imports System.IO
Imports System.Data
Imports System.Data.OleDb  'Therrasim Librarite e OLEDB
Imports ADODB
Imports System.Math

Module mVariblesForUI
    Public m_UseAxis As Integer
    Public Declare Function Frequency Lib "exacttimer.dll" () As Double
    Public Declare Function NowCounter Lib "exacttimer.dll" () As Double '计数器
    Public Apppath = Application.StartupPath '定位到debug
    Public Connstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Apppath & "\Sys\paradata.mdb;" & "Persist Security Info=False" '参数数据库路径
    Public Connstringnew As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Apppath & "\Sys\datasave.mdb;" & "Persist Security Info=False" '数据记录数据库路径
    Public OleDbConnpara As New OleDbConnection(Connstring) '连接参数数据库
    Public OleDbConnrecd As New OleDbConnection(Connstringnew) '连接保存结果数据库
    Public MyDataSet As New DataSet '声明记录集对象

    Public MyOleDataAdapter As New OleDbDataAdapter
    Public MyOledbCommand As New OleDbCommand
    Public MyRec As New ADODB.Recordset
    Public Myconn As New ADODB.Connection
    Public paranew(49) As String '参数
    Public mypiecedata As piecedataStruct '存储实验结果
    Public my_oknum As Integer
    Public my_ngnum As Integer
    Public my_allnum As Integer
    Public countpiecepara As Integer  '工件类别个数
    Public countpiece As Integer 'OK编号计算
    Public countpieceng As Integer 'NG产品编号计数
    Public prefpiecetype As String '产品型号
    Public scancodeflag As Boolean '扫码标识——默认工序是必须扫码，赋真值
    Public flagok As Boolean 'OK/NG判断标识
    Public okorngflag(15) As Boolean '各测试项判断结果以及超时判断
    Public huituflag As Boolean '画图标识
    Public Const RealCurveNum As Short = 1 '实际曲线编号
    Public moveflag As Integer '正反转控制
    Public runflag As Boolean '自动动作标识
    Public begintest As Boolean '自动测试开始——保证只调用一次主测试函数及状态设置
    Public TStart As Double '自动起始时间
    Public Ttotal As Double '一次实验总时间
    Public wyflag As Boolean '位移采集标识
    Public datasensor(5000) As Double '采集当前力值——左右反驱力用一个数组存放，分清什么时候该采集哪个传感器的数据即可
    Public datawy(5000) As Double '采集当前位移
    'Public encodersave(1500) As Double 'd2210采集的码值——转换位移用，若位移传感器效果好则采用位移传感器即可
    Public datasaveload() As Double '保存采样点——力值
    Public datasavepos() As Double '保存采样点——位移值
    Public countcxsave As Integer '重画曲线时有效点数-查询读取曲线用
    Public countcxhuitustart1 '边界点
    Public countcxhuituend1 '边界点    
    Public count1 As Long  '全程计数
    Public count2 As Integer
    Public count3 As Integer  '2-3为右反驱力测试
    Public count4 As Integer  '3-4为左反驱力测试
    Public maxwy2 As Double '从中位运动到右侧最大位移（右边界）
    Public maxwy3 As Double '从最右侧运动到最左侧的最大位移（左边界）
    Public maxwy4 As Double '从最左侧运动到最右侧的最大位移（右边界）
    Public countAflag As Integer '找到中位标识
    Public countA As Integer '记录中位采样点位置
    Public ngflag As Integer '方便区分OK/NG编号
    Public eftcot1 As Integer
    Public eftcot2 As Integer
    Public ordersend2 As Integer
    Public ordersend3 As Integer
    Public ordersend5 As Integer
    Public ordersend6 As Integer
    Public ordersend8 As Integer
    Public ordersend9 As Integer
    Public ordersend11 As Integer

    Public Dir1 As Integer '正/逆转方向
    Public vdatafqlleft As Double '左反驱力电压
    Public vdatafqlright As Double '右反驱力电压
    Public vdatawy As Double '位移电压
    Public vdatajingxi As Double '径向间隙电压
    Public vdatajingxli As Double '径向力电压
    Public datasensorfqlleft As Double '左反驱力
    Public datasensorfqlright As Double '右反驱力
    Public datasensorwy As Double '位移
    Public datasensorjingxi As Double '径向间隙
    Public datasensorjingxli As Double '径向力
    Public scot As Double
    Public filterarr(9) As Double '滤波数据存放
    Public fqllefttemp As Double '左反驱力中介变量
    Public fqlrighttemp As Double '右反驱力中介变量
    Public sensorfqlleft As Double '检测反驱力是否超过最大力值
    Public sensorfqlright As Double
    Public jxcount As Integer '抽检间隙滤波用
    Public jxvel(10) As Double
    Public jxsum As Double

    Public pdbothavgfql As Double '左右反驱力平均值差值
    Public pdmaxfqlR As Double '右反驱力最大值
    Public pdminfqlR As Double '右反驱力最小值
    Public pdbdfqlR As Double '右反驱力波动量
    Public pdavgfqlR As Double '右反驱力平均值
    Public pdwyR As Double '右反驱动位移
    Public pdmaxfqlL As Double '左反驱力最大值
    Public pdminfqlL As Double '左反驱力最小值
    Public pdbdfqlL As Double '左反驱力波动量
    Public pdavgfqlL As Double '左反驱力平均值
    Public pdwyL As Double '左反驱动位移
    Public pdbothbd As Double '左右波动量差值
    Public pdjingxjianxiup As Double '上拉齿条径向间隙
    Public pdjingxliup As Double '上拉齿条径向力
    Public pdjingxjianxidown As Double '下拉齿条径向间隙
    Public pdjingxlidown As Double '下拉齿条径向力
    Public jianxizero As Double '间隙检测时气缸刚接触工件时的位移
    Public jianxilizero As Double '起始间隙力电压——零位
    Public sensorleftload As Double '左反驱力——实时监测是否超最大力值
    Public sensorrightload As Double '右反驱力——实时监测是否超最大力值
    Public jianxicheckinte As Integer '间隙检测频率换算为间隔件数
    Public cotjianxi As Integer = 0 '间隙检测计数，测试后复位重新计数
    Public fqjianxiexp As Boolean '检测标识
    Public clearwy As Double '位移零位
    Public clearfqlleft As Double '左反驱力零位
    Public clearfqlright As Double '右反驱力零位
    Public bytesrecd(699) As Byte 'PLC与PC通讯，一个字节对应一个字符，PLC——>PC
    Public bytessend(699) As Byte 'PC——>PLC
    Public plccoms As Integer '监控plc通讯状态

    Public leftchg As Double '手动调试换向标识等
    Public rightchg As Double
    Public leftchgflag As Integer
    Public rightchgflag As Integer
    Public handstop As Integer = 0
    Public movetestflag As Integer = 0
    Public checkupflag As Boolean '上拉检测完成标识
    Public checkdownflag As Boolean '下拉检测完成标识
    Public checkzeroflag As Boolean '原位采集完成标识

    Public sst1 As Integer = 0
    Public sst2 As Integer = 0
    Public sst3 As Integer = 0
    Public sst4 As Integer = 0
    Public sst5 As Integer = 0
    Public sst6 As Integer = 0

    Public countzero As Integer

    Public ordersend12 As Integer
    Public ordersend13 As Integer
    Public ordersend14 As Integer
    Public ordersend15 As Integer
    Public ordersend16 As Integer
    Public ordersend17 As Integer
    Public ordersend18 As Integer
    Public ordersend19 As Integer
    Public ordersend20 As Integer
    Public ordersend21 As Integer
    Public ordersend22 As Integer
    Public ordersend23 As Integer
    Public ordersend24 As Integer
    Public ordersend25 As Integer
    Public volzerowy As Double '零位基准电压

    Public zeromoveflag As Integer ' 回零标示，保持从左到右回零，即先到归零位
    Public zerowybc As Double '根据位移回零

    Public lvboleft(10) As Double
    Public lvboright(10) As Double
    Public icount As Integer
    Public svelleft As Double
    Public svel As Double
    Public svelright As Double
    Public lvboleftfql As Double
    Public lvborightfql As Double
    Public lvbortemp1 As Double
    Public lvbortemp2 As Double
    Public lvboltemp1 As Double
    Public lvboltemp2 As Double
    Public counter As Integer

    Public Declare Function GetLastError Lib "kernel32" () As Long
    '用户参数
    Structure piecedataStruct
        Dim datasaverec() As String '实验结果
        Dim mcountdata As Long '采样点数
        Dim huitustart As Long
        Dim huituend As Long
        Dim huitustart1 As Long
        Dim huituend1 As Long

        Public Sub initialize()
            ReDim datasaverec(20)  '当声明一个数组没有说明具体的维数或元素个数时，例如dim datasaverec() as string,这时如果想使用这个数组，则要使用redim重新定义这个数组，但这时注意要加上数组的维数或元素个数
        End Sub
    End Structure

    '延时程序
    Public Sub DelayS(ByRef X As Double)
        Try
            Dim StartTime As Double
            StartTime = GetTimeCount() / 1000
            Do While IIf(GetTimeCount() / 1000 - StartTime < 0, GetTimeCount() / 1000 - StartTime + 86400, GetTimeCount() / 1000 - StartTime) < X
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    '读取时间 毫秒
    Public Function GetTimeCount() As Double
        Return NowCounter / Frequency * 1000
    End Function

    '打开参数数据库
    Public Sub OpenConn()

        GlobalVariable.PiecePARA = New DataClasses_pieceparaDataContext()



        Dim companyNameQuery = From cust In GlobalVariable.PiecePARA.piecepara1 Select cust


        GlobalVariable.Datatable_para = companyNameQuery


        Return
        ' For Each customer In companyNameQuery
        'MessageBox.Show(customer.ToString())
        ' Next


        Dim Sqlstring As String

        Sqlstring = "Select * from piecepara"
        MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConnpara)
        MyOleDataAdapter.Fill(MyDataSet)
    End Sub

    '打开数据记录数据库
    Public Sub OpenConnNew()
        Dim companyNameQuery = From cust In GlobalVariable.Piecedatasave.piecedatasave1 Select cust

        Return
        Dim Sqlstring As String

        Sqlstring = "Select * from piecedatasave"
        MyOleDataAdapter.SelectCommand = New OleDbCommand(Sqlstring, OleDbConnrecd)
    End Sub

    '关闭参数数据库
    Public Sub CloseConn()

        'MyDataSet.Tables(0).Clear() '删除表中的数据，以免引起下次数据叠加
        ' MyOleDataAdapter.Dispose()
        ' MyDataSet.Dispose()
    End Sub

    '关闭数据记录数据库
    Public Sub CloseConnNew()
        ' MyDataSet.Tables(0).Clear()
        '  MyOleDataAdapter.Dispose()
    End Sub

    '打开数据记录数据库以供数据查询用
    Public Sub OpenConncx()
        MyRec = New ADODB.Recordset
    End Sub

    '关闭数据记录数据库供数据查询用
    Public Sub CloseConncx()
        'If MyRec.State = True Then
        MyRec.Close()
        MyRec = Nothing
        'End If
    End Sub

    '读取参数文件
    Public Sub readparanew(ByVal npara As String)
        Dim irow As Integer
        Dim i As Integer

        For irow = 0 To countpiecepara - 1
            If database.DataGridView1.Rows(irow).Cells(0).Value = npara Then
                Exit For
            End If
        Next irow
        For i = 0 To 19
            paranew(i) = database.DataGridView1.Rows(irow).Cells(i).Value
        Next
        For i = 21 To 49
            paranew(i) = database.DataGridView1.Rows(irow).Cells(i).Value
        Next
        volzerowy = Val(paranew(33))
    End Sub

    '回中
    Public Sub move_return()
        Dim m_nStart As Double
        Dim m_nSpeed As Double
        Dim fAcc As Double
        Dim Dir As Integer

        '设置允许单轴动态变速和动态变速的最大范围: 2M Hz。动态变速不能用于插补运动，所以在插补时需要禁止动态变速。
        '运动结束后可禁止动态变速，以及关闭控制卡
        d2210_variety_speed_range(m_UseAxis, 1, 3200000)  ' 32000   '2000000
        Dir = Dir1
        m_nStart = 500  '提取输入信息
        'm_nSpeed = Val(paranew(18)) * Val(frmSensorbiaodg.speedxs.Text)
        m_nSpeed = 0.3 * Val(frmSensorbiaodg.speedxs.Text) '速度限定死
        fAcc = 0.5
        d2210_set_profile(m_UseAxis, m_nStart, m_nSpeed, fAcc, 0.1)   '设置速度、加速度
        d2210_t_vmove(m_UseAxis, Dir) '作连续运动
        'd2210_change_speed(m_UseAxis, m_nSpeed)
    End Sub

    '起始从中位开始动作
    Public Sub move_start3()
        Dim m_nStart As Double
        Dim m_nSpeed As Double
        Dim fAcc As Double
        Dim Dir As Integer

        d2210_variety_speed_range(m_UseAxis, 1, 3200000)  ' 32000   '2000000
        Dir = Dir1
        m_nStart = 50  '提取输入信息
        m_nSpeed = 0.4 * Val(frmSensorbiaodg.speedxs.Text)
        fAcc = 3
        d2210_set_profile(m_UseAxis, m_nStart, m_nSpeed, fAcc, 0.1)   '设置速度、加速度
        d2210_t_vmove(m_UseAxis, Dir) '作连续运动
    End Sub

    '动作
    Public Sub move_start()
        Dim m_nStart As Double
        Dim m_nSpeed As Double
        Dim fAcc As Double
        Dim Dir As Integer

        d2210_variety_speed_range(m_UseAxis, 1, 3200000)  ' 32000   '2000000
        Dir = Dir1 '正/逆转方向
        m_nStart = 50  '提取输入信息
        m_nSpeed = Val(paranew(18)) * Val(frmSensorbiaodg.speedxs.Text) '测试速度
        fAcc = 3
        d2210_set_profile(m_UseAxis, m_nStart, m_nSpeed, fAcc, 0.1)   '设置速度、加速度
        d2210_t_vmove(m_UseAxis, Dir) '作连续运动
    End Sub

    '回零动作
    Public Sub move_start1()
        Dim m_nStart As Double
        Dim m_nSpeed As Double
        Dim fAcc As Double
        Dim Dir As Integer

        d2210_variety_speed_range(m_UseAxis, 1, 3200000)  ' 32000   '2000000
        Dir = Dir1
        m_nStart = 50  '提取输入信息
        m_nSpeed = 0.08 * Val(frmSensorbiaodg.speedxs.Text)
        fAcc = 3
        d2210_set_profile(m_UseAxis, m_nStart, m_nSpeed, fAcc, 0.1)   '设置速度、加速度
        d2210_t_vmove(m_UseAxis, Dir) '作连续运动
    End Sub

    Public Sub move_start2()
        Dim m_nStart As Double
        Dim m_nSpeed As Double
        Dim fAcc As Double
        Dim Dir As Integer

        d2210_variety_speed_range(m_UseAxis, 1, 3200000)  ' 32000   '2000000
        Dir = Dir1
        m_nStart = 50  '提取输入信息
        m_nSpeed = 0.2 * Val(frmSensorbiaodg.speedxs.Text)
        fAcc = 3
        d2210_set_profile(m_UseAxis, m_nStart, m_nSpeed, fAcc, 0.1)   '设置速度、加速度
        d2210_t_vmove(m_UseAxis, Dir) '作连续运动
    End Sub

    '回中速度改变
    Public Sub changespeed()
        d2210_change_speed(0, 0.4 * Val(frmSensorbiaodg.speedxs.Text))
    End Sub
End Module
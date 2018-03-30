Module GlobalVariable
    '数据库链接

    Public Piecedatasave As New DataClasses_PIECEDATASAVEDataContext

    Public PiecePARA As New DataClasses_pieceparaDataContext

    Public Datatable_save As IQueryable(Of piecedatasave)

    Public Datatable_para As IQueryable(Of piecepara)

    '线程次数
    Public ThreadCount As Integer
    '测试计时开始
    Public TestStart As Double
    '测试计时结束
    Public TestEnd As Double


    Public glo_Rxstr As String '位移值

    '读取自开机以来的系统时间，单位毫秒
    Public Declare Function timeGetTime Lib "winmm.dll" Alias "timeGetTime" () As Long




End Module

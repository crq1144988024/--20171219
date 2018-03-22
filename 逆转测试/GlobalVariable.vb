Module GlobalVariable
    '数据库链接

    Public Piecedatasave As New DataClasses_PIECEDATASAVEDataContext

    Public PiecePARA As New DataClasses_pieceparaDataContext

    Public Datatable_save As IQueryable(Of piecedatasave)

    Public Datatable_para As IQueryable(Of piecepara)


End Module

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQueryData
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chaxun = New Steema.TeeChart.TChart()
        Me.FastLine1 = New Steema.TeeChart.Styles.FastLine()
        Me.FastLine2 = New Steema.TeeChart.Styles.FastLine()
        Me.CursorTool1 = New Steema.TeeChart.Tools.CursorTool()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Listdata = New System.Windows.Forms.ListBox()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.endtime = New System.Windows.Forms.DateTimePicker()
        Me.statime = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ngsel = New System.Windows.Forms.Button()
        Me.oksel = New System.Windows.Forms.Button()
        Me.gjz = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pieresult = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.piedate = New System.Windows.Forms.TextBox()
        Me.pietm = New System.Windows.Forms.TextBox()
        Me.pienumber = New System.Windows.Forms.TextBox()
        Me.pietype = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dataRecord = New System.Windows.Forms.DataGridView()
        Me.测试项 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.下限 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.上限 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.测试结果 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dataRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.chaxun)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 769)
        Me.Panel1.TabIndex = 1
        '
        'chaxun
        '
        '
        '
        '
        Me.chaxun.Aspect.ElevationFloat = 345.0R
        Me.chaxun.Aspect.RotationFloat = 345.0R
        Me.chaxun.Aspect.View3D = False
        '
        '
        '
        '
        '
        '
        Me.chaxun.Axes.Bottom.Automatic = True
        '
        '
        '
        Me.chaxun.Axes.Bottom.Grid.ZPosition = 0R
        '
        '
        '
        Me.chaxun.Axes.Depth.Automatic = True
        '
        '
        '
        Me.chaxun.Axes.Depth.Grid.ZPosition = 0R
        '
        '
        '
        Me.chaxun.Axes.DepthTop.Automatic = True
        '
        '
        '
        Me.chaxun.Axes.DepthTop.Grid.ZPosition = 0R
        '
        '
        '
        Me.chaxun.Axes.Left.Automatic = True
        '
        '
        '
        Me.chaxun.Axes.Left.Grid.ZPosition = 0R
        '
        '
        '
        Me.chaxun.Axes.Right.Automatic = True
        '
        '
        '
        Me.chaxun.Axes.Right.Grid.ZPosition = 0R
        '
        '
        '
        Me.chaxun.Axes.Top.Automatic = True
        '
        '
        '
        Me.chaxun.Axes.Top.Grid.ZPosition = 0R
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.chaxun.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chaxun.Header.Font.Name = "宋体"
        Me.chaxun.Header.Font.Size = 12
        Me.chaxun.Header.Font.SizeFloat = 12.0!
        Me.chaxun.Header.Lines = New String() {"反驱测试曲线"}
        '
        '
        '
        '
        '
        '
        Me.chaxun.Legend.Shadow.Visible = True
        '
        '
        '
        '
        '
        '
        Me.chaxun.Legend.Title.Font.Bold = True
        '
        '
        '
        Me.chaxun.Legend.Title.Pen.Visible = False
        Me.chaxun.Location = New System.Drawing.Point(-2, -2)
        Me.chaxun.Name = "chaxun"
        Me.chaxun.Series.Add(Me.FastLine1)
        Me.chaxun.Series.Add(Me.FastLine2)
        Me.chaxun.Size = New System.Drawing.Size(521, 445)
        Me.chaxun.TabIndex = 1
        Me.chaxun.Tools.Add(Me.CursorTool1)
        '
        '
        '
        '
        '
        '
        Me.chaxun.Walls.Back.AutoHide = False
        '
        '
        '
        Me.chaxun.Walls.Bottom.AutoHide = False
        '
        '
        '
        Me.chaxun.Walls.Left.AutoHide = False
        '
        '
        '
        Me.chaxun.Walls.Right.AutoHide = False
        '
        'FastLine1
        '
        '
        '
        '
        Me.FastLine1.LinePen.Color = System.Drawing.Color.Red
        '
        '
        '
        '
        '
        '
        Me.FastLine1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.FastLine1.Marks.Callout.ArrowHeadSize = 8
        '
        '
        '
        Me.FastLine1.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.FastLine1.Marks.Callout.Distance = 0
        Me.FastLine1.Marks.Callout.Draw3D = False
        Me.FastLine1.Marks.Callout.Length = 10
        Me.FastLine1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        '
        '
        Me.FastLine1.Marks.Shadow.Visible = True
        '
        '
        '
        '
        '
        '
        Me.FastLine1.Marks.Symbol.Shadow.Visible = True
        Me.FastLine1.ShowInLegend = False
        Me.FastLine1.Title = "fastLine1"
        '
        '
        '
        Me.FastLine1.XValues.DataMember = "X"
        Me.FastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.FastLine1.YValues.DataMember = "Y"
        '
        'FastLine2
        '
        '
        '
        '
        Me.FastLine2.LinePen.Color = System.Drawing.Color.Green
        '
        '
        '
        '
        '
        '
        Me.FastLine2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None
        Me.FastLine2.Marks.Callout.ArrowHeadSize = 8
        '
        '
        '
        Me.FastLine2.Marks.Callout.Brush.Color = System.Drawing.Color.Black
        Me.FastLine2.Marks.Callout.Distance = 0
        Me.FastLine2.Marks.Callout.Draw3D = False
        Me.FastLine2.Marks.Callout.Length = 10
        Me.FastLine2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle
        '
        '
        '
        Me.FastLine2.Marks.Shadow.Visible = True
        '
        '
        '
        '
        '
        '
        Me.FastLine2.Marks.Symbol.Shadow.Visible = True
        Me.FastLine2.ShowInLegend = False
        Me.FastLine2.Title = "fastLine2"
        '
        '
        '
        Me.FastLine2.XValues.DataMember = "X"
        Me.FastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.FastLine2.YValues.DataMember = "Y"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Listdata)
        Me.GroupBox2.Controls.Add(Me.btnQuery)
        Me.GroupBox2.Controls.Add(Me.endtime)
        Me.GroupBox2.Controls.Add(Me.statime)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ngsel)
        Me.GroupBox2.Controls.Add(Me.oksel)
        Me.GroupBox2.Controls.Add(Me.gjz)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 449)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(509, 307)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "数据查询"
        '
        'Listdata
        '
        Me.Listdata.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Listdata.FormattingEnabled = True
        Me.Listdata.ItemHeight = 12
        Me.Listdata.Location = New System.Drawing.Point(281, 32)
        Me.Listdata.Name = "Listdata"
        Me.Listdata.Size = New System.Drawing.Size(222, 256)
        Me.Listdata.TabIndex = 16
        '
        'btnQuery
        '
        Me.btnQuery.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnQuery.BackgroundImage = Global.逆转测试.My.Resources.Resources.记录查询
        Me.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuery.Location = New System.Drawing.Point(214, 56)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(51, 55)
        Me.btnQuery.TabIndex = 12
        Me.btnQuery.UseVisualStyleBackColor = False
        '
        'endtime
        '
        Me.endtime.CustomFormat = "yyyy-MM-dd"
        Me.endtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endtime.Location = New System.Drawing.Point(101, 161)
        Me.endtime.Name = "endtime"
        Me.endtime.Size = New System.Drawing.Size(120, 21)
        Me.endtime.TabIndex = 11
        Me.endtime.Value = New Date(2015, 9, 7, 0, 0, 0, 0)
        '
        'statime
        '
        Me.statime.CustomFormat = "yyyy-MM-dd"
        Me.statime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.statime.Location = New System.Drawing.Point(101, 126)
        Me.statime.Name = "statime"
        Me.statime.Size = New System.Drawing.Size(120, 21)
        Me.statime.TabIndex = 10
        Me.statime.Value = New Date(2015, 9, 7, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(279, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 12)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "数据列表："
        '
        'ngsel
        '
        Me.ngsel.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ngsel.Location = New System.Drawing.Point(146, 227)
        Me.ngsel.Name = "ngsel"
        Me.ngsel.Size = New System.Drawing.Size(119, 61)
        Me.ngsel.TabIndex = 7
        Me.ngsel.Text = "不合格品查询"
        Me.ngsel.UseVisualStyleBackColor = True
        '
        'oksel
        '
        Me.oksel.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.oksel.Location = New System.Drawing.Point(19, 227)
        Me.oksel.Name = "oksel"
        Me.oksel.Size = New System.Drawing.Size(121, 61)
        Me.oksel.TabIndex = 6
        Me.oksel.Text = "合格品查询"
        Me.oksel.UseVisualStyleBackColor = True
        '
        'gjz
        '
        Me.gjz.Location = New System.Drawing.Point(65, 29)
        Me.gjz.Name = "gjz"
        Me.gjz.Size = New System.Drawing.Size(210, 21)
        Me.gjz.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "终止时间："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "起始时间："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "关键字："
        '
        'Pic1
        '
        Me.Pic1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Pic1.Location = New System.Drawing.Point(8, 163)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(47, 22)
        Me.Pic1.TabIndex = 125
        Me.Pic1.TabStop = False
        Me.Pic1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pieresult)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.piedate)
        Me.GroupBox1.Controls.Add(Me.pietm)
        Me.GroupBox1.Controls.Add(Me.pienumber)
        Me.GroupBox1.Controls.Add(Me.pietype)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Pic1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 490)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 266)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "工件信息"
        '
        'pieresult
        '
        Me.pieresult.Location = New System.Drawing.Point(377, 29)
        Me.pieresult.Name = "pieresult"
        Me.pieresult.Size = New System.Drawing.Size(78, 21)
        Me.pieresult.TabIndex = 140
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "测试结果："
        '
        'piedate
        '
        Me.piedate.Location = New System.Drawing.Point(377, 107)
        Me.piedate.Name = "piedate"
        Me.piedate.Size = New System.Drawing.Size(78, 21)
        Me.piedate.TabIndex = 137
        '
        'pietm
        '
        Me.pietm.Location = New System.Drawing.Point(77, 107)
        Me.pietm.Name = "pietm"
        Me.pietm.Size = New System.Drawing.Size(199, 21)
        Me.pietm.TabIndex = 135
        '
        'pienumber
        '
        Me.pienumber.Location = New System.Drawing.Point(77, 67)
        Me.pienumber.Name = "pienumber"
        Me.pienumber.Size = New System.Drawing.Size(199, 21)
        Me.pienumber.TabIndex = 134
        '
        'pietype
        '
        Me.pietype.Location = New System.Drawing.Point(77, 29)
        Me.pietype.Name = "pietype"
        Me.pietype.Size = New System.Drawing.Size(100, 21)
        Me.pietype.TabIndex = 133
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(306, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "测试日期："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "产品条码："
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 12)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "产品型号："
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 12)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "产品编号："
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.dataRecord)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(521, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(487, 769)
        Me.Panel2.TabIndex = 2
        '
        'dataRecord
        '
        Me.dataRecord.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dataRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.测试项, Me.下限, Me.上限, Me.测试结果, Me.Column1})
        Me.dataRecord.Location = New System.Drawing.Point(4, 3)
        Me.dataRecord.Name = "dataRecord"
        Me.dataRecord.RowTemplate.Height = 23
        Me.dataRecord.Size = New System.Drawing.Size(471, 475)
        Me.dataRecord.TabIndex = 1
        '
        '测试项
        '
        Me.测试项.HeaderText = "        测试项"
        Me.测试项.Name = "测试项"
        Me.测试项.ReadOnly = True
        Me.测试项.Width = 130
        '
        '下限
        '
        Me.下限.HeaderText = "  上限"
        Me.下限.Name = "下限"
        Me.下限.ReadOnly = True
        Me.下限.Width = 70
        '
        '上限
        '
        Me.上限.HeaderText = "  下限"
        Me.上限.Name = "上限"
        Me.上限.ReadOnly = True
        Me.上限.Width = 70
        '
        '测试结果
        '
        Me.测试结果.HeaderText = " 测试值"
        Me.测试结果.Name = "测试结果"
        Me.测试结果.ReadOnly = True
        Me.测试结果.Width = 80
        '
        'Column1
        '
        Me.Column1.HeaderText = "  单位"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'frmQueryData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 769)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmQueryData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "数据查询"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dataRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dataRecord As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents endtime As System.Windows.Forms.DateTimePicker
    Friend WithEvents statime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ngsel As System.Windows.Forms.Button
    Friend WithEvents oksel As System.Windows.Forms.Button
    Friend WithEvents gjz As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pieresult As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents piedate As System.Windows.Forms.TextBox
    Friend WithEvents pietm As System.Windows.Forms.TextBox
    Friend WithEvents pienumber As System.Windows.Forms.TextBox
    Friend WithEvents pietype As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Listdata As System.Windows.Forms.ListBox
    Friend WithEvents 测试项 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 下限 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 上限 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 测试结果 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chaxun As Steema.TeeChart.TChart
    Friend WithEvents FastLine1 As Steema.TeeChart.Styles.FastLine
    Friend WithEvents CursorTool1 As Steema.TeeChart.Tools.CursorTool
    Friend WithEvents FastLine2 As Steema.TeeChart.Styles.FastLine
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tooluser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.plccomsstate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tooltime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.typesel = New System.Windows.Forms.ComboBox()
        Me.bianhao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tiaoma = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBOX_num_state = New System.Windows.Forms.TextBox()
        Me.trouble = New System.Windows.Forms.TextBox()
        Me.state = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DAQjxl = New AxDAQPILOTAXLib.AxDAQPilot()
        Me.DAQjxjx = New AxDAQPILOTAXLib.AxDAQPilot()
        Me.DAQwy = New AxDAQPILOTAXLib.AxDAQPilot()
        Me.DAQfqlright = New AxDAQPILOTAXLib.AxDAQPilot()
        Me.DAQfqlleft = New AxDAQPILOTAXLib.AxDAQPilot()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lblfqlright = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.countclr = New System.Windows.Forms.Button()
        Me.countchag = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.lblfqlleft = New System.Windows.Forms.Label()
        Me.lblok = New System.Windows.Forms.Label()
        Me.lblwy = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lblng = New System.Windows.Forms.Label()
        Me.lblall = New System.Windows.Forms.Label()
        Me.datatest = New System.Windows.Forms.DataGridView()
        Me.测试项 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.上限 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.下限 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.测量值 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timhand = New System.Windows.Forms.Timer(Me.components)
        Me.Timzero = New System.Windows.Forms.Timer(Me.components)
        Me.Timlvbof = New System.Windows.Forms.Timer(Me.components)
        Me.Timtest = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tcCurve = New Steema.TeeChart.TChart()
        Me.FastLine1 = New Steema.TeeChart.Styles.FastLine()
        Me.FastLine2 = New Steema.TeeChart.Styles.FastLine()
        Me.CursorTool1 = New Steema.TeeChart.Tools.CursorTool()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.添加用户ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除用户ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改密码ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DAQjxl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAQjxjx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAQwy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAQfqlright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAQfqlleft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datatest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton7, Me.ToolStripButton6, Me.ToolStripButton5, Me.ToolStripButton8})
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tooluser, Me.toolstate, Me.plccomsstate, Me.tooltime})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'tooluser
        '
        resources.ApplyResources(Me.tooluser, "tooluser")
        Me.tooluser.Name = "tooluser"
        '
        'toolstate
        '
        resources.ApplyResources(Me.toolstate, "toolstate")
        Me.toolstate.Name = "toolstate"
        '
        'plccomsstate
        '
        resources.ApplyResources(Me.plccomsstate, "plccomsstate")
        Me.plccomsstate.BackColor = System.Drawing.Color.Red
        Me.plccomsstate.Name = "plccomsstate"
        '
        'tooltime
        '
        resources.ApplyResources(Me.tooltime, "tooltime")
        Me.tooltime.Name = "tooltime"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DAQjxl)
        Me.Panel1.Controls.Add(Me.DAQjxjx)
        Me.Panel1.Controls.Add(Me.DAQwy)
        Me.Panel1.Controls.Add(Me.Pic1)
        Me.Panel1.Controls.Add(Me.DAQfqlright)
        Me.Panel1.Controls.Add(Me.DAQfqlleft)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.datatest)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Name = "Panel1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.typesel)
        Me.GroupBox3.Controls.Add(Me.bianhao)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.tiaoma)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {resources.GetString("ComboBox1.Items"), resources.GetString("ComboBox1.Items1")})
        Me.ComboBox1.Name = "ComboBox1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'typesel
        '
        Me.typesel.BackColor = System.Drawing.SystemColors.ButtonFace
        resources.ApplyResources(Me.typesel, "typesel")
        Me.typesel.FormattingEnabled = True
        Me.typesel.Name = "typesel"
        '
        'bianhao
        '
        resources.ApplyResources(Me.bianhao, "bianhao")
        Me.bianhao.Name = "bianhao"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Name = "Label20"
        '
        'tiaoma
        '
        resources.ApplyResources(Me.tiaoma, "tiaoma")
        Me.tiaoma.Name = "tiaoma"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Name = "Label17"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBOX_num_state)
        Me.GroupBox1.Controls.Add(Me.trouble)
        Me.GroupBox1.Controls.Add(Me.state)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'TextBOX_num_state
        '
        resources.ApplyResources(Me.TextBOX_num_state, "TextBOX_num_state")
        Me.TextBOX_num_state.Name = "TextBOX_num_state"
        '
        'trouble
        '
        resources.ApplyResources(Me.trouble, "trouble")
        Me.trouble.Name = "trouble"
        '
        'state
        '
        resources.ApplyResources(Me.state, "state")
        Me.state.Name = "state"
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Name = "Label19"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Name = "Label18"
        '
        'DAQjxl
        '
        resources.ApplyResources(Me.DAQjxl, "DAQjxl")
        Me.DAQjxl.Name = "DAQjxl"
        Me.DAQjxl.OcxState = CType(resources.GetObject("DAQjxl.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'DAQjxjx
        '
        resources.ApplyResources(Me.DAQjxjx, "DAQjxjx")
        Me.DAQjxjx.Name = "DAQjxjx"
        Me.DAQjxjx.OcxState = CType(resources.GetObject("DAQjxjx.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'DAQwy
        '
        resources.ApplyResources(Me.DAQwy, "DAQwy")
        Me.DAQwy.Name = "DAQwy"
        Me.DAQwy.OcxState = CType(resources.GetObject("DAQwy.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'DAQfqlright
        '
        resources.ApplyResources(Me.DAQfqlright, "DAQfqlright")
        Me.DAQfqlright.Name = "DAQfqlright"
        Me.DAQfqlright.OcxState = CType(resources.GetObject("DAQfqlright.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'DAQfqlleft
        '
        resources.ApplyResources(Me.DAQfqlleft, "DAQfqlleft")
        Me.DAQfqlleft.Name = "DAQfqlleft"
        Me.DAQfqlleft.OcxState = CType(resources.GetObject("DAQfqlleft.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.lblfqlright)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.countclr)
        Me.GroupBox2.Controls.Add(Me.countchag)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblresult)
        Me.GroupBox2.Controls.Add(Me.lblfqlleft)
        Me.GroupBox2.Controls.Add(Me.lblok)
        Me.GroupBox2.Controls.Add(Me.lblwy)
        Me.GroupBox2.Controls.Add(Me.lbltime)
        Me.GroupBox2.Controls.Add(Me.lblng)
        Me.GroupBox2.Controls.Add(Me.lblall)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Label36
        '
        resources.ApplyResources(Me.Label36, "Label36")
        Me.Label36.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Name = "Label36"
        '
        'Label37
        '
        resources.ApplyResources(Me.Label37, "Label37")
        Me.Label37.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Name = "Label37"
        '
        'lblfqlright
        '
        Me.lblfqlright.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblfqlright.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblfqlright, "lblfqlright")
        Me.lblfqlright.ForeColor = System.Drawing.Color.White
        Me.lblfqlright.Name = "lblfqlright"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Name = "Label16"
        '
        'countclr
        '
        resources.ApplyResources(Me.countclr, "countclr")
        Me.countclr.Name = "countclr"
        Me.countclr.UseVisualStyleBackColor = True
        '
        'countchag
        '
        resources.ApplyResources(Me.countchag, "countchag")
        Me.countchag.Name = "countchag"
        Me.countchag.UseVisualStyleBackColor = True
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Name = "Label15"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Name = "Label14"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Name = "Label13"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Name = "Label12"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Name = "Label9"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Name = "Label7"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Name = "Label6"
        '
        'lblresult
        '
        Me.lblresult.BackColor = System.Drawing.Color.Yellow
        Me.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblresult, "lblresult")
        Me.lblresult.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblresult.Name = "lblresult"
        '
        'lblfqlleft
        '
        Me.lblfqlleft.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblfqlleft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblfqlleft, "lblfqlleft")
        Me.lblfqlleft.ForeColor = System.Drawing.Color.White
        Me.lblfqlleft.Name = "lblfqlleft"
        '
        'lblok
        '
        Me.lblok.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblok, "lblok")
        Me.lblok.ForeColor = System.Drawing.Color.White
        Me.lblok.Name = "lblok"
        '
        'lblwy
        '
        Me.lblwy.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblwy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblwy, "lblwy")
        Me.lblwy.ForeColor = System.Drawing.Color.White
        Me.lblwy.Name = "lblwy"
        '
        'lbltime
        '
        Me.lbltime.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbltime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lbltime, "lbltime")
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Name = "lbltime"
        '
        'lblng
        '
        Me.lblng.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblng.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblng, "lblng")
        Me.lblng.ForeColor = System.Drawing.Color.White
        Me.lblng.Name = "lblng"
        '
        'lblall
        '
        Me.lblall.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.lblall, "lblall")
        Me.lblall.ForeColor = System.Drawing.Color.White
        Me.lblall.Name = "lblall"
        '
        'datatest
        '
        Me.datatest.AllowUserToDeleteRows = False
        Me.datatest.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.datatest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datatest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.测试项, Me.上限, Me.下限, Me.测量值, Me.Column1})
        resources.ApplyResources(Me.datatest, "datatest")
        Me.datatest.Name = "datatest"
        Me.datatest.RowTemplate.Height = 23
        Me.datatest.ShowEditingIcon = False
        '
        '测试项
        '
        Me.测试项.FillWeight = 120.0!
        resources.ApplyResources(Me.测试项, "测试项")
        Me.测试项.Name = "测试项"
        '
        '上限
        '
        Me.上限.FillWeight = 120.0!
        resources.ApplyResources(Me.上限, "上限")
        Me.上限.Name = "上限"
        '
        '下限
        '
        Me.下限.FillWeight = 120.0!
        resources.ApplyResources(Me.下限, "下限")
        Me.下限.Name = "下限"
        '
        '测量值
        '
        Me.测量值.FillWeight = 120.0!
        resources.ApplyResources(Me.测量值, "测量值")
        Me.测量值.Name = "测量值"
        '
        'Column1
        '
        Me.Column1.FillWeight = 120.0!
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tcCurve)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Timhand
        '
        Me.Timhand.Interval = 80
        '
        'Timzero
        '
        Me.Timzero.Interval = 80
        '
        'Timlvbof
        '
        Me.Timlvbof.Interval = 25
        '
        'Timtest
        '
        Me.Timtest.Interval = 50
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 19200
        Me.SerialPort1.PortName = "COM8"
        Me.SerialPort1.ReadBufferSize = 500
        '
        'TextBox4
        '
        resources.ApplyResources(Me.TextBox4, "TextBox4")
        Me.TextBox4.Name = "TextBox4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'tcCurve
        '
        '
        '
        '
        Me.tcCurve.Aspect.ElevationFloat = 345.0R
        Me.tcCurve.Aspect.RotationFloat = 345.0R
        Me.tcCurve.Aspect.View3D = False
        '
        '
        '
        '
        '
        '
        Me.tcCurve.Axes.Bottom.Automatic = True
        '
        '
        '
        Me.tcCurve.Axes.Bottom.Grid.ZPosition = 0R
        '
        '
        '
        Me.tcCurve.Axes.Depth.Automatic = True
        '
        '
        '
        Me.tcCurve.Axes.Depth.Grid.ZPosition = 0R
        '
        '
        '
        Me.tcCurve.Axes.DepthTop.Automatic = True
        '
        '
        '
        Me.tcCurve.Axes.DepthTop.Grid.ZPosition = 0R
        '
        '
        '
        Me.tcCurve.Axes.Left.Automatic = True
        '
        '
        '
        Me.tcCurve.Axes.Left.Grid.ZPosition = 0R
        '
        '
        '
        Me.tcCurve.Axes.Right.Automatic = True
        '
        '
        '
        Me.tcCurve.Axes.Right.Grid.ZPosition = 0R
        '
        '
        '
        Me.tcCurve.Axes.Top.Automatic = True
        '
        '
        '
        Me.tcCurve.Axes.Top.Grid.ZPosition = 0R
        Me.tcCurve.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.tcCurve, "tcCurve")
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.tcCurve.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tcCurve.Header.Font.Name = "宋体"
        Me.tcCurve.Header.Font.Size = 12
        Me.tcCurve.Header.Font.SizeFloat = 12.0!
        Me.tcCurve.Header.Lines = New String() {"反驱测试曲线"}
        '
        '
        '
        '
        '
        '
        Me.tcCurve.Legend.Shadow.Visible = True
        '
        '
        '
        '
        '
        '
        Me.tcCurve.Legend.Title.Font.Bold = True
        '
        '
        '
        Me.tcCurve.Legend.Title.Pen.Visible = False
        Me.tcCurve.Legend.Visible = False
        Me.tcCurve.Name = "tcCurve"
        Me.tcCurve.Series.Add(Me.FastLine1)
        Me.tcCurve.Series.Add(Me.FastLine2)
        Me.tcCurve.Tools.Add(Me.CursorTool1)
        '
        '
        '
        '
        '
        '
        Me.tcCurve.Walls.Back.AutoHide = False
        '
        '
        '
        Me.tcCurve.Walls.Bottom.AutoHide = False
        '
        '
        '
        Me.tcCurve.Walls.Left.AutoHide = False
        '
        '
        '
        Me.tcCurve.Walls.Right.AutoHide = False
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
        resources.ApplyResources(Me.FastLine1, "FastLine1")
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
        resources.ApplyResources(Me.FastLine2, "FastLine2")
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.添加用户ToolStripMenuItem, Me.删除用户ToolStripMenuItem, Me.修改密码ToolStripMenuItem, Me.ToolStripMenuItem4})
        resources.ApplyResources(Me.ToolStripButton1, "ToolStripButton1")
        Me.ToolStripButton1.Name = "ToolStripButton1"
        '
        '添加用户ToolStripMenuItem
        '
        Me.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem"
        resources.ApplyResources(Me.添加用户ToolStripMenuItem, "添加用户ToolStripMenuItem")
        '
        '删除用户ToolStripMenuItem
        '
        Me.删除用户ToolStripMenuItem.Name = "删除用户ToolStripMenuItem"
        resources.ApplyResources(Me.删除用户ToolStripMenuItem, "删除用户ToolStripMenuItem")
        '
        '修改密码ToolStripMenuItem
        '
        Me.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem"
        resources.ApplyResources(Me.修改密码ToolStripMenuItem, "修改密码ToolStripMenuItem")
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButton2, "ToolStripButton2")
        Me.ToolStripButton2.Name = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButton3, "ToolStripButton3")
        Me.ToolStripButton3.Name = "ToolStripButton3"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.逆转测试.My.Resources.Resources.Setup
        resources.ApplyResources(Me.ToolStripButton4, "ToolStripButton4")
        Me.ToolStripButton4.Name = "ToolStripButton4"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.逆转测试.My.Resources.Resources.清零
        resources.ApplyResources(Me.ToolStripButton7, "ToolStripButton7")
        Me.ToolStripButton7.Name = "ToolStripButton7"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButton6, "ToolStripButton6")
        Me.ToolStripButton6.Name = "ToolStripButton6"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButton5, "ToolStripButton5")
        Me.ToolStripButton5.Name = "ToolStripButton5"
        '
        'Pic1
        '
        resources.ApplyResources(Me.Pic1, "Pic1")
        Me.Pic1.Name = "Pic1"
        Me.Pic1.TabStop = False
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.逆转测试.My.Resources.Resources.照明
        resources.ApplyResources(Me.ToolStripButton8, "ToolStripButton8")
        Me.ToolStripButton8.Name = "ToolStripButton8"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        resources.ApplyResources(Me.ToolStripMenuItem4, "ToolStripMenuItem4")
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DAQjxl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAQjxjx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAQwy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAQfqlright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAQfqlleft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datatest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents 添加用户ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除用户ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 修改密码ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tooluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolstate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tooltime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents countchag As System.Windows.Forms.Button
    Friend WithEvents countclr As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bianhao As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tiaoma As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents lblfqlleft As System.Windows.Forms.Label
    Friend WithEvents lblok As System.Windows.Forms.Label
    Friend WithEvents lblwy As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lblng As System.Windows.Forms.Label
    Friend WithEvents lblall As System.Windows.Forms.Label
    Friend WithEvents datatest As System.Windows.Forms.DataGridView
    Friend WithEvents typesel As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Timhand As System.Windows.Forms.Timer
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents lblfqlright As System.Windows.Forms.Label
    Friend WithEvents DAQjxl As AxDAQPILOTAXLib.AxDAQPilot
    Friend WithEvents DAQjxjx As AxDAQPILOTAXLib.AxDAQPilot
    Friend WithEvents DAQwy As AxDAQPILOTAXLib.AxDAQPilot
    Friend WithEvents DAQfqlright As AxDAQPILOTAXLib.AxDAQPilot
    Friend WithEvents DAQfqlleft As AxDAQPILOTAXLib.AxDAQPilot
    Friend WithEvents 测试项 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 上限 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 下限 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 测量值 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tcCurve As Steema.TeeChart.TChart
    Friend WithEvents FastLine1 As Steema.TeeChart.Styles.FastLine
    Friend WithEvents CursorTool1 As Steema.TeeChart.Tools.CursorTool
    Friend WithEvents plccomsstate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FastLine2 As Steema.TeeChart.Styles.FastLine
    Friend WithEvents Timzero As System.Windows.Forms.Timer
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timlvbof As System.Windows.Forms.Timer
    Friend WithEvents Timtest As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents trouble As TextBox
    Friend WithEvents state As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBOX_num_state As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
End Class

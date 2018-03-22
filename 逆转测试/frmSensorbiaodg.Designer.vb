<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSensorbiaodg
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
        Me.components = New System.ComponentModel.Container
        Me.Textfqll = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.leftfqlclr = New System.Windows.Forms.Button
        Me.leftfqlcoef = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.leftfql = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.rightfql = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.rightfqlcoef = New System.Windows.Forms.TextBox
        Me.rightfqlclr = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Textfqlr = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.wy = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.wycoef = New System.Windows.Forms.TextBox
        Me.wyclr = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Textwy = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.jxjx = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.jxjxcoef = New System.Windows.Forms.TextBox
        Me.jxjxclr = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Textjxjx = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.jxli = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.jxlicoef = New System.Windows.Forms.TextBox
        Me.jxliclr = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Textjxli = New System.Windows.Forms.TextBox
        Me.posrun = New System.Windows.Forms.Button
        Me.negrun = New System.Windows.Forms.Button
        Me.runstop = New System.Windows.Forms.Button
        Me.speedxs = New System.Windows.Forms.TextBox
        Me.Timerbd = New System.Windows.Forms.Timer(Me.components)
        Me.wyzerojizhun = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Textfqll
        '
        Me.Textfqll.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Textfqll.Location = New System.Drawing.Point(161, 26)
        Me.Textfqll.Name = "Textfqll"
        Me.Textfqll.Size = New System.Drawing.Size(100, 26)
        Me.Textfqll.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(70, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 39)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "锁存"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'leftfqlclr
        '
        Me.leftfqlclr.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.leftfqlclr.Location = New System.Drawing.Point(161, 138)
        Me.leftfqlclr.Name = "leftfqlclr"
        Me.leftfqlclr.Size = New System.Drawing.Size(87, 58)
        Me.leftfqlclr.TabIndex = 19
        Me.leftfqlclr.Text = "左反驱力清零"
        Me.leftfqlclr.UseVisualStyleBackColor = True
        '
        'leftfqlcoef
        '
        Me.leftfqlcoef.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.leftfqlcoef.Location = New System.Drawing.Point(161, 218)
        Me.leftfqlcoef.Name = "leftfqlcoef"
        Me.leftfqlcoef.Size = New System.Drawing.Size(97, 26)
        Me.leftfqlcoef.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "左反驱力标定系数:"
        '
        'leftfql
        '
        Me.leftfql.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.leftfql.Location = New System.Drawing.Point(161, 85)
        Me.leftfql.Name = "leftfql"
        Me.leftfql.Size = New System.Drawing.Size(100, 26)
        Me.leftfql.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "左反驱力(V):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.leftfql)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.leftfqlcoef)
        Me.GroupBox1.Controls.Add(Me.leftfqlclr)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Textfqll)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 271)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "左反驱力标定"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.rightfql)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.rightfqlcoef)
        Me.GroupBox2.Controls.Add(Me.rightfqlclr)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Textfqlr)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 271)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "右反驱力标定"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "右反驱力(V):"
        '
        'rightfql
        '
        Me.rightfql.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rightfql.Location = New System.Drawing.Point(161, 85)
        Me.rightfql.Name = "rightfql"
        Me.rightfql.Size = New System.Drawing.Size(100, 26)
        Me.rightfql.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "右反驱力标定系数:"
        '
        'rightfqlcoef
        '
        Me.rightfqlcoef.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rightfqlcoef.Location = New System.Drawing.Point(161, 218)
        Me.rightfqlcoef.Name = "rightfqlcoef"
        Me.rightfqlcoef.Size = New System.Drawing.Size(97, 26)
        Me.rightfqlcoef.TabIndex = 18
        '
        'rightfqlclr
        '
        Me.rightfqlclr.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rightfqlclr.Location = New System.Drawing.Point(161, 138)
        Me.rightfqlclr.Name = "rightfqlclr"
        Me.rightfqlclr.Size = New System.Drawing.Size(87, 58)
        Me.rightfqlclr.TabIndex = 19
        Me.rightfqlclr.Text = "右反驱力清零"
        Me.rightfqlclr.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.Location = New System.Drawing.Point(70, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 39)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "锁存"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Textfqlr
        '
        Me.Textfqlr.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Textfqlr.Location = New System.Drawing.Point(161, 26)
        Me.Textfqlr.Name = "Textfqlr"
        Me.Textfqlr.Size = New System.Drawing.Size(100, 26)
        Me.Textfqlr.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.wy)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.wycoef)
        Me.GroupBox3.Controls.Add(Me.wyclr)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Textwy)
        Me.GroupBox3.Location = New System.Drawing.Point(623, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(278, 271)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "位移标定"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "位移(V):"
        '
        'wy
        '
        Me.wy.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.wy.Location = New System.Drawing.Point(161, 85)
        Me.wy.Name = "wy"
        Me.wy.Size = New System.Drawing.Size(100, 26)
        Me.wy.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "位移标定系数:"
        '
        'wycoef
        '
        Me.wycoef.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.wycoef.Location = New System.Drawing.Point(161, 218)
        Me.wycoef.Name = "wycoef"
        Me.wycoef.Size = New System.Drawing.Size(97, 26)
        Me.wycoef.TabIndex = 18
        '
        'wyclr
        '
        Me.wyclr.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.wyclr.Location = New System.Drawing.Point(161, 138)
        Me.wyclr.Name = "wyclr"
        Me.wyclr.Size = New System.Drawing.Size(87, 58)
        Me.wyclr.TabIndex = 19
        Me.wyclr.Text = "位移清零"
        Me.wyclr.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.Location = New System.Drawing.Point(86, 77)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 39)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "锁存"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Textwy
        '
        Me.Textwy.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Textwy.Location = New System.Drawing.Point(161, 26)
        Me.Textwy.Name = "Textwy"
        Me.Textwy.Size = New System.Drawing.Size(100, 26)
        Me.Textwy.TabIndex = 21
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.jxjx)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.jxjxcoef)
        Me.GroupBox4.Controls.Add(Me.jxjxclr)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.Textjxjx)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.jxli)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.jxlicoef)
        Me.GroupBox4.Controls.Add(Me.jxliclr)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Textjxli)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 306)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(583, 271)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "径向间隙检测标定"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "径向力(N):"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(27, 170)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(303, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 16)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "径向间隙(mm):"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(421, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 26)
        Me.TextBox1.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(431, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "径向间隙(V):"
        Me.Label9.Visible = False
        '
        'jxjx
        '
        Me.jxjx.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jxjx.Location = New System.Drawing.Point(298, 192)
        Me.jxjx.Name = "jxjx"
        Me.jxjx.Size = New System.Drawing.Size(100, 26)
        Me.jxjx.TabIndex = 30
        Me.jxjx.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(294, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 16)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "径向间隙标定系数:"
        Me.Label10.Visible = False
        '
        'jxjxcoef
        '
        Me.jxjxcoef.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jxjxcoef.Location = New System.Drawing.Point(444, 231)
        Me.jxjxcoef.Name = "jxjxcoef"
        Me.jxjxcoef.Size = New System.Drawing.Size(97, 26)
        Me.jxjxcoef.TabIndex = 32
        Me.jxjxcoef.Visible = False
        '
        'jxjxclr
        '
        Me.jxjxclr.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jxjxclr.Location = New System.Drawing.Point(311, 66)
        Me.jxjxclr.Name = "jxjxclr"
        Me.jxjxclr.Size = New System.Drawing.Size(87, 58)
        Me.jxjxclr.TabIndex = 33
        Me.jxjxclr.Text = "径向间隙清零"
        Me.jxjxclr.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button7.Location = New System.Drawing.Point(306, 147)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(57, 39)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "锁存"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Textjxjx
        '
        Me.Textjxjx.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Textjxjx.Location = New System.Drawing.Point(434, 179)
        Me.Textjxjx.Name = "Textjxjx"
        Me.Textjxjx.Size = New System.Drawing.Size(100, 26)
        Me.Textjxjx.TabIndex = 35
        Me.Textjxjx.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "径向力(V):"
        '
        'jxli
        '
        Me.jxli.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jxli.Location = New System.Drawing.Point(140, 85)
        Me.jxli.Name = "jxli"
        Me.jxli.Size = New System.Drawing.Size(100, 26)
        Me.jxli.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "径向力标定系数:"
        '
        'jxlicoef
        '
        Me.jxlicoef.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jxlicoef.Location = New System.Drawing.Point(140, 218)
        Me.jxlicoef.Name = "jxlicoef"
        Me.jxlicoef.Size = New System.Drawing.Size(97, 26)
        Me.jxlicoef.TabIndex = 25
        '
        'jxliclr
        '
        Me.jxliclr.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jxliclr.Location = New System.Drawing.Point(140, 138)
        Me.jxliclr.Name = "jxliclr"
        Me.jxliclr.Size = New System.Drawing.Size(97, 58)
        Me.jxliclr.TabIndex = 26
        Me.jxliclr.Text = "径向力清零"
        Me.jxliclr.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.Location = New System.Drawing.Point(54, 77)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 39)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "锁存"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Textjxli
        '
        Me.Textjxli.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Textjxli.Location = New System.Drawing.Point(140, 26)
        Me.Textjxli.Name = "Textjxli"
        Me.Textjxli.Size = New System.Drawing.Size(100, 26)
        Me.Textjxli.TabIndex = 28
        '
        'posrun
        '
        Me.posrun.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.posrun.Location = New System.Drawing.Point(657, 316)
        Me.posrun.Name = "posrun"
        Me.posrun.Size = New System.Drawing.Size(97, 39)
        Me.posrun.TabIndex = 33
        Me.posrun.Text = "右 移"
        Me.posrun.UseVisualStyleBackColor = True
        '
        'negrun
        '
        Me.negrun.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.negrun.Location = New System.Drawing.Point(767, 316)
        Me.negrun.Name = "negrun"
        Me.negrun.Size = New System.Drawing.Size(97, 39)
        Me.negrun.TabIndex = 34
        Me.negrun.Text = "左 移"
        Me.negrun.UseVisualStyleBackColor = True
        '
        'runstop
        '
        Me.runstop.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.runstop.Location = New System.Drawing.Point(702, 382)
        Me.runstop.Name = "runstop"
        Me.runstop.Size = New System.Drawing.Size(97, 39)
        Me.runstop.TabIndex = 35
        Me.runstop.Text = "停  止"
        Me.runstop.UseVisualStyleBackColor = True
        '
        'speedxs
        '
        Me.speedxs.Enabled = False
        Me.speedxs.Location = New System.Drawing.Point(801, 495)
        Me.speedxs.Name = "speedxs"
        Me.speedxs.Size = New System.Drawing.Size(93, 21)
        Me.speedxs.TabIndex = 36
        Me.speedxs.Text = "35398.23"
        '
        'Timerbd
        '
        '
        'wyzerojizhun
        '
        Me.wyzerojizhun.Location = New System.Drawing.Point(801, 454)
        Me.wyzerojizhun.Name = "wyzerojizhun"
        Me.wyzerojizhun.Size = New System.Drawing.Size(93, 21)
        Me.wyzerojizhun.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(643, 454)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 16)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "零位判断基准电压："
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(643, 495)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "编码器系数："
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(702, 529)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 39)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "保  存"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button6.Location = New System.Drawing.Point(434, 67)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(108, 58)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "读取当前间隙位移值"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmSensorbiaodg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 603)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.wyzerojizhun)
        Me.Controls.Add(Me.speedxs)
        Me.Controls.Add(Me.runstop)
        Me.Controls.Add(Me.negrun)
        Me.Controls.Add(Me.posrun)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSensorbiaodg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "系数标定"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Textfqll As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents leftfqlclr As System.Windows.Forms.Button
    Friend WithEvents leftfqlcoef As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents leftfql As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rightfql As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rightfqlcoef As System.Windows.Forms.TextBox
    Friend WithEvents rightfqlclr As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Textfqlr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents wy As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents wycoef As System.Windows.Forms.TextBox
    Friend WithEvents wyclr As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Textwy As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents jxjx As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents jxjxcoef As System.Windows.Forms.TextBox
    Friend WithEvents jxjxclr As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Textjxjx As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents jxli As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents jxlicoef As System.Windows.Forms.TextBox
    Friend WithEvents jxliclr As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Textjxli As System.Windows.Forms.TextBox
    Friend WithEvents posrun As System.Windows.Forms.Button
    Friend WithEvents negrun As System.Windows.Forms.Button
    Friend WithEvents runstop As System.Windows.Forms.Button
    Friend WithEvents speedxs As System.Windows.Forms.TextBox
    Friend WithEvents Timerbd As System.Windows.Forms.Timer
    Friend WithEvents wyzerojizhun As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class

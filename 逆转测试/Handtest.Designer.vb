<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Handtest
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
        Me.components = New System.ComponentModel.Container()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.negativerun = New System.Windows.Forms.Button()
        Me.postiverun = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_motor_target = New System.Windows.Forms.TextBox()
        Me.TextBox_motor_speed = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.Location = New System.Drawing.Point(495, 119)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(180, 55)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "加载气缸 上升"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button6.Location = New System.Drawing.Point(20, 119)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(180, 55)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "间隙检测压下气缸下降"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.Location = New System.Drawing.Point(20, 218)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 55)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "加载下限位导杆缸上升"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.Location = New System.Drawing.Point(495, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 55)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "间隙检测横移气缸前进"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(257, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 55)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "壳体夹紧气缸松开"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(32, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 55)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "壳体夹紧气缸夹紧"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'negativerun
        '
        Me.negativerun.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.negativerun.Location = New System.Drawing.Point(48, 71)
        Me.negativerun.Name = "negativerun"
        Me.negativerun.Size = New System.Drawing.Size(111, 54)
        Me.negativerun.TabIndex = 16
        Me.negativerun.Text = "左 移"
        Me.negativerun.UseVisualStyleBackColor = True
        '
        'postiverun
        '
        Me.postiverun.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.postiverun.Location = New System.Drawing.Point(261, 74)
        Me.postiverun.Name = "postiverun"
        Me.postiverun.Size = New System.Drawing.Size(111, 54)
        Me.postiverun.TabIndex = 15
        Me.postiverun.Text = "右 移"
        Me.postiverun.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button7.Location = New System.Drawing.Point(495, 218)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(180, 55)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "加载横移气缸  前进"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button8.Location = New System.Drawing.Point(719, 219)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(180, 55)
        Me.Button8.TabIndex = 23
        Me.Button8.Text = "加载横移气缸  后退"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button9.Location = New System.Drawing.Point(719, 120)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(180, 55)
        Me.Button9.TabIndex = 22
        Me.Button9.Text = "加载气缸  下降"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button10.Location = New System.Drawing.Point(257, 119)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(180, 55)
        Me.Button10.TabIndex = 21
        Me.Button10.Text = "间隙检测压下气缸上升"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button11.Location = New System.Drawing.Point(257, 218)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(180, 55)
        Me.Button11.TabIndex = 20
        Me.Button11.Text = "加载下限位导杆缸下降"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button12.Location = New System.Drawing.Point(719, 20)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(180, 55)
        Me.Button12.TabIndex = 19
        Me.Button12.Text = "间隙检测横移气缸后退"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "径向力(N):"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(169, 131)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 40
        '
        'Timer1
        '
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button14.Location = New System.Drawing.Point(313, 123)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(102, 41)
        Me.Button14.TabIndex = 43
        Me.Button14.Text = "力 清零"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(30, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 16)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "径向间隙(mm):"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(169, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 44
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button13.Location = New System.Drawing.Point(313, 70)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(102, 41)
        Me.Button13.TabIndex = 46
        Me.Button13.Text = "间隙清零"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_motor_target)
        Me.GroupBox1.Controls.Add(Me.TextBox_motor_speed)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.postiverun)
        Me.GroupBox1.Controls.Add(Me.negativerun)
        Me.GroupBox1.Location = New System.Drawing.Point(479, 485)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 224)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "电机调试"
        '
        'TextBox_motor_target
        '
        Me.TextBox_motor_target.Location = New System.Drawing.Point(199, 160)
        Me.TextBox_motor_target.Name = "TextBox_motor_target"
        Me.TextBox_motor_target.Size = New System.Drawing.Size(173, 21)
        Me.TextBox_motor_target.TabIndex = 20
        '
        'TextBox_motor_speed
        '
        Me.TextBox_motor_speed.Location = New System.Drawing.Point(199, 24)
        Me.TextBox_motor_speed.Name = "TextBox_motor_speed"
        Me.TextBox_motor_speed.Size = New System.Drawing.Size(173, 21)
        Me.TextBox_motor_speed.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(47, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "电机目标(deg)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "电机转速(deg/s)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Button13)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button14)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 478)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(461, 231)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "传感器标定"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button16)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button15)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button12)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(943, 450)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "气缸手动"
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button16.Location = New System.Drawing.Point(257, 337)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(180, 55)
        Me.Button16.TabIndex = 23
        Me.Button16.Text = "壳体夹紧气缸二 松开"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button15.Location = New System.Drawing.Point(20, 337)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(180, 55)
        Me.Button15.TabIndex = 18
        Me.Button15.Text = "壳体夹紧气缸二  夹紧"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Handtest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 721)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Handtest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "手动调试"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents negativerun As System.Windows.Forms.Button
    Friend WithEvents postiverun As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_motor_target As TextBox
    Friend WithEvents TextBox_motor_speed As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
End Class

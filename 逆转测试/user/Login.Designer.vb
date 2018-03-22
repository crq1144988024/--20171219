<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.CobName = New System.Windows.Forms.ComboBox
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.UsernameLabel = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(372, 62)
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.TxtPassword.Location = New System.Drawing.Point(70, 195)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(218, 21)
        Me.TxtPassword.TabIndex = 91
        '
        'CobName
        '
        Me.CobName.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.CobName.Location = New System.Drawing.Point(72, 125)
        Me.CobName.Name = "CobName"
        Me.CobName.Size = New System.Drawing.Size(220, 20)
        Me.CobName.TabIndex = 90
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cancel.Location = New System.Drawing.Point(190, 258)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(98, 31)
        Me.Cancel.TabIndex = 89
        Me.Cancel.Text = "取消(&C)"
        '
        'OK
        '
        Me.OK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OK.Location = New System.Drawing.Point(70, 258)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(98, 31)
        Me.OK.TabIndex = 88
        Me.OK.Text = "确定(&O)"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PasswordLabel.Location = New System.Drawing.Point(70, 174)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 26)
        Me.PasswordLabel.TabIndex = 87
        Me.PasswordLabel.Text = "密码(&P)"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UsernameLabel.Location = New System.Drawing.Point(70, 110)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 21)
        Me.UsernameLabel.TabIndex = 86
        Me.UsernameLabel.Text = "用户名(&U)"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 314)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.CobName)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "用户登录"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents CobName As System.Windows.Forms.ComboBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
End Class

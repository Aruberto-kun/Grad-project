<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccountSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnSaveUser = New Guna.UI2.WinForms.Guna2Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1422, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMIN PROFILE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 679)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.BtnSaveUser)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TxtConfirmPass)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TxtPassword)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TxtUsername)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtLastname)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TxtFirstname)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(5, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 679)
        Me.Panel2.TabIndex = 2
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtPassword.BorderRadius = 5
        Me.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPassword.DefaultText = ""
        Me.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtPassword.Location = New System.Drawing.Point(0, 342)
        Me.TxtPassword.MaxLength = 45
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtPassword.PlaceholderText = ""
        Me.TxtPassword.SelectedText = ""
        Me.TxtPassword.Size = New System.Drawing.Size(338, 42)
        Me.TxtPassword.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(338, 54)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Password:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtUsername
        '
        Me.TxtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtUsername.BorderRadius = 5
        Me.TxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUsername.DefaultText = ""
        Me.TxtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsername.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtUsername.Location = New System.Drawing.Point(0, 246)
        Me.TxtUsername.MaxLength = 45
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUsername.PlaceholderText = ""
        Me.TxtUsername.SelectedText = ""
        Me.TxtUsername.Size = New System.Drawing.Size(338, 42)
        Me.TxtUsername.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(338, 54)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Username:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtLastname
        '
        Me.TxtLastname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtLastname.BorderRadius = 5
        Me.TxtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLastname.DefaultText = ""
        Me.TxtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLastname.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtLastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtLastname.Location = New System.Drawing.Point(0, 150)
        Me.TxtLastname.MaxLength = 45
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtLastname.PlaceholderText = ""
        Me.TxtLastname.SelectedText = ""
        Me.TxtLastname.Size = New System.Drawing.Size(338, 42)
        Me.TxtLastname.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(338, 54)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Last name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFirstname
        '
        Me.TxtFirstname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtFirstname.BorderRadius = 5
        Me.TxtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFirstname.DefaultText = ""
        Me.TxtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFirstname.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtFirstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtFirstname.Location = New System.Drawing.Point(0, 54)
        Me.TxtFirstname.MaxLength = 45
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFirstname.PlaceholderText = ""
        Me.TxtFirstname.SelectedText = ""
        Me.TxtFirstname.Size = New System.Drawing.Size(338, 42)
        Me.TxtFirstname.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 54)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtConfirmPass
        '
        Me.TxtConfirmPass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtConfirmPass.BorderRadius = 5
        Me.TxtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtConfirmPass.DefaultText = ""
        Me.TxtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtConfirmPass.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtConfirmPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtConfirmPass.Location = New System.Drawing.Point(0, 438)
        Me.TxtConfirmPass.MaxLength = 45
        Me.TxtConfirmPass.Name = "TxtConfirmPass"
        Me.TxtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtConfirmPass.PlaceholderText = ""
        Me.TxtConfirmPass.SelectedText = ""
        Me.TxtConfirmPass.Size = New System.Drawing.Size(338, 42)
        Me.TxtConfirmPass.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(338, 54)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Confirm Password:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 674)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(338, 5)
        Me.Panel3.TabIndex = 41
        '
        'BtnSaveUser
        '
        Me.BtnSaveUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSaveUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSaveUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSaveUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSaveUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSaveUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSaveUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSaveUser.ForeColor = System.Drawing.Color.White
        Me.BtnSaveUser.Location = New System.Drawing.Point(0, 633)
        Me.BtnSaveUser.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSaveUser.Name = "BtnSaveUser"
        Me.BtnSaveUser.Size = New System.Drawing.Size(338, 41)
        Me.BtnSaveUser.TabIndex = 42
        Me.BtnSaveUser.Text = "SAVE"
        '
        'CheckBox1
        '
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox1.Location = New System.Drawing.Point(0, 480)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(338, 34)
        Me.CheckBox1.TabIndex = 43
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmAccountSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1422, 734)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAccountSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSaveUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckBox1 As CheckBox
End Class

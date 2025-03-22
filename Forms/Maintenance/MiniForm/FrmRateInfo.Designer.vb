<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRateInfo
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
        Me.TxtRates = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BtnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtRateClassification = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtRates
        '
        Me.TxtRates.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtRates.BorderRadius = 5
        Me.TxtRates.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtRates.DefaultText = ""
        Me.TxtRates.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtRates.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtRates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtRates.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtRates.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtRates.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtRates.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtRates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtRates.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtRates.Location = New System.Drawing.Point(3, 138)
        Me.TxtRates.Name = "TxtRates"
        Me.TxtRates.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtRates.PlaceholderText = ""
        Me.TxtRates.SelectedText = ""
        Me.TxtRates.Size = New System.Drawing.Size(450, 42)
        Me.TxtRates.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(450, 23)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Rates:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(417, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(38, 13)
        Me.LinkLabel1.TabIndex = 36
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "[close]"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BorderRadius = 5
        Me.BtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BtnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(3, 250)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(450, 50)
        Me.BtnUpdate.TabIndex = 35
        Me.BtnUpdate.Text = "SAVE"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 300)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(450, 5)
        Me.Panel3.TabIndex = 32
        '
        'TxtRateClassification
        '
        Me.TxtRateClassification.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtRateClassification.BorderRadius = 5
        Me.TxtRateClassification.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtRateClassification.DefaultText = ""
        Me.TxtRateClassification.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtRateClassification.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtRateClassification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtRateClassification.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtRateClassification.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtRateClassification.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtRateClassification.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtRateClassification.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtRateClassification.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtRateClassification.Location = New System.Drawing.Point(3, 73)
        Me.TxtRateClassification.Name = "TxtRateClassification"
        Me.TxtRateClassification.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtRateClassification.PlaceholderText = ""
        Me.TxtRateClassification.ReadOnly = True
        Me.TxtRateClassification.SelectedText = ""
        Me.TxtRateClassification.Size = New System.Drawing.Size(450, 42)
        Me.TxtRateClassification.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(453, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 232)
        Me.Panel2.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(3, 232)
        Me.Panel1.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(456, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Rate Classification:"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 50)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Rates Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmRateInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtRates)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TxtRateClassification)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmRateInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtRates As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BtnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtRateClassification As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

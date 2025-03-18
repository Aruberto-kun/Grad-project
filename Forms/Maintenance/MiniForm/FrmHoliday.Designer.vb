<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHoliday
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
        Me.DtHoliday = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TxtClassification = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BtnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtHolidayName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DtHoliday
        '
        Me.DtHoliday.BorderRadius = 5
        Me.DtHoliday.Checked = True
        Me.DtHoliday.CustomFormat = "MMM/dd/yyyy"
        Me.DtHoliday.Dock = System.Windows.Forms.DockStyle.Top
        Me.DtHoliday.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DtHoliday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtHoliday.Location = New System.Drawing.Point(3, 222)
        Me.DtHoliday.Margin = New System.Windows.Forms.Padding(2)
        Me.DtHoliday.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DtHoliday.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DtHoliday.Name = "DtHoliday"
        Me.DtHoliday.Size = New System.Drawing.Size(456, 37)
        Me.DtHoliday.TabIndex = 42
        Me.DtHoliday.Value = New Date(2024, 11, 2, 16, 21, 31, 190)
        '
        'Label32
        '
        Me.Label32.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(3, 180)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(456, 42)
        Me.Label32.TabIndex = 41
        Me.Label32.Text = "Date:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtClassification
        '
        Me.TxtClassification.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtClassification.BorderRadius = 5
        Me.TxtClassification.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtClassification.DefaultText = ""
        Me.TxtClassification.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtClassification.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtClassification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtClassification.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtClassification.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtClassification.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtClassification.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtClassification.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtClassification.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtClassification.Location = New System.Drawing.Point(3, 138)
        Me.TxtClassification.Name = "TxtClassification"
        Me.TxtClassification.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtClassification.PlaceholderText = ""
        Me.TxtClassification.SelectedText = ""
        Me.TxtClassification.Size = New System.Drawing.Size(456, 42)
        Me.TxtClassification.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(456, 23)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Holiday Name: "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(417, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(38, 13)
        Me.LinkLabel1.TabIndex = 38
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
        Me.BtnUpdate.Location = New System.Drawing.Point(3, 268)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(456, 50)
        Me.BtnUpdate.TabIndex = 37
        Me.BtnUpdate.Text = "SAVE"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(3, 318)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(456, 5)
        Me.Panel4.TabIndex = 36
        '
        'BtnDelete
        '
        Me.BtnDelete.BorderRadius = 5
        Me.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDelete.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BtnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(3, 323)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(456, 50)
        Me.BtnDelete.TabIndex = 35
        Me.BtnDelete.Text = "DELETE"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 373)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(456, 5)
        Me.Panel3.TabIndex = 34
        '
        'TxtHolidayName
        '
        Me.TxtHolidayName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtHolidayName.BorderRadius = 5
        Me.TxtHolidayName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtHolidayName.DefaultText = ""
        Me.TxtHolidayName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtHolidayName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtHolidayName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtHolidayName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtHolidayName.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtHolidayName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtHolidayName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtHolidayName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtHolidayName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TxtHolidayName.Location = New System.Drawing.Point(3, 73)
        Me.TxtHolidayName.Name = "TxtHolidayName"
        Me.TxtHolidayName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtHolidayName.PlaceholderText = ""
        Me.TxtHolidayName.SelectedText = ""
        Me.TxtHolidayName.Size = New System.Drawing.Size(456, 42)
        Me.TxtHolidayName.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(459, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 305)
        Me.Panel2.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(3, 305)
        Me.Panel1.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(462, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Holiday Name: "
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 50)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Holiday Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmHoliday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.DtHoliday)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.TxtClassification)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TxtHolidayName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmHoliday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtHoliday As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label32 As Label
    Friend WithEvents TxtClassification As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BtnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtHolidayName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

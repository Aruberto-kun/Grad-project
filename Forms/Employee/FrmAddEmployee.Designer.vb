﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddEmployee
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtAllowance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.BtnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.CbAssociateStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbCompensationType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSalary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CbPosition = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbDepartment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRfidNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.DGVoluntary = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DGLeaveAllocation = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.voluntaryID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voluntaryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.leaveID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.leaveType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.days = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.DGVoluntary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGLeaveAllocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtAllowance)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Panel10)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.CbAssociateStatus)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.CbCompensationType)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TxtSalary)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1848, 415)
        Me.Panel3.TabIndex = 4
        '
        'TxtAllowance
        '
        Me.TxtAllowance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtAllowance.BorderRadius = 5
        Me.TxtAllowance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAllowance.DefaultText = ""
        Me.TxtAllowance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtAllowance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtAllowance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAllowance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAllowance.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtAllowance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtAllowance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtAllowance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtAllowance.Location = New System.Drawing.Point(929, 288)
        Me.TxtAllowance.MaxLength = 45
        Me.TxtAllowance.Name = "TxtAllowance"
        Me.TxtAllowance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAllowance.PlaceholderText = ""
        Me.TxtAllowance.SelectedText = ""
        Me.TxtAllowance.Size = New System.Drawing.Size(917, 36)
        Me.TxtAllowance.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(929, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(917, 45)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Allowance(Non-Taxable):"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.BtnSave)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.BtnCancel)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(929, 361)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(917, 47)
        Me.Panel10.TabIndex = 29
        '
        'BtnSave
        '
        Me.BtnSave.BorderRadius = 5
        Me.BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(612, 0)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(150, 47)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "SAVE"
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(762, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(5, 47)
        Me.Panel11.TabIndex = 1
        '
        'BtnCancel
        '
        Me.BtnCancel.BorderRadius = 5
        Me.BtnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(767, 0)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(150, 47)
        Me.BtnCancel.TabIndex = 0
        Me.BtnCancel.Text = "CANCEL"
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(929, 408)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(917, 5)
        Me.Panel9.TabIndex = 28
        '
        'CbAssociateStatus
        '
        Me.CbAssociateStatus.BackColor = System.Drawing.Color.Transparent
        Me.CbAssociateStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CbAssociateStatus.BorderRadius = 5
        Me.CbAssociateStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.CbAssociateStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbAssociateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbAssociateStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbAssociateStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbAssociateStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CbAssociateStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbAssociateStatus.ItemHeight = 30
        Me.CbAssociateStatus.Items.AddRange(New Object() {"Probationary", "Regular", "Resigned"})
        Me.CbAssociateStatus.Location = New System.Drawing.Point(929, 207)
        Me.CbAssociateStatus.Name = "CbAssociateStatus"
        Me.CbAssociateStatus.Size = New System.Drawing.Size(917, 36)
        Me.CbAssociateStatus.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(929, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(917, 45)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Associate Status:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbCompensationType
        '
        Me.CbCompensationType.BackColor = System.Drawing.Color.Transparent
        Me.CbCompensationType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CbCompensationType.BorderRadius = 5
        Me.CbCompensationType.Dock = System.Windows.Forms.DockStyle.Top
        Me.CbCompensationType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbCompensationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCompensationType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbCompensationType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbCompensationType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CbCompensationType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbCompensationType.ItemHeight = 30
        Me.CbCompensationType.Items.AddRange(New Object() {"Daily", "Monthly"})
        Me.CbCompensationType.Location = New System.Drawing.Point(929, 126)
        Me.CbCompensationType.Name = "CbCompensationType"
        Me.CbCompensationType.Size = New System.Drawing.Size(917, 36)
        Me.CbCompensationType.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(929, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(917, 45)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Compensation Type:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtSalary
        '
        Me.TxtSalary.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtSalary.BorderRadius = 5
        Me.TxtSalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSalary.DefaultText = ""
        Me.TxtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSalary.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtSalary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtSalary.Location = New System.Drawing.Point(929, 45)
        Me.TxtSalary.MaxLength = 45
        Me.TxtSalary.Name = "TxtSalary"
        Me.TxtSalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSalary.PlaceholderText = ""
        Me.TxtSalary.SelectedText = ""
        Me.TxtSalary.Size = New System.Drawing.Size(917, 36)
        Me.TxtSalary.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(929, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(917, 45)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Salary:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(924, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 413)
        Me.Panel5.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CbPosition)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.CbDepartment)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.TxtRfidNumber)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.TxtLastname)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtFirstName)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(924, 413)
        Me.Panel4.TabIndex = 0
        '
        'CbPosition
        '
        Me.CbPosition.BackColor = System.Drawing.Color.Transparent
        Me.CbPosition.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CbPosition.BorderRadius = 5
        Me.CbPosition.Dock = System.Windows.Forms.DockStyle.Top
        Me.CbPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPosition.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbPosition.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CbPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbPosition.ItemHeight = 30
        Me.CbPosition.Location = New System.Drawing.Point(0, 366)
        Me.CbPosition.Name = "CbPosition"
        Me.CbPosition.Size = New System.Drawing.Size(924, 36)
        Me.CbPosition.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(924, 44)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Position:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbDepartment
        '
        Me.CbDepartment.BackColor = System.Drawing.Color.Transparent
        Me.CbDepartment.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CbDepartment.BorderRadius = 5
        Me.CbDepartment.Dock = System.Windows.Forms.DockStyle.Top
        Me.CbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDepartment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbDepartment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CbDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbDepartment.ItemHeight = 30
        Me.CbDepartment.Location = New System.Drawing.Point(0, 286)
        Me.CbDepartment.Name = "CbDepartment"
        Me.CbDepartment.Size = New System.Drawing.Size(924, 36)
        Me.CbDepartment.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(924, 44)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Department:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtRfidNumber
        '
        Me.TxtRfidNumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtRfidNumber.BorderRadius = 5
        Me.TxtRfidNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtRfidNumber.DefaultText = ""
        Me.TxtRfidNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtRfidNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtRfidNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtRfidNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtRfidNumber.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtRfidNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtRfidNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtRfidNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtRfidNumber.Location = New System.Drawing.Point(0, 206)
        Me.TxtRfidNumber.MaxLength = 45
        Me.TxtRfidNumber.Name = "TxtRfidNumber"
        Me.TxtRfidNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtRfidNumber.PlaceholderText = ""
        Me.TxtRfidNumber.SelectedText = ""
        Me.TxtRfidNumber.Size = New System.Drawing.Size(924, 36)
        Me.TxtRfidNumber.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(924, 45)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "RFID Number:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtLastname
        '
        Me.TxtLastname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtLastname.BorderRadius = 5
        Me.TxtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLastname.DefaultText = ""
        Me.TxtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLastname.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtLastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtLastname.Location = New System.Drawing.Point(0, 125)
        Me.TxtLastname.MaxLength = 45
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtLastname.PlaceholderText = ""
        Me.TxtLastname.SelectedText = ""
        Me.TxtLastname.Size = New System.Drawing.Size(924, 36)
        Me.TxtLastname.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(924, 44)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Last name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFirstName
        '
        Me.TxtFirstName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtFirstName.BorderRadius = 5
        Me.TxtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFirstName.DefaultText = ""
        Me.TxtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFirstName.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtFirstName.Location = New System.Drawing.Point(0, 45)
        Me.TxtFirstName.MaxLength = 45
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFirstName.PlaceholderText = ""
        Me.TxtFirstName.SelectedText = ""
        Me.TxtFirstName.Size = New System.Drawing.Size(924, 36)
        Me.TxtFirstName.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(924, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.DGVoluntary)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 415)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(924, 483)
        Me.Panel8.TabIndex = 26
        '
        'DGVoluntary
        '
        Me.DGVoluntary.AllowUserToAddRows = False
        Me.DGVoluntary.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGVoluntary.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVoluntary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVoluntary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVoluntary.ColumnHeadersHeight = 40
        Me.DGVoluntary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.voluntaryID, Me.voluntaryName, Me.amount})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVoluntary.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVoluntary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVoluntary.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVoluntary.Location = New System.Drawing.Point(0, 44)
        Me.DGVoluntary.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVoluntary.Name = "DGVoluntary"
        Me.DGVoluntary.RowHeadersVisible = False
        Me.DGVoluntary.RowHeadersWidth = 51
        Me.DGVoluntary.RowTemplate.Height = 24
        Me.DGVoluntary.Size = New System.Drawing.Size(924, 439)
        Me.DGVoluntary.TabIndex = 6
        Me.DGVoluntary.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVoluntary.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVoluntary.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVoluntary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVoluntary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVoluntary.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGVoluntary.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVoluntary.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVoluntary.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVoluntary.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVoluntary.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVoluntary.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVoluntary.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVoluntary.ThemeStyle.ReadOnly = False
        Me.DGVoluntary.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVoluntary.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVoluntary.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVoluntary.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGVoluntary.ThemeStyle.RowsStyle.Height = 24
        Me.DGVoluntary.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVoluntary.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(924, 44)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Voluntary Contributions"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(924, 415)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 483)
        Me.Panel7.TabIndex = 27
        '
        'DGLeaveAllocation
        '
        Me.DGLeaveAllocation.AllowUserToAddRows = False
        Me.DGLeaveAllocation.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DGLeaveAllocation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGLeaveAllocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGLeaveAllocation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGLeaveAllocation.ColumnHeadersHeight = 40
        Me.DGLeaveAllocation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.leaveID, Me.leaveType, Me.days})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGLeaveAllocation.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGLeaveAllocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGLeaveAllocation.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGLeaveAllocation.Location = New System.Drawing.Point(929, 459)
        Me.DGLeaveAllocation.Margin = New System.Windows.Forms.Padding(2)
        Me.DGLeaveAllocation.Name = "DGLeaveAllocation"
        Me.DGLeaveAllocation.RowHeadersVisible = False
        Me.DGLeaveAllocation.RowHeadersWidth = 51
        Me.DGLeaveAllocation.RowTemplate.Height = 24
        Me.DGLeaveAllocation.Size = New System.Drawing.Size(919, 439)
        Me.DGLeaveAllocation.TabIndex = 29
        Me.DGLeaveAllocation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGLeaveAllocation.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGLeaveAllocation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGLeaveAllocation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGLeaveAllocation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGLeaveAllocation.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGLeaveAllocation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGLeaveAllocation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGLeaveAllocation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGLeaveAllocation.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGLeaveAllocation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGLeaveAllocation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGLeaveAllocation.ThemeStyle.HeaderStyle.Height = 40
        Me.DGLeaveAllocation.ThemeStyle.ReadOnly = False
        Me.DGLeaveAllocation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGLeaveAllocation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGLeaveAllocation.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGLeaveAllocation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGLeaveAllocation.ThemeStyle.RowsStyle.Height = 24
        Me.DGLeaveAllocation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGLeaveAllocation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(929, 415)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(919, 44)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Manage Leave"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'voluntaryID
        '
        Me.voluntaryID.DataPropertyName = "voluntaryID"
        Me.voluntaryID.HeaderText = "Voluntary ID"
        Me.voluntaryID.Name = "voluntaryID"
        Me.voluntaryID.ReadOnly = True
        Me.voluntaryID.Visible = False
        '
        'voluntaryName
        '
        Me.voluntaryName.DataPropertyName = "name"
        Me.voluntaryName.HeaderText = "Voluntary Contribution Name"
        Me.voluntaryName.MinimumWidth = 8
        Me.voluntaryName.Name = "voluntaryName"
        Me.voluntaryName.ReadOnly = True
        Me.voluntaryName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'amount
        '
        Me.amount.DataPropertyName = "amount"
        Me.amount.HeaderText = "Amount"
        Me.amount.MaxInputLength = 6
        Me.amount.MinimumWidth = 8
        Me.amount.Name = "amount"
        Me.amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'leaveID
        '
        Me.leaveID.DataPropertyName = "leaveID"
        Me.leaveID.HeaderText = "Leave ID"
        Me.leaveID.Name = "leaveID"
        Me.leaveID.ReadOnly = True
        Me.leaveID.Visible = False
        '
        'leaveType
        '
        Me.leaveType.DataPropertyName = "leaveType"
        Me.leaveType.HeaderText = "Leave Type"
        Me.leaveType.Name = "leaveType"
        Me.leaveType.ReadOnly = True
        '
        'days
        '
        Me.days.DataPropertyName = "days"
        Me.days.HeaderText = "Days"
        Me.days.Name = "days"
        '
        'FrmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1848, 898)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGLeaveAllocation)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.DGVoluntary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGLeaveAllocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents BtnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents CbAssociateStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CbCompensationType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtSalary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CbPosition As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CbDepartment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtRfidNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DGVoluntary As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents DGLeaveAllocation As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtAllowance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents voluntaryID As DataGridViewTextBoxColumn
    Friend WithEvents voluntaryName As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents leaveID As DataGridViewTextBoxColumn
    Friend WithEvents leaveType As DataGridViewTextBoxColumn
    Friend WithEvents days As DataGridViewTextBoxColumn
End Class

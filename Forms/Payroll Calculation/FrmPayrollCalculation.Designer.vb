<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPayrollCalculation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TCEmployee = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TPPayrollPeriod = New System.Windows.Forms.TabPage()
        Me.DGPayrollPeriod = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colPayrollPeriodID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayrollPeriodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReleased = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RBNo = New System.Windows.Forms.RadioButton()
        Me.RBYes = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPayrollPeriodName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.TPPayrollCalculation = New System.Windows.Forms.TabPage()
        Me.DGVEmployeeList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPayrollPeriod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeletePayrollPeriodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TCEmployee.SuspendLayout()
        Me.TPPayrollPeriod.SuspendLayout()
        CType(Me.DGPayrollPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TPPayrollCalculation.SuspendLayout()
        CType(Me.DGVEmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TCEmployee
        '
        Me.TCEmployee.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TCEmployee.Controls.Add(Me.TPPayrollPeriod)
        Me.TCEmployee.Controls.Add(Me.TPPayrollCalculation)
        Me.TCEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCEmployee.ItemSize = New System.Drawing.Size(180, 40)
        Me.TCEmployee.Location = New System.Drawing.Point(0, 0)
        Me.TCEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.TCEmployee.Name = "TCEmployee"
        Me.TCEmployee.SelectedIndex = 0
        Me.TCEmployee.Size = New System.Drawing.Size(1454, 882)
        Me.TCEmployee.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TCEmployee.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TCEmployee.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TCEmployee.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TCEmployee.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TCEmployee.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TCEmployee.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TCEmployee.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TCEmployee.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TCEmployee.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TCEmployee.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TCEmployee.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TCEmployee.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TCEmployee.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black
        Me.TCEmployee.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TCEmployee.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.TCEmployee.TabIndex = 2
        Me.TCEmployee.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        '
        'TPPayrollPeriod
        '
        Me.TPPayrollPeriod.Controls.Add(Me.DGPayrollPeriod)
        Me.TPPayrollPeriod.Controls.Add(Me.Panel1)
        Me.TPPayrollPeriod.Controls.Add(Me.Label1)
        Me.TPPayrollPeriod.Controls.Add(Me.BtnSave)
        Me.TPPayrollPeriod.Location = New System.Drawing.Point(184, 4)
        Me.TPPayrollPeriod.Margin = New System.Windows.Forms.Padding(2)
        Me.TPPayrollPeriod.Name = "TPPayrollPeriod"
        Me.TPPayrollPeriod.Padding = New System.Windows.Forms.Padding(2)
        Me.TPPayrollPeriod.Size = New System.Drawing.Size(1266, 874)
        Me.TPPayrollPeriod.TabIndex = 1
        Me.TPPayrollPeriod.Text = "Payroll Period"
        Me.TPPayrollPeriod.UseVisualStyleBackColor = True
        '
        'DGPayrollPeriod
        '
        Me.DGPayrollPeriod.AllowUserToAddRows = False
        Me.DGPayrollPeriod.AllowUserToDeleteRows = False
        Me.DGPayrollPeriod.AllowUserToResizeColumns = False
        Me.DGPayrollPeriod.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGPayrollPeriod.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGPayrollPeriod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGPayrollPeriod.ColumnHeadersHeight = 40
        Me.DGPayrollPeriod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPayrollPeriodID, Me.colPayrollPeriodName, Me.colDateFrom, Me.colDateTo, Me.colPayout, Me.colReleased})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGPayrollPeriod.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGPayrollPeriod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGPayrollPeriod.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGPayrollPeriod.Location = New System.Drawing.Point(2, 359)
        Me.DGPayrollPeriod.Margin = New System.Windows.Forms.Padding(2)
        Me.DGPayrollPeriod.Name = "DGPayrollPeriod"
        Me.DGPayrollPeriod.ReadOnly = True
        Me.DGPayrollPeriod.RowHeadersVisible = False
        Me.DGPayrollPeriod.RowHeadersWidth = 62
        Me.DGPayrollPeriod.RowTemplate.Height = 28
        Me.DGPayrollPeriod.Size = New System.Drawing.Size(1262, 472)
        Me.DGPayrollPeriod.TabIndex = 9
        Me.DGPayrollPeriod.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGPayrollPeriod.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGPayrollPeriod.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGPayrollPeriod.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGPayrollPeriod.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGPayrollPeriod.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGPayrollPeriod.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGPayrollPeriod.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGPayrollPeriod.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGPayrollPeriod.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGPayrollPeriod.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGPayrollPeriod.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGPayrollPeriod.ThemeStyle.HeaderStyle.Height = 40
        Me.DGPayrollPeriod.ThemeStyle.ReadOnly = True
        Me.DGPayrollPeriod.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGPayrollPeriod.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGPayrollPeriod.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGPayrollPeriod.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGPayrollPeriod.ThemeStyle.RowsStyle.Height = 28
        Me.DGPayrollPeriod.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGPayrollPeriod.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'colPayrollPeriodID
        '
        Me.colPayrollPeriodID.DataPropertyName = "payrollperiodID"
        Me.colPayrollPeriodID.HeaderText = "ID"
        Me.colPayrollPeriodID.MinimumWidth = 8
        Me.colPayrollPeriodID.Name = "colPayrollPeriodID"
        Me.colPayrollPeriodID.ReadOnly = True
        Me.colPayrollPeriodID.Visible = False
        '
        'colPayrollPeriodName
        '
        Me.colPayrollPeriodName.DataPropertyName = "payrollperiodname"
        Me.colPayrollPeriodName.HeaderText = "Payroll Period Name"
        Me.colPayrollPeriodName.MinimumWidth = 8
        Me.colPayrollPeriodName.Name = "colPayrollPeriodName"
        Me.colPayrollPeriodName.ReadOnly = True
        '
        'colDateFrom
        '
        Me.colDateFrom.DataPropertyName = "datefrom"
        Me.colDateFrom.HeaderText = "From"
        Me.colDateFrom.MinimumWidth = 8
        Me.colDateFrom.Name = "colDateFrom"
        Me.colDateFrom.ReadOnly = True
        '
        'colDateTo
        '
        Me.colDateTo.DataPropertyName = "dateto"
        Me.colDateTo.HeaderText = "To"
        Me.colDateTo.MinimumWidth = 8
        Me.colDateTo.Name = "colDateTo"
        Me.colDateTo.ReadOnly = True
        '
        'colPayout
        '
        Me.colPayout.DataPropertyName = "payout"
        Me.colPayout.HeaderText = "Payout"
        Me.colPayout.MinimumWidth = 8
        Me.colPayout.Name = "colPayout"
        Me.colPayout.ReadOnly = True
        '
        'colReleased
        '
        Me.colReleased.DataPropertyName = "released"
        Me.colReleased.HeaderText = "Payslip Releasing"
        Me.colReleased.MinimumWidth = 6
        Me.colReleased.Name = "colReleased"
        Me.colReleased.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 38)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1262, 321)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RBNo)
        Me.Panel2.Controls.Add(Me.RBYes)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.DTPTo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.DTPFrom)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TxtPayrollPeriodName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(573, 321)
        Me.Panel2.TabIndex = 0
        '
        'RBNo
        '
        Me.RBNo.AutoSize = True
        Me.RBNo.Dock = System.Windows.Forms.DockStyle.Top
        Me.RBNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBNo.Location = New System.Drawing.Point(0, 296)
        Me.RBNo.Margin = New System.Windows.Forms.Padding(2)
        Me.RBNo.Name = "RBNo"
        Me.RBNo.Size = New System.Drawing.Size(573, 22)
        Me.RBNo.TabIndex = 19
        Me.RBNo.TabStop = True
        Me.RBNo.Text = "No"
        Me.RBNo.UseVisualStyleBackColor = True
        '
        'RBYes
        '
        Me.RBYes.AutoSize = True
        Me.RBYes.Dock = System.Windows.Forms.DockStyle.Top
        Me.RBYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBYes.Location = New System.Drawing.Point(0, 274)
        Me.RBYes.Margin = New System.Windows.Forms.Padding(2)
        Me.RBYes.Name = "RBYes"
        Me.RBYes.Size = New System.Drawing.Size(573, 22)
        Me.RBYes.TabIndex = 18
        Me.RBYes.TabStop = True
        Me.RBYes.Text = "Yes"
        Me.RBYes.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 235)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(573, 39)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Payout Period"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'DTPTo
        '
        Me.DTPTo.Checked = True
        Me.DTPTo.CustomFormat = "MMM/dd/yyyy"
        Me.DTPTo.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTPTo.FillColor = System.Drawing.Color.White
        Me.DTPTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(0, 194)
        Me.DTPTo.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.Size = New System.Drawing.Size(573, 41)
        Me.DTPTo.TabIndex = 16
        Me.DTPTo.Value = New Date(2025, 4, 9, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 155)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(573, 39)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "To"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'DTPFrom
        '
        Me.DTPFrom.Checked = True
        Me.DTPFrom.CustomFormat = "MMM/dd/yyyy"
        Me.DTPFrom.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTPFrom.FillColor = System.Drawing.Color.White
        Me.DTPFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(0, 114)
        Me.DTPFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPFrom.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.Size = New System.Drawing.Size(573, 41)
        Me.DTPFrom.TabIndex = 14
        Me.DTPFrom.Value = New Date(2025, 4, 9, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(573, 39)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "From"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TxtPayrollPeriodName
        '
        Me.TxtPayrollPeriodName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtPayrollPeriodName.BorderRadius = 5
        Me.TxtPayrollPeriodName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPayrollPeriodName.DefaultText = ""
        Me.TxtPayrollPeriodName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPayrollPeriodName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPayrollPeriodName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPayrollPeriodName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPayrollPeriodName.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtPayrollPeriodName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtPayrollPeriodName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPayrollPeriodName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtPayrollPeriodName.Location = New System.Drawing.Point(0, 39)
        Me.TxtPayrollPeriodName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPayrollPeriodName.Name = "TxtPayrollPeriodName"
        Me.TxtPayrollPeriodName.PlaceholderText = ""
        Me.TxtPayrollPeriodName.SelectedText = ""
        Me.TxtPayrollPeriodName.Size = New System.Drawing.Size(573, 36)
        Me.TxtPayrollPeriodName.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(573, 39)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Payroll Period Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1262, 36)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Payroll Period Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnSave
        '
        Me.BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(2, 831)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(1262, 41)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "SAVE"
        '
        'TPPayrollCalculation
        '
        Me.TPPayrollCalculation.Controls.Add(Me.DGVEmployeeList)
        Me.TPPayrollCalculation.Controls.Add(Me.Panel5)
        Me.TPPayrollCalculation.Controls.Add(Me.Panel3)
        Me.TPPayrollCalculation.Location = New System.Drawing.Point(184, 4)
        Me.TPPayrollCalculation.Margin = New System.Windows.Forms.Padding(2)
        Me.TPPayrollCalculation.Name = "TPPayrollCalculation"
        Me.TPPayrollCalculation.Padding = New System.Windows.Forms.Padding(2)
        Me.TPPayrollCalculation.Size = New System.Drawing.Size(1266, 874)
        Me.TPPayrollCalculation.TabIndex = 2
        Me.TPPayrollCalculation.Text = "Payroll Calculation"
        Me.TPPayrollCalculation.UseVisualStyleBackColor = True
        '
        'DGVEmployeeList
        '
        Me.DGVEmployeeList.AllowUserToAddRows = False
        Me.DGVEmployeeList.AllowUserToDeleteRows = False
        Me.DGVEmployeeList.AllowUserToResizeColumns = False
        Me.DGVEmployeeList.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DGVEmployeeList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVEmployeeList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVEmployeeList.ColumnHeadersHeight = 30
        Me.DGVEmployeeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column12, Me.Column13, Me.Column14})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVEmployeeList.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGVEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVEmployeeList.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVEmployeeList.Location = New System.Drawing.Point(2, 55)
        Me.DGVEmployeeList.MultiSelect = False
        Me.DGVEmployeeList.Name = "DGVEmployeeList"
        Me.DGVEmployeeList.ReadOnly = True
        Me.DGVEmployeeList.RowHeadersVisible = False
        Me.DGVEmployeeList.RowHeadersWidth = 51
        Me.DGVEmployeeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVEmployeeList.Size = New System.Drawing.Size(1262, 817)
        Me.DGVEmployeeList.TabIndex = 81
        Me.DGVEmployeeList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVEmployeeList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVEmployeeList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVEmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVEmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVEmployeeList.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGVEmployeeList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVEmployeeList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVEmployeeList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVEmployeeList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVEmployeeList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVEmployeeList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVEmployeeList.ThemeStyle.HeaderStyle.Height = 30
        Me.DGVEmployeeList.ThemeStyle.ReadOnly = True
        Me.DGVEmployeeList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVEmployeeList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVEmployeeList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVEmployeeList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGVEmployeeList.ThemeStyle.RowsStyle.Height = 22
        Me.DGVEmployeeList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVEmployeeList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "employeeID"
        Me.Column2.HeaderText = "Employee ID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "employeeNumber"
        Me.Column1.HeaderText = "Employee Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "fullname"
        Me.Column12.HeaderText = "Name"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "departmentName"
        Me.Column13.HeaderText = "Department"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "positionName"
        Me.Column14.HeaderText = "Position"
        Me.Column14.MinimumWidth = 6
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(2, 50)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1262, 5)
        Me.Panel5.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.TxtPayrollPeriod)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Guna2Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1262, 48)
        Me.Panel3.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(706, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 48)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Payroll Period:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPayrollPeriod
        '
        Me.TxtPayrollPeriod.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtPayrollPeriod.BorderRadius = 5
        Me.TxtPayrollPeriod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPayrollPeriod.DefaultText = ""
        Me.TxtPayrollPeriod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPayrollPeriod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPayrollPeriod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPayrollPeriod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPayrollPeriod.Dock = System.Windows.Forms.DockStyle.Right
        Me.TxtPayrollPeriod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtPayrollPeriod.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPayrollPeriod.ForeColor = System.Drawing.Color.Black
        Me.TxtPayrollPeriod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtPayrollPeriod.Location = New System.Drawing.Point(838, 0)
        Me.TxtPayrollPeriod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPayrollPeriod.Name = "TxtPayrollPeriod"
        Me.TxtPayrollPeriod.PlaceholderText = ""
        Me.TxtPayrollPeriod.ReadOnly = True
        Me.TxtPayrollPeriod.SelectedText = ""
        Me.TxtPayrollPeriod.Size = New System.Drawing.Size(236, 48)
        Me.TxtPayrollPeriod.TabIndex = 28
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1074, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 48)
        Me.Panel4.TabIndex = 26
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(1079, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(183, 48)
        Me.Guna2Button1.TabIndex = 25
        Me.Guna2Button1.Text = "Change Payroll Period"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeletePayrollPeriodToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(184, 26)
        '
        'DeletePayrollPeriodToolStripMenuItem
        '
        Me.DeletePayrollPeriodToolStripMenuItem.Name = "DeletePayrollPeriodToolStripMenuItem"
        Me.DeletePayrollPeriodToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DeletePayrollPeriodToolStripMenuItem.Text = "&Delete Payroll Period"
        '
        'FrmPayrollCalculation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1454, 882)
        Me.ControlBox = False
        Me.Controls.Add(Me.TCEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmPayrollCalculation"
        Me.TCEmployee.ResumeLayout(False)
        Me.TPPayrollPeriod.ResumeLayout(False)
        CType(Me.DGPayrollPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TPPayrollCalculation.ResumeLayout(False)
        CType(Me.DGVEmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TCEmployee As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TPPayrollPeriod As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPayrollPeriodName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DTPTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DTPFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents TPPayrollCalculation As TabPage
    Friend WithEvents RBNo As RadioButton
    Friend WithEvents RBYes As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents DGPayrollPeriod As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DGVEmployeeList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPayrollPeriod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents colPayrollPeriodID As DataGridViewTextBoxColumn
    Friend WithEvents colPayrollPeriodName As DataGridViewTextBoxColumn
    Friend WithEvents colDateFrom As DataGridViewTextBoxColumn
    Friend WithEvents colDateTo As DataGridViewTextBoxColumn
    Friend WithEvents colPayout As DataGridViewTextBoxColumn
    Friend WithEvents colReleased As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeletePayrollPeriodToolStripMenuItem As ToolStripMenuItem
End Class

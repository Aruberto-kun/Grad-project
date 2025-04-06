<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayroll
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DGAttendance = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOvertime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOtRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUndertime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNightDifferential = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoliday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClassification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DGVoluntary = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.voluntaryID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voluntaryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voluntaryAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DGIncentive = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.incentiveID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.incentiveName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.incentiveAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TxtNetPay = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TxtGrossPay = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.TxtTax = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtPagIbig = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPhilHealth = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtSSS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TxtTotalDeduc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtMandatory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtVoluntaryContributions = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtUndertime = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtLate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.TxtTotalIncrease = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtNightDifferential = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtIncentives = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtAllowance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtOvertime = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DGAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.DGVoluntary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGIncentive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1789, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 998)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 998)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1784, 5)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 993)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1784, 5)
        Me.Panel4.TabIndex = 3
        '
        'DGAttendance
        '
        Me.DGAttendance.AllowUserToAddRows = False
        Me.DGAttendance.AllowUserToDeleteRows = False
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        Me.DGAttendance.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        Me.DGAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAttendance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.DGAttendance.ColumnHeadersHeight = 40
        Me.DGAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGAttendance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.Column1, Me.colTimeIn, Me.colTimeOut, Me.colOvertime, Me.colOtRemarks, Me.colLate, Me.colUndertime, Me.colNightDifferential, Me.colReport, Me.colHoliday, Me.colClassification})
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGAttendance.DefaultCellStyle = DataGridViewCellStyle21
        Me.DGAttendance.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGAttendance.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGAttendance.Location = New System.Drawing.Point(5, 5)
        Me.DGAttendance.Margin = New System.Windows.Forms.Padding(2)
        Me.DGAttendance.Name = "DGAttendance"
        Me.DGAttendance.ReadOnly = True
        Me.DGAttendance.RowHeadersVisible = False
        Me.DGAttendance.RowHeadersWidth = 62
        Me.DGAttendance.RowTemplate.Height = 28
        Me.DGAttendance.Size = New System.Drawing.Size(1784, 220)
        Me.DGAttendance.TabIndex = 17
        Me.DGAttendance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGAttendance.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGAttendance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGAttendance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGAttendance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGAttendance.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGAttendance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGAttendance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGAttendance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGAttendance.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGAttendance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGAttendance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGAttendance.ThemeStyle.HeaderStyle.Height = 40
        Me.DGAttendance.ThemeStyle.ReadOnly = True
        Me.DGAttendance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGAttendance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGAttendance.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGAttendance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGAttendance.ThemeStyle.RowsStyle.Height = 28
        Me.DGAttendance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGAttendance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "date"
        Me.colDate.HeaderText = "Date"
        Me.colDate.MinimumWidth = 8
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "dayname"
        Me.Column1.HeaderText = "Day"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'colTimeIn
        '
        Me.colTimeIn.DataPropertyName = "login"
        Me.colTimeIn.HeaderText = "Time In"
        Me.colTimeIn.MinimumWidth = 8
        Me.colTimeIn.Name = "colTimeIn"
        Me.colTimeIn.ReadOnly = True
        '
        'colTimeOut
        '
        Me.colTimeOut.DataPropertyName = "logout"
        Me.colTimeOut.HeaderText = "Time Out"
        Me.colTimeOut.MinimumWidth = 8
        Me.colTimeOut.Name = "colTimeOut"
        Me.colTimeOut.ReadOnly = True
        '
        'colOvertime
        '
        Me.colOvertime.DataPropertyName = "overtime"
        Me.colOvertime.HeaderText = "Overtime"
        Me.colOvertime.MinimumWidth = 8
        Me.colOvertime.Name = "colOvertime"
        Me.colOvertime.ReadOnly = True
        '
        'colOtRemarks
        '
        Me.colOtRemarks.DataPropertyName = "otremark"
        Me.colOtRemarks.HeaderText = "Overtime Remark"
        Me.colOtRemarks.MinimumWidth = 6
        Me.colOtRemarks.Name = "colOtRemarks"
        Me.colOtRemarks.ReadOnly = True
        '
        'colLate
        '
        Me.colLate.DataPropertyName = "late"
        Me.colLate.HeaderText = "Late"
        Me.colLate.MinimumWidth = 8
        Me.colLate.Name = "colLate"
        Me.colLate.ReadOnly = True
        '
        'colUndertime
        '
        Me.colUndertime.DataPropertyName = "undertime"
        Me.colUndertime.HeaderText = "Undertime"
        Me.colUndertime.MinimumWidth = 8
        Me.colUndertime.Name = "colUndertime"
        Me.colUndertime.ReadOnly = True
        '
        'colNightDifferential
        '
        Me.colNightDifferential.DataPropertyName = "nightdifferential"
        Me.colNightDifferential.HeaderText = "Night Differential"
        Me.colNightDifferential.MinimumWidth = 6
        Me.colNightDifferential.Name = "colNightDifferential"
        Me.colNightDifferential.ReadOnly = True
        '
        'colReport
        '
        Me.colReport.DataPropertyName = "report"
        Me.colReport.HeaderText = "Record Entry"
        Me.colReport.MinimumWidth = 6
        Me.colReport.Name = "colReport"
        Me.colReport.ReadOnly = True
        '
        'colHoliday
        '
        Me.colHoliday.DataPropertyName = "classification"
        Me.colHoliday.HeaderText = "Holiday"
        Me.colHoliday.MinimumWidth = 6
        Me.colHoliday.Name = "colHoliday"
        Me.colHoliday.ReadOnly = True
        '
        'colClassification
        '
        Me.colClassification.DataPropertyName = "dayremark"
        Me.colClassification.HeaderText = "Day Classification"
        Me.colClassification.MinimumWidth = 6
        Me.colClassification.Name = "colClassification"
        Me.colClassification.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(5, 225)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1784, 5)
        Me.Panel5.TabIndex = 18
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.DGVoluntary)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.DGIncentive)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(5, 230)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1784, 200)
        Me.Panel6.TabIndex = 78
        '
        'DGVoluntary
        '
        Me.DGVoluntary.AllowUserToAddRows = False
        Me.DGVoluntary.AllowUserToDeleteRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.White
        Me.DGVoluntary.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.DGVoluntary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVoluntary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DGVoluntary.ColumnHeadersHeight = 30
        Me.DGVoluntary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVoluntary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.voluntaryID, Me.voluntaryName, Me.voluntaryAmount})
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVoluntary.DefaultCellStyle = DataGridViewCellStyle24
        Me.DGVoluntary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVoluntary.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVoluntary.Location = New System.Drawing.Point(873, 0)
        Me.DGVoluntary.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVoluntary.Name = "DGVoluntary"
        Me.DGVoluntary.RowHeadersVisible = False
        Me.DGVoluntary.RowHeadersWidth = 62
        Me.DGVoluntary.RowTemplate.Height = 28
        Me.DGVoluntary.Size = New System.Drawing.Size(911, 200)
        Me.DGVoluntary.TabIndex = 22
        Me.DGVoluntary.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVoluntary.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVoluntary.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVoluntary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVoluntary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVoluntary.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGVoluntary.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVoluntary.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVoluntary.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVoluntary.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVoluntary.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVoluntary.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVoluntary.ThemeStyle.HeaderStyle.Height = 30
        Me.DGVoluntary.ThemeStyle.ReadOnly = False
        Me.DGVoluntary.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVoluntary.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVoluntary.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVoluntary.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGVoluntary.ThemeStyle.RowsStyle.Height = 28
        Me.DGVoluntary.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVoluntary.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'voluntaryID
        '
        Me.voluntaryID.DataPropertyName = "voluntaryID"
        Me.voluntaryID.HeaderText = "Voluntary ID"
        Me.voluntaryID.MinimumWidth = 8
        Me.voluntaryID.Name = "voluntaryID"
        Me.voluntaryID.ReadOnly = True
        Me.voluntaryID.Visible = False
        '
        'voluntaryName
        '
        Me.voluntaryName.DataPropertyName = "name"
        Me.voluntaryName.HeaderText = "Voluntary Contribution"
        Me.voluntaryName.MinimumWidth = 8
        Me.voluntaryName.Name = "voluntaryName"
        Me.voluntaryName.ReadOnly = True
        '
        'voluntaryAmount
        '
        Me.voluntaryAmount.DataPropertyName = "Amount"
        Me.voluntaryAmount.HeaderText = "Amount"
        Me.voluntaryAmount.MinimumWidth = 8
        Me.voluntaryAmount.Name = "voluntaryAmount"
        Me.voluntaryAmount.ReadOnly = True
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(869, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(4, 200)
        Me.Panel7.TabIndex = 21
        '
        'DGIncentive
        '
        Me.DGIncentive.AllowUserToAddRows = False
        Me.DGIncentive.AllowUserToDeleteRows = False
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.White
        Me.DGIncentive.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.DGIncentive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGIncentive.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.DGIncentive.ColumnHeadersHeight = 30
        Me.DGIncentive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGIncentive.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.incentiveID, Me.incentiveName, Me.incentiveAmount})
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGIncentive.DefaultCellStyle = DataGridViewCellStyle27
        Me.DGIncentive.Dock = System.Windows.Forms.DockStyle.Left
        Me.DGIncentive.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGIncentive.Location = New System.Drawing.Point(0, 0)
        Me.DGIncentive.Margin = New System.Windows.Forms.Padding(2)
        Me.DGIncentive.Name = "DGIncentive"
        Me.DGIncentive.RowHeadersVisible = False
        Me.DGIncentive.RowHeadersWidth = 62
        Me.DGIncentive.RowTemplate.Height = 28
        Me.DGIncentive.Size = New System.Drawing.Size(869, 200)
        Me.DGIncentive.TabIndex = 18
        Me.DGIncentive.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGIncentive.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGIncentive.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGIncentive.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGIncentive.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGIncentive.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGIncentive.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGIncentive.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGIncentive.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGIncentive.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGIncentive.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGIncentive.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGIncentive.ThemeStyle.HeaderStyle.Height = 30
        Me.DGIncentive.ThemeStyle.ReadOnly = False
        Me.DGIncentive.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGIncentive.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGIncentive.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGIncentive.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGIncentive.ThemeStyle.RowsStyle.Height = 28
        Me.DGIncentive.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGIncentive.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'incentiveID
        '
        Me.incentiveID.DataPropertyName = "incentiveID"
        Me.incentiveID.HeaderText = "Incentive ID"
        Me.incentiveID.MinimumWidth = 8
        Me.incentiveID.Name = "incentiveID"
        Me.incentiveID.Visible = False
        '
        'incentiveName
        '
        Me.incentiveName.DataPropertyName = "incentiveName"
        Me.incentiveName.HeaderText = "Incentive Name"
        Me.incentiveName.MinimumWidth = 8
        Me.incentiveName.Name = "incentiveName"
        '
        'incentiveAmount
        '
        Me.incentiveAmount.HeaderText = "Amount"
        Me.incentiveAmount.MinimumWidth = 8
        Me.incentiveAmount.Name = "incentiveAmount"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel14)
        Me.Panel9.Controls.Add(Me.Panel15)
        Me.Panel9.Controls.Add(Me.Panel13)
        Me.Panel9.Controls.Add(Me.Panel12)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Controls.Add(Me.Panel16)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(5, 435)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1784, 490)
        Me.Panel9.TabIndex = 80
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Guna2GroupBox2)
        Me.Panel14.Controls.Add(Me.Guna2GroupBox1)
        Me.Panel14.Controls.Add(Me.Panel21)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(846, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(418, 490)
        Me.Panel14.TabIndex = 9
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.TxtNetPay)
        Me.Guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(0, 100)
        Me.Guna2GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(418, 76)
        Me.Guna2GroupBox2.TabIndex = 60
        Me.Guna2GroupBox2.Text = "Net Pay"
        '
        'TxtNetPay
        '
        Me.TxtNetPay.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtNetPay.BorderRadius = 5
        Me.TxtNetPay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNetPay.DefaultText = ""
        Me.TxtNetPay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtNetPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtNetPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNetPay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNetPay.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtNetPay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtNetPay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtNetPay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtNetPay.Location = New System.Drawing.Point(0, 40)
        Me.TxtNetPay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNetPay.Name = "TxtNetPay"
        Me.TxtNetPay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtNetPay.PlaceholderText = ""
        Me.TxtNetPay.ReadOnly = True
        Me.TxtNetPay.SelectedText = ""
        Me.TxtNetPay.Size = New System.Drawing.Size(418, 35)
        Me.TxtNetPay.TabIndex = 55
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.TxtGrossPay)
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(418, 76)
        Me.Guna2GroupBox1.TabIndex = 59
        Me.Guna2GroupBox1.Text = "Gross Pay"
        '
        'TxtGrossPay
        '
        Me.TxtGrossPay.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtGrossPay.BorderRadius = 5
        Me.TxtGrossPay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGrossPay.DefaultText = ""
        Me.TxtGrossPay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtGrossPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtGrossPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtGrossPay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtGrossPay.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtGrossPay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtGrossPay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtGrossPay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtGrossPay.Location = New System.Drawing.Point(0, 40)
        Me.TxtGrossPay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtGrossPay.Name = "TxtGrossPay"
        Me.TxtGrossPay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtGrossPay.PlaceholderText = ""
        Me.TxtGrossPay.ReadOnly = True
        Me.TxtGrossPay.SelectedText = ""
        Me.TxtGrossPay.Size = New System.Drawing.Size(418, 35)
        Me.TxtGrossPay.TabIndex = 55
        '
        'Panel21
        '
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(0, 0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(418, 24)
        Me.Panel21.TabIndex = 0
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(826, 0)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(20, 490)
        Me.Panel15.TabIndex = 8
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.TxtTax)
        Me.Panel13.Controls.Add(Me.Label12)
        Me.Panel13.Controls.Add(Me.TxtPagIbig)
        Me.Panel13.Controls.Add(Me.Label11)
        Me.Panel13.Controls.Add(Me.TxtPhilHealth)
        Me.Panel13.Controls.Add(Me.Label10)
        Me.Panel13.Controls.Add(Me.TxtSSS)
        Me.Panel13.Controls.Add(Me.Label9)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(564, 0)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(262, 490)
        Me.Panel13.TabIndex = 6
        '
        'TxtTax
        '
        Me.TxtTax.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtTax.BorderRadius = 5
        Me.TxtTax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTax.DefaultText = ""
        Me.TxtTax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtTax.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtTax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTax.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtTax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtTax.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtTax.ForeColor = System.Drawing.Color.Black
        Me.TxtTax.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtTax.Location = New System.Drawing.Point(0, 205)
        Me.TxtTax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTax.Name = "TxtTax"
        Me.TxtTax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTax.PlaceholderText = ""
        Me.TxtTax.ReadOnly = True
        Me.TxtTax.SelectedText = ""
        Me.TxtTax.Size = New System.Drawing.Size(262, 35)
        Me.TxtTax.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(0, 180)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(262, 25)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Tax"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPagIbig
        '
        Me.TxtPagIbig.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtPagIbig.BorderRadius = 5
        Me.TxtPagIbig.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPagIbig.DefaultText = ""
        Me.TxtPagIbig.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPagIbig.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPagIbig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPagIbig.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPagIbig.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtPagIbig.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtPagIbig.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPagIbig.ForeColor = System.Drawing.Color.Black
        Me.TxtPagIbig.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtPagIbig.Location = New System.Drawing.Point(0, 145)
        Me.TxtPagIbig.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPagIbig.Name = "TxtPagIbig"
        Me.TxtPagIbig.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPagIbig.PlaceholderText = ""
        Me.TxtPagIbig.ReadOnly = True
        Me.TxtPagIbig.SelectedText = ""
        Me.TxtPagIbig.Size = New System.Drawing.Size(262, 35)
        Me.TxtPagIbig.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 120)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(262, 25)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Pag-Ibig"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPhilHealth
        '
        Me.TxtPhilHealth.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtPhilHealth.BorderRadius = 5
        Me.TxtPhilHealth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPhilHealth.DefaultText = ""
        Me.TxtPhilHealth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPhilHealth.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPhilHealth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPhilHealth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPhilHealth.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtPhilHealth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtPhilHealth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPhilHealth.ForeColor = System.Drawing.Color.Black
        Me.TxtPhilHealth.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtPhilHealth.Location = New System.Drawing.Point(0, 85)
        Me.TxtPhilHealth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPhilHealth.Name = "TxtPhilHealth"
        Me.TxtPhilHealth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPhilHealth.PlaceholderText = ""
        Me.TxtPhilHealth.ReadOnly = True
        Me.TxtPhilHealth.SelectedText = ""
        Me.TxtPhilHealth.Size = New System.Drawing.Size(262, 35)
        Me.TxtPhilHealth.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 60)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(262, 25)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "PhilHealth"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtSSS
        '
        Me.TxtSSS.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtSSS.BorderRadius = 5
        Me.TxtSSS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSSS.DefaultText = ""
        Me.TxtSSS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSSS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSSS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSSS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSSS.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtSSS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtSSS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSSS.ForeColor = System.Drawing.Color.Black
        Me.TxtSSS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtSSS.Location = New System.Drawing.Point(0, 25)
        Me.TxtSSS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtSSS.Name = "TxtSSS"
        Me.TxtSSS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSSS.PlaceholderText = ""
        Me.TxtSSS.ReadOnly = True
        Me.TxtSSS.SelectedText = ""
        Me.TxtSSS.Size = New System.Drawing.Size(262, 35)
        Me.TxtSSS.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(262, 25)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "SSS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(544, 0)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(20, 490)
        Me.Panel12.TabIndex = 5
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.TxtTotalDeduc)
        Me.Panel10.Controls.Add(Me.Label19)
        Me.Panel10.Controls.Add(Me.TxtMandatory)
        Me.Panel10.Controls.Add(Me.Label20)
        Me.Panel10.Controls.Add(Me.TxtVoluntaryContributions)
        Me.Panel10.Controls.Add(Me.Label17)
        Me.Panel10.Controls.Add(Me.TxtUndertime)
        Me.Panel10.Controls.Add(Me.Label16)
        Me.Panel10.Controls.Add(Me.TxtLate)
        Me.Panel10.Controls.Add(Me.Label15)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(282, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(262, 490)
        Me.Panel10.TabIndex = 4
        '
        'TxtTotalDeduc
        '
        Me.TxtTotalDeduc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtTotalDeduc.BorderRadius = 5
        Me.TxtTotalDeduc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTotalDeduc.DefaultText = ""
        Me.TxtTotalDeduc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtTotalDeduc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtTotalDeduc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotalDeduc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotalDeduc.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtTotalDeduc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtTotalDeduc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtTotalDeduc.ForeColor = System.Drawing.Color.Black
        Me.TxtTotalDeduc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtTotalDeduc.Location = New System.Drawing.Point(0, 265)
        Me.TxtTotalDeduc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTotalDeduc.Name = "TxtTotalDeduc"
        Me.TxtTotalDeduc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTotalDeduc.PlaceholderText = ""
        Me.TxtTotalDeduc.ReadOnly = True
        Me.TxtTotalDeduc.SelectedText = ""
        Me.TxtTotalDeduc.Size = New System.Drawing.Size(262, 35)
        Me.TxtTotalDeduc.TabIndex = 62
        '
        'Label19
        '
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(0, 240)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(262, 25)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Total Deductions"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtMandatory
        '
        Me.TxtMandatory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtMandatory.BorderRadius = 5
        Me.TxtMandatory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMandatory.DefaultText = ""
        Me.TxtMandatory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtMandatory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtMandatory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtMandatory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtMandatory.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtMandatory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtMandatory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtMandatory.ForeColor = System.Drawing.Color.Black
        Me.TxtMandatory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtMandatory.Location = New System.Drawing.Point(0, 205)
        Me.TxtMandatory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMandatory.Name = "TxtMandatory"
        Me.TxtMandatory.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtMandatory.PlaceholderText = ""
        Me.TxtMandatory.ReadOnly = True
        Me.TxtMandatory.SelectedText = ""
        Me.TxtMandatory.Size = New System.Drawing.Size(262, 35)
        Me.TxtMandatory.TabIndex = 60
        '
        'Label20
        '
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(0, 180)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(262, 25)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Mandatory Contributions"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtVoluntaryContributions
        '
        Me.TxtVoluntaryContributions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtVoluntaryContributions.BorderRadius = 5
        Me.TxtVoluntaryContributions.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtVoluntaryContributions.DefaultText = ""
        Me.TxtVoluntaryContributions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtVoluntaryContributions.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtVoluntaryContributions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtVoluntaryContributions.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtVoluntaryContributions.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtVoluntaryContributions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtVoluntaryContributions.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtVoluntaryContributions.ForeColor = System.Drawing.Color.Black
        Me.TxtVoluntaryContributions.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtVoluntaryContributions.Location = New System.Drawing.Point(0, 145)
        Me.TxtVoluntaryContributions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtVoluntaryContributions.Name = "TxtVoluntaryContributions"
        Me.TxtVoluntaryContributions.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtVoluntaryContributions.PlaceholderText = ""
        Me.TxtVoluntaryContributions.ReadOnly = True
        Me.TxtVoluntaryContributions.SelectedText = ""
        Me.TxtVoluntaryContributions.Size = New System.Drawing.Size(262, 35)
        Me.TxtVoluntaryContributions.TabIndex = 40
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(0, 120)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(262, 25)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Voluntary Contributions"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtUndertime
        '
        Me.TxtUndertime.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtUndertime.BorderRadius = 5
        Me.TxtUndertime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUndertime.DefaultText = ""
        Me.TxtUndertime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUndertime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtUndertime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUndertime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUndertime.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtUndertime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtUndertime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtUndertime.ForeColor = System.Drawing.Color.Black
        Me.TxtUndertime.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtUndertime.Location = New System.Drawing.Point(0, 85)
        Me.TxtUndertime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtUndertime.Name = "TxtUndertime"
        Me.TxtUndertime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUndertime.PlaceholderText = ""
        Me.TxtUndertime.ReadOnly = True
        Me.TxtUndertime.SelectedText = ""
        Me.TxtUndertime.Size = New System.Drawing.Size(262, 35)
        Me.TxtUndertime.TabIndex = 38
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(0, 60)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(262, 25)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Undertime"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtLate
        '
        Me.TxtLate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtLate.BorderRadius = 5
        Me.TxtLate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLate.DefaultText = ""
        Me.TxtLate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtLate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtLate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLate.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtLate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtLate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtLate.ForeColor = System.Drawing.Color.Black
        Me.TxtLate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtLate.Location = New System.Drawing.Point(0, 25)
        Me.TxtLate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtLate.Name = "TxtLate"
        Me.TxtLate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtLate.PlaceholderText = ""
        Me.TxtLate.ReadOnly = True
        Me.TxtLate.SelectedText = ""
        Me.TxtLate.Size = New System.Drawing.Size(262, 35)
        Me.TxtLate.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(262, 25)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Late"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(262, 0)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(20, 490)
        Me.Panel11.TabIndex = 3
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.TxtTotalIncrease)
        Me.Panel16.Controls.Add(Me.Label21)
        Me.Panel16.Controls.Add(Me.TxtNightDifferential)
        Me.Panel16.Controls.Add(Me.Label18)
        Me.Panel16.Controls.Add(Me.TxtIncentives)
        Me.Panel16.Controls.Add(Me.Label14)
        Me.Panel16.Controls.Add(Me.TxtAllowance)
        Me.Panel16.Controls.Add(Me.Label13)
        Me.Panel16.Controls.Add(Me.TxtOvertime)
        Me.Panel16.Controls.Add(Me.Label8)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(262, 490)
        Me.Panel16.TabIndex = 1
        '
        'TxtTotalIncrease
        '
        Me.TxtTotalIncrease.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtTotalIncrease.BorderRadius = 5
        Me.TxtTotalIncrease.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTotalIncrease.DefaultText = ""
        Me.TxtTotalIncrease.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtTotalIncrease.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtTotalIncrease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotalIncrease.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotalIncrease.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtTotalIncrease.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtTotalIncrease.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtTotalIncrease.ForeColor = System.Drawing.Color.Black
        Me.TxtTotalIncrease.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtTotalIncrease.Location = New System.Drawing.Point(0, 265)
        Me.TxtTotalIncrease.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTotalIncrease.Name = "TxtTotalIncrease"
        Me.TxtTotalIncrease.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTotalIncrease.PlaceholderText = ""
        Me.TxtTotalIncrease.ReadOnly = True
        Me.TxtTotalIncrease.SelectedText = ""
        Me.TxtTotalIncrease.Size = New System.Drawing.Size(262, 35)
        Me.TxtTotalIncrease.TabIndex = 52
        '
        'Label21
        '
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(0, 240)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(262, 25)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "Total"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtNightDifferential
        '
        Me.TxtNightDifferential.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtNightDifferential.BorderRadius = 5
        Me.TxtNightDifferential.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNightDifferential.DefaultText = ""
        Me.TxtNightDifferential.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtNightDifferential.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtNightDifferential.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNightDifferential.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNightDifferential.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtNightDifferential.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtNightDifferential.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtNightDifferential.ForeColor = System.Drawing.Color.Black
        Me.TxtNightDifferential.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtNightDifferential.Location = New System.Drawing.Point(0, 205)
        Me.TxtNightDifferential.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNightDifferential.Name = "TxtNightDifferential"
        Me.TxtNightDifferential.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtNightDifferential.PlaceholderText = ""
        Me.TxtNightDifferential.ReadOnly = True
        Me.TxtNightDifferential.SelectedText = ""
        Me.TxtNightDifferential.Size = New System.Drawing.Size(262, 35)
        Me.TxtNightDifferential.TabIndex = 50
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(0, 180)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(262, 25)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "Night Differential"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtIncentives
        '
        Me.TxtIncentives.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtIncentives.BorderRadius = 5
        Me.TxtIncentives.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIncentives.DefaultText = ""
        Me.TxtIncentives.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIncentives.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIncentives.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIncentives.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIncentives.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtIncentives.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtIncentives.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtIncentives.ForeColor = System.Drawing.Color.Black
        Me.TxtIncentives.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtIncentives.Location = New System.Drawing.Point(0, 145)
        Me.TxtIncentives.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtIncentives.Name = "TxtIncentives"
        Me.TxtIncentives.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIncentives.PlaceholderText = ""
        Me.TxtIncentives.ReadOnly = True
        Me.TxtIncentives.SelectedText = ""
        Me.TxtIncentives.Size = New System.Drawing.Size(262, 35)
        Me.TxtIncentives.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(0, 120)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(262, 25)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Incentives"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.TxtAllowance.ForeColor = System.Drawing.Color.Black
        Me.TxtAllowance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtAllowance.Location = New System.Drawing.Point(0, 85)
        Me.TxtAllowance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtAllowance.Name = "TxtAllowance"
        Me.TxtAllowance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAllowance.PlaceholderText = ""
        Me.TxtAllowance.ReadOnly = True
        Me.TxtAllowance.SelectedText = ""
        Me.TxtAllowance.Size = New System.Drawing.Size(262, 35)
        Me.TxtAllowance.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 60)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(262, 25)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Allowance"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtOvertime
        '
        Me.TxtOvertime.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtOvertime.BorderRadius = 5
        Me.TxtOvertime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtOvertime.DefaultText = ""
        Me.TxtOvertime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtOvertime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtOvertime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOvertime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOvertime.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtOvertime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtOvertime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtOvertime.ForeColor = System.Drawing.Color.Black
        Me.TxtOvertime.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TxtOvertime.Location = New System.Drawing.Point(0, 25)
        Me.TxtOvertime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtOvertime.Name = "TxtOvertime"
        Me.TxtOvertime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtOvertime.PlaceholderText = ""
        Me.TxtOvertime.SelectedText = ""
        Me.TxtOvertime.Size = New System.Drawing.Size(262, 35)
        Me.TxtOvertime.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(262, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Overtime"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(5, 430)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1784, 5)
        Me.Panel8.TabIndex = 79
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(5, 925)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(1784, 32)
        Me.Guna2Button2.TabIndex = 83
        Me.Guna2Button2.Text = "SAVE"
        '
        'Panel20
        '
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel20.Location = New System.Drawing.Point(5, 957)
        Me.Panel20.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(1784, 4)
        Me.Panel20.TabIndex = 82
        '
        'Guna2Button3
        '
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.Location = New System.Drawing.Point(5, 961)
        Me.Guna2Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(1784, 32)
        Me.Guna2Button3.TabIndex = 81
        Me.Guna2Button3.Text = "CALCULATE"
        '
        'FrmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1794, 998)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Panel20)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.DGAttendance)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.DGVoluntary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGIncentive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DGAttendance As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colTimeIn As DataGridViewTextBoxColumn
    Friend WithEvents colTimeOut As DataGridViewTextBoxColumn
    Friend WithEvents colOvertime As DataGridViewTextBoxColumn
    Friend WithEvents colOtRemarks As DataGridViewTextBoxColumn
    Friend WithEvents colLate As DataGridViewTextBoxColumn
    Friend WithEvents colUndertime As DataGridViewTextBoxColumn
    Friend WithEvents colNightDifferential As DataGridViewTextBoxColumn
    Friend WithEvents colReport As DataGridViewTextBoxColumn
    Friend WithEvents colHoliday As DataGridViewTextBoxColumn
    Friend WithEvents colClassification As DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DGVoluntary As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents voluntaryID As DataGridViewTextBoxColumn
    Friend WithEvents voluntaryName As DataGridViewTextBoxColumn
    Friend WithEvents voluntaryAmount As DataGridViewTextBoxColumn
    Friend WithEvents Panel7 As Panel
    Friend WithEvents DGIncentive As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents incentiveID As DataGridViewTextBoxColumn
    Friend WithEvents incentiveName As DataGridViewTextBoxColumn
    Friend WithEvents incentiveAmount As DataGridViewTextBoxColumn
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TxtNetPay As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TxtGrossPay As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents TxtTax As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtPagIbig As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPhilHealth As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtSSS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TxtTotalDeduc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtMandatory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtVoluntaryContributions As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtUndertime As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtLate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents TxtTotalIncrease As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtNightDifferential As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtIncentives As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtAllowance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtOvertime As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAuditInfo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TxtActor = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DgAudit = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.infoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.auditID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateActed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oldValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.newValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtDateActed = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DgAudit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtDateActed)
        Me.Panel1.Controls.Add(Me.TxtActor)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 67)
        Me.Panel1.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(751, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(49, 17)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "[close]"
        '
        'TxtActor
        '
        Me.TxtActor.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtActor.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtActor.Location = New System.Drawing.Point(0, 0)
        Me.TxtActor.Name = "TxtActor"
        Me.TxtActor.Size = New System.Drawing.Size(751, 38)
        Me.TxtActor.TabIndex = 1
        Me.TxtActor.Text = "Label1"
        Me.TxtActor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(795, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 383)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 383)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 445)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(790, 5)
        Me.Panel4.TabIndex = 3
        '
        'DgAudit
        '
        Me.DgAudit.AllowUserToAddRows = False
        Me.DgAudit.AllowUserToDeleteRows = False
        Me.DgAudit.AllowUserToResizeColumns = False
        Me.DgAudit.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgAudit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgAudit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgAudit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgAudit.ColumnHeadersHeight = 40
        Me.DgAudit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.infoID, Me.auditID, Me.dateActed, Me.oldValue, Me.newValue, Me.remarks})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgAudit.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgAudit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgAudit.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgAudit.Location = New System.Drawing.Point(5, 67)
        Me.DgAudit.Margin = New System.Windows.Forms.Padding(2)
        Me.DgAudit.Name = "DgAudit"
        Me.DgAudit.ReadOnly = True
        Me.DgAudit.RowHeadersVisible = False
        Me.DgAudit.RowHeadersWidth = 51
        Me.DgAudit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgAudit.RowTemplate.Height = 24
        Me.DgAudit.Size = New System.Drawing.Size(790, 378)
        Me.DgAudit.TabIndex = 5
        Me.DgAudit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgAudit.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgAudit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgAudit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgAudit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgAudit.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgAudit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgAudit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgAudit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgAudit.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgAudit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgAudit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgAudit.ThemeStyle.HeaderStyle.Height = 40
        Me.DgAudit.ThemeStyle.ReadOnly = True
        Me.DgAudit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgAudit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgAudit.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgAudit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgAudit.ThemeStyle.RowsStyle.Height = 24
        Me.DgAudit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgAudit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'infoID
        '
        Me.infoID.DataPropertyName = "infoID"
        Me.infoID.HeaderText = "Info ID"
        Me.infoID.Name = "infoID"
        Me.infoID.ReadOnly = True
        Me.infoID.Visible = False
        '
        'auditID
        '
        Me.auditID.DataPropertyName = "auditID"
        Me.auditID.HeaderText = "Audit ID"
        Me.auditID.Name = "auditID"
        Me.auditID.ReadOnly = True
        '
        'dateActed
        '
        Me.dateActed.DataPropertyName = "dateActed"
        Me.dateActed.HeaderText = "Date"
        Me.dateActed.Name = "dateActed"
        Me.dateActed.ReadOnly = True
        '
        'oldValue
        '
        Me.oldValue.DataPropertyName = "from"
        Me.oldValue.HeaderText = "Old Value"
        Me.oldValue.Name = "oldValue"
        Me.oldValue.ReadOnly = True
        '
        'newValue
        '
        Me.newValue.DataPropertyName = "to"
        Me.newValue.HeaderText = "New Value"
        Me.newValue.Name = "newValue"
        Me.newValue.ReadOnly = True
        '
        'remarks
        '
        Me.remarks.DataPropertyName = "remarks"
        Me.remarks.HeaderText = "Action"
        Me.remarks.Name = "remarks"
        Me.remarks.ReadOnly = True
        '
        'TxtDateActed
        '
        Me.TxtDateActed.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtDateActed.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateActed.Location = New System.Drawing.Point(0, 38)
        Me.TxtDateActed.Name = "TxtDateActed"
        Me.TxtDateActed.Size = New System.Drawing.Size(751, 25)
        Me.TxtDateActed.TabIndex = 2
        Me.TxtDateActed.Text = "Label1"
        '
        'FrmAuditInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.DgAudit)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAuditInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgAudit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TxtActor As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DgAudit As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TxtDateActed As Label
    Friend WithEvents infoID As DataGridViewTextBoxColumn
    Friend WithEvents auditID As DataGridViewTextBoxColumn
    Friend WithEvents dateActed As DataGridViewTextBoxColumn
    Friend WithEvents oldValue As DataGridViewTextBoxColumn
    Friend WithEvents newValue As DataGridViewTextBoxColumn
    Friend WithEvents remarks As DataGridViewTextBoxColumn
End Class

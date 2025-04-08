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
        Me.TxtDateActed = New System.Windows.Forms.Label()
        Me.TxtActor = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DgAuditInfo = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.infoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.auditID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oldValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.newValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DgAuditInfo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DgAuditInfo
        '
        Me.DgAuditInfo.AllowUserToAddRows = False
        Me.DgAuditInfo.AllowUserToDeleteRows = False
        Me.DgAuditInfo.AllowUserToResizeColumns = False
        Me.DgAuditInfo.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgAuditInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgAuditInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgAuditInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgAuditInfo.ColumnHeadersHeight = 40
        Me.DgAuditInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.infoID, Me.auditID, Me.oldValue, Me.newValue})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgAuditInfo.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgAuditInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgAuditInfo.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgAuditInfo.Location = New System.Drawing.Point(5, 67)
        Me.DgAuditInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.DgAuditInfo.Name = "DgAuditInfo"
        Me.DgAuditInfo.ReadOnly = True
        Me.DgAuditInfo.RowHeadersVisible = False
        Me.DgAuditInfo.RowHeadersWidth = 51
        Me.DgAuditInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgAuditInfo.RowTemplate.Height = 24
        Me.DgAuditInfo.Size = New System.Drawing.Size(790, 378)
        Me.DgAuditInfo.TabIndex = 5
        Me.DgAuditInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgAuditInfo.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgAuditInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgAuditInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgAuditInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgAuditInfo.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgAuditInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgAuditInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgAuditInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgAuditInfo.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgAuditInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgAuditInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgAuditInfo.ThemeStyle.HeaderStyle.Height = 40
        Me.DgAuditInfo.ThemeStyle.ReadOnly = True
        Me.DgAuditInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgAuditInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgAuditInfo.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgAuditInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgAuditInfo.ThemeStyle.RowsStyle.Height = 24
        Me.DgAuditInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgAuditInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.auditID.Visible = False
        '
        'oldValue
        '
        Me.oldValue.DataPropertyName = "oldValue"
        Me.oldValue.HeaderText = "Old Value"
        Me.oldValue.Name = "oldValue"
        Me.oldValue.ReadOnly = True
        '
        'newValue
        '
        Me.newValue.DataPropertyName = "newValue"
        Me.newValue.HeaderText = "New Value"
        Me.newValue.Name = "newValue"
        Me.newValue.ReadOnly = True
        '
        'FrmAuditInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.DgAuditInfo)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAuditInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgAuditInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TxtActor As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DgAuditInfo As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TxtDateActed As Label
    Friend WithEvents infoID As DataGridViewTextBoxColumn
    Friend WithEvents auditID As DataGridViewTextBoxColumn
    Friend WithEvents oldValue As DataGridViewTextBoxColumn
    Friend WithEvents newValue As DataGridViewTextBoxColumn
End Class

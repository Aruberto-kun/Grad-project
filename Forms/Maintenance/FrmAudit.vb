Public Class FrmAudit
    Private Sub FrmAudit_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dt As DataTable = DisplayAudit()
        DgAudit.DataSource = dt
    End Sub

    Private Sub DgAudit_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgAudit.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedAuditID As Integer = DgAudit.Rows(e.RowIndex).Cells("auditID").Value
            Dim selectedType As String = DgAudit.Rows(e.RowIndex).Cells("actionType").Value

            If selectedType = "Update" Then
                FrmAuditInfo.DgAuditInfo.DataSource = DisplayAuditInfo(selectedAuditID)
                FrmAuditInfo.ShowDialog()
            End If
        End If
    End Sub
End Class
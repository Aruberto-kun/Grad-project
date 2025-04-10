Public Class FrmAudit
    Private Sub FrmAudit_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dt As DataTable = DisplayAudit()
        DgAudit.DataSource = dt
    End Sub

    Private Sub DgAudit_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgAudit.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedAuditID As Integer = DgAudit.Rows(e.RowIndex).Cells("auditID").Value
            Dim selectedType As String = DgAudit.Rows(e.RowIndex).Cells("actionType").Value
            Dim dateActed As String = DgAudit.Rows(e.RowIndex).Cells("dateActed").Value.ToString
            Dim actor As String = DgAudit.Rows(e.RowIndex).Cells("action").Value.ToString

            If selectedType = "Update" Then
                FrmAuditInfo.DgAuditInfo.DataSource = DisplayAuditInfo(selectedAuditID)
                FrmAuditInfo.TxtActor.Text = actor
                FrmAuditInfo.TxtDateActed.Text = dateActed
                FrmAuditInfo.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RunQuery("Select * from tblaudit")
        Dim count As Integer = ds.Tables("querytable").Rows.Count
        If count > DgAudit.Rows.Count Then
            Dim dt As DataTable = DisplayAudit()
            DgAudit.DataSource = dt
        End If
    End Sub
End Class
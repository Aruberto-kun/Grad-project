Public Class FrmIncentiveInfo
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtIncentiveName.Text) Then
            MsgEmptyField()
            Exit Sub
        Else
            UpdateIncentive(MdlMaintenance.incentiveID, TxtIncentiveName.Text)
            Me.Close()
            FrmMainte.DgIncentives.DataSource = DisplayIncentive()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteIncentive(MdlMaintenance.incentiveID)
        Me.Close()
        FrmMainte.DgIncentives.DataSource = DisplayIncentive()
    End Sub
End Class
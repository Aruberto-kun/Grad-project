Public Class FrmLeaveInfo
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtLeave.Text) Then
            MsgEmptyField()
            Exit Sub
        Else
            UpdateLeave(MdlMaintenance.leaveID, TxtLeave.Text)
            Me.Close()
            FrmMainte.dgLeave.DataSource = DisplayLeave()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteLeave(MdlMaintenance.leaveID)
        Me.Close()
        FrmMainte.dgLeave.DataSource = DisplayLeave()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class
Public Class FrmDepartmentInfo
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtDepartment.Text) Then
            MsgEmptyField()
            Exit Sub
        Else
            UpdateDepartment(MdlMaintenance.departmentID, TxtDepartment.Text)
            Me.Close()
            FrmMainte.DgDepartment.DataSource = DisplayDepartment()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteDepartment(MdlMaintenance.departmentID)
        Me.Close()
        FrmMainte.DgDepartment.DataSource = DisplayDepartment()
    End Sub
End Class
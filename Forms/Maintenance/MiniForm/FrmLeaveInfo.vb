Imports System.Text.RegularExpressions

Public Class FrmLeaveInfo

    Dim leaveName As String = ""
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtLeave.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtLeave.Text, forNames) Then
            MessageBox.Show("Invalid type of leave.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            UpdateLeave(MdlMaintenance.leaveID, TxtLeave.Text)
            Auditing($"{FrmMain.fullName} updated the leave {leaveName} to {TxtLeave.Text}", "Others")
            Me.Close()
            FrmMainte.dgLeave.DataSource = DisplayLeave()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteLeave(MdlMaintenance.leaveID)
        Auditing($"{FrmMain.fullName} set the leave {leaveName} to inactive.", "Others")
        Me.Close()
        FrmMainte.dgLeave.DataSource = DisplayLeave()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub FrmLeaveInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        leaveName = TxtLeave.Text
    End Sub
End Class
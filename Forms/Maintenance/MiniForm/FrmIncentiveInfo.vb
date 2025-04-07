Imports System.Text.RegularExpressions

Public Class FrmIncentiveInfo

    Dim incentive As String = ""

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtIncentiveName.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtIncentiveName.Text, forNames) Then
            MessageBox.Show("Invalid incentive name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            UpdateIncentive(MdlMaintenance.incentiveID, TxtIncentiveName.Text)
            Auditing($"{FrmMain.fullName} updated the incentive from {incentive} to {TxtIncentiveName.Text}")
            Me.Close()
            FrmMainte.DgIncentives.DataSource = DisplayIncentive()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteIncentive(MdlMaintenance.incentiveID)
        Auditing($"{FrmMain.fullName} set the incentive {incentive} to inactive.")
        Me.Close()
        FrmMainte.DgIncentives.DataSource = DisplayIncentive()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub FrmIncentiveInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        incentive = TxtIncentiveName.Text
    End Sub
End Class
Imports System.Text.RegularExpressions

Public Class FrmPositionInfo
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub FrmPositionInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtPosition.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtPosition.Text, forNames) Then
            MessageBox.Show("Invalid position name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            UpdatePosition(MdlMaintenance.positionID, TxtPosition.Text)
            Me.Close()
            FrmMainte.DgPosition.DataSource = DisplayPosition()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeletePosition(MdlMaintenance.positionID)
        Me.Close()
        FrmMainte.DgPosition.DataSource = DisplayPosition()
    End Sub
End Class
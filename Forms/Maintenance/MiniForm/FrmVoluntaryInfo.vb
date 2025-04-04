Imports System.Text.RegularExpressions

Public Class FrmVoluntaryInfo
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtVoluntary.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtVoluntary.Text, forNames) Then
            MessageBox.Show("Invalid type of voluntary.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            UpdateVoluntary(MdlMaintenance.voluntaryID, TxtVoluntary.Text)
            Me.Close()
            FrmMainte.DgVoluntary.DataSource = DisplayVoluntary()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteVoluntary(MdlMaintenance.voluntaryID)
        Me.Close()
        FrmMainte.DgVoluntary.DataSource = DisplayVoluntary()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class
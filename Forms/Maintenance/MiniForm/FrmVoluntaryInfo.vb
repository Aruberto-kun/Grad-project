Imports System.Text.RegularExpressions

Public Class FrmVoluntaryInfo

    Dim voluntary As String = ""
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtVoluntary.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtVoluntary.Text, forNames) Then
            MessageBox.Show("Invalid type of voluntary.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            UpdateVoluntary(MdlMaintenance.voluntaryID, TxtVoluntary.Text)
            Auditing($"{FrmMain.fullName} updated the voluntary {voluntary} to {TxtVoluntary.Text}", "Others")
            Me.Close()
            FrmMainte.DgVoluntary.DataSource = DisplayVoluntary()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteVoluntary(MdlMaintenance.voluntaryID)
        Auditing($"{FrmMain.fullName} set the voluntary {voluntary} to inactive.", "Others")
        Me.Close()
        FrmMainte.DgVoluntary.DataSource = DisplayVoluntary()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub FrmVoluntaryInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        voluntary = TxtVoluntary.Text
    End Sub
End Class
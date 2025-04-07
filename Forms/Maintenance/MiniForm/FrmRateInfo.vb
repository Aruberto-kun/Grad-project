Imports System.Text.RegularExpressions

Public Class FrmRateInfo
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtRates.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtRates.Text, forNumbers) Then
            MessageBox.Show("Invalid rate.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtRates.Clear()
            Exit Sub
        ElseIf Val(TxtRates.Text <= 0) Then
            MessageBox.Show("Invalid rate.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtRates.Clear()
            Exit Sub
        ElseIf Val(TxtRates.Text > 350) Then
            MessageBox.Show("Invalid rate.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dim rate As Integer = Val(TxtRates.Text)
            UpdateRate(rate, MdlMaintenance.rateID)
            Auditing($"{FrmMain.fullName} updated the rate of {TxtRateClassification.Text} to {TxtRates.Text}")
            Me.Close()
            FrmMainte.dgRates.DataSource = DisplayRates()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class
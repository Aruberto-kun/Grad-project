Imports System.Text.RegularExpressions

Public Class FrmHoliday
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtHolidayName.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtHolidayName.Text, forNames) Then
            MessageBox.Show("Invalid holiday name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtHolidayName.Clear()
            Exit Sub
        Else
            UpdateHoliday(MdlMaintenance.holidayID, DtHoliday.Value, TxtHolidayName.Text, CbClassification.SelectedItem.ToString)
            Auditing($"{FrmMain.fullName} updated a holiday.", "Others")
            Me.Close()
            FrmMainte.dgHoliday.DataSource = DisplayHoliday()
        End If
    End Sub

    Private Sub FrmHoliday_Load(sender As Object, e As EventArgs) Handles Me.Load
        CbClassification.SelectedIndex = 0
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteHoliday(MdlMaintenance.holidayID)
        Auditing($"{FrmMain.fullName} delete a holiday.", "Others")
        Me.Close()
        FrmMainte.dgHoliday.DataSource = DisplayHoliday()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class
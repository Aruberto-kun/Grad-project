Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class FrmAddEmployee
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        FrmEmployee.Enabled = True
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim lastName As String = StrConv(TxtLastname.Text, VbStrConv.ProperCase)
            Dim firstName As String = StrConv(TxtFirstName.Text, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(firstName) AndAlso
               String.IsNullOrEmpty(lastName) AndAlso
               String.IsNullOrEmpty(TxtRfidNumber.Text) AndAlso
               String.IsNullOrEmpty(TxtSalary.Text) Then
                MsgEmptyField()
                Exit Sub
            ElseIf CbDepartment.SelectedIndex = -1 OrElse CbPosition.SelectedIndex = -1 OrElse CbAssociateStatus.SelectedIndex = -1 OrElse CbAssociateStatus.SelectedIndex = -1 Then
                MsgEmptyField()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtFirstName.Text, forNames) OrElse Not Regex.IsMatch(TxtLastname.Text, forNames) Then
                MessageBox.Show("Invalid names.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf TxtRfidNumber.Text.Length <> 10 Then
                MessageBox.Show("Invalid RFID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtRfidNumber.Focus()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtSalary.Text, forPrice) Then
                MessageBox.Show("Invalid salary.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf Val(TxtSalary.Text) > 999999 Then
                MessageBox.Show("Invalid salary.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtRfidNumber.Text, numberOnly) Then
                MessageBox.Show("Invalid RFID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtRfidNumber.Focus()
                Exit Sub
            End If
            For Each row As DataGridViewRow In DGVoluntary.Rows
                Try
                    Dim amount As Integer = If(String.IsNullOrEmpty(row.Cells("amount").Value.ToString), 0, row.Cells("amount").Value)

                    If Not IsNumeric(amount) Then
                        MessageBox.Show("Voluntary amount contains only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    ElseIf amount < 0 Then
                        MessageBox.Show("Voluntary amount cannot be less than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    ElseIf amount.ToString.Length > 20 Then
                        MessageBox.Show("Invalid voluntary amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show("Invalid Voluntary amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Next


            ClassEmployee.NewEmployee(TxtRfidNumber, TxtLastname, TxtFirstName, CbDepartment, CbPosition, TxtSalary, CbAssociateStatus, TxtAllowance)
            ClassEmployee.LoadEmployee(FrmEmployee.DgEmployee)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDepartment.SelectedIndexChanged
        ClassEmployee.LoadPosition(CbDepartment, CbPosition)
    End Sub
    Private Sub FrmAddEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        ClassEmployee.LoadVoluntary(DGVoluntary)
        ClassEmployee.LoadLeaveAllocation(DGLeaveAllocation)
        ClassEmployee.LoadAllowance(TxtAllowance)
    End Sub
End Class
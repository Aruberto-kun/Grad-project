Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class FrmAddEmployee
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        TxtAllowance.Clear()
        TxtFirstName.Clear()
        TxtLastname.Clear()
        TxtRfidNumber.Clear()
        TxtSalary.Clear()
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
            ElseIf Not Regex.IsMatch(TxtFirstName.Text, forNames) Then
                MessageBox.Show("Invalid first name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtFirstName.Clear()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtLastname.Text, forNames) Then
                MessageBox.Show("Invalid last name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtLastname.Clear()
                Exit Sub
            ElseIf TxtRfidNumber.Text.Length <> 10 Then
                MessageBox.Show("Invalid RFID.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtRfidNumber.Clear()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtSalary.Text, numberOnly) Then
                MessageBox.Show("Invalid salary.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtSalary.Clear()
                Exit Sub
            ElseIf Val(TxtSalary.Text) > 999999 Then
                MessageBox.Show("Invalid salary.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtSalary.Clear()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtRfidNumber.Text, numberOnly) Then
                MessageBox.Show("Invalid RFID", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtRfidNumber.Clear()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtAllowance.Text, numberOnly) Then
                MessageBox.Show("Invalid amount of allowance.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtAllowance.Clear()
                Exit Sub
            ElseIf Val(TxtSalary.Text <= 0) Then
                MessageBox.Show("Invalid amount of salary.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf Val(TxtAllowance.Text) > 30000 Then
                MessageBox.Show("Allowance exceeds the non-taxable amount.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ClassEmployee.NewAssociate(TxtFirstName, TxtLastname, TxtRfidNumber, CbDepartment, CbPosition, TxtSalary, CbCompensationType, CbAssociateStatus, TxtAllowance)
            ClassEmployee.LoadEmployee(FrmEmployee.DgEmployee)
            Me.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgVoluntary_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGVoluntary.CellValidating
        Dim amountColumnIndex As Integer = 2
        Dim amountPattern As String = "^\d+(\.\d{1,2})?$"

        If e.ColumnIndex = amountColumnIndex Then
            If Not Regex.IsMatch(e.FormattedValue.ToString(), amountPattern) Then
                MessageBox.Show("Invalid amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            ElseIf e.FormattedValue > 100000 Then
                MessageBox.Show("Invalid amount.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            ElseIf e.FormattedValue > Val(TxtSalary.text) Then
                MessageBox.Show("Invalid amount.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub DgVoluntary_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGVoluntary.DataError
        MessageBox.Show("Invalid amount.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        e.Cancel = True
    End Sub

    Private Sub DgLeaveAllocation_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGLeaveAllocation.CellValidating
        Dim leaveColumnIndex As Integer = 2
        Dim wholeNumberPattern As String = "^\d{1,3}$"

        If e.ColumnIndex = leaveColumnIndex Then
            If Not Regex.IsMatch(e.FormattedValue.ToString(), wholeNumberPattern) Then
                MessageBox.Show("Invalid count of leave.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            ElseIf e.FormattedValue > 100 Then
                MessageBox.Show("Invalid count of leave.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub DgLeaveAllocation_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGLeaveAllocation.DataError
        MessageBox.Show("Invalid count of leave.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        e.Cancel = True
    End Sub


    Private Sub CbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDepartment.SelectedIndexChanged
        ClassEmployee.LoadPosition(CbDepartment, CbPosition)
    End Sub
    Private Sub FrmAddEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            OpenServerConnection()
            ClassEmployee.LoadVoluntaryNew(DGVoluntary)
            ClassEmployee.LoadLeaveNew(DGLeaveAllocation)
            ClassEmployee.ClearFields(TxtFirstName, TxtLastname, TxtRfidNumber, CbDepartment, CbPosition, TxtSalary, CbCompensationType, CbAssociateStatus, TxtAllowance)
        Catch ex As Exception

        End Try
    End Sub
End Class
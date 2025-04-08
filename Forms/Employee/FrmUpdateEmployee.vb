Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class FrmUpdateEmployee

    Dim oldfirstname As String = ""
    Dim oldlastname As String = ""
    Dim rfidnumber As String = ""
    Dim department As String = ""
    Dim position As String = ""
    Dim salary As String = ""
    Dim compensation As String = ""
    Dim associateStatus As String = ""
    Dim allowance As String = ""

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


            Auditing($"{FrmMain.fullName} updated {oldfirstname} {oldlastname} information.", "Update")
            Dim auditID As Integer = GetAuditID()

        ClassEmployee.UpdateAssociate(TxtFirstName, TxtLastname, TxtRfidNumber, CbDepartment, CbPosition, TxtSalary, CbCompensationType, CbAssociateStatus, TxtAllowance)

        ClassEmployee.LoadEmployee(FrmEmployee.DgEmployee)

        If TxtFirstName.Text <> oldfirstname Then
            UpdateAudit(auditID, oldfirstname, TxtFirstName.Text)
        End If

        If TxtLastname.Text <> oldlastname Then
            UpdateAudit(auditID, oldlastname, TxtLastname.Text)
        End If

        If TxtRfidNumber.Text <> rfidnumber Then
            UpdateAudit(auditID, rfidnumber, TxtRfidNumber.Text)
        End If

        If CbDepartment.Text.ToString() <> department Then
            UpdateAudit(auditID, department, CbDepartment.Text)
        End If

        If CbPosition.Text.ToString() <> position Then
            UpdateAudit(auditID, position, CbPosition.Text)
        End If

        If TxtSalary.Text <> salary Then
            UpdateAudit(auditID, salary.ToString(), TxtSalary.Text)
        End If

        If CbCompensationType.Text.ToString() <> compensation Then
            UpdateAudit(auditID, compensation, CbCompensationType.Text)
        End If

        If CbAssociateStatus.Text.ToString() <> associateStatus Then
            UpdateAudit(auditID, associateStatus, CbAssociateStatus.Text)
        End If

        If TxtAllowance.Text <> allowance Then
            UpdateAudit(auditID, allowance.ToString(), TxtAllowance.Text)
        End If
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

    Private Sub FrmUpdateEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenServerConnection()
        ClassEmployee.LoadDepartment(CbDepartment)
        ClassEmployee.SelectEmployee(FrmEmployee.DgEmployee, TxtRfidNumber, TxtFirstName, TxtLastname, CbDepartment, CbPosition, TxtSalary, CbCompensationType, CbAssociateStatus)
        ClassEmployee.LoadAllowance(TxtAllowance)
        ClassEmployee.LoadVoluntary(DGVoluntary)
        ClassEmployee.LoadLeaveAllocation(DGLeaveAllocation)

        oldfirstname = TxtFirstName.Text
        oldlastname = TxtLastname.Text
        rfidnumber = TxtRfidNumber.Text
        department = CbDepartment.Text
        position = CbPosition.Text
        salary = TxtSalary.Text
        compensation = CbCompensationType.Text
        associateStatus = CbAssociateStatus.Text
        allowance = TxtAllowance.Text
    End Sub

    Private Sub CbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDepartment.SelectedIndexChanged
        ClassEmployee.LoadPosition(CbDepartment, CbPosition)
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
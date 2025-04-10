Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class FrmPayroll
    Private Sub ClearFields()
        TxtOvertime.Clear()
        TxtAllowance.Clear()
        TxtNightDifferential.Clear()
        TxtIncentives.Clear()
        TxtTotalIncrease.Clear()
        TxtLate.Clear()
        TxtUndertime.Clear()
        TxtMandatory.Clear()
        TxtVoluntaryContributions.Clear()
        TxtTotalDeduc.Clear()
        TxtSSS.Clear()
        TxtPhilHealth.Clear()
        TxtPagIbig.Clear()
        TxtTax.Clear()
        TxtGrossPay.Clear()
        TxtNetPay.Clear()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub FrmPayroll_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenServerConnection()
        ClassPayrollCalculation.GetDailyWage(Label4)
        ClassPayrollCalculation.LoadAttendance(DGAttendance)
        ClassPayrollCalculation.EmployeeCompensationType()
        ClassPayrollCalculation.EmployeeStatus()
        ClassPayrollCalculation.LoadIncentive(DGIncentive)
        ClassPayrollCalculation.LoadAllowance(TxtAllowance)
        ClassPayrollCalculation.LoadVoluntary(DGVoluntary)
        ClearFields()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If ClassPayrollCalculation.hasschedule = False Then
            MsgBox("Employee doesn't have assigned schedule yet")
            Exit Sub
        End If

        'Check if all logins have logouts and vice versa
        For Each row As DataGridViewRow In DGAttendance.Rows
            Dim otcount As Integer = If(String.IsNullOrEmpty(row.Cells("colOvertime").Value.ToString), 0, row.Cells("colOvertime").Value)
            Dim otremarks As String = If(String.IsNullOrEmpty(row.Cells("colOtRemarks").Value.ToString), "No record", row.Cells("colOtRemarks").Value)
            Dim login As String = If(String.IsNullOrEmpty(row.Cells("colTimeIn").Value.ToString), "No record", row.Cells("colTimeIn").Value)
            Dim logout As String = If(String.IsNullOrEmpty(row.Cells("colTimeOut").Value.ToString), "No record", row.Cells("colTimeOut").Value)
            If (login = "No record" And logout <> "No record") Or (login <> "No record" And logout = "No record") Then
                MsgBox("A record doesn't have a login or logout. Please inform the employee or the Department Head")
                Exit Sub
            End If

            If otcount = 0 Then
                Continue For
            End If

            If otremarks = "No record" Then
                MsgBox("An overtime is still pending. Please inform the Department Head")
                Exit Sub
            End If
        Next
        ClassPayrollCalculation.CalculateSalaryFinal()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            If MsgBox("Verify salary calculation", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ClassPayrollCalculation.SaveSalary(TxtOvertime, TxtAllowance, TxtIncentives, TxtNightDifferential, TxtLate, TxtUndertime, TxtVoluntaryContributions, TxtSSS, TxtPhilHealth, TxtPagIbig, TxtTax, TxtMandatory, TxtTotalIncrease, TxtTotalDeduc, TxtGrossPay, TxtNetPay)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGIncentive_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGIncentive.CellValidating
        Dim columnName As String = DGIncentive.Columns(e.ColumnIndex).Name

        If columnName = "incentiveAmount" Then
            Dim value As String = e.FormattedValue.ToString()
            Dim dec As Decimal

            If Not Decimal.TryParse(value, dec) OrElse dec < 0 Then
                MessageBox.Show("Please enter a valid number greater than or equal to 0.")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FrmPayroll_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ClassPayrollCalculation.LoadEmployees(FrmPayrollCalculation.DGVEmployeeList)
    End Sub
End Class
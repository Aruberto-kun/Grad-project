Public Class FrmPayroll
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

        ClassPayrollCalculation.GetGrossPay(DGAttendance, TxtGrossPay)
        ClassPayrollCalculation.GetOvertime(DGAttendance, TxtOvertime)
        ClassPayrollCalculation.GetIncentives(DGIncentive, TxtIncentives)
        ClassPayrollCalculation.GetLate(DGAttendance, TxtLate)
        ClassPayrollCalculation.GetUndertime(DGAttendance, TxtUndertime)
        ClassPayrollCalculation.GetNightDifferential(DGAttendance, TxtNightDifferential)
        ClassPayrollCalculation.GetVoluntaryContrib(DGVoluntary, TxtVoluntaryContributions)
        ClassPayrollCalculation.GetSSS(TxtGrossPay, TxtSSS)
        ClassPayrollCalculation.GetPhilhealth(TxtGrossPay, TxtPhilHealth)
        ClassPayrollCalculation.GetPagIbig(TxtPagIbig)
        'ClassPayrollCalculation.GetTax(TxtGrossPay, TxtTax, TxtSSS, TxtPhilHealth, TxtPagIbig)
        ClassPayrollCalculation.TotalIncrease(TxtOvertime, TxtAllowance, TxtIncentives, TxtNightDifferential, TxtTotalIncrease)
        ClassPayrollCalculation.TotalMandatoryContri(TxtSSS, TxtPhilHealth, TxtPagIbig, TxtTax, TxtMandatory)
        ClassPayrollCalculation.TotalDeductions(TxtLate, TxtUndertime, TxtVoluntaryContributions, TxtMandatory, TxtTotalDeduc)
        ClassPayrollCalculation.GetNetPay(TxtGrossPay, TxtTotalIncrease, TxtTotalDeduc, TxtNetPay)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            If MsgBox("Verify salary calculation", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ClassPayrollCalculation.SaveSalary(TxtOvertime, TxtAllowance, TxtIncentives, TxtNightDifferential, TxtLate, TxtUndertime, TxtVoluntaryContributions, TxtSSS, TxtPhilHealth, TxtPagIbig, TxtTax, TxtMandatory, TxtTotalIncrease, TxtTotalDeduc, TxtGrossPay, TxtNetPay)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
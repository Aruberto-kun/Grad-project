Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class FrmDepartmentHeadControls

    Public departmentHeadName As String = ""
    Private Sub FrmDepartmentHeadControls_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenServerConnection()
        ClassDepartmentHeadControls.GetDepartmentID()
        ClassDepartmentHeadControls.GetDepartmentName(LblDeptName)
        ClassDepartmentHeadControls.LoadFiledLeave(DGFiledLeave)
        ClassDepartmentHeadControls.LoadFiledFTIO(DGFiledFTIO)
        ClassDepartmentHeadControls.LoadAttendance(DGAttendance)
        ClassDepartmentHeadControls.LoadOvertime(DGOvertime)
        ClassDepartmentHeadControls.LoadMyFiledFTIO(DGFTIOFiled)
        ClassDepartmentHeadControls.LoadLeaveType(CBLeaveType)
        ClassDepartmentHeadControls.LeaveCount(DGLeaveCount)
        ClassDepartmentHeadControls.LoadMyFiledLeave(DGLeaveFiled)
        Timer1.Start()
        Timer2.Start()
    End Sub
    Private Sub TPSchedule_Enter(sender As Object, e As EventArgs) Handles TPSchedule.Enter

        ClassDepartmentHeadControls.LoadEmployees(CbEmployees)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            If CLBSchedule.CheckedItems.Count = 0 Then
                MsgBox("Please set schedule at least 1 day")
                Exit Sub
            End If

            If CbEmployees.SelectedIndex = -1 Then
                MsgEmptyField()
                Exit Sub
            ElseIf Not Regex.IsMatch(MtbTimeIn.Text, timePattern) Then
                MessageBox.Show("Invalid time format for Time In.")
                Exit Sub
            ElseIf Not Regex.IsMatch(MtbTimeOut.Text, timePattern) Then
                MessageBox.Show("Invalid time format for Time Out.")
                Exit Sub
            End If

            Dim timeIn As TimeSpan = TimeSpan.Parse(MtbTimeIn.Text)
            Dim timeOut As TimeSpan = TimeSpan.Parse(MtbTimeOut.Text)

            If timeIn = timeOut Then
                MessageBox.Show("Time In and Time Out cannot be the same.")
                Exit Sub
            End If

            If timeIn >= timeOut Then
                MessageBox.Show("Time In must be earlier than Time Out.")
                Exit Sub
            End If

            Dim duration As TimeSpan = timeOut - timeIn

            If duration.TotalHours <> 5 Then
                MessageBox.Show("Schedule must be at least 4 hours.")
                Exit Sub
            End If

            If duration.TotalHours > 8 Then
                MessageBox.Show("Maximum allowed working hours is 8.")
                Exit Sub
            End If

            ClassDepartmentHeadControls.NewSchedule(CbEmployees, CLBSchedule, MtbTimeIn, MtbTimeOut, "12:00", "1:00")

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmDepartmentHeadControls_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        With Screen.PrimaryScreen
            Me.Size = .WorkingArea.Size
            Me.Location = Point.Empty
        End With
    End Sub
    Private Sub CbEmployees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbEmployees.SelectedIndexChanged
        Try
            ClassDepartmentHeadControls.LoadSchedule(CbEmployees, CLBSchedule, MtbTimeIn, MtbTimeOut)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGFiledLeave_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFiledLeave.CellContentClick
        'Try
        If e.RowIndex >= 0 Then
                If e.ColumnIndex = DGFiledLeave.Columns("Approve").Index Then
                    ' Get the Filed Leave ID of the selected row
                    Dim filedLeaveID As Integer = Convert.ToInt32(DGFiledLeave.Rows(e.RowIndex).Cells("Filed Leave ID").Value)

                    If MsgBox("Are you sure you want to approve the leave filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartmentHeadControls.ApproveLeave(filedLeaveID)
                        Dim name As String = DGFiledLeave.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim leaveFrom As String = DGFiledLeave.Rows(e.RowIndex).Cells("From").Value.ToString
                        Dim leaveTo As String = DGFiledLeave.Rows(e.RowIndex).Cells("To").Value.ToString
                        Auditing($"{LblName.Text} approved {name}'s leave from {leaveFrom} to {leaveTo}.", "Others")
                        ClassDepartmentHeadControls.LoadFiledLeave(DGFiledLeave)
                    End If

                ElseIf e.ColumnIndex = DGFiledLeave.Columns("Decline").Index Then
                    ' Get the Filed Leave ID of the selected row
                    Dim filedLeaveID As Integer = Convert.ToInt32(DGFiledLeave.Rows(e.RowIndex).Cells("Filed Leave ID").Value)
                    If MsgBox("Are you sure you want to decline the leave filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartmentHeadControls.DeclineLeave(filedLeaveID)
                        Dim name As String = DGFiledLeave.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim leaveFrom As String = DGFiledLeave.Rows(e.RowIndex).Cells("From").Value.ToString
                        Dim leaveTo As String = DGFiledLeave.Rows(e.RowIndex).Cells("To").Value.ToString
                        Auditing($"{LblName.Text} declined {name}'s leave from {leaveFrom} to {leaveTo}.", "Others")
                        ClassDepartmentHeadControls.LoadFiledLeave(DGFiledLeave)
                    End If

                End If
            End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub DGFiledFTIO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFiledFTIO.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = DGFiledFTIO.Columns("Approve").Index Then
                    ' Get the Filed FTIO ID of the selected row
                    Dim FTIOID As Integer = Convert.ToInt32(DGFiledFTIO.Rows(e.RowIndex).Cells("FTIO ID").Value)

                    If MsgBox("Are you sure you want to approve the FTIO filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartmentHeadControls.ApproveFTIO(FTIOID)
                        Dim name As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim ftioDate As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Date").Value.ToString
                        Dim ftioTime As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Time").Value.ToString
                        Auditing($"{LblName.Text} approved {name}'s filed FTIO dated {ftioDate} {ftioTime}.", "Others")
                        ClassDepartmentHeadControls.LoadFiledFTIO(DGFiledFTIO)
                    End If

                ElseIf e.ColumnIndex = DGFiledFTIO.Columns("Decline").Index Then
                    ' Get the Filed FTIO ID of the selected row
                    Dim FTIOID As Integer = Convert.ToInt32(DGFiledFTIO.Rows(e.RowIndex).Cells("FTIO ID").Value)
                    If MsgBox("Are you sure you want to decline the FTIO filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartmentHeadControls.DeclineFTIO(FTIOID)
                        Dim name As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim ftioDate As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Date").Value.ToString
                        Dim ftioTime As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Time").Value.ToString
                        Auditing($"{LblName.Text} declined {name}'s filed FTIO dated {ftioDate} {ftioTime}.", "Others")
                        ClassDepartmentHeadControls.LoadFiledFTIO(DGFiledFTIO)
                    End If

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGOvertime_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOvertime.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = DGOvertime.Columns("Approve").Index Then
                    ' Get the Filed FTIO ID of the selected row
                    Dim employeeID As Integer = Convert.ToInt32(DGOvertime.Rows(e.RowIndex).Cells("Employee ID").Value)
                    Dim attendanceID As Integer = Convert.ToInt32(DGOvertime.Rows(e.RowIndex).Cells("Attendance ID").Value)


                    If MsgBox("Are you sure you want to approve the Overtime filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartmentHeadControls.ApproveOvertime(employeeID, attendanceID, DGOvertime)
                        Dim name As String = DGOvertime.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim overtimeDate As String = DGOvertime.Rows(e.RowIndex).Cells("Attendance Date").Value.ToString
                        Auditing($"{LblName.Text} approved {name}'s overtime dated {overtimeDate}.", "Others")
                        ClassDepartmentHeadControls.LoadOvertime(DGOvertime)
                    End If

                ElseIf e.ColumnIndex = DGOvertime.Columns("Decline").Index Then
                    ' Get the Filed FTIO ID of the selected row
                    Dim employeeID As Integer = Convert.ToInt32(DGOvertime.Rows(e.RowIndex).Cells("Employee ID").Value)
                    Dim attendanceID As Integer = Convert.ToInt32(DGOvertime.Rows(e.RowIndex).Cells("Attendance ID").Value)
                    If MsgBox("Are you sure you want to decline the Overtime filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartmentHeadControls.DeclineOvertime(employeeID, attendanceID, DGOvertime)
                        Dim name As String = DGOvertime.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim overtimeDate As String = DGOvertime.Rows(e.RowIndex).Cells("Attendance Date").Value.ToString
                        Auditing($"{LblName.Text} declined {name}'s overtime dated {overtimeDate}.", "Others")
                        ClassDepartmentHeadControls.LoadOvertime(DGOvertime)
                    End If

                End If
            End If
        Catch ex As Exception
        MsgBox(ex.Message)
        Exit Sub
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ClassDepartmentHeadControls.LoadAttendance(DGAttendance)
        ClassDepartmentHeadControls.RefreshOvertime(DGOvertime)
        ClassDepartmentHeadControls.RefreshFTIO(DGFiledFTIO)
        ClassDepartmentHeadControls.RefreshLeave(DGFiledLeave)
        ClassDepartmentHeadControls.LoadPersonalOvertime(DGOTShowing)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim currentDate As String = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
        Dim currentTime As String = DateTime.Now.ToString("h:mm:ss tt")
        Dim currentDateTime As String = currentTime
        DisplayDate.Text = currentDate
        DisplayTime.Text = currentDateTime
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox("Logout Success")
            Auditing($"{departmentHeadName} has logged out.", "Attendance")
            FrmLogin.Show()
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub FrmDepartmentHeadControls_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ClassLogin.SetToLoggedOutEmployees(ClassDepartmentHeadControls.departmentID)
    End Sub

    Private Sub BtnFTIOSave_Click(sender As Object, e As EventArgs) Handles BtnFTIOSave.Click
        Dim today As Date = Date.Now()

        If CBFTIOType.SelectedIndex = -1 Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(mtbTime.Text, timePattern) Then
            MessageBox.Show("Invalid time format.")
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtFTIOReason.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtFTIOReason.Text, singleSpace) Then
            MessageBox.Show("Invalid FTIO reason.")
            Exit Sub
        ElseIf DTPFTIODate.Value.Day >= today.Day Then
            MessageBox.Show("Date must start yesterday.")
            Exit Sub
        End If
        ClassDepartmentHeadControls.FileFTIO(DTPFTIODate, CBFTIOType, TxtFTIOReason, mtbTime)
        ClassDepartmentHeadControls.LoadMyFiledFTIO(DGFTIOFiled)
    End Sub

    Private Sub BtnLeaveSave_Click(sender As Object, e As EventArgs) Handles BtnLeaveSave.Click
        If CBLeaveType.SelectedIndex = -1 Then
            MsgEmptyField()
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtLeaveReason.text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtLeaveReason.Text, singleSpace) Then
            MessageBox.Show("Invalid Leave Reason.")
            Exit Sub
        End If

        If CBLeaveType.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a type of leave.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedTypeOfLeave As String = CBLeaveType.Text.ToString()
        Dim remaining As Integer

        For Each row As DataGridViewRow In DGLeaveCount.Rows
            If row.Cells("manageTypeofLeave").Value IsNot Nothing AndAlso row.Cells("manageTypeofLeave").Value.ToString() = selectedTypeOfLeave Then
                If Integer.TryParse(row.Cells("manageRemainingLeave").Value.ToString(), remaining) Then
                Else
                    MessageBox.Show("Invalid remaining leave value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim startDate As Date = DTPLeaveFrom.Value.Date
                Dim endDate As Date = DTPLeaveTo.Value.Date

                If endDate < startDate Then
                    MessageBox.Show("End date cannot be earlier than start date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Dim difference As Integer = (endDate - startDate).Days + 1
                If difference > remaining Then
                    MessageBox.Show("Insufficient leave credits.")
                    Exit Sub
                End If

                Exit For
            End If
        Next

        If remaining = -1 Then
            MessageBox.Show("Leave type not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ClassDepartmentHeadControls.FileLeave(DTPLeaveFrom, DTPLeaveTo, CBLeaveType, TxtLeaveReason)
        ClassDepartmentHeadControls.LeaveCount(DGLeaveCount)
        ClassDepartmentHeadControls.LoadFiledLeave(DGFiledLeave)
        ClassDepartmentHeadControls.LoadMyFiledLeave(DGLeaveFiled)
    End Sub
    Private Sub TPSalaryAndPayslip_Enter(sender As Object, e As EventArgs) Handles TPSalaryAndPayslip.Enter
        ClassDepartmentHeadControls.LoadSalaryAndPaySlip(DGSalaryAndPaySlip)
    End Sub

    Private Sub DGSalaryAndPaySlip_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSalaryAndPaySlip.CellContentClick
        Try
            ' Check if the clicked cell is in the button column
            If e.ColumnIndex = DGSalaryAndPaySlip.Columns("btnViewAndPrint").Index AndAlso e.RowIndex >= 0 Then
                Dim payrollID As String = DGSalaryAndPaySlip.Rows(e.RowIndex).Cells("colPayrollPeriodID").Value.ToString()
                dt = New DataTable("DT_Department")
                dt.Clear()

                adp = New MySqlDataAdapter("Select CONCAT(pp.datefrom,' to ',pp.dateto) as payrollperiod, e.employeeNumber, CONCAT(e.firstname,' ',e.lastname) as name,
                                        p.overtime,p.allowance,p.incentives,p.nightdifferential,p.late,p.undertime,p.voluntary,p.sss,p.philhealth,p.pagibig,p.tax,p.totalincrease,
                                        p.totaldeduc,p.grosspay, (p.totalincrease + p.grosspay) as totalearning, p.netpay from tblpayrollperiod pp
                                        LEFT JOIN tblpayroll p on p.payrollperiodID = pp.payrollperiodID
                                        LEFT JOIn tblemployee e on e.employeeID = p.employeeID
                                        WHERE p.payrollID = '" & payrollID & "'", conn)
                adp.Fill(dt)


                Dim crystal As New CRPaySlip
                crystal.SetDataSource(dt)
                FrmPrinting.CRVPrinting.ReportSource = crystal
                FrmPrinting.Show()
                FrmMain.Enabled = False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
End Class
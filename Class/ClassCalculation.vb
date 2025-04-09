Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class ClassCalculation
    #Region "Variables"
    Shared noofdays As Integer = 0
    Shared NightDiffRate As Decimal = 0
    Shared OtRegularRate As Decimal = 0
    Shared OtSpecialRate As Decimal = 0
    Shared RestDayRate As Decimal = 0
    Shared SpecialHolidayRate As Decimal = 0
    Shared RegularHolidayRate As Decimal = 0
    Shared DoubleHolidayRate As Decimal = 0

    Shared compensationtype As String
    Shared employmentstatus As String
    Shared payrollperiodID As Integer
    Shared isPayout As String

    Shared dateto As String
    Shared datefrom As String

    Public Shared hasschedule As Boolean


    Shared employeeID As Integer
#End Region
#Region "Payroll Period Controls not included on the calculation"
    Public Shared Sub NewPayrollPeriod(payrollperiodname As Guna2TextBox, dtpfrom As Guna2DateTimePicker, dtpto As Guna2DateTimePicker, rb As RadioButton)
        Try
            RunCommand("Insert into tblpayrollperiod (payrollperiodname,datefrom,dateto,payout,released) VALUES (@payrollperiodname,@datefrom,@dateto,@payout,'Not Released')")
            With com
                .Parameters.AddWithValue("@payrollperiodname", payrollperiodname.Text.Trim)
                .Parameters.AddWithValue("@datefrom", dtpfrom.Value.Date)
                .Parameters.AddWithValue("@dateto", dtpto.Value.Date)
                .Parameters.AddWithValue("@payout", If(rb.Checked = True, "Yes", "No"))
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With
            MsgBox("Saved", MsgBoxStyle.OkOnly)
            payrollperiodname.Clear()
            dtpfrom.Value = Now.Date
            dtpto.Value = Now.Date
            rb.Checked = True
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Shared Sub LoadPayrollPeriod(dg As DataGridView)
        Try
            Dim role As String = FrmMain.LblPos.Text.Trim
            RunQuery("Select * from tblpayrollperiod")
            If ds.Tables("querytable").Rows.Count > 0 Then
                dg.DataSource = ds.Tables("querytable")
                If role = "Admin" Then
                    ' Check if the button column already exists to avoid duplication
                    If dg.Columns("btnRelease") Is Nothing Then
                        ' Add a new button column
                        Dim btnColumn As New DataGridViewButtonColumn()
                        btnColumn.Name = "btnRelease"
                        btnColumn.HeaderText = "Action"
                        btnColumn.Text = "Release"
                        btnColumn.UseColumnTextForButtonValue = True
                        dg.Columns.Add(btnColumn)
                    End If

                    If dg.Columns("btnPrintTotal") Is Nothing Then
                        Dim btnColumn As New DataGridViewButtonColumn()
                        btnColumn.Name = "btnPrintTotal"
                        btnColumn.HeaderText = "Print Payroll Summary"
                        btnColumn.Text = "Print"
                        btnColumn.UseColumnTextForButtonValue = True
                        dg.Columns.Add(btnColumn)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub LoadPayrollPeriodCB(cb As Guna2ComboBox)
        Try
            RunQuery("Select * from tblpayrollperiod")
            cb.DataSource = ds.Tables("querytable")
            cb.ValueMember = "payrollperiodID"
            cb.DisplayMember = "payrollperiodname"
            cb.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub SelectEmployee(dg As Guna2DataGridView, lblname As Label, lbldept As Label, lblpos As Label)
        Try
            If dg.SelectedRows.Count > 0 Then
                employeeID = dg.SelectedRows(0).Cells(0).Value
                lblname.Text = $"Employee Name: {dg.SelectedRows(0).Cells(2).Value}"
                lbldept.Text = $"Department: {dg.SelectedRows(0).Cells(3).Value}"
                lblpos.Text = $"Position: {dg.SelectedRows(0).Cells(4).Value}"
                FrmPayroll.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub RefreshPayrollPeriodCB(cb As Guna2ComboBox)
        Try
            Dim itemcount As Integer = cb.Items.Count
            RunQuery("Select * from tblpayrollperiod")
            Dim rowcount As Integer = ds.Tables("querytable").Rows.Count

            If itemcount <> rowcount Then
                LoadPayrollPeriodCB(cb)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub SelectPayrollPeriod(cb As Guna2ComboBox, txtfrom As Guna2TextBox, txtto As Guna2TextBox, txtpayout As Guna2TextBox)
        Try
            If cb.SelectedIndex = -1 Then
                txtfrom.Clear()
                txtto.Clear()
                txtpayout.Clear()
                Exit Sub
            End If

            Dim payrollperiodID As Integer = cb.SelectedValue
            RunQuery("Select * from tblpayrollperiod where payrollperiodID = '" & payrollperiodID & "'")
            txtfrom.Text = Format(ds.Tables("querytable").Rows(0)(2), "yyyy-MM-dd")
            txtto.Text = Format(ds.Tables("querytable").Rows(0)(3), "yyyy-MM-dd")
            txtpayout.Text = ds.Tables("querytable").Rows(0)(4)
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub UsePayrollPeriod(cb As Guna2ComboBox, txtpayrollperiod As Guna2TextBox, txtfrom As Guna2TextBox, txtto As Guna2TextBox, txtpayout As Guna2TextBox)
        Try
            If cb.SelectedIndex = -1 Then
                Exit Sub
            End If
            payrollperiodID = cb.SelectedValue
            txtpayrollperiod.Text = cb.Text
            isPayout = txtpayout.Text
            datefrom = txtfrom.Text
            dateto = txtto.Text
            MsgBox(payrollperiodID)

        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub EmployeeStatus()
        Try
            RunQuery("Select status from tblemployee where employeeID = '" & employeeID & "'")
            If ds.Tables("querytable").Rows.Count > 0 Then
                employmentstatus = ds.Tables("querytable").Rows(0)(0)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Sub EmployeeCompensationType()
        Try
            RunQuery("Select type from tblsalary where employeeID = '" & employeeID & "'")
            If ds.Tables("querytable").Rows.Count > 0 Then
                compensationtype = ds.Tables("querytable").Rows(0)(0)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Sub GetRates()
        Try
            RunQuery("Select rate from tblrates")
            If ds.Tables("querytable").Rows.Count > 0 Then
                NightDiffRate = If(IsDBNull(ds.Tables("querytable").Rows(0)(0)), 0, ds.Tables("querytable").Rows(0)(0) / 100)
                OtRegularRate = If(IsDBNull(ds.Tables("querytable").Rows(1)(0)), 0, ds.Tables("querytable").Rows(1)(0) / 100)
                OtSpecialRate = If(IsDBNull(ds.Tables("querytable").Rows(2)(0)), 0, ds.Tables("querytable").Rows(2)(0) / 100)
                RestDayRate = If(IsDBNull(ds.Tables("querytable").Rows(3)(0)), 0, ds.Tables("querytable").Rows(3)(0) / 100)
                SpecialHolidayRate = If(IsDBNull(ds.Tables("querytable").Rows(4)(0)), 0, ds.Tables("querytable").Rows(4)(0) / 100)
                RegularHolidayRate = If(IsDBNull(ds.Tables("querytable").Rows(5)(0)), 0, ds.Tables("querytable").Rows(5)(0) / 100)
                DoubleHolidayRate = If(IsDBNull(ds.Tables("querytable").Rows(6)(0)), 0, ds.Tables("querytable").Rows(6)(0) / 100)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub GetDailyWage(lbldaily As Label)
        Try
            RunQuery("Select coalesce(daily,0) as daily from tblsalary where employeeID = '" & employeeID & "'")
            lbldaily.Text = $"Daily Wage: {ds.Tables("querytable").Rows(0)(0)}"
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Shared Sub LoadEmployees(dgv As Guna2DataGridView)
        Try
            RunQuery("SELECT e.employeeID,e.employeeNumber, CONCAT(e.firstname, ' ', e.lastname) AS fullname, d.departmentName, po.positionName
                      FROM tblemployee e
                      LEFT JOIN tbldepartment d on d.departmentID = e.departmentID
                      LEFT JOIN tblposition po on po.positionID = e.positionID
                      WHERE e.status <> 'Resigned' and e.employeeID NOT IN (
                      SELECT p.employeeID
                      FROM tblpayroll p
                      WHERE p.payrollperiodID = '" & payrollperiodID & "')")
            If ds.Tables.Contains("querytable") AndAlso ds.Tables("querytable").Rows.Count > 0 Then
                dgv.DataSource = ds.Tables("querytable")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub LoadIncentive(dg As Guna2DataGridView)
        Try
            RunQuery("Select incentiveID, incentiveName from tblincentives where status='Active'")
            If isPayout = "Yes" Then
                dg.DataSource = ds.Tables("querytable")
            Else
                ds.Tables("querytable").Rows.Clear()
                dg.DataSource = ds.Tables("querytable")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub LoadAllowance(txt As Guna2TextBox)
        Try
            If employeeID = 0 Then
                Exit Sub
            End If
            RunQuery("Select * from tblempallowance where employeeID = '" & employeeID & "'")
            If ds.Tables("querytable").Rows.Count > 0 Then
                txt.Text = ds.Tables("querytable").Rows(0)("allowance")
            Else
                txt.Text = "0"
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub LoadVoluntary(dg As Guna2DataGridView)
        Try
            RunQuery("Select a.voluntaryID, b.name, a.amount from tblempvoluntary a
                      LEFT JOIN tblvoluntary b on b.voluntaryID = a.voluntaryID
                      WHERE a.employeeID='" & employeeID & "' and a.amount <> '0.00'")
            If isPayout = "Yes" Then
                dg.DataSource = ds.Tables("querytable")
            Else
                ds.Tables("querytable").Rows.Clear()
                dg.DataSource = ds.Tables("querytable")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub LoadAttendance(dg As Guna2DataGridView)
        Try
            If employeeID = 0 Then
                Exit Sub
            End If

            RunQuery("WITH RECURSIVE date_range AS (
                SELECT '" & datefrom & "' AS date
                UNION
                SELECT DATE_ADD(date, INTERVAL 1 DAY)
                FROM date_range
                WHERE date < '" & dateto & "'
                )
                SELECT DISTINCT
                dr.date,
                dayname(dr.date) as dayname,
                att.login,
                att.logout,

                CASE
                    WHEN att.logout > CONCAT(dr.date, ' ', ts.timeout)
                    THEN FLOOR(TIME_TO_SEC(TIMEDIFF(att.logout, CONCAT(dr.date, ' ', ts.timeout))) / 3600)
                    ELSE 0
                END AS overtime,

                ot.remarks as otremark,

                CASE
                    WHEN att.login > CONCAT(dr.date, ' ', ts.timein)
                    THEN FLOOR(TIME_TO_SEC(TIMEDIFF(att.login, CONCAT(dr.date, ' ', ts.timein))) / 60)
                    ELSE 0
                END AS late,

                CASE
                    WHEN att.logout < CONCAT(dr.date, ' ', ts.timeout)
                    THEN FLOOR(TIME_TO_SEC(TIMEDIFF(CONCAT(dr.date, ' ', ts.timeout), att.logout)) / 60)
                    ELSE 0
                END AS undertime,

                CASE
                    WHEN att.logout >= CONCAT(dr.date, ' ', '23:00:00') 
                    THEN FLOOR(TIME_TO_SEC(TIMEDIFF(att.logout, CONCAT(dr.date, ' ', '22:00:00'))) / 3600)
                    ELSE 0
                END AS nightdifferential,

                IF(att.report IS NULL, 'Absent', att.report) AS report,

                IF(h.classification IS NULL, 'No Holiday', h.classification) AS classification,

                sc.remark AS dayremark

                FROM date_range dr
                LEFT JOIN tblattendance att ON att.date = dr.date AND att.employeeID = '" & employeeID & "'
                LEFT JOIN tbltimeschedule ts ON ts.employeeID = att.employeeID
                LEFT JOIN tblschedule sc ON sc.employeeID = '" & employeeID & "' AND sc.day = DAYNAME(dr.date)
                LEFT JOIN tblholiday h ON h.date = dr.date
                LEFT JOIN tblovertime ot on ot.attendanceID = att.attendanceID
                ORDER BY dr.date ASC;
                ")
            If ds.Tables("querytable").Rows.Count > 0 Then
                dg.DataSource = ds.Tables("querytable")
            Else

            End If

            hasschedule = True
            RunQuery("Select * from tbltimeschedule WHERE employeeID = '" & employeeID & "'")
            If ds.Tables("querytable").Rows.Count = 0 Then
                'MsgBox("No schedule set to the employee yet")
                hasschedule = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
End Class

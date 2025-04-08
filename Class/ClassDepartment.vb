Imports Guna.UI2.WinForms
Public Class ClassDepartment

    Public Shared Sub LoadDepartmentDG(dg As Guna2DataGridView)
        Try
            RunQuery("SELECT 
                     a.departmentID, 
                     a.departmentName, 
                     CONCAT(c.firstname, ' ', c.lastname) AS departmentHead,
                     (SELECT COUNT(*) 
                     FROM tblemployee e 
                     WHERE e.departmentID = a.departmentID and e.status != 'Resigned') AS departmentPopulation,
                     a.status 
                     FROM 
                     tbldepartment a
                     LEFT JOIN 
                     tbldepartmenthead b ON b.departmentID = a.departmentID
                     LEFT JOIN 
                     tblemployee c ON c.employeeID = b.employeeID
                     WHERE a.status != 'Resigned'
                     GROUP BY 
                     a.departmentID, a.departmentName, departmentHead, a.status")
            dg.DataSource = ds.Tables("querytable")
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub LoadDepartmentHead(cb As Guna2ComboBox, cbdep As Guna2ComboBox)
        Try
            Dim deptid As Integer = cbdep.SelectedValue
            RunQuery("Select a.employeeID, CONCAT(a.firstname,' ',a.lastname) as fullname from tblemployee a 
                      where status ='Regular' and departmentID = '" & deptid & "'")
            cb.DisplayMember = "fullname"
            cb.ValueMember = "employeeID"
            cb.DataSource = ds.Tables("querytable")
            cb.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub LoadDepartment(cb As Guna2ComboBox)
        Try
            RunQuery("Select * from tbldepartment where status='Active'")
            cb.ValueMember = "departmentID"
            cb.DisplayMember = "departmentName"
            cb.DataSource = ds.Tables("querytable")
            cb.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub SaveDepartmentHead(dg As Guna2DataGridView)
        Try
            Dim deptID As Integer = FrmDepartmentControls.CbDepartment.SelectedValue
            Dim empID As Integer = FrmDepartmentControls.CbDepartmentHead.SelectedValue

            RunQuery("Select * from tblposition WHERE departmentID = '" & deptID & "' and positionName = 'Department Head'")
            Dim posID As Integer = ds.Tables("querytable").Rows(0)(0)


            RunCommand("Update tblemployee SET positionID = '0' WHERE positionID = '" & posID & "'")
            With com
                .ExecuteNonQuery()
            End With

            RunCommand("Insert into tbldepartmenthead (departmentID,employeeID) VALUES (@departmentID,@employeeID)
                        ON DUPLICATE KEY UPDATE employeeID=@employeeID")
            With com
                .Parameters.AddWithValue("@departmentID", deptID)
                .Parameters.AddWithValue("@employeeID", empID)
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With

            RunCommand("Update tblemployee SET departmentID=@departmentID,positionID=@posID WHERE employeeID=@empID")
            With com
                .Parameters.AddWithValue("@departmentID", deptID)
                .Parameters.AddWithValue("@posID", posID)
                .Parameters.AddWithValue("@empID", empID)
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With

            MsgBox("Saved", MsgBoxStyle.OkOnly)
            FrmDepartmentControls.TCDepartment.SelectedTab = FrmDepartmentControls.TPDepartmentList
            LoadDepartmentDG(dg)
            Auditing($"{FrmMain.LblName.Text} set {FrmDepartmentControls.CbDepartmentHead.Text} as Department Head in {FrmDepartmentControls.CbDepartment.Text}", "Others")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub LoadOvertime(dg As Guna2DataGridView)
        Try
            RunQuery("SELECT 
                  a.attendanceID AS 'Attendance ID',
                  a.employeeID AS 'Employee ID',
                  CONCAT(b.firstname,' ', b.lastname) AS 'Full Name',
                  a.date AS 'Attendance Date',
                  a.login AS 'Login',
                  a.logout AS 'Logout',
                  CASE
                  WHEN a.logout > CONCAT(a.date, ' ', c.timeout)
                  THEN FLOOR(TIME_TO_SEC(TIMEDIFF(a.logout, CONCAT(a.date, ' ', c.timeout))) / 3600)
                  ELSE 0
                  END AS 'Overtime'
                  FROM tblattendance a
                  LEFT JOIN tblemployee b ON b.employeeID = a.employeeID
                  LEFT JOIN tbltimeschedule c ON c.employeeID = a.employeeID
                  WHERE
                  a.attendanceID NOT IN (SELECT attendanceID FROM tblovertime)
                  AND a.employeeID IN (SELECT employeeID FROM tbldepartmenthead)
                  GROUP BY a.attendanceID, b.firstname, b.lastname, a.date, a.login, a.logout, c.timeout
                  HAVING FLOOR(TIME_TO_SEC(TIMEDIFF(a.logout, CONCAT(a.date, ' ', c.timeout))) / 3600) > 0
                  ORDER BY a.attendanceID")

            If ds.Tables("querytable").Rows.Count > 0 Then
                ' Bind the data to the DataGridView
                dg.DataSource = ds.Tables("querytable")

                ' Add Approve button column
                If dg.Columns("Approve") Is Nothing Then
                    Dim approveButtonColumn As New DataGridViewButtonColumn()
                    approveButtonColumn.Name = "Approve"
                    approveButtonColumn.Text = "Approve"
                    approveButtonColumn.UseColumnTextForButtonValue = True ' Display the text on the button
                    dg.Columns.Add(approveButtonColumn)
                End If

                ' Add Decline button column
                If dg.Columns("Decline") Is Nothing Then
                    Dim declineButtonColumn As New DataGridViewButtonColumn()
                    declineButtonColumn.Name = "Decline"
                    declineButtonColumn.Text = "Decline"
                    declineButtonColumn.UseColumnTextForButtonValue = True ' Display the text on the button
                    dg.Columns.Add(declineButtonColumn)
                End If

            End If
        Catch ex As Exception
            ' Handle the error
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Shared Sub LoadFiledFTIO(dg As Guna2DataGridView)
        Try
            RunQuery("Select a.ftioID 'FTIO ID', concat(b.firstname,' ',b.lastname) 'Full Name',a.date 'Date',a.time 'Time',a.classification 'Classification', a.reason 'Reason',a.status 'Status'
            From tblfiledftio a
                      join tblemployee b on b.employeeID = a.employeeID
                      where a.status='Pending' and a.employeeID in (Select employeeID from tbldepartmenthead)")
            If ds.Tables("querytable").Rows.Count > 0 Then
                ' Bind the data to the DataGridView
                dg.DataSource = ds.Tables("querytable")

                ' Add Approve button column
                If dg.Columns("Approve") Is Nothing Then
                    Dim approveButtonColumn As New DataGridViewButtonColumn()
                    approveButtonColumn.Name = "Approve"
                    approveButtonColumn.Text = "Approve"
                    approveButtonColumn.UseColumnTextForButtonValue = True ' Display the text on the button
                    dg.Columns.Add(approveButtonColumn)

                End If

                ' Add Decline button column
                If dg.Columns("Decline") Is Nothing Then
                    Dim declineButtonColumn As New DataGridViewButtonColumn()
                    declineButtonColumn.Name = "Decline"
                    declineButtonColumn.Text = "Decline"
                    declineButtonColumn.UseColumnTextForButtonValue = True ' Display the text on the button
                    dg.Columns.Add(declineButtonColumn)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub LoadFiledLeave(dg As Guna2DataGridView)
        Try
            dg.Rows.Clear()
            RunQuery("select a.filedleaveID 'Filed Leave ID', CONCAT(b.firstname,' ',b.lastname) 'Full Name', a.leavefrom 'From',a.leaveto 'To',c.leaveType 'Type',a.leavereason 'Reason' from tblfiledleave a
                      join tblemployee b on b.employeeID = a.employeeID
                      join tblleave c on c.leaveID = a.leaveID
                      where a.status = 'Pending' and a.employeeID in (Select employeeID from tbldepartmenthead)")

            If ds.Tables("querytable").Rows.Count > 0 Then
                ' Bind the data to the DataGridView
                dg.DataSource = ds.Tables("querytable")

                ' Add Approve button column
                If dg.Columns("Approve") Is Nothing Then
                    Dim approveButtonColumn As New DataGridViewButtonColumn()
                    approveButtonColumn.Name = "Approve"
                    approveButtonColumn.Text = "Approve"
                    approveButtonColumn.UseColumnTextForButtonValue = True ' Display the text on the button
                    dg.Columns.Add(approveButtonColumn)
                End If


                ' Add Decline button column
                If dg.Columns("Decline") Is Nothing Then
                    Dim declineButtonColumn As New DataGridViewButtonColumn()
                    declineButtonColumn.Name = "Decline"
                    declineButtonColumn.Text = "Decline"
                    declineButtonColumn.UseColumnTextForButtonValue = True ' Display the text on the button
                    dg.Columns.Add(declineButtonColumn)
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub DeclineFTIO(ftioID As Integer)
        Try
            RunCommand("Update tblfiledftio SET status='Decline' where ftioID = '" & ftioID & "'")
            With com
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With
            MsgBox("FTIO declined", MsgBoxStyle.OkOnly)
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub ApproveFTIO(ftioId As Integer)
        Try
            RunCommand("Update tblfiledftio SET status='Approve' where ftioID = '" & ftioId & "'")
            With com
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With

            RunQuery("Select employeeID, date, time, classification from tblfiledftio WHERE ftioID = '" & ftioId & "'")
            If ds.Tables("querytable").Rows.Count > 0 Then
                Dim ftioemployeeID As Integer = ds.Tables("querytable").Rows(0)(0)
                Dim ftiodate As Date = Convert.ToDateTime(ds.Tables("querytable").Rows(0)(1))
                Dim timestring As TimeSpan = TimeSpan.Parse(ds.Tables("querytable").Rows(0)(2).ToString())
                Dim ftiotime As String = timestring.ToString("hh\:mm\:ss")
                Dim ftioFinal As String = ftiodate.ToString("yyyy-MM-dd") & " " & ftiotime
                Dim classification As String = ds.Tables("querytable").Rows(0)(3).ToString()

                If classification = "Login" Then
                    RunCommand("INSERT INTO tblattendance (employeeID, date, login, report) 
                    VALUES (@employeeID, @date, @login, 'Present')
                    ON DUPLICATE KEY UPDATE login = @login")
                    With com
                        .Parameters.AddWithValue("@login", ftioFinal)
                        .Parameters.AddWithValue("@employeeID", ftioemployeeID)
                        .Parameters.AddWithValue("@date", ftiodate)
                        .ExecuteNonQuery()
                        .Parameters.Clear()
                    End With
                ElseIf classification = "Logout" Then
                    RunCommand("INSERT INTO tblattendance (employeeID, date, logout, report) 
                    VALUES (@employeeID, @date, @logout, 'Present')
                    ON DUPLICATE KEY UPDATE logout = @logout")
                    With com
                        .Parameters.AddWithValue("@logout", ftioFinal)
                        .Parameters.AddWithValue("@employeeID", ftioemployeeID)
                        .Parameters.AddWithValue("@date", ftiodate)
                        .ExecuteNonQuery()
                        .Parameters.Clear()
                    End With
                End If
            End If
            MsgBox("FTIO Approved", MsgBoxStyle.OkOnly)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub ApproveOvertime(employeeID As Integer, attendanceID As Integer, dg As Guna2DataGridView)
        Try
            RunCommand("Insert into tblovertime (employeeID,attendanceID,remarks) VALUES (@employeeID,@attendanceID,@remarks)")
            With com
                .Parameters.AddWithValue("@employeeID", employeeID)
                .Parameters.AddWithValue("@attendanceID", attendanceID)
                .Parameters.AddWithValue("@remarks", "Approved")
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With

            MsgBox("Overtime Approved", MsgBoxStyle.OkOnly)
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub DeclineOvertime(employeeID As Integer, attendanceID As Integer, dg As Guna2DataGridView)
        Try
            RunCommand("Insert into tblovertime (employeeID,attendanceID,remarks) VALUES (@employeeID,@attendanceID,@remarks)")
            With com
                .Parameters.AddWithValue("@employeeID", employeeID)
                .Parameters.AddWithValue("@attendanceID", attendanceID)
                .Parameters.AddWithValue("@remarks", "Declined")
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With
            MsgBox("Overtime Declined", MsgBoxStyle.OkOnly)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub ApproveLeave(leaveid As Integer)
        Try
            RunQuery("Select employeeID,leavefrom,leaveto from tblfiledleave where filedleaveID = '" & leaveid & "'")
            Dim leaveemployeeID As Integer = ds.Tables("querytable").Rows(0)(0)
            Dim leavefrom As Date = Date.Parse(ds.Tables("querytable").Rows(0)(1))
            Dim leaveto As Date = Date.Parse(ds.Tables("querytable").Rows(0)(2))

            Dim currentdate As Date = leavefrom
            While currentdate <= leaveto

                Dim formattedcurrentdate As String = currentdate.ToString("yyyy-MM-dd")

                RunQuery("Select * from tblattendance where employeeID = '" & leaveemployeeID & "' and date = '" & formattedcurrentdate & "'")
                If ds.Tables("querytable").Rows.Count > 0 Then

                    RunCommand("Update tblfiledleave SET status='Declined' where filedleaveID = '" & leaveid & "'")
                    With com
                        .ExecuteNonQuery()
                        .Parameters.Clear()
                    End With



                    MsgBox("Date: " & currentdate & " already has attendance recorded. Leave request denied")
                    currentdate = currentdate.AddDays(1)
                    Continue While
                End If

                RunCommand("Insert into tblattendance (employeeID,date,report) VALUES (@employeeID,@date,'On Leave')")
                With com
                    .Parameters.AddWithValue("@employeeID", leaveemployeeID)
                    .Parameters.AddWithValue("@date", currentdate)
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                    currentdate = currentdate.AddDays(1)
                End With

                RunCommand("Update tblfiledleave SET status='Approve' where filedleaveID = '" & leaveid & "'")
                With com
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                End With
                MsgBox("Leave Approved", MsgBoxStyle.OkOnly)

            End While

        Catch ex As Exception

        End Try


    End Sub
    Public Shared Sub DeclineLeave(leaveid As Integer)
        Try
            RunCommand("Update tblfiledleave SET status='Decline' where filedleaveID = '" & leaveid & "'")
            With com
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With
            MsgBox("Leave declined", MsgBoxStyle.OkOnly)
        Catch ex As Exception

        End Try
    End Sub
End Class

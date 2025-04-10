Public Class FrmDepartmentControls
    Private Sub TPDepartmentList_Enter(sender As Object, e As EventArgs) Handles TPDepartmentList.Enter
        ClassDepartment.LoadDepartmentDG(DGDepartment)
    End Sub
    Private Sub FrmDepartmentControls_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenServerConnection()
        ClassDepartment.LoadDepartmentDG(DGDepartment)
    End Sub
    Private Sub TPDepartmentProfile_Enter(sender As Object, e As EventArgs) Handles TPDepartmentProfile.Enter
        ClassDepartment.LoadDepartment(CbDepartment)
        ClassDepartment.LoadDepartmentHead(CbDepartmentHead, CbDepartment)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CbDepartment.SelectedIndex = -1 Then
            MsgEmptyField()
            Exit Sub
        ElseIf CbDepartmentHead.SelectedIndex = -1 Then
            MsgEmptyField()
            Exit Sub
        End If
        ClassDepartment.SaveDepartmentHead(DGDepartment)
        ClassEmployee.LoadEmployee(FrmEmployee.DgEmployee)
    End Sub

    Private Sub CbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDepartment.SelectedIndexChanged
        Try
            If CbDepartment.SelectedIndex = -1 Then
                Exit Sub
            End If
            ClassDepartment.LoadDepartmentHead(CbDepartmentHead, CbDepartment)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub TPFTIOFiling_Enter(sender As Object, e As EventArgs) Handles TPFTIOFiling.Enter
        ClassDepartment.LoadFiledFTIO(DGFiledFTIO)
    End Sub

    Private Sub TPLeaveFiling_Enter(sender As Object, e As EventArgs) Handles TPLeaveFiling.Enter
        ClassDepartment.LoadFiledLeave(DGFiledLeave)
    End Sub

    Private Sub DGFiledLeave_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFiledLeave.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = DGFiledLeave.Columns("Approve").Index Then
                    ' Get the Filed Leave ID of the selected row
                    Dim filedLeaveID As Integer = Convert.ToInt32(DGFiledLeave.Rows(e.RowIndex).Cells("Filed Leave ID").Value)

                    If MsgBox("Are you sure you want to approve the leave filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartment.ApproveLeave(filedLeaveID)
                        Dim name As String = DGFiledLeave.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim leaveFrom As String = DGFiledLeave.Rows(e.RowIndex).Cells("From").Value.ToString
                        Dim leaveTo As String = DGFiledLeave.Rows(e.RowIndex).Cells("To").Value.ToString
                        Auditing($"{FrmMain.fullName} approved {name}'s leave from {leaveFrom} to {leaveTo}", "Others")
                        ClassDepartment.LoadFiledLeave(DGFiledLeave)
                    End If

                ElseIf e.ColumnIndex = DGFiledLeave.Columns("Decline").Index Then
                    ' Get the Filed Leave ID of the selected row
                    Dim filedLeaveID As Integer = Convert.ToInt32(DGFiledLeave.Rows(e.RowIndex).Cells("Filed Leave ID").Value)
                    If MsgBox("Are you sure you want to decline the leave filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartment.DeclineLeave(filedLeaveID)
                        Dim name As String = DGFiledLeave.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim leaveFrom As String = DGFiledLeave.Rows(e.RowIndex).Cells("From").Value.ToString
                        Dim leaveTo As String = DGFiledLeave.Rows(e.RowIndex).Cells("To").Value.ToString
                        Auditing($"{FrmMain.fullName} declined {name}'s leave from {leaveFrom} to {leaveTo}.", "Others")
                        ClassDepartment.LoadFiledLeave(DGFiledLeave)
                    End If

                End If
            End If

        Catch ex As Exception
        MsgBox(ex.Message)
        Exit Sub
        End Try
    End Sub

    Private Sub DGFiledFTIO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFiledFTIO.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = DGFiledFTIO.Columns("Approve").Index Then
                    ' Get the Filed FTIO ID of the selected row
                    Dim FTIOID As Integer = Convert.ToInt32(DGFiledFTIO.Rows(e.RowIndex).Cells("FTIO ID").Value)

                    If MsgBox("Are you sure you want to approve the FTIO filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartment.ApproveFTIO(FTIOID)
                        Dim name As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim ftioDate As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Date").Value.ToString
                        Dim ftioTime As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Time").Value.ToString
                        Auditing($"{FrmMain.fullName} approved {name}'s filed FTIO dated {ftioDate} {ftioTime}.", "Others")
                        ClassDepartment.LoadFiledFTIO(DGFiledFTIO)
                    End If

                ElseIf e.ColumnIndex = DGFiledFTIO.Columns("Decline").Index Then
                    ' Get the Filed FTIO ID of the selected row
                    Dim FTIOID As Integer = Convert.ToInt32(DGFiledFTIO.Rows(e.RowIndex).Cells("FTIO ID").Value)
                    If MsgBox("Are you sure you want to decline the FTIO filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartment.DeclineFTIO(FTIOID)
                        Dim name As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim ftioDate As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Date").Value.ToString
                        Dim ftioTime As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Time").Value.ToString
                        Auditing($"{FrmMain.fullName} declined {name}'s filed FTIO dated {ftioDate} {ftioTime}.", "Others")
                        ClassDepartment.LoadFiledFTIO(DGFiledFTIO)

                    End If

                End If
            End If

        Catch ex As Exception
        MsgBox(ex.Message)
        Exit Sub
        End Try
    End Sub

    Private Sub TCDepartment_Enter(sender As Object, e As EventArgs) Handles TCDepartment.Enter
        ClassDepartment.LoadOvertime(DGOvertime)
    End Sub

    Private Sub DGOvertime_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOvertime.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = DGOvertime.Columns("Approve").Index Then
                    ' Get the Filed FTIO ID of the selected row
                    Dim employeeID As Integer = Convert.ToInt32(DGOvertime.Rows(e.RowIndex).Cells("EmployeeID").Value)
                    Dim attendanceID As Integer = Convert.ToInt32(DGOvertime.Rows(e.RowIndex).Cells("AttendanceID").Value)


                    If MsgBox("Are you sure you want to approve the Overtime filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartment.ApproveOvertime(employeeID, attendanceID, DGOvertime)
                        ClassDepartment.LoadOvertime(DGOvertime)
                        Dim name As String = DGOvertime.Rows(e.RowIndex).Cells("FullName").Value.ToString
                        'Auditing($"{LblName.Text} approved {name}'s overtime.")
                    End If

                ElseIf e.ColumnIndex = DGOvertime.Columns("Decline").Index Then
                    ' Get the Filed FTIO ID of the selected row
                    Dim employeeID As Integer = Convert.ToInt32(DGOvertime.Rows(e.RowIndex).Cells("EmployeeID").Value)
                    Dim attendanceID As Integer = Convert.ToInt32(DGOvertime.Rows(e.RowIndex).Cells("AttendanceID").Value)
                    If MsgBox("Are you sure you want to decline the Overtime filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartment.DeclineOvertime(employeeID, attendanceID, DGOvertime)
                        ClassDepartment.LoadOvertime(DGOvertime)
                        Dim name As String = DGOvertime.Rows(e.RowIndex).Cells("FullName").Value.ToString
                        'Auditing($"{LblName.Text} declined {name}'s overtime.")
                    End If

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim fileleaverowcount As Integer = DGFiledLeave.Rows.Count
            RunQuery("select a.filedleaveID 'Filed Leave ID', CONCAT(b.firstname,' ',b.lastname) 'Full Name', a.leavefrom 'From',a.leaveto 'To',c.leaveType 'Type',a.leavereason 'Reason' from tblfiledleave a
                      join tblemployee b on b.employeeID = a.employeeID
                      join tblleave c on c.leaveID = a.leaveID
                      where a.status = 'Pending' and a.employeeID in (Select employeeID from tbldepartmenthead)")
            If ds.Tables("querytable").Rows.Count > 0 Then
                Dim fileleave As Integer = ds.Tables("querytable").Rows.Count
                If fileleaverowcount <> fileleave Then
                    ClassDepartment.LoadFiledLeave(DGFiledLeave)
                End If

            End If


            Dim otrowcount As Integer = DGOvertime.Rows.Count
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
                Dim otcount As Integer = ds.Tables("querytable").Rows.Count
                If otcount <> otrowcount Then
                    ClassDepartment.LoadOvertime(DGOvertime)
                End If
            End If


            Dim ftiorowcount As Integer = DGFiledFTIO.Rows.Count
            RunQuery("Select a.ftioID 'FTIO ID', concat(b.firstname,' ',b.lastname) 'Full Name',a.date 'Date',a.time 'Time',a.classification 'Classification', a.reason 'Reason',a.status 'Status'
            From tblfiledftio a
                      join tblemployee b on b.employeeID = a.employeeID
                      where a.status='Pending' and a.employeeID in (Select employeeID from tbldepartmenthead)")
            If ds.Tables("querytable").Rows.Count > 0 Then
                Dim ftiocount As Integer = ds.Tables("querytable").Rows.Count
                If ftiorowcount <> ftiocount Then
                    ClassDepartment.LoadFiledFTIO(DGFiledFTIO)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
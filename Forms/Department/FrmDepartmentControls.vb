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
                If e.ColumnIndex = DGFIledleave.Columns("Approve").Index Then
                    ' Get the Filed Leave ID of the selected row
                    Dim filedLeaveID As Integer = Convert.ToInt32(DGFiledLeave.Rows(e.RowIndex).Cells("Filed Leave ID").Value)

                    If MsgBox("Are you sure you want to approve the leave filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartment.ApproveLeave(filedLeaveID)
                        Dim name As String = DGFiledLeave.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim leaveFrom As String = DGFiledLeave.Rows(e.RowIndex).Cells("leavefrom").Value.ToString
                        Dim leaveTo As String = DGFiledLeave.Rows(e.RowIndex).Cells("leaveTo").Value.ToString
                        Auditing($"{FrmMain.fullName} approved {name}'s leave from {leaveFrom} to {leaveTo}", "Others")
                        DGFiledLeave.Rows.RemoveAt(e.RowIndex)
                    End If

                ElseIf e.ColumnIndex = DGFiledLeave.Columns("Decline").Index Then
                    ' Get the Filed Leave ID of the selected row
                    Dim filedLeaveID As Integer = Convert.ToInt32(DGFiledLeave.Rows(e.RowIndex).Cells("Filed Leave ID").Value)
                    If MsgBox("Are you sure you want to decline the leave filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartment.DeclineLeave(filedLeaveID)
                        Dim name As String = DGFiledLeave.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim leaveFrom As String = DGFiledLeave.Rows(e.RowIndex).Cells("leavefrom").Value.ToString
                        Dim leaveTo As String = DGFiledLeave.Rows(e.RowIndex).Cells("leaveTo").Value.ToString
                        Auditing($"{FrmMain.fullName} declined {name}'s leave from {leaveFrom} to {leaveTo}.", "Others")
                        DGFiledLeave.Rows.RemoveAt(e.RowIndex)
                    End If

                End If
            End If

        Catch ex As Exception

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
                        DGFiledFTIO.Rows.RemoveAt(e.RowIndex)
                    End If

                ElseIf e.ColumnIndex = DGFiledFTIO.Columns("Decline").Index Then
                    ' Get the Filed FTIO ID of the selected row
                    Dim FTIOID As Integer = Convert.ToInt32(DGFiledFTIO.Rows(e.RowIndex).Cells("FTIO ID").Value)
                    If MsgBox("Are you sure you want to decline the FTIO filed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ClassDepartment.DeclineLeave(FTIOID)
                        Dim name As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Full Name").Value.ToString
                        Dim ftioDate As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Date").Value.ToString
                        Dim ftioTime As String = DGFiledFTIO.Rows(e.RowIndex).Cells("Time").Value.ToString
                        Auditing($"{FrmMain.fullName} declined {name}'s filed FTIO dated {ftioDate} {ftioTime}.", "Others")
                        DGFiledFTIO.Rows.RemoveAt(e.RowIndex)
                    End If

                End If
            End If

        Catch ex As Exception

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
End Class
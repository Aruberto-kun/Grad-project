Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports System.Text.RegularExpressions

Public Class FrmEmployee
    Private Sub FrmEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenServerConnection()
        ClassEmployee.LoadDepartment(FrmAddEmployee.CbDepartment)
        ClassEmployee.LoadEmployee(DgEmployee)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ClassEmployee.RefreshDepartment(FrmAddEmployee.CbDepartment)
        ClassEmployee.RefreshVoluntary(FrmAddEmployee.DGVoluntary)
    End Sub

    Private Sub DGVoluntary_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        MessageBox.Show("Invalid amount.")
    End Sub
    Public Shared Sub GetDailyWageOfMonthlyEmployees(id As Integer)
        Try
            Dim selectedemployeeID As Integer = id
            RunQuery("Select salary,type from tblsalary where employeeID = '" & selectedemployeeID & "'")
            Dim salary As Decimal = ds.Tables("querytable").Rows(0)(0)
            Dim type As String = ds.Tables("querytable").Rows(0)(1)



            RunQuery("Select * from tblschedule where employeeID='" & id & "'")
            If ds.Tables("querytable").Rows.Count > 0 Then
                If type = "Monthly" Then
                    RunQuery("WITH RECURSIVE date_range AS (
                      SELECT CAST(CONCAT(YEAR(CURDATE()), '-01-01') AS DATE) AS date
                      UNION ALL
                      SELECT DATE_ADD(date, INTERVAL 1 DAY)
                      FROM date_range
                      WHERE date < CAST(CONCAT(YEAR(CURDATE()), '-12-31') AS DATE)
                      )
                      SELECT COUNT(dr.date) 
                      FROM date_range dr
                      JOIN tblschedule sched ON sched.day = DAYNAME(dr.date)
                      LEFT JOIN tblholiday hol ON hol.date = dr.date
                      WHERE sched.employeeID = '" & selectedemployeeID & "'
                      AND sched.remark = 'With Duty'
                      AND hol.date IS NULL;")
                    Dim numberofdays As Integer = ds.Tables("querytable").Rows(0)(0)
                    Dim dailywage As Decimal = (salary * 12) / numberofdays


                    RunCommand("Update tblsalary SET daily=@daily WHERE employeeID = '" & selectedemployeeID & "'")
                    With com
                        .Parameters.AddWithValue("@daily", dailywage)
                        .ExecuteNonQuery()
                        .Parameters.Clear()
                    End With
                ElseIf type = "Daily" Then
                    RunCommand("Update tblsalary SET daily=@daily WHERE employeeID = '" & selectedemployeeID & "'")
                    With com
                        .Parameters.AddWithValue("@daily", salary)
                        .ExecuteNonQuery()
                        .Parameters.Clear()
                    End With
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Dim selectedRow As DataGridViewRow = DGEmployee.SelectedRows(0)

            ' Retrieve the userID of the selected row (assuming userID is at index 0)
            Dim userID As Integer = selectedRow.Cells(0).Value

            If MsgBox("Are you sure you want to reset the password of this user?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                RunCommand("Update tblemployee set password=NULL where employeeID = '" & userID & "'")
                With com
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                    MsgBox("Password reset")
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgEmployee_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgEmployee.CellDoubleClick
        ClassEmployee.SelectEmployee(DgEmployee, FrmAddEmployee.TxtRfidNumber, FrmAddEmployee.TxtFirstName, FrmAddEmployee.TxtLastname, FrmAddEmployee.CbDepartment, FrmAddEmployee.CbPosition, FrmAddEmployee.TxtSalary, FrmAddEmployee.CbCompensationType, FrmAddEmployee.CbAssociateStatus)
    End Sub

    Private Sub DgEmployee_MouseDown(sender As Object, e As MouseEventArgs) Handles DgEmployee.MouseDown
        Try
            ' Check if the right mouse button is clicked
            If e.Button = MouseButtons.Right Then
                ' Check if any row is selected
                If DgEmployee.SelectedRows.Count > 0 Then
                    ' Show the ContextMenuStrip at the mouse click location
                    ContextMenuStrip1.Show(DgEmployee, e.Location)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAddAssociate_Click(sender As Object, e As EventArgs) Handles BtnAddAssociate.Click
        FrmAddEmployee.Show()
        FrmAddEmployee.BringToFront()
        Me.Enabled = False
    End Sub

    Private Sub DgEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgEmployee.CellClick

        ' Check if the clicked cell is the button column
        If e.ColumnIndex = DgEmployee.Columns("btnViewSalaryHistory").Index AndAlso e.RowIndex >= 0 Then
            ' Get the employeeID of the selected row
            ClassEmployee.employeeID = CInt(DgEmployee.Rows(e.RowIndex).Cells("Column1").Value)
            ClassEmployee.ViewSalaryHistory(FrmSalaryHistory.DGSalaryHistory)
        End If
    End Sub
End Class
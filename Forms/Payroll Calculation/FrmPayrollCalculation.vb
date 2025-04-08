Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class FrmPayrollCalculation


    Private Sub FrmPayrollCalculation_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenServerConnection()
        ClassPayrollCalculation.GetRates()
        ClassPayrollCalculation.LoadPayrollPeriod(DGPayrollPeriod)
        RBYes.Checked = True

        ' Add this in the Form Designer
        Dim contextMenu As New ContextMenuStrip()
        Dim deleteMenuItem As New ToolStripMenuItem("Delete")

        ' Add the delete menu item to the context menu
        contextMenu.Items.Add(deleteMenuItem)
        DGPayrollPeriod.ContextMenuStrip = contextMenu

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            'max 17 days and min 14 days
            If String.IsNullOrEmpty(TxtPayrollPeriodName.Text) Then
                MsgEmptyField()
                Exit Sub
            End If

            Dim startDate As Date = DTPFrom.Value.Date
            Dim endDate As Date = DTPTo.Value.Date

            If endDate < startDate Then
                MessageBox.Show("The end date cannot be earlier than start date.")
                Exit Sub
            End If

            Dim difference As Integer = (endDate - startDate).Days + 1

            If difference < 14 OrElse difference > 17 Then
                MessageBox.Show("Invalid payroll period.")
                Exit Sub
            End If
            '
            ClassPayrollCalculation.NewPayrollPeriod(TxtPayrollPeriodName, DTPFrom, DTPTo, RBYes)
            ClassPayrollCalculation.LoadPayrollPeriod(DGPayrollPeriod)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgPayrollPeriod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPayrollPeriod.CellContentClick
        Try
            If FrmMain.LblPos.Text.Trim = "Admin" Then
                ' Check if the clicked cell is in the button column
                If e.ColumnIndex = DGPayrollPeriod.Columns("btnRelease").Index AndAlso e.RowIndex >= 0 Then
                    Dim payrollperiodID As String = DGPayrollPeriod.Rows(e.RowIndex).Cells("colPayrollPeriodID").Value.ToString()
                    Dim isreleased As String = DGPayrollPeriod.Rows(e.RowIndex).Cells("colReleased").Value.ToString

                    If isreleased = "Released" Then
                        MsgBox("Pay Slip already released")
                        Exit Sub
                    End If

                    If MsgBox("Are you sure you want to release the Pay Slip?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        RunCommand("Update tblpayrollperiod SET released='Released' WHERE payrollperiodID = '" & payrollperiodID & "'")
                        With com
                            .ExecuteNonQuery()
                        End With
                        MsgBox("Pay Slip for the selected period is now released")
                        ClassPayrollCalculation.LoadPayrollPeriod(DGPayrollPeriod)
                    End If
                End If

                If e.ColumnIndex = DGPayrollPeriod.Columns("btnPrintTotal").Index AndAlso e.RowIndex >= 0 Then
                    Dim payrollperiodID As String = DGPayrollPeriod.Rows(e.RowIndex).Cells("colPayrollPeriodID").Value.ToString()
                    Dim isreleased As String = DGPayrollPeriod.Rows(e.RowIndex).Cells("colReleased").Value.ToString
                    If isreleased <> "Released" Then
                        MsgBox("Payroll period not yet released.")
                        Exit Sub
                    End If

                    dt = New DataTable("DT_PayrollSummary")
                    dt.Clear()
                    adp = New MySqlDataAdapter("SELECT 
                                                p.payrollperiodID,
                                                pp.payrollperiodname,
                                                pp.datefrom,
                                                pp.dateto,
                                                pp.payout,
                                                e.employeeNumber,
                                                CONCAT(e.firstname, ' ', e.lastname) AS fullname,
                                                d.departmentName,
                                                pos.positionName,
                                                p.netpay,
                                                SUM(p.netpay) OVER () AS total
                                                FROM tblpayroll p
                                                JOIN tblpayrollperiod pp ON p.payrollperiodID = pp.payrollperiodID
                                                JOIN tblemployee e ON p.employeeID = e.employeeID
                                                JOIN tbldepartment d ON e.departmentID = d.departmentID
                                                LEFT JOIN tblposition pos ON e.positionID = pos.positionID
                                                WHERE p.payrollperiodID = '" & payrollperiodID & "'
                                                ORDER BY e.employeeNumber;
                                                ", conn)
                    adp.Fill(dt)

                    Dim crystal As New CRPayrollTotal
                    crystal.SetDataSource(dt)
                    FrmPrinting.CRVPrinting.ReportSource = crystal
                    FrmPrinting.ShowDialog()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        FrmPayrollPeriod.ShowDialog()
    End Sub

    Private Sub DGVEmployeeList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEmployeeList.CellDoubleClick
        ClassPayrollCalculation.SelectEmployee(DGVEmployeeList, FrmPayroll.Label1, FrmPayroll.Label2, FrmPayroll.Label3)
    End Sub

    Private Sub DGPayrollPeriod_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGPayrollPeriod.CellMouseClick
        If e.Button = MouseButtons.Right Then
            If e.RowIndex >= 0 Then
                DGPayrollPeriod.ClearSelection()
                DGPayrollPeriod.Rows(e.RowIndex).Selected = True
            End If
        End If
    End Sub

    Private Sub deleteMenuItem_Click(sender As Object, e As EventArgs) Handles deleteMenuItem.Click
        Dim selectedRowIndex As Integer = DGPayrollPeriod.SelectedCells(0).RowIndex
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo)

        If confirm = DialogResult.Yes Then
            Dim payrollPeriodID As Integer = DGPayrollPeriod.Rows(selectedRowIndex).Cells("ColPayrollPeriodID").Value
            DGPayrollPeriod.Rows.RemoveAt(selectedRowIndex)
            DeletePeriod(payrollPeriodID)
            ClassPayrollCalculation.LoadPayrollPeriod(DGPayrollPeriod)
        End If
    End Sub



End Class
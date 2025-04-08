Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Module MdlMaintenance

    ReadOnly connection As MySqlConnection = conn

#Region "User"

    Public Sub NewUser(firstName As String, lastName As String, userName As String)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblUsers (firstName, lastName, userName, role, status) VALUES (@firstName, @lastName, @userName, 'Payroll Staff', 'Active')", connection)
            command.Parameters.AddWithValue("@firstName", firstName)
            command.Parameters.AddWithValue("@lastName", lastName)
            command.Parameters.AddWithValue("@userName", userName)
            command.ExecuteNonQuery()
            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("User name already exist.", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End Try
    End Sub

    Public Function DisplayUsers() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT userID, CONCAT(firstname, ' ', lastname) AS fullName, IF (logged = 'Yes', 'Logged in', 'Logged off') AS logged FROM tblUsers WHERE status LIKE 'Active' AND role NOT LIKE 'Admin' AND role NOT LIKE 'Attendance'", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

#End Region

#Region "Department"

    Public departmentID As Integer = 0

    Public Sub NewDepartment(department As String)
        Try
            Dim checkCommand As New MySqlCommand("SELECT departmentID FROM tblDepartment WHERE departmentName = @departmentName AND status = 'Inactive'", connection)
            checkCommand.Parameters.AddWithValue("@departmentName", department)
            Dim reader As MySqlDataReader = checkCommand.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim existingDepartmentID As Integer = reader("departmentID")
                reader.Close()

                Dim commandID As New MySqlCommand("UPDATE tblDepartment SET status = 'Active' WHERE departmentID = @departmentID", connection)
                commandID.Parameters.AddWithValue("@departmentID", existingDepartmentID)
                commandID.ExecuteNonQuery()

                Dim updatePos As New MySqlCommand("UPDATE tblPosition SET status = 'Active' WHERE departmentID = @departmentID", connection)
                updatePos.Parameters.AddWithValue("@departmentID", existingDepartmentID)
                updatePos.ExecuteNonQuery()

                MessageBox.Show("Department has been reactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                reader.Close()
                Dim command As New MySqlCommand("INSERT INTO tblDepartment (departmentName, status) VALUES (@departmentName, 'Active')", connection)
                command.Parameters.AddWithValue("@departmentName", department)
                command.ExecuteNonQuery()

                Dim getLastID As New MySqlCommand("SELECT LAST_INSERT_ID()", connection)
                Dim lastInsertedID As Integer = Convert.ToInt32(getLastID.ExecuteScalar())

                Dim addHeadDept As New MySqlCommand("INSERT INTO tblPosition (positionName, departmentID, status) VALUES ('Department Head', @departmentID, 'Active')", connection)
                addHeadDept.Parameters.AddWithValue("@departmentID", lastInsertedID)
                addHeadDept.ExecuteNonQuery()

                MessageBox.Show("Department added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As MySqlException
        If ex.Number = 1062 Then
            MessageBox.Show("Department already exist.", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show(ex.Message)
        End If
        End Try
    End Sub

    Public Function DisplayDepartment() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblDepartment WHERE status = 'Active'", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As MySqlException
            Return Nothing
        End Try
    End Function

    Public Sub SelectDepartment(dg As DataGridView)
        Try
            If dg.SelectedRows.Count > 0 Then
                departmentID = dg.SelectedRows(0).Cells(0).Value
                FrmDepartmentInfo.TxtDepartment.Text = dg.SelectedRows(0).Cells("departmentName").Value
                FrmDepartmentInfo.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub UpdateDepartment(departmentID As Integer, departmentName As String)
        Try
            Dim command As New MySqlCommand("UPDATE tblDepartment SET departmentName = @departmentName WHERE departmentID = @departmentID", connection)
            command.Parameters.AddWithValue("@departmentName", departmentName)
            command.Parameters.AddWithValue("@departmentID", departmentID)
            command.ExecuteNonQuery()
            MessageBox.Show("Department updated successfully.")
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Department name already exist.", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Public Sub DeleteDepartment(departmentID As Integer)
        Try
            Dim commandOne As New MySqlCommand("SELECT COUNT(*) FROM tblEmployee WHERE departmentID = @departmentID", connection)
            commandOne.Parameters.AddWithValue("@departmentID", departmentID)
            Dim count As Integer = Convert.ToInt32(commandOne.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Selected department cannot be deleted.", "Invalid deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                Dim command As New MySqlCommand("UPDATE tblDepartment SET status = 'Inactive' WHERE departmentID = @departmentID", connection)
                command.Parameters.AddWithValue("@departmentID", departmentID)
                command.ExecuteNonQuery()

                Dim commandPos As New MySqlCommand("UPDATE tblPosition SET status = 'Inactive' WHERE departmentID = @departmentID", connection)
                commandPos.Parameters.AddWithValue("@departmentID", departmentID)
                commandPos.ExecuteNonQuery()

                MessageBox.Show("Department deleted successfully.")
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "Position"

    Public positionID As Integer = 0

    Public Sub NewPosition(departmentID As Integer, positionName As String)
        Try
            Dim checkCommand As New MySqlCommand("SELECT positionID FROM tblPosition WHERE positionName = @positionName AND departmentID = @departmentID AND status = 'Inactive'", connection)
            checkCommand.Parameters.AddWithValue("@positionName", positionName)
            checkCommand.Parameters.AddWithValue("@departmentID", departmentID)

            Dim reader As MySqlDataReader = checkCommand.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim existingPositionID As Integer = reader("positionID")
                reader.Close()

                Dim commandID As New MySqlCommand("UPDATE tblPosition SET status = 'Active' WHERE positionID = @positionID", connection)
                commandID.Parameters.AddWithValue("@positionID", existingPositionID)
                commandID.ExecuteNonQuery()
                MessageBox.Show("Position has been reactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                reader.Close()
                Dim command As New MySqlCommand("INSERT INTO tblPosition (positionName, departmentID, status) VALUES (@positionName, @departmentID, 'Active')", connection)
                command.Parameters.AddWithValue("@positionName", positionName)
                command.Parameters.AddWithValue("@departmentID", departmentID)
                command.ExecuteNonQuery()
                MessageBox.Show("Position added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Position in this department already existed.", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Public Function DisplayPosition() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT p.positionID, p.positionName, d.departmentName, p.status FROM tblPosition p JOIN tblDepartment d ON p.departmentID = d.departmentID WHERE p.status = 'Active'", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As MySqlException
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub SelectPosition(dg As DataGridView)
        Try
            If dg.SelectedRows.Count > 0 Then
                positionID = dg.SelectedRows(0).Cells(0).Value
                FrmPositionInfo.TxtPosition.Text = dg.SelectedRows(0).Cells("positionName").Value
                If FrmPositionInfo.TxtPosition.Text = "Department Head" Then
                    FrmPositionInfo.BtnUpdate.Enabled = False
                    FrmPositionInfo.BtnDelete.Enabled = False
                Else
                    FrmPositionInfo.BtnDelete.Enabled = True
                    FrmPositionInfo.BtnUpdate.Enabled = True
                End If
                FrmPositionInfo.TxtDepartment.Text = dg.SelectedRows(0).Cells("departmentPosition").Value
                FrmPositionInfo.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdatePosition(positionID As Integer, positionName As String)
        Try
            Dim command As New MySqlCommand("UPDATE tblPosition SET positionName = @positionName WHERE positionID = @positionID", connection)
            command.Parameters.AddWithValue("@positionName", positionName)
            command.Parameters.AddWithValue("@positionID", positionID)
            command.ExecuteNonQuery()
            MessageBox.Show("Position updated successfully.")
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Position already exist.", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Public Sub DeletePosition(positionID As Integer)
        Try
            Dim commandOne As New MySqlCommand("SELECT COUNT(*) FROM tblEmployee WHERE positionID = @positionID", connection)
            commandOne.Parameters.AddWithValue("@positionID", positionID)
            Dim count As Integer = Convert.ToInt32(commandOne.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Selected position cannot be deleted.", "Invalid deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                Dim command As New MySqlCommand("UPDATE tblPosition SET status = 'Inactive' WHERE positionID = @positionID", connection)
                command.Parameters.AddWithValue("@positionID", positionID)
                command.ExecuteNonQuery()
                MessageBox.Show("Position deleted successfully.")
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "Leave"

    Public leaveID As Integer = 0

    Public Sub NewLeave(leaveType As String)
        Try
            Dim checkCommand As New MySqlCommand("SELECT leaveID FROM tblLeave WHERE leaveType = @leaveType AND status = 'Inactive'", connection)
            checkCommand.Parameters.AddWithValue("@leaveType", leaveType)
            Dim reader As MySqlDataReader = checkCommand.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim existingLeaveID As Integer = reader("leaveID")
                reader.Close()

                Dim commandID As New MySqlCommand("UPDATE tblLeave SET status = 'Active' WHERE leaveID = @leaveID", connection)
                commandID.Parameters.AddWithValue("@leaveID", existingLeaveID)
                commandID.ExecuteNonQuery()
                MessageBox.Show("Leave has been reactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                reader.Close()
                Dim command As New MySqlCommand("INSERT INTO tblLeave (leaveType, status) VALUES (@leaveType, 'Active')", connection)
                command.Parameters.AddWithValue("@leaveType", leaveType)
                command.ExecuteNonQuery()
                MessageBox.Show("Leave added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Type of leave already exist.", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Public Function DisplayLeave() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblLeave WHERE status = 'Active'", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As mysqlException
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub SelectLeave(dg As DataGridView)
        Try
            If dg.SelectedRows.Count > 0 Then
                leaveID = dg.SelectedRows(0).Cells(0).Value
                FrmLeaveInfo.TxtLeave.Text = dg.SelectedRows(0).Cells("leaveName").Value
                FrmLeaveInfo.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateLeave(leaveID As Integer, leaveName As String)
        Try
            Dim command As New MySqlCommand("UPDATE tblLeave SET leaveType = @leaveName WHERE leaveID = @leaveID", connection)
            command.Parameters.AddWithValue("@leaveName", leaveName)
            command.Parameters.AddWithValue("@leaveID", leaveID)
            command.ExecuteNonQuery()
            MessageBox.Show("Leave updated successfully.")
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Type of leave already exist.", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Public Sub DeleteLeave(leaveID As Integer)
        Try
            Dim command As New MySqlCommand("UPDATE tblLeave SET status = 'Inactive' WHERE leaveID = @leaveID", connection)
            command.Parameters.AddWithValue("@leaveID", leaveID)
            command.ExecuteNonQuery()
            MessageBox.Show("Leave deleted successfully.")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Incentives"

    Public incentiveID As Integer = 0

    Public Sub NewIncentives(incentiveName As String)
        Try
            Dim checkCommand As New MySqlCommand("SELECT incentiveID FROM tblIncentives WHERE incentiveName = @incentiveName AND status = 'Inactive'", connection)
            checkCommand.Parameters.AddWithValue("@incentiveName", incentiveName)
            Dim reader As MySqlDataReader = checkCommand.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim existingIncentiveID As Integer = reader("incentiveID")
                reader.Close()

                Dim commandID As New MySqlCommand("UPDATE tblIncentives SET status = 'Active' WHERE incentiveID = @incentiveID", connection)
                commandID.Parameters.AddWithValue("@incentiveID", existingIncentiveID)
                commandID.ExecuteNonQuery()
                MessageBox.Show("Incentive has been reactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                reader.Close()
                Dim command As New MySqlCommand("INSERT INTO tblIncentives (incentiveName, status) VALUES (@incentiveName, 'Active')", connection)
                command.Parameters.AddWithValue("@incentiveName", incentiveName)
                command.ExecuteNonQuery()
                MessageBox.Show("Incentive added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Type of incentive already exist.", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show(ex.Message)
            End If
        End Try
    End Sub

    Public Function DisplayIncentive() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblIncentives WHERE status = 'Active'", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub SelectIncentives(dg As DataGridView)
        Try
            If dg.SelectedRows.Count > 0 Then
                incentiveID = dg.SelectedRows(0).Cells(0).Value
                FrmIncentiveInfo.TxtIncentiveName.Text = dg.SelectedRows(0).Cells("incentiveName").Value
                FrmIncentiveInfo.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateIncentive(incentiveID As Integer, incentiveName As String)
        Try
            Dim command As New MySqlCommand("UPDATE tblIncentives SET incentiveName = @incentiveName WHERE incentiveID = @incentiveID", connection)
            command.Parameters.AddWithValue("@incentiveName", incentiveName)
            command.Parameters.AddWithValue("@incentiveID", incentiveID)
            command.ExecuteNonQuery()
            MessageBox.Show("Incentive updated successfully.")
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Type of incentive already exist.", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Public Sub DeleteIncentive(incentiveID As Integer)
        Try
            Dim command As New MySqlCommand("UPDATE tblIncentives SET status = 'Inactive' WHERE incentiveID = @departmentID", connection)
            command.Parameters.AddWithValue("@departmentID", incentiveID)
            command.ExecuteNonQuery()
            MessageBox.Show("Incentive deleted successfully.")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Holiday"

    Public holidayID As Integer = 0

    Public Sub NewHoliday(holidayDate As Date, holidayName As String, classification As String)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblHoliday (date, classification, holidayName) VALUES (@date, @classification, @holidayName)", connection)
            command.Parameters.AddWithValue("@date", holidayDate)
            command.Parameters.AddWithValue("@classification", classification)
            command.Parameters.AddWithValue("@holidayName", holidayName)
            command.ExecuteNonQuery()
            MessageBox.Show("Holiday added successfully.")
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Holiday already exist.", "Duplicate entry.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Public Function DisplayHoliday() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblHoliday", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub Selectholiday(dg As DataGridView)
        Try
            If dg.SelectedRows.Count > 0 Then
                holidayID = dg.SelectedRows(0).Cells(0).Value
                FrmHoliday.TxtHolidayName.Text = dg.SelectedRows(0).Cells("holidayName").Value
                FrmHoliday.CbClassification.Text = dg.SelectedRows(0).Cells("classification").Value
                FrmHoliday.DtHoliday.Value = dg.SelectedRows(0).Cells("holidayDate").Value
                FrmHoliday.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateHoliday(holidayID As Integer, holidayDate As Date, holidayName As String, classification As String)
        Try
            Dim command As New MySqlCommand("UPDATE tblHoliday SET date = @holidayDate, holidayName = @holidayName, classification = @classification WHERE holidayID = @holidayID", connection)
            command.Parameters.AddWithValue("@holidayID", holidayID)
            command.Parameters.AddWithValue("@holidayDate", holidayDate)
            command.Parameters.AddWithValue("@holidayName", holidayName)
            command.Parameters.AddWithValue("@classification", classification)
            command.ExecuteNonQuery()
            MessageBox.Show("Holiday updated successfully.")
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Holiday already exist.", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Public Sub DeleteHoliday(holidayID As Integer)
        Try
            Dim command As New MySqlCommand("DELETE FROM tblHoliday WHERE holidayID = @holidayID", connection)
            command.Parameters.AddWithValue("@holidayID", holidayID)
            command.ExecuteNonQuery()
            MessageBox.Show("Holiday deleted successfully.")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "Rates"


    Public rateID As Integer = 0
    Public Sub UpdateRate(rate As Integer, rateID As Integer)
        Try
            Dim command As New MySqlCommand("UPDATE tblRates SET rate = @rate WHERE ratesID = @rateID", connection)
            command.Parameters.AddWithValue("@rate", rate)
            command.Parameters.AddWithValue("@rateID", rateID)
            command.ExecuteNonQuery()
            MessageBox.Show("Rate updated successfully.")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DisplayRates() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblRates", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub SelectRates(dg As DataGridView)
        Try
            If dg.SelectedRows.Count > 0 Then
                rateID = dg.SelectedRows(0).Cells(0).Value
                FrmRateInfo.TxtRateClassification.Text = dg.SelectedRows(0).Cells("rateClassification").Value
                FrmRateInfo.TxtRates.Text = dg.SelectedRows(0).Cells("rate").Value
                FrmRateInfo.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Contributions"

#Region "Tax"

    Public Function GetMaxSalary(cb As Guna2ComboBox) As Decimal
        Try
            Dim maxsal As Decimal
            If cb.Text = "Daily" Then
                RunQuery("Select * from tblTaxDaily order by maxSalary DESC limit 1")
                maxsal = ds.Tables("querytable").Rows(0)(2) + 0.01
            Else
                RunQuery("Select * from tblTaxMonthly order by maxSalary DESC limit 1")
                maxsal = ds.Tables("querytable").Rows(0)(2) + 0.01
            End If
            Return maxsal

        Catch ex As MySqlException
            Return 0
        End Try
    End Function
#Region "INSERT AND UPDATE"

    Public Sub NewTaxDaily(minimumSalary As Decimal, maximumSalary As Decimal, fixedAmount As Decimal, percentage As Integer)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblTaxDaily (minSalary, maxSalary, fixedAmount, percentage) 
                                             VALUES (@minSalary, @maxSalary, @fixedAmount, @percentage)", connection)
            With command.Parameters
                .AddWithValue("@minSalary", minimumSalary)
                .AddWithValue("@maxSalary", maximumSalary)
                .AddWithValue("@fixedAmount", fixedAmount)
                .AddWithValue("@percentage", percentage)
            End With
            command.ExecuteNonQuery()
            MessageBox.Show("Tax added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub NewTaxMonthly(minimumSalary As Decimal, maximumSalary As Decimal, fixedAmount As Decimal, percentage As Integer)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblTaxMonthly (minSalary, maxSalary, fixedAmount, percentage) 
                                              VALUES (@minSalary, @maxSalary, @fixedAmount, @percentage)", connection)
            With command.Parameters
                .AddWithValue("@minSalary", minimumSalary)
                .AddWithValue("@maxSalary", maximumSalary)
                .AddWithValue("@fixedAmount", fixedAmount)
                .AddWithValue("@percentage", percentage)
            End With
            command.ExecuteNonQuery()
            MessageBox.Show("Tax added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub DeleteTaxDaily()
        Try
            Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblTaxDaily", connection)
            Dim count As Integer = checkCommand.ExecuteScalar()
            If count = 0 Then
                MessageBox.Show("This tax cannot deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim command As New MySqlCommand("DELETE FROM tblTaxDaily ORDER BY taxDailyID DESC LIMIT 1", connection)
            command.ExecuteNonQuery()
            MessageBox.Show("Tax deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub DeleteTaxMonthly()
        Try
            Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblTaxMonthly", connection)
            Dim count As Integer = checkCommand.ExecuteScalar()
            If count = 0 Then
                MessageBox.Show("This tax cannot deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim command As New MySqlCommand("DELETE FROM tblTaxMonthly ORDER BY taxMonthlyID DESC LIMIT 1", connection)
            command.ExecuteNonQuery()
            MessageBox.Show("Tax deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "READ"
    Public Function DisplayTaxDaily() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT minsalary, maxsalary, fixedamount, percentage FROM tblTaxDaily", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function DisplayTaxMonthly() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT minsalary, maxsalary, fixedamount, percentage FROM tblTaxMonthly", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

#End Region

#End Region

#Region "SSS"

#Region "INSERT AND UPDATE"
    Public Sub NewSSS(minSalary As Decimal, maxSalary As Decimal, EE As Decimal, er As Decimal)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblSSS (minSalary, maxSalary, ee, er) 
                                             VALUES (@minSalary, @maxSalary, @ee, @er)", connection)
            With command.Parameters
                .AddWithValue("@minSalary", minSalary)
                .AddWithValue("@maxSalary", maxSalary)
                .AddWithValue("@ee", EE)
                .AddWithValue("@er", er)
            End With

            command.ExecuteNonQuery()
            MessageBox.Show("SSS added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DeleteSSS()
        Try
            Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblSSS", connection)
            Dim count As Integer = checkCommand.ExecuteScalar()
            If count = 0 Then
                MessageBox.Show("This SSS cannot deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim command As New MySqlCommand("DELETE FROM tblSSS ORDER BY sssID DESC LIMIT 1", connection)
            command.ExecuteNonQuery()
            MessageBox.Show("SSS deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "READ"
    Public Function DisplaySSS() As DataTable
        Dim datatable As New DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblSSS", connection)
            Dim adapter As New MySqlDataAdapter(command)

            adapter.Fill(datatable)
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return datatable
    End Function

    Public Function SSSGetMaxSalary() As Decimal
        Try
            Dim max As Decimal = 0
            RunQuery("Select max(maxSalary) from tblsss")
            If ds.Tables("querytable").Rows.Count > 0 Then
                Dim result = ds.Tables("querytable").Rows(0)(0)
                If Not IsDBNull(result) Then
                    max = Convert.ToDecimal(result) + 0.01
                End If
            Else
                max = 0
            End If
            Return max
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return 0
        End Try
    End Function
#End Region

#End Region

#Region "PAG-IBIG"

    Public Function DisplayPagIbig() As DataTable
        Dim datatable As New DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblpagibig ORDER BY date DESC", connection)
            Dim adapter As New MySqlDataAdapter(command)

            adapter.Fill(datatable)
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return datatable
    End Function

    Public Sub NewPagibig(rate As Integer)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblpagibig (rate, date) VALUES (@rate, current_timestamp)", connection)
            With command.Parameters
                .AddWithValue("@rate", rate)
            End With

            command.ExecuteNonQuery()

            MessageBox.Show("New Pag-Ibig rate updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "PhilHealth"

    Public Function DisplayPhilhealth() As DataTable
        Dim datatable As New DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblPhilhealth ORDER BY date DESC", connection)
            Dim adapter As New MySqlDataAdapter(command)

            adapter.Fill(datatable)
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return datatable
    End Function

    Public Sub NewPhilhealth(rate As Integer)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblPhilHealth (rate, date) VALUES (@rate, NOW())", connection)
            command.Parameters.AddWithValue("@rate", rate)
            command.ExecuteNonQuery()
            MessageBox.Show("PhilHealth rate added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
#End Region

#Region "Voluntary"

    Public voluntaryID As Integer = 0

    Public Sub NewVoluntary(voluntaryName As String)
        Try
            Dim checkCommand As New MySqlCommand("SELECT voluntaryID FROM tblVoluntary WHERE name = @voluntaryName AND status = 'Inactive'", connection)
            checkCommand.Parameters.AddWithValue("@voluntaryName", voluntaryName)
            Dim reader As MySqlDataReader = checkCommand.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim existingVoluntaryID As Integer = reader("voluntaryID")
                reader.Close()

                Dim commandID As New MySqlCommand("UPDATE tblVoluntary SET status = 'Active' WHERE voluntaryID = @voluntaryID", connection)
                commandID.Parameters.AddWithValue("@voluntaryID", existingVoluntaryID)
                commandID.ExecuteNonQuery()
                MessageBox.Show("Voluntary has been reactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                reader.Close()
                Dim command As New MySqlCommand("INSERT INTO tblVoluntary (name, status) VALUES (@voluntaryName, 'Active')", connection)
                command.Parameters.AddWithValue("@voluntaryName", voluntaryName)
                command.ExecuteNonQuery()
                MessageBox.Show("Voluntary added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Type of voluntary already exist.", "Duplicate entry.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Public Function DisplayVoluntary() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblVoluntary WHERE status = 'Active'", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub SelectVoluntary(dg As DataGridView)
        Try
            If dg.SelectedRows.Count > 0 Then
                voluntaryID = dg.SelectedRows(0).Cells(0).Value
                FrmVoluntaryInfo.TxtVoluntary.Text = dg.SelectedRows(0).Cells("voluntaryName").Value
                FrmVoluntaryInfo.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateVoluntary(voluntaryID As Integer, voluntaryName As String)
        Try
            Dim command As New MySqlCommand("UPDATE tblVoluntary SET name = @voluntaryName WHERE voluntaryID = @voluntaryID", connection)
            command.Parameters.AddWithValue("@voluntaryID", voluntaryID)
            command.Parameters.AddWithValue("@voluntaryName", voluntaryName)
            command.ExecuteNonQuery()
            MessageBox.Show("Voluntary updated successfully.")
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Voluntary already exist.", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Public Sub DeleteVoluntary(voluntaryID As Integer)
        Try
            Dim command As New MySqlCommand("UPDATE tblVoluntary SET status = 'Inactive' WHERE voluntaryID = @voluntaryID", connection)
            command.Parameters.AddWithValue("@voluntaryID", voluntaryID)
            command.ExecuteNonQuery()
            MessageBox.Show("Update deleted successfully.")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "Employees"
    'Public Function SearchEmployees(search As String) As DataTable
    '    Dim query As String = "SELECT employeeNumber, rfidNumber, firstname, lastname FROM tblemployee"

    '    If Not String.IsNullOrEmpty(search) Then
    '        query += " WHERE employeeNumber LIKE @search OR rfidNumber LIKE @search OR firstname LIKE @search OR lastname LIKE @search"
    '    End If

    '    Dim command As New MySqlCommand(query, connection)

    '    If Not String.IsNullOrEmpty(search) Then
    '        command.Parameters.AddWithValue("@search", "%" & search & "%")
    '    End If
    '    Dim adapter As New MySqlDataAdapter(command)
    '    Dim datatable As New DataTable
    '    adapter.Fill(datatable)
    '    Return datatable
    'End Function
#End Region

#Region "Others"

    Public Sub Auditing(action As String, actionType As String)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblaudit (action, dateActed, actionType) VALUES (@action, NOW(), @actionType)", connection)
            command.Parameters.AddWithValue("@action", action)
            command.Parameters.AddWithValue("@actionType", actionType)
            command.ExecuteNonQuery()

            Dim dt As DataTable = DisplayAudit()
            FrmAudit.DgAudit.DataSource = dt
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DisplayAudit() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblaudit", connection)
            Dim dt As New DataTable
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(dt)
            Return dt
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public firstname As String = ""
    Public lastname As String = ""
    Public profileUsername As String = ""


    Public Sub GetInfo(username As String)
        Try
            Dim query As String = "SELECT userID, firstname, lastname, username FROM tblUsers WHERE username = @username"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", username)

            Dim adapter As New MySqlDataAdapter(command)
            Dim ds As New DataSet()

            adapter.Fill(ds, "tblUsers")

            If ds.Tables("tblUsers").Rows.Count > 0 Then
                Dim row As DataRow = ds.Tables("tblUsers").Rows(0)
                FrmAccountSettings.userID = row("userID")
                FrmAccountSettings.TxtFirstname.Text = row("firstname").ToString()
                FrmAccountSettings.TxtLastname.Text = row("lastname").ToString()
                FrmAccountSettings.TxtUsername.Text = row("username").ToString()
            Else
                MessageBox.Show("User not found.")
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateAdminPayroll(ID As Integer, firstname As String, lastname As String, username As String, password As String)
        Try
            Dim command As New MySqlCommand("UPDATE tblUsers SET firstname = @firstname, lastname = @lastname, username = @username, password = @password WHERE userID = @userID", connection)
            command.Parameters.AddWithValue("@firstname", firstname)
            command.Parameters.AddWithValue("@lastname", lastname)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)
            command.Parameters.AddWithValue("@userID", ID)
            command.ExecuteNonQuery()
            MessageBox.Show("Profile update successfully.")
            Auditing($"{FrmMain.fullName} updated their profile.", "Others")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function GetAuditID() As Integer
        Try
            Dim command As New MySqlCommand("SELECT auditID FROM tblAudit ORDER BY auditID DESC LIMIT 1", connection)
            Return command.ExecuteScalar()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub UpdateAudit(auditID As Integer, oldValue As String, newValue As String)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblAuditInfo (auditID, oldValue, newValue) VALUES (@auditID, @oldValue, @newValue)", connection)
            command.Parameters.AddWithValue("@auditID", auditID)
            command.Parameters.AddWithValue("@oldValue", oldValue)
            command.Parameters.AddWithValue("@newValue", newValue)
            command.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DisplayAuditInfo(auditID) As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblAuditInfo WHERE auditID = @auditID", connection)
            command.Parameters.AddWithValue("@auditID", auditID)
            Dim datatable As New DataTable
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(datatable)
            Return datatable
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub DeletePeriod(payrollID As Integer)
        Try
            Dim command As New MySqlCommand("DELETE FROM tblPayrollPeriod WHERE payrollPeriodID = @periodID", connection)
            command.Parameters.AddWithValue("@periodID", payrollID)
            command.ExecuteNonQuery()
            MessageBox.Show("Payroll period has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
End Module
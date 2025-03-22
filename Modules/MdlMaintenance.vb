Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms

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
            MessageBox.Show("User added successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DisplayUsers() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT userID, CONCAT(firstname, ' ', lastname) AS fullName, IF (logged = 'Yes', 'Logged in', 'Logged off') AS logged FROM tblUsers WHERE status LIKE 'Active'", connection)
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
            Dim command As New MySqlCommand("INSERT INTO tblDepartment (departmentName, status) VALUES (@departmentName, 'Active')", connection)
            command.Parameters.AddWithValue("@departmentName", department)
            command.ExecuteNonQuery()
            MessageBox.Show("Department added successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DisplayDepartment() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblDepartment WHERE status = 'Active'", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As Exception
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
        Dim command As New MySqlCommand("UPDATE tblDepartment SET departmentName = @departmentName WHERE departmentID = @departmentID", connection)
        command.Parameters.AddWithValue("@departmentName", departmentName)
        command.Parameters.AddWithValue("@departmentID", departmentID)
        command.ExecuteNonQuery()
        MessageBox.Show("Department updated successfully.")
    End Sub

    Public Sub DeleteDepartment(departmentID As Integer)
        Dim command As New MySqlCommand("UPDATE tblDepartment SET status = 'Inactive' WHERE departmentID = @departmentID", connection)
        command.Parameters.AddWithValue("@departmentID", departmentID)
        command.ExecuteNonQuery()
        MessageBox.Show("Department deleted successfully.")
    End Sub

#End Region

#Region "Position"

    Public Sub NewPosition(departmentID As Integer, positionName As String)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblPosition (departmentID, positionName, status) VALUES (@departmentID, @positionName, 'Active')", connection)
            command.Parameters.AddWithValue("@departmentID", departmentID)
            command.Parameters.AddWithValue("@positionName", positionName)
            command.ExecuteNonQuery()
            MessageBox.Show("Position added successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DisplayPosition() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT p.positionID, p.positionName, d.departmentName, p.status FROM tblPosition p JOIN tblDepartment d ON p.departmentID = d.departmentID", connection)
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

#Region "Leave"

    Public leaveID As Integer = 0

    Public Sub NewLeave(leaveType As String)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblLeave (leaveType, status) VALUES (@leaveType, 'Active')", connection)
            command.Parameters.AddWithValue("@leaveType", leaveType)
            command.ExecuteNonQuery()
            MessageBox.Show("Leave type added successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DisplayLeave() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblLeave WHERE status = 'Active'", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As Exception
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
        Dim command As New MySqlCommand("UPDATE tblLeave SET leaveType = @leaveName WHERE leaveID = @leaveID", connection)
        command.Parameters.AddWithValue("@leaveName", leaveName)
        command.Parameters.AddWithValue("@leaveID", leaveID)
        command.ExecuteNonQuery()
        MessageBox.Show("Leave updated successfully.")
    End Sub

    Public Sub DeleteLeave(leaveID As Integer)
        Dim command As New MySqlCommand("UPDATE tblLeave SET status = 'Inactive' WHERE leaveID = @leaveID", connection)
        command.Parameters.AddWithValue("@leaveID", leaveID)
        command.ExecuteNonQuery()
        MessageBox.Show("Leave deleted successfully.")
    End Sub
#End Region

#Region "Incentives"

    Public incentiveID As Integer = 0

    Public Sub NewIncentives(incentiveName As String)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblIncentives (incentiveName, status) VALUES (@incentiveName, 'Active')", connection)
            command.Parameters.AddWithValue("@incentiveName", incentiveName)
            command.ExecuteNonQuery()
            MessageBox.Show("Incentive added successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DisplayIncentive() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblIncentives WHERE status = 'Active'", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable
            adapter.Fill(datatable)
            Return datatable
        Catch ex As Exception
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
        Dim command As New MySqlCommand("UPDATE tblIncentives SET incentiveName = @incentiveName WHERE incentiveID = @incentiveID", connection)
        command.Parameters.AddWithValue("@incentiveName", incentiveName)
        command.Parameters.AddWithValue("@incentiveID", incentiveID)
        command.ExecuteNonQuery()
        MessageBox.Show("Incentive updated successfully.")
    End Sub

    Public Sub DeleteIncentive(incentiveID As Integer)
        Dim command As New MySqlCommand("UPDATE tblIncentives SET status = 'Inactive' WHERE incentiveID = @departmentID", connection)
        command.Parameters.AddWithValue("@departmentID", incentiveID)
        command.ExecuteNonQuery()
        MessageBox.Show("Incentive deleted successfully.")
    End Sub
#End Region

#Region "Holiday"

    Public Sub NewHoliday(holidayDate As Date, holidayName As String, classification As String)
        Try
            Dim command As New MySqlCommand("INSERT INTO tblHoliday (date, classification, holidayName) VALUES (@date, @classification, @holidayName)", connection)
            command.Parameters.AddWithValue("@date", holidayDate)
            command.Parameters.AddWithValue("@classification", classification)
            command.Parameters.AddWithValue("@holidayName", holidayName)
            command.ExecuteNonQuery()
            MessageBox.Show("Holiday added successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DisplayHoliday() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblHoliday", connection)
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

#Region "Rates"


    Public rateID As Integer = 0
    Public Sub UpdateRate(rate As Integer, rateID As Integer)
        Try
            Dim command As New MySqlCommand("UPDATE tblRates SET rate = @rate WHERE rateID = @rateID", connection)
            command.Parameters.AddWithValue("@rate", rate)
            command.Parameters.AddWithValue("@rateID", rateID)
            command.ExecuteNonQuery()
            MessageBox.Show("Rate updated successfully.")
        Catch ex As Exception
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
        Catch ex As Exception
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

        Catch ex As Exception
            Return 0
        End Try
    End Function
#Region "INSERT AND UPDATE"

    Public Sub NewTaxDaily(minimumSalary As Decimal, maximumSalary As Decimal, fixedAmount As Decimal, percentage As Integer)
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
    End Sub

    Public Sub NewTaxMonthly(minimumSalary As Decimal, maximumSalary As Decimal, fixedAmount As Decimal, percentage As Integer)
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
    End Sub

    Public Sub DeleteTaxDaily()
        Try
            Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblTaxDaily", connection)
            Dim count As Integer = checkCommand.ExecuteScalar()
            If count = 0 Then
                MessageBox.Show("This tax cannot deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim command As New MySqlCommand("DELETE FROM tblTaxDaily ORDER BY taxID DESC LIMIT 1", connection)
            command.ExecuteNonQuery()
            MessageBox.Show("Tax deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
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
            Dim command As New MySqlCommand("DELETE FROM tblTaxMonthly ORDER BY taxID DESC LIMIT 1", connection)
            command.ExecuteNonQuery()
            MessageBox.Show("Tax deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "READ"

    Public Function DisplayTaxDaily() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblTaxDaily", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

    Public Function DisplayTaxMonthly() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblTaxMonthly", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
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
        Catch ex As Exception
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
        Catch ex As Exception
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
            Dim command As New MySqlCommand("INSERT INTO tblVoluntary (name, status) VALUES (@voluntaryName, 'Active')", connection)
            command.Parameters.AddWithValue("@voluntaryName", voluntaryName)
            command.ExecuteNonQuery()
            MessageBox.Show("Voluntary added successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DisplayVoluntary() As DataTable
        Try
            Dim command As New MySqlCommand("SELECT * FROM tblVoluntary", connection)
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
End Module

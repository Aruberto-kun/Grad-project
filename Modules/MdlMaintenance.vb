Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms

Module MdlMaintenance

    ReadOnly connection As MySqlConnection = conn

#Region "User"

    Public Sub NewUser(firstName As String, lastName As String, userName As String)
        Dim command As New MySqlCommand("INSERT INTO tblUsers (firstName, lastName, userName, role, status) VALUES (@firstName, @lastName, @userName, 'Payroll Staff', 'Active')", connection)
        command.Parameters.AddWithValue("@firstName", firstName)
        command.Parameters.AddWithValue("@lastName", lastName)
        command.Parameters.AddWithValue("@userName", userName)
        command.ExecuteNonQuery()
        MessageBox.Show("User added successfully.")
    End Sub

    Public Function DisplayUsers() As DataTable
        Dim command As New MySqlCommand("SELECT userID, CONCAT(firstname, ' ', lastname) AS fullName, IF (logged = 'Yes', 'Logged in', 'Logged off') AS logged FROM tblUsers WHERE status LIKE 'Active'", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

#End Region

#Region "Department"

    Public Sub NewDepartment(department As String)
        Dim command As New MySqlCommand("INSERT INTO tblDepartment (departmentName, status) VALUES (@departmentName, 'Active')", connection)
        command.Parameters.AddWithValue("@departmentName", department)
        command.ExecuteNonQuery()
        MessageBox.Show("Department added successfully.")
    End Sub

    Public Function DisplayDepartment() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblDepartment", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
    End Function

#End Region

End Module

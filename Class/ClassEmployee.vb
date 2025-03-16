Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class ClassEmployee
    Public Shared employeeID As Integer
    Public Shared oldSalary As Integer

    Public Shared Sub LoadEmployee(dg As DataGridView)
        Try
            RunQuery("Select a.employeeID,a.employeeNumber,a.rfidnumber,CONCAT(a.firstname,' ',a.lastname) as fullname,a.firstname,a.lastname,b.departmentName,if(a.positionID=0,NULL,c.positionName) as positionName,d.salary,d.type,a.status from tblemployee a
                      LEFT JOIN tbldepartment b on b.departmentID = a.departmentID
                      LEFT JOIN tblposition c on c.positionID = a.positionID
                      LEFT JOIN tblsalary d on d.employeeID = a.employeeID
                      ORDER by a.employeeID")
            dg.DataSource = ds.Tables("querytable")

            ' Check if the button column already exists to avoid adding it multiple times
            If dg.Columns("btnViewSalaryHistory") Is Nothing Then
                ' Create a new DataGridViewButtonColumn
                Dim btnColumn As New DataGridViewButtonColumn()
                btnColumn.HeaderText = "" ' Blank header text
                btnColumn.Text = "View Salary History" ' Button text
                btnColumn.Name = "btnViewSalaryHistory" ' Name of the column
                btnColumn.UseColumnTextForButtonValue = True ' Use the same text for all buttons

                ' Add the button column to the DataGridView
                dg.Columns.Add(btnColumn)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub LoadVoluntary(dg As DataGridView)
        Try
            RunQuery("SELECT v.voluntaryID, v.name, COALESCE(ev.amount, 0) AS amount FROM tblvoluntary v LEFT JOIN tblempvoluntary ev ON v.voluntaryID = ev.voluntaryID AND ev.employeeID = '" & employeeID & "'")
            dg.DataSource = ds.Tables("querytable")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub LoadLeaveAllocation(dg As DataGridView)
        Try
            RunQuery("Select l.leaveID, l.leaveType, coalesce(el.days,0) as days from tblleave l left join tblemployeeleave el on l.leaveID = el.leaveID and el.employeeID = '" & employeeID & "'")
            dg.DataSource = ds.Tables("querytable")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub LoadDepartment(cb As Guna2ComboBox)
        Try
            RunQuery("Select * from tbldepartment where status = 'Active'")
            cb.ValueMember = "departmentID"
            cb.DisplayMember = "departmentName"
            cb.DataSource = ds.Tables("querytable")
            cb.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub RefreshDepartment(cb As Guna2ComboBox)
        Try
            RunQuery("Select * from tbldepartment where status='Active'")
            Dim count As Integer = ds.Tables("querytable").Rows.Count
            If cb.Items.Count < count Then
                LoadDepartment(cb)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub RefreshVoluntary(dg As DataGridView)
        Try
            RunQuery("select * from tblvoluntary where status = 'Active'")
            Dim count As Integer = ds.Tables("querytable").Rows.Count
            If dg.Rows.Count < count Then
                LoadVoluntary(dg)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Public Shared Sub LoadPosition(cbDept As Guna2ComboBox, cbPos As Guna2ComboBox)
        Try
            RunQuery("Select * from tblposition where departmentID = '" & cbDept.SelectedValue & "'")
            cbPos.ValueMember = "positionID"
            cbPos.DisplayMember = "positionName"
            cbPos.DataSource = ds.Tables("querytable")
            cbPos.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub SelectEmployee(dg As Guna2DataGridView, txtrfid As Guna2TextBox, txtfirstname As Guna2TextBox, txtlastname As Guna2TextBox, cbdept As Guna2ComboBox, cbpos As Guna2ComboBox, txtsalary As Guna2TextBox, cbtype As Guna2ComboBox, cbstatus As Guna2ComboBox)
        Try
            If dg.SelectedRows.Count > 0 Then
                employeeID = dg.SelectedRows(0).Cells(0).Value
                txtrfid.Text = dg.SelectedRows(0).Cells(2).Value
                txtfirstname.Text = dg.SelectedRows(0).Cells(4).Value
                txtlastname.Text = dg.SelectedRows(0).Cells(5).Value
                cbdept.Text = If(String.IsNullOrEmpty(dg.SelectedRows(0).Cells(6).Value.ToString), "", dg.SelectedRows(0).Cells(6).Value)
                LoadPosition(FrmAddEmployee.CbDepartment, FrmAddEmployee.CbPosition)
                cbpos.Text = If(String.IsNullOrEmpty(dg.SelectedRows(0).Cells(7).Value.ToString), "", dg.SelectedRows(0).Cells(7).Value)
                txtsalary.Text = dg.SelectedRows(0).Cells(8).Value
                cbtype.Text = If(String.IsNullOrEmpty(dg.SelectedRows(0).Cells(9).Value.ToString), "", dg.SelectedRows(0).Cells(9).Value)
                cbstatus.Text = If(IsDBNull(dg.SelectedRows(0).Cells(10).Value), "", dg.SelectedRows(0).Cells(10).Value)
                FrmAddEmployee.Show()
                FrmEmployee.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Public Shared Sub NewEmployee(rfidnumber As Guna2TextBox, txtlastname As Guna2TextBox, txtfirstname As Guna2TextBox, cbdept As Guna2ComboBox, cbpos As Guna2ComboBox, txtsalary As Guna2TextBox, cbstatus As Guna2ComboBox, txtallowances As Guna2TextBox)
        Try
            Dim employeenumber As Integer
            If employeeID = 0 Then

                If cbstatus.Text = "Resigned" Then
                    MsgBox("Can't set the status to resigned for new employees", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                Dim deptID As Integer = cbdept.SelectedValue

                'Get Last Inserted Employee Number
                RunQuery("Select * from tblemployee order by employeeID DESC LIMIT 1")
                If ds.Tables("querytable").Rows.Count > 0 Then
                    employeenumber = ds.Tables("querytable").Rows(0)(1) + 1
                Else
                    Dim year = Now.Year
                    employeenumber = year & "0001"
                End If

                'If Position is Department Head and there is an existing Department Head
                If cbpos.Text = "Department Head" Then
                    RunQuery("Select * from tbldepartmenthead where departmentID = '" & deptID & "' and employeeID != 0")
                    If ds.Tables("querytable").Rows.Count > 0 Then
                        MsgBox("There's an assigned Department Head already. Demote the current Department Head to assign a new one.")
                        Exit Sub


                    Else

                        'Insert employee
                        RunCommand("Insert into tblemployee (employeeNumber,rfidnumber,lastname,firstname,departmentID,positionID,status) VALUES
                        (@employeeNumber,@rfidnumber,@lastname,@firstname,@departmentID,@positionID,@status)")
                        With com
                            .Parameters.AddWithValue("@employeeID", employeeID)
                            .Parameters.AddWithValue("@employeeNumber", employeenumber)
                            .Parameters.AddWithValue("@rfidnumber", rfidnumber.Text)
                            .Parameters.AddWithValue("@lastname", txtlastname.Text)
                            .Parameters.AddWithValue("@firstname", txtfirstname.Text)
                            .Parameters.AddWithValue("@departmentID", cbdept.SelectedValue)
                            .Parameters.AddWithValue("@positionID", cbpos.SelectedValue)
                            .Parameters.AddWithValue("@status", cbstatus.Text)
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With


                        'Get last inserted Employee ID
                        RunQuery("Select employeeID from tblemployee order by employeeID DESC limit 1")
                        Dim newemployeeID As Integer = ds.Tables("querytable").Rows(0)(0)

                        'If Position is Department Head and no Department Assigned yet
                        If cbpos.Text = "Department Head" Then
                            RunCommand("Insert into tbldepartmenthead (departmentID,employeeID) VALUES (@departmentID,@employeeID) 
                                    ON DUPLICATE KEY UPDATE employeeID=@employeeID")
                            With com
                                .Parameters.AddWithValue("@departmentID", deptID)
                                .Parameters.AddWithValue("@employeeID", newemployeeID)
                                .ExecuteNonQuery()
                                .Parameters.Clear()
                            End With
                        End If

                        'Get last inserted
                        RunQuery("Select * from tblemployee ORDER by employeeID DESC LIMIT 1")
                        If ds.Tables("querytable").Rows.Count > 0 Then
                            Dim empID As Integer = ds.Tables("querytable").Rows(0)(0)

                            RunCommand("Insert into tblsalary (employeeID,salary,type) VALUES (@employeeID,@salary,@type)")
                            With com
                                .Parameters.AddWithValue("@employeeID", empID)
                                .Parameters.AddWithValue("@salary", txtsalary.Text.Trim)
                                .Parameters.AddWithValue("@type", FrmAddEmployee.CbCompensationType.Text)
                                .ExecuteNonQuery()
                                .Parameters.Clear()

                            End With

                            'Voluntary
                            For Each row As DataGridViewRow In FrmAddEmployee.DGVoluntary.Rows
                                Dim volID As Integer = row.Cells("voluntaryID").Value
                                Dim amount As Decimal = If(String.IsNullOrEmpty(row.Cells("amount").Value), 0, row.Cells("amount").Value)

                                RunCommand("Insert into tblempvoluntary (employeeID,voluntaryID,amount) VALUES (@employeeID,@voluntaryID,@amount)
                                    ON DUPLICATE KEY UPDATE amount=@amount")
                                With com
                                    .Parameters.AddWithValue("@employeeID", empID)
                                    .Parameters.AddWithValue("@voluntaryID", volID)
                                    .Parameters.AddWithValue("@amount", amount)
                                    .ExecuteNonQuery()
                                    .Parameters.Clear()
                                End With
                            Next

                            SaveLeaveAllocation(empID)
                            SaveAllowance(empID, txtallowances)
                            SaveSalaryHistory(empID, txtsalary)
                        End If
                        MsgBox("Saved")
                    End If

                Else
                    'Insert employee
                    RunCommand("Insert into tblemployee (employeeNumber,rfidnumber,lastname,firstname,departmentID,positionID,status) VALUES
                        (@employeeNumber,@rfidnumber,@lastname,@firstname,@departmentID,@positionID,@status)")
                    With com
                        .Parameters.AddWithValue("@employeeID", employeeID)
                        .Parameters.AddWithValue("@employeeNumber", employeenumber)
                        .Parameters.AddWithValue("@rfidnumber", rfidnumber.Text)
                        .Parameters.AddWithValue("@lastname", txtlastname.Text)
                        .Parameters.AddWithValue("@firstname", txtfirstname.Text)
                        .Parameters.AddWithValue("@departmentID", cbdept.SelectedValue)
                        .Parameters.AddWithValue("@positionID", cbpos.SelectedValue)
                        .Parameters.AddWithValue("@status", cbstatus.Text)
                        .ExecuteNonQuery()
                        .Parameters.Clear()
                    End With

                    'Get last inserted Employee ID
                    RunQuery("Select employeeID from tblemployee order by employeeID DESC limit 1")
                    Dim newemployeeID As Integer = ds.Tables("querytable").Rows(0)(0)


                    'Get last inserted
                    RunQuery("Select * from tblemployee ORDER by employeeID DESC LIMIT 1")
                    If ds.Tables("querytable").Rows.Count > 0 Then
                        Dim empID As Integer = ds.Tables("querytable").Rows(0)(0)

                        RunCommand("Insert into tblsalary (employeeID,salary,type) VALUES (@employeeID,@salary,@type)")
                        With com
                            .Parameters.AddWithValue("@employeeID", empID)
                            .Parameters.AddWithValue("@salary", txtsalary.Text.Trim)
                            .Parameters.AddWithValue("@type", FrmAddEmployee.CbCompensationType.Text)
                            .ExecuteNonQuery()
                            .Parameters.Clear()

                        End With

                        'Voluntary
                        For Each row As DataGridViewRow In FrmAddEmployee.DGVoluntary.Rows
                            Dim volID As Integer = row.Cells("voluntaryID").Value
                            Dim amount As Decimal = If(String.IsNullOrEmpty(row.Cells("amount").Value), 0, row.Cells("amount").Value)

                            RunCommand("Insert into tblempvoluntary (employeeID,voluntaryID,amount) VALUES (@employeeID,@voluntaryID,@amount)
                                    ON DUPLICATE KEY UPDATE amount=@amount")
                            With com
                                .Parameters.AddWithValue("@employeeID", empID)
                                .Parameters.AddWithValue("@voluntaryID", volID)
                                .Parameters.AddWithValue("@amount", amount)
                                .ExecuteNonQuery()
                                .Parameters.Clear()
                            End With
                        Next
                        SaveLeaveAllocation(empID)
                        SaveAllowance(empID, txtallowances)
                        SaveSalaryHistory(empID, txtsalary)
                    End If
                End If
                MsgBox("Saved")
            Else
                GetOldSalary()
                Dim depID As Integer = cbdept.SelectedValue
                Dim selectedposID As Integer = cbpos.SelectedValue
                RunQuery("Select * from tblemployee where employeeID = '" & employeeID & "'")
                Dim posID As Integer
                If ds.Tables("querytable").Rows.Count > 0 Then
                    posID = ds.Tables("querytable").Rows(0)(0)
                End If

                'If no current position
                If posID = 0 Then


                    'If aassign na department head
                    If cbpos.Text = "Department Head" Then

                        'If may assigned Department Head
                        RunQuery("Select * from tbldepartmenthead where departmentID = '" & depID & "' and employeeID !='" & employeeID & "'")
                        If ds.Tables("querytable").Rows.Count > 0 Then
                            MsgBox("There's an assigned Department Head already. Demote the Department head first.")
                            Exit Sub

                        Else
                            'If walang department head
                            RunCommand("Update tblemployee SET rfidnumber=@rfidnumber, firstname=@firstname,lastname=@lastname,
                                            departmentID=@departmentID,positionID=@positionID,status=@status WHERE employeeID=@employeeID")
                            With com
                                .Parameters.AddWithValue("@rfidnumber", rfidnumber.Text.Trim)
                                .Parameters.AddWithValue("@firstname", txtfirstname.Text.Trim)
                                .Parameters.AddWithValue("@lastname", txtlastname.Text.Trim)
                                .Parameters.AddWithValue("@departmentID", depID)
                                .Parameters.AddWithValue("@positionID", selectedposID)
                                .Parameters.AddWithValue("@status", cbstatus.Text)
                                .Parameters.AddWithValue("@employeeID", employeeID)
                                .ExecuteNonQuery()
                                .Parameters.Clear()

                            End With

                            'Create new department head
                            RunCommand("Insert into tbldepartmenthead (departmentID,employeeID) VALUES (@departmentID,@employeeID) 
                                    ON DUPLICATE KEY UPDATE employeeID=@employeeID")
                            With com
                                .Parameters.AddWithValue("@departmentID", depID)
                                .Parameters.AddWithValue("@employeeID", employeeID)

                            End With

                            'Update Salary
                            RunCommand("Update tblsalary set salary=@salary, type=@type WHERE employeeID=@employeeID")
                            With com
                                .Parameters.AddWithValue("@employeeID", employeeID)
                                .Parameters.AddWithValue("@salary", txtsalary.Text.Trim)
                                .Parameters.AddWithValue("@type", FrmAddEmployee.CbCompensationType.Text)
                                .ExecuteNonQuery()
                                .Parameters.Clear()

                            End With

                            'Insert Voluntary Contribution
                            For Each row As DataGridViewRow In FrmAddEmployee.DGVoluntary.Rows
                                Dim volID As Integer = row.Cells("voluntaryID").Value
                                Dim amount As Decimal = If(String.IsNullOrEmpty(row.Cells("amount").Value.ToString), 0, row.Cells("amount").Value)

                                RunCommand("Insert into tblempvoluntary (employeeID,voluntaryID,amount) VALUES (@employeeID,@voluntaryID,@amount)
                                        ON DUPLICATE KEY UPDATE amount=@amount")
                                With com
                                    .Parameters.AddWithValue("@employeeID", employeeID)
                                    .Parameters.AddWithValue("@voluntaryID", volID)
                                    .Parameters.AddWithValue("@amount", amount)
                                    .ExecuteNonQuery()
                                    .Parameters.Clear()
                                End With
                            Next

                            SaveLeaveAllocation(employeeID)
                            SaveAllowance(employeeID, txtallowances)
                            SaveSalaryHistory(employeeID, txtsalary)

                            'Check if may schedule
                            RunQuery("Select * from tblschedule where employeeID = '" & employeeID & "'")
                            If ds.Tables("querytable").Rows.Count > 0 Then
                                GetDailyWageOfMonthlyEmployees(employeeID)

                            End If

                        End If
                        MsgBox("Saved")

                    Else
                        'If hindi department head
                        RunCommand("Update tblemployee SET rfidnumber=@rfidnumber, firstname=@firstname,lastname=@lastname,
                                            departmentID=@departmentID,positionID=@positionID,status=@status WHERE employeeID=@employeeID")
                        With com
                            .Parameters.AddWithValue("@rfidnumber", rfidnumber.Text.Trim)
                            .Parameters.AddWithValue("@firstname", txtfirstname.Text.Trim)
                            .Parameters.AddWithValue("@lastname", txtlastname.Text.Trim)
                            .Parameters.AddWithValue("@departmentID", depID)
                            .Parameters.AddWithValue("@positionID", selectedposID)
                            .Parameters.AddWithValue("@status", cbstatus.Text)
                            .Parameters.AddWithValue("@employeeID", employeeID)
                            .ExecuteNonQuery()
                            .Parameters.Clear()

                        End With

                        'Update Salary
                        RunCommand("Update tblsalary set salary=@salary, type=@type WHERE employeeID=@employeeID")
                        With com
                            .Parameters.AddWithValue("@employeeID", employeeID)
                            .Parameters.AddWithValue("@salary", txtsalary.Text.Trim)
                            .Parameters.AddWithValue("@type", FrmAddEmployee.CbCompensationType.Text)
                            .ExecuteNonQuery()
                            .Parameters.Clear()

                        End With

                        'Insert Voluntary Contribution
                        For Each row As DataGridViewRow In FrmAddEmployee.DGVoluntary.Rows
                            Dim volID As Integer = row.Cells("voluntaryID").Value
                            Dim amount As Decimal = If(String.IsNullOrEmpty(row.Cells("amount").Value.ToString), 0, row.Cells("amount").Value)

                            RunCommand("Insert into tblempvoluntary (employeeID,voluntaryID,amount) VALUES (@employeeID,@voluntaryID,@amount)
                                        ON DUPLICATE KEY UPDATE amount=@amount")
                            With com
                                .Parameters.AddWithValue("@employeeID", employeeID)
                                .Parameters.AddWithValue("@voluntaryID", volID)
                                .Parameters.AddWithValue("@amount", amount)
                                .ExecuteNonQuery()
                                .Parameters.Clear()
                            End With
                        Next

                        SaveLeaveAllocation(employeeID)
                        SaveAllowance(employeeID, txtallowances)
                        SaveSalaryHistory(employeeID, txtsalary)


                        'Check if may schedule
                        RunQuery("Select * from tblschedule where employeeID = '" & employeeID & "'")
                        If ds.Tables("querytable").Rows.Count > 0 Then
                            GetDailyWageOfMonthlyEmployees(employeeID)
                        End If
                        MsgBox("Saved")
                    End If

                Else
                    'May position na magpapalit lang

                    'Magpapalit into department head
                    If cbpos.Text = "Department Head" Then
                        RunQuery("Select * from tbldepartmenthead where departmentID = '" & depID & "'")
                        'If merong department
                        If ds.Tables("querytable").Rows.Count > 0 Then
                            Dim sempid As Integer = ds.Tables("querytable").Rows(0)(2)
                            If sempid = 0 Then
                                'IF WALANG DEPARTMENT HEAD

                                'Update profile
                                RunCommand("Update tblemployee SET rfidnumber=@rfidnumber, firstname=@firstname,lastname=@lastname,
                                            departmentID=@departmentID,positionID=@positionID,status=@status WHERE employeeID=@employeeID")
                                With com
                                    .Parameters.AddWithValue("@rfidnumber", rfidnumber.Text.Trim)
                                    .Parameters.AddWithValue("@firstname", txtfirstname.Text.Trim)
                                    .Parameters.AddWithValue("@lastname", txtlastname.Text.Trim)
                                    .Parameters.AddWithValue("@departmentID", depID)
                                    .Parameters.AddWithValue("@positionID", selectedposID)
                                    .Parameters.AddWithValue("@status", cbstatus.Text)
                                    .Parameters.AddWithValue("@employeeID", employeeID)
                                    .ExecuteNonQuery()
                                    .Parameters.Clear()

                                End With

                                'Update Salary
                                RunCommand("Update tblsalary set salary=@salary, type=@type WHERE employeeID=@employeeID")
                                With com
                                    .Parameters.AddWithValue("@employeeID", employeeID)
                                    .Parameters.AddWithValue("@salary", txtsalary.Text.Trim)
                                    .Parameters.AddWithValue("@type", FrmAddEmployee.CbCompensationType.Text)
                                    .ExecuteNonQuery()
                                    .Parameters.Clear()

                                End With
                                'Insert Voluntary Contribution
                                For Each row As DataGridViewRow In FrmAddEmployee.DGVoluntary.Rows
                                    Dim volID As Integer = row.Cells("voluntaryID").Value
                                    Dim amount As Decimal = If(String.IsNullOrEmpty(row.Cells("amount").Value.ToString), 0, row.Cells("amount").Value)

                                    RunCommand("Insert into tblempvoluntary (employeeID,voluntaryID,amount) VALUES (@employeeID,@voluntaryID,@amount)
                                        ON DUPLICATE KEY UPDATE amount=@amount")
                                    With com
                                        .Parameters.AddWithValue("@employeeID", employeeID)
                                        .Parameters.AddWithValue("@voluntaryID", volID)
                                        .Parameters.AddWithValue("@amount", amount)
                                        .ExecuteNonQuery()
                                        .Parameters.Clear()
                                    End With
                                Next
                                SaveLeaveAllocation(employeeID)
                                SaveAllowance(employeeID, txtallowances)
                                SaveSalaryHistory(employeeID, txtsalary)

                                'Assign Department HEad
                                RunCommand("Update tbldepartmenthead set employeeID = '" & employeeID & "' where employeeID = 0 and departmentID = '" & depID & "'")
                                With com
                                    .ExecuteNonQuery()
                                    .Parameters.Clear()
                                End With


                                'Check if may schedule
                                RunQuery("Select * from tblschedule where employeeID = '" & employeeID & "'")
                                If ds.Tables("querytable").Rows.Count > 0 Then
                                    GetDailyWageOfMonthlyEmployees(employeeID)
                                End If
                                MsgBox("Saved")


                            Else
                                ''IF MERONG DEPARTMENT HEAD
                                If sempid = employeeID Then
                                    'IF SAME ACCOUNT 

                                    'Update profile
                                    RunCommand("Update tblemployee SET rfidnumber=@rfidnumber, firstname=@firstname,lastname=@lastname,
                                            departmentID=@departmentID,positionID=@positionID,status=@status WHERE employeeID=@employeeID")
                                    With com
                                        .Parameters.AddWithValue("@rfidnumber", rfidnumber.Text.Trim)
                                        .Parameters.AddWithValue("@firstname", txtfirstname.Text.Trim)
                                        .Parameters.AddWithValue("@lastname", txtlastname.Text.Trim)
                                        .Parameters.AddWithValue("@departmentID", depID)
                                        .Parameters.AddWithValue("@positionID", selectedposID)
                                        .Parameters.AddWithValue("@status", cbstatus.Text)
                                        .Parameters.AddWithValue("@employeeID", employeeID)
                                        .ExecuteNonQuery()
                                        .Parameters.Clear()

                                    End With

                                    'Update Salary
                                    RunCommand("Update tblsalary set salary=@salary, type=@type WHERE employeeID=@employeeID")
                                    With com
                                        .Parameters.AddWithValue("@employeeID", employeeID)
                                        .Parameters.AddWithValue("@salary", txtsalary.Text.Trim)
                                        .Parameters.AddWithValue("@type", FrmAddEmployee.CbCompensationType.Text)
                                        .ExecuteNonQuery()
                                        .Parameters.Clear()
                                    End With

                                    'Insert Voluntary Contribution
                                    For Each row As DataGridViewRow In FrmAddEmployee.DGVoluntary.Rows
                                        Dim volID As Integer = row.Cells("voluntaryID").Value
                                        Dim amount As Decimal = If(String.IsNullOrEmpty(row.Cells("amount").Value.ToString), 0, row.Cells("amount").Value)

                                        RunCommand("Insert into tblempvoluntary (employeeID,voluntaryID,amount) VALUES (@employeeID,@voluntaryID,@amount)
                                        ON DUPLICATE KEY UPDATE amount=@amount")
                                        With com
                                            .Parameters.AddWithValue("@employeeID", employeeID)
                                            .Parameters.AddWithValue("@voluntaryID", volID)
                                            .Parameters.AddWithValue("@amount", amount)
                                            .ExecuteNonQuery()
                                            .Parameters.Clear()
                                        End With
                                    Next
                                    SaveLeaveAllocation(employeeID)
                                    SaveAllowance(employeeID, txtallowances)
                                    SaveSalaryHistory(employeeID, txtsalary)

                                    'Create new department head
                                    RunCommand("Insert into tbldepartmenthead (departmentID,employeeID) VALUES (@departmentID,@employeeID) 
                                    ON DUPLICATE KEY UPDATE employeeID=@employeeID")
                                    With com
                                        .Parameters.AddWithValue("@departmentID", depID)
                                        .Parameters.AddWithValue("@employeeID", employeeID)
                                    End With

                                    'Check if may schedule
                                    RunQuery("Select * from tblschedule where employeeID = '" & employeeID & "'")
                                    If ds.Tables("querytable").Rows.Count > 0 Then
                                        GetDailyWageOfMonthlyEmployees(employeeID)
                                    End If
                                    MsgBox("Saved")
                                Else
                                    MsgBox("There's an assigned Department Head already. Demote the current Department Head to assign a new one.")
                                    Exit Sub
                                End If
                            End If
                        Else
                            'If wala pang department
                            'Update profile
                            RunCommand("Update tblemployee SET rfidnumber=@rfidnumber, firstname=@firstname,lastname=@lastname,
                                            departmentID=@departmentID,positionID=@positionID,status=@status WHERE employeeID=@employeeID")
                            With com
                                .Parameters.AddWithValue("@rfidnumber", rfidnumber.Text.Trim)
                                .Parameters.AddWithValue("@firstname", txtfirstname.Text.Trim)
                                .Parameters.AddWithValue("@lastname", txtlastname.Text.Trim)
                                .Parameters.AddWithValue("@departmentID", depID)
                                .Parameters.AddWithValue("@positionID", selectedposID)
                                .Parameters.AddWithValue("@status", cbstatus.Text)
                                .Parameters.AddWithValue("@employeeID", employeeID)
                                .ExecuteNonQuery()
                                .Parameters.Clear()

                            End With

                            'Update Salary
                            RunCommand("Update tblsalary set salary=@salary, type=@type WHERE employeeID=@employeeID")
                            With com
                                .Parameters.AddWithValue("@employeeID", employeeID)
                                .Parameters.AddWithValue("@salary", txtsalary.Text.Trim)
                                .Parameters.AddWithValue("@type", FrmAddEmployee.CbCompensationType.Text)
                                .ExecuteNonQuery()
                                .Parameters.Clear()

                            End With
                            'Insert Voluntary Contribution
                            For Each row As DataGridViewRow In FrmAddEmployee.DGVoluntary.Rows
                                Dim volID As Integer = row.Cells("voluntaryID").Value
                                Dim amount As Decimal = If(String.IsNullOrEmpty(row.Cells("amount").Value.ToString), 0, row.Cells("amount").Value)

                                RunCommand("Insert into tblempvoluntary (employeeID,voluntaryID,amount) VALUES (@employeeID,@voluntaryID,@amount)
                                        ON DUPLICATE KEY UPDATE amount=@amount")
                                With com
                                    .Parameters.AddWithValue("@employeeID", employeeID)
                                    .Parameters.AddWithValue("@voluntaryID", volID)
                                    .Parameters.AddWithValue("@amount", amount)
                                    .ExecuteNonQuery()
                                    .Parameters.Clear()
                                End With
                            Next
                            SaveLeaveAllocation(employeeID)
                            SaveAllowance(employeeID, txtallowances)
                            SaveSalaryHistory(employeeID, txtsalary)


                            'Check if may schedule
                            RunQuery("Select * from tblschedule where employeeID = '" & employeeID & "'")
                            If ds.Tables("querytable").Rows.Count > 0 Then
                                GetDailyWageOfMonthlyEmployees(employeeID)
                            End If

                            'Create new department head
                            RunCommand("Insert into tbldepartmenthead (departmentID,employeeID) VALUES (@departmentID,@employeeID) 
                                    ON DUPLICATE KEY UPDATE employeeID=@employeeID")
                            With com
                                .Parameters.AddWithValue("@departmentID", depID)
                                .Parameters.AddWithValue("@employeeID", employeeID)

                            End With

                            MsgBox("Saved")
                        End If
                    Else
                        'Magpapalit pero hindi department head
                        RunCommand("Update tblemployee SET rfidnumber=@rfidnumber, firstname=@firstname,lastname=@lastname,
                                            departmentID=@departmentID,positionID=@positionID,status=@status WHERE employeeID=@employeeID")
                        With com
                            .Parameters.AddWithValue("@rfidnumber", rfidnumber.Text.Trim)
                            .Parameters.AddWithValue("@firstname", txtfirstname.Text.Trim)
                            .Parameters.AddWithValue("@lastname", txtlastname.Text.Trim)
                            .Parameters.AddWithValue("@departmentID", depID)
                            .Parameters.AddWithValue("@positionID", selectedposID)
                            .Parameters.AddWithValue("@status", cbstatus.Text)
                            .Parameters.AddWithValue("@employeeID", employeeID)
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                        'Update Salary
                        RunCommand("Update tblsalary set salary=@salary, type=@type WHERE employeeID=@employeeID")
                        With com
                            .Parameters.AddWithValue("@employeeID", employeeID)
                            .Parameters.AddWithValue("@salary", txtsalary.Text.Trim)
                            .Parameters.AddWithValue("@type", FrmAddEmployee.CbCompensationType.Text)
                            .ExecuteNonQuery()
                            .Parameters.Clear()

                        End With
                        'Insert Voluntary Contribution
                        For Each row As DataGridViewRow In FrmAddEmployee.DGVoluntary.Rows
                            Dim volID As Integer = row.Cells("voluntaryID").Value
                            Dim amount As Decimal = If(String.IsNullOrEmpty(row.Cells("amount").Value.ToString), 0, row.Cells("amount").Value)

                            RunCommand("Insert into tblempvoluntary (employeeID,voluntaryID,amount) VALUES (@employeeID,@voluntaryID,@amount)
                                        ON DUPLICATE KEY UPDATE amount=@amount")
                            With com
                                .Parameters.AddWithValue("@employeeID", employeeID)
                                .Parameters.AddWithValue("@voluntaryID", volID)
                                .Parameters.AddWithValue("@amount", amount)
                                .ExecuteNonQuery()
                                .Parameters.Clear()
                            End With
                        Next

                        SaveLeaveAllocation(employeeID)
                        SaveAllowance(employeeID, txtallowances)
                        SaveSalaryHistory(employeeID, txtsalary)


                        'Check if may schedule
                        RunQuery("Select * from tblschedule where employeeID = '" & employeeID & "'")
                        If ds.Tables("querytable").Rows.Count > 0 Then
                            GetDailyWageOfMonthlyEmployees(employeeID)
                        End If

                        'Remove from department head list
                        RunCommand("Update tbldepartmenthead SET employeeID = 0 WHERE employeeID = '" & employeeID & "'")
                        With com
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With
                        MsgBox("Saved")
                    End If
                End If
            End If


            employeeID = 0
            rfidnumber.Clear()
            txtlastname.Clear()
            txtfirstname.Clear()
            cbdept.SelectedIndex = -1
            cbpos.SelectedIndex = -1
            FrmAddEmployee.TxtSalary.Clear()
            txtallowances.Clear()
            FrmAddEmployee.CbAssociateStatus.SelectedIndex = -1
            FrmAddEmployee.CbCompensationType.SelectedIndex = -1
            LoadVoluntary(FrmAddEmployee.DGVoluntary)
            LoadLeaveAllocation(FrmAddEmployee.DGLeaveAllocation)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Shared Sub GetDailyWageOfMonthlyEmployees(id As Integer)
        Try
            Dim selectedemployeeID As Integer = id
            RunQuery("Select salary,type from tblsalary where employeeID = '" & selectedemployeeID & "'")
            Dim salary As Decimal = ds.Tables("querytable").Rows(0)(0)
            Dim type As String = ds.Tables("querytable").Rows(0)(1)

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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub SaveLeaveAllocation(empid As Integer)
        Try
            For Each row As DataGridViewRow In FrmAddEmployee.DGLeaveAllocation.Rows
                Dim leaveID As Integer = row.Cells("leaveID").Value
                Dim days As Decimal = If(String.IsNullOrEmpty(row.Cells("days").Value.ToString), 0, row.Cells("days").Value)

                RunCommand("Insert into tblemployeeleave (employeeID,leaveID,days) VALUES (@employeeID,@leaveID,@days)
                                        ON DUPLICATE KEY UPDATE days=@days")
                With com
                    .Parameters.AddWithValue("@employeeID", empid)
                    .Parameters.AddWithValue("@leaveID", leaveID)
                    .Parameters.AddWithValue("@days", days)
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub SaveAllowance(empid As Integer, txtallowance As Guna2TextBox)
        Try
            RunCommand("Insert into tblempallowance (employeeID, allowance) VALUES (@employeeID,@allowance) ON DUPLICATE KEY UPDATE allowance=@allowance")
            With com
                .Parameters.AddWithValue("@employeeID", empid)
                .Parameters.AddWithValue("@allowance", txtallowance.Text.Trim)
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub GetOldSalary()
        Try
            If employeeID > 0 Then
                RunQuery("Select salary from tblsalary where employeeID = '" & employeeID & "'")
                oldSalary = ds.Tables("querytable").Rows(0)(0)
            Else
                oldSalary = 0
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub SaveSalaryHistory(empid As Integer, txtsalary As Guna2TextBox)
        Try
            'If updating
            If empid > 0 Then
                Dim newSalary As Integer = txtsalary.Text
                If oldSalary > newSalary Or oldSalary < newSalary Then
                    RunCommand("Insert into tblsalaryhistory (employeeID,salary,date) VALUES (@employeeID,@salary,NOW())")
                    With com
                        .Parameters.AddWithValue("@employeeID", employeeID)
                        .Parameters.AddWithValue("@salary", txtsalary.Text.Trim)
                        .ExecuteNonQuery()
                        .Parameters.Clear()
                    End With
                End If
            Else
                RunCommand("Insert into tblsalaryhistory (employeeID,salary,date) VALUES (@employeeID,@salary,NOW())")
                With com
                    .Parameters.AddWithValue("@employeeID", employeeID)
                    .Parameters.AddWithValue("@salary", txtsalary.Text.Trim)
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub LoadAllowance(txtallowance As Guna2TextBox)
        Try
            If employeeID <> 0 Then
                RunQuery("Select * from tblempallowance where employeeID = '" & employeeID & "'")
                If ds.Tables("querytable").Rows.Count > 0 Then
                    Dim allowanceAmount As Decimal = ds.Tables("querytable").Rows(0)(2)
                    txtallowance.Text = allowanceAmount
                Else
                    txtallowance.Text = "0.00"
                End If
            Else
                txtallowance.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub ViewSalaryHistory(dg As Guna2DataGridView)
        Try
            If employeeID > 0 Then
                RunQuery("Select salary,date from tblsalaryhistory where employeeID = '" & employeeID & "'")
                If ds.Tables("querytable").Rows.Count > 0 Then
                    FrmSalaryHistory.Show()
                    FrmEmployee.Enabled = False
                Else
                    MsgBox("There's no salary history available")
                    Exit Sub

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub LoadSalaryHistory(dg As Guna2DataGridView)
        Try
            RunQuery("Select salary,date from tblsalaryhistory where employeeID= '" & employeeID & "'")
            dg.DataSource = ds.Tables("querytable")
        Catch ex As Exception

        End Try
    End Sub



End Class

Imports System.Text.RegularExpressions

Public Class FrmSignUpAdmin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If String.IsNullOrEmpty(TxtFirstName.Text) OrElse
           String.IsNullOrEmpty(TxtLastName.Text) OrElse
           String.IsNullOrEmpty(TxtPassword.Text) OrElse
           String.IsNullOrEmpty(TxtUsername.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtFirstName.Text, fornames) Then
            MessageBox.Show("Invalid first name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtFirstName.Clear()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtLastName.text, fornames) Then
            MessageBox.Show("Invalid last name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtLastName.Clear()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtUsername.Text, noSpace) Then
            MessageBox.Show("Invalid username.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUsername.Clear()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtPassword.Text, noSpace) Then
            MessageBox.Show("Invalid Password", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPassword.Clear()
            Exit Sub
        End If
        Try
            Dim lastName As String = StrConv(TxtLastName.Text, VbStrConv.ProperCase)
            Dim firstName As String = StrConv(TxtFirstName.Text, VbStrConv.ProperCase)

            RunCommand("Insert into tblusers (firstName,lastName,role,username,password,status) VALUES (@firstName,@lastName,'Admin',@username,@password, 'Active')")
            With com
                .Parameters.AddWithValue("@firstName", lastName.Trim)
                .Parameters.AddWithValue("@lastName", firstName.Trim)
                .Parameters.AddWithValue("@username", TxtUsername.Text.Trim)
                .Parameters.AddWithValue("@password", TxtPassword.Text.Trim)
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With

            RunCommand("Insert into tblusers (firstName,lastName,role,username,password, status) VALUES (@firstName,@lastName,'Attendance',@username,@password, 'Active')")
            With com
                .Parameters.AddWithValue("@firstName", "Attendance")
                .Parameters.AddWithValue("@lastName", "Attendance")
                .Parameters.AddWithValue("@username", "attendance")
                .Parameters.AddWithValue("@password", "passwordattendance")
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With

            MessageBox.Show("Admin registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FrmLogin.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports System.Text.RegularExpressions

Public Class FrmSignUpEmployee
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If String.IsNullOrEmpty(TxtPassword.Text) OrElse String.IsNullOrEmpty(TxtUsername.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtUsername.Text, noSpace) Then
            MessageBox.Show("Invalid Username", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUsername.Clear()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtPassword.Text, noSpace) Then
            MessageBox.Show("Invalid password", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPassword.Clear()
            Exit Sub
        End If
        Try
            RunCommand("Update tblemployee SET password=@password WHERE employeeNumber = '" & TxtUsername.Text.Trim & "'")
            With com
                .Parameters.AddWithValue("@password", TxtPassword.Text.Trim)
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With
            MessageBox.Show("Password updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            FrmLogin.Show()
            Me.Close()
        Catch ex As Exception

        End Try


    End Sub
End Class
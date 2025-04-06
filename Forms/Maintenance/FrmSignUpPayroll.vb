Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports System.Text.RegularExpressions

Public Class FrmSignUpPayroll
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If String.IsNullOrEmpty(TxtPassword.Text.Trim) Then
            MsgBox("Please input password")
            Exit Sub
        End If
        If Not Regex.IsMatch(TxtPassword.Text, noSpace) Then
            MessageBox.Show("Invalid password.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPassword.Clear()
            Exit Sub
        End If
        Try
            RunCommand("Update tblusers set password=@password where username=@username")
            With com
                .Parameters.AddWithValue("@username", TxtUsername.Text.Trim)
                .Parameters.AddWithValue("@password", TxtPassword.Text.Trim)
                .ExecuteNonQuery()
                .Parameters.Clear()
                MessageBox.Show("Password updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FrmLogin.Show()
                Me.Close()
            End With
        Catch ex As Exception

        End Try

    End Sub
End Class
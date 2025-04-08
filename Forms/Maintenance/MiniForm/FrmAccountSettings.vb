Imports System.Text.RegularExpressions

Public Class FrmAccountSettings

    Public userID As Integer = 0

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TxtPassword.PasswordChar = ""
            TxtConfirmPass.PasswordChar = ""
        Else
            TxtPassword.PasswordChar = "•"
            TxtConfirmPass.PasswordChar = "•"
        End If
    End Sub

    Private Sub BtnSaveUser_Click(sender As Object, e As EventArgs) Handles BtnSaveUser.Click
        If String.IsNullOrEmpty(TxtFirstname.Text) OrElse String.IsNullOrEmpty(TxtLastname.Text) OrElse String.IsNullOrEmpty(TxtUsername.Text) OrElse String.IsNullOrEmpty(TxtPassword.Text) OrElse String.IsNullOrEmpty(TxtConfirmPass.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtFirstname.Text, fornames) Then
            MessageBox.Show("Invalid first name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtFirstname.Clear()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtLastname.Text, fornames) Then
            MessageBox.Show("Invalid last name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtLastname.Clear()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtUsername.Text, noSpace) Then
            MessageBox.Show("Invalid username.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUsername.Clear()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtPassword.Text, noSpace) Then
            MessageBox.Show("Invalid password.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPassword.Clear()
            Exit Sub
        ElseIf TxtPassword.Text <> TxtConfirmPass.Text Then
            MessageBox.Show("Password do not match.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtConfirmPass.Clear()
            Exit Sub
        Else
            UpdateAdminPayroll(userID, TxtFirstname.Text, TxtLastname.Text, TxtUsername.Text, TxtPassword.Text)
            TxtPassword.Clear()
            TxtConfirmPass.Clear()
        End If
    End Sub
End Class
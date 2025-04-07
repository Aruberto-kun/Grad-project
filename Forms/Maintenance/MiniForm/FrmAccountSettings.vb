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
        Else
            UpdateAdminPayroll(userID, TxtFirstname.Text, TxtLastname.Text, TxtUsername.Text, TxtPassword.Text)
        End If
    End Sub
End Class
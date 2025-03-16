Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class FrmMainte



    Private Sub BtnSaveUser_Click(sender As Object, e As EventArgs) Handles BtnSaveUser.Click
        If String.IsNullOrEmpty(TxtFirstname.Text) OrElse String.IsNullOrEmpty(TxtLastname.Text) OrElse String.IsNullOrEmpty(TxtUsername.Text) Then
            MsgEmptyField()
            Exit Sub
        Else
            NewUser(TxtFirstname.Text, TxtLastname.Text, TxtUsername.Text)
            DgUser.DataSource = DisplayUsers()
            TxtFirstname.Clear()
            TxtLastname.Clear()
            TxtUsername.Clear()
        End If
    End Sub



End Class
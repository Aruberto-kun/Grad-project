Imports System.ComponentModel

Public Class FrmSalaryHistory
    Private Sub FrmSalaryHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClassEmployee.LoadSalaryHistory(DGSalaryHistory)
    End Sub

    Private Sub FrmSalaryHistory_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmEmployee.Enabled = True
    End Sub
End Class
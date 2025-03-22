Public Class FrmRateInfo
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtRates.Text) Then
            MsgEmptyField()
            Exit Sub
        Else
            Dim rate As Integer = Val(TxtRates.Text)
            UpdateRate(rate, MdlMaintenance.rateID)
            Me.Close()
            FrmMainte.dgRates.DataSource = DisplayRates()
        End If
    End Sub
End Class
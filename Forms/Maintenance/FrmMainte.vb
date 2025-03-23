Imports System.Text.RegularExpressions

Public Class FrmMainte

    Private Sub FrmMainte_Load(sender As Object, e As EventArgs) Handles Me.Load
        DgUser.DataSource = DisplayUsers()
        DgDepartment.DataSource = DisplayDepartment()
        DgPosition.DataSource = DisplayPosition()
        dgLeave.DataSource = DisplayLeave()
        DgIncentives.DataSource = DisplayIncentive()
        dgHoliday.DataSource = DisplayHoliday()
        dgSSS.DataSource = DisplaySSS()
        dgPhilhealth.DataSource = DisplayPhilhealth()
        dgPagibig.DataSource = DisplayPagIbig()
        DgVoluntary.DataSource = DisplayVoluntary()
        dgRates.DataSource = DisplayRates()

        CbDepartment.DataSource = DisplayDepartment()
        CbDepartment.DisplayMember = "departmentName"
        CbDepartment.ValueMember = "departmentID"

        CbClassification.SelectedIndex = 0


        CbTaxClassification.SelectedIndex = 0

        If CbTaxClassification.SelectedIndex = 0 Then
            Dim maxSalaryOne As Decimal = GetMaxSalary(CbTaxClassification)
            TxtTaxMinSalary.Text = maxSalaryOne
            dgTax.DataSource = DisplayTaxDaily()
        Else
            Dim maxSalaryOne As Decimal = GetMaxSalary(CbTaxClassification)
            TxtTaxMinSalary.Text = maxSalaryOne
            dgTax.DataSource = DisplayTaxMonthly()
        End If
    End Sub

    Private Sub BtnSaveUser_Click(sender As Object, e As EventArgs) Handles BtnSaveUser.Click
        If String.IsNullOrEmpty(TxtFirstname.Text) OrElse String.IsNullOrEmpty(TxtLastname.Text) OrElse String.IsNullOrEmpty(TxtUsername.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtFirstname.Text, forNames) Then
            MessageBox.Show("Invalid first name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtFirstname.Clear()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtLastname.Text, forNames) Then
            MessageBox.Show("Invalid last name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtLastname.Clear()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtUsername.Text, antiSpace) Then
            MessageBox.Show("Invalid user name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUsername.Clear()
            Exit Sub
        Else
            NewUser(TxtFirstname.Text, TxtLastname.Text, TxtUsername.Text)
            TxtFirstname.Clear()
            TxtLastname.Clear()
            TxtUsername.Clear()
            DgUser.DataSource = DisplayUsers()
        End If
    End Sub

    Private Sub BtnSaveDepartment_Click(sender As Object, e As EventArgs) Handles BtnSaveDepartment.Click
        If String.IsNullOrEmpty(TxtDepartment.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtDepartment.Text, forNames) Then
            MessageBox.Show("Invalid department name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDepartment.Clear()
            Exit Sub
        Else
            NewDepartment(TxtDepartment.Text)
            DgDepartment.DataSource = DisplayDepartment()
            TxtDepartment.Clear()
            CbDepartment.DataSource = DisplayDepartment()
            CbDepartment.DisplayMember = "departmentName"
            CbDepartment.ValueMember = "departmentID"
        End If
    End Sub

    Private Sub BtnSavePosition_Click(sender As Object, e As EventArgs) Handles BtnSavePosition.Click
        If String.IsNullOrEmpty(TxtPosition.Text) OrElse String.IsNullOrEmpty(CbDepartment.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtPosition.Text, forNames) Then
            MessageBox.Show("Invalid position name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPosition.Clear()
            Exit Sub
        Else
            If CbDepartment.SelectedValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(TxtPosition.Text) Then
                Dim departmentID As Integer = Convert.ToInt32(CbDepartment.SelectedValue)
                NewPosition(departmentID, TxtPosition.Text)
                CbDepartment.SelectedIndex = 0
                TxtPosition.Clear()
                DgPosition.DataSource = DisplayPosition()
            Else
                MessageBox.Show("Please select a department and enter a position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub BtnSaveLeave_Click(sender As Object, e As EventArgs) Handles BtnSaveLeave.Click
        If String.IsNullOrEmpty(TxtLeave.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtLeave.Text, fornames) Then
            MessageBox.Show("Invalid type of leave.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtLeave.Clear()
            Exit Sub
        Else
            NewLeave(TxtLeave.Text)
            dgLeave.DataSource = DisplayLeave()
            TxtLeave.Clear()
        End If
    End Sub

    Private Sub BtnSaveIncentives_Click(sender As Object, e As EventArgs) Handles BtnSaveIncentives.Click
        If String.IsNullOrEmpty(TxtIncentives.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtIncentives.Text, fornames) Then
            MessageBox.Show("Invalid type of incentives.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtIncentives.Clear()
            Exit Sub
        Else
            NewIncentives(TxtIncentives.Text)
            DgIncentives.DataSource = DisplayIncentive()
            TxtIncentives.Clear()
        End If
    End Sub

    Private Sub BtnSaveHoliday_Click(sender As Object, e As EventArgs) Handles BtnSaveHoliday.Click
        If String.IsNullOrEmpty(TxtHoliday.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(txtholiday.text, fornames) Then
            MessageBox.Show("Invalid holiday name.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            NewHoliday(DtHoliday.Value, TxtHoliday.Text, CbClassification.SelectedItem.ToString)
            dgHoliday.DataSource = DisplayHoliday()
            TxtHoliday.Clear()
        End If
    End Sub

    Private Sub BtnVoluntary_Click(sender As Object, e As EventArgs) Handles BtnSaveVoluntary.Click
        If String.IsNullOrEmpty(TxtVoluntary.Text) Then
            MsgEmptyField()
            Exit Sub
        ElseIf Not Regex.IsMatch(TxtVoluntary.Text, fornames) Then
            MessageBox.Show("Invalid type of voluntary.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            NewVoluntary(TxtVoluntary.Text)
            DgVoluntary.DataSource = DisplayVoluntary()
            TxtVoluntary.Clear()
        End If
    End Sub

    Private Sub DgDepartment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgDepartment.CellDoubleClick
        SelectDepartment(DgDepartment)
    End Sub

    Private Sub DgPosition_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgPosition.CellDoubleClick
        SelectPosition(DgPosition)
    End Sub

    Private Sub DgLeave_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLeave.CellDoubleClick
        SelectLeave(dgLeave)
    End Sub

    Private Sub DgIncentives_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgIncentives.CellDoubleClick
        SelectIncentives(DgIncentives)
    End Sub

    Private Sub DgHoliday_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgHoliday.CellDoubleClick
        Selectholiday(dgHoliday)
    End Sub

    Private Sub DgRates_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRates.CellDoubleClick
        SelectRates(dgRates)
    End Sub

    Private Sub DgVoluntary_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgVoluntary.CellDoubleClick
        SelectVoluntary(DgVoluntary)
    End Sub

#Region "Tax"
    Private Sub CbTaxClassification_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTaxClassification.SelectedIndexChanged
        If CbTaxClassification.SelectedIndex = 0 Then
            dgTax.DataSource = DisplayTaxDaily()
            TxtTaxMinSalary.Text = GetMaxSalary(CbTaxClassification)
            Exit Sub
        ElseIf CbTaxClassification.SelectedIndex = 1 Then
            dgTax.DataSource = DisplayTaxMonthly()
            TxtTaxMinSalary.Text = GetMaxSalary(CbTaxClassification)
        End If
    End Sub

    Private Sub BtnSaveTax_Click(sender As Object, e As EventArgs) Handles BtnSaveTax.Click
        If CbTaxClassification.SelectedIndex = 0 Then
            If String.IsNullOrEmpty(TxtTaxFixedAmount.Text) OrElse
                String.IsNullOrEmpty(TxtTaxMaxSalary.Text) OrElse
                String.IsNullOrEmpty(TxtTaxPercentage.Text) Then
                MsgEmptyField()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtTaxMaxSalary.Text, numberOnly) Then
                MessageBox.Show("Invalid amount of max salary.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtTaxMaxSalary.Clear()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtTaxMinSalary.Text, numberOnly) Then
                MessageBox.Show("Invalid amount of min salary.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtTaxMinSalary.Clear()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtTaxFixedAmount.text, numberOnly) Then
                MessageBox.Show("Invalid amount fixed amount.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtTaxFixedAmount.Clear()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtTaxPercentage.Text, numberOnly) Then
                MessageBox.Show("Invalid value of percentage.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtTaxPercentage.Clear()
                Exit Sub
            Else
                Dim maxSalary As Decimal = Val(TxtTaxMaxSalary.Text)
                Dim minSalary As Decimal = Val(TxtTaxMinSalary.Text)
                Dim fixedAmount As Decimal = Val(TxtTaxFixedAmount.Text)
                Dim taxPercentage As Integer = Val(TxtTaxPercentage.Text)
                NewTaxDaily(minSalary, maxSalary, fixedAmount, taxPercentage)
                CbTaxClassification.SelectedIndex = 0
                dgTax.DataSource = DisplayTaxDaily()
                Dim maxSalaryOne As Decimal = GetMaxSalary(CbTaxClassification)
                TxtTaxMinSalary.Text = maxSalaryOne
                TxtTaxMaxSalary.Clear()
                TxtTaxFixedAmount.Clear()
                TxtTaxPercentage.Clear()
            End If
        ElseIf CbTaxClassification.SelectedIndex = 1 Then
            If String.IsNullOrEmpty(TxtTaxFixedAmount.Text) OrElse
            String.IsNullOrEmpty(TxtTaxMaxSalary.Text) OrElse
            String.IsNullOrEmpty(TxtTaxPercentage.Text) Then
                MsgEmptyField()
                Exit Sub
            Else
                Dim maxSalary As Decimal = Val(TxtTaxMaxSalary.Text)
                Dim minSalary As Decimal = Val(TxtTaxMinSalary.Text)
                Dim fixedAmount As Decimal = Val(TxtTaxFixedAmount.Text)
                Dim taxPercentage As Integer = Val(TxtTaxPercentage.Text)
                NewTaxMonthly(minSalary, maxSalary, fixedAmount, taxPercentage)
                CbTaxClassification.SelectedIndex = 1
                dgTax.DataSource = DisplayTaxMonthly()
                Dim maxSalaryOne As Decimal = GetMaxSalary(CbTaxClassification)
                TxtTaxMinSalary.Text = maxSalaryOne
                TxtTaxMaxSalary.Clear()
                TxtTaxFixedAmount.Clear()
                TxtTaxPercentage.Clear()
            End If
        End If
    End Sub

    Private Sub BtnDeleteTax_Click(sender As Object, e As EventArgs) Handles BtnDeleteTax.Click
        If CbTaxClassification.SelectedIndex = 0 Then
            DeleteTaxDaily()
            CbTaxClassification.SelectedIndex = 0
            dgTax.DataSource = DisplayTaxDaily()
            Dim maxSalaryOne As Decimal = GetMaxSalary(CbTaxClassification)
            TxtTaxMinSalary.Text = maxSalaryOne
            TxtTaxMaxSalary.Clear()
            TxtTaxFixedAmount.Clear()
            TxtTaxPercentage.Clear()
            Exit Sub
        ElseIf CbTaxClassification.SelectedIndex = 1 Then
            DeleteTaxMonthly()
            CbTaxClassification.SelectedIndex = 1
            dgTax.DataSource = DisplayTaxMonthly()
            Dim maxSalaryOne As Decimal = GetMaxSalary(CbTaxClassification)
            TxtTaxMinSalary.Text = maxSalaryOne
            TxtTaxMaxSalary.Clear()
            TxtTaxFixedAmount.Clear()
            TxtTaxPercentage.Clear()
        End If
    End Sub
#End Region

#Region "SSS"

    Private Sub BtnSaveSSS_Click(sender As Object, e As EventArgs) Handles BtnSaveSSS.Click
        Try
            If String.IsNullOrEmpty(TxtSSSMaxSalary.Text) OrElse
                    String.IsNullOrEmpty(TxtSSSEE.Text) OrElse
                    String.IsNullOrEmpty(TxtSSSER.Text) Then
                MsgEmptyField()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtSSSMaxSalary.Text, numberOnly) Then
                MessageBox.Show("Invalid amount of max salary.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtSSSMaxSalary.Clear()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtSSSMinSalary.text, numberOnly) Then
                MessageBox.Show("Invalid amount of minimum salary.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtSSSMinSalary.Clear()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtSSSEE.Text, numberonly) Then
                MessageBox.Show("Invalid amount of EE.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtSSSEE.Clear()
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtSSSER.Text, numberonly) Then
                MessageBox.Show("Invalid amount of ER.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtSSSER.Clear()
                Exit Sub
            ElseIf Val(TxtSSSEE.Text > 10000) Then
                MessageBox.Show("Invalid amount of EE.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtSSSEE.Clear()
                Exit Sub
            ElseIf val(TxtSSSER.Text > 10000) Then
                MessageBox.Show("Invalid amount of ER", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtSSSER.Clear()
                Exit Sub
            Else
                Dim minSalary As Decimal
                If String.IsNullOrEmpty(TxtSSSMinSalary.Text) Then
                    minSalary = 0
                Else
                    minSalary = Val(TxtSSSMinSalary.Text)
                End If
                NewSSS(minSalary, Val(TxtSSSMaxSalary.Text), Val(TxtSSSEE.Text), Val(TxtSSSER.Text))
                dgSSS.DataSource = DisplaySSS()
                Dim sssMaxSalary As Decimal = SSSGetMaxSalary()
                TxtSSSMinSalary.Text = sssMaxSalary
                TxtSSSMaxSalary.Clear()
                TxtSSSEE.Clear()
                TxtSSSER.Clear()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnDeleteSSS_Click(sender As Object, e As EventArgs) Handles BtnDeleteSSS.Click
        If dgSSS.Rows.Count = 0 Then
            MessageBox.Show("Invalid deletion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to delete this SSS?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            DeleteSSS()
            dgSSS.DataSource = DisplaySSS()
            TxtSSSMinSalary.Text = SSSGetMaxSalary()
            Exit Sub
        End If
    End Sub
#End Region

#Region "PAG-IBIG"

    Private Sub BtnSavePagIbig_Click(sender As Object, e As EventArgs) Handles BtnSavePagibig.Click
        Try
            If String.IsNullOrEmpty(TxtPagibigRate.Text) Then
                MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf Not Regex.IsMatch(TxtPagibigRate.Text, numberOnly) Then
                MessageBox.Show("Invalid rate.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtPagibigRate.Clear()
                Exit Sub
            Else
                NewPagibig(TxtPagibigRate.Text)
                dgPagibig.DataSource = DisplayPagIbig()
                TxtPagibigRate.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "PhilHealth"

    Private Sub BtnSavePhilHealth_Click(sender As Object, e As EventArgs) Handles BtnSavePhilhealth.Click
        Try
            If String.IsNullOrEmpty(txtPhilhealthRate.Text) Then
                MsgEmptyField()
                Exit Sub
            ElseIf Not Regex.IsMatch(txtPhilhealthRate.Text, numberOnly) Then
                MessageBox.Show("Invalid rate.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPhilhealthRate.Clear()
                Exit Sub
            Else
                NewPhilhealth(Convert.ToInt32(txtPhilhealthRate.Text))
                dgPhilhealth.DataSource = DisplayPhilhealth()
                txtPhilhealthRate.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


#End Region

End Class
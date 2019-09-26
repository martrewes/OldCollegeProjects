Public Class Form1
    'Delare global variable 
    Dim Tax As Decimal = 0.22
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Declare local variables
        Dim TotalIncome As Decimal
        Dim TaxPaid As Decimal
        Dim IncomeAfterTax As Decimal
        'Caculate total income
        TotalIncome = Val(txtHourRate.Text) * Val(txtHourWorked.Text)
        txtBeforeTax.Text = Format(TotalIncome, "£0.00")
        'Calculate Tax paid
        TaxPaid = TotalIncome * Tax
        txtTaxPaid.Text = Format(TaxPaid, "£0.00")
        'Calculate income after Tax
        IncomeAfterTax = TotalIncome - TaxPaid
        txtAfterTax.Text = Format(IncomeAfterTax, "£0.00")

    End Sub

    Private Sub TaxPerHour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaxPerHour.Click
        Dim TaxHour As Decimal
        Dim TaxHourText As String

        TaxHour = Val(txtHourRate.Text) * Tax
        TaxHourText = Format(TaxHour, "£0.00")
        MsgBox("You pay " & TaxHourText & " tax per hour!")

    End Sub
End Class

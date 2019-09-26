Public Class frmCarBill

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub lblLabourCharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLabourCharge.Click

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        lblLabourCharge.Text = "£" & Val(txtHourlyRate.Text) * Val(txtHoursWorked.Text)
        lblChargeParts.Text = "£" & txtCostOfParts.Text
        lblSubTotal.Text = "£" & Val(txtHourlyRate.Text) * Val(txtHoursWorked.Text) + Val(txtCostOfParts.Text)
        lblVAT.Text = "£" & (Val(txtHourlyRate.Text) * Val(txtHoursWorked.Text) + Val(txtCostOfParts.Text)) * 1.175 - (Val(txtHourlyRate.Text) * Val(txtHoursWorked.Text) + Val(txtCostOfParts.Text))
        lblTotalBill.Text = "£" & (Val(txtHourlyRate.Text) * Val(txtHoursWorked.Text) + Val(txtCostOfParts.Text)) * 1.175
    End Sub

    Private Sub txtHourlyRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHourlyRate.TextChanged
        Dim input1 = txtHourlyRate.Text


    End Sub

    Private Sub txtHoursWorked_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoursWorked.TextChanged

    End Sub

    Private Sub txtCostOfParts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCostOfParts.TextChanged

    End Sub

    Private Sub txtVatRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmCarBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

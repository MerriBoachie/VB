Public Class frmSavings
    Function calcSavings(ByVal decSavingsInput As Decimal, ByVal intMonths As Integer) As Integer
        Return (intMonths * decSavingsInput)
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decSavings As Decimal
        Dim intMonths As Integer
        Dim decTotal As Integer

        Try
            decSavings = Convert.ToDecimal(txtInput.Text)
            intMonths = Convert.ToInt32(txtInput.Text)
            decTotal = calcSavings(decSavings, intMonths)
            lblMessage.Text = "Your total savings is " & decTotal.ToString("$##.00") & "! Nice!"
        Catch ex As Exception
            MessageBox.Show("You have to enter a number!", "U dumb")
        End Try
    End Sub
End Class
Public Class frmCandy
    Private Sub myCalculate(ByVal strCandy As String, ByVal intOunces As Integer, ByVal decCost As Decimal, ByRef decAnswer As Decimal)
        decAnswer = decCost * intOunces
        lblMessage.Text = "The cost of " & intOunces & " ounces of " & strCandy & " is " & decAnswer.ToString("$##.00") & "!"
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strCandyName As String
        Dim intNumEnteredOunces As Integer
        Dim decCostEntered As Decimal
        Dim decAnswerVar As Decimal
        Try
            strCandyName = txtInput.Text
            intNumEnteredOunces = Convert.ToInt32(txtInput2.Text)
            decCostEntered = Convert.ToDecimal(txtInput3.Text)
            myCalculate(strCandyName, intNumEnteredOunces, decCostEntered, decAnswerVar)

        Catch ex As Exception
            MessageBox.Show("You have to enter the correct input!", "What...?")
        End Try
    End Sub
End Class
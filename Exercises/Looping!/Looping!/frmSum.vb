Public Class frmSum
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intInput As Integer
        Dim intSum As Integer
        Try
            intInput = Convert.ToInt32(txtSumLimit.Text)
            For intCounter As Integer = 1 To intInput
                intSum = intSum + intCounter
            Next intCounter
            lblOutput.Text = "The sum of every number from 1 to " & intInput.ToString & " is " & intSum.ToString & "!"
        Catch ex As Exception
            MessageBox.Show("Whoah whoah there! Enter a whole number!", "Jinkies!")
        End Try
    End Sub
End Class
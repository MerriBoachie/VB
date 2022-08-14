Public Class frmTimesTen
    Private Sub MultiplyByTen(ByVal intNum As Integer, ByRef intAnswer As Integer)
        'sets the answer in intAnswer's location     intAnswer = intNum * 10 
        intAnswer = intNum * 10
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim intNumberEntered As Integer
        Dim intNewNumber As Integer
        Try
            intNumberEntered = Convert.ToInt32(txtInput.Text)

            'send inNumberEntered value and intNewNumber location
            MultiplyByTen(intNumberEntered, intNewNumber)
            lblOutput.Text = intNumberEntered & " x 10 = " & intNewNumber & "!"
        Catch ex As Exception
            MessageBox.Show("Enter a number!", "You messed up >:(")
        End Try
    End Sub
End Class
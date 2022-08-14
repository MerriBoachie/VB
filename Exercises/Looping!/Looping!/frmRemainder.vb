Public Class frmRemainder
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intUpper As Integer
        Dim intDivisor As Integer
        Dim intCounter As Integer
        Try
            intUpper = Convert.ToInt32(txtInput1.Text)
            intDivisor = Convert.ToInt32(txtInput2.Text)
            For i As Integer = 1 To intUpper
                If i Mod intDivisor = 0 Then
                    intCounter = intCounter + 1
                End If
            Next i
            lblOutput.Text = "The number of integers evenly divisible by " & intDivisor.ToString & " between 1 and " & intUpper.ToString & " is " & intCounter.ToString & "!"
        Catch ex As Exception
            MessageBox.Show("Enter a whole number!", "Whoops!")
        End Try
    End Sub
End Class
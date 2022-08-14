Public Class frmCubes
    Function calcCube(ByVal intNumberInput As Integer) As Integer
        Return (intNumberInput ^ 3)
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intInput As Integer
        Dim intOutput As Integer
        Try
            intInput = Convert.ToInt32(txtInput.Text)
            intOutput = calcCube(intInput)
            lblMessage.Text = intInput & " to the third power is " & intOutput & "!"
        Catch ex As Exception
            MessageBox.Show("Enter a whole number!", "Nani?!")
        End Try
    End Sub
End Class
Public Class frmAnnoy
    Private Sub btnAnnoy_Click(sender As Object, e As EventArgs) Handles btnAnnoy.Click
        Dim intInput As Integer
        Try
            intInput = Convert.ToInt32(InputBox("How many times would you like to annoy? (Enter a number!)", "Why so whiny???"))
            For intCounter As Integer = 1 To intInput
                lblOutput.Text &= "Whine!!!!" & vbCrLf
            Next intCounter
        Catch ex As Exception
            MessageBox.Show("Enter a whole number!", "Uuuuugh!!")
        End Try
    End Sub
End Class
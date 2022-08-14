Public Class frmMints
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare
        Dim intServing As Integer
        Dim intLeft As Integer
        Dim intInput As Integer
        Try
            'Input
            intInput = Convert.ToInt32(txtEnter.Text)
            'Calculate
            intServing = (intInput) \ 3
            intLeft = (intInput) Mod 3
            'Output
            lblOutput.Text = intServing.ToString
            lblOutput2.Text = intLeft.ToString
            If intLeft = 1 Then
                lblLeftOver.Text = "There is"
                lblLeftOver2.Text = "mint left in the bag!"
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a whole number!", "You fool >:(")
        End Try
    End Sub
End Class
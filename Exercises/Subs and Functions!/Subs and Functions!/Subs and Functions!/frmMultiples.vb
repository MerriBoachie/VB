Public Class frmMultiples
    Private Sub showMultiples(ByVal intNum As Integer)
        'loop to create multiples
        For intCounter As Integer = 1 To 10
            lblOutput.Text &= intNum & "x" & intCounter & "=" & intNum * intCounter & vbCrLf
        Next intCounter
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim intInput As Integer
        Try
            intInput = Convert.ToInt32(txtNumber.Text)
            showMultiples(intInput) 'call method and send input
        Catch ex As Exception
            MessageBox.Show("Enter a number!", "Eh? I don't understand...")
        End Try
    End Sub
End Class
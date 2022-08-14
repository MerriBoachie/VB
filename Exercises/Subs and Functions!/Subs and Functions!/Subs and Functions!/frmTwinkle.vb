Public Class frmTwinkle
    Private Sub displayPoem()
        lblPoem.Text = " * . * . * . * . * . * " & vbCrLf & "Twinkle Twinkle Little Star" & vbCrLf & "How I Wonder What You Are" & vbCrLf & "Up Above The World So High" & vbCrLf & "Like a Diamond In The Sky" & vbCrLf & " * . * . * . * . * . * "
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        displayPoem()

    End Sub
End Class
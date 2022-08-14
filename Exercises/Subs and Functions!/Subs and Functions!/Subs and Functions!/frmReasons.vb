Public Class frmReasons
    Private Sub showReasons()
        lblMessage.Text = "CS teaches critical thinking!" & vbCrLf & "CS touches everyone, every day!" & vbCrLf & "CS jobs are in hight demand!"
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'call the output from the private sub
        showReasons()
    End Sub
End Class
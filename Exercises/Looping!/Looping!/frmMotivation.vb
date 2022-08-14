Public Class frmMotivation
    Private Sub btnShowMessage_Click(sender As Object, e As EventArgs) Handles btnShowMessage.Click
        Dim intLimit As Integer
        Try
            intLimit = Convert.ToInt32(txtInput.Text)
            For intCounter = 1 To intLimit
                lblMessage.Text &= "STUDY!!!" & vbCrLf
            Next intCounter
        Catch ex As Exception
            MessageBox.Show("What're you doing?? Get motivated!!!", "Nuh-uh girlfriend")
        End Try
    End Sub
    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        lblMessage.Text = " "
    End Sub

End Class
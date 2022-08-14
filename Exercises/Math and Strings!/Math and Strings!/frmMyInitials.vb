Public Class frmMyInitials

    Dim strInput As String
    Dim strFirstInitial As String
    Dim strLastInitial As String
    Dim intIndexNum As Integer

    Private Sub btnShowInitials_Click(sender As Object, e As EventArgs) Handles btnShowInitials.Click

        Try
            strInput = txtInput.Text
            strFirstInitial = strInput.Chars(0)

            intIndexNum = strInput.IndexOf(" ")

            strLastInitial = strInput.Chars(intIndexNum + 1)

            lblOutput.Text = strFirstInitial.ToUpper & strLastInitial.ToUpper & "!"
        Catch ex As Exception
            MessageBox.Show("You have to enter letters only!", "Hey- What!?!")
        End Try
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        lblOutput.Text = " "
    End Sub
End Class
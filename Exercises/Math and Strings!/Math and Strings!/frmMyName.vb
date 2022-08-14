Public Class frmMyName

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        Dim strFirstName As String
        Dim strLastName As String

        Dim strFullName As String

        Try

            strFirstName = InputBox("Enter your first name!", "What do they call you?")
            strLastName = InputBox("Enter your last name!", "What's your last name?")

            strFullName = String.Concat(strFirstName.Trim, strLastName.Trim)
            lblOutput.Text = "Your name is " & strFullName & "!"

        Catch ex As Exception
            MessageBox.Show("You have to enter letter >:(", "Stupid.")
        End Try

    End Sub
End Class
Public Class frmGuessit
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Try
            'Declare
            Dim Generator As New Random
            Static intSecretNum As Integer = Generator.Next(0, 11)
            Dim intUserGuess As Integer
            Static intTries As Integer = 0
            intTries = intTries + 1
            'Input
            intUserGuess = Convert.ToInt32(txtInput.Text)
            'Calculate and Output
            If intUserGuess = intSecretNum And intTries <= 3 Then
                lblMessage.Text = "Yay! You guessed it!"
                MessageBox.Show("You guessed the secret number- and in less than 3 tries- awesome! Your prize is a cookie!! :D", "Awesome!!!")
                Application.Exit()
            ElseIf intUserGuess = intSecretNum And intTries >= 3 Then
                lblMessage.Text = "Yay! Guessed it!"
                MessageBox.Show("You guessed the secret number- Now try for a prize! (Guess it in 3 tries or less!)", "Hooray!")
                Application.Exit()
            ElseIf intUserGuess > intSecretNum Then
                lblMessage.Text = "Oops- too high!"
            ElseIf intUserGuess < intSecretNum Then
                lblMessage.Text = "Oops- too low!"
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a whole number between 1 and 11! >:(", "You fool!!!")
        End Try
    End Sub
End Class
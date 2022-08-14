Public Class frmUnlocker
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            Dim strPassword As String
            Dim strGuess As String
            Dim intGuessCounter As Integer
            strPassword = InputBox("Set the password!", "Alright! Let's play!!!")
            Do
                strGuess = InputBox("Now try and guess the password!", "Unlock the code like a master programmer!(Enter STOP to quit!)")
                If strGuess <> strPassword Then
                    MessageBox.Show("Whoops- keep trying!", "Wrong code!")
                    intGuessCounter = intGuessCounter + 1
                End If
            Loop Until strGuess = strPassword Or strGuess = "STOP"
            If strGuess = "STOP" Then
                MessageBox.Show("Okie dokie- come back when you're ready to play!", "See ya!")
                Application.Exit()
            ElseIf strGuess = strPassword Then
                MessageBox.Show("Awesome! You guessed the code correctly! The code was " & strPassword & "! It took you " & intGuessCounter & " times to guess it correctly.", "Yay!")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("You've gotta enter a password in order to play the game!", "Yikes! An error!")
        End Try
    End Sub
End Class
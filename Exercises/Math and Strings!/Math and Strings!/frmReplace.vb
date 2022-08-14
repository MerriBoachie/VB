Public Class frmReplace

    Dim strInputWord As String
    Dim charLetterReplaced As Char
    Dim charNewLetter As Char
    Dim strNewWord As String


    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            strInputWord = txtInputWord.Text
            charLetterReplaced = txtLetterReplaced.Text
            charNewLetter = txtReplacement.Text

            strNewWord = strInputWord.Replace(charLetterReplaced, charNewLetter)
            lblOutput.Text = "You created the word " & strNewWord & "! Nice!"

        Catch ex As Exception
            MessageBox.Show("You have to enter a word in the first textbox, and a letter in the last two!", "Nani!?!?")
        End Try
    End Sub

    Private Sub txtInputWord_TextChanged(sender As Object, e As EventArgs) Handles txtInputWord.TextChanged
        lblOutput.Text = " "
    End Sub

    Private Sub txtLetterReplaced_TextChanged(sender As Object, e As EventArgs) Handles txtLetterReplaced.TextChanged
        lblOutput.Text = " "
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtReplacement.TextChanged
        lblOutput.Text = " "
    End Sub
End Class
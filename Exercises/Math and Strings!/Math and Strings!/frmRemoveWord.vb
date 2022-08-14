Public Class frmRemoveWord

    Dim strStringInput As String
    Dim strWordRemove As String
    Dim strNewPhrase As String
    Dim intIndex As Integer

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            strStringInput = txtInputPhrase.Text
            strWordRemove = txtWordRemove.Text

            intIndex = strStringInput.IndexOf(strWordRemove)

            strNewPhrase = strStringInput.Remove(intIndex, strWordRemove.Length)

            lblOutput.Text = "Your new phrase is: " & strNewPhrase
        Catch ex As Exception
            MessageBox.Show("You have to enter words!", "What're you doing???")
        End Try
    End Sub
End Class
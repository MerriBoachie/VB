Public Class frmWhichComesFirst

    Dim strInput1 As String
    Dim strInput2 As String

    Private Sub btnShowMe_Click(sender As Object, e As EventArgs) Handles btnShowMe.Click

        Try
            strInput1 = txtInput1.Text
            strInput2 = txtInput2.Text

            If String.Compare(strInput1, strInput2) = 0 Then
                lblOutput.Text = "They are both the same!"
            ElseIf String.Compare(strInput1, strInput2) < 0 Then
                lblOutput.Text = strInput1 & " comes before " & strInput2 & "!"
            ElseIf String.Compare(strInput1, strInput2) > 0 Then
                lblOutput.Text = strInput2 & " comes before " & strInput1 & "!"
            End If
        Catch ex As Exception
            MessageBox.Show("You need to enter a word!", "Huh!?")
        End Try
    End Sub

    Private Sub txtInput1_TextChanged(sender As Object, e As EventArgs) Handles txtInput1.TextChanged
        lblOutput.Text = " "
    End Sub

    Private Sub txtInput2_TextChanged(sender As Object, e As EventArgs) Handles txtInput2.TextChanged
        lblOutput.Text = " "
    End Sub
End Class
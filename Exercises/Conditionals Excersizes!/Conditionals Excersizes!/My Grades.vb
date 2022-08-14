Public Class frmMyGrades
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        'Declare
        Dim intInput As Integer
        Try
            'Input
            intInput = Convert.ToInt32(txtInput.Text)
            'Calculate (If/Then)
            If intInput >= 90 And intInput <= 100 Then
                lblMessage.Text = "You made an A- Awesome job!"
            ElseIf intInput >= 80 And intInput < 90 Then
                lblMessage.Text = "You made a B- Great!"
            ElseIf intInput >= 70 And intInput < 80 Then
                lblMessage.Text = "You made a C- Not bad!"
            ElseIf intInput >= 60 And intInput < 70 Then
                lblMessage.Text = "You made a D- Keep working! :o"
            ElseIf intInput < 50 Then
                lblMessage.Text = "Uhhh, you made an F...You really should study more.... ^^'"
            End If
        Catch ex As Exception
            If intInput < 0 Or intInput > 100 Then
                MessageBox.Show("Enter a number between 1 and 100!", "Whoops ^^'")
            End If
        End Try
    End Sub
End Class
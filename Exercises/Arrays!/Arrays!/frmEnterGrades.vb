Public Class frmEnterGrades
    Dim arrGrades(4) As Integer
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Try
            For intCounter As Integer = 0 To arrGrades.Length - 1
                arrGrades(intCounter) = Convert.ToInt32(InputBox("Enter your grade percentage!", "Grade number " & (intCounter + 1) & "!"))
            Next intCounter
        Catch ex As Exception
            MessageBox.Show("You have to enter a whole number!", "Hey! What are you doing!?")
        End Try
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        For intCounter As Integer = 0 To arrGrades.Length - 1
            lblMessage.Text &= "Your grade is a " & arrGrades(intCounter).ToString & " percent!" & vbCrLf
        Next intCounter
    End Sub
End Class
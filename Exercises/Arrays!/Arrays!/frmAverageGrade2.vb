Public Class frmAverageGrade2
    Dim arrGrades(4) As Integer
    Dim intTotal As Integer

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Try
            For intCounter As Integer = 0 To arrGrades.Length - 1
                arrGrades(intCounter) = Convert.ToInt32(InputBox("Enter your grade percentage!", "Grade number " & (intCounter + 1) & "!"))
                intTotal = intTotal + arrGrades(intCounter)
            Next intCounter
        Catch ex As Exception
            MessageBox.Show("You have to enter a whole number!", "Hey! What are you doing!?")
        End Try
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intAverage As Integer
        intAverage = intTotal / 5
        lblMessage.Text = "The average of the 5 grades is " & intAverage & "!"

    End Sub
End Class
Public Class frmRandomGrades
    Dim arrGrades(0) As Integer
    Dim intTotal As Integer
    Dim intInputNum As Integer

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        intInputNum = Convert.ToInt32(InputBox("How many grades are you entering?", "How many?"))
        ReDim arrGrades(intInputNum - 1)
        Try
            For intCounter As Integer = 0 To arrGrades.Length - 1
                arrGrades(intCounter) = Convert.ToInt32(InputBox("Enter your grade percentage!", "Grade number " & (intCounter + 1) & "!"))
                intTotal = intTotal + arrGrades(intCounter)
            Next intCounter
        Catch ex As Exception
            MessageBox.Show("You have to enter a whole number!", "Hey! What are you doing!?")
        End Try
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblAverage As Double
        dblAverage = intTotal / intInputNum
        lblMessage.Text = "The average of the " & intInputNum.ToString & " grades is " & dblAverage.ToString & "!"
    End Sub
End Class
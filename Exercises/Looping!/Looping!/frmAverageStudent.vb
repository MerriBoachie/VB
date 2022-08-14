Public Class frmAverageStudent
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim intInput As Integer
        Dim intAverage As Integer
        Dim intTotal As Integer
        Try
            For intCounter As Integer = 9 To 12
                intInput = Convert.ToInt32(InputBox("Enter the number of students in this grade!", "Gathering info..."))
                lblOutput.Text &= "There are " & intInput.ToString & " students in grade " & intCounter.ToString & "!" & vbCrLf
                intTotal = intTotal + intInput
            Next intCounter
            intAverage = intTotal / 4
            lblOutput.Text &= "The average number of students in each grade is " & intAverage & "!"
        Catch ex As Exception
            MessageBox.Show("You can't have a piece of a student- enter a whole number!!", "Eh???")
        End Try
    End Sub
End Class
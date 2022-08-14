Public Class frmGradeAverage_
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculateFor.Click
        'For loop
        Try
            Dim intGradeInput As Integer
            Dim intAverage As Double
            Dim intSum As Integer
            For intCounter = 1 To 5
                intGradeInput = Convert.ToInt32(InputBox("Enter a grade!! (You'll enter five total!)", "I'll help you find your average!"))
                intSum = intSum + intGradeInput
                lblMessage.Text &= vbCrLf & "You entered " & intGradeInput & "!"
            Next intCounter
            intAverage = intSum / 5
            lblMessage.Text = vbCrLf & "Your grade average is " & intAverage & "!"
        Catch ex As Exception
            MessageBox.Show("Enter a whole number!", "Eh? Nani???")
        End Try
    End Sub

    Private Sub btnCalculateDo_Click(sender As Object, e As EventArgs) Handles btnCalculateDo.Click
        'Do loop
        Try
            Dim intGradeInput As Integer
            Dim intAverage As Double
            Dim intSum As Integer
            Dim intCounter As Integer
            Do While intCounter < 5
                intGradeInput = Convert.ToInt32(InputBox("Enter a grade!! (You'll enter five total!)", "I'll help you find your average!"))
                intSum = intSum + intGradeInput
                lblMessage.Text &= vbCrLf & "You entered " & intGradeInput & "!"
                intCounter = intCounter + 1
            Loop
            intAverage = intSum / 5
            lblMessage.Text = vbCrLf & "Your grade average is " & intAverage & "!"
        Catch ex As Exception
            MessageBox.Show("Enter a whole number!", "Eh? Nani???")
        End Try
    End Sub
End Class
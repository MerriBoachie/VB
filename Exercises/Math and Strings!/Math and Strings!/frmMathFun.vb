Public Class frmMathFun


    Private Sub AbsoluteValueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsoluteValueToolStripMenuItem.Click

        Try

            Dim dblNumInputAbs As Double = Convert.ToDouble(txtInput.Text)
            Dim dblNumOutputAbs As Double

            dblNumOutputAbs = Math.Abs(dblNumInputAbs)
            lblOutput.Text = "The absolute value of " & Convert.ToString(dblNumInputAbs) & " is " & Convert.ToString(dblNumOutputAbs) & "!"

        Catch ex As Exception
            MessageBox.Show("Enter a number!", "Eh???")
        End Try

    End Sub

    Private Sub SquareRootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SquareRootToolStripMenuItem.Click

        Try

            Dim dblNumInputSqrt As Double = Convert.ToDouble(txtInput.Text)
            Dim dblNumOutputSqrt As Double

            dblNumOutputSqrt = Math.Sqrt(dblNumInputSqrt)
            lblOutput.Text = "The square root of " & Convert.ToString(dblNumInputSqrt) & " is " & Convert.ToString(dblNumOutputSqrt) & "!"

        Catch ex As Exception
            MessageBox.Show("Enter a number!", "Eh???")
        End Try

    End Sub

    Private Sub SignToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignToolStripMenuItem.Click

        Try


            Dim dblNumInputSign As Double = Convert.ToDouble(txtInput.Text)
            Dim dblNumOutputSign As Double

            dblNumOutputSign = Math.Sign(dblNumInputSign)
            lblOutput.Text = "The sign of " & Convert.ToString(dblNumInputSign) & " is " & Convert.ToString(dblNumOutputSign) & "!"

        Catch ex As Exception
            MessageBox.Show("Enter a number!", "Eh???")
        End Try

    End Sub

    Private Sub RoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoundToolStripMenuItem.Click

        Try


            Dim dblNumInputRound As Double = Convert.ToDouble(txtInput.Text)
            Dim dblNumOutputRound As Double
            Dim intRoundPlaces As Integer

            intRoundPlaces = InputBox("Enter the number of decimals that you would like to round to!", "How many?")

            dblNumOutputRound = Math.Round(dblNumInputRound, intRoundPlaces)
            lblOutput.Text = Convert.ToString(dblNumInputRound) & " rounded to " & intRoundPlaces & " places is " & Convert.ToString(dblNumOutputRound) & "!"

        Catch ex As Exception
            MessageBox.Show("Enter a number!", "Eh???")
        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        lblOutput.Text = " "
    End Sub
End Class
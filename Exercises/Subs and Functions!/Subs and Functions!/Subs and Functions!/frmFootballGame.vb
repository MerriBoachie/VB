Public Class frmFootballGame
    Function calcTotal(ByVal intScore1 As Integer, ByVal intScore2 As Integer, ByVal intScore3 As Integer, ByVal intScore4 As Integer) As Integer
        Return (intScore1 + intScore2 + intScore3 + intScore4)
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intInput1 As Integer
        Dim intInput2 As Integer
        Dim intInput3 As Integer
        Dim intInput4 As Integer
        Dim intTotal As Integer
        Try
            intInput1 = Convert.ToInt32(txtInput1.Text)
            intInput2 = Convert.ToInt32(txtInput2.Text)
            intInput3 = Convert.ToInt32(txtInput3.Text)
            intInput4 = Convert.ToInt32(txtInput4.Text)

            intTotal = calcTotal(intInput1, intInput2, intInput3, intInput4)
            lblMessage.Text = "The total score of the four quarters is " & intTotal & "!"

        Catch ex As Exception
            MessageBox.Show("You have to enter a number!", "I don't get it :(")

        End Try

    End Sub
End Class
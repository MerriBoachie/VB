Public Class frmPowerof2
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        For intCounter = 1 To 10
            lblOutput.Text &= "2 to the " & intCounter.ToString & "  is " & 2 ^ intCounter.ToString & " !" & vbCrLf
        Next intCounter
    End Sub
    'Array Declaration (Global)
    Dim arrPowers(9) As Integer
    Private Sub btnArray_Click(sender As Object, e As EventArgs) Handles btnArray.Click
        For i As Integer = 0 To arrPowers.Length - 1
            arrPowers(i) = 2 ^ (i + 1)
            lblOutput.Text &= "2 to the power of " & (i + 1).ToString & " is " & arrPowers(i).ToString & "!" & vbCrLf
        Next i
    End Sub
End Class
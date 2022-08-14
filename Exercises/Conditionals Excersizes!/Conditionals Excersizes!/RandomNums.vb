Public Class frmRandomNums
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim dblVariable As Double
        Dim intVariable As Integer
        Dim intVariable2 As Integer
        Dim intVariable3 As Integer

        Dim genNumber As New Random

        dblVariable = genNumber.NextDouble
        intVariable = genNumber.Next
        intVariable2 = genNumber.Next(100)
        intVariable3 = genNumber.Next(10, 50)
        lblOutput.Text = "Here ya go!" & vbCrLf & dblVariable & vbCrLf & intVariable & vbCrLf & intVariable2 & vbCrLf & intVariable3
    End Sub
End Class
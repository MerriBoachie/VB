Public Class frmChoccyMilk
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare
        Dim intInput As Integer
        Dim intServings As Integer
        Dim intLeftOver As Integer
        'Input
        intInput = Convert.ToInt32(txtInput.Text)
        'Calculate
        intServings = intInput \ 8
        intLeftOver = intInput Mod 8
        'Output
        lblServings.Text = intInput & " ounces is " & intServings & " servings of chocolate milk!"
        lblLeftOver.Text = "There are " & intLeftOver & " ounces left over!"
    End Sub
End Class
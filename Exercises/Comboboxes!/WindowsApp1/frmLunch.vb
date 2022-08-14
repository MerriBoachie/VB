Public Class frmLunch
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblDrinkCost As Double
        Dim dblFoodCost As Double
        Dim dblTax As Double
        Dim dblTotal As Double
        Try
            If lstChoices.Text = "Chef Salad" Then
                dblFoodCost = 3.99
            ElseIf lstChoices.Text = "Garden Salad" Then
                dblFoodCost = 2.99
            ElseIf lstChoices.Text = "Hamburger" Then
                dblFoodCost = 2.99
            ElseIf lstChoices.Text = "Cheeseburger" Then
                dblFoodCost = 3.49
            ElseIf lstChoices.Text = "Chicken Sandwich" Then
                dblFoodCost = 3.99
            End If

            If cboDrinkSize.Text = "Small!" Then
                dblDrinkCost = 0.99
            ElseIf cboDrinkSize.Text = "Medium!!" Then
                dblDrinkCost = 1.49
            ElseIf cboDrinkSize.Text = "Large!!!" Then
                dblDrinkCost = 1.99
            End If
            dblTax = (dblFoodCost + dblDrinkCost) * 0.07
            dblTotal = dblDrinkCost + dblFoodCost + dblTax
            lblMessage.Text = "You ordered a " & lstChoices.Text & " with a " & cboDrinkSize.Text & " " & cboDrinkChoices.Text & "! Your total is " & dblTotal.ToString("$##.00") & "!"
        Catch ex As Exception
            MessageBox.Show("Enter one of the options!", "Oops!")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("I hope you enjoyed your food! :D", "Later!")
        Me.Close()
    End Sub
End Class
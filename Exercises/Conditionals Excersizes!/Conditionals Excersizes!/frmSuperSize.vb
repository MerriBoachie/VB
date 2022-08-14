Public Class frmSuperSize
    Dim decSubTotal As Decimal
    Dim decTotal As Decimal
    Dim genNumber As New Random
    Dim intNumber As Integer = genNumber.Next(100, 1000)
    Private Sub chhkHamburger_CheckedChanged(sender As Object, e As EventArgs) Handles chkHamburger.CheckedChanged
        If chkHamburger.Checked Then
            decSubTotal = decSubTotal + 2.95
        Else
            decSubTotal = decSubTotal - 2.95
            lblNumber.Text = " "
            lblMessage.Text = " "
        End If
    End Sub

    Private Sub radFries_CheckedChanged(sender As Object, e As EventArgs) Handles chkFries.CheckedChanged
        If chkFries.Checked Then
            decSubTotal = decSubTotal + 1.95
        Else
            decSubTotal = decSubTotal - 1.95
            lblNumber.Text = " "
            lblMessage.Text = " "
        End If
    End Sub

    Private Sub chkCheese_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheese.CheckedChanged
        If chkCheese.Checked Then
            decSubTotal = decSubTotal + 3.95
        Else
            decSubTotal = decSubTotal - 3.95
            lblNumber.Text = " "
            lblMessage.Text = " "
        End If
    End Sub

    Private Sub chkOnion_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnion.CheckedChanged
        If chkOnion.Checked Then
            decSubTotal = decSubTotal + 2.5
        Else
            decSubTotal = decSubTotal - 2.5
            lblNumber.Text = " "
            lblMessage.Text = " "
        End If
    End Sub

    Private Sub radSuperSize_CheckedChanged(sender As Object, e As EventArgs) Handles radSuperSize.CheckedChanged
        If radSuperSize.Checked Then
            decSubTotal = decSubTotal + 2.0
        Else
            decSubTotal = decSubTotal - 2.0
            lblNumber.Text = " "
            lblMessage.Text = " "
        End If
    End Sub

    Private Sub btnPlace_Click(sender As Object, e As EventArgs) Handles btnPlace.Click
        decTotal = decSubTotal * 1.07
        lblNumber.Text = "Your order number is " & intNumber & "!"
        lblMessage.Text = "Your total is " & decTotal.ToString("$##.00") & "! Have a great day!"
    End Sub
End Class
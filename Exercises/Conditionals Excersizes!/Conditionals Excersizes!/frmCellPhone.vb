Public Class frmCellPhone
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim intMin As Decimal = 0
        Const decFee As Decimal = 9.95
        Dim decCost As Decimal = 0
        Dim decTotal As Decimal = 0
        Dim decTax As Integer = 0
        Dim decSubTotal As Decimal = 0
        Try
            intMin = Convert.ToInt32(txtInput.Text)
            Select Case intMin
                Case < 201
                    decCost = 0
                Case 201 To 300
                    decCost = intMin * 0.17
                Case 301 To 500
                    decCost = intMin * 0.15
                Case >= 501
                    decCost = intMin * 0.12
            End Select
            decSubTotal = decCost + decFee
            decTax = decSubTotal * 0.07
            decTotal = decSubTotal + decTax
            lblMessage.Text = "Here is your reciept!" & vbCrLf & "Regular Price: " & decFee.ToString("$##.00") & vbCrLf & "Minutes cost: " & decCost.ToString("$##.00") & vbCrLf & "Sub-Total: " & decSubTotal.ToString("$##.00") & vbCrLf & "Tax: " & decTax.ToString("$##.00") & vbCrLf & "Total: " & decTotal.ToString("$##.00")
        Catch ex As Exception
            MessageBox.Show("Enter a whole number please!", "Oh no!")
        End Try

    End Sub
End Class
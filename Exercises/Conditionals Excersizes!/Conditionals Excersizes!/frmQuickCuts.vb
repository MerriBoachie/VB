Public Class frmQuickCuts
    Dim decTotoal As Decimal = 0
    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        lblMessage.Text = "Your total cost is " & decTotoal.ToString("$##.00") & "!"
    End Sub

    Private Sub chkHairCut_CheckedChanged(sender As Object, e As EventArgs) Handles chkHairCut.CheckedChanged
        If chkHairCut.Checked Then
            decTotoal = decTotoal + 9.95
        Else
            decTotoal = decTotoal - 9.95
        End If
    End Sub

    Private Sub ChkShampoo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShampoo.CheckedChanged
        If ChkShampoo.Checked Then
            decTotoal = decTotoal + 3.95
        Else
            decTotoal = decTotoal - 3.95
        End If
    End Sub

    Private Sub chkStyle_CheckedChanged(sender As Object, e As EventArgs) Handles chkStyle.CheckedChanged
        If chkStyle.Checked Then
            decTotoal = decTotoal + 5.95
        Else
            decTotoal = decTotoal - 5.95
        End If
    End Sub

    Private Sub chkMassage_CheckedChanged(sender As Object, e As EventArgs) Handles chkMassage.CheckedChanged
        If chkMassage.Checked Then
            decTotoal = decTotoal + 2.95
        Else
            decTotoal = decTotoal - 2.95
        End If
    End Sub
End Class
Public Class frmMath
    Private Sub btnNumber1_Click(sender As Object, e As EventArgs) Handles btnNumber1.Click
        lblNumber1.Text = 6 + 3 / 2
    End Sub

    Private Sub btnNumber2_Click(sender As Object, e As EventArgs) Handles btnNumber2.Click
        lblNumber2.Text = (6 + 3) / 2
    End Sub

    Private Sub btnNumber3_Click(sender As Object, e As EventArgs) Handles btnNumber3.Click
        lblNumber3.Text = 9 * 2 / 5
    End Sub

    Private Sub btnNumber4_Click(sender As Object, e As EventArgs) Handles btnNumber4.Click
        lblNumber4.Text = 9.0 * 2 / 5
    End Sub

    Private Sub btnNumber5_Click(sender As Object, e As EventArgs) Handles btnNumber5.Click
        lblNumber5.Text = 7 / 2
    End Sub

    Private Sub btnNumber6_Click(sender As Object, e As EventArgs) Handles btnNumber6.Click
        lblNumber6.Text = 7 \ 2
    End Sub

    Private Sub btnNumber7_Click(sender As Object, e As EventArgs) Handles btnNumber7.Click
        lblNumber7.Text = 7 Mod 2
    End Sub
End Class
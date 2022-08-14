Public Class frmLooping
    Private Sub btnHeckYeah_Click(sender As Object, e As EventArgs) Handles btnHeckYeah.Click
        lblDoIt.Text = "Lets do it!!!"
    End Sub

    Private Sub btnPowerOf2_Click(sender As Object, e As EventArgs) Handles btnPowerOf2.Click
        frmPowerof2.Show()
    End Sub

    Private Sub btnMotivation_Click(sender As Object, e As EventArgs) Handles btnMotivation.Click
        frmMotivation.Show()
    End Sub

    Private Sub btnAvgGrade_Click(sender As Object, e As EventArgs) Handles btnAvgGrade.Click
        frmGradeAverage_.Show()
    End Sub

    Private Sub btnRemainder_Click(sender As Object, e As EventArgs) Handles btnRemainder.Click
        frmRemainder.Show()
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        frmSum.Show()
    End Sub

    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        frmUnlocker.Show()
    End Sub

    Private Sub btnAnnoy_Click(sender As Object, e As EventArgs) Handles btnAnnoy.Click
        frmAnnoy.Show()
    End Sub

    Private Sub btnAverageStudents_Click(sender As Object, e As EventArgs) Handles btnAverageStudents.Click
        frmAverageStudent.Show()
    End Sub
End Class

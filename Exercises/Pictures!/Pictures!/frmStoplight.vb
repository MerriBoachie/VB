Public Class frmStoplight
    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        Me.picStoplight.Image = My.Resources.stopLightRed
        lblMessage.Text = "stop! STop!! STOPP!!! DD:"
    End Sub

    Private Sub btnYellow_Click(sender As Object, e As EventArgs) Handles btnYellow.Click
        Me.picStoplight.Image = My.Resources.stopLightYellow
        lblMessage.Text = "Slow down! Slow down! :O"
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        Me.picStoplight.Image = My.Resources.stopLightGreen
        lblMessage.Text = "Go! Go! Go! >:DD"
    End Sub
End Class
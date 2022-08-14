'Game over Screen Code

Public Class frmGameOver

    'Public variable to get score from game form
    Public intScore As Integer

    Private Sub btnTitle_Click(sender As Object, e As EventArgs) Handles btnTitle.Click

        'Hide form if player clicks Back To Title
        Me.Hide()

    End Sub

    Private Sub frmGameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set intScore value to score value from game form
        intScore = frmGame.intScoreHold

        'Display this in label
        lblScoreIs.Text = "Your score is " & intScore & "."

    End Sub
End Class
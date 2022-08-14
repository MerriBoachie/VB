Public Class frmShapes
    Private Sub StarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StarToolStripMenuItem.Click
        BackgroundImage = My.Resources.blueCircle
    End Sub

    Private Sub StarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StarToolStripMenuItem1.Click
        BackgroundImage = My.Resources.purpleStar
    End Sub

    Private Sub SquareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SquareToolStripMenuItem.Click
        BackgroundImage = My.Resources.redSq
    End Sub

    Private Sub TriangleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TriangleToolStripMenuItem.Click
        BackgroundImage = My.Resources.greenTriangle
    End Sub

    Private Sub BackToNormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToNormalToolStripMenuItem.Click
        BackgroundImage = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    'Buttons
    Private Sub btnStoplight_Click(sender As Object, e As EventArgs) Handles btnStoplight.Click
        frmStoplight.Show()
    End Sub

    Private Sub btnMoveMe_Click(sender As Object, e As EventArgs) Handles btnMoveMe.Click
        frmMoveMe.Show()
    End Sub

    Private Sub btnKicks_Click(sender As Object, e As EventArgs) Handles btnKicks.Click
        frmKicks.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTalking.Click
        frmChat.Show()
    End Sub

    Private Sub btnDance_Click(sender As Object, e As EventArgs) Handles btnDance.Click
        frmDance.Show()
    End Sub
End Class

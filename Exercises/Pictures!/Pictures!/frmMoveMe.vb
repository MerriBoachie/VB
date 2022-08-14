Public Class frmMoveMe

    Private Sub tmrAcross_Tick(sender As Object, e As EventArgs) Handles tmrAcross.Tick
        Dim ptAcrossNew As Point

        ptAcrossNew.X = picCorgi.Location.X + 5
        ptAcrossNew.Y = picCorgi.Location.Y
        picCorgi.Location = ptAcrossNew
        lblMessage.Location = ptAcrossNew
    End Sub

    Private Sub btnAcross_Click(sender As Object, e As EventArgs) Handles btnAcross.Click
        tmrAcross.Start()
        lblMessage.Text = "See ya!"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ptOriginal As Point

        tmrAcross.Stop()
        tmrDown.Stop()
        tmrDiagonal.Stop()

        ptOriginal.X = picCorgi.Location.X = 12
        ptOriginal.Y = picCorgi.Location.Y = 12
        picCorgi.Location = ptOriginal
        lblMessage.Location = ptOriginal
        lblMessage.Text = "Hello! :3"
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        tmrDown.Start()
        tmrAcross.Stop()
        lblMessage.Text = "Bombs away!"
    End Sub

    Private Sub tmrDown_Tick(sender As Object, e As EventArgs) Handles tmrDown.Tick
        Dim ptDownNew As Point

        ptDownNew.X = picCorgi.Location.X
        ptDownNew.Y = picCorgi.Location.Y + 5
        picCorgi.Location = ptDownNew
        lblMessage.Location = ptDownNew
    End Sub

    Private Sub tmrDiagonal_Tick(sender As Object, e As EventArgs) Handles tmrDiagonal.Tick
        Dim ptDiagonalNew As Point

        ptDiagonalNew.X = picCorgi.Location.X + 5
        ptDiagonalNew.Y = picCorgi.Location.Y + 5
        picCorgi.Location = ptDiagonalNew
        lblMessage.Location = ptDiagonalNew
    End Sub

    Private Sub btnDiagonal_Click(sender As Object, e As EventArgs) Handles btnDiagonal.Click
        tmrDiagonal.Start()
        lblMessage.Text = "Woah! :0"
    End Sub
End Class
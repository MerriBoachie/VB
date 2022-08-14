Public Class frmDrawShip
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        Dim DrawSurface As Graphics = lblSurface.CreateGraphics

        Dim penBlack As New Pen(Color.Black, 2)

        DrawSurface.DrawLine(penBlack, 368, 170, 389, 205)
        DrawSurface.DrawLine(penBlack, 389, 205, 421, 222)
        DrawSurface.DrawLine(penBlack, 421, 222, 410, 193)
        DrawSurface.DrawLine(penBlack, 410, 193, 395, 170)
        DrawSurface.DrawLine(penBlack, 401, 170, 405, 145)
        DrawSurface.DrawLine(penBlack, 405, 145, 405, 120)
        DrawSurface.DrawLine(penBlack, 405, 120, 368, 170)
        DrawSurface.DrawLine(penBlack, 405, 120, 421, 109)
        DrawSurface.DrawLine(penBlack, 421, 109, 444, 95)
        DrawSurface.DrawLine(penBlack, 444, 95, 469, 80)
        DrawSurface.DrawLine(penBlack, 469, 80, 499, 70)
        DrawSurface.DrawLine(penBlack, 499, 70, 515, 72)
        DrawSurface.DrawLine(penBlack, 515, 72, 537, 80)
        DrawSurface.DrawLine(penBlack, 537, 80, 564, 95)
        DrawSurface.DrawLine(penBlack, 564, 95, 587, 120)
        DrawSurface.DrawLine(penBlack, 587, 120, 606, 135)
    End Sub
End Class
Public Class frmDrawingShapes
    Private Sub btnDrawShip_Click(sender As Object, e As EventArgs) Handles btnDrawShip.Click
        frmDrawShip.Show()
    End Sub

    Private Sub btnDrawShapes_Click(sender As Object, e As EventArgs) Handles btnDrawShapes.Click

        Dim LabelSurface As Graphics = lblSurface.CreateGraphics

        Dim penYellow As New Pen(Color.Gold, 4)
        Dim penBrown As New Pen(Color.SaddleBrown, 4)
        Dim penRed As New Pen(Color.Red, 4)
        Dim penBlack As New Pen(Color.Black, 4)
        Dim penLightBlue As New Pen(Color.PowderBlue, 4)

        LabelSurface.DrawEllipse(penLightBlue, 369, 127, 50, 50)
        LabelSurface.DrawEllipse(penLightBlue, 307, 127, 50, 50)

        LabelSurface.DrawEllipse(penBlack, 307, 347, 50, 50)
        LabelSurface.DrawEllipse(penBlack, 404, 347, 50, 50)

        LabelSurface.DrawArc(penYellow, 317, 189, 100, 50, 0, 180)

        LabelSurface.DrawRectangle(penYellow, 277, 64, 171, 172)
        LabelSurface.DrawRectangle(penBrown, 277, 242, 171, 43)
        LabelSurface.DrawLine(penYellow, 261, 175, 191, 102)
        LabelSurface.DrawLine(penYellow, 454, 175, 521, 102)
        LabelSurface.DrawLine(penYellow, 307, 291, 307, 347)
        LabelSurface.DrawLine(penYellow, 404, 291, 404, 347)
        LabelSurface.DrawLine(penYellow, 296, 162, 353, 162)

        lblMessage.Text = "Spangebob Square"
    End Sub
End Class

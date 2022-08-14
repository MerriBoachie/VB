Public Class frmKicks
    Private Sub tmrKick_Tick(sender As Object, e As EventArgs) Handles tmrKick.Tick
        tmrKick.Start()
        Static intPicNum As Integer
        If intPicNum = 0 Then
            picStickFigure.Image = My.Resources.stand
            intPicNum = 1
        ElseIf intPicNum = 1 Then
            picStickFigure.Image = My.Resources.leftFootUp
            intPicNum = 2
        ElseIf intPicNum = 2 Then
            picStickFigure.Image = My.Resources.rtFootUp
            intPicNum = 0
        End If
    End Sub
End Class
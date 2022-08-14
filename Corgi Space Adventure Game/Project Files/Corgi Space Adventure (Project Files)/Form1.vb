'Merrietta Boachie
'Corgi Space Adventure
'Game; User flies through space as a corgi, dodging objects and collecting treats

'Title Screen code

Public Class frmTitleScreen

    'Code to play a barking animation when player clicks on the title sprite
    Private Sub picCorgiTitleSprite_Click(sender As Object, e As EventArgs) Handles picCorgiTitleSprite.Click
        tmrBark.Start()
    End Sub

    'Timertick for bark animation
    Private Sub tmrBark_Tick(sender As Object, e As EventArgs) Handles tmrBark.Tick
        Static intPicNum As Integer

        If intPicNum = 0 Then
            picCorgiTitleSprite.Image = My.Resources.SpaceCorgiBark1
            intPicNum = 1
        ElseIf intPicNum = 1 Then
            picCorgiTitleSprite.Image = My.Resources.SpaceCorgiBark2
            intPicNum = 2
        ElseIf intPicNum = 2 Then
            picCorgiTitleSprite.Image = My.Resources.SpaceCorgiBark3
            intPicNum = 3
        ElseIf intPicNum = 3 Then
            picCorgiTitleSprite.Image = My.Resources.SpaceCorgiBark4
            intPicNum = 4
        ElseIf intPicNum = 4 Then
            picCorgiTitleSprite.Image = My.Resources.SpaceCorgiBark5
            intPicNum = 5
        ElseIf intPicNum = 5 Then
            picCorgiTitleSprite.Image = My.Resources.SpaceCorgiBark6
            intPicNum = 6
        ElseIf intPicNum = 6 Then
            intPicNum = 0

            tmrBark.Stop()
            picCorgiTitleSprite.Image = My.Resources.SpaceCorgiTitleDog
        End If
    End Sub

    'Start button- begins game 
    Private Sub btnGameStart_Click(sender As Object, e As EventArgs) Handles btnGameStart.Click
        frmGame.Show()
    End Sub
End Class

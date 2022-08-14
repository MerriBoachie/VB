Public Class frmChat
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmrTalk.Stop()
        lblMessage.Text = " "
        picTalk.Image = My.Resources.Face1
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrTalk.Start()
        lblMessage.Text = "Study! Study!! Study!!! Study!!!! Study!!!!!"
    End Sub

    Private Sub tmrTalk_Tick(sender As Object, e As EventArgs) Handles tmrTalk.Tick

        Static intPicNum As Integer
        If intPicNum = 0 Then
            picTalk.Image = My.Resources.Face1
            intPicNum = 1
        ElseIf intPicNum = 1 Then
            picTalk.Image = My.Resources.Face2
            intPicNum = 2
        ElseIf intPicNum = 2 Then
            picTalk.Image = My.Resources.Face3
            intPicNum = 3
        ElseIf intPicNum = 3 Then
            picTalk.Image = My.Resources.Face2
            intPicNum = 0
        End If

    End Sub
End Class
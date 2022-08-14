Public Class frmDance
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start Dancing!" Then
            tmrDance.Start()
            btnStart.Text = "Stop Dancing!"
        ElseIf btnStart.Text = "Stop Dancing!" Then
            tmrDance.Stop()
            btnStart.Text = "Start Dancing!"
            picDance.Image = My.Resources.win_1
        End If
    End Sub

    Private Sub tmrDance_Tick(sender As Object, e As EventArgs) Handles tmrDance.Tick
        Static intPicNum As Integer

        If intPicNum = 0 Then
            picDance.Image = My.Resources.win_2
            intPicNum = 1
        ElseIf intPicNum = 1 Then
            picDance.Image = My.Resources.win_3
            intPicNum = 2
        ElseIf intPicNum = 2 Then
            picDance.Image = My.Resources.win_4
            intPicNum = 3
        ElseIf intPicNum = 3 Then
            picDance.Image = My.Resources.win_5
            intPicNum = 4
        ElseIf intPicNum = 4 Then
            picDance.Image = My.Resources.win_6
            intPicNum = 5
        ElseIf intPicNum = 5 Then
            picDance.Image = My.Resources.win_7
            intPicNum = 6
        ElseIf intPicNum = 6 Then
            picDance.Image = My.Resources.win_8
            intPicNum = 7
        ElseIf intPicNum = 7 Then
            picDance.Image = My.Resources.win_9
            intPicNum = 8
        ElseIf intPicNum = 8 Then
            picDance.Image = My.Resources.win_10
            intPicNum = 9
        ElseIf intPicNum = 9 Then
            picDance.Image = My.Resources.win_11
            intPicNum = 10
        ElseIf intPicNum = 10 Then
            picDance.Image = My.Resources.win_12
            intPicNum = 11
        ElseIf intPicNum = 11 Then
            picDance.Image = My.Resources.win_13
            intPicNum = 12
        ElseIf intPicNum = 12 Then
            picDance.Image = My.Resources.win_14
            intPicNum = 13
        ElseIf intPicNum = 13 Then
            picDance.Image = My.Resources.win_15
            intPicNum = 14
        ElseIf intPicNum = 14 Then
            picDance.Image = My.Resources.win_16
            intPicNum = 0
        End If
    End Sub
End Class
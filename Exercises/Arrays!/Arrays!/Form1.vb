Public Class frmArrays
    Private Sub btnPrompt_Click(sender As Object, e As EventArgs) Handles btnPrompt.Click
        Dim genPhrases As New Random
        Dim intPhraseNumber As Integer

        intPhraseNumber = genPhrases.Next(1, 5)

        If intPhraseNumber = 1 Then
            lblMessage.Text = "Yeah!"
        ElseIf intPhraseNumber = 2 Then
            lblMessage.Text = "Heck yeah!!!"
        ElseIf intPhraseNumber = 3 Then
            lblMessage.Text = "Let's do it!!"
        ElseIf intPhraseNumber = 4 Then
            lblMessage.Text = "Okay!!!!"
        End If
    End Sub

    Private Sub btnFriends_Click(sender As Object, e As EventArgs) Handles btnFriends.Click
        frmFriends.Show()
    End Sub

    Private Sub btnEnterGrades_Click(sender As Object, e As EventArgs) Handles btnEnterGrades.Click
        frmEnterGrades.Show()
    End Sub

    Private Sub btnAverageGrade_Click(sender As Object, e As EventArgs) Handles btnAverageGrade.Click
        frmAverageGrade2.Show()
    End Sub

    Private Sub btnRandomGrades_Click(sender As Object, e As EventArgs) Handles btnRandomGrades.Click
        frmRandomGrades.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmFindName.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnShowFoods.Click
        frmShowFoods.Show()
    End Sub
End Class

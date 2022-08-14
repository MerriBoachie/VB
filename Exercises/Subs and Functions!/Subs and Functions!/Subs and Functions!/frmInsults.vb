Public Class frmInsults
    Private Sub showInsult(ByVal intRandom As Integer, ByRef strOffend As String)
        If intRandom = 1 Then
            lblMessage.Text = " I think he be transformed into a beast; for I can nowhere find him like a man ~ As You Like It "
        ElseIf intRandom = 2 Then
            lblMessage.Text = "Lets meet as little as we can ~ As You Like It "
        ElseIf intRandom = 3 Then
            lblMessage.Text = "I desire that we be better strangers ~ As You Like It"
        ElseIf intRandom = 4 Then
            lblMessage.Text = "Boys, apes, braggarts, jacks, milksops! ~ Much Ado About Nothing"
        ElseIf intRandom = 5 Then
            lblMessage.Text = "This is the silliest stuff that I ever heard ~ A Midsummer Night's Dream"
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim gen As New Random

        Dim intInsultNum As Integer = gen.Next(1, 6)
        Dim strInsult As String

        showInsult(intInsultNum, strInsult)
    End Sub
End Class
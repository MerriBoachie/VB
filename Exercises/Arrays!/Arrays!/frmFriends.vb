Public Class frmFriends
    Dim arrFriends(2) As String
    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        Try
            For intCounter As Integer = 0 To arrFriends.Length - 1
                arrFriends(intCounter) = InputBox("Enter the names of your three best friends!", "Friend number " & (intCounter + 1) & "!")
            Next intCounter
        Catch ex As Exception
            MessageBox.Show("What're you doing? You have to enter letters!", "Hey! >:( ")
        End Try
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        For intCounter As Integer = 0 To arrFriends.Length - 1
            lblMessage.Text &= "Hello, " & arrFriends(intCounter) & "!" & vbCrLf
        Next intCounter
    End Sub
End Class
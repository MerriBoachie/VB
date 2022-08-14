Public Class frmShowFoods
    Dim arrFoods(2) As String

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Try
            For intCounter As Integer = 0 To arrFoods.Length - 1
                arrFoods(intCounter) = InputBox("Enter one of your favorite foods!", "Number " & (intCounter + 1) & "!")
            Next intCounter
        Catch ex As Exception
            MessageBox.Show("What're you doing?? You have to enter letters!", "Whoah there! ")
        End Try
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        For intCounter As Integer = 0 To arrFoods.Length - 1
            lblMessage.Text &= "You like to eat " & arrFoods(intCounter) & "!" & vbCrLf
        Next intCounter
    End Sub
End Class
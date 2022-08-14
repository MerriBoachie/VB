Public Class frmBirthdayPresents
    Private Sub btnBirthday_Click(sender As Object, e As EventArgs) Handles btnBirthday.Click
        Dim strPresents As String
        Dim strRestaurant As String
        Try
            For intCounter As Integer = 1 To 3
                strPresents = InputBox("Enter what you want for your birthday!", "I'll get you some presents :D")
                lstOutput.Items.Add(strPresents & vbCrLf)
            Next intCounter
            If MessageBox.Show("Do you have a favorite restaurant?", "Let's go out!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                strRestaurant = InputBox("What's the restaurant name?", "Enter thr name!")
                MessageBox.Show("It's settled then- lets go out to eat at " & strRestaurant & "!", "Alright!")
            Else
                MessageBox.Show("That's cool- we'll order some takeout! >:)", "*Gasp!*")
            End If
        Catch ex As Exception
            MessageBox.Show("You have to tell me what you want for your birthday- use your words!!", "Huh?")
        End Try
    End Sub
End Class
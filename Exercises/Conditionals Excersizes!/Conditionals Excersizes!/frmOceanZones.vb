Public Class frmOceanZones
    Private Sub btnZone_Click(sender As Object, e As EventArgs) Handles btnZone.Click
        'Declare
        Dim intMeters As Integer

        Try
            'Input
            intMeters = Convert.ToInt32(txtInput.Text)
            'Calculate
            If intMeters >= 0 And intMeters <= 2 Then
                lblMessage.Text = "You are in the Sunlight Zone! Sunshine sparkles off of the ocean waves! :D"
            ElseIf intMeters >= 3 And intMeters <= 1000 Then
                lblMessage.Text = "You are in the Twilight Zone! These deep blue waters are home to many seacreatures- it holds a serene beauty!"
            ElseIf intMeters >= 1001 And intMeters <= 4000 Then
                lblMessage.Text = "You are in the Midnight Zone! There is hardly any light, and it's much colder down here! The sea creatures here are so strange- I wonder if we'll see an anglerfish?"
            ElseIf intMeters >= 4001 And intMeters <= 6000 Then
                lblMessage.Text = "You are in the Abyss Zone! This zone remains in perpetual darkness, with the only light coming from the bioluminescent fish life. It's so dark down here...!"
            ElseIf intMeters >= 6001 And intMeters <= 11000 Then
                lblMessage.Text = "You have reached the Trenches- The deepest ocean zone! This are remains plunged in darkness and extreme water pressure, yet there is still sea life here- Neato! "
            End If
        Catch ex As Exception
            MessageBox.Show("You have to put in a whole number!!! :0", "Whoa there buckaroo!")
        End Try

    End Sub
End Class
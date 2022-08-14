Public Class frmWindChill
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Dim intTempurature As Integer
        Dim intWindSpeed As Integer
        Dim intWindChill As Double
        Try
            intTempurature = Convert.ToInt32(txtInput1.Text)
            intWindSpeed = Convert.ToInt32(txtInput2.Text)
            If intTempurature > 40 Or intWindSpeed < 5 Then
                lblMessage.Text = "You'll be just fine! :)"
            Else
                intWindChill = 35.74 + (0.6215 * intTempurature) - (35.75 * (intWindSpeed ^ 0.16)) + (0.4275 * intTempurature) * (intWindSpeed ^ 0.16)
            End If
            If intWindChill >= 21 And intWindChill <= 40 Then
                lblMessage.Text = "A bit chilly, but you shouldn't get frostbite! The wind chill is only " & intWindChill & "!"
            ElseIf intWindChill >= -14 And intWindChill <= 20 Then
                lblMessage.Text = "It's cold- the wind chill is " & intWindChill & "!" & " Be careful! Any exposed skin is at risk of frostbite."
            ElseIf intWindChill >= -29 And intWindChill <= -15 Then
                lblMessage.Text = "The wind chill is " & intWindChill & "!" & " It's very cold! any exposed skin will be frostbitten within 30 minutes. "
            ElseIf intWindChill >= -44 And intWindChill <= -30 Then
                lblMessage.Text = "Bitter cold! The wind chill is " & intWindChill & "!" & " Any exposed skin will frostbite within 10 minutes! :o"
            ElseIf intWindChill >= -60 And intWindChill <= -45 Then
                lblMessage.Text = "EXTREME cold!! The wind chill is " & intWindChill & "!" & " Any exposed skin will frostbite within 2 minutes!!! D:"
            ElseIf intWindChill < -60 Then
                lblMessage.Text = "The wind chill is " & intWindChill & "! Boi you gonna die!!!! Go inside!!!!!! DDD:"
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a number you fool!! >:(", "I can't believe you've done this.")
        End Try
    End Sub
End Class
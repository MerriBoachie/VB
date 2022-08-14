Public Class frmConcert
    Private Sub DisplayTheCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayTheCostToolStripMenuItem.Click
        Dim dblEventCost As Double
        Dim intTickets As Integer
        Dim dblTotal As Double
        Try
            intTickets = cboTickets.Text
            If lstEvent.Text = "Concert" Then
                dblEventCost = 49.99
            ElseIf lstEvent.Text = "Orchestra" Then
                dblEventCost = 35.99
            ElseIf lstEvent.Text = "Play" Then
                dblEventCost = 24.99
            ElseIf lstEvent.Text = "Musical" Then
                dblEventCost = 29.99
            End If
            dblTotal = dblEventCost * intTickets
            lblMessage.Text = "Your total for the " & lstEvent.Text & " is " & dblTotal.ToString("$##.00") & "! Have fun!"
        Catch ex As Exception
            MessageBox.Show("You can only have up to 5 tickets!", "Uh-oh!")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("See ya- have fun! :D", "Bye!")
        Me.Close()
    End Sub
End Class
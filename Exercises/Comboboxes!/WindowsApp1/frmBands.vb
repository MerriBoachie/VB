Public Class frmBands
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Okie dokie then- I'll see you later!", "Catch you later!")
        Me.Close()
    End Sub

    Private Sub TheBeatlesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheBeatlesToolStripMenuItem.Click
        lblMessage.Text = "Paul McCartney - Lead Singer" & vbCrLf & "John Lennon - Rhythm Guitar" & vbCrLf & "George Harrison - Lead Guitar" & vbCrLf & "Ringo Starr - Drums"
        If MessageBox.Show("Do you like the Beatles???", "Quick survey!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Heck yeah! They're awesome!", "Yay!")
        Else
            MessageBox.Show(":(  Maybe you've never heard of them?", "Huh??")
        End If
    End Sub

    Private Sub TheWhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheWhoToolStripMenuItem.Click
        lblMessage.Text = "Roger Daltrey - Lead Singer" & vbCrLf & "Pete Townsend - Guitar" & vbCrLf & "John Entwhistle - Bass Guitar" & vbCrLf & "Keith Moon – Drums”
    End Sub

    Private Sub TheDoorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheDoorsToolStripMenuItem.Click
        lblMessage.Text = "Jim Morrison - Lead Singer" & vbCrLf & "Robby Kreiger - Guitar" & vbCrLf & "Ray Manzarek - Keyboard" & vbCrLf & "John Densmore - Drums"
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        DialogBands.Show()
    End Sub

    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectToolStripMenuItem.Click

    End Sub
End Class
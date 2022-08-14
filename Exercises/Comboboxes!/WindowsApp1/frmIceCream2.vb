Public Class frmIceCream2
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim strFlavor As String
        Try
            strFlavor = InputBox("What flavor would you like?", "Enter a flavor!")
            lstFlavors.Text &= strFlavor & vbCrLf
        Catch ex As Exception
            MessageBox.Show("Enter a flavor!!", "Eh??")
        End Try
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Try
            lstFlavors.Items.Remove(InputBox("Enter a flavor you'd like to remove!", "It's too much??"))
        Catch ex As Exception
            MessageBox.Show("You have to enter one of the flavors in the list!", "Nani???")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Okie dokie then- enjoy your ice cream!!!", "Later!")
    End Sub

    Private Sub FavoriteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoriteToolStripMenuItem.Click
        Dim strFavorite As String
        Try
            If MessageBox.Show("Do you have a favorite flavor??", "Do ya?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                strFavorite = InputBox("Tell me what is is then! :D", "Enter the flavor!")
                lblFavorites.Text &= vbCrLf & strFavorite
            Else
                MessageBox.Show("So you like every flavor then? ^^ ", "I see you don't pick favorites!")
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a flavor!", "Ya dun goofed")
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        DialogIceCream2.Show()
    End Sub
End Class
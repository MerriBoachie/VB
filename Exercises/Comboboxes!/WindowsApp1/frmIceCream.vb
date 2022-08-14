Public Class frmIceCream
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        lstFlavors.Items.Add(txtEnter.Text)
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Try
            lstFlavors.Items.Remove(txtEnter.Text)
        Catch ex As Exception
            MessageBox.Show("You have to remove something that is in the listbox!")
        End Try
    End Sub

    Private Sub SortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortToolStripMenuItem.Click
        lstFlavors.Sorted = True
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lstFlavors.Items.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Enjoy your ice cream- I'll see you later!", "Parting is a sweet sorrow!")
        Me.Close()
    End Sub
End Class
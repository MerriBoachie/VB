Public Class frmReadyForSchool
    Private Sub chkHomework_CheckedChanged(sender As Object, e As EventArgs) Handles chkHomework.CheckedChanged
        lblMessage.Text &= "You did your homework- it was tough, but you finished!" & vbCrLf
        MessageBox.Show("Awesome Job!")
    End Sub

    Private Sub chkBreakfast_CheckedChanged(sender As Object, e As EventArgs) Handles chkBreakfast.CheckedChanged
        lblMessage.Text &= "Heck Yeah- you had pancakes, bacon, and eggs- Yum!! :D" & vbCrLf
    End Sub

    Private Sub chkBrushTeeth_CheckedChanged(sender As Object, e As EventArgs) Handles chkBrushTeeth.CheckedChanged
        lblMessage.Text &= " Yup, minty fresh!!! :)" & vbCrLf
    End Sub
    Private Sub btnReady_Click(sender As Object, e As EventArgs) Handles btnReady.Click
        If Not (chkHomework.Checked And chkBreakfast.Checked And chkBrushTeeth.Checked) Then
            MessageBox.Show(“Are you sure you are ready for school? I think you have a few things left to do!”, "You're not done yet tho!")
        Else
            MessageBox.Show("Looks like you're ready for school- Have a great day! :>", "See ya after school!")
            Application.Exit()
        End If
    End Sub
End Class
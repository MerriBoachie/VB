Public Class frmTotalPencils
    Private Sub TotalThePencils(ByVal intStudents As Integer, ByVal intPencils As Integer, ByRef intTotal As Integer)
        intTotal = intStudents * intPencils
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intNumStudents As Integer
        Dim intNumPencils As Integer
        Dim intAnswer As Integer
        Try
            intNumPencils = Convert.ToInt32(txtInput1.Text)
            intNumStudents = Convert.ToInt32(txtInput2.Text)

            TotalThePencils(intNumStudents, intNumPencils, intAnswer)
            lblMessage.Text = "The total number of pencils per student is " & intAnswer & "!"
        Catch ex As Exception
            MessageBox.Show("You can't have a part of a student- enter a whole number!", "Hey- stop that!")
        End Try
    End Sub

    Private Sub txtInput1_TextChanged(sender As Object, e As EventArgs) Handles txtInput1.TextChanged
        lblMessage.Text = " "
    End Sub

    Private Sub txtInput2_TextChanged(sender As Object, e As EventArgs) Handles txtInput2.TextChanged
        lblMessage.Text = " "
    End Sub
End Class
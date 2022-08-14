Public Class frmTotalStudents
    Function calcTotal(ByVal intNum1 As Integer, ByVal intNum2 As Integer, ByVal intNum3 As Integer, ByVal intNum4 As Integer) As Integer
        Return (intNum1 + intNum2 + intNum3 + intNum4)
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intInput1 As Integer
        Dim intInput2 As Integer
        Dim intInput3 As Integer
        Dim intInput4 As Integer
        Dim intAnswer As Integer
        Try
            intInput1 = Convert.ToInt32(txtInput1.Text)
            intInput2 = Convert.ToInt32(txtInput2.Text)
            intInput3 = Convert.ToInt32(txtInput3.Text)
            intInput4 = Convert.ToInt32(txtInput4.Text)
            intAnswer = calcTotal(intInput1, intInput2, intInput3, intInput4)
            lblMessage.Text = "The total number of students here today was " & intAnswer & "!"
        Catch ex As Exception
            MessageBox.Show("You can't have half of a student- enter whole numbers!", "Hey, what're you doing?!")
        End Try
    End Sub
End Class
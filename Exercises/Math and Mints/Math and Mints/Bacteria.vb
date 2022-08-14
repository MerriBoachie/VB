Public Class frmBacteria
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare
        Dim dblBacteria As Double
        Dim dblK As Double
        Dim dblTime As Double
        Dim dblAnswer As Double
        Try
            'Input
            dblBacteria = Convert.ToDouble(txtInput1.Text)
            dblK = Convert.ToDouble(txtInput2.Text)
            dblTime = Convert.ToDouble(txtInput3.Text)
            'Calculate
            dblAnswer = (dblBacteria) * Math.Exp((dblK) * (dblTime))
            'Output
            lblOutput.Text = "If there are " & dblBacteria.ToString & " bacteria at the start, and the constant is " & dblK.ToString & ", there will be " & dblAnswer.ToString & " bacteria after " & dblTime.ToString & " hours!"
        Catch ex As Exception

        End Try
    End Sub
End Class
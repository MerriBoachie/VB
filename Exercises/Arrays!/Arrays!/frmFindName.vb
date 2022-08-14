Public Class frmFindName
    Dim strNames() As String = {“Andy”, “Johnnie”, “Destin”, “Dave”, “Angeline”, “Ramone”, “Joel”, “Latrece”, “Nate”, “Jeff”}

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strNameInput As String
        Dim blnNameSearch As Boolean = False

        Try
            strNameInput = InputBox("What name are you searching for?", "Who are you looking for?")

            For intCounter As Integer = 0 To strNames.Length - 1
                If strNameInput = strNames(intCounter) Then
                    blnNameSearch = True
                    lblOutput.Text = "Ah! Here it is- You must be " & strNameInput & ", yes?"
                Else
                    lblOutput.Text = "Ah sorry- I don't see anyone under the name of " & strNameInput & "!"
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("You have to enter a name!", "Huh??")
        End Try
    End Sub
End Class
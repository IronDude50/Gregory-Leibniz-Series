Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        ' Closes the program
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtIterations.Text <> "" Then
            If IsNumeric(txtIterations.Text) = True Then
                Dim Iterations As Integer = txtIterations.Text
                Dim Output As Double
                ' Declaration of variables

                For k = 1 To Iterations
                    Output += 4 * (((-1) ^ (k + 1)) / ((2 * k) - 1))
                Next
                ' Loops through each iteration

                txtOutput.Text = Output
                ' Displays output
            Else
                MessageBox.Show("Input is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtIterations.Clear()
                ' When the input non-existent or in the wrong format
            End If
        Else
            MessageBox.Show("Input is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtIterations.Clear()
        End If
        ' Validation
    End Sub
End Class
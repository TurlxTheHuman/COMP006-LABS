Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        lbTotal.Text = tbRed.Text + 0 + tbGreen.Text + 0 + tbBlue.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbTotal.Text = ""
        tbRed.Text = ""
        tbGreen.Text = ""
        tbBlue.Text = ""
    End Sub
End Class

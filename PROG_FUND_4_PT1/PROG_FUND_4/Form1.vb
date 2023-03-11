Option Strict On
Option Infer Off
Option Explicit On


Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim Name As String = txtName.Text
        Dim Years As Integer
        Dim Sales As Integer
        Integer.TryParse(txtSales.Text, Sales)

        If txtName.Text = "" Or txtSales.Text = "" Or txtYears.Text = "" Then
            lblOutput.Text = "You Are Missing An Input"
        Else
            If Integer.TryParse(txtYears.Text, Years) Then
                If Years >= 5 And Sales >= 100000 Then
                    lblOutput.Text = Name + " You Get A $1000 Bonus!"
                Else
                    lblOutput.Text = Name + " You Won't Get A Bonus"
                End If
            Else
                lblOutput.Text = "Please have a year value > 0"
            End If
        End If
    End Sub

    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtYears.Text = ""
        txtSales.Text = ""
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class

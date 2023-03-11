Option Strict On
Option Infer Off
Option Explicit On

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ages As Integer = 16
        Do While ages <> 101
            lstAges.Items.Add(ages)
            ages = ages + 1
        Loop ' Loops from ages 16 - 100
        lstAges.SelectedIndex = 0
    End Sub

    Private Sub txtTicket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTicket.KeyPress
        If (e.KeyChar).ToString.ToUpper = "Y" Then ' Uppercase + Lowercase Y
            e.Handled = False
        ElseIf (e.KeyChar).ToString.ToUpper = "N" Then ' Uppercase + Lowercase N
            e.Handled = False
        ElseIf e.KeyChar = Convert.ToChar(8) Then ' Backspace
            e.Handled = False
        Else
            e.Handled = True ' Handle everything not a Y,N,Backspace
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtTicket.Text = ""
        lblOutput.Text = ""
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim selectedAge As String = lstAges.SelectedItem.ToString
        Dim fullName As String = txtName.Text
        Dim hadTicket As Boolean = False

        If txtTicket.Text.ToUpper = "Y" Then
            hadTicket = True
        End If


        If selectedAge < "30" Then
            If hadTicket = False Then
                lblOutput.Text = "Great! You qualify for insurance for $45"
            ElseIf hadTicket = True Then
                lblOutput.Text = "Your rate for insurance for $85"
            End If
        End If

        If selectedAge >= "30" Then
            If hadTicket = False Then
                lblOutput.Text = "Great! You qualify for insurance for $30"
            ElseIf hadTicket = True Then
                lblOutput.Text = "Your rate for insurance for $85"
            End If
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class

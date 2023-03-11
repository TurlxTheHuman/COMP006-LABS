Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty

        txtDonuts.Focus()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        btnCalc.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False
        btnPrint.Visible = False
        ' PrintForm1.Print()
        btnCalc.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False
        btnPrint.Visible = False

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblTotalItems.Text = Val(txtDonuts.Text) + Val(txtMuffins.Text)
        lblTotalSales.Text = Val(lblTotalItems.Text) * 0.5
        lblTotalSales.Text = Format(lblTotalSales.Text, "currency")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = DateTime.Now.ToString("MM/dd/yyyy")
        txtDonuts.Focus()
    End Sub
End Class

Option Strict On
Option Infer Off
Option Explicit On
Public Class Form1
    Private Sub btnTriangle_Click(sender As Object, e As EventArgs) Handles btnTriangle.Click
        lblOutput.Text = ""
        Dim Area As Double = 0
        Dim Base As Double
        Dim Height As Double
        Dim inputBase As String
        Dim inputHeight As String
        inputBase = InputBox("Enter the Base of the circle here ", "Base")
        inputHeight = InputBox("Enter the Height of the circle here ", "Radius")
        Double.TryParse(inputBase, Base)
        Double.TryParse(inputHeight, Height)
        Area = (Height * Base) / 2
        lblOutput.Text = "The Area Of Your Triangle Is " + Area.ToString("N2")
    End Sub

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        lblOutput.Text = ""
        Dim Area As Double = 0
        Dim Side As Double
        Dim inputSide As String
        inputSide = InputBox("Enter One Side Of Your Square ", "Side")
        Double.TryParse(inputSide, Side)
        Area = Side ^ 2
        lblOutput.Text = "The Area Of The Square Is " + Area.ToString("N2")
    End Sub

    Private Sub btnCircle_Click(sender As Object, e As EventArgs) Handles btnCircle.Click
        lblOutput.Text = ""
        Dim Area As Double = 0
        Dim Radius As Double
        Dim inputRadius As String
        inputRadius = InputBox("Enter the radius of the circle here ", "Radius")
        Double.TryParse(inputRadius, Radius)
        Area = System.Math.PI * Radius ^ 2
        lblOutput.Text = "The Area Of The Circle Is " + Area.ToString("N2")

    End Sub
End Class

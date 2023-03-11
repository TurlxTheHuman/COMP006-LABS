Option Strict On
Option Infer Off
Option Explicit On

Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim orderTotal As Double = 0

        Dim orderBurger As String = ""
        Dim orderFries As String = ""
        Dim orderDrink As String = ""

        Dim orderTakeout As Boolean
        Dim orderDonation As Boolean
        Dim donationPrompt As String = ""
        Dim takeoutPrompt As String = ""

        If radBurgerRegular.Checked Then
            orderTotal = orderTotal + 3.5
            orderBurger = "Regular"
        ElseIf radBurgerCheese.Checked Then
            orderTotal = orderTotal + 4.0
            orderBurger = "Cheese"
        ElseIf radBurgerSecret.Checked Then
            orderTotal = orderTotal + 8.0
            orderBurger = "Secret"
        End If

        If radFriesSmall.Checked Then
            orderTotal = orderTotal + 1.5
            orderFries = "Small"
        ElseIf radFriesLarge.Checked Then
            orderTotal = orderTotal + 2.5
            orderFries = "Large"
        End If

        If radDrinkSoda.Checked Then
            orderTotal = orderTotal + 1.0
            orderDrink = "Soda"
        ElseIf radDrinkShake.Checked Then
            orderTotal = orderTotal + 2.0
            orderDrink = "Shake"
        End If

        If checkToGo.Checked Then
            takeoutPrompt = "Your order is take out" + Environment.NewLine
            orderTakeout = True
        End If

        If checkDonate.Checked Then
            orderTotal = orderTotal + 1.0
            donationPrompt = "Thanks for your donation" + Environment.NewLine
            orderDonation = True
        End If
        lblOutput.Text = "You have ordered a " +
            orderBurger + " burger with " +
            orderFries + " fries and a " +
            orderDrink +
            Environment.NewLine +
            donationPrompt +
            takeoutPrompt +
            "Your total is $" +
            orderTotal.ToString("N2")

    End Sub
End Class

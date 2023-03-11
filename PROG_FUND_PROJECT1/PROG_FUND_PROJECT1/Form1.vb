
Option Infer Off
Option Explicit

Public Class Form1

    ' cost of each pattern
    Dim willowCost As Decimal = 15.0
    Dim rosesCost As Decimal = 39.95
    Dim castlesCost As Decimal = 19.99

    ' initial price difference from willow pattern
    ' these will be used to calculate changing prices per pattern
    Dim platterUpcharge As Decimal = 15
    Dim servingBowlUpcharge As Decimal = 5
    Dim soupBowlsUpcharge As Decimal = 70
    Dim sugarBowlUpcharge As Decimal = 20
    Dim creamerUpcharge As Decimal = 10
    Dim teapotUpcharge As Decimal = 135

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim plateQuantity As Integer = 1
        Do While plateQuantity <> 21
            lstQuantity.Items.Add(plateQuantity)
            plateQuantity = plateQuantity + 1
        Loop
        lstQuantity.SelectedIndex = 0 ' selects first value by default to not cause errors later
        picCastles.Visible = False
        picRoses.Visible = False
        picWillow.Visible = False
    End Sub

    Private Sub radWillow_CheckedChanged(sender As Object, e As EventArgs) Handles radWillow.CheckedChanged
        cbPlatter.Text = "11in Platter ($" & (willowCost + platterUpcharge) & ")"
        cbServingBowl.Text = "Serving Bowl ($" & (willowCost + servingBowlUpcharge) & ")"
        cbSetOfSoupBowls.Text = "Set Of 8 Soup Bowls ($" & (willowCost + soupBowlsUpcharge) & ")"
        cbSugarBowl.Text = "Sugar Bowl ($" & (willowCost + sugarBowlUpcharge) & ")"
        cbTeapot.Text = "Teapot ($" & (willowCost + teapotUpcharge) & ")"
        picCastles.Visible = False
        picRoses.Visible = False
        picWillow.Visible = True
    End Sub

    Private Sub radRoses_CheckedChanged(sender As Object, e As EventArgs) Handles radRoses.CheckedChanged
        cbPlatter.Text = "11in Platter ($" & (rosesCost + platterUpcharge) & ")"
        cbServingBowl.Text = "Serving Bowl ($" & (rosesCost + servingBowlUpcharge) & ")"
        cbSetOfSoupBowls.Text = "Set Of 8 Soup Bowls ($" & (rosesCost + soupBowlsUpcharge) & ")"
        cbSugarBowl.Text = "Sugar Bowl ($" & (rosesCost + sugarBowlUpcharge) & ")"
        cbTeapot.Text = "Teapot ($" & (rosesCost + teapotUpcharge) & ")"
        picCastles.Visible = False
        picRoses.Visible = True
        picWillow.Visible = False
    End Sub

    Private Sub radCastles_CheckedChanged(sender As Object, e As EventArgs) Handles radCastles.CheckedChanged
        cbPlatter.Text = "11in Platter ($" & (castlesCost + platterUpcharge) & ")"
        cbServingBowl.Text = "Serving Bowl ($" & (castlesCost + servingBowlUpcharge) & ")"
        cbSetOfSoupBowls.Text = "Set Of 8 Soup Bowls ($" & (castlesCost + soupBowlsUpcharge) & ")"
        cbSugarBowl.Text = "Sugar Bowl ($" & (castlesCost + sugarBowlUpcharge) & ")"
        cbTeapot.Text = "Teapot ($" & (castlesCost + teapotUpcharge) & ")"
        picCastles.Visible = True
        picRoses.Visible = False
        picWillow.Visible = True
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim selectedPattern As String = ""
        Dim quantityNeeded As Integer = lstQuantity.SelectedItem

        Dim platterAddition As Boolean = False
        Dim servingBowlAddition As Boolean = False
        Dim eightSoupBowlsAddition As Boolean = False
        Dim sugarBowlAddition As Boolean = False
        Dim creamerAddition As Boolean = False
        Dim teapotAddition As Boolean = False

        Dim patternCost As Double
        Dim additionalsCost As Double
        Dim totalCost As Double


        ' Get Selected Pattern And Account For Price
        If radWillow.Checked Then
            patternCost = willowCost
            selectedPattern = "Royal Wex Blue Willow"
        ElseIf radRoses.Checked Then
            patternCost = rosesCost
            selectedPattern = "Royal Albert Old Country Roses"
        ElseIf radCastles.Checked Then
            patternCost = castlesCost
            selectedPattern = "Johnson Brothers Old British Castles"
        End If

        ' Find all selected addons
        If cbPlatter.Checked Then
            additionalsCost = additionalsCost + (patternCost + platterUpcharge)
            platterAddition = True
        End If

        If cbServingBowl.Checked Then
            additionalsCost = additionalsCost + (patternCost + servingBowlUpcharge)
            servingBowlAddition = True
        End If

        If cbSetOfSoupBowls.Checked Then
            additionalsCost = additionalsCost + (patternCost + soupBowlsUpcharge)
            eightSoupBowlsAddition = True
        End If

        If cbSugarBowl.Checked Then
            additionalsCost = additionalsCost + (patternCost + sugarBowlUpcharge)
            sugarBowlAddition = True
        End If

        If cbCreamer.Checked Then
            additionalsCost = additionalsCost + (patternCost + creamerUpcharge)
            creamerAddition = True
        End If

        If cbTeapot.Checked Then
            additionalsCost = additionalsCost + (patternCost + teapotUpcharge)
            teapotAddition = True
        End If


        ' Calculate toal cost
        totalCost = (patternCost * quantityNeeded) + additionalsCost
        lblOutput.Text = totalCost

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radWillow.Checked = True
        lstQuantity.SelectedIndex = "0"
        cbPlatter.Checked = False
        cbServingBowl.Checked = False
        cbSetOfSoupBowls.Checked = False
        cbSugarBowl.Checked = False
        cbCreamer.Checked = False
        cbTeapot.Checked = False
    End Sub
End Class

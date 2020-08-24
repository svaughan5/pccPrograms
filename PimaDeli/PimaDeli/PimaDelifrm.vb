Option Strict On
Option Explicit On

'Programmer : Sean Vaughan
'17 October 2018
'CIS141 : Program 4

Public Class PimaDelifrm

    'All global constants declared
    Const _BASE_SANDWICH_COST As Double = 6.0
    Const _JALAPENO_COST As Double = 0.25
    Const _DRINK_COST As Double = 2.0
    Const _EXTRA_MEAT_COST As Double = 1.5
    Const _EXTRA_CHEESE_COST As Double = 0.4

    'Exit button to close the program
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Prices button display 
    Private Sub PricesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PricesToolStripMenuItem.Click
        Dim fmt As String = "0.00"
        Dim sandwichCost As String = _BASE_SANDWICH_COST.ToString(fmt)
        Dim jalapenoCost As String = _JALAPENO_COST.ToString(fmt)
        Dim drinkCost As String = _DRINK_COST.ToString(fmt)
        Dim extraMeat As String = _EXTRA_MEAT_COST.ToString(fmt)
        Dim extraCheese As String = _EXTRA_CHEESE_COST.ToString(fmt)



        MessageBox.Show("*** Sandwiches with one meat, one cheese, and any condiment other then jalapenos : $" & sandwichCost _
                        & vbNewLine & vbNewLine & "*** Jalapenos : + $" & jalapenoCost _
                        & vbNewLine & vbNewLine & "*** Drinks : + $" & drinkCost _
                        & vbNewLine & vbNewLine & "*** Extra Meat : + $" & extraMeat _
                        & vbNewLine & vbNewLine & "*** Extra Cheese : + $" & extraCheese, "Pricing")
    End Sub

    'About button display
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim fmt As String = "0.00"
        Dim jalapenoCost As String = _JALAPENO_COST.ToString(fmt)

        MessageBox.Show("Hello, welcome to the Pima Deli." & vbNewLine & vbNewLine & "This program will assist you in making a successful purchase here at our deli." _
                        & vbNewLine & vbNewLine & "You are to select the type of bread you would like, your choice of meat (Up to 3), your choice of cheese (Up to 3), " _
                        & "and as many condiments as you would like free of charge (other than jalapenos costing + $" & jalapenoCost & ")." _
                        & vbNewLine & vbNewLine & "Created By: Sean Vaughan" & vbNewLine & "V1.00", "About")
    End Sub

    'Used to view a preview of your receipt.
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click

        'Declare all variables needed.
        Dim breadType, meatType, cheeseType, condiments, userDrink As String
        Dim sandwichCostString As String = "0.00"
        meatType = "None"
        Dim sandwichCost As Double = _BASE_SANDWICH_COST
        'Used to format the output. Instead of $9.5 it shows $9.50.
        Dim fmt As String = "0.00"
        Dim fmt2 As String = "00.00"

        'Function calls to get bread , meat, cheese, condiment, and drink type(s).
        breadType = getBreadType()
        meatType = getMeatType(sandwichCost)
        cheeseType = getCheeseType(sandwichCost)
        condiments = getCondiments(sandwichCost)
        userDrink = getUserDrink(sandwichCost)

        'Determines the formatting for cost printing.
        If sandwichCost < 10.0 Then
            sandwichCostString = sandwichCost.ToString(fmt)
        ElseIf sandwichCost > 10.0 Then
            sandwichCostString = sandwichCost.ToString(fmt2)
        End If

        'MessageBox for the Receipt Preview
        If (meatType <> "None") Then
            MessageBox.Show("Pima Deli" & vbNewLine & "------------------------------" & vbNewLine & "Bread : " & breadType & vbNewLine _
                & "Meat(s) : " & meatType & vbNewLine & "Cheese(s) : " & cheeseType & vbNewLine & "Condiments : " & condiments & vbNewLine _
                & "Drink : " & userDrink & vbNewLine & "Total : $" & sandwichCostString, "Receipt Preview")
        End If

    End Sub

    'Similar to the preview sub, couldn't figure out if I could make a call to that sub then add on to it. 
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim breadType, meatType, cheeseType, condiments, userDrink As String
        Dim sandwichCostString As String = "0.00"
        meatType = "None"
        Dim sandwichCost As Double = _BASE_SANDWICH_COST
        Dim fmt As String = "0.00"
        Dim fmt2 As String = "00.00"

        breadType = getBreadType()
        meatType = getMeatType(sandwichCost)
        cheeseType = getCheeseType(sandwichCost)
        condiments = getCondiments(sandwichCost)
        userDrink = getUserDrink(sandwichCost)

        If sandwichCost < 10.0 Then
            sandwichCostString = sandwichCost.ToString(fmt)
        ElseIf sandwichCost > 10.0 Then
            sandwichCostString = sandwichCost.ToString(fmt2)
        End If

        'Same as preview except added a thank you message at the end!
        If (meatType <> "None") Then
            MessageBox.Show("Pima Deli" & vbNewLine & "------------------------------" & vbNewLine & "Bread : " & breadType & vbNewLine _
                & "Meat(s) : " & meatType & vbNewLine & "Cheese(s) : " & cheeseType & vbNewLine & "Condiments : " & condiments & vbNewLine _
                & "Drink : " & userDrink & vbNewLine & "Total : $" & sandwichCostString & vbNewLine & vbNewLine & "Thank you for coming to the Pima Deli!", "Receipt")
        End If

        'Clears all options and returns to default for the next user.
        Dim ChkBox As CheckBox = Nothing

        For Each xObject As Object In Me.gboxMeats.Controls
            If TypeOf xObject Is CheckBox Then
                ChkBox = CType(xObject, CheckBox)
                ChkBox.Checked = False
            End If
        Next

        For Each xObject As Object In Me.gboxCheeses.Controls
            If TypeOf xObject Is CheckBox Then
                ChkBox = CType(xObject, CheckBox)
                ChkBox.Checked = False
            End If
        Next

        For Each xObject As Object In Me.gboxCondiments.Controls
            If TypeOf xObject Is CheckBox Then
                ChkBox = CType(xObject, CheckBox)
                ChkBox.Checked = False
            End If
        Next
        rbtnWhite.Checked = True
        rbtnNoDrink.Checked = True

    End Sub

    'Function to determine which condiments are on the sandwich
    Private Function getCondiments(ByRef sandwichCost As Double) As String
        Dim condiments As String = ""

        If cboxMustard.Checked = True Then condiments = cboxMustard.Text

        If cboxMayo.Checked = True AndAlso condiments = "" Then
            condiments = cboxMayo.Text
        ElseIf cboxMayo.Checked = True AndAlso condiments <> "" Then
            condiments += " + " & cboxMayo.Text
        End If

        If cboxKetchup.Checked = True AndAlso condiments = "" Then
            condiments = cboxKetchup.Text
        ElseIf cboxKetchup.Checked = True AndAlso condiments <> "" Then
            condiments += " + " & cboxKetchup.Text
        End If

        If cboxSalt.Checked = True AndAlso condiments = "" Then
            condiments = cboxSalt.Text
        ElseIf cboxSalt.Checked = True AndAlso condiments <> "" Then
            condiments += " + " & cboxSalt.Text
        End If

        If cboxPepper.Checked = True AndAlso condiments = "" Then
            condiments = cboxPepper.Text
        ElseIf cboxPepper.Checked = True AndAlso condiments <> "" Then
            condiments += " + " & cboxPepper.Text
        End If

        If cboxLettuce.Checked = True AndAlso condiments = "" Then
            condiments = cboxLettuce.Text
        ElseIf cboxLettuce.Checked = True AndAlso condiments <> "" Then
            condiments += " + " & cboxLettuce.Text
        End If

        If cboxTomato.Checked = True AndAlso condiments = "" Then
            condiments = cboxTomato.Text
        ElseIf cboxTomato.Checked = True AndAlso condiments <> "" Then
            condiments += " + " & cboxTomato.Text
        End If

        If cboxPickle.Checked = True AndAlso condiments = "" Then
            condiments = cboxPickle.Text
        ElseIf cboxPickle.Checked = True AndAlso condiments <> "" Then
            condiments += " + " & cboxPickle.Text
        End If

        If cboxOnion.Checked = True AndAlso condiments = "" Then
            condiments = cboxOnion.Text
        ElseIf cboxOnion.Checked = True AndAlso condiments <> "" Then
            condiments += " + " & cboxOnion.Text
        End If

        If cboxJalapeno.Checked = True AndAlso condiments = "" Then
            condiments = cboxJalapeno.Text
        ElseIf cboxJalapeno.Checked = True AndAlso condiments <> "" Then
            condiments += " + " & cboxJalapeno.Text
        End If

        If cboxNoCondiments.Checked = True Then condiments = cboxNoCondiments.Text

        If cboxJalapeno.Checked = True Then
            sandwichCost += _JALAPENO_COST
        End If

        Return condiments

    End Function

    'Function to determine what kinds of cheese the customer is ordering.
    Private Function getCheeseType(ByRef sandwichCost As Double) As String
        Dim c As Integer
        Dim cheeseType As String = "None"

        If cboxSwiss.Checked = True Then c = 1
        If cboxCheddar.Checked = True Then c += 2
        If cboxPepperJack.Checked = True Then c += 4

        Select Case c
            Case 0
                cheeseType = cboxNoCheese.Text
            Case 1
                cheeseType = cboxSwiss.Text
            Case 2
                cheeseType = cboxCheddar.Text
            Case 3
                cheeseType = cboxSwiss.Text & " + " & cboxCheddar.Text
            Case 4
                cheeseType = cboxPepperJack.Text
            Case 5
                cheeseType = cboxSwiss.Text & " + " & cboxPepperJack.Text
            Case 6
                cheeseType = cboxPepperJack.Text & " + " & cboxCheddar.Text
            Case 7
                cheeseType = cboxSwiss.Text & " + " & cboxCheddar.Text & " + " & cboxPepperJack.Text
        End Select

        If c = 3 OrElse c = 5 OrElse c = 6 Then
            sandwichCost += _EXTRA_CHEESE_COST
        ElseIf c = 7 Then
            sandwichCost += (_EXTRA_CHEESE_COST * 2)
        End If

        Return cheeseType
    End Function

    'Function to determine what kind of meats the user is ordering.
    Private Function getMeatType(ByRef sandwichCost As Double) As String
        Dim c As Integer
        Dim meatType As String = "None"

        If cboxHam.Checked = True Then c = 1
        If cboxTurkey.Checked = True Then c += 2
        If cboxRoastBeef.Checked = True Then c += 4

        Select Case c
            Case 0
                MessageBox.Show("Please choose a type of meat, we don't like vegetarians.")
            Case 1
                meatType = cboxHam.Text
            Case 2
                meatType = cboxTurkey.Text
            Case 3
                meatType = cboxHam.Text & " + " & cboxTurkey.Text
            Case 4
                meatType = cboxRoastBeef.Text
            Case 5
                meatType = cboxHam.Text & " + " & cboxRoastBeef.Text
            Case 6
                meatType = cboxRoastBeef.Text & " + " & cboxTurkey.Text
            Case 7
                meatType = cboxHam.Text & " + " & cboxTurkey.Text & " + " & cboxRoastBeef.Text
        End Select

        If c = 3 OrElse c = 5 OrElse c = 6 Then
            sandwichCost += _EXTRA_MEAT_COST
        ElseIf c = 7 Then
            sandwichCost += (_EXTRA_MEAT_COST * 2)
        End If

        Return meatType

    End Function

    'Function to determine if the user is getting a drink or not.
    Private Function getUserDrink(ByRef sandwichCost As Double) As String

        Dim userDrink As String

        If rbtnApple.Checked = True Then
            sandwichCost += _DRINK_COST
            userDrink = rbtnApple.Text
        ElseIf rbtnFountain.Checked = True Then
            sandwichCost += _DRINK_COST
            userDrink = rbtnFountain.Text
        Else
            userDrink = rbtnNoDrink.Text
        End If

        Return userDrink
    End Function


    'Function to get the type of bread the user orders
    Private Function getBreadType() As String
        Dim bread As String = "null"
        If rbtnWhite.Checked = True Then
            bread = rbtnWhite.Text
        ElseIf rbtnWheat.Checked = True Then
            bread = rbtnWheat.Text
        ElseIf rbtnItalian.Checked = True Then
            bread = rbtnItalian.Text
        End If

        Return bread

    End Function

End Class

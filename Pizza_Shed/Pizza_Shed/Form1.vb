Public Class Form1
    ' ### Declarations ###
    Dim toppingtext As String
    Dim topping As Decimal = 0 'Declaring topping total as 0, at start

    Dim cheesetomato = "3.50" 'Assigning Cheese and Tomato price as £3.50
    Dim hampineapple = "4.20" 'Assigning Ham and Pineapple price as £4.20
    Dim vegetarian = "5.20" 'Assigning Vegetarian price as £5.20
    Dim meatfeast = "5.80" 'Assigning Meat Feast price as £5.80
    Dim seafood = "5.60" 'Assigning Seafood price as £5.60
    Dim pizzatotal As Decimal = 0 'Declaring pizza total as 0, at start

    Dim cheese As Decimal = 0.5 'Asigning price as 50p
    Dim onions As Decimal = 0.5
    Dim pepperoni As Decimal = 0.5
    Dim peppers As Decimal = 0.5
    Dim sub1 As Decimal = 0
    Dim sub2 As Decimal = 0
    Dim sub3 As Decimal = 0
    Dim sub4 As Decimal = 0
    Dim sub5 As Decimal = 0
    Dim pizzasum As Decimal = 0
    Dim drink As Decimal = 0
    Dim drinksum As Decimal = 0




    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click



        If lblSubTotal1.Text = "" Then
            ' ### Calculate Pizza Type Price ###
            If cobPizzaType.Text = "Cheese and Tomato" Then
                pizzatotal = cheesetomato           'Telling program to make tot be eaqual to the pizza type price as a decimal value
                lblPizzaType1.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Ham and Pineapple" Then
                pizzatotal = hampineapple
                lblPizzaType1.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Vegetarian" Then
                pizzatotal = vegetarian
                lblPizzaType1.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Meat Feast" Then
                pizzatotal = meatfeast
                lblPizzaType1.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Seafood" Then
                pizzatotal = seafood
                lblPizzaType1.Text = cobPizzaType.Text
            End If


            ' ### Pizza Base ###
            lblPizzaBase1.Text = cobPizzaBase.Text



            ' ### Calculate Topping price ###
            If cbxCheese.Checked Then
                topping = topping + Val(cheese)     'Add the value of cheese (50p) to the topping total
                toppingtext = toppingtext & " Cheese"
            ElseIf topping = topping Then
            End If
            If cbxOnions.Checked Then
                topping = topping + Val(onions)
                toppingtext = toppingtext & " Onions"
            ElseIf topping = topping Then
            End If
            If cbxPepperoni.Checked Then
                topping = topping + Val(pepperoni)
                toppingtext = toppingtext & " Pepperoni"
            ElseIf topping = topping Then
            End If
            If cbxPeppers.Checked Then
                topping = topping + Val(peppers)
                toppingtext = toppingtext & " Peppers"
            ElseIf topping = topping Then
            End If
            lblTopping1.Text = toppingtext

            ' ### Add Quantity to Pizza ###
            lblPizzaQnty1.Text = cobPizzaQnty.Text


            ' ### Calculate Drink Price ###
            If rbnCola.Checked Then
                lblDrink1.Text = "Cola"     'Telling program to place a label in the summary as Cola
                drink = 0.9                 'Telling program to add a value of 90p in the cost of order summary
            End If
            If rbnLemon.Checked Then
                lblDrink1.Text = "Lemon"
                drink = 0.8
            End If
            If rbnOrange.Checked Then
                lblDrink1.Text = "Orange"
                drink = 0.9
            End If
            lblDrinkQnty1.Text = cobDrinkQnty.Text


            ' ### Total Up Everything ###
            pizzasum = Val(lblPizzaQnty1.Text) * Val(pizzatotal + topping)
            drinksum = Val(lblDrinkQnty1.Text) + Val(drink)
            sub1 = Val(pizzasum + drinksum)
            lblSubTotal1.Text = sub1.ToString("c")

            ' ### Clear all Input values so they can be used again ###
            ' ComboBox All Clear
            cobPizzaType.Text = ""
            cobPizzaBase.Text = ""
            cobDrinkQnty.Text = ""
            cobPizzaQnty.Text = ""

            'RadioButtons All Clear
            rbnLemon.Checked = False
            rbnCola.Checked = False
            rbnOrange.Checked = False

            'CheckBoxes All Clear
            cbxCheese.Checked = False
            cbxOnions.Checked = False
            cbxPepperoni.Checked = False
            cbxPeppers.Checked = False

            topping = 0
            pizzasum = 0
            drinksum = 0
            toppingtext = ""



        ElseIf lblSubTotal1.Text <> "" And lblSubTotal2.Text = "" Then
            ' ### Calculate Pizza Type Price ###
            If cobPizzaType.Text = "Cheese and Tomato" Then
                pizzatotal = cheesetomato           'Telling program to make tot be eaqual to the pizza type price as a decimal value
                lblPizzaType2.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Ham and Pineapple" Then
                pizzatotal = hampineapple
                lblPizzaType2.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Vegetarian" Then
                pizzatotal = vegetarian
                lblPizzaType2.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Meat Feast" Then
                pizzatotal = meatfeast
                lblPizzaType2.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Seafood" Then
                pizzatotal = seafood
                lblPizzaType2.Text = cobPizzaType.Text
            End If


            ' ### Pizza Base ###
            lblPizzaBase2.Text = cobPizzaBase.Text



            ' ### Calculate Topping price ###
            If cbxCheese.Checked Then
                topping = topping + Val(cheese)     'Add the value of cheese (50p) to the topping total
                toppingtext = toppingtext & " Cheese"
            ElseIf topping = topping Then
            End If
            If cbxOnions.Checked Then
                topping = topping + Val(onions)
                toppingtext = toppingtext & " Onions"
            ElseIf topping = topping Then
            End If
            If cbxPepperoni.Checked Then
                topping = topping + Val(pepperoni)
                toppingtext = toppingtext & " Pepperoni"
            ElseIf topping = topping Then
            End If
            If cbxPeppers.Checked Then
                topping = topping + Val(peppers)
                toppingtext = toppingtext & " Peppers"
            ElseIf topping = topping Then
            End If
            lblTopping2.Text = toppingtext

            ' ### Add Quantity to Pizza ###
            lblPizzaQnty2.Text = cobPizzaQnty.Text


            ' ### Calculate Drink Price ###
            If rbnCola.Checked Then
                lblDrink2.Text = "Cola"     'Telling program to place a label in the summary as Cola
                drink = 0.9                 'Telling program to add a value of 90p in the cost of order summary
            End If
            If rbnLemon.Checked Then
                lblDrink2.Text = "Lemon"
                drink = 0.8
            End If
            If rbnOrange.Checked Then
                lblDrink2.Text = "Orange"
                drink = 0.9
            End If
            lblDrinkQnty2.Text = cobDrinkQnty.Text


            ' ### Total Up Everything ###
            pizzasum = Val(lblPizzaQnty2.Text) * Val(pizzatotal + topping)
            drinksum = Val(lblDrinkQnty2.Text) + Val(drink)
            sub2 = Val(pizzasum + drinksum)
            lblSubTotal2.Text = sub2.ToString("c")

            ' ### Clear all Input values so they can be used again ###
            ' ComboBox All Clear
            cobPizzaType.Text = ""
            cobPizzaBase.Text = ""
            cobDrinkQnty.Text = ""
            cobPizzaQnty.Text = ""

            'RadioButtons All Clear
            rbnLemon.Checked = False
            rbnCola.Checked = False
            rbnOrange.Checked = False

            'CheckBoxes All Clear
            cbxCheese.Checked = False
            cbxOnions.Checked = False
            cbxPepperoni.Checked = False
            cbxPeppers.Checked = False

            topping = 0
            pizzasum = 0
            drinksum = 0
            toppingtext = ""

        ElseIf lblSubTotal1.Text <> "" And lblSubTotal2.Text <> "" And lblSubTotal3.Text = "" Then
            ' ### Calculate Pizza Type Price ###
            If cobPizzaType.Text = "Cheese and Tomato" Then
                pizzatotal = cheesetomato           'Telling program to make tot be eaqual to the pizza type price as a decimal value
                lblPizzaType2.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Ham and Pineapple" Then
                pizzatotal = hampineapple
                lblPizzaType3.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Vegetarian" Then
                pizzatotal = vegetarian
                lblPizzaType3.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Meat Feast" Then
                pizzatotal = meatfeast
                lblPizzaType3.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Seafood" Then
                pizzatotal = seafood
                lblPizzaType3.Text = cobPizzaType.Text
            End If


            ' ### Pizza Base ###
            lblPizzaBase3.Text = cobPizzaBase.Text



            ' ### Calculate Topping price ###
            If cbxCheese.Checked Then
                topping = topping + Val(cheese)     'Add the value of cheese (50p) to the topping total
                toppingtext = toppingtext & " Cheese"
            ElseIf topping = topping Then
            End If
            If cbxOnions.Checked Then
                topping = topping + Val(onions)
                toppingtext = toppingtext & " Onions"
            ElseIf topping = topping Then
            End If
            If cbxPepperoni.Checked Then
                topping = topping + Val(pepperoni)
                toppingtext = toppingtext & " Pepperoni"
            ElseIf topping = topping Then
            End If
            If cbxPeppers.Checked Then
                topping = topping + Val(peppers)
                toppingtext = toppingtext & " Peppers"
            ElseIf topping = topping Then
            End If
            lblTopping3.Text = toppingtext

            ' ### Add Quantity to Pizza ###
            lblPizzaQnty3.Text = cobPizzaQnty.Text


            ' ### Calculate Drink Price ###
            If rbnCola.Checked Then
                lblDrink3.Text = "Cola"     'Telling program to place a label in the summary as Cola
                drink = 0.9                 'Telling program to add a value of 90p in the cost of order summary
            End If
            If rbnLemon.Checked Then
                lblDrink3.Text = "Lemon"
                drink = 0.8
            End If
            If rbnOrange.Checked Then
                lblDrink3.Text = "Orange"
                drink = 0.9
            End If
            lblDrinkQnty3.Text = cobDrinkQnty.Text


            ' ### Total Up Everything ###
            pizzasum = Val(lblPizzaQnty3.Text) * Val(pizzatotal + topping)
            drinksum = Val(lblDrinkQnty3.Text) + Val(drink)
            sub3 = Val(pizzasum + drinksum)
            lblSubTotal3.Text = sub3.ToString("c")

            ' ### Clear all Input values so they can be used again ###
            ' ComboBox All Clear
            cobPizzaType.Text = ""
            cobPizzaBase.Text = ""
            cobDrinkQnty.Text = ""
            cobPizzaQnty.Text = ""

            'RadioButtons All Clear
            rbnLemon.Checked = False
            rbnCola.Checked = False
            rbnOrange.Checked = False

            'CheckBoxes All Clear
            cbxCheese.Checked = False
            cbxOnions.Checked = False
            cbxPepperoni.Checked = False
            cbxPeppers.Checked = False

            topping = 0
            pizzasum = 0
            drinksum = 0
            toppingtext = ""

        ElseIf lblSubTotal1.Text <> "" And lblSubTotal2.Text <> "" And lblSubTotal3.Text <> "" And lblSubTotal4.Text = "" Then
            ' ### Calculate Pizza Type Price ###
            If cobPizzaType.Text = "Cheese and Tomato" Then
                pizzatotal = cheesetomato           'Telling program to make tot be eaqual to the pizza type price as a decimal value
                lblPizzaType4.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Ham and Pineapple" Then
                pizzatotal = hampineapple
                lblPizzaType4.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Vegetarian" Then
                pizzatotal = vegetarian
                lblPizzaType4.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Meat Feast" Then
                pizzatotal = meatfeast
                lblPizzaType4.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Seafood" Then
                pizzatotal = seafood
                lblPizzaType4.Text = cobPizzaType.Text
            End If


            ' ### Pizza Base ###
            lblPizzaBase4.Text = cobPizzaBase.Text



            ' ### Calculate Topping price ###
            If cbxCheese.Checked Then
                topping = topping + Val(cheese)     'Add the value of cheese (50p) to the topping total
                toppingtext = toppingtext & " Cheese"
            ElseIf topping = topping Then
            End If
            If cbxOnions.Checked Then
                topping = topping + Val(onions)
                toppingtext = toppingtext & " Onions"
            ElseIf topping = topping Then
            End If
            If cbxPepperoni.Checked Then
                topping = topping + Val(pepperoni)
                toppingtext = toppingtext & " Pepperoni"
            ElseIf topping = topping Then
            End If
            If cbxPeppers.Checked Then
                topping = topping + Val(peppers)
                toppingtext = toppingtext & " Peppers"
            ElseIf topping = topping Then
            End If
            lblTopping4.Text = toppingtext

            ' ### Add Quantity to Pizza ###
            lblPizzaQnty4.Text = cobPizzaQnty.Text


            ' ### Calculate Drink Price ###
            If rbnCola.Checked Then
                lblDrink4.Text = "Cola"     'Telling program to place a label in the summary as Cola
                drink = 0.9                 'Telling program to add a value of 90p in the cost of order summary
            End If
            If rbnLemon.Checked Then
                lblDrink4.Text = "Lemon"
                drink = 0.8
            End If
            If rbnOrange.Checked Then
                lblDrink4.Text = "Orange"
                drink = 0.9
            End If
            lblDrinkQnty4.Text = cobDrinkQnty.Text


            ' ### Total Up Everything ###
            pizzasum = Val(lblPizzaQnty4.Text) * Val(pizzatotal + topping)
            drinksum = Val(lblDrinkQnty4.Text) + Val(drink)
            sub4 = Val(pizzasum + drinksum)
            lblSubTotal4.Text = sub4.ToString("c")

            ' ### Clear all Input values so they can be used again ###
            ' ComboBox All Clear
            cobPizzaType.Text = ""
            cobPizzaBase.Text = ""
            cobDrinkQnty.Text = ""
            cobPizzaQnty.Text = ""

            'RadioButtons All Clear
            rbnLemon.Checked = False
            rbnCola.Checked = False
            rbnOrange.Checked = False

            'CheckBoxes All Clear
            cbxCheese.Checked = False
            cbxOnions.Checked = False
            cbxPepperoni.Checked = False
            cbxPeppers.Checked = False

            topping = 0
            pizzasum = 0
            drinksum = 0
            toppingtext = ""

        ElseIf lblSubTotal1.Text <> "" And lblSubTotal2.Text <> "" And lblSubTotal3.Text <> "" And lblSubTotal4.Text <> "" And lblSubTotal5.Text = "" Then
            ' ### Calculate Pizza Type Price ###
            If cobPizzaType.Text = "Cheese and Tomato" Then
                pizzatotal = cheesetomato           'Telling program to make tot be eaqual to the pizza type price as a decimal value
                lblPizzaType5.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Ham and Pineapple" Then
                pizzatotal = hampineapple
                lblPizzaType5.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Vegetarian" Then
                pizzatotal = vegetarian
                lblPizzaType5.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Meat Feast" Then
                pizzatotal = meatfeast
                lblPizzaType5.Text = cobPizzaType.Text

            ElseIf cobPizzaType.Text = "Seafood" Then
                pizzatotal = seafood
                lblPizzaType5.Text = cobPizzaType.Text
            End If


            ' ### Pizza Base ###
            lblPizzaBase5.Text = cobPizzaBase.Text



            ' ### Calculate Topping price ###
            If cbxCheese.Checked Then
                topping = topping + Val(cheese)     'Add the value of cheese (50p) to the topping total
                toppingtext = toppingtext & " Cheese"
            ElseIf topping = topping Then
            End If
            If cbxOnions.Checked Then
                topping = topping + Val(onions)
                toppingtext = toppingtext & " Onions"
            ElseIf topping = topping Then
            End If
            If cbxPepperoni.Checked Then
                topping = topping + Val(pepperoni)
                toppingtext = toppingtext & " Pepperoni"
            ElseIf topping = topping Then
            End If
            If cbxPeppers.Checked Then
                topping = topping + Val(peppers)
                toppingtext = toppingtext & " Peppers"
            ElseIf topping = topping Then
            End If
            lblTopping5.Text = toppingtext

            ' ### Add Quantity to Pizza ###
            lblPizzaQnty5.Text = cobPizzaQnty.Text


            ' ### Calculate Drink Price ###
            If rbnCola.Checked Then
                lblDrink5.Text = "Cola"     'Telling program to place a label in the summary as Cola
                drink = 0.9                 'Telling program to add a value of 90p in the cost of order summary
            End If
            If rbnLemon.Checked Then
                lblDrink5.Text = "Lemon"
                drink = 0.8
            End If
            If rbnOrange.Checked Then
                lblDrink5.Text = "Orange"
                drink = 0.9
            End If
            lblDrinkQnty5.Text = cobDrinkQnty.Text


            ' ### Total Up Everything ###
            pizzasum = Val(lblPizzaQnty5.Text) * Val(pizzatotal + topping)
            drinksum = Val(lblDrinkQnty5.Text) + Val(drink)
            sub5 = Val(pizzasum + drinksum)
            lblSubTotal5.Text = sub5.ToString("c")

            ' ### Clear all Input values so they can be used again ###
            ' ComboBox All Clear
            cobPizzaType.Text = ""
            cobPizzaBase.Text = ""
            cobDrinkQnty.Text = ""
            cobPizzaQnty.Text = ""

            'RadioButtons All Clear
            rbnLemon.Checked = False
            rbnCola.Checked = False
            rbnOrange.Checked = False

            'CheckBoxes All Clear
            cbxCheese.Checked = False
            cbxOnions.Checked = False
            cbxPepperoni.Checked = False
            cbxPeppers.Checked = False

            topping = 0
            pizzasum = 0
            drinksum = 0
            toppingtext = ""

        End If
        lblTotal.Text = Val(sub1 + sub2 + sub3 + sub4 + sub5).ToString("c")


    End Sub

    Private Sub btnClearOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearOrder.Click
        Dim totalorders As Integer = 1

        ' ### Clear all ###
        ' ComboBox All Clear
        cobTableNo.Text = ""
        cobPizzaType.Text = ""
        cobPizzaBase.Text = ""
        cobDrinkQnty.Text = ""
        cobPizzaQnty.Text = ""

        'RadioButtons All Clear
        rbnLemon.Checked = False
        rbnCola.Checked = False
        rbnOrange.Checked = False

        'CheckBoxes All Clear
        cbxCheese.Checked = False
        cbxOnions.Checked = False
        cbxPepperoni.Checked = False
        cbxPeppers.Checked = False

        'TextBox Clear
        txtAddRequest.Text = ""

        'Labels All Clear
        lblTable.Text = ""
        lblPizzaBase1.Text = ""
        lblPizzaBase2.Text = ""
        lblPizzaBase3.Text = ""
        lblPizzaBase4.Text = ""
        lblPizzaBase5.Text = ""
        lblPizzaType1.Text = ""
        lblPizzaType2.Text = ""
        lblPizzaType3.Text = ""
        lblPizzaType4.Text = ""
        lblPizzaType5.Text = ""
        lblTopping1.Text = ""
        lblTopping2.Text = ""
        lblTopping3.Text = ""
        lblTopping4.Text = ""
        lblTopping5.Text = ""
        lblDrink1.Text = ""
        lblDrink2.Text = ""
        lblDrink3.Text = ""
        lblDrink4.Text = ""
        lblDrink5.Text = ""
        lblPizzaQnty1.Text = ""
        lblPizzaQnty2.Text = ""
        lblPizzaQnty3.Text = ""
        lblPizzaQnty4.Text = ""
        lblPizzaQnty5.Text = ""
        lblDrinkQnty1.Text = ""
        lblDrinkQnty2.Text = ""
        lblDrinkQnty3.Text = ""
        lblDrinkQnty4.Text = ""
        lblDrinkQnty5.Text = ""
        lblAddRequest.Text = ""
        lblTotal.Text = ""
        lblTableNo.Text = ""
        lblSubTotal1.Text = ""
        lblSubTotal2.Text = ""
        lblSubTotal3.Text = ""
        lblSubTotal4.Text = ""
        lblSubTotal5.Text = ""

        ' ### Disable The Groups To Look as Startup ###
        GroupSummary.Enabled = False
        GroupPizza.Enabled = False
        GroupDrink.Enabled = False
        GroupRequest.Enabled = False
        btnOrder.Enabled = False
        btnClearOrder.Enabled = False

        ' ### Enable TableNo ComboBox Again ###
        cobTableNo.Enabled = True

        ' Reset values

        topping = 0
        pizzasum = 0
        drinksum = 0
        toppingtext = ""
        sub1 = 0
        sub2 = 0
        sub3 = 0
        sub4 = 0
        sub5 = 0

        ' ### Add 1 to total orders ###
        lblOrdersToday.Text = totalorders + Val(lblOrdersToday.Text) ' Add 1 to the total orders of the day

    End Sub

    Private Sub cobTableNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobTableNo.SelectedIndexChanged
        ' ### Table No. ###
        lblTableNo.Text = cobTableNo.Text
        cobTableNo.Enabled = False
        GroupSummary.Enabled = True
        GroupPizza.Enabled = True
        GroupDrink.Enabled = True
        GroupRequest.Enabled = True
        btnOrder.Enabled = True
        btnClearOrder.Enabled = True

    End Sub

    Private Sub btnAddRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRequest.Click
        ' ### Show Additional Requests ###
        lblAddRequest.Text = lblAddRequest.Text & ControlChars.NewLine & txtAddRequest.Text
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ### Disable groups for startup ###
        GroupSummary.Enabled = False
        GroupPizza.Enabled = False
        GroupDrink.Enabled = False
        GroupRequest.Enabled = False
        btnOrder.Enabled = False
        btnClearOrder.Enabled = False

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim fRate As Decimal
        Dim tRate As Decimal
        Dim Amt As Decimal
        Decimal.TryParse(FromTextBox.Text, Amt)
        If FromCombo.Text = "Dollars" Then
            fRate = 1
        End If

        If FromCombo.Text = "Pesos" Then
            fRate = 18
        End If

        If FromCombo.Text = "Euros" Then
            fRate = 0.92
        End If

        If FromCombo.Text = "Yen" Then
            fRate = 128
        End If




        If ToCombo.Text = "Dollars" Then
            tRate = 1
        End If

        If ToCombo.Text = "Pesos" Then
            tRate = 18
        End If

        If ToCombo.Text = "Euros" Then
            tRate = 0.92
        End If

        If ToCombo.Text = "Yen" Then
            tRate = 128
        End If




        ToTextBox.Text = Convert(Amt, fRate, tRate)
    End Sub

    Function Convert(Amt As Decimal, fromrate As Decimal, torate As Decimal)
        Return Amt / fromrate * torate
    End Function
End Class

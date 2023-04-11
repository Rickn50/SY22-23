Class MainWindow
    Private Sub FromMenu(sender As Object, e As RoutedEventArgs)
        FromtextBox.Text = sender.header
    End Sub

    Private Sub ToMenu(sender As Object, e As RoutedEventArgs)
        TotextBox.Text = sender.header
    End Sub
    Function DollarsToPesos(Dollars As Decimal) As Decimal
        Return Dollars * 18.25
    End Function

    Function PesosToDollars(Pesos As Decimal) As Decimal
        Return Pesos / 18.25
    End Function

    Function DollarsToYen(Dollars As Decimal) As Decimal
        Return Dollars * 129.23
    End Function

    Function YenToDollars(Yen As Decimal) As Decimal
        Return Yen / 129.23
    End Function

    Function DollarsToEuro(Dollars As Decimal) As Decimal
        Return Dollars * 0.92
    End Function

    Function EuroToDollar(Euro As Decimal) As Decimal
        Return Euro / 0.92
    End Function

    Function DollarsToYuan(Dollars As Decimal) As Decimal
        Return Dollars * 6.74
    End Function

    Function YuanToDollars(Yuan As Decimal) As Decimal
        Return Yuan / 6.74
    End Function

    Function DollarsToPounds(Dollars As Decimal) As Decimal
        Return Dollars * 0.82
    End Function

    Function PoundsToDollars(Pounds As Decimal) As Decimal
        Return Pounds / 0.82
    End Function

    Function DollarsToIranianRial(Dollars As Decimal) As Decimal
        Return Dollars * 2502.15
    End Function

    Function IranianRialToDollars(IranianRial As Decimal) As Decimal
        Return IranianRial / 2502.15
    End Function



    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        Dim fromAmt As Decimal
        Dim toAmt As Decimal

        Decimal.TryParse(FromtextAmount.Text, fromAmt)

        If FromtextBox.Text = "Dollars" Then
            toAmt = DollarstoPesos(fromAmt)
        End If
        If FromtextBox.Text = "Pesos" Then
            toAmt = PesostoDollars(fromAmt)
        End If
        If FromtextBox.Text = "Dollars" Then
            toAmt = DollarsToYen(fromAmt)
        End If
        If FromtextBox.Text = "Yen" Then
            toAmt = YenToDollars(fromAmt)
        End If

        If FromtextBox.Text = "Dollars" Then
            toAmt = DollarsToYuan(fromAmt)
        End If
        If FromtextBox.Text = "Yuan" Then
            toAmt = YuanToDollars(fromAmt)
        End If

        If FromtextBox.Text = "Dollars" Then
            toAmt = DollarsToIranianRial(fromAmt)
        End If
        If FromtextBox.Text = "IranianRial" Then
            toAmt = IranianRialToDollars(fromAmt)
        End If

        If FromtextBox.Text = "Dollars" Then
            toAmt = DollarsToPounds(fromAmt)
        End If
        If FromtextBox.Text = "Pounds" Then
            toAmt = PoundsToDollars(fromAmt)
        End If




        TotextAmount.Text = toAmt
    End Sub
End Class
Class MainWindow
    Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
        Dim Fromamt As Decimal
        Dim fRate As Decimal
        Dim tRate As Decimal
        If standardvolumeCombo.Text = "tablespoon" Then fRate = 14.7
        If metricvolumeCombo.Text = "liter" Then fRate = 1000






        FromTextBox.Text = ""

        ToTextBox.Text = ""

        standardvolumeCombo.Text = ""

        metricvolumeCombo.Text = ""

        standardLengthCombo.Text = ""

        metricLengthCombo.Text = ""

    End Sub

    Private Sub volumeConvertButton__Click(sender As Object, e As RoutedEventArgs) Handles volumeConvertButton_.Click
        Dim amt As Decimal

        Dim fRate As Decimal

        Dim tRate As Decimal

        Decimal.TryParse(FromTextBox.Text, amt)

        If standardvolumeCombo.Text = "tablespoon" Then frate = 14.7868

        If standardvolumeCombo.Text = "cup" Then frate = 240.00057168

        If standardvolumeCombo.Text = "fluid ounce" Then frate = 29.5735

        If standardvolumeCombo.Text = "gill" Then frate = 118.294

        If standardvolumeCombo.Text = "pint" Then frate = 473.176

        If standardvolumeCombo.Text = "quart" Then frate = 946.353

        If standardvolumeCombo.Text = "gallon" Then frate = 3785.41






        If metricvolumeCombo.Text = "milliliter" Then trate = 0

        If metricvolumeCombo.Text = "liter" Then trate = 1000

        If metricvolumeCombo.Text = "kiloliter" Then tRate = 1

        ToTextBox.Text = Convert(amt, fRate, tRate)


    End Sub

    Function Convert(amt As Decimal, fRate As Decimal, tRate As Decimal)

        Return amt * fRate / tRate

    End Function




    Private Sub lengthConvertButton_Click(sender As Object, e As RoutedEventArgs) Handles lengthConvertButton.Click
        Dim amt As Decimal

        Dim fRate As Decimal

        Dim tRate As Decimal

        Decimal.TryParse(FromTextBox.Text, amt)

        If standardLengthCombo.Text = "inch" Then fRate = 2.54

        If standardLengthCombo.Text = "foot" Then fRate = 30.48

        If standardLengthCombo.Text = "yard" Then fRate = 91.44

        If standardLengthCombo.Text = "mile" Then fRate = 160934





        If metricLengthCombo.Text = "millimeter" Then tRate = 0.1

        If metricLengthCombo.Text = "centimeter" Then tRate = 1

        If metricLengthCombo.Text = "meter" Then tRate = 100

        If metricLengthCombo.Text = "kilometer" Then tRate = 100000


        ToTextBox.Text = Convert(amt, fRate, tRate)


    End Sub
End Class

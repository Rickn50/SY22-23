Class MainWindow
    Private Sub CalculateButton_Click(sender As Object, e As RoutedEventArgs) Handles CalculateButton.Click
        Dim Length As Decimal
        Dim Width As Decimal
        Dim CarpetCost As Decimal

        Decimal.TryParse(LengthTextBox.Text, Length)

        Decimal.TryParse(WidthTextBox.Text, Width)

        Decimal.TryParse(CarpetTextBox.Text, CarpetCost)

        FinalCost.Content = Length * Width * CarpetCost




        If OtherCarpets.Text = "New York Style Chandler" Then CarpetCost = 150

        If OtherCarpets.Text = "Home Decor Style" Then CarpetCost = 400

        If OtherCarpets.Text = "Abstract Gray" Then CarpetCost = 84

        FinalCost.Content = Convert(Length, Width, CarpetCost)

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
        LengthTextBox.Text = ""
        WidthTextBox.Text = ""
        CarpetTextBox.Text = ""
        FinalCost.Content = "0"
    End Sub

    Function Convert(CarpetCost As Decimal, Length As Decimal, Width As Decimal)

        Return CarpetCost * Length * Width

    End Function

    Private Sub CalculateButton_Copy_Click(sender As Object, e As RoutedEventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LengthSlider_ValueChanged(sender As Object, e As EventArgs)
        LengthTextBox.Text = sender.Value
    End Sub

    Private Sub WidthSlider_ValueChanged(sender As Object, e As EventArgs)
        WidthTextBox.Text = sender.Value
    End Sub

    Private Sub CarpetCostSlider_ValueChanged(sender As Object, e As EventArgs)
        CarpetTextBox.Text = sender.Value
    End Sub
End Class

Imports System.Reflection.Metadata

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Me.Background = New SolidColorBrush(Colors.Red)

        If COLORCOMBO.Text = "Blue" Then Me.Background = New SolidColorBrush(Colors.Blue)

        If COLORCOMBO.Text = "Yellow" Then Me.Background = New SolidColorBrush(Colors.Yellow)

        If COLORCOMBO.Text = "Orange" Then Me.Background = New SolidColorBrush(Colors.Orange)

        If COLORCOMBO.Text = "Purple" Then Me.Background = New SolidColorBrush(Colors.Purple)
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim Angle As Decimal
        Decimal.TryParse(AngleTextBox.Text, Angle)
        Select Case COLORCOMBO.Text
            Case "Blue"
                Me.Background = New SolidColorBrush(Colors.Blue)

            Case "Yellow"
                Me.Background = New SolidColorBrush(Colors.Yellow)

            Case "Orange"
                Me.Background = New SolidColorBrush(Colors.Orange)

            Case "Purple"
                Me.Background = New SolidColorBrush(Colors.Purple)

            Case Else
                Me.Background = New LinearGradientBrush(Colors.Red, Colors.Pink, Angle)
        End Select
    End Sub

    Private Sub AngleSlider_ValueChanged(sender As Object, e As EventArgs)
        AngleTextBox.Text = sender.Value
        Me.Background = New LinearGradientBrush(Colors.Red, Colors.Pink, sender.value)

    End Sub

    Private Sub ADDBUTTON_Click(sender As Object, e As RoutedEventArgs) Handles ADDBUTTON.Click
        Dim Red As Decimal
        Dim Green As Decimal
        Dim Blue As Decimal

        Decimal.TryParse(GreenTextBox.Text, Green)

        Decimal.TryParse(BlueTextBox.Text, Blue)

        Decimal.TryParse(RedTextBox.Text, Red)

        FINALNUMBER.Content = Red + Blue + Green

    End Sub

    Private Sub BlueSlider_ValueChanged(sender As Object, e As EventArgs)
        BlueTextBox.Text = sender.Value
        ShowColor()
    End Sub

    Private Sub GreenSlider_ValueChanged(sender As Object, e As EventArgs)
        GreenTextBox.Text = sender.Value
        ShowColor()
    End Sub

    Private Sub RedSlider_ValueChanged(sender As Object, e As EventArgs)
        RedTextBox.Text = sender.Value
        ShowColor()
    End Sub

    Sub ShowColor()
        Dim Red As Decimal
        Dim Green As Decimal
        Dim Blue As Decimal

        Decimal.TryParse(GreenTextBox.Text, Green)

        Decimal.TryParse(BlueTextBox.Text, Blue)

        Decimal.TryParse(RedTextBox.Text, Red)

        Me.Background = New SolidColorBrush(Color.FromArgb(255, Red, Green, Blue))
    End Sub


End Class
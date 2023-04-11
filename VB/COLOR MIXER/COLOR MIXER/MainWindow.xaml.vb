'Imports System.Drawing

Imports Microsoft.Win32
Imports System.IO
Imports System.Windows.Threading

Class MainWindow
    Dim G1 As Color
    Dim G2 As Color
    Dim Shape As String
    Private Sub RedSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        RedValue.Content = RedSlider.Value
        ChangeColor()
    End Sub

    Private Sub BlueSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        BlueValue.Content = BlueSlider.Value
        ChangeColor()
    End Sub

    Private Sub GreenSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        GreenValue.Content = GreenSlider.Value
        ChangeColor()
    End Sub

    Sub ChangeColor()

        ColorRectangle.Fill = New SolidColorBrush(Color.FromRgb(RedSlider.Value, BlueSlider.Value, GreenSlider.Value))
    End Sub

    Private Sub Color1_Click(sender As Object, e As RoutedEventArgs) Handles Color1.Click
        Color1.Background = ColorRectangle.Fill
    End Sub

    Private Sub Color2_Click(sender As Object, e As RoutedEventArgs) Handles Color2.Click
        Color2.Background = ColorRectangle.Fill
    End Sub

    Private Sub Color3_Click(sender As Object, e As RoutedEventArgs) Handles Color3.Click
        Color3.Background = ColorRectangle.Fill
    End Sub

    Private Sub Color4_Click(sender As Object, e As RoutedEventArgs) Handles Color4.Click
        Color4.Background = ColorRectangle.Fill
    End Sub

    Private Sub Color5_Click(sender As Object, e As RoutedEventArgs) Handles Color5.Click
        Color5.Background = ColorRectangle.Fill
    End Sub

    Private Sub Color6_Click(sender As Object, e As RoutedEventArgs) Handles Color6.Click
        Color6.Background = ColorRectangle.Fill
    End Sub

    Private Sub Color7_Click(sender As Object, e As RoutedEventArgs) Handles Color7.Click
        Color7.Background = ColorRectangle.Fill
    End Sub

    Private Sub Color8_Click(sender As Object, e As RoutedEventArgs) Handles Color8.Click
        Color8.Background = ColorRectangle.Fill
    End Sub

    Private Sub Color9_Click(sender As Object, e As RoutedEventArgs) Handles Color9.Click
        Color9.Background = ColorRectangle.Fill
    End Sub

    Private Sub Gradiant1_Click(sender As Object, e As RoutedEventArgs) Handles Gradiant1.Click
        G1 = Color.FromRgb(RedSlider.Value, BlueSlider.Value, GreenSlider.Value)
        Gradiant1.Background = New SolidColorBrush(G1)
    End Sub

    Private Sub Gradient2_Click(sender As Object, e As RoutedEventArgs) Handles Gradiant2.Click
        G2 = Color.FromRgb(RedSlider.Value, BlueSlider.Value, GreenSlider.Value)
        Gradiant2.Background = New SolidColorBrush(G2)
    End Sub

    Private Sub Radial_Button_Click(sender As Object, e As RoutedEventArgs) Handles Radial_Button.Click
        ColorRectangle.Fill = New RadialGradientBrush(G1, G2)
    End Sub

    Private Sub Radial_Linear_Click(sender As Object, e As RoutedEventArgs) Handles Radial_Linear.Click
        ColorRectangle.Fill = New LinearGradientBrush(G1, G2, Radial_Linear_Slider.Value)
    End Sub

    Private Sub Radial_Linear_Slider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        ColorRectangle.Fill = New LinearGradientBrush(G1, G2, Radial_Linear_Slider.Value)
    End Sub
    Sub SetLinearGradient()
        ColorRectangle.Fill = New LinearGradientBrush(G1, G2, Angle_Slider.Value)
    End Sub

    Private Sub Angle_Slider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        SetLinearGradient()
    End Sub
    Private Sub MyParentCanvas_MouseMove(sender As Object, e As MouseEventArgs)
        Select Case Shape
            Case "Ellipse"
                Dim myImageBrush As New ImageBrush(Circle.Source)
                Dim myCanvas As New Canvas
                myCanvas.Width = WidthSlider.Value
                myCanvas.Height = HeightSlider.Value
                myCanvas.Background = myImageBrush
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(myCanvas, p.X)
                Canvas.SetTop(myCanvas, p.Y)
                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(myCanvas)
                End If

            Case "Rectangle"
                Dim myImageBrush As New ImageBrush(Rectangle.Source)
                Dim myCanvas As New Canvas
                myCanvas.Width = WidthSlider.Value
                myCanvas.Height = HeightSlider.Value
                myCanvas.Background = myImageBrush
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(myCanvas, p.X)
                Canvas.SetTop(myCanvas, p.Y)

                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(myCanvas)
                End If

            Case "Triangle"
                Dim el As New Polygon
                el.Width = WidthSlider.Value
                el.Height = HeightSlider.Value
                el.Fill = ColorRectangle.Fill
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(el, p.X)
                Canvas.SetTop(el, p.Y)

                el.Points.Add(New Point(0, 0))
                el.Points.Add(New Point(WidthSlider.Value, 0))
                el.Points.Add(New Point(HeightSlider.Value, HeightSlider.Value))

                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If

            Case "Pentagon"
                Dim el As New Polygon
                el.Width = WidthSlider.Value
                el.Height = HeightSlider.Value
                el.Fill = ColorRectangle.Fill
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(el, p.X)
                Canvas.SetTop(el, p.Y)

                el.Points.Add(New Point(0, 10))
                el.Points.Add(New Point(11, 0))
                el.Points.Add(New Point(10, -11))
                el.Points.Add(New Point(-10, -11))
                el.Points.Add(New Point(-11, 0))







                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If

            Case "polygon"
                Dim el As New Polygon
                el.Fill = ColorRectangle.Fill
                Dim numpoints As Integer = NumberofSidesSlider.Value
                For index = 0 To numpoints - 1
                    Dim angle As Decimal
                    angle = (2 * Math.PI / numpoints) * index
                    el.Points.Add(New Point(Math.Cos(angle) * WidthSlider.Value, Math.Sin(angle) * WidthSlider.Value))
                Next
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(el, p.X)
                Canvas.SetTop(el, p.Y)

                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If

            Case "Hexagon"
                Dim el As New Polygon
                el.Width = WidthSlider.Value
                el.Height = HeightSlider.Value
                el.Fill = ColorRectangle.Fill
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(el, p.X)
                Canvas.SetTop(el, p.Y)

                el.Points.Add(New Point(-11, 12))
                el.Points.Add(New Point(-15, 0.5))
                el.Points.Add(New Point(-11, -13))
                el.Points.Add(New Point(11, -13))
                el.Points.Add(New Point(15, 0.5))
                el.Points.Add(New Point(11, 12))







                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If

            Case Else

        End Select

        From_Slider.Maximum = drawingCanvas.Children.Count - 1
        To_Slider.Maximum = drawingCanvas.Children.Count - 1
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Window_Loaded_1(sender As Object, e As RoutedEventArgs)
        G1 = Colors.Red
        Gradiant1.Background = New SolidColorBrush(G1)

        G2 = Colors.Green
        Gradiant2.Background = New SolidColorBrush(G2)
        SetLinearGradient()
    End Sub

    Private Sub Ellipse_Button_Click(sender As Object, e As RoutedEventArgs) Handles Ellipse_Button.Click
        Shape = "Ellipse"
    End Sub

    Private Sub Rectangle_Button_Click(sender As Object, e As RoutedEventArgs) Handles Rectangle_Button.Click
        Shape = "Rectangle"
    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As RoutedEventArgs) Handles Clear_Button.Click
        drawingCanvas.Children.Clear()
    End Sub

    Private Sub Triangle_Button_Click(sender As Object, e As RoutedEventArgs) Handles Triangle_Button.Click
        Shape = "Triangle"
    End Sub

    Private Sub Pentagon_Button_Click(sender As Object, e As RoutedEventArgs) Handles Pentagon_Button.Click
        Shape = "Pentagon"
    End Sub

    Private Sub Polygon_Button_Click(sender As Object, e As RoutedEventArgs) Handles Polygon_Button.Click
        Shape = "polygon"
    End Sub

    Private Sub NumberofSidesSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))

    End Sub

    Private Sub Hexagon_Button_Click(sender As Object, e As RoutedEventArgs) Handles Hexagon_Button.Click
        Shape = "Hexagon"
    End Sub

    Private Sub HeightSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))

    End Sub

    Private Sub DELETE_Button_Click(sender As Object, e As RoutedEventArgs) Handles DELETE_Button.Click
        drawingCanvas.Children.RemoveRange(From_Slider.Value, To_Slider.Value - From_Slider.Value)
        From_Slider.Maximum = drawingCanvas.Children.Count - 1
        To_Slider.Maximum = drawingCanvas.Children.Count - 1
    End Sub

    Private Sub Save_Button_Click(sender As Object, e As RoutedEventArgs) Handles Save_Button.Click
        ExportToPng(drawingCanvas)
    End Sub

    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using

        '

        surface.LayoutTransform = transform

        Canvas.SetLeft(drawingCanvas, 200)

        Canvas.SetTop(drawingCanvas, 10)

    End Sub

    Private Sub drawingCanvas_Loaded(sender As Object, e As RoutedEventArgs)
        Dim dt As DispatcherTimer = New DispatcherTimer()
        AddHandler dt.Tick, AddressOf dispatcherTimer_Tick

        dt.Interval = New TimeSpan(0, 0, 1)
        dt.Start()


    End Sub

    Public Sub dispatcherTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        For Each u In drawingCanvas.Children
            Canvas.SetLeft(u, Canvas.GetLeft(u) + LeftRightTrackBar.Value)
            Canvas.SetTop(u, Canvas.GetTop(u) + UpDownTrackBar.Value)
        Next

    End Sub


End Class

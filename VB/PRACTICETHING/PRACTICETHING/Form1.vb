Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Box1 As New BOX
        Box1.Height = HeightTextBox.Text
        Box1.Length = LengthTextBox.Text
        Box1.Width = WidthTextBox.Text
        Integer.TryParse(LengthTextBox.Text)
        Integer.TryParse(WidthTextBox.Text)
        Integer.TryParse(HeightTextBox.Text)
    End Sub
End Class

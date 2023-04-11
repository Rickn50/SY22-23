Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Box1 As New BOX1

        Integer.TryParse(LengthTextBox.Text, Box1.Length)
        Integer.TryParse(WidthTextBox.Text, Box1.Width)
        Integer.TryParse(HeightTextBox.Text, Box1.Height)
        VolumeLabel.Text = Box1.Volume
    End Sub
End Class

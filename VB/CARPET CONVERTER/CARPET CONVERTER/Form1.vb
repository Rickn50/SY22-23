Imports System.IO
Imports System.Security.Cryptography

Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Length As Decimal
        Dim Width As Decimal
        Dim Cost As Decimal

        Decimal.TryParse(LengthTextBox.Text, Length)
        Decimal.TryParse(WidthTextBox.Text, Width)
        Decimal.TryParse(PriceTextBox.Text, Cost)

        Label1.Text = sender.text
        If sender.text = "Wool" Then
            DisplayPictureBox.Image = WoolPictureBox.Image
            PriceTextBox.Text = 1.3
        End If

        If sender.text = "Berber" Then
            DisplayPictureBox.Image = BerberPictureBox.Image
            PriceTextBox.Text = 2.5
        End If

        If sender.text = "Persian" Then
            DisplayPictureBox.Image = PersianPictureBox.Image
            PriceTextBox.Text = 1.0
        End If

        CostTextBox.Text = (Length * Width * Cost).ToString("C2")

    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles WidthTrackBar.Scroll
        WidthTextBox.Text = sender.Value
    End Sub

    Private Sub LengthTrackBar_Scroll(sender As Object, e As EventArgs) Handles LengthTrackBar.Scroll
        LengthTextBox.Text = sender.Value
    End Sub
End Class

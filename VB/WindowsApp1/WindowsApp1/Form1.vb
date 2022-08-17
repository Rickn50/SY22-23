Public Class Form1
    Private Sub LuffyButton_Click(sender As Object, e As EventArgs) Handles LuffyButton.Click
        displaypicturebox.Image = luffyPictureBox.Image
        namelabel.Text = "SnakeMan Luffy"
        heightlabel.Text = "9 feet"
        legslabel.Text = "Speed"
    End Sub

    Private Sub bouncemanluffyButton_Click(sender As Object, e As EventArgs) Handles bouncemanluffyButton.Click
        displaypicturebox.Image = BounceManPictureBox.Image
        namelabel.Text = "Bounce Man Luffy"
        heightlabel.Text = "13 feet"
        legslabel.Text = "Strength"
    End Sub

    Private Sub TankmanButton_Click(sender As Object, e As EventArgs) Handles TankmanButton.Click
        displaypicturebox.Image = TankManPictureBox.Image
        namelabel.Text = "Tank Man Luffy"
        heightlabel.Text = "22-24 feet"
        legslabel.Text = "Defense"
    End Sub

    Private Sub Gear5Button_Click(sender As Object, e As EventArgs) Handles Gear5Button.Click
        displaypicturebox.Image = Gear5PictureBox.Image
        namelabel.Text = "Gear 5 Luffy"
        heightlabel.Text = "5 feet"
        legslabel.Text = "Crazy attacks"
    End Sub

    Private Sub GearSecondButton_Click(sender As Object, e As EventArgs) Handles GearSecondButton.Click
        displaypicturebox.Image = SecondGearPictureBox.Image
        namelabel.Text = "Second Gear Luffy"
        heightlabel.Text = "5 feet"
        legslabel.Text = "Small power up"
    End Sub
End Class

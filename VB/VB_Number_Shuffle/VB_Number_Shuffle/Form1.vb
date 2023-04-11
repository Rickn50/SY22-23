Public Class Form1
    Public Counter As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Shuffle()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call EmptySpotChecker(Button1, Button2)
        Call EmptySpotChecker(Button1, Button5)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Call Shuffle()
    End Sub
End Class

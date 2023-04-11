Public Class Frm2DPlatformmer
    Dim MoveSpeed As Integer = 15

    Private Sub Frm2DPlatformmer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Start()
        End Select
    End Sub

    Private Sub TmrRight_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        PicPlayer.Left += MoveSpeed
    End Sub
End Class

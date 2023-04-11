Public Class Enemy
    Dim MoveRight As Boolean
    Public Property Picture As PictureBox
    Public Property MoveSpeed As Integer
    Public Property BoundaryPlatform As PictureBox

    Public Sub Move()
        If Picture.Left > BoundaryPlatform.Left + BoundaryPlatform.Width Then
            MoveRight = False
        End If
        If Picture.Left < BoundaryPlatform.Left Then
            MoveRight = True
        End If
        If MoveRight Then
            Picture.Left += MoveSpeed
        Else
            Picture.Left -= MoveSpeed
        End If


    End Sub


End Class

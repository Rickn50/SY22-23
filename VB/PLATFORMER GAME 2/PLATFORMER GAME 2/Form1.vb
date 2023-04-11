Public Class Frm2DPlatformmer
    Dim E1 As New Enemy
    Dim E2 As New Enemy
    Dim MoveSpeed As Integer = 15
    Dim isJumping As Boolean
    Dim Coin As Integer
    Dim Spike As Integer


    Private Sub Frm2DPlatformmer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Start()
            Case Keys.Left
                TmrLeft.Start()
            Case Keys.Up
                TmrUp.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub TmrRight_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        PicPlayer.Left += MoveSpeed
    End Sub

    Private Sub Frm2DPlatformmer_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Stop()
            Case Keys.Left
                TmrLeft.Stop()
            Case Keys.Up
                TmrUp.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub TmrLeft_Tick(sender As Object, e As EventArgs) Handles TmrLeft.Tick
        PicPlayer.Left -= MoveSpeed
    End Sub

    Private Sub TmrUp_Tick(sender As Object, e As EventArgs) Handles TmrUp.Tick
        PicPlayer.Top -= MoveSpeed
    End Sub

    Private Sub Frm2DPlatformmer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        E1.Picture = PicEnemy
        E1.MoveSpeed = 1
        TmrGameLogic.Start()
        E1.BoundaryPlatform = PictureBox1

        E2.Picture = PicEnemy2
        E2.BoundaryPlatform = PictureBox3
        E2.MoveSpeed = 1


    End Sub

    Private Sub TmrGameLogic_Tick(sender As Object, e As EventArgs) Handles TmrGameLogic.Tick
        E1.Move()
        E2.Move()
        If PicPlayer.Bounds.IntersectsWith(PicAir.Bounds) Then
            If isJumping = False Then
                TmrGravity.Start()
            End If
        ElseIf PicPlayer.Bounds.IntersectsWith(PicGround.Bounds) Then
            TmrGravity.Stop()
        End If

        For Each B As Control In Me.Controls
            If TypeOf B Is PictureBox Then
                If B.Tag = "Bound" Then
                    If PicPlayer.Bounds.IntersectsWith(B.Bounds) Then
                        TmrGravity.Stop()
                    End If
                End If
            End If

            If B.Tag = "Coin" Then
                If B.Visible And PicPlayer.Bounds.IntersectsWith(B.Bounds) Then
                    B.Visible = False
                    Coin += 1
                    ScoreLabel.Text = Coin
                End If
            End If

            If B.Tag = "Spike" Then
                If B.Visible And PicPlayer.Bounds.IntersectsWith(B.Bounds) Then
                    B.Visible = False
                    Spike -= 1
                    ScoreLabel.Text = Spike
                End If
            End If

            If B.Tag = "GameOver" And PicPlayer.Bounds.IntersectsWith(B.Bounds) Then
                MsgBox("GameOver")
                Coin = 0
                ScoreLabel.Text = Coin
                TmrGameLogic.Stop()
            End If
        Next
        E1.Move()
        E2.Move()

    End Sub

    Private Sub TmrGravity_Tick(sender As Object, e As EventArgs) Handles TmrGravity.Tick
        PicPlayer.Top += MoveSpeed
    End Sub

    Private Sub ScoreLabel_Click(sender As Object, e As EventArgs) Handles ScoreLabel.Click

    End Sub
End Class

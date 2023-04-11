<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm2DPlatformmer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.PicAir = New System.Windows.Forms.PictureBox()
        Me.PicGround = New System.Windows.Forms.PictureBox()
        Me.PicPlayer = New System.Windows.Forms.PictureBox()
        Me.TmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.TmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PicEnemy = New System.Windows.Forms.PictureBox()
        Me.PicEnemy2 = New System.Windows.Forms.PictureBox()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEnemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmrRight
        '
        Me.TmrRight.Interval = 20
        '
        'PicAir
        '
        Me.PicAir.Location = New System.Drawing.Point(5, 5)
        Me.PicAir.Name = "PicAir"
        Me.PicAir.Size = New System.Drawing.Size(797, 329)
        Me.PicAir.TabIndex = 0
        Me.PicAir.TabStop = False
        '
        'PicGround
        '
        Me.PicGround.BackColor = System.Drawing.Color.SpringGreen
        Me.PicGround.Location = New System.Drawing.Point(-5, 372)
        Me.PicGround.Name = "PicGround"
        Me.PicGround.Size = New System.Drawing.Size(816, 97)
        Me.PicGround.TabIndex = 1
        Me.PicGround.TabStop = False
        '
        'PicPlayer
        '
        Me.PicPlayer.BackColor = System.Drawing.Color.Red
        Me.PicPlayer.Location = New System.Drawing.Point(12, 315)
        Me.PicPlayer.Name = "PicPlayer"
        Me.PicPlayer.Size = New System.Drawing.Size(50, 51)
        Me.PicPlayer.TabIndex = 2
        Me.PicPlayer.TabStop = False
        '
        'TmrLeft
        '
        Me.TmrLeft.Interval = 20
        '
        'TmrUp
        '
        Me.TmrUp.Interval = 20
        '
        'TmrGameLogic
        '
        Me.TmrGameLogic.Interval = 20
        '
        'TmrGravity
        '
        Me.TmrGravity.Interval = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Salmon
        Me.PictureBox1.Location = New System.Drawing.Point(534, 257)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 20)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Salmon
        Me.PictureBox2.Location = New System.Drawing.Point(453, 133)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(117, 20)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "Bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Salmon
        Me.PictureBox3.Location = New System.Drawing.Point(218, 172)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(117, 48)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "Bound"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Points"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Location = New System.Drawing.Point(68, 22)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(14, 16)
        Me.ScoreLabel.TabIndex = 7
        Me.ScoreLabel.Text = "0"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox4.Location = New System.Drawing.Point(293, 89)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 33)
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "Coin"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox5.Location = New System.Drawing.Point(262, 89)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 33)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "Coin"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox6.Location = New System.Drawing.Point(585, 218)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(24, 33)
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "Coin"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox7.Location = New System.Drawing.Point(546, 217)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(24, 33)
        Me.PictureBox7.TabIndex = 10
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "Coin"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox8.Location = New System.Drawing.Point(495, 54)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(24, 33)
        Me.PictureBox8.TabIndex = 13
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "Coin"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox9.Location = New System.Drawing.Point(465, 54)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(24, 33)
        Me.PictureBox9.TabIndex = 12
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "Coin"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox10.Location = New System.Drawing.Point(525, 54)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(24, 33)
        Me.PictureBox10.TabIndex = 14
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "Coin"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox11.Location = New System.Drawing.Point(232, 89)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(24, 33)
        Me.PictureBox11.TabIndex = 15
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "Coin"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox12.Location = New System.Drawing.Point(722, 35)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(24, 33)
        Me.PictureBox12.TabIndex = 16
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "Coin"
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox13.Image = Global.PLATFORMER_GAME_2.My.Resources.Resources._145_1458638_spikes_pixel_art_png_transparent_png
        Me.PictureBox13.Location = New System.Drawing.Point(465, 103)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(100, 34)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 17
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Tag = "Spike"
        '
        'PicEnemy
        '
        Me.PicEnemy.BackColor = System.Drawing.Color.Maroon
        Me.PicEnemy.Location = New System.Drawing.Point(615, 217)
        Me.PicEnemy.Name = "PicEnemy"
        Me.PicEnemy.Size = New System.Drawing.Size(37, 32)
        Me.PicEnemy.TabIndex = 19
        Me.PicEnemy.TabStop = False
        Me.PicEnemy.Tag = "GameOver"
        '
        'PicEnemy2
        '
        Me.PicEnemy2.BackColor = System.Drawing.Color.Maroon
        Me.PicEnemy2.Location = New System.Drawing.Point(249, 134)
        Me.PicEnemy2.Name = "PicEnemy2"
        Me.PicEnemy2.Size = New System.Drawing.Size(37, 32)
        Me.PicEnemy2.TabIndex = 20
        Me.PicEnemy2.TabStop = False
        Me.PicEnemy2.Tag = "GameOver"
        '
        'Frm2DPlatformmer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.PicEnemy2)
        Me.Controls.Add(Me.PicEnemy)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicPlayer)
        Me.Controls.Add(Me.PicGround)
        Me.Controls.Add(Me.PicAir)
        Me.Name = "Frm2DPlatformmer"
        Me.Text = "Form1"
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicEnemy2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TmrRight As Timer
    Friend WithEvents PicAir As PictureBox
    Friend WithEvents PicGround As PictureBox
    Friend WithEvents PicPlayer As PictureBox
    Friend WithEvents TmrLeft As Timer
    Friend WithEvents TmrUp As Timer
    Friend WithEvents TmrGameLogic As Timer
    Friend WithEvents TmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PicEnemy As PictureBox
    Friend WithEvents PicEnemy2 As PictureBox
End Class

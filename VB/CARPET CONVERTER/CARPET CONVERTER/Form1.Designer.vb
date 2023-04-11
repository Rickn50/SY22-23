<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PersianPictureBox = New System.Windows.Forms.PictureBox()
        Me.BerberPictureBox = New System.Windows.Forms.PictureBox()
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.WoolPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.WidthTextBox = New System.Windows.Forms.TextBox()
        Me.LengthTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.LengthTrackBar = New System.Windows.Forms.TrackBar()
        Me.WidthTrackBar = New System.Windows.Forms.TrackBar()
        CType(Me.PersianPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BerberPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WoolPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LengthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Wool", "Berber", "Persian"})
        Me.ComboBox1.Location = New System.Drawing.Point(303, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'PersianPictureBox
        '
        Me.PersianPictureBox.Image = Global.CARPET_CONVERTER.My.Resources.Resources._209581_3
        Me.PersianPictureBox.Location = New System.Drawing.Point(504, 46)
        Me.PersianPictureBox.Name = "PersianPictureBox"
        Me.PersianPictureBox.Size = New System.Drawing.Size(102, 130)
        Me.PersianPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PersianPictureBox.TabIndex = 6
        Me.PersianPictureBox.TabStop = False
        Me.PersianPictureBox.Visible = False
        '
        'BerberPictureBox
        '
        Me.BerberPictureBox.Image = Global.CARPET_CONVERTER.My.Resources.Resources.BER5509_B
        Me.BerberPictureBox.Location = New System.Drawing.Point(322, 46)
        Me.BerberPictureBox.Name = "BerberPictureBox"
        Me.BerberPictureBox.Size = New System.Drawing.Size(102, 130)
        Me.BerberPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BerberPictureBox.TabIndex = 5
        Me.BerberPictureBox.TabStop = False
        Me.BerberPictureBox.Visible = False
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.Location = New System.Drawing.Point(290, 210)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(465, 228)
        Me.DisplayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DisplayPictureBox.TabIndex = 4
        Me.DisplayPictureBox.TabStop = False
        '
        'WoolPictureBox
        '
        Me.WoolPictureBox.Image = Global.CARPET_CONVERTER.My.Resources.Resources.Align_Pebble_1__19257
        Me.WoolPictureBox.Location = New System.Drawing.Point(168, 46)
        Me.WoolPictureBox.Name = "WoolPictureBox"
        Me.WoolPictureBox.Size = New System.Drawing.Size(102, 130)
        Me.WoolPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WoolPictureBox.TabIndex = 1
        Me.WoolPictureBox.TabStop = False
        Me.WoolPictureBox.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Width"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Length"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Price"
        '
        'CostTextBox
        '
        Me.CostTextBox.Location = New System.Drawing.Point(86, 210)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CostTextBox.TabIndex = 12
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Location = New System.Drawing.Point(85, 242)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(100, 22)
        Me.WidthTextBox.TabIndex = 13
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Location = New System.Drawing.Point(85, 275)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(100, 22)
        Me.LengthTextBox.TabIndex = 14
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(85, 306)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PriceTextBox.TabIndex = 15
        '
        'LengthTrackBar
        '
        Me.LengthTrackBar.Location = New System.Drawing.Point(12, 15)
        Me.LengthTrackBar.Maximum = 50
        Me.LengthTrackBar.Name = "LengthTrackBar"
        Me.LengthTrackBar.Size = New System.Drawing.Size(104, 56)
        Me.LengthTrackBar.TabIndex = 16
        '
        'WidthTrackBar
        '
        Me.WidthTrackBar.Location = New System.Drawing.Point(12, 77)
        Me.WidthTrackBar.Maximum = 50
        Me.WidthTrackBar.Name = "WidthTrackBar"
        Me.WidthTrackBar.Size = New System.Drawing.Size(104, 56)
        Me.WidthTrackBar.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.WidthTrackBar)
        Me.Controls.Add(Me.LengthTrackBar)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.LengthTextBox)
        Me.Controls.Add(Me.WidthTextBox)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PersianPictureBox)
        Me.Controls.Add(Me.BerberPictureBox)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Controls.Add(Me.WoolPictureBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PersianPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BerberPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WoolPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LengthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents WoolPictureBox As PictureBox
    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents BerberPictureBox As PictureBox
    Friend WithEvents PersianPictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents WidthTextBox As TextBox
    Friend WithEvents LengthTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents LengthTrackBar As TrackBar
    Friend WithEvents WidthTrackBar As TrackBar
End Class

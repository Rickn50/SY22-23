Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Form1

    Dim Count As Integer
    Dim Current As Integer
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        DisplayPictureBox.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub DisplayPictureBox_Click(sender As Object, e As EventArgs) Handles DisplayPictureBox.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Sub Load()
        Dim InFile As StreamReader
        Dim IDX As Integer
        If IO.File.Exists("Mario_Games.txt") Then
            InFile = IO.File.OpenText("Mario_Games.txt")
            While InFile.Peek <> -1
                Lines(IDX) = InFile.ReadLine
                MarioGamesComboBox.Items.Add(GetMario(IDX).Name)
                IDX = IDX + 1
            End While
            Count = IDX
            DebugTextBox.Text = Count
            ShowMarioGames(0)
            InFile.Close()
        End If
    End Sub

    Sub ShowMarioGames(Index As Integer)
        Dim Fields() As String
        Fields = Lines(Index).Split("|")
        NameTextBox.Text = Fields(0)
        YearTextBox.Text = Fields(1)
        ConsoleTextBox.Text = Fields(2)
        CharactersTextBox.Text = Fields(3)
        MainVillainTextBox.Text = Fields(4)
        TypeTextBox.Text = Fields(5)
        If IO.File.Exists(Fields(6)) Then
            DisplayPictureBox.Load(Fields(6))
        End If
        If IO.File.Exists(Fields(7)) Then
            DisplayPictureBox2.Load(Fields(7))
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim L As String
        L = NameTextBox.Text
        L += "|"
        L += YearTextBox.Text
        L += "|"
        L += ConsoleTextBox.Text
        L += "|"
        L += CharactersTextBox.Text
        L += "|"
        L += MainVillainTextBox.Text
        L += "|"
        L += TypeTextBox.Text
        L += "|"
        L += DisplayPictureBox.ImageLocation
        L += "|"
        L += DisplayPictureBox2.ImageLocation
        Lines(Current) = L
        Save()
    End Sub

    Public Sub Save()
        Dim outFile As IO.StreamWriter
        outFile = IO.File.CreateText("Mario_Games.txt")
        For index = 0 To Count
            If Lines(index) <> "" Then
                outFile.WriteLine(Lines(index))
            End If

        Next
        outFile.Close()
    End Sub

    Sub Clear()
        NameTextBox.Clear()
        YearTextBox.Clear()
        ConsoleTextBox.Clear()
        CharactersTextBox.Clear()
        MainVillainTextBox.Clear()
        TypeTextBox.Clear()
        DisplayPictureBox.Image = Nothing
        DisplayPictureBox2.Image = Nothing
    End Sub
    Dim Lines(100) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
    End Sub
    Structure MARIO_GAME
        Dim Name As String
        Dim Year As String
        Dim Console As String
        Dim Characters As String
        Dim MainVillain As String
        Dim Type As String
    End Structure
    Function GetMario(Index As Integer) As MARIO_GAME
        Dim Fields() As String
        Dim C As MARIO_GAME
        Fields = Lines(Index).Split("|")
        C.Name = Fields(0)
        C.Year = Fields(1)
        C.Console = Fields(2)
        C.Characters = Fields(3)
        C.MainVillain = Fields(4)

        C.Type = (Fields(5))
        Return C

    End Function

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Clear()
        Current = Count
        Count = Count + 1
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Lines(Current) = ""
        Save()
        Load()
    End Sub

    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        Current = 0
        ShowMarioGames(Current)
    End Sub

    Private Sub LastButton_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        Current = Count - 1
        ShowMarioGames(Current)
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If Current > 0 Then
            Current = Current - 1
            ShowMarioGames(Current)
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If Current < Count - 1 Then
            Current = Current + 1
            ShowMarioGames(Current)
        End If
    End Sub

    Private Sub CountriesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MarioGamesComboBox.SelectedIndexChanged
        ShowMarioGames(MarioGamesComboBox.SelectedIndex)
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles DisplayPictureBox2.Click
        OpenFileDialog2.ShowDialog()
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        DisplayPictureBox2.Load(OpenFileDialog2.FileName)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
End Class

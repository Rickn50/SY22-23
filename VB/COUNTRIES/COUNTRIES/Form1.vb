Imports System.IO

Public Class Form1

    Dim Count As Integer
    Dim Current As Integer
    Structure Country
        Dim Name As String
        Dim Capital As String
        Dim Population As String
        Dim Size As String
        Dim Picture As String
    End Structure

    Function GetCountry(Index As Integer) As Country
        Dim Fields() As String
        Dim C As Country
        Fields = Lines(Index).Split("|")
        C.Name = Fields(0)
        C.Capital = Fields(1)
        C.Population = Fields(2)
        C.Size = Fields(3)

        C.Picture = (Fields(4))
        Return C

    End Function

    Private Sub DisplayPictureBox_Click(sender As Object, e As EventArgs) Handles DisplayPictureBox.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        DisplayPictureBox.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim L As String
        L = CountryTextBox.Text
        L += "|"
        L += CapitalTextBox.Text
        L += "|"
        L += PopulationTextBox.Text
        L += "|"
        L += SizeTextBox.Text
        L += "|"
        L += DisplayPictureBox.ImageLocation
        Lines(Current) = L
        Save()
    End Sub

    Public Sub Save()
        Dim outFile As IO.StreamWriter
        outFile = IO.File.CreateText("Countries.txt")
        For index = 0 To Count
            If Lines(index) <> "" Then
                outFile.WriteLine(Lines(index))
            End If

        Next
        outFile.Close()
    End Sub

    Sub Clear()
        CountryTextBox.Clear()
        CapitalTextBox.Clear()
        PopulationTextBox.Clear()
        SizeTextBox.Clear()
        DisplayPictureBox.Image = Nothing
    End Sub
    Dim Lines(100) As String

    Sub Load()
        Dim InFile As StreamReader
        Dim IDX As Integer
        If IO.File.Exists("Countries.txt") Then
            InFile = IO.File.OpenText("Countries.txt")
            While InFile.Peek <> -1
                Lines(IDX) = InFile.ReadLine
                CountriesComboBox.Items.Add(GetCountry(IDX).Name)
                IDX = IDX + 1
            End While
            Count = IDX
            DebugTextBox.Text = Count
            ShowCountry(0)
            InFile.Close()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
    End Sub
    Sub ShowCountry(index As Integer)
        Dim fields() As String
        If index < 0 Or Lines(index) = "" Then
            Return
        End If
        fields = Lines(index).Split("|")
        If fields.Count > 0 Then CountryTextBox.Text = fields(0)
        If fields.Count > 1 Then CapitalTextBox.Text = fields(1)
        If fields.Count > 2 Then PopulationTextBox.Text = fields(2)
        If fields.Count > 3 Then SizeTextBox.Text = fields(3)
        If fields.Count > 4 Then
            If IO.File.Exists(fields(4)) Then
                DisplayPictureBox.Load(fields(4))
            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        Current = 0
        ShowCountry(Current)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        Current = Count - 1
        ShowCountry(Current)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If Current < Count - 1 Then
            Current = Current + 1
            ShowCountry(Current)
        End If
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If Current > 0 Then
            Current = Current - 1
            ShowCountry(Current)
        End If
    End Sub

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

    Private Sub CountriesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CountriesComboBox.SelectedIndexChanged
        ShowCountry(CountriesComboBox.SelectedIndex)
    End Sub

    Private Sub DebugTextBox_TextChanged(sender As Object, e As EventArgs) Handles DebugTextBox.TextChanged

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

    End Sub
End Class

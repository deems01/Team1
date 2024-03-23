Module NameSearchFunctions

    Private SearchedFilmName As String
    Private inputData As New List(Of String) From {"tere", "veiko", "uku"}

    Public Sub setSearchedFilmName(name As String)
        SearchedFilmName = name
    End Sub

    Public Function getSearchedFilmName()
        Return SearchedFilmName
    End Function

    Public Sub AddPanelsDynamically(resultForm As Form)
        Dim startX As Integer = 12
        Dim startY As Integer = 45
        Dim spacing As Integer = 30
        Dim width As Integer = 539
        Dim height As Integer = 25
        Dim i As Integer = 0
        ' Loop through the input data
        For Each item As String In inputData
            ' Create a new label
            Dim newPanel As New Panel()
            Dim newLabel As New Label()

            newPanel.BackColor = Color.Red
            newPanel.AutoSize = True
            newPanel.Width = width
            newPanel.Height = height
            newPanel.Location = New Point(startX, startY + (i * spacing))
            ' Set properties for the new label
            newLabel.Text = item
            newLabel.AutoSize = True ' Adjust size automatically based on content
            ' You can set other properties as needed (e.g., font, color, etc.)

            ' Add the new label to the FlowLayoutPanel
            newPanel.Controls.Add(newLabel)
            resultForm.Controls.Add(newPanel)
            i += 1
        Next
    End Sub
End Module

Imports NameSearchDLL

Module NameSearchFunctions

    Private ReadOnly apiKey As String = "36d0af349fe1d35fc3babe753de0aa8e"
    Private SearchedFilmName As String
    Private inputData As New List(Of Movie)()

    Public Sub SetSearchedFilmName(name As String)
        SearchedFilmName = name
    End Sub

    Public Function GetSearchedFilmName()
        Return SearchedFilmName
    End Function

    Public Async Sub AddPanelsDynamically(resultForm As Form)
        Dim nameSearch As New CNameSearch(apiKey)
        inputData = Await nameSearch.SearchMovieAsync(GetSearchedFilmName())

        Dim i As Integer = 0

        Dim panelStartX As Integer = 12
        Dim panelStartY As Integer = 45
        Dim spacingBetweenLabels As Integer = 25
        Dim panelWidth As Integer = 539
        Dim initialPanelHeight As Integer = 75
        Dim currentYPosition As Integer

        For Each movie As Movie In inputData
            Dim newPanel As New Panel()
            newPanel.BackColor = Color.LightBlue
            newPanel.AutoSize = True
            newPanel.Width = panelWidth
            newPanel.Location = New Point(panelStartX, panelStartY)
            currentYPosition = 5

            ' Title Label
            Dim titleLabel As New Label()
            titleLabel.Text = $"Title: {movie.Title}"
            titleLabel.AutoSize = True
            titleLabel.Location = New Point(5, currentYPosition)
            newPanel.Controls.Add(titleLabel)
            currentYPosition += spacingBetweenLabels

            ' Poster label
            Dim posterLabel As New Label()
            posterLabel.Text = $"Poster: {movie.PosterUrl}"
            posterLabel.AutoSize = True
            newPanel.Controls.Add(posterLabel)
            posterLabel.Location = New Point(5, currentYPosition)
            currentYPosition += spacingBetweenLabels

            ' Overview Label (added only if the overview is not empty)
            If Not String.IsNullOrWhiteSpace(movie.Overview) Then
                Dim overviewLabel As New Label()
                overviewLabel.Text = $"Overview: {movie.Overview}"
                overviewLabel.AutoSize = True
                overviewLabel.Location = New Point(5, currentYPosition)
                overviewLabel.Width = panelWidth - 10
                overviewLabel.Height = 60 ' Adjusted for potential multiline overviews
                overviewLabel.TextAlign = ContentAlignment.TopLeft
                overviewLabel.AutoEllipsis = True
                newPanel.Controls.Add(overviewLabel)
                currentYPosition += overviewLabel.Height + 5
            End If

            ' Release Date Label (Adjust position based on the presence of overview)
            Dim releaseDateLabel As New Label()
            releaseDateLabel.Text = $"Release Date: {movie.ReleaseDate.ToShortDateString()}"
            releaseDateLabel.AutoSize = True
            releaseDateLabel.Location = New Point(5, currentYPosition)
            newPanel.Controls.Add(releaseDateLabel)
            currentYPosition += spacingBetweenLabels

            ' Language Label (Adjust position based on the presence of overview)
            Dim languageLabel As New Label()
            languageLabel.Text = $"Language: {movie.Language}"
            languageLabel.AutoSize = True
            languageLabel.Location = New Point(5, currentYPosition)
            newPanel.Controls.Add(languageLabel)
            currentYPosition += spacingBetweenLabels

            ' Adjust the panel height based on the content
            newPanel.Height = currentYPosition + 5 ' Adding some padding at the bottom

            resultForm.Controls.Add(newPanel)
            panelStartY += newPanel.Height + 10
            i += 1
        Next

    End Sub

    Public Async Sub AddPosterDynamically(resultFlowPanel As FlowLayoutPanel)
        Dim nameSearch As New CNameSearch(apiKey)
        inputData = Await nameSearch.SearchMovieAsync(GetSearchedFilmName())

        For Each movie As Movie In inputData
            Dim posterPicBox As New PictureBox
            posterPicBox.Load(movie.PosterUrl)
            posterPicBox.SizeMode = PictureBoxSizeMode.StretchImage
            posterPicBox.Width = 200
            posterPicBox.Height = 300
            posterPicBox.Margin = New Padding(1)
            resultFlowPanel.Controls.Add(posterPicBox)
        Next

    End Sub

End Module

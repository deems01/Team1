Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading
Imports NameSearchDLL
Module NameSearchFunctions

    Private ReadOnly apiKey As String = "36d0af349fe1d35fc3babe753de0aa8e"
    Private SearchedFilmName As String = ""
    Private inputData As New List(Of Movie)()
    Private selectedDate As DateTime = DateTime.MinValue
    Private selectedFilmName As String = ""
    Private selectedPlace As String = ""
    Private dateFlag = 0

    Public Sub SetSelectedPlace(place As String)
        selectedPlace = place
    End Sub

    Public Function GetSelectedPlace() As String
        Return selectedPlace
    End Function


    Public Function GetDateFlag() As Integer
        Return dateFlag
    End Function

    Public Sub SetSelectedFilmName(userSelectedFilmName As String)
        selectedFilmName = userSelectedFilmName
    End Sub

    Public Function GetSelectedFilmName() As String
        Return selectedFilmName
    End Function

    Public Sub SetSelectedDate(userSelectedDate As DateTime)
        dateFlag = 1
        selectedDate = userSelectedDate
    End Sub

    Public Function GetSelectedDate() As DateTime
        Return selectedDate
    End Function

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


        If i = 0 Then
            Dim newPanel As New Panel()
            newPanel.BackColor = Color.LightBlue
            newPanel.AutoSize = True
            newPanel.Width = panelWidth
            newPanel.Location = New Point(panelStartX, panelStartY)
            currentYPosition = 5

            Dim emptyLabel As New Label()
            emptyLabel.Text = "Could not find that movie"
            emptyLabel.AutoSize = True
            emptyLabel.Location = New Point(5, currentYPosition)
            newPanel.Controls.Add(emptyLabel)
        End If

    End Sub

    Public Async Sub AddPosterDynamically(resultFlowPanel As FlowLayoutPanel)
        Dim nameSearch As New CNameSearch(apiKey)
        inputData = Await nameSearch.SearchMovieAsync(GetSearchedFilmName())

        If inputData.Count = 0 Then
            Dim panelStartX As Integer = 12
            Dim panelStartY As Integer = 45
            Dim spacingBetweenLabels As Integer = 25
            Dim panelWidth As Integer = 539
            Dim initialPanelHeight As Integer = 75
            Dim currentYPosition As Integer


            Dim newPanel As New Panel()
            newPanel.BackColor = Color.LightBlue
            newPanel.AutoSize = True
            newPanel.Width = panelWidth
            newPanel.Location = New Point(panelStartX, panelStartY)
            currentYPosition = 5

            Dim eLabel As New Label()
            eLabel.Text = "This film was not found."
            eLabel.AutoSize = True
            eLabel.Location = New Point(5, currentYPosition)
            newPanel.Controls.Add(eLabel)
            currentYPosition += spacingBetweenLabels

            resultFlowPanel.Controls.Add(newPanel)

        Else
            For Each movie As Movie In inputData
                'disregarding films with faulty poster URLs 
                If Not String.IsNullOrWhiteSpace(movie.PosterUrl) Then
                    Dim posterPicBox As New PictureBox
                    Try
                        posterPicBox.Load(movie.PosterUrl)
                        posterPicBox.SizeMode = PictureBoxSizeMode.StretchImage
                        posterPicBox.Width = 200
                        posterPicBox.Height = 300
                        posterPicBox.Margin = New Padding(1)
                        posterPicBox.Tag = movie
                        AddHandler posterPicBox.MouseEnter, AddressOf posterPicBox_MouseEnter
                        AddHandler posterPicBox.MouseLeave, AddressOf posterPicBox_MouseLeave
                        AddHandler posterPicBox.Click, AddressOf posterPicBox_Click
                        resultFlowPanel.Controls.Add(posterPicBox)
                    Catch ex As WebException
                        'log something.... or not
                    End Try
                End If
            Next
        End If


    End Sub

    Private Sub posterPicBox_Click(sender As Object, e As EventArgs)
        Dim pictureBox As PictureBox = DirectCast(sender, PictureBox)
        Dim movieTitle As String = TryCast(pictureBox.Tag.Title, String)

        If movieTitle IsNot Nothing Then
            If dateFlag = 1 Then
                'date has been selected, so let's continue movie night planning
                dateFlag = 0
                SetSelectedFilmName(movieTitle)
                UiHelpFunctions.OpenChildForm(New FormConfirmNightChoices)

                'mtea copyisin ja nyyd salvestab andmebaasi, enne sittus errori kuna polnud seda Movie informatsiooni kusalgilt saada
                Dim movie As Movie = DirectCast(pictureBox.Tag, Movie)
                FilmPageFunctions.setClickedMovie(movie)
                SaveFilmToDatabase()
                Return
            End If
        Else
            MessageBox.Show("Could not cast movie title!")
        End If
        If dateFlag = 0 Then
            'user just wants to see movie search results
            Dim movie As Movie = DirectCast(pictureBox.Tag, Movie)
            FilmPageFunctions.setClickedMovie(movie)
            UiHelpFunctions.OpenChildForm(New FormFilmPage)
        End If
        SaveFilmToDatabase()
    End Sub


    Private Sub posterPicBox_MouseEnter(sender As Object, e As EventArgs)
        Dim pictureBox As PictureBox = DirectCast(sender, PictureBox)
        pictureBox.Size = New Size(pictureBox.Width + 20, pictureBox.Height + 20) ' Increase size in every direction
        pictureBox.Location = New Point(pictureBox.Location.X - 10, pictureBox.Location.Y - 10) ' Move picture box to center
    End Sub

    Private Sub posterPicBox_MouseLeave(sender As Object, e As EventArgs)
        Dim pictureBox As PictureBox = DirectCast(sender, PictureBox)
        pictureBox.Size = New Size(pictureBox.Width - 20, pictureBox.Height - 20) ' Return to original size
        pictureBox.Location = New Point(pictureBox.Location.X + 10, pictureBox.Location.Y + 10) ' Move picture box back
    End Sub

End Module

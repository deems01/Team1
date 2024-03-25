Imports SortClass

Module CategoryFunctions

    Private pickedCategory As String
    Private enteredSearch As String

    Public Sub setPickedCategory(category As String)
        pickedCategory = category
    End Sub

    Public Function getPickedCategory()
        Return pickedCategory
    End Function

    Public Sub setSearch(search As String)
        enteredSearch = search
    End Sub

    Public Function getSearch()
        Return enteredSearch
    End Function
    Public Async Sub AddPanelsDynamically(resultForm As Form)

        ' Create an instance of TMDBClient with your API key
        Dim tmdbClient As New TMDBClient("e9bb467295d762ec5f93dffdab6761bd")

        ' Fetch popular movies
        Dim inputData As List(Of Movie)
        'inputData = Await tmdbClient.FetchPopularMovies()
        inputData = Await tmdbClient.FetchAllMovies()

        Dim sortedMovies As List(Of Movie)                             'every time it has to go here again
        Select Case pickedCategory
            Case "genre"
                sortedMovies = Await tmdbClient.GetGenres(enteredSearch)
                    'tmdbClient.SortMoviesByGenre(inputData, enteredSearch)
            Case "Old"
                sortedMovies = tmdbClient.SortMoviesByReleaseDateAscending(inputData)
            Case "New"
                sortedMovies = tmdbClient.SortMoviesByReleaseDateDescending(inputData)
            Case "Language"
                sortedMovies = tmdbClient.SortMoviesByLanguage(inputData, enteredSearch)
            Case "Company"
                sortedMovies = tmdbClient.SortMoviesByCompany(inputData, enteredSearch)
            Case "Actor"
                sortedMovies = tmdbClient.SortMoviesByActor(inputData, enteredSearch)
            Case Else
                sortedMovies = Await tmdbClient.FetchPopularMovies() ' Default to using popular movies
        End Select

        Dim panelStartX As Integer = 12
        Dim panelStartY As Integer = 45
        Dim spacingBetweenLabels As Integer = 25
        Dim panelWidth As Integer = 539
        Dim initialPanelHeight As Integer = 20

        For Each movie As Movie In sortedMovies
            Dim newPanel As New Panel()
            newPanel.BackColor = Color.LightBlue
            newPanel.AutoSize = True
            newPanel.Width = panelWidth
            newPanel.Height = initialPanelHeight
            newPanel.Location = New Point(panelStartX, panelStartY)

            ' Title Label
            Dim titleLabel As New Label()
            titleLabel.Text = movie.Title 'filmi nimi

            'poster movie.PosterUrl

            titleLabel.AutoSize = True

            newPanel.Controls.Add(titleLabel)
            resultForm.Controls.Add(newPanel)

            panelStartY += newPanel.Height + 10
        Next

    End Sub

End Module
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
        Dim tmdbClient As New TMDBClient("Your_API_Key_Here")

        ' Fetch popular movies
        Dim popularMovies As List(Of Movie) = Await tmdbClient.FetchPopularMovies()

        ' Determine which sorting function to use based on the picked category
        Dim sortedMovies As List(Of Movie)
        Select Case pickedCategory
            Case "Genre"
                sortedMovies = tmdbClient.SortMoviesByGenre(popularMovies, enteredSearch)
            Case "ReleaseDateAscending"
                sortedMovies = tmdbClient.SortMoviesByReleaseDateAscending(popularMovies)
            Case "ReleaseDateDescending"
                sortedMovies = tmdbClient.SortMoviesByReleaseDateDescending(popularMovies)
            Case "Language"
                sortedMovies = tmdbClient.SortMoviesByLanguage(popularMovies, enteredSearch)
            Case "Company"
                sortedMovies = tmdbClient.SortMoviesByCompany(popularMovies, enteredSearch)
            Case "Actor"
                sortedMovies = tmdbClient.SortMoviesByActor(popularMovies, enteredSearch)
            Case Else
                ' Handle invalid or unspecified category
                sortedMovies = popularMovies ' Default to using popular movies
        End Select

        ' Now you have the sorted list of movies, you can proceed to create panels dynamically as before...
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
            titleLabel.Text = movie.Title ' Assuming Movie class has a Title property
            titleLabel.AutoSize = True

            newPanel.Controls.Add(titleLabel)
            resultForm.Controls.Add(newPanel)

            panelStartY += newPanel.Height + 10
        Next
    End Sub

End Module
Imports SortClass
Imports RandomMovie

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

    Public Async Sub AddPosterDynamicallyCategory(resultFlowPanel As FlowLayoutPanel)
        ' Create an instance of TMDBClient with your API key
        Dim tmdbClient As New TMDBClient("e9bb467295d762ec5f93dffdab6761bd")
        Dim RandomClient As New RandomMovieRec("e9bb467295d762ec5f93dffdab6761bd")
        ' Fetch popular movies
        Dim inputData As List(Of Movie)
        'inputData = Await tmdbClient.FetchPopularMovies()
        inputData = Await tmdbClient.FetchAllMovies("Pop", "")

        Dim sortedMovies As List(Of Movie)
        sortedMovies = inputData

        Select Case pickedCategory
            Case "genre"
                sortedMovies = Await tmdbClient.GetGenres(enteredSearch)
                    'tmdbClient.SortMoviesByGenre(inputData, enteredSearch)
            Case "Old"
                sortedMovies = Await tmdbClient.FetchAllMovies("Asc", "")
            Case "New"
                sortedMovies = Await tmdbClient.FetchAllMovies("Desc", "")
            Case "Language"
                sortedMovies = Await tmdbClient.FetchAllMovies("Desc", enteredSearch)
            Case "Company"
                sortedMovies = Await tmdbClient.GetMoviesByCompany(enteredSearch)
            Case "Actor"
                sortedMovies = Await tmdbClient.GetMoviesByActor(enteredSearch)
            Case "Random"
                sortedMovies.Clear() ' Clear the contents of the list
                Dim randomMovie As Movie = Await RandomClient.GetRandomMovie()
                sortedMovies.Add(randomMovie)
            Case "Popular"
                sortedMovies = inputData ' popular movies kui kuskil vaja, pärast saab ära deletida siit
            Case Else
                sortedMovies = inputData ' Default to using popular movies
        End Select

        'Image = movie.PosterUrl

        For Each movie As Movie In sortedMovies
            Dim posterPicBox As New PictureBox
            If Not (movie.PosterUrl = "") Then
                posterPicBox.Load(movie.PosterUrl)
                posterPicBox.SizeMode = PictureBoxSizeMode.StretchImage
                posterPicBox.Width = 200
                posterPicBox.Height = 300
                posterPicBox.Margin = New Padding(1)
                AddHandler posterPicBox.MouseEnter, AddressOf posterPicBox_MouseEnter
                AddHandler posterPicBox.MouseLeave, AddressOf posterPicBox_MouseLeave
                AddHandler posterPicBox.Click, AddressOf posterPicBox_Click
                resultFlowPanel.Controls.Add(posterPicBox)

            End If
        Next

    End Sub

    Private Sub posterPicBox_Click(sender As Object, e As EventArgs)
        Dim pictureBox As PictureBox = DirectCast(sender, PictureBox)
        UiHelpFunctions.OpenChildForm(New FormFilmPage)
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
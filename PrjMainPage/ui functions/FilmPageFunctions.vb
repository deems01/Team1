Imports FilmDatabase.FilmdbModel
Imports FilmDatabase
Imports WatchStatistics
Imports DllHandler
Module FilmPageFunctions

    Private clickedMovie As Object

    Sub setClickedMovie(movie As Object)
        clickedMovie = movie
    End Sub

    Function getClickedMovie()
        Return clickedMovie
    End Function

    Sub attachPoster(pbPoster As PictureBox)
        pbPoster.Load(clickedMovie.PosterUrl)
        pbPoster.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Sub attachFilmTitle(lblTitle As Label)
        lblTitle.Text = clickedMovie.Title
    End Sub

    Sub attachFilmOverview(textBox As RichTextBox)
        textBox.Text = clickedMovie.Overview
    End Sub

    Async Sub SaveFilmToDatabase()
        Dim db As New FilmdbModel()
        Dim film As New FilmDatabase.Films()
        Dim stat As New WatchStatistics.Statistics()
        film.Imdb_Id = clickedMovie.Id
        film.Name = clickedMovie.Title
        film.ReleaseYear = clickedMovie.ReleaseDate
        film.FilmLength = Await stat.GetMovieLength(clickedMovie.Id)
        film.Genre = If(clickedMovie.Genres IsNot Nothing, clickedMovie.Genres(0), String.Empty)
        'film.Counter =

        db.Films.Add(film)
        db.SaveChanges()

    End Sub
End Module

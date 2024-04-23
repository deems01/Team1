Imports FilmDatabase.FilmdbModel
Imports FilmDatabase
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

    Sub SaveFilmToDatabase()
        Dim db As New FilmdbModel()
        Dim film As New FilmDatabase.Films()

        film.Imdb_Id = clickedMovie.Id
        film.Name = clickedMovie.Title
        film.ReleaseYear = clickedMovie.ReleaseDate
        film.FilmLength = clickedMovie.Filmlength
        'tra noh mtea kuidas sa seda listi siin teha tahad orgu, ma nagu poolenisti tahan terve selle fkin genre tabeli teha listiks
        'film.Genre =

        db.Films.Add(film)
        db.SaveChanges()
    End Sub
End Module

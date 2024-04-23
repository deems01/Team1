Module StatFunction

    Public weekdayMoviesWatched As New Dictionary(Of String, Integer) From {
        {"Mon", 0},
        {"Tue", 0},
        {"Wed", 3},
        {"Thu", 0},
        {"Fri", 0},
        {"Sat", 0},
        {"Sun", 0}
    }

    Private minutes As Integer = 0 'change this
    Public minutesWatched As String = minutes.ToString + " min"
    Public mostPopularGenre As String = "tere"
    Public mostPopularMovie As String = "https://th.bing.com/th/id/R.5ceba0b0a3541b382cdebe38d4add8e2?rik=C8Inv9PdfUzSPA&pid=ImgRaw&r=0"

End Module

Imports WatchStatistics
Imports RecAlgorythm
Module StatFunction

    ' Create an instance of a class that implements IStatistics
    Private statisticsService As New Statistics("e9bb467295d762ec5f93dffdab6761bd")

    Private recommendationService As New Recommendation()

    Public weekdayMoviesWatched As New Dictionary(Of String, Integer) From {
        {"Mon", 0},
        {"Tue", 0},
        {"Wed", 0},
        {"Thu", 0},
        {"Fri", 0},
        {"Sat", 0},
        {"Sun", 0}
    }

    Private minutes As Integer = statisticsService.GetTotalWatchedTime()
    Public minutesWatched As String = minutes.ToString + " min"
    Public mostPopularGenre As String = recommendationService.GetGenreName(recommendationService.GetMostPopularGenreId())
    Public mostPopularMovie As String
    '"https://th.bing.com/th/id/R.5ceba0b0a3541b382cdebe38d4add8e2?rik=C8Inv9PdfUzSPA&pid=ImgRaw&r=0" posterpath?

    ' Asynchronous method to initialize module data
    Private Async Function InitializeAsync() As Task
        ' Call asynchronous methods and assign values
        mostPopularMovie = Await statisticsService.GetMostWatchedMovie()
    End Function

    ' Synchronous entry point
    Sub Main()
        ' Call the asynchronous initialization method and wait for it to complete
        InitializeAsync().Wait()
    End Sub


End Module

Imports WatchStatistics
Imports RecAlgorythm
Imports FilmDatabase
Module StatFunction

    ' Create an instance of a class that implements IStatistics
    Private statisticsService As New Statistics()
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
    Dim minutes As Integer = statisticsService.GetTotalWatchedTime()
    Public minutesWatched As String = minutes.ToString() + " min"
    Dim mostPopularGenreId As Integer = recommendationService.GetMostPopularGenreId()
    Public mostPopularGenre As String = recommendationService.GetGenreName(mostPopularGenreId)
    Public mostPopularMovie As String

    Public Async Function InitializeAsync() As Task
        ' Call asynchronous methods and assign values

        Dim mostPopularMovieName As String = Await statisticsService.GetMostWatchedMovie()
        mostPopularMovie = mostPopularMovieName
    End Function

    Private Sub ReadAndUpdateWeekdayMoviesWatched()
        Using context As New FilmdbModel()
            ' Query the database to get the relevant data
            Dim planningData = context.Planning.ToList()

            ' Process each planning record
            For Each planningItem In planningData
                ' Get the day of the week from the planned date
                Dim dayOfWeek As String = planningItem.PlannedDate.DayOfWeek.ToString().Substring(0, 3)

                ' Increment the corresponding count in the dictionary
                If weekdayMoviesWatched.ContainsKey(dayOfWeek) Then
                    weekdayMoviesWatched(dayOfWeek) += 1
                End If
            Next
        End Using
    End Sub

    ' This method should be called to initialize the module
    Public Async Function InitializeModuleAsync() As Task
        ' Call the asynchronous initialization method and wait for it to complete
        Await InitializeAsync()
        ReadAndUpdateWeekdayMoviesWatched()
    End Function

End Module

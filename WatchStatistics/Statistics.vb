﻿Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Threading.Tasks
Imports FilmDatabase.FilmdbModel
Imports FilmDatabase

Public Class Statistics
    Implements IStatistics

    Private ReadOnly apiKey As String = "e9bb467295d762ec5f93dffdab6761bd"      'this to one universal
    Private ReadOnly baseURL As String = "https://api.themoviedb.org/3"
    Private ReadOnly httpClient As HttpClient

    Public Sub New(apiKey As String)
        Me.apiKey = apiKey
        Me.httpClient = New HttpClient()
    End Sub
    Public Async Function GetMovieLength(movieId As Integer) As Task(Of Integer) Implements IStatistics.GetMovieLength
        Dim length As Integer = 0

        Try
            ' Construct URL to fetch movie details
            Dim url As String = $"{baseURL}/movie/{movieId}?api_key={apiKey}"

            ' Make API request to get movie details
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()

            ' Parse response JSON
            Dim data As JObject = JObject.Parse(json)

            ' Extract movie length from the response
            If data("runtime") IsNot Nothing Then
                length = data("runtime").ToObject(Of Integer)()
            End If
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try

        Return length
    End Function

    'emailsenderist datetime variable inputiks, siis saab nädala päeva vastu.
    'väljakutse selline : Dim dayOfWeek As String = GetDayOfWeek(currentDate)
    Public Function GetDayOfWeek(inputDate As DateTime) As String Implements IStatistics.GetDayOfWeek
        Return inputDate.DayOfWeek.ToString()
    End Function


    Dim db As New FilmdbModel()

    Public Function GetTotalWatchedTime() As Integer Implements IStatistics.GetTotalWatchedTime
        Dim totalWatchedMinutes As Integer = 0

        Try
            ' Query the Planning table to get all planned movies
            Dim plannedMovies = db.Planning.Select(Function(p) p.Film_Id).ToList()

            ' Calculate the total watched time of all planned movies
            For Each movieId In plannedMovies
                ' Query the Films table to get the length of each planned movie
                Dim movieLength = db.Films.Where(Function(f) f.Id = movieId).Select(Function(f) f.FilmLength).FirstOrDefault()

                ' Convert movie length to minutes and add to total watched time
                Dim movieLengthInMinutes As Integer = If(Integer.TryParse(movieLength, Nothing), Convert.ToInt32(movieLength), 0)
                totalWatchedMinutes += movieLengthInMinutes
            Next
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try

        Return totalWatchedMinutes
    End Function

    Public Async Function GetMostWatchedMovie() As Task(Of String) Implements IStatistics.GetMostWatchedMovie
        Dim mostWatchedMoviePosterPath As String = String.Empty

        Try
            ' Group movies by their IDs and count the number of times each movie has been planned
            Dim moviePlanCounts = db.Planning.GroupBy(Function(p) p.Film_Id).
                                              Select(Function(g) New With {
                                                         .MovieId = g.Key,
                                                         .PlanCount = g.Count()
                                                     }).
                                              OrderByDescending(Function(x) x.PlanCount)

            ' Get the ID of the most planned movie
            Dim mostPlannedMovieId = moviePlanCounts.FirstOrDefault()?.MovieId

            ' Get the name of the most planned movie
            If mostPlannedMovieId.HasValue Then
                mostWatchedMoviePosterPath = Await GetMoviePosterPath(mostPlannedMovieId)

            End If
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try
        Return mostWatchedMoviePosterPath
    End Function

    Public Async Function GetMoviePosterPath(movieId As Integer) As Task(Of String)
        Dim posterPath As String = String.Empty

        Try
            Dim url As String = $"{baseURL}/movie/{movieId}?api_key={apiKey}"
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()

            Dim imageBaseURL As String = "https://image.tmdb.org/t/p/w500"
            Dim movieData As JObject = JObject.Parse(json)

            posterPath = If(movieData("poster_path") IsNot Nothing, $"{imageBaseURL}{movieData("poster_path").ToString()}", String.Empty)

        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try

        Return posterPath
    End Function


End Class




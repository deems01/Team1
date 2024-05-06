Imports System.Data.Entity.Core
Imports System.Net.Http
Imports FilmDatabase
Imports Newtonsoft.Json.Linq
Imports SortClass
Imports System.Environment

Public Class Recommendation
    Implements IRecommendation

    Private ReadOnly apiKey As String = GetEnvironmentVariable("MOVIE_NIGHT_API_KEY")

    Private ReadOnly baseURL As String = "https://api.themoviedb.org/3"
    Private httpClient As New HttpClient


    'Et saada soovitatud filme kasutaja dataga on vaja teha siuke request, kui ühe reaga :

    'dim variable as list(of movie) = Await IRecommendation.FetchRecommendedMovies(GetMostPopularYear(), GetMostPopularGenreId())

    'NB!! võtab andmebaasisit kõige populaarsemad aastad ja zanrid ja selle alusel teeb api requesti.
    'toimimiseks vaja ka SortClass (kuna sealt tuleb movie list)
    Public Async Function FetchRecommendedMovies(popularYear As Integer, popularGenreId As Integer) As Task(Of List(Of Movie)) Implements IRecommendation.FetchRecommendedMovies
        Dim movies As New List(Of Movie)()
        Dim url As String = $"{baseURL}/discover/movie?api_key={apiKey}"
        If popularYear <> 0 Then
            url &= $"&primary_release_year={popularYear}"
        End If
        If popularGenreId <> 0 Then
            url &= $"&with_genres={popularGenreId}"
        End If

        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()
            Dim data As JObject = JObject.Parse(json)
            Dim results As JArray = DirectCast(data("results"), JArray)

            Dim imageBaseURL As String = "https://image.tmdb.org/t/p/w500"
            Dim limit As Integer = 0

            For Each item As JObject In results
                If limit > 20 Then
                    Exit For
                End If

                Dim posterPath As String = If(item("poster_path") IsNot Nothing, item("poster_path").ToString(), String.Empty)
                Dim fullPosterUrl As String = If(Not String.IsNullOrEmpty(posterPath), $"{imageBaseURL}{posterPath}", String.Empty)
                Dim movie As New Movie With {
                            .Title = item("title").ToString(),
                            .Overview = item("overview").ToString(),
                            .ReleaseDate = If(item("release_date") IsNot Nothing, Date.Parse(item("release_date").ToString()), Nothing),
                            .Language = If(item("original_language") IsNot Nothing, item("original_language").ToString(), ""),
                            .PosterUrl = fullPosterUrl
                        }
                movies.Add(movie)
                limit += 1
            Next

        Catch ex As HttpRequestException
            Console.WriteLine($"HTTP Request Error: {ex.Message}") ' HTTP request errors
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}") 'any error
        End Try
        Return movies
    End Function


    Public Function GetMostPopularGenreId() As Integer Implements IRecommendation.GetMostPopularGenreId
        Dim db As New FilmdbModel()
        Dim mostPopularGenre As Integer = 0

        Try
            ' Query the Films table to get all movies
            Dim allMovies = db.Films

            ' Group movies by genre and count the number of movies in each genre
            Dim genreCounts = allMovies.GroupBy(Function(m) m.Genre).
                                  Select(Function(g) New With {.GenreId = g.Key, .Count = g.Count()}).
                                  OrderByDescending(Function(x) x.Count)

            ' Get the genre ID of the most popular genre
            Dim mostPopularGenreId = genreCounts.FirstOrDefault()?.GenreId

            ' Get the genre name corresponding to the genre ID
            If mostPopularGenreId.HasValue Then
                Return mostPopularGenreId
            End If
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try

        Return mostPopularGenre
    End Function

    Public Function GetMostPopularYear() As Integer Implements IRecommendation.GetMostPopularYear
        Dim db As New FilmdbModel()
        Dim mostPopularYear As Integer = 0

        Try
            ' Query the Films table to get all movies
            Dim allMovies = db.Films

            ' Group movies by release year and count the number of movies released in each year
            Dim yearCounts = allMovies.GroupBy(Function(m) m.ReleaseYear).
                                      Select(Function(g) New With {.Year = g.Key, .Count = g.Count()}).
                                      OrderByDescending(Function(x) x.Count)

            ' Get the year with the highest count
            mostPopularYear = yearCounts.FirstOrDefault()?.Year
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try

        Return mostPopularYear
    End Function

    Private genreMapping As New Dictionary(Of Integer, String) From {
    {28, "Action"},
    {12, "Adventure"},
    {16, "Animation"},
    {35, "Comedy"},
    {80, "Crime"},
    {99, "Documentary"},
    {18, "Drama"},
    {10751, "Family"},
    {14, "Fantasy"},
    {36, "History"},
    {27, "Horror"},
    {10402, "Music"},
    {9648, "Mystery"},
    {10749, "Romance"},
    {878, "Science Fiction"},
    {10770, "TV Movie"},
    {53, "Thriller"},
    {10752, "War"},
    {37, "Western"}}

    Public Function GetGenreName(genreId As Integer) As String Implements IRecommendation.GetGenreName
        If genreMapping.ContainsKey(genreId) Then
            Return genreMapping(genreId)
        Else
            Return "Unknown"
        End If
    End Function

    Public Function GetGenreId(genreName As String) As Integer Implements IRecommendation.GetGenreId
        For Each kvp As KeyValuePair(Of Integer, String) In genreMapping
            If kvp.Value = genreName Then
                Return kvp.Key
            End If
        Next
        Return -1
    End Function


End Class

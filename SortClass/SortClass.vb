﻿Imports System.CodeDom.Compiler
Imports System.Diagnostics.Eventing.Reader
Imports System.Net.Http
Imports System.Reflection
Imports Newtonsoft.Json.Linq
Imports System.Environment

Public Class TMDBClient
    Implements ISortClass

    Private ReadOnly apiKey As String = ""
    Private ReadOnly baseURL As String = "https://api.themoviedb.org/3"
    Private ReadOnly httpClient As HttpClient

    Public Sub New()
        Me.apiKey = GetEnvironmentVariable("MOVIE_NIGHT_API_KEY")
        If String.IsNullOrEmpty(apiKey) Then
            Throw New Exception("API key not found in environment variables.")
        End If
        Me.httpClient = New HttpClient()
    End Sub

    Public Async Function GetGenres(Genre As String) As Task(Of List(Of Movie)) Implements ISortClass.GetGenres
        Dim movies As New List(Of Movie)()
        Dim genres As Integer = GetGenreId(Genre)
        Dim url As String = $"{baseURL}/discover/movie?api_key={apiKey}&sort_by=popularity.desc&with_genres={genres}"
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
                Dim movieGenres As New List(Of String)()
                For Each genreId As JValue In item("genre_ids")
                    Dim genreIdValue As Integer = genreId.Value
                    Dim genreName As String = GetGenreName(genreIdValue)
                    movieGenres.Add(genreName)
                Next
                Dim posterPath As String = If(item("poster_path") IsNot Nothing, item("poster_path").ToString(), String.Empty)
                Dim fullPosterUrl As String = If(Not String.IsNullOrEmpty(posterPath), $"{imageBaseURL}{posterPath}", String.Empty)
                Dim movie As New Movie With {
                    .Genres = movieGenres,
                    .Title = item("title").ToString(),
                    .Overview = item("overview").ToString(),
                    .ReleaseDate = If(item("release_date") IsNot Nothing, Date.Parse(item("release_date").ToString()), Nothing),
                    .Language = If(item("original_language") IsNot Nothing, item("original_language").ToString(), ""),
                    .PosterUrl = fullPosterUrl,
                    .Id = item("id").ToObject(Of Integer)()
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

    Private ReadOnly languageMapping As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
    {"English", "en"},
    {"French", "fr"},
    {"Spanish", "es"},
    {"German", "de"},
    {"Italian", "it"},
    {"Portuguese", "pt"},
    {"Russian", "ru"},
    {"Chinese", "zh"},
    {"Japanese", "ja"},
    {"Arabic", "ar"},
    {"Hindi", "hi"},
    {"Korean", "ko"},
    {"Dutch", "nl"},
    {"Swedish", "sv"},
    {"Norwegian", "no"},
    {"Danish", "da"},
    {"Finnish", "fi"},
    {"Greek", "el"},
    {"Turkish", "tr"},
    {"Polish", "pl"},
    {"Hungarian", "hu"},
    {"Czech", "cs"},
    {"Thai", "th"},
    {"Indonesian", "id"},
    {"Vietnamese", "vi"}
    }

    Public Function FetchLanguage(languageCode As String) As String
        Dim languageName As String = ""
        If languageMapping.ContainsKey(languageCode.ToLower()) Then
            languageName = languageMapping(languageCode.ToLower())
        Else
            languageName = "Unknown"
        End If
        Return languageName
    End Function

    Public Function FetchLanguageCode(languageName As String) As String
        Dim languageCode As String = ""
        If languageMapping.ContainsKey(languageName) Then
            languageCode = languageMapping(languageName)
        Else
            languageCode = "Unknown"
        End If
        Return languageCode
    End Function
    Public Async Function FetchAllMovies(input As String, language As String) As Task(Of List(Of Movie)) Implements ISortClass.FetchAllMovies
        Dim movies As New List(Of Movie)()

        Dim url As String = $"{baseURL}/movie/popular?api_key={apiKey}"

        If input = "Desc" Then
            url = $"{baseURL}/discover/movie?api_key={apiKey}&sort_by=release_date.desc"

        ElseIf input = "Asc" Then
            url = $"{baseURL}/discover/movie?api_key={apiKey}&sort_by=release_date.asc"
        End If
        If language <> "" Then
            Dim temp As String = FetchLanguageCode(language)
            If temp <> "Unknown" Then
                url &= "&with_original_language="
                url &= temp
            End If
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
                                .Id = item("id").ToObject(Of Integer)(), 'see lisaks
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
        Return movies 'list
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

    Private Function GetGenreName(genreId As Integer) As String
        If genreMapping.ContainsKey(genreId) Then
            Return genreMapping(genreId)
        Else
            Return "Unknown"
        End If
    End Function

    Private Function GetGenreId(genreName As String) As Integer
        For Each kvp As KeyValuePair(Of Integer, String) In genreMapping
            If kvp.Value = genreName Then
                Return kvp.Key
            End If
        Next
        Return -1
    End Function

    Public Async Function GetMoviesByCompany(companyName As String) As Task(Of List(Of Movie)) Implements ISortClass.GetMoviesByCompany
        Dim movies As New List(Of Movie)()

        Try
            ' Get company ID by company name
            Dim companyId As Integer = Await GetCompanyIdByName(companyName)

            ' Make API request to get movies by company ID
            Dim url As String = $"{baseURL}/company/{companyId}/movies?api_key={apiKey}"
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()

            ' Parse response JSON
            Dim data As JObject = JObject.Parse(json)
            Dim results As JArray = DirectCast(data("results"), JArray)

            ' Process each movie in the results
            Dim limit As Integer = 0
            Dim imageBaseURL As String = "https://image.tmdb.org/t/p/w500"

            For Each item As JObject In results

                If limit > 20 Then
                    Exit For
                End If

                Dim posterPath As String = If(item("poster_path") IsNot Nothing, item("poster_path").ToString(), String.Empty)
                Dim fullPosterUrl As String = If(Not String.IsNullOrEmpty(posterPath), $"{imageBaseURL}{posterPath}", String.Empty)

                Dim movie As New Movie With {
                    .Id = item("id").ToObject(Of Integer)(),
                    .Title = item("title").ToString(),
                    .Overview = item("overview").ToString(),
                    .ReleaseDate = If(item("release_date") IsNot Nothing, Date.Parse(item("release_date").ToString()), Nothing),
                    .Language = If(item("original_language") IsNot Nothing, item("original_language").ToString(), ""),
                    .PosterUrl = fullPosterUrl
                }
                movies.Add(movie)
                limit += 1
            Next
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try

        Return movies
    End Function

    Private Async Function GetCompanyIdByName(companyName As String) As Task(Of Integer)
        Dim companyId As Integer = -1
        Try
            Dim url As String = $"{baseURL}/search/company?api_key={apiKey}&query={Uri.EscapeDataString(companyName)}"
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()

            Dim data As JObject = JObject.Parse(json)
            Dim results As JArray = DirectCast(data("results"), JArray)
            If results.Count > 0 Then
                companyId = Convert.ToInt32(results(0)("id"))
            End If
        Catch ex As Exception
            Console.WriteLine($"Error getting company ID: {ex.Message}")
        End Try
        Return companyId
    End Function

    Public Async Function GetMoviesByActor(actorName As String) As Task(Of List(Of Movie)) Implements ISortClass.GetMoviesByActor
        Dim movies As New List(Of Movie)()

        Try
            ' Get actor ID by actor name
            Dim actorId As Integer = Await GetActorIdByName(actorName)

            ' Make API request to get movie credits by actor ID
            Dim url As String = $"{baseURL}/person/{actorId}/movie_credits?api_key={apiKey}"
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()

            ' Parse response JSON
            Dim data As JObject = JObject.Parse(json)
            Dim cast As JArray = DirectCast(data("cast"), JArray)

            Dim limit As Integer = 0

            Dim imageBaseURL As String = "https://image.tmdb.org/t/p/w500"
            ' Process each movie in the cast
            For Each item As JObject In cast

                If limit > 20 Then
                    Exit For
                End If

                Dim posterPath As String = If(item("poster_path") IsNot Nothing, item("poster_path").ToString(), String.Empty)
                Dim fullPosterUrl As String = If(Not String.IsNullOrEmpty(posterPath), $"{imageBaseURL}{posterPath}", String.Empty)
                Dim movie As New Movie With {
                    .Id = item("id").ToObject(Of Integer)(),
                    .Title = item("title").ToString(),
                    .Overview = item("overview").ToString(),
                    .ReleaseDate = If(item("release_date") IsNot Nothing, Date.Parse(item("release_date").ToString()), Nothing),
                    .Language = If(item("original_language") IsNot Nothing, item("original_language").ToString(), ""),
                    .PosterUrl = fullPosterUrl
                }
                movies.Add(movie)

                limit += 1
            Next
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try

        Return movies
    End Function

    Private Async Function GetActorIdByName(actorName As String) As Task(Of Integer)
        Dim actorId As Integer = -1
        Try
            Dim url As String = $"{baseURL}/search/person?api_key={apiKey}&query={Uri.EscapeDataString(actorName)}"
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()

            Dim data As JObject = JObject.Parse(json)
            Dim results As JArray = DirectCast(data("results"), JArray)
            If results.Count > 0 Then
                actorId = Convert.ToInt32(results(0)("id")) 'siia lisaks posteri tagastus ja saamine (tuple)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error getting actor ID: {ex.Message}")
        End Try
        Return actorId
    End Function
    Public Async Function GetRandomMovie() As Task(Of Movie) Implements ISortClass.GetRandomMovie
        Dim randomMovie As New Movie()

        Try
            ' Generate a random page number
            Dim randomPage As Integer = New Random().Next(1, 500)

            ' Construct URL to fetch random page of movies
            Dim url As String = $"{baseURL}/discover/movie?api_key={apiKey}&page={randomPage}"
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()

            Dim data As JObject = JObject.Parse(json)
            Dim results As JArray = DirectCast(data("results"), JArray)
            Dim imageBaseURL As String = "https://image.tmdb.org/t/p/w500"

            If results.Count > 0 Then
                ' Generate a random index within the range of available movies on the page
                Dim randomIndex As Integer = New Random().Next(0, results.Count)

                ' Select a random movie from the list
                Dim randomMovieData As JObject = DirectCast(results(randomIndex), JObject)
                randomMovie.Id = randomMovieData("id").ToObject(Of Integer)()
                randomMovie.Title = randomMovieData("title").ToString()
                randomMovie.Overview = randomMovieData("overview").ToString()
                randomMovie.ReleaseDate = If(randomMovieData("release_date") IsNot Nothing, Date.Parse(randomMovieData("release_date").ToString()), Nothing)
                randomMovie.Language = If(randomMovieData("original_language") IsNot Nothing, randomMovieData("original_language").ToString(), "")
                randomMovie.PosterUrl = If(randomMovieData("poster_path") IsNot Nothing, $"{imageBaseURL}{randomMovieData("poster_path").ToString()}", String.Empty)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try

        Return randomMovie
    End Function
End Class

Public Class Movie      ' this for all, to main
    Public Property Title As String
    Public Property Overview As String
    Public Property ReleaseDate As Date
    Public Property Language As String
    Public Property Genres As New List(Of String)
    Public Property PosterUrl As String
    Public Property Id As Integer
End Class

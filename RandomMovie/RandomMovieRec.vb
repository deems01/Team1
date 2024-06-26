﻿Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports SortClass
Imports System.Environment

Public Class RandomMovieRec
    Implements IRandomMovieRec

    Private ReadOnly apiKey As String
    Private ReadOnly baseURL As String = "https://api.themoviedb.org/3"
    Private ReadOnly httpClient As HttpClient

    Public Sub New()
        Me.apiKey = GetEnvironmentVariable("MOVIE_NIGHT_API_KEY")
        If String.IsNullOrEmpty(apiKey) Then
            Throw New Exception("API key not found in environment variables.")
        End If
        Me.httpClient = New HttpClient()
    End Sub
    Private Async Function GetRandomMovie() As Task(Of Movie) Implements IRandomMovieRec.GetRandomMovie
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

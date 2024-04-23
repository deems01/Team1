
Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class CNameSearch
    ' default val temporary
    Private ReadOnly apiKey As String = "36d0af349fe1d35fc3babe753de0aa8e"
    Private ReadOnly baseURL As String = "https://api.themoviedb.org/3"
    Private ReadOnly httpClient As HttpClient = New HttpClient()
    Private movies As New List(Of Movie)()

    Public Sub New(apiKey As String)
        Me.apiKey = apiKey
    End Sub

    Public Function GetMoviesList()
        If Me.movies.Count <> 0 Then
            Return Me.movies
        Else
            Console.WriteLine("movies has not been populated!")
            Return 0
        End If
    End Function

    Public Async Function SearchMovieAsync(movieName As String) As Task(Of List(Of Movie))

        movies.Clear()
        Dim query As String = Uri.EscapeDataString(movieName)
        Dim url As String = $"{baseURL}/search/movie?api_key={apiKey}&query={query}"


        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            If response.IsSuccessStatusCode Then
                Dim jsonString As String = Await response.Content.ReadAsStringAsync()
                Dim data As JObject = JObject.Parse(jsonString)
                Dim results As JArray = DirectCast(data("results"), JArray)

                Dim listLimit As Integer = 0
                Dim imageBaseURL As String = "https://image.tmdb.org/t/p/w500"

                For Each item As JObject In results
                    If listLimit > 100 Then
                        Exit For
                    End If

                    Dim posterPath As String = If(item("poster_path") IsNot Nothing, item("poster_path").ToString(), String.Empty)
                    Dim fullPosterUrl As String = If(Not String.IsNullOrEmpty(posterPath), $"{imageBaseURL}{posterPath}", String.Empty)

                    Dim movie As New Movie With {
                            .Title = item("title").ToString(),
                            .Overview = item("overview").ToString(),
                            .ReleaseDate = If(item("release_date") IsNot Nothing, Date.Parse(item("release_date").ToString()), Nothing),
                            .Language = If(item("original_language") IsNot Nothing, item("original_language").ToString(), ""),
                            .ProductionCompanies = If(item("production_companies") IsNot Nothing, item("production_companies").Select(Function(pc) pc("name").ToString()).ToList(), New List(Of String)()),
                            .Actors = If(item("credits") IsNot Nothing AndAlso item("credits")("cast") IsNot Nothing, item("credits")("cast").Select(Function(actor) actor("name").ToString()).ToList(), New List(Of String)()),
                            .PosterUrl = fullPosterUrl
                        }

                    movies.Add(movie)
                    listLimit += 1

                Next
            Else
                Throw New HttpRequestException($"Failed to fetch data. Status code: {response.StatusCode}")
            End If
        Catch ex As HttpRequestException
            Console.WriteLine($"An error occurred during the HTTP request: {ex.Message}")
        Catch ex As Exception
            Console.WriteLine($"An unexpected error occurred: {ex.Message}")
        End Try

        Return movies
    End Function

    Public Sub PrintFirst10Movies(movies As List(Of Movie))
        For i As Integer = 0 To Math.Min(movies.Count, 10) - 1
            Dim movie = movies(i)
            Console.WriteLine($"Title: {movie.Title}")
            Console.WriteLine($"Overview: {movie.Overview}")
            Console.WriteLine($"Release Date: {movie.ReleaseDate.ToShortDateString()}")
            Console.WriteLine($"Language: {movie.Language}")
            Console.WriteLine($"Production Companies: {String.Join(", ", movie.ProductionCompanies)}")
            Console.WriteLine($"Actors: {String.Join(", ", movie.Actors)}")
            Console.WriteLine("------------------------------------------------")
        Next
    End Sub

End Class

' Using class to store movie attributes,
' because tuples or anonymous objects pose
' unnecessary challenges regarding mutability
' later on
Public Class Movie
    Public Property Title As String
    Public Property Overview As String
    Public Property ReleaseDate As Date
    Public Property Language As String
    Public Property Genres As New List(Of String)
    Public Property ProductionCompanies As New List(Of String)
    Public Property Actors As New List(Of String)
    Public Property PosterUrl As String
End Class

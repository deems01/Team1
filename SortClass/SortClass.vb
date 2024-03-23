
Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class TMDBClient
    Private ReadOnly apiKey As String = "e9bb467295d762ec5f93dffdab6761bd"      'this to one universal
    Private ReadOnly baseURL As String = "https://api.themoviedb.org/3"
    Private ReadOnly httpClient As HttpClient

    Public Sub New(apiKey As String)
        Me.apiKey = apiKey
        Me.httpClient = New HttpClient()
    End Sub

    Public Async Function FetchPopularMovies() As Task(Of List(Of Movie))
        Dim movies As New List(Of Movie)()

        Dim url As String = $"{baseURL}/movie/popular?api_key={apiKey}"

        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()

            Dim data As JObject = JObject.Parse(json)
            Dim results As JArray = DirectCast(data("results"), JArray)

            For Each item As JObject In results
                Dim movie As New Movie With {
                    .Title = item("title").ToString(),
                    .Overview = item("overview").ToString(),
                    .ReleaseDate = If(item("release_date") IsNot Nothing, CDate(item("release_date")), Nothing),
                    .Language = If(item("original_language") IsNot Nothing, item("original_language").ToString(), ""),
                    .ProductionCompanies = If(item("production_companies") IsNot Nothing, item("production_companies").Select(Function(pc) pc("name").ToString()).ToList(), New List(Of String)),
                    .Actors = If(item("credits") IsNot Nothing AndAlso item("credits")("cast") IsNot Nothing, item("credits")("cast").Select(Function(actor) actor("name").ToString()).ToList(), New List(Of String))
                }
                movies.Add(movie)
            Next

        Catch ex As HttpRequestException

            Console.WriteLine($"HTTP Request Error: {ex.Message}")      ' HTTP request errors
        Catch ex As Exception

            Console.WriteLine($"Error: {ex.Message}")
        End Try

        Return movies       'list
    End Function

    'sort_by - string  
    'Choose from one Of the many available sort options.
    'Allowed Values :  ,  
    'popularity.asc,  
    'popularity.desc,  
    'release_date.asc,  
    'release_date.desc,  
    'revenue.asc,  
    'revenue.desc,  
    'primary_release_date.asc,  
    'primary_release_date.desc,  
    'original_title.asc,  
    'original_title.desc,  
    'vote_average.asc,  
    'vote_average.desc,  
    'vote_count.asc,  
    'vote_count.desc  
    'Default:   popularity.desc  

    Public Function SortMoviesByGenre(movies As List(Of Movie), genre As String) As List(Of Movie)
        Return movies.Where(Function(m) m.Genres.Contains(genre)).ToList()
    End Function

    Public Function SortMoviesByReleaseDateAscending(movies As List(Of Movie)) As List(Of Movie)
        Return movies.OrderBy(Function(m) m.ReleaseDate).ToList()
    End Function

    Public Function SortMoviesByReleaseDateDescending(movies As List(Of Movie)) As List(Of Movie)
        Return movies.OrderByDescending(Function(m) m.ReleaseDate).ToList()
    End Function

    Public Function SortMoviesByLanguage(movies As List(Of Movie), language As String) As List(Of Movie)
        Return movies.Where(Function(m) m.Language.Equals(language, StringComparison.OrdinalIgnoreCase)).ToList()
    End Function

    Public Function SortMoviesByCompany(movies As List(Of Movie), company As String) As List(Of Movie)
        Return movies.Where(Function(m) m.ProductionCompanies.Contains(company)).ToList()
    End Function

    Public Function SortMoviesByActor(movies As List(Of Movie), actor As String) As List(Of Movie)
        Return movies.Where(Function(m) m.Actors.Contains(actor)).ToList()
    End Function


End Class

Public Class Movie      ' this for all, to main
    Public Property Title As String
    Public Property Overview As String
    Public Property ReleaseDate As Date
    Public Property Language As String
    Public Property Genres As New List(Of String)
    Public Property ProductionCompanies As New List(Of String)
    Public Property Actors As New List(Of String)
End Class

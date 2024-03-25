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

    Public Async Function GetGenres(Genre As String) As Task(Of List(Of Movie))
        Dim movies As New List(Of Movie)()
        Dim genres As Integer = GetGenreId(Genre)
        Dim url As String = $"{baseURL}/discover/movie?api_key={apiKey}&sort_by=popularity.desc&with_genres={genres}"
        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()

            Dim data As JObject = JObject.Parse(json)
            Dim results As JArray = DirectCast(data("results"), JArray)

            For Each item As JObject In results
                Dim movieGenres As New List(Of String)()
                For Each genreId As JValue In item("genre_ids")
                    Dim genreIdValue As Integer = genreId.Value
                    Dim genreName As String = GetGenreName(genreIdValue)
                    movieGenres.Add(genreName)
                Next

                Dim movie As New Movie With {
                    .Genres = movieGenres,
                    .Title = item("title").ToString(),
                    .Overview = item("overview").ToString(),
                    .ReleaseDate = If(item("release_date") IsNot Nothing, Date.Parse(item("release_date").ToString()), Nothing),
                    .Language = If(item("original_language") IsNot Nothing, item("original_language").ToString(), "")
                }
                movies.Add(movie)
            Next

        Catch ex As HttpRequestException
            Console.WriteLine($"HTTP Request Error: {ex.Message}") ' HTTP request errors
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}") 'any error
        End Try

        Return movies

    End Function

    Private Async Function GetCompanyName(companyId As Integer) As Task(Of String)
        Dim url As String = $"{baseURL}/company/{companyId}?api_key={apiKey}"

        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()

            Dim data As JObject = JObject.Parse(json)
            Return data("name").ToString()

        Catch ex As HttpRequestException
            Console.WriteLine($"HTTP Request Error: {ex.Message}") ' HTTP request errors
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}") 'any error
        End Try

        Return "Unknown"
    End Function

    Public Async Function FetchAllMovies() As Task(Of List(Of Movie))
        Dim movies As New List(Of Movie)()

        Dim url As String = $"{baseURL}/discover/movie?api_key={apiKey}"

        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()

            Dim data As JObject = JObject.Parse(json)
            Dim results As JArray = DirectCast(data("results"), JArray)

            Dim imageBaseURL As String = "https://image.tmdb.org/t/p/w500"

            For Each item As JObject In results
                Dim movieGenres As New List(Of String)()
                For Each genreId As JValue In item("genre_ids")
                    Dim genreIdValue As Integer = genreId.Value
                    Dim genreName As String = GetGenreName(genreIdValue)
                    movieGenres.Add(genreName)
                Next

                Dim productionCompanies As New List(Of String)()
                If item("production_companies") IsNot Nothing Then
                    For Each company As JObject In item("production_companies")
                        Dim companyName As String = company("name").ToString()
                        productionCompanies.Add(companyName)
                    Next
                End If

                Dim creditsUrl As String = $"{baseURL}/movie/{item("id")}/credits?api_key={apiKey}"
                Dim creditsResponse As HttpResponseMessage = Await httpClient.GetAsync(creditsUrl)
                creditsResponse.EnsureSuccessStatusCode()
                Dim creditsJson As String = Await creditsResponse.Content.ReadAsStringAsync()
                Dim creditsData As JObject = JObject.Parse(creditsJson)

                Dim actors As New List(Of String)()
                For Each actor As JObject In creditsData("cast")
                    actors.Add(actor("name").ToString())
                Next

                Dim posterPath As String = If(item("poster_path") IsNot Nothing, item("poster_path").ToString(), String.Empty)
                Dim fullPosterUrl As String = If(Not String.IsNullOrEmpty(posterPath), $"{imageBaseURL}{posterPath}", String.Empty)

                Dim movie As New Movie With {
                .Genres = movieGenres,
                .Title = item("title").ToString(),
                .Overview = item("overview").ToString(),
                .ReleaseDate = If(item("release_date") IsNot Nothing, Date.Parse(item("release_date").ToString()), Nothing),
                .Language = If(item("original_language") IsNot Nothing, item("original_language").ToString(), ""),
                .ProductionCompanies = productionCompanies,
                .Actors = actors,
                .PosterUrl = fullPosterUrl
            }
                movies.Add(movie)
            Next

        Catch ex As HttpRequestException
            Console.WriteLine($"HTTP Request Error: {ex.Message}") ' HTTP request errors
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}") 'any error
        End Try

        Return movies 'list
    End Function



    Public Async Function FetchPopularMovies() As Task(Of List(Of Movie))
        Dim movies As New List(Of Movie)()

        Dim url As String = $"{baseURL}/movie/popular?api_key={apiKey}"

        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()

            Dim data As JObject = JObject.Parse(json)
            Dim results As JArray = DirectCast(data("results"), JArray)

            Dim imageBaseURL As String = "https://image.tmdb.org/t/p/w500"

            For Each item As JObject In results

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
                            .ProductionCompanies = If(item("production_companies") IsNot Nothing, item("production_companies").Select(Function(pc) pc("name").ToString()).ToList(), New List(Of String)()),
                            .Actors = If(item("credits") IsNot Nothing AndAlso item("credits")("cast") IsNot Nothing, item("credits")("cast").Select(Function(actor) actor("name").ToString()).ToList(), New List(Of String)()),
                            .PosterUrl = fullPosterUrl
                        }
                movies.Add(movie)
            Next

        Catch ex As HttpRequestException

            Console.WriteLine($"HTTP Request Error: {ex.Message}")      ' HTTP request errors
        Catch ex As Exception

            Console.WriteLine($"Error: {ex.Message}")           'any error
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
        Dim genreId As Integer = GetGenreId(genre)
        Return movies.Where(Function(m) m.Genres.Contains(genreId.ToString())).ToList()
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

    Private Function GetGenreName(genreId As Integer) As String
        ' Dictionary to map genre IDs to names
        Dim genreMapping As New Dictionary(Of Integer, String) From {
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

        ' Check if the genreId exists in the dictionary
        If genreMapping.ContainsKey(genreId) Then
            Return genreMapping(genreId)
        Else
            Return "Unknown" ' Default to "Unknown" if the genre ID is not found
        End If
    End Function

    Private Function GetGenreId(genreName As String) As Integer
        ' Dictionary to map genre names to IDs
        Dim genreMapping As New Dictionary(Of String, Integer) From {
        {"Action", 28},
        {"Adventure", 12},
        {"Animation", 16},
        {"Comedy", 35},
        {"Crime", 80},
        {"Documentary", 99},
        {"Drama", 18},
        {"Family", 10751},
        {"Fantasy", 14},
        {"History", 36},
        {"Horror", 27},
        {"Music", 10402},
        {"Mystery", 9648},
        {"Romance", 10749},
        {"Science Fiction", 878},
        {"TV Movie", 10770},
        {"Thriller", 53},
        {"War", 10752},
        {"Western", 37}
    }

        ' Check if the genreName exists in the dictionary
        If genreMapping.ContainsKey(genreName) Then
            Return genreMapping(genreName)
        Else
            Return -1 ' Return -1 if the genre name is not found
        End If
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
    Public Property PosterUrl As String
End Class

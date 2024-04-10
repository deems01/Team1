Public Interface ISortClass
    Function GetGenres(Genre As String) As Task(Of List(Of Movie))
    Function FetchAllMovies(input As String, language As String) As Task(Of List(Of Movie))
    Function GetMoviesByCompany(companyName As String) As Task(Of List(Of Movie))
    Function GetMoviesByActor(actorName As String) As Task(Of List(Of Movie))
    Function GetRandomMovie() As Task(Of Movie)

End Interface

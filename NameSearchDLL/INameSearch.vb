Public Interface INameSearch
    Function SearchMovieAsync(movieName As String) As Task(Of List(Of Movie))

End Interface

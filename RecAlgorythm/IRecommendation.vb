Imports System.Net.Http
Imports SortClass
Public Interface IRecommendation
    Function GetGenreId(genreName As String) As Integer
    Function GetGenreName(genreId As Integer) As String
    Function GetMostPopularGenreId() As Integer
    Function GetMostPopularYear() As Integer
    Function FetchRecommendedMovies(popularYear As Integer, popularGenreId As Integer) As Task(Of List(Of Movie))
End Interface

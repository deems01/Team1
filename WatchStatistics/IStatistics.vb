﻿Imports System.Threading.Tasks
Public Interface IStatistics
    Function GetMovieLength(movieId As Integer) As Task(Of Integer)

    Function GetTotalWatchedTime() As Integer

    Function GetMostWatchedMovie() As Task(Of String)

End Interface

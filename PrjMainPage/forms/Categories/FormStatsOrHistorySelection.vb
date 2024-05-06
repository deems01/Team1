Imports System.Diagnostics.Eventing.Reader
Imports DllHandler
Imports FilmDatabase

Public Class FormStatsOrHistorySelection
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        UiHelpFunctions.OpenChildForm(New FormWatchHistory)
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        UiHelpFunctions.OpenChildForm(New FormStats)
    End Sub

    Private firstTimeButtonPressed As Boolean = True

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click

        ' Create an instance of CDllHandler
        Dim dllHandler As IDllHandler = New CDllHandler()
        Using dbContext As New FilmdbModel()
            Dim films = dbContext.Films.ToList()

            ' Create a list to hold movie details as strings
            Dim movieDetails As New List(Of String())

            ' Add column names as the first row
            movieDetails.Add({"Imdb_Id", "Name", "ReleaseYear", "FilmLength", "Genre"})

            ' Add each film's details as a string array to the list
            For Each film In films
                Dim details As String() = {film.Imdb_Id.ToString(), film.Name, film.ReleaseYear.ToString(), film.FilmLength.ToString(), film.Genre.ToString()}
                movieDetails.Add(details)
            Next

            ' Convert list to two-dimensional array
            Dim movieDetailsArray(movieDetails.Count - 1, movieDetails(0).Length - 1) As String
            For i As Integer = 0 To movieDetails.Count - 1
                For j As Integer = 0 To movieDetails(0).Length - 1
                    movieDetailsArray(i, j) = movieDetails(i)(j)
                Next
            Next

            Static Dim filepath As String = ""
            ' Call the method from the instance to save data to CSV
            If firstTimeButtonPressed Then
                filepath = dllHandler.SaveDataToCsv(movieDetailsArray, ",", """", False)
                firstTimeButtonPressed = False
            Else

                filepath = dllHandler.SaveDataToCsv(movieDetailsArray, ",", """", True, True)
            End If
            If filepath = "" Then
                Console.WriteLine("Failed to save data to CSV.")
            Else
                Console.WriteLine($"Data saved successfully.")
            End If
        End Using
    End Sub
End Class
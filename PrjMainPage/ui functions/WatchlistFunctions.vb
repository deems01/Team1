Module WatchlistFunctions

    Private watchList As New List(Of Object)
    Sub setWatchlistMember(movie As Object)
        ' Check if any object in watchList meets the condition
        If Not watchList.Any(Function(obj) obj.PosterUrl = movie.PosterUrl) Then
            ' If no object meets the condition, add the movie to the watchList
            watchList.Add(movie)
        End If
    End Sub

    Public Sub AddPosterDynamicallyWatchlist(resultFlowPanel As FlowLayoutPanel)
        If watchList IsNot Nothing AndAlso watchList.Count > 0 Then
            For Each movie As Object In watchList
                Dim posterPicBox As New PictureBox

                If movie.PosterUrl IsNot Nothing Then
                    posterPicBox.Load(movie.PosterUrl)
                    posterPicBox.SizeMode = PictureBoxSizeMode.StretchImage
                    posterPicBox.Width = 200
                    posterPicBox.Height = 300
                    posterPicBox.Margin = New Padding(1)
                    posterPicBox.Tag = movie
                    resultFlowPanel.Controls.Add(posterPicBox)
                End If
            Next
        End If
    End Sub

End Module

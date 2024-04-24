Imports System.Drawing.Drawing2D
Imports System.Windows.Media.Effects

Public Class FormStats

    Private Sub FormStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        crtWeekdays.ChartAreas(0).AxisY.Interval = 1
        ' Assuming crtWeekdays is your chart control

        ' Assuming crtWeekdays is your chart control
        crtWeekdays.Titles.Add("Most popular day for movies")
        crtWeekdays.Titles(0).Font = New Font("Arial", 14, FontStyle.Bold)

        crtWeekdays.BackColor = Color.LightCyan

        ' Add data points to the series
        For Each day In StatFunction.weekdayMoviesWatched
            crtWeekdays.Series("Series1").Points.AddXY(day.Key, day.Value) ' Adding data points (x, y)
        Next

        lblGenre.Text = StatFunction.mostPopularGenre
        lblTime.Text = StatFunction.minutesWatched

        ' Check if inputs in StatFunction are empty
        If String.IsNullOrEmpty(StatFunction.mostPopularMovie) Then
            ' If empty, load the "no search result" image
            pbMostPopularMovie.Load("https://cdn.dribbble.com/users/760295/screenshots/4433975/no-search-result.png")
        Else
            pbMostPopularMovie.Load(StatFunction.mostPopularMovie)
        End If

    End Sub

    Private Sub pbMostPopularMovie_MouseEnter(sender As Object, e As EventArgs) Handles pbMostPopularMovie.MouseEnter
        pbMostPopularMovie.Size = New Size(pbMostPopularMovie.Width + 20, pbMostPopularMovie.Height + 20) ' Increase size in every direction
        pbMostPopularMovie.Location = New Point(pbMostPopularMovie.Location.X - 10, pbMostPopularMovie.Location.Y - 10) ' Move picture box to center
    End Sub

    Private Sub pbMostPopularMovie_MouseLeave(sender As Object, e As EventArgs) Handles pbMostPopularMovie.MouseLeave
        pbMostPopularMovie.Size = New Size(pbMostPopularMovie.Width - 20, pbMostPopularMovie.Height - 20) ' Return to original size
        pbMostPopularMovie.Location = New Point(pbMostPopularMovie.Location.X + 10, pbMostPopularMovie.Location.Y + 10) ' Move picture box back
    End Sub

End Class
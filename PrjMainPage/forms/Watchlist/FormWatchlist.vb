Public Class FormWatchlist
    Private Sub FormWatchlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WatchlistFunctions.AddPosterDynamicallyWatchlist(flowPnlWatchlist)
        UiHelpFunctions.MakeRoundedEdgesPanel(pnlWatchlistLabel, 10)
    End Sub
End Class
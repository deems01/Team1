Imports System.Collections.Generic

Public Class FormFilmPage
    Private Sub FormFilmPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UiHelpFunctions.MakeRoundedEdgesPanel(pnlPoster, 30)
        UiHelpFunctions.MakeRoundedEdgesPanel(pnlDescription, 30)
        UiHelpFunctions.MakeRoundedEdgesPanel(pnlFilmName, 20)

        FilmPageFunctions.attachPoster(pbPoster)
        FilmPageFunctions.attachFilmTitle(lblFilmName)
        FilmPageFunctions.attachFilmOverview(rTxtDescription)

    End Sub

    Private Sub btnAddToWatchlist_Click(sender As Object, e As EventArgs) Handles btnAddToWatchlist.Click
        WatchlistFunctions.setWatchlistMember(FilmPageFunctions.getClickedMovie())
    End Sub
End Class
Public Class FormSearchResultPage
    Private Sub FormSearchResultPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiHelpFunctions.MakeRoundedEdgesPanel(pnlSearchResult, 10)

        lbl.Text = NameSearchFunctions.getSearchedFilmName()

        NameSearchFunctions.AddPanelsDynamically(Me)
    End Sub

End Class
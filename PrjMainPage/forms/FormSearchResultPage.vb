Public Class FormSearchResultPage
    Private Sub FormSearchResultPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiHelpFunctions.MakeRoundedEdgesPanel(pnlSearchResult, 10)

        lbl.Text = NameSearchFunctions.getSearchedFilmName()

        NameSearchFunctions.AddPosterDynamically(flowPanelResult)
    End Sub

End Class
﻿Public Class FormSearchResultPage

    Private Sub FormSearchResultPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UiHelpFunctions.MakeRoundedEdgesPanel(pnlSearchResult, 10)

        lbl.Text = NameSearchFunctions.GetSearchedFilmName()

        NameSearchFunctions.AddPosterDynamically(flowPanelResult)

    End Sub

    Private Sub btnComparison_Click(sender As Object, e As EventArgs) Handles btnComparison.Click
        Dim comparisonPanel As Panel = MovieComparisonFunctions.CreateComparisonPanel()
        Me.Controls.Add(comparisonPanel)
        comparisonPanel.BringToFront()
        comparisonPanel.Location = New Point((Me.ClientSize.Width - comparisonPanel.Width) \ 2, (Me.ClientSize.Height - comparisonPanel.Height) \ 2)
    End Sub

End Class
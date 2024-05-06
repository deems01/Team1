Imports System.Collections.Generic
Imports System.Windows.Controls.Primitives
Imports Newtonsoft.Json.Linq

Public Class FormFilmPage
    Private Sub FormFilmPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UiHelpFunctions.MakeRoundedEdgesPanel(pnlPoster, 30)
        UiHelpFunctions.MakeRoundedEdgesPanel(pnlDescription, 30)
        UiHelpFunctions.MakeRoundedEdgesPanel(pnlFilmName, 20)

        FilmPageFunctions.attachPoster(pbPoster)
        FilmPageFunctions.attachFilmTitle(lblFilmName)
        FilmPageFunctions.attachFilmOverview(rTxtDescription)
        FilmPageFunctions.setTags()
        FilmPageFunctions.setComments()
        FilmPageFunctions.AddTagsDynamically(flowPanelTags)

    End Sub

    Private Sub btnAddToWatchlist_Click(sender As Object, e As EventArgs) Handles btnAddToWatchlist.Click
        SaveToWatchlist()
        WatchlistFunctions.setWatchlistMember(FilmPageFunctions.getClickedMovie())
    End Sub

    Private Sub flowPanelTags_MouseEnter(sender As Object, e As EventArgs) Handles flowPanelTags.MouseEnter
        Dim panel As FlowLayoutPanel = CType(sender, FlowLayoutPanel)
        panel.BackColor = Color.Orange
    End Sub

    Private Sub flowPanelTags_MouseLeave(sender As Object, e As EventArgs) Handles flowPanelTags.MouseLeave
        Dim panel As FlowLayoutPanel = CType(sender, FlowLayoutPanel)
        panel.BackColor = Color.BurlyWood
    End Sub

    Private Sub flowPanelTags_Click(sender As Object, e As EventArgs) Handles flowPanelTags.Click
        Dim childForm As Form = UiHelpFunctions.getChildForm()
        Dim tagPanel As Panel = FilmPageFunctions.CreateTagForm()

        If FilmPageFunctions.tags.Count > 10 Then
            MessageBox.Show("Movie can have max 10 tags")
        Else
            childForm.Controls.Add(tagPanel)
            tagPanel.Location = New Point((Me.ClientSize.Width - tagPanel.Width) \ 2, (Me.ClientSize.Height - tagPanel.Height) \ 2)
            tagPanel.BringToFront()
        End If

    End Sub

    Private Sub btnComments_Click(sender As Object, e As EventArgs) Handles btnComments.Click
        Dim commentPanel As Panel = FilmPageFunctions.CreateCommentsPanel
        Me.Controls.Add(commentPanel)
        commentPanel.BringToFront()
        commentPanel.Location = New Point((Me.ClientSize.Width - commentPanel.Width) \ 2, (Me.ClientSize.Height - commentPanel.Height) \ 2)
    End Sub

End Class
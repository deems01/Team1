Public Class FormCategoryResult
    Private Sub FormCategoryResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiHelpFunctions.MakeRoundedEdgesPanel(pnlSearchResult, 10)
        UiHelpFunctions.MakeRoundedEdgesPanel(pnlOptionalResult, 10)

        lbl.Text = CategoryFunctions.getPickedCategory()
        If CategoryFunctions.getSearch() = "" Then
            Me.Controls.Remove(pnlOptionalResult)
        Else
            lblCateSearch.Text = CategoryFunctions.getSearch()
        End If

        CategoryFunctions.AddPosterDynamicallyCategory(flowPanelResult)

    End Sub

End Class
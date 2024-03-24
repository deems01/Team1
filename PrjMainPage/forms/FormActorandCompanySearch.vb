Public Class FormActorandCompanySearch
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        CategoryFunctions.setSearch(txtSearch.Text)
        UiHelpFunctions.OpenChildForm(FormCategoryResult)
    End Sub
End Class
Public Class FormCategories
    Private Sub tabelpnlGenre_Click(sender As Object, e As EventArgs) Handles tabelpnlGenre.Click
        UiHelpFunctions.OpenChildForm(FormGenreSelection)
        CategoryFunctions.setPickedCategory("genre")
    End Sub

    Private Sub TableLayoutPanel2_Click(sender As Object, e As EventArgs) Handles TableLayoutPanel2.Click
        CategoryFunctions.setPickedCategory("Old")
    End Sub
    Private Sub TableLayoutPanel4_Click(sender As Object, e As EventArgs) Handles TableLayoutPanel2.Click
        CategoryFunctions.setPickedCategory("New")
    End Sub
    Private Sub TableLayoutPanel5_Click(sender As Object, e As EventArgs) Handles TableLayoutPanel2.Click
        CategoryFunctions.setPickedCategory("Company")
        UiHelpFunctions.OpenChildForm(FormActorandCompanySearch)
    End Sub
    Private Sub TableLayoutPanel3_Click(sender As Object, e As EventArgs) Handles TableLayoutPanel2.Click
        CategoryFunctions.setPickedCategory("Actor")
        UiHelpFunctions.OpenChildForm(FormActorandCompanySearch)
    End Sub
End Class
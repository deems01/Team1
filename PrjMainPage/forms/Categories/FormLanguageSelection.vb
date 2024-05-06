Public Class FormLanguageSelection
    Private Sub cmbGenreSelection_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbLanguageSelection.SelectionChangeCommitted
        Dim selectedLanguage As String = cmbLanguageSelection.SelectedItem.ToString()
        ' Do something with the selected genre...
        CategoryFunctions.setSearch(selectedLanguage)

        UiHelpFunctions.OpenChildForm(FormCategoryResult)
    End Sub

End Class
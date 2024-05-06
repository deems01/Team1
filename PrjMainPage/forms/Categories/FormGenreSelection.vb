Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormGenreSelection

    Private Sub cmbGenreSelection_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbGenreSelection.SelectionChangeCommitted
        Dim selectedGenre As String = cmbGenreSelection.SelectedItem.ToString()
        ' Do something with the selected genre...
        CategoryFunctions.setSearch(selectedGenre)

        UiHelpFunctions.OpenChildForm(FormCategoryResult)
    End Sub

End Class
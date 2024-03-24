Imports System.Data.Common

Public Class FormCategories

    Private Sub lblOld_Click(sender As Object, e As EventArgs) Handles lblOld.Click
        CategoryFunctions.setPickedCategory("Old")
        UiHelpFunctions.OpenChildForm(FormCategoryResult)
    End Sub

    Private Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        CategoryFunctions.setPickedCategory("New")
        UiHelpFunctions.OpenChildForm(FormCategoryResult)
    End Sub

    Private Sub lblCompany_Click(sender As Object, e As EventArgs) Handles lblCompany.Click
        CategoryFunctions.setPickedCategory("Company")
        Dim searchBar As New FormActorandCompanySearch()
        tabelpnlCompany.Controls.Add(searchBar.pnlSearch, 1, 1)
    End Sub

    Private Sub lblActor_Click(sender As Object, e As EventArgs) Handles lblActor.Click
        CategoryFunctions.setPickedCategory("Actor")
        Dim searchBar As New FormActorandCompanySearch()
        tabelpnlActor.Controls.Add(searchBar.pnlSearch, 1, 1)
    End Sub

    Private Sub lblGenre_Click(sender As Object, e As EventArgs) Handles lblGenre.Click
        Dim genreForm As New FormGenreSelection()
        tabelpnlGenre.Controls.Add(genreForm.cmbGenreSelection, 1, 1)
        CategoryFunctions.setPickedCategory("genre")
    End Sub

    Private Sub FormCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryFunctions.setSearch("")
    End Sub
End Class
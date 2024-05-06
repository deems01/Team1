Imports System.Data.Common
Public Class FormCategories

    Private columnOriginalWidths As New List(Of Single)
    Private disableMouseEnterEvents As Boolean = False ' Flag to control mouse enter events

    Private Sub FormCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryFunctions.setSearch("")
        For i As Integer = 0 To 7
            Dim columnWidth As Single = TableLayoutPanel1.ColumnStyles(i).Width
            columnOriginalWidths.Add(columnWidth)
        Next

        ' Add event handlers to each panel
        For i As Integer = 0 To 7
            Dim panel As Panel = CType(TableLayoutPanel1.GetControlFromPosition(i, 0), Panel)
            AddHandler panel.MouseEnter, AddressOf Column_MouseEnter
            AddHandler panel.MouseLeave, AddressOf Column_MouseLeave
        Next
    End Sub

    Private Sub Column_MouseEnter(sender As Object, e As EventArgs)
        If Not disableMouseEnterEvents Then ' Check if mouse enter events are not disabled
            Dim panel As Panel = DirectCast(sender, Panel)
            Dim columnIndex As Integer = TableLayoutPanel1.GetColumn(panel)
            Dim columnWidth As Integer = TableLayoutPanel1.ColumnStyles(columnIndex).Width

            ' Increase width by 20% if it's not already increased
            If TableLayoutPanel1.ColumnStyles(columnIndex).Width = columnOriginalWidths(columnIndex) Then
                TableLayoutPanel1.ColumnStyles(columnIndex).Width = columnWidth * 2
            End If

        End If
    End Sub

    Private Sub Column_MouseLeave(sender As Object, e As EventArgs)

        If Not disableMouseEnterEvents Then
            Dim panel As Panel = DirectCast(sender, Panel)
            Dim columnIndex As Integer = TableLayoutPanel1.GetColumn(panel)
            Dim columnWidth As Integer = TableLayoutPanel1.Width

            ' Restore original width
            TableLayoutPanel1.ColumnStyles(columnIndex).Width = columnOriginalWidths(columnIndex)
        End If
    End Sub

    Private Sub pnlActor_Click(sender As Object, e As EventArgs) Handles pnlActor.Click

        If Not disableMouseEnterEvents Then

            CategoryFunctions.setPickedCategory("Actor")
            Dim searchBar As New FormActorandCompanySearch()
            'tabelpnlActor.Controls.Add(searchBar.pnlSearch, 1, 1)
            searchBar.pnlSearch.Dock = DockStyle.Top
            pnlActor.Controls.Add(searchBar.pnlSearch)

        End If

        disableMouseEnterEvents = True

    End Sub

    Private Sub pnlCompany_Click(sender As Object, e As EventArgs) Handles pnlCompany.Click

        If Not disableMouseEnterEvents Then

            CategoryFunctions.setPickedCategory("Company")
            Dim searchBar As New FormActorandCompanySearch()
            'tabelpnlCompany.Controls.Add(searchBar.pnlSearch, 1, 1)
            searchBar.pnlSearch.Dock = DockStyle.Top
            pnlCompany.Controls.Add(searchBar.pnlSearch)

        End If

        disableMouseEnterEvents = True

    End Sub

    Private Sub pnlGenre_Click(sender As Object, e As EventArgs) Handles pnlGenre.Click

        If Not disableMouseEnterEvents Then

            Dim genreForm As New FormGenreSelection()
            genreForm.cmbGenreSelection.DropDownStyle = ComboBoxStyle.DropDownList
            'tabelpnlGenre.Controls.Add(genreForm.cmbGenreSelection, 1, 1)
            genreForm.cmbGenreSelection.Dock = DockStyle.Top
            pnlGenre.Controls.Add(genreForm.cmbGenreSelection)
            CategoryFunctions.setPickedCategory("genre")

        End If

        disableMouseEnterEvents = True

    End Sub

    Private Sub pnlLanguage_Click(sender As Object, e As EventArgs) Handles pnlLanguage.Click

        If Not disableMouseEnterEvents Then
            Dim languageForm As New FormLanguageSelection()
            languageForm.cmbLanguageSelection.DropDownStyle = ComboBoxStyle.DropDownList
            languageForm.cmbLanguageSelection.Dock = DockStyle.Top
            pnlLanguage.Controls.Add(languageForm.cmbLanguageSelection)
            CategoryFunctions.setPickedCategory("Language")
        End If

        disableMouseEnterEvents = True

    End Sub

    Private Sub pnlNew_Click(sender As Object, e As EventArgs) Handles pnlNew.Click

        If Not disableMouseEnterEvents Then

            CategoryFunctions.setPickedCategory("New")
            UiHelpFunctions.OpenChildForm(FormCategoryResult)

        End If

        disableMouseEnterEvents = True

    End Sub

    Private Sub pnlOld_Click(sender As Object, e As EventArgs) Handles pnlOld.Click

        If Not disableMouseEnterEvents Then

            CategoryFunctions.setPickedCategory("Old")
            UiHelpFunctions.OpenChildForm(FormCategoryResult)

        End If

        disableMouseEnterEvents = True

    End Sub

    Private Sub pnlRand_Click(sender As Object, e As EventArgs) Handles pnlRand.Click

        If Not disableMouseEnterEvents Then

            CategoryFunctions.setPickedCategory("Random")
            UiHelpFunctions.OpenChildForm(FormCategoryResult)

        End If

        disableMouseEnterEvents = True

    End Sub

    Private Sub pnlRec_Click(sender As Object, e As EventArgs) Handles pnlRec.Click

        If Not disableMouseEnterEvents Then


        End If

        disableMouseEnterEvents = True

    End Sub


    'Private Sub BtnRandom_Click(sender As Object, e As EventArgs)
    '    CategoryFunctions.setPickedCategory("Random")
    '    UiHelpFunctions.OpenChildForm(FormCategoryResult)
    'End Sub
End Class
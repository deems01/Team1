Public Class FormActorandCompanySearch
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        CategoryFunctions.setSearch(txtSearch.Text)
        UiHelpFunctions.OpenChildForm(FormCategoryResult)

        AdjustTextBoxFontSize()

    End Sub

    Private Sub AdjustTextBoxFontSize()
        ' Calculate the font size based on the screen resolution
        Dim screenSize As Size = Screen.PrimaryScreen.WorkingArea.Size
        Dim fontSize As Single = Math.Min(screenSize.Width, screenSize.Height) / 20 ' Adjust this factor as needed

        ' Set the font size for the TextBox
        txtSearch.Font = New Font("Microsoft Sans Serif", fontSize, FontStyle.Bold)
    End Sub
End Class
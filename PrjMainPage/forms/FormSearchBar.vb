Public Class FormSearchBar
    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        If txtSearch.Text = "Search" Then
            txtSearch.Text = ""
        End If
    End Sub
    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Search"
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        NameSearchFunctions.setSearchedFilmName(txtSearch.Text)
        UiHelpFunctions.OpenChildForm(New FormSearchResultPage)
    End Sub
End Class
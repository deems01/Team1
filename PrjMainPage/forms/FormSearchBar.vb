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
        If txtSearch.Text = "Search" Then
            Return
        End If
        NameSearchFunctions.SetSearchedFilmName(txtSearch.Text)
        UiHelpFunctions.OpenChildForm(New FormSearchResultPage)
    End Sub

    Private Sub FormSearchBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NameSearchFunctions.GetDateFlag() = 1 Then
            Dim lblInstructions As New Label()
            lblInstructions.AutoSize = True
            lblInstructions.Text = "Enter the movie title for your movie night:"
            lblInstructions.ForeColor = Color.Black
            lblInstructions.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)
            lblInstructions.Location = New Point(10, 10)

            Me.Controls.Add(lblInstructions)
        End If

        txtSearch.Text = "Search"
    End Sub
End Class
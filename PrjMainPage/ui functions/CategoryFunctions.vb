Module CategoryFunctions

    Private pickedCategory As String
    Private enteredSearch As String

    Public Sub setPickedCategory(category As String)
        pickedCategory = category
    End Sub

    Public Function getPickedCategory()
        Return pickedCategory
    End Function

    Public Sub setSearch(search As String)
        enteredSearch = search
    End Sub

    Public Function getSearch()
        Return enteredSearch
    End Function
    Public Sub AddPanelsDynamically(resultForm As Form)

        Dim inputData As New List(Of String) From {"veiko", "uku", "juhan"}

        Dim panelStartX As Integer = 12
        Dim panelStartY As Integer = 45
        Dim spacingBetweenLabels As Integer = 25
        Dim panelWidth As Integer = 539
        Dim initialPanelHeight As Integer = 20

        For Each name As String In inputData
            Dim newPanel As New Panel()
            newPanel.BackColor = Color.LightBlue
            newPanel.AutoSize = True
            newPanel.Width = panelWidth
            newPanel.Height = initialPanelHeight
            newPanel.Location = New Point(panelStartX, panelStartY)

            ' Title Label
            Dim titleLabel As New Label()
            titleLabel.Text = name
            titleLabel.AutoSize = True

            newPanel.Controls.Add(titleLabel)
            resultForm.Controls.Add(newPanel)

            panelStartY += newPanel.Height + 10
        Next

    End Sub

End Module

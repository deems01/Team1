Imports SortClass
Module MovieComparisonFunctions

    Public Movies As New List(Of Object)

    Function SetMoviesForComparison(comparisonMovie As Object)

        If Movies.Count < 2 Then
            Movies.Add(comparisonMovie)
            Return True
        Else
            Return False
        End If

    End Function

    Function CreateComparisonPanel() As Panel
        Dim panel As New Panel()
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.Size = New Size(1041, 381)

        ' TableLayoutPanel for movie1
        Dim tableLayoutPanel1 As New TableLayoutPanel()
        tableLayoutPanel1.Width = panel.Width / 2
        tableLayoutPanel1.Height = panel.Height / 1.2
        tableLayoutPanel1.ColumnCount = 2
        tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30))
        tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70))
        tableLayoutPanel1.BackColor = Color.LightBlue
        tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single

        ' TableLayoutPanel for movie2
        Dim tableLayoutPanel2 As New TableLayoutPanel()
        tableLayoutPanel2.Location = New Point(panel.Width / 2, 0)
        tableLayoutPanel2.Width = panel.Width / 2
        tableLayoutPanel2.Height = panel.Height / 1.2
        tableLayoutPanel2.ColumnCount = 2
        tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30))
        tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70))
        tableLayoutPanel2.BackColor = Color.LightGray
        tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single

        Dim lblLabel As New Label()
        lblLabel.Text = "Poster:"
        lblLabel.Dock = DockStyle.Fill
        lblLabel.TextAlign = ContentAlignment.MiddleRight

        Dim language As String

        If Movies.Count > 0 Then
            ' Add rows and labels for each movie property - Movie 1
            AddRow(tableLayoutPanel1, "Title:", Movies(0).Title)
            AddRow(tableLayoutPanel1, "Overview:", Movies(0).Overview)
            AddRow(tableLayoutPanel1, "Release Date:", Movies(0).ReleaseDate.ToShortDateString())

            language = FetchLanguage(Movies(0).Language)

            AddRow(tableLayoutPanel1, "Language:", language)
            ' Add PictureBox for PosterUrl - Movie 1

            Dim pictureBox1 As New PictureBox()
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            pictureBox1.Load(Movies(0).PosterUrl)
            pictureBox1.Dock = DockStyle.Fill
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 5)
            tableLayoutPanel1.Controls.Add(lblLabel, 0, 5)
        End If

        If Movies.Count > 1 Then
            ' Add rows and labels for each movie property - Movie 2
            AddRow(tableLayoutPanel2, "Title:", Movies(1).Title)
            AddRow(tableLayoutPanel2, "Overview:", Movies(1).Overview)
            AddRow(tableLayoutPanel2, "Release Date:", Movies(1).ReleaseDate.ToShortDateString())

            language = FetchLanguage(Movies(1).Language)

            AddRow(tableLayoutPanel2, "Language:", language)
            ' Add PictureBox for PosterUrl - Movie 2
            Dim pictureBox2 As New PictureBox()
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
            pictureBox2.Dock = DockStyle.Fill
            pictureBox2.Load(Movies(1).PosterUrl)
            tableLayoutPanel2.Controls.Add(pictureBox2, 1, 5)
            tableLayoutPanel2.Controls.Add(lblLabel, 0, 5)
        End If

        ' Close Button
        Dim btnClose As New Button()
        btnClose.Text = "Close"
        btnClose.Size = New Size(75, 23)
        btnClose.Location = New Point(panel.Width / 2 - (btnClose.Width / 2), 325)
        AddHandler btnClose.Click, Sub(sender, e) panel.Parent.Controls.Remove(panel)

        ' Clean 1 Button
        Dim btnClean1 As New Button()
        btnClean1.Text = "Clean 1"
        btnClean1.Size = New Size(75, 23)
        btnClean1.Location = New Point(25, 325)
        AddHandler btnClean1.Click, Sub(sender, e) CleanMovie(0, panel)

        ' Clean 2 Button
        Dim btnClean2 As New Button()
        btnClean2.Text = "Clean 2"
        btnClean2.Size = New Size(75, 23)
        btnClean2.Location = New Point(panel.Width - 100, 325)
        AddHandler btnClean2.Click, Sub(sender, e) CleanMovie(1, panel)

        ' Add buttons to the panel
        panel.Controls.Add(btnClose)
        panel.Controls.Add(btnClean1)
        panel.Controls.Add(btnClean2)

        If Movies.Count > 0 Then
            panel.Controls.Add(tableLayoutPanel1)
        End If

        If Movies.Count > 1 Then
            panel.Controls.Add(tableLayoutPanel2)
        End If

        Return panel
    End Function

    Sub AddRow(tableLayoutPanel As TableLayoutPanel, label As String, value As String)
        Dim lblLabel As New Label()
        lblLabel.Text = label
        lblLabel.Dock = DockStyle.Fill
        lblLabel.TextAlign = ContentAlignment.MiddleRight

        Dim lblValue As New Label()
        lblValue.Text = value
        lblValue.Dock = DockStyle.Fill
        lblValue.TextAlign = ContentAlignment.MiddleLeft

        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tableLayoutPanel.Controls.Add(lblLabel)
        tableLayoutPanel.Controls.Add(lblValue)
    End Sub


    Sub CleanMovie(index As Integer, panel As Panel)
        If index >= 0 AndAlso index < Movies.Count Then
            Movies.RemoveAt(index)
            ReloadComparisonPanel(panel)
        End If
    End Sub

    Sub ReloadComparisonPanel(panel As Panel)
        ' Clear existing panel controls
        panel.Controls.Clear()

        ' Create the comparison panel again
        Dim newPanel As Panel = CreateComparisonPanel()

        ' Add the new panel to the form or wherever your comparisonPanel is located
        Dim childForm As Form = UiHelpFunctions.getChildForm()
        childForm.Controls.Remove(panel)
        childForm.Controls.Add(newPanel)

        ' Set panel visibility to false initially
        newPanel.Visible = False

        ' Add event handler to handle when the panel is fully loaded
        AddHandler newPanel.VisibleChanged, Sub(sender, e)
                                                If newPanel.Visible Then
                                                    ' Adjust panel position
                                                    newPanel.Location = New Point((childForm.ClientSize.Width - newPanel.Width) \ 2, (childForm.ClientSize.Height - newPanel.Height) \ 2)
                                                End If
                                            End Sub

        ' Bring the new panel to the front
        newPanel.BringToFront()

        ' Ensure the panel is fully loaded
        newPanel.Visible = True
    End Sub

    Private ReadOnly languageMapping As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
         {"en", "English"},
         {"fr", "French"},
         {"es", "Spanish"},
         {"de", "German"},
         {"it", "Italian"},
         {"pt", "Portuguese"},
         {"ru", "Russian"},
         {"zh", "Chinese"},
         {"ja", "Japanese"},
         {"ar", "Arabic"},
         {"hi", "Hindi"},
         {"ko", "Korean"},
         {"nl", "Dutch"},
         {"sv", "Swedish"},
         {"no", "Norwegian"},
         {"da", "Danish"},
         {"fi", "Finnish"},
         {"el", "Greek"},
         {"tr", "Turkish"},
         {"pl", "Polish"},
         {"hu", "Hungarian"},
         {"cs", "Czech"},
         {"th", "Thai"},
         {"id", "Indonesian"},
         {"vi", "Vietnamese"}
     }

    Public Function FetchLanguage(languageCode As String) As String
        Dim languageName As String = ""
        If languageMapping.ContainsKey(languageCode.ToLower()) Then
            languageName = languageMapping(languageCode.ToLower())
        Else
            languageName = "Unknown"
        End If
        Return languageName
    End Function


End Module

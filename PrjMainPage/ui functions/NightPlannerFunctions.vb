Imports FilmDatabase.FilmdbModel
Imports FilmDatabase
Module NightPlannerFunctions

    Public filmPlanning As New List(Of Dictionary(Of String, String)) 'From {
    'New Dictionary(Of String, String) From {{"name", "Movie1"}, {"date", "2024-04-22"}, {"place", "bosniaherzegovina"}},
    'New Dictionary(Of String, String) From {{"name", "Movie2"}, {"date", "2024-04-21"}, {"place", "bosniaherzegovina"}},
    ' New Dictionary(Of String, String) From {{"name", "Movie3"}, {"date", "2024-04-31"}, {"place", "tere"}}
    ' }

    Public Sub GetPlannedInformation()
        filmPlanning.Clear()

        Dim db As New FilmdbModel()
        Dim currentDate As Date = Date.Today

        Dim query = From plan In db.Planning
                    Where plan.PlannedDate >= currentDate
                    Select plan

        For Each plan In query
            Dim planDict As New Dictionary(Of String, String)
            planDict.Add("name", plan.Film.Name)
            planDict.Add("date", plan.PlannedDate.ToString)
            planDict.Add("place", plan.PlannedPlace)
            filmPlanning.Add(planDict)
        Next
    End Sub


    Public Sub AddPlanDynamically(planForm As Form)
        GetPlannedInformation()

        Dim panelHeight As Integer = 30
        Dim panelWidth As Integer = 96
        Dim startY As Integer = 50
        Dim panelX As Integer = 30
        Dim cap As Integer = 5
        Dim i As Integer = 1

        For Each filmPlan As Dictionary(Of String, String) In filmPlanning
            Dim filmPanel As New Panel
            Dim lblname As New Label
            Dim lblDate As New Label
            Dim lblPlace As New Label

            filmPanel.Width = planForm.Width - panelX - 6
            filmPanel.Height = panelHeight
            filmPanel.Location = New Point(panelX, (1 * startY) +
                                              ((i - 1) * panelHeight) + ((i - 1) * cap))
            filmPanel.BackColor = Color.LightBlue
            filmPanel.Anchor = AnchorStyles.Right
            filmPanel.Anchor = AnchorStyles.Left
            filmPanel.Anchor = AnchorStyles.Top

            lblname.Text = filmPlan("name")
            lblname.Location = New Point(10, 3)
            lblname.BackColor = Color.LightGreen
            lblname.AutoSize = True
            lblname.Font = New Font(lblname.Font.FontFamily, 14)

            lblDate.Text = filmPlan("date")
            lblDate.BackColor = Color.LightGreen
            lblDate.AutoSize = False
            lblDate.Font = New Font(lblDate.Font.FontFamily, 19)
            lblDate.TextAlign = ContentAlignment.MiddleCenter
            lblDate.Dock = DockStyle.Fill

            lblPlace.Text = filmPlan("place")
            lblPlace.BackColor = Color.LightGreen
            lblPlace.AutoSize = True
            lblPlace.Font = New Font(lblname.Font.FontFamily, 19)
            lblPlace.Dock = DockStyle.Right
            lblPlace.Location = New Point(filmPanel.Width - lblPlace.Width - 10, 3)


            Dim maxWidth As Integer = lblPlace.Width
            If lblPlace.PreferredWidth > maxWidth Then
                maxWidth = lblPlace.PreferredWidth
            End If


            lblDate.Width = maxWidth

            lblDate.Location = New Point((filmPanel.Width - lblDate.Width) \ 2, 3)

            UiHelpFunctions.MakeRoundedEdgesPanel(filmPanel, 5)
            filmPanel.Controls.Add(lblname)
            filmPanel.Controls.Add(lblDate)
            filmPanel.Controls.Add(lblPlace)
            planForm.Controls.Add(filmPanel)

            i += 1
        Next

    End Sub



End Module
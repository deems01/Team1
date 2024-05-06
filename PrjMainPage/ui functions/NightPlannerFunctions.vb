Imports FilmDatabase.FilmdbModel
Imports FilmDatabase

Module NightPlannerFunctions

    Public filmPlanning As New List(Of Dictionary(Of String, String))


    Public Sub AddPlanDynamically(planForm As Form)

        GetPlannedInformation()
        Dim panelHeight As Integer = 30
        Dim startY As Integer = 50
        Dim panelX As Integer = 30
        Dim cap As Integer = 5
        Dim i As Integer = 1

        For Each filmPlan As Dictionary(Of String, String) In filmPlanning
            Dim filmPanel As New TableLayoutPanel
            Dim lblName As New Label
            Dim lblDate As New Label
            Dim lblPlace As New Label

            filmPanel.Width = planForm.Width - 2 * panelX
            filmPanel.Height = panelHeight
            filmPanel.Location = New Point(panelX, startY + ((i - 1) * (panelHeight + cap)))
            filmPanel.BackColor = Color.LightBlue
            filmPanel.ColumnCount = 3
            filmPanel.RowCount = 1
            filmPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.0F)) ' 40% for name 
            filmPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F)) ' 30% for date 
            filmPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F)) ' 30% for loc 
            filmPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, panelHeight))
            filmPanel.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top

            lblName.Text = filmPlan("name")
            lblName.BackColor = Color.LightGreen
            lblName.Dock = DockStyle.Fill
            lblName.Font = New Font(lblName.Font.FontFamily, 14)

            lblDate.Text = filmPlan("date")
            lblDate.BackColor = Color.LightGreen
            lblDate.Dock = DockStyle.Fill
            lblDate.TextAlign = ContentAlignment.MiddleCenter
            lblDate.Font = New Font(lblDate.Font.FontFamily, 14)

            lblPlace.Text = filmPlan("place")
            lblPlace.BackColor = Color.LightGreen
            lblPlace.Dock = DockStyle.Fill
            lblPlace.Font = New Font(lblPlace.Font.FontFamily, 14)
            lblPlace.TextAlign = ContentAlignment.MiddleRight

            filmPanel.Controls.Add(lblName, 0, 0)
            filmPanel.Controls.Add(lblDate, 1, 0)
            filmPanel.Controls.Add(lblPlace, 2, 0)

            planForm.Controls.Add(filmPanel)

            i += 1
        Next

    End Sub

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



End Module
Module WatchHistoryFunctions

    Public watchHistory As New List(Of Dictionary(Of String, String)) From {
        New Dictionary(Of String, String) From {{"name", "Movie1"}, {"date", "2024-04-22"}},
        New Dictionary(Of String, String) From {{"name", "Movie2"}, {"date", "2024-04-21"}},
        New Dictionary(Of String, String) From {{"name", "Movie3"}, {"date", "2024-04-31"}}
    }
    'watchHistory.Add(New Dictionary(Of String, String) From {{"name", "Movie4"}, {"date", "2024-04-19"}})

    Public Sub AddHistoryDynamically(historyForm As Form)

        Dim panelHeight As Integer = 30
        Dim panelWidth As Integer = 96
        Dim startY As Integer = 50
        Dim panelX As Integer = 30
        Dim cap As Integer = 5
        Dim i As Integer = 1

        For Each history As Dictionary(Of String, String) In watchHistory
            Dim historyPanel As New Panel
            Dim lblname As New Label
            Dim lblDate As New Label

            historyPanel.Width = historyForm.Width - panelX - 6
            historyPanel.Height = panelHeight
            historyPanel.Location = New Point(panelX, (1 * startY) +
                                              ((i - 1) * panelHeight) + ((i - 1) * cap))
            historyPanel.BackColor = Color.LightBlue
            historyPanel.Anchor = AnchorStyles.Right
            historyPanel.Anchor = AnchorStyles.Left
            historyPanel.Anchor = AnchorStyles.Top

            lblname.Text = history("name")
            lblname.Location = New Point(10, 3)
            lblname.BackColor = Color.LightGreen
            lblname.AutoSize = True
            lblname.Font = New Font(lblname.Font.FontFamily, 14)

            lblDate.Text = history("date")
            lblDate.BackColor = Color.LightGreen
            lblDate.AutoSize = True
            lblDate.Font = New Font(lblname.Font.FontFamily, 19)
            lblDate.Dock = DockStyle.Right

            UiHelpFunctions.MakeRoundedEdgesPanel(historyPanel, 5)
            historyPanel.Controls.Add(lblname)
            historyPanel.Controls.Add(lblDate)
            historyForm.Controls.Add(historyPanel)

            i += 1
        Next

    End Sub


End Module

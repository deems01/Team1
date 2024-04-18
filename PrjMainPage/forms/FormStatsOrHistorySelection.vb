Public Class FormStatsOrHistorySelection
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        UiHelpFunctions.OpenChildForm(New FormWatchHistory)
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        UiHelpFunctions.OpenChildForm(New FormStats)
    End Sub
End Class
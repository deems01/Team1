Public Class FormWatchHistory
    Private Sub FormWatchHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UiHelpFunctions.CenterLabel(lblHistory, Me.ClientSize.Width)

        WatchHistoryFunctions.AddHistoryDynamically(UiHelpFunctions.getChildForm)

    End Sub

    Private Sub FormWatchHistory_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        UiHelpFunctions.CenterLabel(lblHistory, Me.ClientSize.Width)
    End Sub
End Class
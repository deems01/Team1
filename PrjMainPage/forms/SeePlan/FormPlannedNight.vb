Public Class FormPlannedNight

    Private Sub FormPlannedNight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NightPlannerFunctions.AddPlanDynamically(UiHelpFunctions.getChildForm())

    End Sub

End Class
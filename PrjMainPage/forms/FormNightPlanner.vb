Public Class FormNightPlanner

    Private selectedDateTime As DateTime
    Private place As String
    Private DateTimeFlag = False
    Private PlaceFlag = False

    Private Sub FormNightPlanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm"

        Dim lblInstructions As New Label()
        lblInstructions.AutoSize = True
        lblInstructions.Text = "Enter the date, time and location for your movie night:"
        lblInstructions.ForeColor = Color.Black
        lblInstructions.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)
        lblInstructions.Location = New Point(10, 10)

        Me.Controls.Add(lblInstructions)

        btnSubmit.Enabled = False

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimeFlag = True
        selectedDateTime = DateTimePicker1.Value
        NameSearchFunctions.SetSelectedDate(selectedDateTime)
        ValidateSubmit()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        UiHelpFunctions.OpenChildForm(New FormSearchBar)
    End Sub

    Private Sub txtBoxPlace_TextChanged(sender As Object, e As EventArgs) Handles txtBoxPlace.TextChanged
        If String.IsNullOrWhiteSpace(txtBoxPlace.Text) Then
            PlaceFlag = False
        Else
            PlaceFlag = True
        End If
        place = txtBoxPlace.Text
        NameSearchFunctions.SetSelectedPlace(place)
        ValidateSubmit()

    End Sub

    Private Sub ValidateSubmit()
        btnSubmit.Enabled = DateTimeFlag And PlaceFlag
    End Sub

End Class

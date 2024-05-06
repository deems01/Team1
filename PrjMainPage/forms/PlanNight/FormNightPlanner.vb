Public Class FormNightPlanner

    Private selectedDateTime As DateTime
    Private place As String
    Private DateTimeFlag = False
    Private PlaceFlag = False

    Private Sub FormNightPlanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm"

        Dim lblDateTime As New Label()
        lblDateTime.AutoSize = True
        lblDateTime.Text = "Choose date and time:"
        lblDateTime.ForeColor = Color.Black
        lblDateTime.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        lblDateTime.Location = New Point(DateTimePicker1.Location.X, DateTimePicker1.Location.Y - 20) ' Adjust as necessary

        Dim lblLocation As New Label()
        lblLocation.AutoSize = True
        lblLocation.Text = "Specify location:"
        lblLocation.ForeColor = Color.Black
        lblLocation.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        lblLocation.Location = New Point(txtBoxPlace.Location.X, txtBoxPlace.Location.Y - 20) ' Adjust as necessary

        Me.Controls.Add(lblDateTime)
        Me.Controls.Add(lblLocation)

        btnSubmit.Enabled = False

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        selectedDateTime = DateTimePicker1.Value
        If selectedDateTime < DateTime.Now Then
            lblDateWarning.ForeColor = Color.Red
            lblDateWarning.Text = "Please select a date and time later than the current date and time."
            lblDateWarning.Location = New Point(DateTimePicker1.Location.X, DateTimePicker1.Location.Y - 40)
            DateTimeFlag = False
        Else
            lblDateWarning.Text = ""
            DateTimeFlag = True
            NameSearchFunctions.SetSelectedDate(selectedDateTime)
        End If
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

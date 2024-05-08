
Imports EmailSender
Imports System.Threading

Public Class FormConfirmNightChoices
    Dim customFormat As String = "yyyy-MM-dd HH:mm"
    Private emailList As New List(Of String)
    Private listBoxEmails As ListBox
    Private hostEmail As String = ""
    Private hostPassword As String = ""
    Private currentYPos = 0
    Private emailSender As IEmailSender


    Private Sub FormConfirmNightChoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emailSender = New CEmailSender()

        txtBoxSelectedDate.Text = NameSearchFunctions.GetSelectedDate().ToString(customFormat)
        txtBoxSelectedMovie.Text = NameSearchFunctions.GetSelectedFilmName()
        txtBoxSelectedLocation.Text = NameSearchFunctions.GetSelectedPlace()

        Me.AutoScroll = True

        txtBoxHostPassword.PasswordChar = "*"c
        'txtBoxHostEmail.Text = "Enter your Gmail address..."
        'txtBoxHostPassword.Text = "Enter your password..."

        txtBoxSubject.Text = "Invitation to Movie Night"
        txtBoxMessage.Multiline = True
        txtBoxMessage.ScrollBars = ScrollBars.Vertical
        txtBoxMessage.Text = "Please select a group to generate the invitation message."

        listBoxEmails = Me.Controls("ListBox1")
        btnAddEmail.Enabled = False
        btnSendInvites.Enabled = False

        lblInviteStatus.Text = ""
        lblHostCredentialsStatus.Text = ""
    End Sub

    Private Sub btnAddEmail_Click(sender As Object, e As EventArgs) Handles btnAddEmail.Click
        Dim newEmail As String = txtBoxNewEmail.Text.Trim()
        If IsValidEmail(newEmail) Then
            emailList.Add(newEmail)
            UpdateEmailListDisplay()
            AddRemoveButtonToListBox(newEmail)
            txtBoxNewEmail.Text = ""
            ValidateInviteButton()
        End If
        'EmailSender.CEmailSender.SavePlanningDetailsToDatabase(NameSearchFunctions.GetSelectedDate(), NameSearchFunctions.GetSelectedFilmName(), NameSearchFunctions.GetSelectedPlace())
    End Sub

    Private Sub SendInvites()
        If emailList.Count > 0 Then

            Dim movieName As String = NameSearchFunctions.GetSelectedFilmName()
            Dim selectedDate As DateTime = NameSearchFunctions.GetSelectedDate()
            Dim selectedLocation As String = NameSearchFunctions.GetSelectedPlace()
            Dim subject As String = "Invitation to Movie Night: " & movieName
            Dim body As String = String.Empty

            If checkBoxFriends.Checked Then
                body = $"Hey there, Movie Buffs!{Environment.NewLine}{Environment.NewLine}" &
                   $"Are you ready for an epic night of popcorn, laughter, and great cinema? We’re screening {movieName} and you’re on our VIP list!{Environment.NewLine}" &
                   $"🗓 Date: {selectedDate.ToString(customFormat)}{Environment.NewLine}" &
                   $"⏰ Time: {selectedDate.ToString("HH:mm")}{Environment.NewLine}" &
                   $"📍 Location: {selectedLocation}{Environment.NewLine}{Environment.NewLine}" &
                   $"So, mark your calendars and bring your favorite movie snacks! Can’t wait to see you there.{Environment.NewLine}{Environment.NewLine}" &
                   $"Cheers!"
            End If

            If checkBoxFamily.Checked Then
                body = $"Dear Family,{Environment.NewLine}{Environment.NewLine}" &
                   $"It’s time for some quality family bonding! We’ve got a special night planned just for us with the screening of {movieName}.{Environment.NewLine}" &
                   $"🗓 Date: {selectedDate.ToString(customFormat)}{Environment.NewLine}" &
                   $"⏰ Time: {selectedDate.ToString("HH:mm")}{Environment.NewLine}" &
                   $"📍 Location: {selectedLocation}{Environment.NewLine}{Environment.NewLine}" &
                   $"Let’s gather for a cozy evening filled with laughter and heartwarming moments. See you all at movie night!{Environment.NewLine}{Environment.NewLine}" &
                   $"Warm regards."
            End If

            If checkBoxColleagues.Checked Then
                body = $"Dear Colleagues,{Environment.NewLine}{Environment.NewLine}" &
                   $"Break away from the desks and join us for an office movie night where work talk is banned, and fun is mandatory! We’ll be watching {movieName}, and it’s going to be great!{Environment.NewLine}" &
                   $"🗓 Date: {selectedDate.ToString(customFormat)}{Environment.NewLine}" &
                   $"⏰ Time: {selectedDate.ToString("HH:mm")}{Environment.NewLine}" &
                   $"📍 Location: {selectedLocation}{Environment.NewLine}{Environment.NewLine}" &
                   $"It’s the perfect chance to kick back and enjoy some time together outside the office. Your presence is eagerly awaited!{Environment.NewLine}{Environment.NewLine}" &
                   $"All the best!"
            End If

            If checkBoxAcquaintances.Checked Then
                body = $"Hello,{Environment.NewLine}{Environment.NewLine}" &
                   $"I hope this message finds you well! I wanted to extend an invitation to join us for a movie night where we will be enjoying the captivating story of {movieName}.{Environment.NewLine}" &
                   $"🗓 Date: {selectedDate.ToString(customFormat)}{Environment.NewLine}" &
                   $"⏰ Time: {selectedDate.ToString("HH:mm")}{Environment.NewLine}" &
                   $"📍 Location: {selectedLocation}{Environment.NewLine}{Environment.NewLine}" &
                   $"It’s a great opportunity to catch up and share a few laughs. Looking forward to an enjoyable evening with you!{Environment.NewLine}{Environment.NewLine}" &
                   $"Kind regards."
            End If

            txtBoxMessage.Text = body

            emailSender.SetHostEmail(hostEmail)
            emailSender.SetHostPassword(hostPassword)
            Dim success As Boolean = emailSender.SendEmails(emailList, txtBoxSubject.Text, txtBoxMessage.Text)
            If success Then
                lblInviteStatus.ForeColor = Color.Green
                lblInviteStatus.Text = "Invitations sent successfully."
                emailList.Clear()
                UpdateEmailListDisplay()
                btnSendInvites.Enabled = False
                emailSender.SavePlanningDetailsToDatabase(NameSearchFunctions.GetSelectedDate(), NameSearchFunctions.GetSelectedFilmName(), NameSearchFunctions.GetSelectedPlace())

                StatFunction.ResetDict()

                StatFunction.InitializeModuleAsync()

                UiHelpFunctions.OpenChildForm(FormSearchBar)
            Else
                lblInviteStatus.ForeColor = Color.Red
                lblInviteStatus.Text = "Failed to send invitations. Please check your credentials."
            End If
        Else
            lblInviteStatus.ForeColor = Color.Red
            lblInviteStatus.Text = "Please add at least one email address."
        End If
    End Sub


    Private Sub btnSendInvites_Click(sender As Object, e As EventArgs) Handles btnSendInvites.Click
        hostEmail = txtBoxHostEmail.Text
        hostPassword = txtBoxHostPassword.Text
        SendInvites()

    End Sub

    Private Sub UpdateEmailListDisplay()
        listBoxEmails.Items.Clear()
        For Each email In emailList
            listBoxEmails.Items.Add(email)
        Next
    End Sub

    Private Sub txtBoxNewEmail_TextChanged(sender As Object, e As EventArgs) Handles txtBoxNewEmail.TextChanged
        btnAddEmail.Enabled = IsValidEmail(txtBoxNewEmail.Text)
    End Sub

    Private Sub ValidateInviteButton()
        'btnSendInvites.Enabled = hostEmailFlag AndAlso emailList.Count > 0 'AndAlso saveFlag
        btnSendInvites.Enabled = emailList.Count > 0
    End Sub

    Private Sub RemoveEmail(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim emailToRemove As String = btn.Tag.ToString()

        If emailList.Contains(emailToRemove) Then
            emailList.Remove(emailToRemove)
            UpdateEmailListDisplay()
            ValidateInviteButton()
            listBoxEmails.Controls.Remove(btn)
        End If
    End Sub

    Private Sub AddRemoveButtonToListBox(email As String)
        Dim removeButton As New Button()
        removeButton.Text = "Remove"
        removeButton.Tag = email
        AddHandler removeButton.Click, AddressOf RemoveEmail

        listBoxEmails.Controls.Add(removeButton)
        removeButton.Location = New Point(listBoxEmails.Width - removeButton.Width, currentYPos)

        currentYPos += removeButton.Height
    End Sub


    Private Sub txtBoxHostEmail_TextChanged(sender As Object, e As EventArgs) Handles txtBoxHostEmail.TextChanged
        ValidateCredentials()
    End Sub

    Private Sub txtBoxHostPassword_TextChanged(sender As Object, e As EventArgs) Handles txtBoxHostPassword.TextChanged
        ValidateCredentials()
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Return email.Contains("@gmail.com") AndAlso email.Length > 10
    End Function

    Private Function IsValidPassword(password As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(password)
    End Function

    Private Sub ValidateCredentials()
        If IsValidEmail(txtBoxHostEmail.Text) AndAlso IsValidPassword(txtBoxHostPassword.Text) Then
            lblHostCredentialsStatus.ForeColor = Color.Green
            lblHostCredentialsStatus.Text = "Credentials valid."
            btnSendInvites.Enabled = True
        Else
            lblHostCredentialsStatus.ForeColor = Color.Red
            lblHostCredentialsStatus.Text = "Invalid email or password."
            btnSendInvites.Enabled = False
        End If
    End Sub


    Private Sub checkBoxFriends_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxFriends.CheckedChanged
        UncheckOthers(checkBoxFriends)
        UpdateEmailContent(checkBoxFriends)
    End Sub

    Private Sub checkBoxFamily_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxFamily.CheckedChanged
        UncheckOthers(checkBoxFamily)
        UpdateEmailContent(checkBoxFamily)
    End Sub

    Private Sub checkBoxColleagues_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxColleagues.CheckedChanged
        UncheckOthers(checkBoxColleagues)
        UpdateEmailContent(checkBoxColleagues)
    End Sub

    Private Sub checkBoxAcquaintances_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxAcquaintances.CheckedChanged
        UncheckOthers(checkBoxAcquaintances)
        UpdateEmailContent(checkBoxAcquaintances)
    End Sub

    Private Sub UncheckOthers(checkedBox As CheckBox)
        If checkedBox.Checked Then
            For Each control As Control In Me.Controls
                If TypeOf control Is CheckBox AndAlso control IsNot checkedBox Then
                    CType(control, CheckBox).Checked = False
                End If
            Next
        End If
    End Sub

    Private Sub UpdateEmailContent(checkedBox As CheckBox)
        Dim movieName As String = NameSearchFunctions.GetSelectedFilmName()
        Dim selectedDate As String = NameSearchFunctions.GetSelectedDate().ToString(customFormat)
        Dim selectedLocation As String = NameSearchFunctions.GetSelectedPlace()

        Dim subject As String = String.Empty
        Dim body As String = String.Empty

        If checkedBox.Checked Then
            Select Case checkedBox.Name
                Case "checkBoxFriends"
                    subject = "Let's Watch a Movie Together!"
                    body = $"Hey Friends!{Environment.NewLine}{Environment.NewLine}Join me for a movie night where we'll be watching {movieName} at {selectedLocation} on {selectedDate}.{Environment.NewLine}{Environment.NewLine}Bring your favorite snacks!{Environment.NewLine}Toivo"

                Case "checkBoxFamily"
                    subject = "Family Movie Night!"
                    body = $"Hello Family!{Environment.NewLine}{Environment.NewLine}We're planning a family movie night featuring {movieName} at {selectedLocation} on {selectedDate}.{Environment.NewLine}{Environment.NewLine}Looking forward to a great evening together.{Environment.NewLine}Toivo"

                Case "checkBoxColleagues"
                    subject = "Movie Night with Colleagues!"
                    body = $"Dear Colleagues,{Environment.NewLine}{Environment.NewLine}Escape the office and join us for a movie night. We're watching {movieName} at {selectedLocation} on {selectedDate}.{Environment.NewLine}{Environment.NewLine}Hope to see you there,{Environment.NewLine}Toivo"

                Case "checkBoxAcquaintances"
                    subject = "Come and Join Us for a Movie!"
                    body = $"Hi There,{Environment.NewLine}{Environment.NewLine}I'd love for you to join us for a movie night. We're screening {movieName} at {selectedLocation} on {selectedDate}.{Environment.NewLine}{Environment.NewLine}Best,{Environment.NewLine}Toivo"

            End Select
        End If

        txtBoxSubject.Text = subject
        txtBoxMessage.Text = body
    End Sub

End Class


Public Class FormConfirmNightChoices
    Dim customFormat As String = "yyyy-MM-dd HH:mm"
    Private emailList As New List(Of String)
    Private listBoxEmails As ListBox
    Private hostEmail As String = ""
    Private hostPassword As String = ""
    Private hostEmailFlag As Boolean = False
    Private currentYPos = 0


    Private Sub FormConfirmNightChoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBoxSelectedDate.Text = NameSearchFunctions.GetSelectedDate().ToString(customFormat)
        txtBoxSelectedMovie.Text = NameSearchFunctions.GetSelectedFilmName()
        txtBoxSelectedLocation.Text = NameSearchFunctions.GetSelectedPlace()

        listBoxEmails = Me.Controls("ListBox1")
        btnAddEmail.Enabled = False
        btnAddHostEmail.Enabled = False

        txtBoxHostPassword.PasswordChar = "*"c

        ValidateInviteButton()

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
    End Sub

    Private Sub SendInvites()
        If emailList.Count > 0 Then
            If hostEmailFlag Then
                EmailSender.CEmailSender.SendEmails(emailList, NameSearchFunctions.GetSelectedDate(), NameSearchFunctions.GetSelectedFilmName(), NameSearchFunctions.GetSelectedPlace())
                emailList.Clear()
                UpdateEmailListDisplay()
                lblInviteStatus.ForeColor = Color.Green
                lblInviteStatus.Text = "Attempted to send invitation(s)"
                btnSendInvites.Enabled = False
            Else
                lblInviteStatus.ForeColor = Color.Red
                lblInviteStatus.Text = "Please add host email and password first."
            End If
        Else
            lblInviteStatus.ForeColor = Color.Red
            lblInviteStatus.Text = "Please add at least one email address."
        End If
    End Sub

    Private Sub SetHostCredentials()
        If Not hostEmailFlag Then
            hostEmailFlag = True
            hostEmail = txtBoxAddHostEmail.Text
            EmailSender.CEmailSender.SetHostEmail(hostEmail)
            hostPassword = txtBoxHostPassword.Text
            EmailSender.CEmailSender.SetHostPassword(hostPassword)
            lblHostCredentialsStatus.ForeColor = Color.Green
            lblHostCredentialsStatus.Text = "Host credentials set"
        Else
            lblInviteStatus.ForeColor = Color.Red
            lblHostCredentialsStatus.Text = "Host credentials already set."
        End If
    End Sub

    Private Sub btnSendInvites_Click(sender As Object, e As EventArgs) Handles btnSendInvites.Click
        SendInvites()
    End Sub

    Private Sub UpdateEmailListDisplay()
        listBoxEmails.Items.Clear()
        For Each email In emailList
            listBoxEmails.Items.Add(email)
        Next
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Return email.Contains("@gmail.com")
    End Function

    Private Sub txtBoxNewEmail_TextChanged(sender As Object, e As EventArgs) Handles txtBoxNewEmail.TextChanged
        btnAddEmail.Enabled = IsValidEmail(txtBoxNewEmail.Text)
    End Sub

    Private Function IsValidPassword(password As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(password)
    End Function

    Private Sub ValidateHostCredentials()
        If Not hostEmailFlag Then
            btnAddHostEmail.Enabled = IsValidEmail(txtBoxAddHostEmail.Text) AndAlso IsValidPassword(txtBoxHostPassword.Text)
        End If
    End Sub

    Private Sub ValidateInviteButton()
        btnSendInvites.Enabled = hostEmailFlag AndAlso emailList.Count > 0
    End Sub

    Private Sub txtBoxAddHostEmail_TextChanged(sender As Object, e As EventArgs) Handles txtBoxAddHostEmail.TextChanged
        ValidateHostCredentials()
        ValidateInviteButton()
    End Sub

    Private Sub txtBoxHostPassword_TextChanged(sender As Object, e As EventArgs) Handles txtBoxHostPassword.TextChanged
        ValidateHostCredentials()
        ValidateInviteButton()
    End Sub

    Private Sub btnAddHostEmail_Click(sender As Object, e As EventArgs) Handles btnAddHostEmail.Click
        SetHostCredentials()
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

End Class

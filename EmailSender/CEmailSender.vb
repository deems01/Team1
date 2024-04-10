Imports System.Net.Mail
Imports System.IO

Public Class CEmailSender
    Private Shared hostEmail As String = ""
    Private Shared hostPassword As String = ""
    Private Shared hostEmailFlag As Boolean = False
    Private Shared allowedPasswords As New List(Of String)()

    Public Shared Sub SetHostEmail(email As String)
        hostEmail = email
    End Sub

    Public Shared Sub SetHostPassword(password As String)
        hostPassword = password
    End Sub

    Public Shared Sub SetHostEmailFlag(flag As Boolean)
        hostEmailFlag = flag
    End Sub

    Shared Sub New()
        Dim filePath As String = "C:\Users\Kasutaja\source\repos\Team1\EmailSender\appppass.txt"
        'Dim filePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "passwords.txt")
        If File.Exists(filePath) Then
            allowedPasswords.AddRange(File.ReadAllLines(filePath))
        Else
            Console.WriteLine("Password file not found.")
        End If
    End Sub

    Public Shared Sub SendEmails(recipients As List(Of String), selectedDate As DateTime, selectedMovie As String, selectedLocation As String)
        Dim subject As String = $"Invitation to Movie Night: {selectedMovie}"
        Dim body As String = $"Dear friends, you are invited to a movie night on {selectedDate.ToString("yyyy-MM-dd HH:mm")} to watch {selectedMovie} at {selectedLocation}. Please join us!"

        If allowedPasswords.Contains(hostPassword) Then
            For Each recipient As String In recipients
                SendEmail(recipient, subject, body, hostEmail, hostPassword)
            Next
        Else
            Console.WriteLine("Invalid password.")
        End If
    End Sub

    Private Shared Sub SendEmail(ByVal recipient As String, ByVal subject As String, ByVal body As String, ByVal hostEmail As String, ByVal hostPassword As String)
        Dim message As New MailMessage(hostEmail, recipient, subject, body)

        Try
            Dim smtpClient As New SmtpClient()
            smtpClient.Host = "smtp.gmail.com"
            smtpClient.Port = 587
            smtpClient.EnableSsl = True
            smtpClient.Credentials = New System.Net.NetworkCredential(hostEmail, hostPassword)
            smtpClient.Send(message)
        Catch ex As Exception
            Console.WriteLine($"An unexpected error occurred: {ex.Message}")
        End Try
    End Sub
End Class

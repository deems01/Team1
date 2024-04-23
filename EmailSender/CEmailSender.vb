Imports System.Net.Mail
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
'Imports FilmDatabase.FilmdbModel
'Imports FilmDatabase

Public Class CEmailSender
    Private Shared hostEmail As String = ""
    Private Shared hostPassword As String = ""
    Private Shared hostEmailFlag As Boolean = False
    Private Shared storedSalt As String = ""
    Private Shared storedHash As String = ""

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
        Dim filePath As String = "C:\Users\Kasutaja\source\repos\Team1\EmailSender\appppass2.txt"
        'Dim filePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "passwords.txt")
        'Dim salt As String = GenerateSalt(70)
        'HashPassword(hostPassword, salt, 10101, 70)

        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)
            If lines.Length >= 2 Then
                storedSalt = lines(0)
                storedHash = lines(1)
            Else
                Console.WriteLine("Password file format is incorrect.")
            End If
        Else
            Console.WriteLine("Password file not found.")
        End If
    End Sub

    Public Shared Function CheckPassword(ByVal inputPassword As String) As Boolean
        Dim hash As String = HashPassword(inputPassword, storedSalt, 10101, 70)
        Return hash.Equals(storedHash)

    End Function

    Public Shared Sub SendEmails(recipients As List(Of String), selectedDate As DateTime, selectedMovie As String, selectedLocation As String)
        Dim subject As String = $"Invitation to Movie Night: {selectedMovie}"
        Dim body As String = $"Dear friends, you are invited to a movie night on {selectedDate.ToString("yyyy-MM-dd HH:mm")} to watch {selectedMovie} at {selectedLocation}. Please join us!"

        If CheckPassword(hostPassword) Then
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

    Public Shared Function GenerateSalt(ByVal nSalt As Integer) As String
        Dim saltBytes = New Byte(nSalt) {}

        Using provider = New RNGCryptoServiceProvider()
            provider.GetNonZeroBytes(saltBytes)
        End Using

        Return Convert.ToBase64String(saltBytes)
    End Function

    Public Shared Function HashPassword(ByVal password As String, ByVal salt As String, ByVal nIterations As Integer, ByVal nHash As Integer) As String
        Dim saltBytes = Convert.FromBase64String(salt)

        Using rfc2898DeriveBytes = New Rfc2898DeriveBytes(password, saltBytes, nIterations)
            Return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(nHash))
        End Using
    End Function

    'Public Shared Sub SavePlanningDetailsToDatabase(selectedDate As DateTime, selectedMovie As String, selectedLocation As String)
    '    Dim db As New FilmdbModel()
    '    Dim planning As New Planning()

    '    planning.Date = selectedDate
    '    planning.Location = selectedLocation
    '    planning.Film_Id = db.Films.Where(Function(f) f.Name = selectedMovie).Select(Function(f) f.Id).FirstOrDefault()

    '    db.Planning.Add(planning)
    '    db.SaveChanges()
    'End Sub

End Class

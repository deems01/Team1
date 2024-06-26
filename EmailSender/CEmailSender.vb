﻿Imports System.Net.Mail
Imports System.IO
Imports System.Security.Cryptography
Imports FilmDatabase.FilmdbModel
Imports FilmDatabase

Public Class CEmailSender
    Implements IEmailSender

    Private Shared hostEmail As String = ""
    Private Shared hostPassword As String = ""
    Private Shared hostEmailFlag As Boolean = False
    Private Shared storedSalt As String = ""
    Private Shared storedHash As String = ""
    Private Shared userPass As String = ""

    Public Sub SetHostEmail(email As String) Implements IEmailSender.SetHostEmail
        hostEmail = email
    End Sub

    Public Sub SetHostPassword(password As String) Implements IEmailSender.SetHostPassword
        hostPassword = password
    End Sub

    Public Sub SetHostEmailFlag(flag As Boolean)
        hostEmailFlag = flag
    End Sub
    Shared Sub New()
        Dim filePath As String = Environment.GetEnvironmentVariable("MOVIE_NIGHT_HASH_FULL_PATH")
        'Dim filePath As String = "C:\Users\Kasutaja\source\repos\Team1\EmailSender\appppassHash.txt"
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
            'userPass = lines(0)
        Else
            Console.WriteLine("Password file not found.")
        End If
    End Sub

    Private Function CheckPassword(ByVal inputPassword As String) As Boolean
        Dim hash As String = HashPassword(inputPassword, storedSalt, 10101, 70)
        Return hash.Equals(storedHash)

    End Function

    Public Function SendEmails(recipients As List(Of String), subject As String, body As String) Implements IEmailSender.SendEmails
        'Dim subject As String = $"Invitation to Movie Night: {selectedMovie}"
        'Dim body As String = $"Dear friends, you are invited to a movie night on {selectedDate.ToString("yyyy-MM-dd HH:mm")} to watch {selectedMovie} at {selectedLocation}. Please join us!"

        If Not CheckPassword(hostPassword) Then
            Console.WriteLine("Invalid password.")
            Return False
        End If

        Try
            For Each recipient As String In recipients
                SendEmail(recipient, subject, body, hostEmail, hostPassword)
            Next
            Return True
        Catch ex As Exception
            Console.WriteLine($"An unexpected error occurred: {ex.Message}")
            Return False
        End Try
        'If (hostPassword = userPass) Then
        '    For Each recipient As String In recipients
        '        SendEmail(recipient, subject, body, hostEmail, hostPassword)
        '    Next
        'End If
    End Function

    Private Sub SendEmail(ByVal recipient As String, ByVal subject As String, ByVal body As String, ByVal hostEmail As String, ByVal hostPassword As String)
        Dim message As New MailMessage(hostEmail, recipient, subject, body)
        Dim smtpClient As New SmtpClient()
        smtpClient.Host = "smtp.gmail.com"
        smtpClient.Port = 587
        smtpClient.EnableSsl = True
        smtpClient.Credentials = New System.Net.NetworkCredential(hostEmail, hostPassword)
        smtpClient.Send(message)

    End Sub

    Private Function GenerateSalt(ByVal nSalt As Integer) As String
        Dim saltBytes = New Byte(nSalt) {}

        Using provider = New RNGCryptoServiceProvider()
            provider.GetNonZeroBytes(saltBytes)
        End Using

        Return Convert.ToBase64String(saltBytes)
    End Function

    Private Function HashPassword(ByVal password As String, ByVal salt As String, ByVal nIterations As Integer, ByVal nHash As Integer) As String
        Dim saltBytes = Convert.FromBase64String(salt)

        Using rfc2898DeriveBytes = New Rfc2898DeriveBytes(password, saltBytes, nIterations)
            Return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(nHash))
        End Using
    End Function

    Public Sub SavePlanningDetailsToDatabase(selectedDate As DateTime, selectedMovie As String, selectedLocation As String) Implements IEmailSender.SavePlanningDetailsToDatabase
        Dim db As New FilmdbModel()
        Dim planning As New Planning()

        Try
            planning.PlannedFilm = selectedMovie
            planning.PlannedDate = selectedDate
            planning.PlannedPlace = selectedLocation
            planning.Film_Id = db.Films.Where(Function(f) f.Name = selectedMovie).Select(Function(f) f.Id).FirstOrDefault()

            db.Planning.Add(planning)
            db.SaveChanges()
            ' Increment the counter for the added film in the Films table
            Dim existingFilm = db.Films.FirstOrDefault(Function(f) f.Id = planning.Film_Id)
            If existingFilm IsNot Nothing Then
                existingFilm.Counter += 1
                db.SaveChanges()
            End If
        Catch ex As Exception
            Console.WriteLine($"Data already in database: {ex.Message}")
        End Try
    End Sub

End Class

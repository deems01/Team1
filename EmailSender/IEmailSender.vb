Public Interface IEmailSender
    Sub SetHostEmail(email As String)
    Sub SetHostPassword(password As String)
    Sub SendEmails(recipients As List(Of String), subject As String, body As String)
    Sub SavePlanningDetailsToDatabase(selectedDate As DateTime, selectedMovie As String, selectedLocation As String)

End Interface

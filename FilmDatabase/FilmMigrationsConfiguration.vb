Imports System.Data.Entity.Migrations

Public Class FilmMigrationsConfiguration
    Inherits DbMigrationsConfiguration(Of FilmdbModel)

    Public Sub New()
        AutomaticMigrationsEnabled = True
        AutomaticMigrationDataLossAllowed = True
        ' Other configuration settings can be added here
    End Sub
End Class

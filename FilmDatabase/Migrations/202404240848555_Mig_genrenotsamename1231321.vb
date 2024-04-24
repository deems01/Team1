Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Public Partial Class Mig_genrenotsamename1231321
    Inherits DbMigration

    Public Overrides Sub Up()
        DropColumn("dbo.Films", "Genre")
    End Sub
    
    Public Overrides Sub Down()
        AddColumn("dbo.Films", "Genre", Function(c) c.Int(nullable := False))
    End Sub
End Class

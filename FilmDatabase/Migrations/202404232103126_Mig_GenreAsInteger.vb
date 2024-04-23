Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Public Partial Class Mig_GenreAsInteger
    Inherits DbMigration

    Public Overrides Sub Up()
        AddColumn("dbo.Films", "Genre", Function(c) c.Int(nullable := False))
    End Sub
    
    Public Overrides Sub Down()
        DropColumn("dbo.Films", "Genre")
    End Sub
End Class

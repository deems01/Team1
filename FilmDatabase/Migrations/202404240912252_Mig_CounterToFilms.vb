Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Public Partial Class Mig_CounterToFilms
    Inherits DbMigration

    Public Overrides Sub Up()
        AddColumn("dbo.Films", "Counter", Function(c) c.Int(nullable := False))
    End Sub
    
    Public Overrides Sub Down()
        DropColumn("dbo.Films", "Counter")
    End Sub
End Class

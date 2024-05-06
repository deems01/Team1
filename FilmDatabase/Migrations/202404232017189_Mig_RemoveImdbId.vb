Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Public Partial Class Mig_RemoveImdbId
    Inherits DbMigration

    Public Overrides Sub Up()
        DropIndex("dbo.Films", "AK_Films")
        DropColumn("dbo.Films", "Imdb_Id")
    End Sub
    
    Public Overrides Sub Down()
        AddColumn("dbo.Films", "Imdb_Id", Function(c) c.String(maxLength := 100))
        CreateIndex("dbo.Films", "Imdb_Id", unique := True, name := "AK_Films")
    End Sub
End Class

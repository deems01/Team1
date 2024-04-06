Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Public Partial Class Mig_imdbtype2
    Inherits DbMigration

    Public Overrides Sub Up()
        DropIndex("dbo.Films", "AK_Films")
        AlterColumn("dbo.Films", "Imdb_Id", Function(c) c.String(maxLength := 100))
        CreateIndex("dbo.Films", "Imdb_Id", unique := True, name := "AK_Films")
    End Sub
    
    Public Overrides Sub Down()
        DropIndex("dbo.Films", "AK_Films")
        AlterColumn("dbo.Films", "Imdb_Id", Function(c) c.Int(nullable := False))
        CreateIndex("dbo.Films", "Imdb_Id", unique := True, name := "AK_Films")
    End Sub
End Class

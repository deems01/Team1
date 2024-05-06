Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Public Partial Class Mig_AddedimdbAgain
    Inherits DbMigration

    Public Overrides Sub Up()
        AddColumn("dbo.Films", "Imdb_Id", Function(c) c.Int(nullable := False))
        CreateIndex("dbo.Films", "Imdb_Id", unique := True, name := "AK_Films")
    End Sub
    
    Public Overrides Sub Down()
        DropIndex("dbo.Films", "AK_Films")
        DropColumn("dbo.Films", "Imdb_Id")
    End Sub
End Class

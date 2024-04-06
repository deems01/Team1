Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Comments",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Film_Id = c.Int(nullable := False),
                        .Comment = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Films", Function(t) t.Film_Id, cascadeDelete := True) _
                .Index(Function(t) t.Film_Id)
            
            CreateTable(
                "dbo.Films",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Imdb_Id = c.Int(nullable := False),
                        .Name = c.String(),
                        .ReleaseYear = c.String(),
                        .FilmLength = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .Index(Function(t) t.Imdb_Id, unique := True, name := "AK_Films")
            
            CreateTable(
                "dbo.Plannings",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Film_Id = c.Int(nullable := False),
                        .PlannedFilm = c.String(),
                        .PlannedDate = c.DateTime(nullable := False),
                        .PlannedPlace = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Films", Function(t) t.Film_Id, cascadeDelete := True) _
                .Index(Function(t) t.Film_Id)
            
            CreateTable(
                "dbo.Statistics",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Film_Id = c.Int(nullable := False),
                        .WatchedTime = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Films", Function(t) t.Film_Id, cascadeDelete := True) _
                .Index(Function(t) t.Film_Id)
            
            CreateTable(
                "dbo.Tags",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Film_Id = c.Int(nullable := False),
                        .Tag = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Films", Function(t) t.Film_Id, cascadeDelete := True) _
                .Index(Function(t) t.Film_Id)
            
            CreateTable(
                "dbo.Watchlists",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Film_Id = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Films", Function(t) t.Film_Id, cascadeDelete := True) _
                .Index(Function(t) t.Film_Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Comments", "Film_Id", "dbo.Films")
            DropForeignKey("dbo.Watchlists", "Film_Id", "dbo.Films")
            DropForeignKey("dbo.Tags", "Film_Id", "dbo.Films")
            DropForeignKey("dbo.Statistics", "Film_Id", "dbo.Films")
            DropForeignKey("dbo.Plannings", "Film_Id", "dbo.Films")
            DropIndex("dbo.Watchlists", New String() { "Film_Id" })
            DropIndex("dbo.Tags", New String() { "Film_Id" })
            DropIndex("dbo.Statistics", New String() { "Film_Id" })
            DropIndex("dbo.Plannings", New String() { "Film_Id" })
            DropIndex("dbo.Films", "AK_Films")
            DropIndex("dbo.Comments", New String() { "Film_Id" })
            DropTable("dbo.Watchlists")
            DropTable("dbo.Tags")
            DropTable("dbo.Statistics")
            DropTable("dbo.Plannings")
            DropTable("dbo.Films")
            DropTable("dbo.Comments")
        End Sub
    End Class
End Namespace

Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Public Partial Class Mig_RemovedStatistics
    Inherits DbMigration

    Public Overrides Sub Up()
        DropForeignKey("dbo.Statistics", "Film_Id", "dbo.Films")
        DropIndex("dbo.Statistics", New String() { "Film_Id" })
        AddColumn("dbo.Films", "Genre", Function(c) c.Int(nullable := False))
        DropTable("dbo.Statistics")
    End Sub
    
    Public Overrides Sub Down()
        CreateTable(
            "dbo.Statistics",
            Function(c) New With
                {
                    .Id = c.Int(nullable := False, identity := True),
                    .Film_Id = c.Int(nullable := False),
                    .WatchedTime = c.DateTime(nullable := False)
                }) _
            .PrimaryKey(Function(t) t.Id)
        
        DropColumn("dbo.Films", "Genre")
        CreateIndex("dbo.Statistics", "Film_Id")
        AddForeignKey("dbo.Statistics", "Film_Id", "dbo.Films", "Id", cascadeDelete := True)
    End Sub
End Class

Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Mig_testremove
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropColumn("dbo.Films", "test")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Films", "test", Function(c) c.String())
        End Sub
    End Class
End Namespace

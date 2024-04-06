Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Mig_test
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Films", "test", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Films", "test")
        End Sub
    End Class
End Namespace

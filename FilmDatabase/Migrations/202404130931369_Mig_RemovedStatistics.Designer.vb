﻿' <auto-generated />
Imports System.CodeDom.Compiler
Imports System.Data.Entity.Migrations
Imports System.Data.Entity.Migrations.Infrastructure
Imports System.Resources

<GeneratedCode("EntityFramework.Migrations", "6.4.4")>
Public NotInheritable Partial Class Mig_RemovedStatistics
    Implements IMigrationMetadata

    Private ReadOnly Resources As New ResourceManager(GetType(Mig_RemovedStatistics))
    
    Private ReadOnly Property IMigrationMetadata_Id() As String Implements IMigrationMetadata.Id
        Get
            Return "202404130931369_Mig_RemovedStatistics"
        End Get
    End Property
    
    Private ReadOnly Property IMigrationMetadata_Source() As String Implements IMigrationMetadata.Source
        Get
            Return Nothing
        End Get
    End Property
    
    Private ReadOnly Property IMigrationMetadata_Target() As String Implements IMigrationMetadata.Target
        Get
            Return Resources.GetString("Target")
        End Get
    End Property
End Class

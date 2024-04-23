Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq
Imports System.Data.Entity.Core.Common.EntitySql
Imports System.Data.Entity.Migrations

Public Class FilmdbInitializer
    Inherits CreateDatabaseIfNotExists(Of FilmdbModel)

    Protected Overrides Sub Seed(context As FilmdbModel)
        ' You can optionally seed initial data here if needed
        MyBase.Seed(context)
    End Sub
End Class

Public Class FilmdbModel
    Inherits DbContext

    ' Your context has been configured to use a 'FilmdbModel' connection string from your application's 
    ' configuration file (App.config or Web.config). By default, this connection string targets the 
    ' 'FilmDatabase.FilmdbModel' database on your LocalDb instance. 
    ' 
    ' If you wish to target a different database and/or database provider, modify the 'FilmdbModel' 
    ' connection string in the application configuration file.
    Public Sub New()
        MyBase.New("name=FilmdbModel")
        Database.SetInitializer(Of FilmdbModel)(Nothing)
    End Sub

    Public Sub UpdateDatabaseStructureFromMigration()
        Dim migrator As New DbMigrator(New FilmMigrationsConfiguration())
        migrator.Update()
    End Sub

    ' Add a DbSet for each entity type that you want to include in your model. For more information 
    ' on configuring and using a Code First model, see http:'go.microsoft.com/fwlink/?LinkId=390109.
    Public Overridable Property Films() As DbSet(Of Films)
    Public Overridable Property Tags() As DbSet(Of Tags)
    Public Overridable Property Comments() As DbSet(Of Comments)
    Public Overridable Property Watchlist() As DbSet(Of Watchlist)
    Public Overridable Property Planning() As DbSet(Of Planning)
    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        ' Configure one-to-many relationship between Films and Tags
        modelBuilder.Entity(Of Tags)().HasRequired(Function(t) t.Film).WithMany(Function(f) f.Tags).HasForeignKey(Function(t) t.Film_Id)

        ' Configure one-to-many relationship between Films and Comments
        modelBuilder.Entity(Of Comments)().HasRequired(Function(c) c.Film).WithMany(Function(f) f.Comments).HasForeignKey(Function(c) c.Film_Id)

        ' Configure one-to-many relationship between Films and Watchlist
        modelBuilder.Entity(Of Watchlist)().HasRequired(Function(w) w.Film).WithMany(Function(f) f.Watchlist).HasForeignKey(Function(w) w.Film_Id)

        ' Configure one-to-many relationship between Films and Planning
        modelBuilder.Entity(Of Planning)().HasRequired(Function(p) p.Film).WithMany(Function(f) f.Planning).HasForeignKey(Function(p) p.Film_Id)

        MyBase.OnModelCreating(modelBuilder)
    End Sub

End Class

Public Class Films
    <Key>
    Public Property Id As Integer
    <Index("AK_Films", IsUnique:=True)>
    Public Property Imdb_Id As Integer
    Public Property Name As String
    Public Property ReleaseYear As String
    Public Property FilmLength As String
    Public Property Genre As Integer

    ' Navigation properties
    Public Overridable Property Tags As ICollection(Of Tags)
    Public Overridable Property Comments As ICollection(Of Comments)
    Public Overridable Property Watchlist As ICollection(Of Watchlist)
    Public Overridable Property Planning As ICollection(Of Planning)
End Class

Public Class Tags
    <Key>
    Public Property Id As Integer
    Public Property Film_Id As Integer
    Public Property Tag As String

    ' Navigation property
    Public Overridable Property Film As Films

End Class

Public Class Comments
    <Key>
    Public Property Id As Integer
    Public Property Film_Id As Integer
    Public Property Comment As String

    ' Navigation property
    Public Overridable Property Film As Films
End Class

Public Class Watchlist
    <Key>
    Public Property Id As Integer
    Public Property Film_Id As Integer

    ' Navigation property
    Public Overridable Property Film As Films

End Class

Public Class Planning
    <Key>
    Public Property Id As Integer
    Public Property Film_Id As Integer
    Public Property PlannedFilm As String
    Public Property PlannedDate As DateTime
    Public Property PlannedPlace As String

    ' Navigation property
    Public Overridable Property Film As Films
End Class

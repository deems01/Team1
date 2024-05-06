Imports FilmDatabase.FilmdbModel
Imports FilmDatabase
Imports WatchStatistics
Imports DllHandler
Imports System.Security.Cryptography
Imports System.ComponentModel
Imports System.Windows.Controls.Primitives
Imports System.Net.Mail
Imports System.IO
Module FilmPageFunctions

    Private clickedMovie As Object

    Public tags As New List(Of String)

    Public comments As New List(Of String)
    Public Sub setTags()
        Dim db As New FilmdbModel()

        ' Get the clicked movie ID
        Dim clickedMovieId = clickedMovie.Id

        ' Retrieve all films from the database
        Dim films = db.Films.ToList()

        ' Find the film ID based on the clicked movie ID
        Dim filmId = films.FirstOrDefault(Function(f) f.Imdb_Id = clickedMovieId)?.Id

        ' Check if filmId is found before proceeding
        If filmId.HasValue Then
            ' Retrieve all tags for the specified film from the database
            Dim filmTags = db.Tags.Where(Function(t) t.Film_Id = filmId.Value).ToList()

            ' Display the tags
            For Each tag In filmTags
                tags.Add(tag.Tag)
            Next
        Else
            Console.WriteLine("Movie not found in the database.")
        End If
    End Sub

    Public Sub setComments()
        Dim db As New FilmdbModel()

        ' Get the clicked movie ID
        Dim clickedMovieId = clickedMovie.Id

        ' Retrieve all films from the database
        Dim films = db.Films.ToList()

        ' Find the film ID based on the clicked movie ID
        Dim filmId = films.FirstOrDefault(Function(f) f.Imdb_Id = clickedMovieId)?.Id

        ' Check if filmId is found before proceeding
        If filmId.HasValue Then
            ' Retrieve all comments for the specified film from the database
            Dim filmComments = db.Comments.Where(Function(c) c.Film_Id = filmId.Value).ToList()

            ' Display the comments
            For Each comment In filmComments
                comments.Add(comment.Comment)
            Next
        Else
            Console.WriteLine("Movie not found in the database.")
        End If
    End Sub


    Public Sub SaveToWatchlist()
        Dim db As New FilmdbModel()
        'bullshit fix for LINQ error LINQ to Entities does not 
        'recognize the method 'System.Object CompareObjectEqual(System.Object, System.Object, Boolean)' 
        'method, and this method cannot be translated into a store expression.'

        Dim clickedMovieId = clickedMovie.Id

        ' Retrieve all films from the database
        Dim films = db.Films.ToList()

        ' Find the film ID based on the movie name in-memory
        Dim filmId = films.FirstOrDefault(Function(f) f.Imdb_Id = clickedMovieId)?.Id

        ' Check if filmId is found before proceeding
        If filmId.HasValue Then
            Dim watchlist As New FilmDatabase.Watchlist()
            watchlist.Film_Id = filmId.Value
            db.Watchlist.Add(watchlist)
            db.SaveChanges()
        Else
            ' Handle the case where the movie is not found in the database
            Console.WriteLine("Movie not found in the database.")
        End If
    End Sub

    Public Sub saveCommentsToDatabase(comment As String)
        Dim db As New FilmdbModel()


        Dim clickedMovieId = clickedMovie.Id

        ' Retrieve all films from the database
        Dim films = db.Films.ToList()

        ' Find the film ID based on the movie name in-memory
        Dim filmId = films.FirstOrDefault(Function(f) f.Imdb_Id = clickedMovieId)?.Id

        ' Check if filmId is found before proceeding
        If filmId.HasValue Then
            Dim comments As New FilmDatabase.Comments()
            comments.Film_Id = filmId.Value
            comments.Comment = comment
            db.Comments.Add(comments)
            db.SaveChanges()
        Else
            ' Handle the case where the movie is not found in the database
            Console.WriteLine("Movie not found in the database.")
        End If
    End Sub

    Public Sub saveTagsToDatabase(tag As String)
        If tag <> "" Then ' Check if the tag is not an empty string
            Dim db As New FilmdbModel()

            Dim clickedMovieId = clickedMovie.Id

            ' Retrieve all films from the database
            Dim films = db.Films.ToList()

            ' Find the film ID based on the movie name in-memory
            Dim filmId = films.FirstOrDefault(Function(f) f.Imdb_Id = clickedMovieId)?.Id

            ' Check if filmId is found before proceeding
            If filmId.HasValue Then
                Dim tags As New FilmDatabase.Tags()
                tags.Film_Id = filmId.Value
                tags.Tag = tag
                db.Tags.Add(tags)
                db.SaveChanges()
            Else
                ' Handle the case where the movie is not found in the database
                Console.WriteLine("Movie not found in the database.")
            End If
        End If
    End Sub

    Public Sub DeleteTagfromDatabase(tag As String)
        Dim db As New FilmdbModel()

        Dim clickedMovieId = clickedMovie.Id

        ' Retrieve all films from the database
        Dim films = db.Films.ToList()

        ' Find the film ID based on the movie name in-memory
        Dim filmId = films.FirstOrDefault(Function(f) f.Imdb_Id = clickedMovieId)?.Id

        ' Check if filmId is found before proceeding
        If filmId.HasValue Then
            Dim tagToDelete = db.Tags.FirstOrDefault(Function(t) t.Film_Id = filmId And t.Tag = tag)
            db.Tags.Remove(tagToDelete)
            db.SaveChanges()
        Else
            ' Handle the case where the movie is not found in the database
            Console.WriteLine("Movie not found in the database.")
        End If
    End Sub

    Public Sub DeleteCommentfromDatabase(comment As String)
        Dim db As New FilmdbModel()

        Dim clickedMovieId = clickedMovie.Id

        ' Retrieve all films from the database
        Dim films = db.Films.ToList()

        ' Find the film ID based on the movie name in-memory
        Dim filmId = films.FirstOrDefault(Function(f) f.Imdb_Id = clickedMovieId)?.Id

        ' Check if filmId is found before proceeding
        If filmId.HasValue Then
            Dim commentToDelete = db.Comments.FirstOrDefault(Function(c) c.Film_Id = filmId And c.Comment = comment)
            db.Comments.Remove(commentToDelete)
            db.SaveChanges()
        Else
            ' Handle the case where the movie is not found in the database
            Console.WriteLine("Movie not found in the database.")
        End If
    End Sub

    Public Sub DeleteFromWatchlist()
        Dim db As New FilmdbModel()

        Dim clickedMovieId = clickedMovie.Id

        ' Retrieve all films from the database
        Dim films = db.Films.ToList()

        ' Find the film ID based on the movie name in-memory
        Dim filmId = films.FirstOrDefault(Function(f) f.Imdb_Id = clickedMovieId)?.Id

        ' Check if filmId is found before proceeding
        If filmId.HasValue Then
            Dim watchlistToDelete = db.Watchlist.FirstOrDefault(Function(w) w.Film_Id = filmId)
            db.Watchlist.Remove(watchlistToDelete)
            db.SaveChanges()
        Else
            ' Handle the case where the movie is not found in the database
            Console.WriteLine("Movie not found in the database.")
        End If
    End Sub

    Public helpTagFlowPanel As New FlowLayoutPanel
    Sub setClickedMovie(movie As Object)
        clickedMovie = movie
    End Sub

    Function getClickedMovie()
        Return clickedMovie
    End Function

    Sub attachPoster(pbPoster As PictureBox)
        pbPoster.Load(clickedMovie.PosterUrl)
        pbPoster.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Sub attachFilmTitle(lblTitle As Label)
        lblTitle.Text = clickedMovie.Title
    End Sub

    Sub attachFilmOverview(textBox As RichTextBox)
        textBox.Text = clickedMovie.Overview
    End Sub

    Async Sub SaveFilmToDatabase()
        Try
            Dim db As New FilmdbModel()
            Dim film As New FilmDatabase.Films()
            Dim stat As New WatchStatistics.Statistics()
            film.Imdb_Id = clickedMovie.Id
            film.Name = clickedMovie.Title
            film.ReleaseYear = clickedMovie.ReleaseDate
            film.FilmLength = Await stat.GetMovieLength(clickedMovie.Id)
            film.Genre = If(clickedMovie.Genres IsNot Nothing, clickedMovie.Genres(0), String.Empty)
            'film.Counter =

            db.Films.Add(film)
            db.SaveChanges()
        Catch ex As Exception
            'MessageBox.Show("ERROR NAMESEARCH")
        End Try

    End Sub

    Public Sub SaveFilmFromCategorytoDatabase(movie As Object)
        Try
            Dim db As New FilmdbModel()
            Dim film As New FilmDatabase.Films()
            Dim stat As New WatchStatistics.Statistics()

            Dim tempId As Integer = GenerateUniqueRandomId(db) ' Generate a unique random ID

            film.Imdb_Id = tempId 'movie.Id
            film.Name = movie.Title
            film.ReleaseYear = movie.ReleaseDate
            'film.FilmLength = stat.GetMovieLength(movie.Id).Result
            'film.Genre = If(movie.Genres IsNot Nothing, movie.Genres(0), String.Empty)
            'film.Counter =

            db.Films.Add(film)
            db.SaveChanges()
        Catch ex As Exception
            'MessageBox.Show("ERROR CATEGORY")
        End Try
    End Sub


    'Because SortClass doesn't have id, we need to generate a unique id for the film
    Private Function GenerateUniqueRandomId(db As FilmdbModel) As Integer
        Dim rnd As New Random()
        Dim tempId As Integer
        Dim isUnique As Boolean = False

        ' Loop until a unique random ID is generated
        Do
            tempId = rnd.Next(100000, 999999)
            ' Check if the generated ID already exists in the database
            If Not db.Films.Any(Function(f) f.Imdb_Id = tempId) Then
                isUnique = True
            End If
        Loop Until isUnique

        Return tempId
    End Function


    ' Function to clear all data from the database for debugging purposes
    Sub ClearAllTableDataFromDatabase()
        Dim db As New FilmdbModel()
        db.Database.ExecuteSqlCommand("TRUNCATE TABLE Films")
        db.Database.ExecuteSqlCommand("TRUNCATE TABLE Planning")
        'db.Database.ExecuteSqlCommand("TRUNCATE TABLE Statistics")
        db.Database.ExecuteSqlCommand("TRUNCATE TABLE Tags")
        db.Database.ExecuteSqlCommand("TRUNCATE TABLE Watchlist")
        db.Database.ExecuteSqlCommand("TRUNCATE TABLE Comments")
    End Sub

    Sub SubmitComment(flowpanel As FlowLayoutPanel, text As String, addPanel As Panel)

        If Not text = " " Then
            comments.Add(text)
            'TODO save comments DB
            saveCommentsToDatabase(text)
            If addPanel IsNot Nothing Then
                Dim child = UiHelpFunctions.getChildForm
                child.Controls.Remove(addPanel)
                addPanel.Dispose()
            End If
        End If

        For Each ctrl As Control In flowpanel.Controls
            ctrl.Dispose()
        Next
        flowpanel.Controls.Clear()

        For Each comment As String In comments
            Dim label As New Label()
            label.Text = comment
            label.AutoSize = False
            label.Size = New Size(flowpanel.Width - 4, 40)
            label.ForeColor = Color.White
            label.BackColor = Color.Gray
            label.Margin = New Padding(2)
            label.Padding = New Padding(2)
            flowpanel.Controls.Add(label)
        Next
    End Sub

    Sub AddComment(flowpanel As FlowLayoutPanel, panel As Panel, childForm As Form)
        ' Create a new panel for the comment
        Dim commentPanel As New Panel()
        commentPanel.BorderStyle = BorderStyle.FixedSingle
        commentPanel.Size = New Size(200, 80)
        commentPanel.BackColor = Color.White

        ' Set the location of the comment panel to be centered on the form
        commentPanel.Location = New Point((childForm.ClientSize.Width - commentPanel.Width) \ 2, (childForm.ClientSize.Height - commentPanel.Height) \ 2)

        ' Input TextBox
        Dim txtInput As New TextBox()
        txtInput.Size = New Size(150, 20)
        txtInput.Location = New Point(10, 10)

        ' Submit Button
        Dim btnSubmit As New Button()
        btnSubmit.Text = "Submit"
        btnSubmit.Size = New Size(75, 23)
        btnSubmit.Location = New Point(10, 40)
        AddHandler btnSubmit.Click, Sub(sender, e) SubmitComment(flowpanel, txtInput.Text, commentPanel)

        ' Add controls to the comment panel
        commentPanel.Controls.Add(txtInput)
        commentPanel.Controls.Add(btnSubmit)

        ' Add the comment panel to the main panel
        childForm.Controls.Add(commentPanel)

        ' Bring the comment panel to the front
        commentPanel.BringToFront()
    End Sub


    Function CreateCommentsPanel() As Panel
        Dim panel As New Panel()
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.Size = New Size(400, 300)

        ' Title Label
        Dim lblTitle As New Label()
        lblTitle.Text = "Comments" & vbCrLf & "Here are some comments:" ' Multiline text
        lblTitle.Font = New Font(lblTitle.Font, FontStyle.Bold)
        lblTitle.Size = New Size(200, 30) ' Increased size for multiline text
        lblTitle.Location = New Point(20, 20)
        lblTitle.AutoSize = False ' Set AutoSize to False to enable multiline text
        lblTitle.TextAlign = ContentAlignment.TopLeft ' Align text to top left

        ' FlowLayoutPanel
        Dim flowLayoutPanel As New FlowLayoutPanel()
        flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight
        flowLayoutPanel.Size = New Size(360, 140)
        flowLayoutPanel.BackColor = Color.Black
        flowLayoutPanel.AutoScroll = True
        flowLayoutPanel.Location = New Point(20, 80)
        SubmitComment(flowLayoutPanel, " ", Nothing)
        ' Close Button
        Dim btnClose As New Button()
        btnClose.Text = "Close"
        btnClose.Size = New Size(75, 23)
        btnClose.Location = New Point(150, flowLayoutPanel.Bottom + 20)
        AddHandler btnClose.Click, Sub(sender, e) panel.Parent.Controls.Remove(panel)

        ' Add Button
        Dim addButton As New Button()
        addButton.Text = "Add"
        addButton.Size = New Size(75, 23)
        addButton.Location = New Point(btnClose.Right + 10, btnClose.Top)
        AddHandler addButton.Click, Sub(sender, e) AddComment(flowLayoutPanel, panel, UiHelpFunctions.getChildForm)

        ' Add controls to the panel
        panel.Controls.Add(lblTitle)
        panel.Controls.Add(flowLayoutPanel)
        panel.Controls.Add(btnClose)
        panel.Controls.Add(addButton)
        Return panel

    End Function

    Sub SubmitTag(tag As String, tagPanel As Panel, childForm As Form)

        If ValidateTagInput(tag) Then
            tags.Add(tag)
            'TODO save tags DB
            saveTagsToDatabase(tag)
            AddTagsDynamically(helpTagFlowPanel)
            childForm.Controls.Remove(tagPanel)
            tagPanel.Dispose()
        Else
            MessageBox.Show($"Tag can't be longer than 10 letters")
        End If

    End Sub

    Sub DeleteTag(panel As Panel, tag As String, form As Form)
        tags.Remove(tag)
        DeleteTagfromDatabase(tag)
        form.Controls.Remove(panel)
        panel.Dispose()
        AddTagsDynamically(helpTagFlowPanel)
    End Sub

    Function CreateTagForm() As Panel
        Dim panel As New Panel()
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.Size = New Size(300, 150)

        ' Title Label
        Dim lblTitle As New Label()
        lblTitle.Text = "Feedback Form"
        lblTitle.Font = New Font(lblTitle.Font, FontStyle.Bold)
        lblTitle.Size = New Size(150, 20)
        lblTitle.Location = New Point(50, 10)

        ' Input TextBox
        Dim txtInput As New TextBox()
        txtInput.Size = New Size(200, 20)
        txtInput.Location = New Point(25, 40)

        ' Submit Button
        Dim btnSubmit As New Button()
        btnSubmit.Text = "Submit"
        btnSubmit.Size = New Size(75, 23)
        btnSubmit.Location = New Point(85, 70)
        If tags.Count >= 10 Then
            btnSubmit.Enabled = False
        End If
        AddHandler btnSubmit.Click, Sub(sender, e) SubmitTag(txtInput.Text, panel, UiHelpFunctions.getChildForm())

        ' ComboBox
        Dim cmbValues As New ComboBox()
        cmbValues.DropDownStyle = ComboBoxStyle.DropDownList
        cmbValues.Size = New Size(150, 20)
        cmbValues.Location = New Point(50, 100)

        ' Delete Button
        Dim btnDelete As New Button()
        btnDelete.Text = "Delete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.Location = New Point(50, 120)
        btnDelete.Enabled = False ' Initially disabled
        AddHandler btnDelete.Click, Sub(sender, e) DeleteTag(panel, cmbValues.SelectedItem.ToString(), UiHelpFunctions.getChildForm())

        ' Add items to ComboBox
        cmbValues.Items.AddRange(tags.ToArray())

        ' Add controls to the panel
        panel.Controls.Add(lblTitle)
        panel.Controls.Add(txtInput)
        panel.Controls.Add(btnSubmit)
        panel.Controls.Add(cmbValues)
        panel.Controls.Add(btnDelete)

        ' Event handler for checkbox
        AddHandler cmbValues.SelectedIndexChanged, Sub(sender, e)
                                                       If cmbValues.SelectedIndex <> -1 Then
                                                           btnDelete.Enabled = True
                                                       Else
                                                           btnDelete.Enabled = False
                                                       End If
                                                   End Sub
        Return panel
    End Function


    Function ValidateTagInput(input As String)

        If input.Length > 10 Then
            Return False
        Else
            Return True
        End If

    End Function

    Sub AddTagsDynamically(tagFlowPanel)

        helpTagFlowPanel = tagFlowPanel

        For Each ctrl As Control In tagFlowPanel.Controls
            ctrl.Dispose()
        Next
        tagFlowPanel.Controls.Clear()

        For Each tag In tags

            Dim label As New Label

            label.Text = tag
            label.BackColor = Color.LightBlue
            label.Margin = New Padding(4)
            tagFlowPanel.Controls.Add(label)
            label.Width = tagFlowPanel.width / 5.3
            label.Font = New Font("Calibri", 12, FontStyle.Bold)

        Next

    End Sub

End Module

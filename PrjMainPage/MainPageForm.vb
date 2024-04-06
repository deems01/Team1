Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports FilmDatabase
Imports System.Data.Entity.Migrations

Public Class MainPageForm
    'Andmebaasi access
    Dim db As New FilmdbModel()

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2
    Private currentChildForm As Form

    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True ' Enable double buffering
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub MainPageForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If sender Is Nothing Then
            Throw New ArgumentNullException(NameOf(sender))
        End If
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        btnExit.BackColor = Color.Red
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = Color.Transparent
    End Sub

    Private Sub MainPageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.UpdateDatabaseStructureFromMigration()

        UiHelpFunctions.setMainPanel(pnlPage)

        UiHelpFunctions.MakeRoundedEdgesPanel(pnlPage, 30)
        UiHelpFunctions.MakeRoundedEdgesPanel(pnlMainMenu, 30)
        UiHelpFunctions.MakeRoundedEdgesForm(Me, 20)
        UiHelpFunctions.OpenChildForm(New FormSearchBar)

        ' Remove button default style
        Dim buttons As IconButton() = {btnMinimize, btnMaximize, btnExit, btnCategory, btnNewPlan,
            btnPlanned, btnStats, btnWatchlist, btnHomePage}
        For Each button As IconButton In buttons
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderSize = 0
        Next
    End Sub

    'TODO REMOVE LATER
    Private Sub DatabaseExampleUseEF()
        Dim uusfilm As New Films()
        uusfilm.Name = "8"
        uusfilm.Imdb_Id = Guid.NewGuid().ToString()
        uusfilm.Tags = New List(Of Tags) From {New Tags() With {.Tag = "v2ga hea 4"}, New Tags() With {.Tag = "another tag 4"}}
        db.Films.Add(uusfilm)
        db.SaveChanges()



        Dim esimeneleitudfilm = db.Films.Where(Function(a) a.Name = "8").FirstOrDefault()
        esimeneleitudfilm.Name = "muudetud 8"
        esimeneleitudfilm.Tags(0).Tag = "v2ga hea 88"
        db.SaveChanges()



        Dim kustutatavleitudfilm = db.Films.Where(Function(a) a.Name = "muudetud 7").FirstOrDefault()
        db.Films.Remove(kustutatavleitudfilm)
        db.SaveChanges()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'DatabaseExampleUseEF()
        Application.Exit()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnHomePage_Click(sender As Object, e As EventArgs) Handles btnHomePage.Click
        UiHelpFunctions.OpenChildForm(New FormSearchBar)
    End Sub

    Private Sub MainPageForm_ResizeBegin(sender As Object, e As EventArgs) Handles MyBase.ResizeBegin
        SuspendLayout() ' Suspend layout updates during resizing
    End Sub

    Private Sub MainPageForm_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        ResumeLayout(True) ' Resume layout updates and perform a layout immediately
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        UiHelpFunctions.OpenChildForm(New FormCategories)
    End Sub

    Private Sub btnNewPlan_Click(sender As Object, e As EventArgs) Handles btnNewPlan.Click
        UiHelpFunctions.OpenChildForm(New FormNightPlanner)
    End Sub
End Class

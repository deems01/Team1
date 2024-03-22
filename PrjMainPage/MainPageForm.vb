
Imports System.Runtime.InteropServices
Imports System.Xml

Public Class MainPageForm

    ' Constants for mouse messages
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2

    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        'Form'
        'Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    ' Import ReleaseCapture and SendMessage functions
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
        ' Check if the left mouse button is pressed
        If e.Button = MouseButtons.Left Then
            ' Call ReleaseCapture function to release mouse capture from the form
            ReleaseCapture()
            ' Send the WM_NCLBUTTONDOWN message to the form with HT_CAPTION parameter
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub btnCategory_MouseEnter(sender As Object, e As EventArgs)
        ' Change the background color when the mouse enters the panel
        btnCategory.BackColor = Color.Gold
    End Sub

    Private Sub btnCategory_MouseLeave(sender As Object, e As EventArgs)
        ' Restore the original background color when the mouse leaves the panel
        btnCategory.BackColor = Color.White
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        ' Change the background color when the mouse enters the panel
        btnExit.BackColor = Color.Red
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        ' Restore the original background color when the mouse leaves the panel
        btnExit.BackColor = Color.Transparent
    End Sub

    Private Sub MainPageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.FlatAppearance.BorderSize = 0

        btnMaximize.FlatStyle = FlatStyle.Flat
        btnMaximize.FlatAppearance.BorderSize = 0

        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.FlatAppearance.BorderSize = 0

    End Sub

    'Remove transparent border in maximized state'


    'Close-Maximize-Minimize'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
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
End Class

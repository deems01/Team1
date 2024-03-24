Imports System.Drawing.Drawing2D

Module UiHelpFunctions
    Private currentChildForm As Form
    Private mainPanel As Panel

    Public Function getChildForm()
        Return currentChildForm
    End Function

    Public Sub setMainPanel(panel As Panel)
        mainPanel = panel
    End Sub
    Public Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        mainPanel.Controls.Add(childForm)
        mainPanel.Tag = childForm
        childForm.BringToFront()
        If Not currentChildForm.IsDisposed() Then
            currentChildForm.Show()
        End If
    End Sub
    Public Sub MakeRoundedEdgesPanel(panel As Panel, cornerRadius As Integer)
        ' Create a GraphicsPath
        Dim path As New GraphicsPath()

        ' Create the shape (rounded rectangle)
        path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90) ' Top-left corner
        path.AddArc(panel.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90) ' Top-right corner
        path.AddArc(panel.Width - cornerRadius * 2, panel.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90) ' Bottom-right corner
        path.AddArc(0, panel.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90) ' Bottom-left corner
        path.CloseFigure()

        ' Create a Region
        Dim region As New Region(path)

        ' Set the Panel's Region
        panel.Region = region

        ' Subscribe to the Resize event to update the region when the panel is resized
        AddHandler panel.Resize, AddressOf Panel_Resize
    End Sub

    Private Sub Panel_Resize(sender As Object, e As EventArgs)
        ' When the panel is resized, update the rounded edges
        Dim panel As Panel = DirectCast(sender, Panel)
        MakeRoundedEdgesPanel(panel, 30)
    End Sub

    Public Sub MakeRoundedEdgesForm(form As Form, cornerRadius As Integer)
        ' Create a GraphicsPath
        Dim path As New GraphicsPath()

        ' Create the shape (rounded rectangle) for the form's client area
        Dim rect As New Rectangle(0, 0, form.Width, form.Height)
        path.AddArc(rect.Left, rect.Top, cornerRadius * 2, cornerRadius * 2, 180, 90) ' Top-left corner
        path.AddArc(rect.Right - cornerRadius * 2, rect.Top, cornerRadius * 2, cornerRadius * 2, 270, 90) ' Top-right corner
        path.AddArc(rect.Right - cornerRadius * 2, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90) ' Bottom-right corner
        path.AddArc(rect.Left, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90) ' Bottom-left corner
        path.CloseFigure()

        ' Create a Region
        Dim region As New Region(path)

        ' Set the form's Region
        form.Region = region

        ' Subscribe to the Resize and ResizeEnd events to update the rounded edges when the form is resized
        AddHandler form.Resize, AddressOf Form_Resize
        AddHandler form.ResizeEnd, AddressOf Form_ResizeEnd
    End Sub

    Private Sub Form_Resize(sender As Object, e As EventArgs)
        ' When the form is resized, temporarily remove the rounded edges to allow proper resizing
        Dim form As Form = DirectCast(sender, Form)
        form.Region = Nothing
    End Sub

    Private Sub Form_ResizeEnd(sender As Object, e As EventArgs)
        ' When the form stops resizing, reapply the rounded edges
        Dim form As Form = DirectCast(sender, Form)
        MakeRoundedEdgesForm(form, 20)
    End Sub
End Module

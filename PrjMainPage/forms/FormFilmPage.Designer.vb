<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFilmPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAddToWatchlist = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'btnAddToWatchlist
        '
        Me.btnAddToWatchlist.Location = New System.Drawing.Point(341, 215)
        Me.btnAddToWatchlist.Name = "btnAddToWatchlist"
        Me.btnAddToWatchlist.Size = New System.Drawing.Size(139, 45)
        Me.btnAddToWatchlist.TabIndex = 0
        Me.btnAddToWatchlist.Text = "Watchlist"
        Me.btnAddToWatchlist.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(650, 135)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'FormFilmPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1538, 526)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btnAddToWatchlist)
        Me.Name = "FormFilmPage"
        Me.Text = "FormFilmPage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddToWatchlist As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class

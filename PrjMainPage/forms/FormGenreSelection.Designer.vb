<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGenreSelection
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
        Me.cmbGenreSelection = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmbGenreSelection
        '
        Me.cmbGenreSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbGenreSelection.FormattingEnabled = True
        Me.cmbGenreSelection.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "History", "Horror", "Music", "Mystery", "Romance", "Science Fiction", "Thriller", "TV Movie", "War", "Western"})
        Me.cmbGenreSelection.Location = New System.Drawing.Point(0, 0)
        Me.cmbGenreSelection.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbGenreSelection.Name = "cmbGenreSelection"
        Me.cmbGenreSelection.Size = New System.Drawing.Size(197, 24)
        Me.cmbGenreSelection.TabIndex = 0
        '
        'FormGenreSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(197, 23)
        Me.Controls.Add(Me.cmbGenreSelection)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormGenreSelection"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbGenreSelection As ComboBox
End Class

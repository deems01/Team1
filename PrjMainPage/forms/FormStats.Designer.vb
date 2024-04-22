<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStats
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.crtWeekdays = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblTimeMOviesWatched = New System.Windows.Forms.Label()
        Me.lblMostPopularGenre = New System.Windows.Forms.Label()
        Me.lblMostPopularMovie = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pbMostPopularMovie = New System.Windows.Forms.PictureBox()
        CType(Me.crtWeekdays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbMostPopularMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crtWeekdays
        '
        Me.crtWeekdays.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.crtWeekdays.ChartAreas.Add(ChartArea1)
        Me.crtWeekdays.Location = New System.Drawing.Point(11, 83)
        Me.crtWeekdays.Margin = New System.Windows.Forms.Padding(2)
        Me.crtWeekdays.Name = "crtWeekdays"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.crtWeekdays.Series.Add(Series1)
        Me.crtWeekdays.Size = New System.Drawing.Size(645, 248)
        Me.crtWeekdays.TabIndex = 0
        Me.crtWeekdays.Text = "Chart1"
        '
        'lblTimeMOviesWatched
        '
        Me.lblTimeMOviesWatched.AutoSize = True
        Me.lblTimeMOviesWatched.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblTimeMOviesWatched.Location = New System.Drawing.Point(6, 16)
        Me.lblTimeMOviesWatched.Name = "lblTimeMOviesWatched"
        Me.lblTimeMOviesWatched.Size = New System.Drawing.Size(115, 20)
        Me.lblTimeMOviesWatched.TabIndex = 1
        Me.lblTimeMOviesWatched.Text = "Time watched: "
        '
        'lblMostPopularGenre
        '
        Me.lblMostPopularGenre.AutoSize = True
        Me.lblMostPopularGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblMostPopularGenre.Location = New System.Drawing.Point(6, 16)
        Me.lblMostPopularGenre.Name = "lblMostPopularGenre"
        Me.lblMostPopularGenre.Size = New System.Drawing.Size(154, 20)
        Me.lblMostPopularGenre.TabIndex = 2
        Me.lblMostPopularGenre.Text = "Most popular genre: "
        '
        'lblMostPopularMovie
        '
        Me.lblMostPopularMovie.AutoSize = True
        Me.lblMostPopularMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblMostPopularMovie.Location = New System.Drawing.Point(6, 16)
        Me.lblMostPopularMovie.Name = "lblMostPopularMovie"
        Me.lblMostPopularMovie.Size = New System.Drawing.Size(154, 20)
        Me.lblMostPopularMovie.TabIndex = 3
        Me.lblMostPopularMovie.Text = "Most popular movie: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGenre)
        Me.GroupBox1.Controls.Add(Me.lblMostPopularGenre)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 63)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.BackColor = System.Drawing.Color.RosyBrown
        Me.lblGenre.Location = New System.Drawing.Point(51, 44)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(39, 13)
        Me.lblGenre.TabIndex = 3
        Me.lblGenre.Text = "Label1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.lblTime)
        Me.GroupBox2.Controls.Add(Me.lblTimeMOviesWatched)
        Me.GroupBox2.Location = New System.Drawing.Point(322, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 63)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.RosyBrown
        Me.lblTime.Location = New System.Drawing.Point(67, 44)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 13)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Label2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.pbMostPopularMovie)
        Me.GroupBox3.Controls.Add(Me.lblMostPopularMovie)
        Me.GroupBox3.Location = New System.Drawing.Point(678, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 315)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'pbMostPopularMovie
        '
        Me.pbMostPopularMovie.Image = Global.PrjMainPage.My.Resources.Resources.wallpaperflare_com_wallpaper
        Me.pbMostPopularMovie.Location = New System.Drawing.Point(10, 59)
        Me.pbMostPopularMovie.Name = "pbMostPopularMovie"
        Me.pbMostPopularMovie.Size = New System.Drawing.Size(196, 241)
        Me.pbMostPopularMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMostPopularMovie.TabIndex = 4
        Me.pbMostPopularMovie.TabStop = False
        '
        'FormStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1022, 342)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.crtWeekdays)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormStats"
        Me.Text = "FormStats"
        CType(Me.crtWeekdays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pbMostPopularMovie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crtWeekdays As DataVisualization.Charting.Chart
    Friend WithEvents lblTimeMOviesWatched As Label
    Friend WithEvents lblMostPopularGenre As Label
    Friend WithEvents lblMostPopularMovie As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents pbMostPopularMovie As PictureBox
End Class

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
        Me.pbPoster = New System.Windows.Forms.PictureBox()
        Me.pnlFilmName = New System.Windows.Forms.Panel()
        Me.lblFilmName = New System.Windows.Forms.Label()
        Me.btnComments = New System.Windows.Forms.Button()
        Me.flowPanelTags = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlDescription = New System.Windows.Forms.Panel()
        Me.rTxtDescription = New System.Windows.Forms.RichTextBox()
        Me.pnlPoster = New System.Windows.Forms.Panel()
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilmName.SuspendLayout()
        Me.pnlDescription.SuspendLayout()
        Me.pnlPoster.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddToWatchlist
        '
        Me.btnAddToWatchlist.Location = New System.Drawing.Point(658, 8)
        Me.btnAddToWatchlist.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddToWatchlist.Name = "btnAddToWatchlist"
        Me.btnAddToWatchlist.Size = New System.Drawing.Size(103, 22)
        Me.btnAddToWatchlist.TabIndex = 0
        Me.btnAddToWatchlist.Text = "Watchlist"
        Me.btnAddToWatchlist.UseVisualStyleBackColor = True
        '
        'pbPoster
        '
        Me.pbPoster.Location = New System.Drawing.Point(2, 0)
        Me.pbPoster.Margin = New System.Windows.Forms.Padding(2)
        Me.pbPoster.Name = "pbPoster"
        Me.pbPoster.Size = New System.Drawing.Size(235, 309)
        Me.pbPoster.TabIndex = 2
        Me.pbPoster.TabStop = False
        '
        'pnlFilmName
        '
        Me.pnlFilmName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlFilmName.Controls.Add(Me.lblFilmName)
        Me.pnlFilmName.Location = New System.Drawing.Point(8, 14)
        Me.pnlFilmName.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlFilmName.Name = "pnlFilmName"
        Me.pnlFilmName.Size = New System.Drawing.Size(645, 41)
        Me.pnlFilmName.TabIndex = 3
        '
        'lblFilmName
        '
        Me.lblFilmName.AutoSize = True
        Me.lblFilmName.Location = New System.Drawing.Point(13, 13)
        Me.lblFilmName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFilmName.Name = "lblFilmName"
        Me.lblFilmName.Size = New System.Drawing.Size(0, 13)
        Me.lblFilmName.TabIndex = 0
        '
        'btnComments
        '
        Me.btnComments.Location = New System.Drawing.Point(658, 34)
        Me.btnComments.Margin = New System.Windows.Forms.Padding(2)
        Me.btnComments.Name = "btnComments"
        Me.btnComments.Size = New System.Drawing.Size(103, 21)
        Me.btnComments.TabIndex = 4
        Me.btnComments.Text = "Comments"
        Me.btnComments.UseVisualStyleBackColor = True
        '
        'flowPanelTags
        '
        Me.flowPanelTags.BackColor = System.Drawing.Color.BurlyWood
        Me.flowPanelTags.Location = New System.Drawing.Point(8, 66)
        Me.flowPanelTags.Margin = New System.Windows.Forms.Padding(2)
        Me.flowPanelTags.Name = "flowPanelTags"
        Me.flowPanelTags.Size = New System.Drawing.Size(753, 65)
        Me.flowPanelTags.TabIndex = 5
        '
        'pnlDescription
        '
        Me.pnlDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlDescription.Controls.Add(Me.rTxtDescription)
        Me.pnlDescription.Location = New System.Drawing.Point(8, 142)
        Me.pnlDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlDescription.Name = "pnlDescription"
        Me.pnlDescription.Size = New System.Drawing.Size(753, 181)
        Me.pnlDescription.TabIndex = 6
        '
        'rTxtDescription
        '
        Me.rTxtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rTxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rTxtDescription.Enabled = False
        Me.rTxtDescription.Font = New System.Drawing.Font("Rockwell", 14.0!)
        Me.rTxtDescription.Location = New System.Drawing.Point(16, 9)
        Me.rTxtDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.rTxtDescription.Name = "rTxtDescription"
        Me.rTxtDescription.Size = New System.Drawing.Size(720, 153)
        Me.rTxtDescription.TabIndex = 0
        Me.rTxtDescription.Text = ""
        '
        'pnlPoster
        '
        Me.pnlPoster.Controls.Add(Me.pbPoster)
        Me.pnlPoster.Location = New System.Drawing.Point(773, 14)
        Me.pnlPoster.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlPoster.Name = "pnlPoster"
        Me.pnlPoster.Size = New System.Drawing.Size(235, 309)
        Me.pnlPoster.TabIndex = 7
        '
        'FormFilmPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 342)
        Me.Controls.Add(Me.pnlPoster)
        Me.Controls.Add(Me.pnlDescription)
        Me.Controls.Add(Me.flowPanelTags)
        Me.Controls.Add(Me.btnComments)
        Me.Controls.Add(Me.pnlFilmName)
        Me.Controls.Add(Me.btnAddToWatchlist)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormFilmPage"
        Me.Text = "FormFilmPage"
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilmName.ResumeLayout(False)
        Me.pnlFilmName.PerformLayout()
        Me.pnlDescription.ResumeLayout(False)
        Me.pnlPoster.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddToWatchlist As Button
    Friend WithEvents pbPoster As PictureBox
    Friend WithEvents pnlFilmName As Panel
    Friend WithEvents lblFilmName As Label
    Friend WithEvents btnComments As Button
    Friend WithEvents flowPanelTags As FlowLayoutPanel
    Friend WithEvents pnlDescription As Panel
    Friend WithEvents pnlPoster As Panel
    Friend WithEvents rTxtDescription As RichTextBox
End Class

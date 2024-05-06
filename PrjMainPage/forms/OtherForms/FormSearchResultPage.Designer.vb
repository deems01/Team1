<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSearchResultPage
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
        Me.pnlSearchResult = New System.Windows.Forms.Panel()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.flowPanelResult = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblComparison = New System.Windows.Forms.Label()
        Me.btnComparison = New System.Windows.Forms.Button()
        Me.pnlSearchResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSearchResult
        '
        Me.pnlSearchResult.BackColor = System.Drawing.SystemColors.MenuBar
        Me.pnlSearchResult.Controls.Add(Me.lbl)
        Me.pnlSearchResult.Controls.Add(Me.lblSearch)
        Me.pnlSearchResult.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.pnlSearchResult.Location = New System.Drawing.Point(12, 12)
        Me.pnlSearchResult.Name = "pnlSearchResult"
        Me.pnlSearchResult.Size = New System.Drawing.Size(268, 27)
        Me.pnlSearchResult.TabIndex = 0
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lbl.Location = New System.Drawing.Point(77, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(0, 24)
        Me.lbl.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblSearch.Location = New System.Drawing.Point(3, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(80, 24)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search: "
        '
        'flowPanelResult
        '
        Me.flowPanelResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowPanelResult.AutoScroll = True
        Me.flowPanelResult.Location = New System.Drawing.Point(12, 58)
        Me.flowPanelResult.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.flowPanelResult.Name = "flowPanelResult"
        Me.flowPanelResult.Size = New System.Drawing.Size(988, 264)
        Me.flowPanelResult.TabIndex = 1
        '
        'lblComparison
        '
        Me.lblComparison.AutoSize = True
        Me.lblComparison.BackColor = System.Drawing.Color.Silver
        Me.lblComparison.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblComparison.Location = New System.Drawing.Point(318, 19)
        Me.lblComparison.Name = "lblComparison"
        Me.lblComparison.Size = New System.Drawing.Size(344, 20)
        Me.lblComparison.TabIndex = 3
        Me.lblComparison.Text = "Right Click on a movie to add to the comparison"
        '
        'btnComparison
        '
        Me.btnComparison.Location = New System.Drawing.Point(701, 15)
        Me.btnComparison.Name = "btnComparison"
        Me.btnComparison.Size = New System.Drawing.Size(155, 30)
        Me.btnComparison.TabIndex = 4
        Me.btnComparison.Text = "See Comparison"
        Me.btnComparison.UseVisualStyleBackColor = True
        '
        'FormSearchResultPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1022, 342)
        Me.Controls.Add(Me.btnComparison)
        Me.Controls.Add(Me.lblComparison)
        Me.Controls.Add(Me.flowPanelResult)
        Me.Controls.Add(Me.pnlSearchResult)
        Me.Name = "FormSearchResultPage"
        Me.Text = "Form1"
        Me.pnlSearchResult.ResumeLayout(False)
        Me.pnlSearchResult.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlSearchResult As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents lbl As Label
    Friend WithEvents flowPanelResult As FlowLayoutPanel
    Friend WithEvents lblComparison As Label
    Friend WithEvents btnComparison As Button
End Class

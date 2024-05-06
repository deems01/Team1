<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCategoryResult
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
        Me.pnlOptionalResult = New System.Windows.Forms.Panel()
        Me.lblCateSearch = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.flowPanelResult = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnComparison = New System.Windows.Forms.Button()
        Me.lblComparison = New System.Windows.Forms.Label()
        Me.pnlSearchResult.SuspendLayout()
        Me.pnlOptionalResult.SuspendLayout()
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
        Me.pnlSearchResult.Size = New System.Drawing.Size(215, 27)
        Me.pnlSearchResult.TabIndex = 1
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lbl.Location = New System.Drawing.Point(90, 0)
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
        Me.lblSearch.Size = New System.Drawing.Size(95, 24)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Category: "
        '
        'pnlOptionalResult
        '
        Me.pnlOptionalResult.BackColor = System.Drawing.SystemColors.MenuBar
        Me.pnlOptionalResult.Controls.Add(Me.lblCateSearch)
        Me.pnlOptionalResult.Controls.Add(Me.Label1)
        Me.pnlOptionalResult.Controls.Add(Me.Label2)
        Me.pnlOptionalResult.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.pnlOptionalResult.Location = New System.Drawing.Point(233, 12)
        Me.pnlOptionalResult.Name = "pnlOptionalResult"
        Me.pnlOptionalResult.Size = New System.Drawing.Size(215, 27)
        Me.pnlOptionalResult.TabIndex = 2
        '
        'lblCateSearch
        '
        Me.lblCateSearch.AutoSize = True
        Me.lblCateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblCateSearch.Location = New System.Drawing.Point(77, 0)
        Me.lblCateSearch.Name = "lblCateSearch"
        Me.lblCateSearch.Size = New System.Drawing.Size(0, 24)
        Me.lblCateSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(77, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 24)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search: "
        '
        'flowPanelResult
        '
        Me.flowPanelResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowPanelResult.AutoScroll = True
        Me.flowPanelResult.Location = New System.Drawing.Point(12, 54)
        Me.flowPanelResult.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.flowPanelResult.Name = "flowPanelResult"
        Me.flowPanelResult.Size = New System.Drawing.Size(990, 263)
        Me.flowPanelResult.TabIndex = 3
        '
        'btnComparison
        '
        Me.btnComparison.Location = New System.Drawing.Point(858, 12)
        Me.btnComparison.Name = "btnComparison"
        Me.btnComparison.Size = New System.Drawing.Size(155, 30)
        Me.btnComparison.TabIndex = 6
        Me.btnComparison.Text = "See Comparison"
        Me.btnComparison.UseVisualStyleBackColor = True
        '
        'lblComparison
        '
        Me.lblComparison.AutoSize = True
        Me.lblComparison.BackColor = System.Drawing.Color.Silver
        Me.lblComparison.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblComparison.Location = New System.Drawing.Point(475, 16)
        Me.lblComparison.Name = "lblComparison"
        Me.lblComparison.Size = New System.Drawing.Size(344, 20)
        Me.lblComparison.TabIndex = 5
        Me.lblComparison.Text = "Right Click on a movie to add to the comparison"
        '
        'FormCategoryResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 342)
        Me.Controls.Add(Me.btnComparison)
        Me.Controls.Add(Me.lblComparison)
        Me.Controls.Add(Me.flowPanelResult)
        Me.Controls.Add(Me.pnlOptionalResult)
        Me.Controls.Add(Me.pnlSearchResult)
        Me.Name = "FormCategoryResult"
        Me.Text = "FormCategoryResult"
        Me.pnlSearchResult.ResumeLayout(False)
        Me.pnlSearchResult.PerformLayout()
        Me.pnlOptionalResult.ResumeLayout(False)
        Me.pnlOptionalResult.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlSearchResult As Panel
    Friend WithEvents lbl As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents pnlOptionalResult As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCateSearch As Label
    Friend WithEvents flowPanelResult As FlowLayoutPanel
    Friend WithEvents btnComparison As Button
    Friend WithEvents lblComparison As Label
End Class

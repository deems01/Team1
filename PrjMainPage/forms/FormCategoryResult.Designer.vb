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
        Me.pnlSearchResult.Location = New System.Drawing.Point(16, 15)
        Me.pnlSearchResult.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlSearchResult.Name = "pnlSearchResult"
        Me.pnlSearchResult.Size = New System.Drawing.Size(287, 33)
        Me.pnlSearchResult.TabIndex = 1
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lbl.Location = New System.Drawing.Point(120, 0)
        Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(0, 29)
        Me.lbl.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblSearch.Location = New System.Drawing.Point(4, 0)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(122, 29)
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
        Me.pnlOptionalResult.Location = New System.Drawing.Point(311, 15)
        Me.pnlOptionalResult.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlOptionalResult.Name = "pnlOptionalResult"
        Me.pnlOptionalResult.Size = New System.Drawing.Size(287, 33)
        Me.pnlOptionalResult.TabIndex = 2
        '
        'lblCateSearch
        '
        Me.lblCateSearch.AutoSize = True
        Me.lblCateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblCateSearch.Location = New System.Drawing.Point(103, 0)
        Me.lblCateSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCateSearch.Name = "lblCateSearch"
        Me.lblCateSearch.Size = New System.Drawing.Size(0, 29)
        Me.lblCateSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(103, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 29)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(4, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search: "
        '
        'flowPanelResult
        '
        Me.flowPanelResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowPanelResult.AutoScroll = True
        Me.flowPanelResult.Location = New System.Drawing.Point(16, 66)
        Me.flowPanelResult.Name = "flowPanelResult"
        Me.flowPanelResult.Size = New System.Drawing.Size(1320, 324)
        Me.flowPanelResult.TabIndex = 3
        '
        'FormCategoryResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 421)
        Me.Controls.Add(Me.flowPanelResult)
        Me.Controls.Add(Me.pnlOptionalResult)
        Me.Controls.Add(Me.pnlSearchResult)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormCategoryResult"
        Me.Text = "FormCategoryResult"
        Me.pnlSearchResult.ResumeLayout(False)
        Me.pnlSearchResult.PerformLayout()
        Me.pnlOptionalResult.ResumeLayout(False)
        Me.pnlOptionalResult.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSearchResult As Panel
    Friend WithEvents lbl As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents pnlOptionalResult As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCateSearch As Label
    Friend WithEvents flowPanelResult As FlowLayoutPanel
End Class

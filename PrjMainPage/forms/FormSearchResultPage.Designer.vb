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
        Me.pnlSearchResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSearchResult
        '
        Me.pnlSearchResult.BackColor = System.Drawing.SystemColors.MenuBar
        Me.pnlSearchResult.Controls.Add(Me.lbl)
        Me.pnlSearchResult.Controls.Add(Me.lblSearch)
        Me.pnlSearchResult.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.pnlSearchResult.Location = New System.Drawing.Point(18, 18)
        Me.pnlSearchResult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlSearchResult.Name = "pnlSearchResult"
        Me.pnlSearchResult.Size = New System.Drawing.Size(322, 42)
        Me.pnlSearchResult.TabIndex = 0
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lbl.Location = New System.Drawing.Point(116, 0)
        Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(0, 32)
        Me.lbl.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblSearch.Location = New System.Drawing.Point(4, 0)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(119, 32)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search: "
        '
        'flowPanelResult
        '
        Me.flowPanelResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowPanelResult.AutoScroll = True
        Me.flowPanelResult.Location = New System.Drawing.Point(18, 89)
        Me.flowPanelResult.Name = "flowPanelResult"
        Me.flowPanelResult.Size = New System.Drawing.Size(1482, 406)
        Me.flowPanelResult.TabIndex = 1
        '
        'FormSearchResultPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1533, 526)
        Me.Controls.Add(Me.flowPanelResult)
        Me.Controls.Add(Me.pnlSearchResult)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormSearchResultPage"
        Me.Text = "Form1"
        Me.pnlSearchResult.ResumeLayout(False)
        Me.pnlSearchResult.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSearchResult As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents lbl As Label
    Friend WithEvents flowPanelResult As FlowLayoutPanel
End Class

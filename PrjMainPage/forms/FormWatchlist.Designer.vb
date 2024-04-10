<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWatchlist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblWatchlist = New System.Windows.Forms.Label()
        Me.flowPnlWatchlist = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlWatchlistLabel = New System.Windows.Forms.Panel()
        Me.pnlWatchlistLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWatchlist
        '
        Me.lblWatchlist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWatchlist.AutoSize = True
        Me.lblWatchlist.Font = New System.Drawing.Font("Malgun Gothic", 29.0!, System.Drawing.FontStyle.Bold)
        Me.lblWatchlist.Location = New System.Drawing.Point(-1, 0)
        Me.lblWatchlist.Name = "lblWatchlist"
        Me.lblWatchlist.Size = New System.Drawing.Size(289, 77)
        Me.lblWatchlist.TabIndex = 0
        Me.lblWatchlist.Text = "Watchlist"
        '
        'flowPnlWatchlist
        '
        Me.flowPnlWatchlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowPnlWatchlist.AutoScroll = True
        Me.flowPnlWatchlist.BackColor = System.Drawing.SystemColors.ControlLight
        Me.flowPnlWatchlist.Location = New System.Drawing.Point(75, 92)
        Me.flowPnlWatchlist.Name = "flowPnlWatchlist"
        Me.flowPnlWatchlist.Size = New System.Drawing.Size(1386, 397)
        Me.flowPnlWatchlist.TabIndex = 1
        '
        'pnlWatchlistLabel
        '
        Me.pnlWatchlistLabel.AutoSize = True
        Me.pnlWatchlistLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlWatchlistLabel.Controls.Add(Me.lblWatchlist)
        Me.pnlWatchlistLabel.Location = New System.Drawing.Point(586, 4)
        Me.pnlWatchlistLabel.Name = "pnlWatchlistLabel"
        Me.pnlWatchlistLabel.Size = New System.Drawing.Size(288, 82)
        Me.pnlWatchlistLabel.TabIndex = 2
        '
        'FormWatchlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1538, 526)
        Me.Controls.Add(Me.pnlWatchlistLabel)
        Me.Controls.Add(Me.flowPnlWatchlist)
        Me.Name = "FormWatchlist"
        Me.Text = "FormWatchlist"
        Me.pnlWatchlistLabel.ResumeLayout(False)
        Me.pnlWatchlistLabel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWatchlist As Label
    Friend WithEvents flowPnlWatchlist As FlowLayoutPanel
    Friend WithEvents pnlWatchlistLabel As Panel
End Class

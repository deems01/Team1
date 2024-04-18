<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatsOrHistorySelection
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
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHistory
        '
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnHistory.Location = New System.Drawing.Point(385, 167)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(177, 99)
        Me.btnHistory.TabIndex = 0
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnStats.Location = New System.Drawing.Point(742, 167)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(177, 99)
        Me.btnStats.TabIndex = 1
        Me.btnStats.Text = "Stats "
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'FormStatsOrHistorySelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1533, 526)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnHistory)
        Me.Name = "FormStatsOrHistorySelection"
        Me.Text = "StatsOrHistorySelectionForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHistory As Button
    Friend WithEvents btnStats As Button
End Class

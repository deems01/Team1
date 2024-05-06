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
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHistory
        '
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnHistory.Location = New System.Drawing.Point(372, 134)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(157, 79)
        Me.btnHistory.TabIndex = 0
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnStats.Location = New System.Drawing.Point(660, 134)
        Me.btnStats.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(157, 79)
        Me.btnStats.TabIndex = 1
        Me.btnStats.Text = "Stats "
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'BtnExport
        '
        Me.BtnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnExport.Location = New System.Drawing.Point(104, 134)
        Me.BtnExport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(163, 80)
        Me.BtnExport.TabIndex = 2
        Me.BtnExport.Text = "Export"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(104, 231)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(76, 20)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "append"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {",", ";", ":"})
        Me.ComboBox1.Location = New System.Drawing.Point(104, 271)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"""""", "'"})
        Me.ComboBox2.Location = New System.Drawing.Point(104, 301)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Field Separator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Text Qualifier"
        '
        'FormStatsOrHistorySelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1363, 421)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnHistory)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormStatsOrHistorySelection"
        Me.Text = "StatsOrHistorySelectionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHistory As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents BtnExport As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

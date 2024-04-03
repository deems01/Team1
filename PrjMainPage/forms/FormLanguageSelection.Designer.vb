<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLanguageSelection
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
        Me.cmbLanguageSelection = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmbLanguageSelection
        '
        Me.cmbLanguageSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbLanguageSelection.FormattingEnabled = True
        Me.cmbLanguageSelection.Items.AddRange(New Object() {"English", "French", "Spanish", "German", "Italian", "Portuguese", "Russian", "Chinese", "Japanese", "Arabic", "Hindi", "Korean", "Dutch", "Swedish", "Norwegian", "Danish", "Finnish", "Greek", "Turkish", "Polish", "Hungarian", "Czech", "Thai", "Indonesian", "Vietnamese"})
        Me.cmbLanguageSelection.Location = New System.Drawing.Point(0, 0)
        Me.cmbLanguageSelection.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbLanguageSelection.Name = "cmbLanguageSelection"
        Me.cmbLanguageSelection.Size = New System.Drawing.Size(222, 28)
        Me.cmbLanguageSelection.TabIndex = 0
        '
        'FormLanguageSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(222, 29)
        Me.Controls.Add(Me.cmbLanguageSelection)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormLanguageSelection"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbLanguageSelection As ComboBox
End Class

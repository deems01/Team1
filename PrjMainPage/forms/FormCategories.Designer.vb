<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategories
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.tabelpnlActor = New System.Windows.Forms.TableLayoutPanel()
        Me.lblActor = New System.Windows.Forms.Label()
        Me.tabelpnlCompany = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.tabelpnlNew = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.tabelpnlOld = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOld = New System.Windows.Forms.Label()
        Me.tabelpnlGenre = New System.Windows.Forms.TableLayoutPanel()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.tabelpnlActor.SuspendLayout()
        Me.tabelpnlCompany.SuspendLayout()
        Me.tabelpnlNew.SuspendLayout()
        Me.tabelpnlOld.SuspendLayout()
        Me.tabelpnlGenre.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel6)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(47, 27)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(936, 267)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 5
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.tabelpnlActor, 4, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.tabelpnlCompany, 3, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.tabelpnlNew, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.tabelpnlOld, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.tabelpnlGenre, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(933, 264)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'tabelpnlActor
        '
        Me.tabelpnlActor.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabelpnlActor.ColumnCount = 1
        Me.tabelpnlActor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tabelpnlActor.Controls.Add(Me.lblActor, 0, 0)
        Me.tabelpnlActor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelpnlActor.Location = New System.Drawing.Point(747, 3)
        Me.tabelpnlActor.Name = "tabelpnlActor"
        Me.tabelpnlActor.RowCount = 2
        Me.tabelpnlActor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.17829!))
        Me.tabelpnlActor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.82171!))
        Me.tabelpnlActor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tabelpnlActor.Size = New System.Drawing.Size(183, 258)
        Me.tabelpnlActor.TabIndex = 1
        '
        'lblActor
        '
        Me.lblActor.AutoSize = True
        Me.lblActor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblActor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblActor.Location = New System.Drawing.Point(3, 0)
        Me.lblActor.Name = "lblActor"
        Me.lblActor.Size = New System.Drawing.Size(177, 33)
        Me.lblActor.TabIndex = 4
        Me.lblActor.Text = "Actor"
        '
        'tabelpnlCompany
        '
        Me.tabelpnlCompany.BackColor = System.Drawing.Color.Cyan
        Me.tabelpnlCompany.ColumnCount = 1
        Me.tabelpnlCompany.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tabelpnlCompany.Controls.Add(Me.lblCompany, 0, 0)
        Me.tabelpnlCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelpnlCompany.Location = New System.Drawing.Point(561, 3)
        Me.tabelpnlCompany.Name = "tabelpnlCompany"
        Me.tabelpnlCompany.RowCount = 2
        Me.tabelpnlCompany.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.17829!))
        Me.tabelpnlCompany.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.82171!))
        Me.tabelpnlCompany.Size = New System.Drawing.Size(180, 258)
        Me.tabelpnlCompany.TabIndex = 1
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblCompany.Location = New System.Drawing.Point(3, 0)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(174, 33)
        Me.lblCompany.TabIndex = 3
        Me.lblCompany.Text = "Company"
        '
        'tabelpnlNew
        '
        Me.tabelpnlNew.BackColor = System.Drawing.Color.Lime
        Me.tabelpnlNew.ColumnCount = 1
        Me.tabelpnlNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tabelpnlNew.Controls.Add(Me.lblNew, 0, 0)
        Me.tabelpnlNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelpnlNew.Location = New System.Drawing.Point(375, 3)
        Me.tabelpnlNew.Name = "tabelpnlNew"
        Me.tabelpnlNew.RowCount = 2
        Me.tabelpnlNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.17829!))
        Me.tabelpnlNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.82171!))
        Me.tabelpnlNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tabelpnlNew.Size = New System.Drawing.Size(180, 258)
        Me.tabelpnlNew.TabIndex = 1
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblNew.Location = New System.Drawing.Point(3, 0)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(174, 33)
        Me.lblNew.TabIndex = 2
        Me.lblNew.Text = "New"
        '
        'tabelpnlOld
        '
        Me.tabelpnlOld.BackColor = System.Drawing.Color.Yellow
        Me.tabelpnlOld.ColumnCount = 1
        Me.tabelpnlOld.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tabelpnlOld.Controls.Add(Me.lblOld, 0, 0)
        Me.tabelpnlOld.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelpnlOld.Location = New System.Drawing.Point(189, 3)
        Me.tabelpnlOld.Name = "tabelpnlOld"
        Me.tabelpnlOld.RowCount = 2
        Me.tabelpnlOld.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.17829!))
        Me.tabelpnlOld.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.82171!))
        Me.tabelpnlOld.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tabelpnlOld.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tabelpnlOld.Size = New System.Drawing.Size(180, 258)
        Me.tabelpnlOld.TabIndex = 1
        '
        'lblOld
        '
        Me.lblOld.AutoSize = True
        Me.lblOld.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblOld.Location = New System.Drawing.Point(3, 0)
        Me.lblOld.Name = "lblOld"
        Me.lblOld.Size = New System.Drawing.Size(174, 33)
        Me.lblOld.TabIndex = 1
        Me.lblOld.Text = "Old"
        '
        'tabelpnlGenre
        '
        Me.tabelpnlGenre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tabelpnlGenre.ColumnCount = 1
        Me.tabelpnlGenre.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tabelpnlGenre.Controls.Add(Me.lblGenre, 0, 0)
        Me.tabelpnlGenre.Location = New System.Drawing.Point(3, 3)
        Me.tabelpnlGenre.Name = "tabelpnlGenre"
        Me.tabelpnlGenre.RowCount = 2
        Me.tabelpnlGenre.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.17829!))
        Me.tabelpnlGenre.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.82171!))
        Me.tabelpnlGenre.Size = New System.Drawing.Size(180, 258)
        Me.tabelpnlGenre.TabIndex = 0
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblGenre.Location = New System.Drawing.Point(3, 0)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(174, 33)
        Me.lblGenre.TabIndex = 0
        Me.lblGenre.Text = "Genre"
        '
        'FormCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1025, 342)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "FormCategories"
        Me.Text = "FormCategories"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.tabelpnlActor.ResumeLayout(False)
        Me.tabelpnlActor.PerformLayout()
        Me.tabelpnlCompany.ResumeLayout(False)
        Me.tabelpnlCompany.PerformLayout()
        Me.tabelpnlNew.ResumeLayout(False)
        Me.tabelpnlNew.PerformLayout()
        Me.tabelpnlOld.ResumeLayout(False)
        Me.tabelpnlOld.PerformLayout()
        Me.tabelpnlGenre.ResumeLayout(False)
        Me.tabelpnlGenre.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents tabelpnlGenre As TableLayoutPanel
    Friend WithEvents tabelpnlOld As TableLayoutPanel
    Friend WithEvents tabelpnlActor As TableLayoutPanel
    Friend WithEvents tabelpnlNew As TableLayoutPanel
    Friend WithEvents tabelpnlCompany As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblOld As Label
    Friend WithEvents lblActor As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblNew As Label
End Class

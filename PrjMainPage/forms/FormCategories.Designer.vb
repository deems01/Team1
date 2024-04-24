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
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblActor = New System.Windows.Forms.Label()
        Me.lblOld = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlGenre = New System.Windows.Forms.Panel()
        Me.pnlRec = New System.Windows.Forms.Panel()
        Me.pnlRand = New System.Windows.Forms.Panel()
        Me.pnlLanguage = New System.Windows.Forms.Panel()
        Me.pnlCompany = New System.Windows.Forms.Panel()
        Me.pnlNew = New System.Windows.Forms.Panel()
        Me.pnlActor = New System.Windows.Forms.Panel()
        Me.pnlOld = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlGenre.SuspendLayout()
        Me.pnlRec.SuspendLayout()
        Me.pnlRand.SuspendLayout()
        Me.pnlLanguage.SuspendLayout()
        Me.pnlCompany.SuspendLayout()
        Me.pnlNew.SuspendLayout()
        Me.pnlActor.SuspendLayout()
        Me.pnlOld.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblGenre.Location = New System.Drawing.Point(10, 10)
        Me.lblGenre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(97, 36)
        Me.lblGenre.TabIndex = 0
        Me.lblGenre.Text = "Genre"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblNew.Location = New System.Drawing.Point(0, 0)
        Me.lblNew.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Padding = New System.Windows.Forms.Padding(10)
        Me.lblNew.Size = New System.Drawing.Size(95, 56)
        Me.lblNew.TabIndex = 2
        Me.lblNew.Text = "New"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblCompany.Location = New System.Drawing.Point(0, 0)
        Me.lblCompany.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Padding = New System.Windows.Forms.Padding(10)
        Me.lblCompany.Size = New System.Drawing.Size(161, 56)
        Me.lblCompany.TabIndex = 3
        Me.lblCompany.Text = "Company"
        '
        'lblActor
        '
        Me.lblActor.AutoSize = True
        Me.lblActor.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblActor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblActor.Location = New System.Drawing.Point(10, 10)
        Me.lblActor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActor.Name = "lblActor"
        Me.lblActor.Size = New System.Drawing.Size(86, 36)
        Me.lblActor.TabIndex = 4
        Me.lblActor.Text = "Actor"
        '
        'lblOld
        '
        Me.lblOld.AutoSize = True
        Me.lblOld.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblOld.Location = New System.Drawing.Point(10, 10)
        Me.lblOld.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOld.Name = "lblOld"
        Me.lblOld.Size = New System.Drawing.Size(61, 36)
        Me.lblOld.TabIndex = 1
        Me.lblOld.Text = "Old"
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.BackColor = System.Drawing.Color.Transparent
        Me.lblLanguage.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblLanguage.Location = New System.Drawing.Point(0, 0)
        Me.lblLanguage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Padding = New System.Windows.Forms.Padding(10)
        Me.lblLanguage.Size = New System.Drawing.Size(168, 56)
        Me.lblLanguage.TabIndex = 3
        Me.lblLanguage.Text = "Language"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlRec, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlRand, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlLanguage, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlCompany, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlNew, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlActor, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlOld, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlGenre, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(58, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1422, 469)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'pnlGenre
        '
        Me.pnlGenre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlGenre.Controls.Add(Me.lblGenre)
        Me.pnlGenre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGenre.Location = New System.Drawing.Point(3, 3)
        Me.pnlGenre.Name = "pnlGenre"
        Me.pnlGenre.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlGenre.Size = New System.Drawing.Size(171, 463)
        Me.pnlGenre.TabIndex = 0
        '
        'pnlRec
        '
        Me.pnlRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlRec.Controls.Add(Me.Label1)
        Me.pnlRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRec.Location = New System.Drawing.Point(1242, 3)
        Me.pnlRec.Name = "pnlRec"
        Me.pnlRec.Size = New System.Drawing.Size(177, 463)
        Me.pnlRec.TabIndex = 1
        '
        'pnlRand
        '
        Me.pnlRand.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlRand.Controls.Add(Me.Label2)
        Me.pnlRand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRand.Location = New System.Drawing.Point(1065, 3)
        Me.pnlRand.Name = "pnlRand"
        Me.pnlRand.Size = New System.Drawing.Size(171, 463)
        Me.pnlRand.TabIndex = 1
        '
        'pnlLanguage
        '
        Me.pnlLanguage.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlLanguage.Controls.Add(Me.lblLanguage)
        Me.pnlLanguage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLanguage.Location = New System.Drawing.Point(888, 3)
        Me.pnlLanguage.Name = "pnlLanguage"
        Me.pnlLanguage.Size = New System.Drawing.Size(171, 463)
        Me.pnlLanguage.TabIndex = 1
        '
        'pnlCompany
        '
        Me.pnlCompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlCompany.Controls.Add(Me.lblCompany)
        Me.pnlCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCompany.Location = New System.Drawing.Point(711, 3)
        Me.pnlCompany.Name = "pnlCompany"
        Me.pnlCompany.Size = New System.Drawing.Size(171, 463)
        Me.pnlCompany.TabIndex = 1
        '
        'pnlNew
        '
        Me.pnlNew.BackColor = System.Drawing.Color.Blue
        Me.pnlNew.Controls.Add(Me.lblNew)
        Me.pnlNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNew.Location = New System.Drawing.Point(534, 3)
        Me.pnlNew.Name = "pnlNew"
        Me.pnlNew.Size = New System.Drawing.Size(171, 463)
        Me.pnlNew.TabIndex = 1
        '
        'pnlActor
        '
        Me.pnlActor.BackColor = System.Drawing.Color.Cyan
        Me.pnlActor.Controls.Add(Me.lblActor)
        Me.pnlActor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlActor.Location = New System.Drawing.Point(357, 3)
        Me.pnlActor.Name = "pnlActor"
        Me.pnlActor.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlActor.Size = New System.Drawing.Size(171, 463)
        Me.pnlActor.TabIndex = 1
        '
        'pnlOld
        '
        Me.pnlOld.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlOld.Controls.Add(Me.lblOld)
        Me.pnlOld.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOld.Location = New System.Drawing.Point(180, 3)
        Me.pnlOld.Name = "pnlOld"
        Me.pnlOld.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlOld.Size = New System.Drawing.Size(171, 463)
        Me.pnlOld.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(281, 56)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Recommendations"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10)
        Me.Label2.Size = New System.Drawing.Size(235, 56)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Random Movie"
        '
        'FormCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1538, 526)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormCategories"
        Me.Text = "FormCategories"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlGenre.ResumeLayout(False)
        Me.pnlGenre.PerformLayout()
        Me.pnlRec.ResumeLayout(False)
        Me.pnlRec.PerformLayout()
        Me.pnlRand.ResumeLayout(False)
        Me.pnlRand.PerformLayout()
        Me.pnlLanguage.ResumeLayout(False)
        Me.pnlLanguage.PerformLayout()
        Me.pnlCompany.ResumeLayout(False)
        Me.pnlCompany.PerformLayout()
        Me.pnlNew.ResumeLayout(False)
        Me.pnlNew.PerformLayout()
        Me.pnlActor.ResumeLayout(False)
        Me.pnlActor.PerformLayout()
        Me.pnlOld.ResumeLayout(False)
        Me.pnlOld.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblActor As Label
    Friend WithEvents lblOld As Label
    Friend WithEvents lblLanguage As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pnlRec As Panel
    Friend WithEvents pnlRand As Panel
    Friend WithEvents pnlLanguage As Panel
    Friend WithEvents pnlCompany As Panel
    Friend WithEvents pnlNew As Panel
    Friend WithEvents pnlActor As Panel
    Friend WithEvents pnlOld As Panel
    Friend WithEvents pnlGenre As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

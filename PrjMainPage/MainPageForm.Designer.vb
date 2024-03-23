<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPageForm
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
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.btnMaximize = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.btnCategory = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.pnlPage = New System.Windows.Forms.Panel()
        Me.btnHomePage = New FontAwesome.Sharp.IconButton()
        Me.pnlMainMenu = New System.Windows.Forms.Panel()
        Me.tabPnlMainMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlMainMenu.SuspendLayout()
        Me.tabPnlMainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimize.IconColor = System.Drawing.Color.Black
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.IconSize = 30
        Me.btnMinimize.Location = New System.Drawing.Point(856, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(84, 23)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMaximize.IconColor = System.Drawing.Color.Black
        Me.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaximize.IconSize = 25
        Me.btnMaximize.Location = New System.Drawing.Point(937, 2)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(84, 23)
        Me.btnMaximize.TabIndex = 2
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnExit.IconColor = System.Drawing.Color.Black
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 25
        Me.btnExit.Location = New System.Drawing.Point(1017, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.BarChart
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 80
        Me.IconButton3.Location = New System.Drawing.Point(194, 3)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(185, 78)
        Me.IconButton3.TabIndex = 6
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.BarChart
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 80
        Me.IconButton4.Location = New System.Drawing.Point(3, 3)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(185, 78)
        Me.IconButton4.TabIndex = 7
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'btnCategory
        '
        Me.btnCategory.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCategory.IconChar = FontAwesome.Sharp.IconChar.BarChart
        Me.btnCategory.IconColor = System.Drawing.Color.Black
        Me.btnCategory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCategory.IconSize = 80
        Me.btnCategory.Location = New System.Drawing.Point(767, 3)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(187, 78)
        Me.btnCategory.TabIndex = 0
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.BarChart
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 80
        Me.IconButton2.Location = New System.Drawing.Point(576, 3)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(185, 78)
        Me.IconButton2.TabIndex = 5
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.BarChart
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 80
        Me.IconButton1.Location = New System.Drawing.Point(385, 3)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(185, 78)
        Me.IconButton1.TabIndex = 4
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'pnlPage
        '
        Me.pnlPage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPage.BackColor = System.Drawing.Color.Transparent
        Me.pnlPage.Location = New System.Drawing.Point(30, 153)
        Me.pnlPage.Name = "pnlPage"
        Me.pnlPage.Size = New System.Drawing.Size(1041, 381)
        Me.pnlPage.TabIndex = 12
        '
        'btnHomePage
        '
        Me.btnHomePage.BackColor = System.Drawing.Color.Transparent
        Me.btnHomePage.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.btnHomePage.IconColor = System.Drawing.Color.Black
        Me.btnHomePage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHomePage.IconSize = 40
        Me.btnHomePage.Location = New System.Drawing.Point(13, 13)
        Me.btnHomePage.Name = "btnHomePage"
        Me.btnHomePage.Size = New System.Drawing.Size(52, 38)
        Me.btnHomePage.TabIndex = 13
        Me.btnHomePage.UseVisualStyleBackColor = False
        '
        'pnlMainMenu
        '
        Me.pnlMainMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMainMenu.BackColor = System.Drawing.Color.DarkGray
        Me.pnlMainMenu.Controls.Add(Me.tabPnlMainMenu)
        Me.pnlMainMenu.Location = New System.Drawing.Point(30, 57)
        Me.pnlMainMenu.Name = "pnlMainMenu"
        Me.pnlMainMenu.Size = New System.Drawing.Size(1041, 90)
        Me.pnlMainMenu.TabIndex = 14
        '
        'tabPnlMainMenu
        '
        Me.tabPnlMainMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPnlMainMenu.ColumnCount = 5
        Me.tabPnlMainMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tabPnlMainMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tabPnlMainMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tabPnlMainMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tabPnlMainMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tabPnlMainMenu.Controls.Add(Me.btnCategory, 4, 0)
        Me.tabPnlMainMenu.Controls.Add(Me.IconButton1, 2, 0)
        Me.tabPnlMainMenu.Controls.Add(Me.IconButton4, 0, 0)
        Me.tabPnlMainMenu.Controls.Add(Me.IconButton2, 3, 0)
        Me.tabPnlMainMenu.Controls.Add(Me.IconButton3, 1, 0)
        Me.tabPnlMainMenu.Location = New System.Drawing.Point(43, 3)
        Me.tabPnlMainMenu.Name = "tabPnlMainMenu"
        Me.tabPnlMainMenu.RowCount = 1
        Me.tabPnlMainMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tabPnlMainMenu.Size = New System.Drawing.Size(957, 84)
        Me.tabPnlMainMenu.TabIndex = 0
        '
        'MainPageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1096, 570)
        Me.Controls.Add(Me.pnlMainMenu)
        Me.Controls.Add(Me.btnHomePage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.pnlPage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainPageForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Form1"
        Me.pnlMainMenu.ResumeLayout(False)
        Me.tabPnlMainMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCategory As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlPage As Panel
    Friend WithEvents btnHomePage As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlMainMenu As Panel
    Friend WithEvents tabPnlMainMenu As TableLayoutPanel
End Class

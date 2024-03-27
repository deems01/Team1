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
        Me.btnWatchlist = New FontAwesome.Sharp.IconButton()
        Me.btnCategory = New FontAwesome.Sharp.IconButton()
        Me.btnPlanned = New FontAwesome.Sharp.IconButton()
        Me.btnNewPlan = New FontAwesome.Sharp.IconButton()
        Me.btnStats = New FontAwesome.Sharp.IconButton()
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
        Me.btnMinimize.Location = New System.Drawing.Point(1284, 3)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(126, 35)
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
        Me.btnMaximize.Location = New System.Drawing.Point(1406, 3)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(126, 35)
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
        Me.btnExit.Location = New System.Drawing.Point(1526, 3)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 35)
        Me.btnExit.TabIndex = 3
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnWatchlist
        '
        Me.btnWatchlist.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnWatchlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnWatchlist.IconChar = FontAwesome.Sharp.IconChar.BarChart
        Me.btnWatchlist.IconColor = System.Drawing.Color.Black
        Me.btnWatchlist.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnWatchlist.IconSize = 80
        Me.btnWatchlist.Location = New System.Drawing.Point(291, 5)
        Me.btnWatchlist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnWatchlist.Name = "btnWatchlist"
        Me.btnWatchlist.Size = New System.Drawing.Size(279, 119)
        Me.btnWatchlist.TabIndex = 6
        Me.btnWatchlist.UseVisualStyleBackColor = False
        '
        'btnCategory
        '
        Me.btnCategory.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCategory.IconChar = FontAwesome.Sharp.IconChar.BarChart
        Me.btnCategory.IconColor = System.Drawing.Color.Black
        Me.btnCategory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCategory.IconSize = 80
        Me.btnCategory.Location = New System.Drawing.Point(4, 5)
        Me.btnCategory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(279, 119)
        Me.btnCategory.TabIndex = 7
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'btnPlanned
        '
        Me.btnPlanned.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlanned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPlanned.IconChar = FontAwesome.Sharp.IconChar.BarChart
        Me.btnPlanned.IconColor = System.Drawing.Color.Black
        Me.btnPlanned.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPlanned.IconSize = 80
        Me.btnPlanned.Location = New System.Drawing.Point(1152, 5)
        Me.btnPlanned.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlanned.Name = "btnPlanned"
        Me.btnPlanned.Size = New System.Drawing.Size(280, 119)
        Me.btnPlanned.TabIndex = 0
        Me.btnPlanned.UseVisualStyleBackColor = False
        '
        'btnNewPlan
        '
        Me.btnNewPlan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNewPlan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNewPlan.IconChar = FontAwesome.Sharp.IconChar.BarChart
        Me.btnNewPlan.IconColor = System.Drawing.Color.Black
        Me.btnNewPlan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNewPlan.IconSize = 80
        Me.btnNewPlan.Location = New System.Drawing.Point(865, 5)
        Me.btnNewPlan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNewPlan.Name = "btnNewPlan"
        Me.btnNewPlan.Size = New System.Drawing.Size(279, 119)
        Me.btnNewPlan.TabIndex = 5
        Me.btnNewPlan.UseVisualStyleBackColor = False
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStats.IconChar = FontAwesome.Sharp.IconChar.BarChart
        Me.btnStats.IconColor = System.Drawing.Color.Black
        Me.btnStats.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStats.IconSize = 80
        Me.btnStats.Location = New System.Drawing.Point(578, 5)
        Me.btnStats.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(279, 119)
        Me.btnStats.TabIndex = 4
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'pnlPage
        '
        Me.pnlPage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPage.BackColor = System.Drawing.Color.Transparent
        Me.pnlPage.Location = New System.Drawing.Point(45, 235)
        Me.pnlPage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlPage.Name = "pnlPage"
        Me.pnlPage.Size = New System.Drawing.Size(1562, 586)
        Me.pnlPage.TabIndex = 12
        '
        'btnHomePage
        '
        Me.btnHomePage.BackColor = System.Drawing.Color.Transparent
        Me.btnHomePage.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.btnHomePage.IconColor = System.Drawing.Color.Black
        Me.btnHomePage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHomePage.IconSize = 40
        Me.btnHomePage.Location = New System.Drawing.Point(20, 20)
        Me.btnHomePage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHomePage.Name = "btnHomePage"
        Me.btnHomePage.Size = New System.Drawing.Size(78, 58)
        Me.btnHomePage.TabIndex = 13
        Me.btnHomePage.UseVisualStyleBackColor = False
        '
        'pnlMainMenu
        '
        Me.pnlMainMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMainMenu.BackColor = System.Drawing.Color.DarkGray
        Me.pnlMainMenu.Controls.Add(Me.tabPnlMainMenu)
        Me.pnlMainMenu.Location = New System.Drawing.Point(45, 88)
        Me.pnlMainMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlMainMenu.Name = "pnlMainMenu"
        Me.pnlMainMenu.Size = New System.Drawing.Size(1562, 138)
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
        Me.tabPnlMainMenu.Controls.Add(Me.btnPlanned, 4, 0)
        Me.tabPnlMainMenu.Controls.Add(Me.btnStats, 2, 0)
        Me.tabPnlMainMenu.Controls.Add(Me.btnCategory, 0, 0)
        Me.tabPnlMainMenu.Controls.Add(Me.btnNewPlan, 3, 0)
        Me.tabPnlMainMenu.Controls.Add(Me.btnWatchlist, 1, 0)
        Me.tabPnlMainMenu.Location = New System.Drawing.Point(64, 5)
        Me.tabPnlMainMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabPnlMainMenu.Name = "tabPnlMainMenu"
        Me.tabPnlMainMenu.RowCount = 1
        Me.tabPnlMainMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tabPnlMainMenu.Size = New System.Drawing.Size(1436, 129)
        Me.tabPnlMainMenu.TabIndex = 0
        '
        'MainPageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1644, 877)
        Me.Controls.Add(Me.pnlMainMenu)
        Me.Controls.Add(Me.btnHomePage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.pnlPage)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainPageForm"
        Me.Padding = New System.Windows.Forms.Padding(15, 15, 15, 15)
        Me.Text = "Form1"
        Me.pnlMainMenu.ResumeLayout(False)
        Me.tabPnlMainMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnWatchlist As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCategory As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPlanned As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNewPlan As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStats As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlPage As Panel
    Friend WithEvents btnHomePage As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlMainMenu As Panel
    Friend WithEvents tabPnlMainMenu As TableLayoutPanel
End Class

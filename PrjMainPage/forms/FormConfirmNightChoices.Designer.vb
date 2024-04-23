<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfirmNightChoices
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
        Me.components = New System.ComponentModel.Container()
        Me.txtBoxSelectedDate = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtBoxSelectedMovie = New System.Windows.Forms.TextBox()
        Me.btnAddEmail = New System.Windows.Forms.Button()
        Me.txtBoxNewEmail = New System.Windows.Forms.TextBox()
        Me.btnSendInvites = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtBoxAddHostEmail = New System.Windows.Forms.TextBox()
        Me.btnAddHostEmail = New System.Windows.Forms.Button()
        Me.txtBoxHostPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHostCredentialsStatus = New System.Windows.Forms.Label()
        Me.lblInviteStatus = New System.Windows.Forms.Label()
        Me.txtBoxSelectedLocation = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBoxSelectedDate
        '
        Me.txtBoxSelectedDate.Enabled = False
        Me.txtBoxSelectedDate.Location = New System.Drawing.Point(78, 98)
        Me.txtBoxSelectedDate.Name = "txtBoxSelectedDate"
        Me.txtBoxSelectedDate.Size = New System.Drawing.Size(253, 20)
        Me.txtBoxSelectedDate.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtBoxSelectedMovie
        '
        Me.txtBoxSelectedMovie.Enabled = False
        Me.txtBoxSelectedMovie.Location = New System.Drawing.Point(78, 152)
        Me.txtBoxSelectedMovie.Name = "txtBoxSelectedMovie"
        Me.txtBoxSelectedMovie.Size = New System.Drawing.Size(253, 20)
        Me.txtBoxSelectedMovie.TabIndex = 2
        '
        'btnAddEmail
        '
        Me.btnAddEmail.Location = New System.Drawing.Point(461, 219)
        Me.btnAddEmail.Name = "btnAddEmail"
        Me.btnAddEmail.Size = New System.Drawing.Size(130, 23)
        Me.btnAddEmail.TabIndex = 3
        Me.btnAddEmail.Text = "Add Email Recipient(s)"
        Me.btnAddEmail.UseVisualStyleBackColor = True
        '
        'txtBoxNewEmail
        '
        Me.txtBoxNewEmail.Location = New System.Drawing.Point(443, 193)
        Me.txtBoxNewEmail.Name = "txtBoxNewEmail"
        Me.txtBoxNewEmail.Size = New System.Drawing.Size(171, 20)
        Me.txtBoxNewEmail.TabIndex = 4
        '
        'btnSendInvites
        '
        Me.btnSendInvites.Location = New System.Drawing.Point(485, 274)
        Me.btnSendInvites.Name = "btnSendInvites"
        Me.btnSendInvites.Size = New System.Drawing.Size(75, 23)
        Me.btnSendInvites.TabIndex = 5
        Me.btnSendInvites.Text = "Send Invites"
        Me.btnSendInvites.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(636, 98)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(213, 199)
        Me.ListBox1.TabIndex = 6
        '
        'txtBoxAddHostEmail
        '
        Me.txtBoxAddHostEmail.Location = New System.Drawing.Point(443, 98)
        Me.txtBoxAddHostEmail.Name = "txtBoxAddHostEmail"
        Me.txtBoxAddHostEmail.Size = New System.Drawing.Size(171, 20)
        Me.txtBoxAddHostEmail.TabIndex = 7
        '
        'btnAddHostEmail
        '
        Me.btnAddHostEmail.Location = New System.Drawing.Point(461, 150)
        Me.btnAddHostEmail.Name = "btnAddHostEmail"
        Me.btnAddHostEmail.Size = New System.Drawing.Size(130, 23)
        Me.btnAddHostEmail.TabIndex = 8
        Me.btnAddHostEmail.Text = "Add Host Credentials"
        Me.btnAddHostEmail.UseVisualStyleBackColor = True
        '
        'txtBoxHostPassword
        '
        Me.txtBoxHostPassword.Location = New System.Drawing.Point(443, 124)
        Me.txtBoxHostPassword.Name = "txtBoxHostPassword"
        Me.txtBoxHostPassword.Size = New System.Drawing.Size(171, 20)
        Me.txtBoxHostPassword.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "The date you chose:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "The movie you chose:"
        '
        'lblHostCredentialsStatus
        '
        Me.lblHostCredentialsStatus.AutoSize = True
        Me.lblHostCredentialsStatus.Location = New System.Drawing.Point(440, 71)
        Me.lblHostCredentialsStatus.Name = "lblHostCredentialsStatus"
        Me.lblHostCredentialsStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblHostCredentialsStatus.TabIndex = 13
        '
        'lblInviteStatus
        '
        Me.lblInviteStatus.AutoSize = True
        Me.lblInviteStatus.Location = New System.Drawing.Point(440, 309)
        Me.lblInviteStatus.Name = "lblInviteStatus"
        Me.lblInviteStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblInviteStatus.TabIndex = 14
        '
        'txtBoxSelectedLocation
        '
        Me.txtBoxSelectedLocation.Enabled = False
        Me.txtBoxSelectedLocation.Location = New System.Drawing.Point(78, 205)
        Me.txtBoxSelectedLocation.Name = "txtBoxSelectedLocation"
        Me.txtBoxSelectedLocation.Size = New System.Drawing.Size(253, 20)
        Me.txtBoxSelectedLocation.TabIndex = 15
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(75, 189)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(121, 13)
        Me.lblLocation.TabIndex = 16
        Me.lblLocation.Text = "The location you chose:"
        '
        'FormConfirmNightChoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 451)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.txtBoxSelectedLocation)
        Me.Controls.Add(Me.lblInviteStatus)
        Me.Controls.Add(Me.lblHostCredentialsStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxHostPassword)
        Me.Controls.Add(Me.btnAddHostEmail)
        Me.Controls.Add(Me.txtBoxAddHostEmail)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnSendInvites)
        Me.Controls.Add(Me.txtBoxNewEmail)
        Me.Controls.Add(Me.btnAddEmail)
        Me.Controls.Add(Me.txtBoxSelectedMovie)
        Me.Controls.Add(Me.txtBoxSelectedDate)
        Me.Name = "FormConfirmNightChoices"
        Me.Text = "FormConfirmNightChoices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBoxSelectedDate As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtBoxSelectedMovie As TextBox
    Friend WithEvents btnAddEmail As Button
    Friend WithEvents txtBoxNewEmail As TextBox
    Friend WithEvents btnSendInvites As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtBoxAddHostEmail As TextBox
    Friend WithEvents btnAddHostEmail As Button
    Friend WithEvents txtBoxHostPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHostCredentialsStatus As Label
    Friend WithEvents lblInviteStatus As Label
    Friend WithEvents txtBoxSelectedLocation As TextBox
    Friend WithEvents lblLocation As Label
End Class

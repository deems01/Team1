<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConfirmNightChoices
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
        Me.components = New System.ComponentModel.Container()
        Me.txtBoxSelectedDate = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtBoxSelectedMovie = New System.Windows.Forms.TextBox()
        Me.btnAddEmail = New System.Windows.Forms.Button()
        Me.txtBoxNewEmail = New System.Windows.Forms.TextBox()
        Me.btnSendInvites = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHostCredentialsStatus = New System.Windows.Forms.Label()
        Me.lblInviteStatus = New System.Windows.Forms.Label()
        Me.txtBoxSelectedLocation = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.checkBoxFriends = New System.Windows.Forms.CheckBox()
        Me.checkBoxAcquaintances = New System.Windows.Forms.CheckBox()
        Me.checkBoxFamily = New System.Windows.Forms.CheckBox()
        Me.checkBoxColleagues = New System.Windows.Forms.CheckBox()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.txtBoxMessage = New System.Windows.Forms.TextBox()
        Me.txtBoxSubject = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxHostEmail = New System.Windows.Forms.TextBox()
        Me.txtBoxHostPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBoxSelectedDate
        '
        Me.txtBoxSelectedDate.Enabled = False
        Me.txtBoxSelectedDate.Location = New System.Drawing.Point(104, 69)
        Me.txtBoxSelectedDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBoxSelectedDate.Name = "txtBoxSelectedDate"
        Me.txtBoxSelectedDate.Size = New System.Drawing.Size(336, 22)
        Me.txtBoxSelectedDate.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtBoxSelectedMovie
        '
        Me.txtBoxSelectedMovie.Enabled = False
        Me.txtBoxSelectedMovie.Location = New System.Drawing.Point(104, 128)
        Me.txtBoxSelectedMovie.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBoxSelectedMovie.Name = "txtBoxSelectedMovie"
        Me.txtBoxSelectedMovie.Size = New System.Drawing.Size(336, 22)
        Me.txtBoxSelectedMovie.TabIndex = 2
        '
        'btnAddEmail
        '
        Me.btnAddEmail.Location = New System.Drawing.Point(615, 102)
        Me.btnAddEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddEmail.Name = "btnAddEmail"
        Me.btnAddEmail.Size = New System.Drawing.Size(173, 28)
        Me.btnAddEmail.TabIndex = 3
        Me.btnAddEmail.Text = "Add Email Recipient(s)"
        Me.btnAddEmail.UseVisualStyleBackColor = True
        '
        'txtBoxNewEmail
        '
        Me.txtBoxNewEmail.Location = New System.Drawing.Point(595, 69)
        Me.txtBoxNewEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBoxNewEmail.Name = "txtBoxNewEmail"
        Me.txtBoxNewEmail.Size = New System.Drawing.Size(227, 22)
        Me.txtBoxNewEmail.TabIndex = 4
        '
        'btnSendInvites
        '
        Me.btnSendInvites.Location = New System.Drawing.Point(1009, 500)
        Me.btnSendInvites.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSendInvites.Name = "btnSendInvites"
        Me.btnSendInvites.Size = New System.Drawing.Size(109, 28)
        Me.btnSendInvites.TabIndex = 5
        Me.btnSendInvites.Text = "Send Invites"
        Me.btnSendInvites.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(931, 69)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(283, 244)
        Me.ListBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "The date you chose:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "The movie you chose:"
        '
        'lblHostCredentialsStatus
        '
        Me.lblHostCredentialsStatus.AutoSize = True
        Me.lblHostCredentialsStatus.Location = New System.Drawing.Point(984, 331)
        Me.lblHostCredentialsStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHostCredentialsStatus.Name = "lblHostCredentialsStatus"
        Me.lblHostCredentialsStatus.Size = New System.Drawing.Size(0, 16)
        Me.lblHostCredentialsStatus.TabIndex = 13
        '
        'lblInviteStatus
        '
        Me.lblInviteStatus.AutoSize = True
        Me.lblInviteStatus.Location = New System.Drawing.Point(984, 539)
        Me.lblInviteStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInviteStatus.Name = "lblInviteStatus"
        Me.lblInviteStatus.Size = New System.Drawing.Size(0, 16)
        Me.lblInviteStatus.TabIndex = 14
        '
        'txtBoxSelectedLocation
        '
        Me.txtBoxSelectedLocation.Enabled = False
        Me.txtBoxSelectedLocation.Location = New System.Drawing.Point(104, 187)
        Me.txtBoxSelectedLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBoxSelectedLocation.Name = "txtBoxSelectedLocation"
        Me.txtBoxSelectedLocation.Size = New System.Drawing.Size(336, 22)
        Me.txtBoxSelectedLocation.TabIndex = 15
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(100, 167)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(149, 16)
        Me.lblLocation.TabIndex = 16
        Me.lblLocation.Text = "The location you chose:"
        '
        'checkBoxFriends
        '
        Me.checkBoxFriends.AutoSize = True
        Me.checkBoxFriends.Location = New System.Drawing.Point(488, 240)
        Me.checkBoxFriends.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBoxFriends.Name = "checkBoxFriends"
        Me.checkBoxFriends.Size = New System.Drawing.Size(74, 20)
        Me.checkBoxFriends.TabIndex = 18
        Me.checkBoxFriends.Text = "Friends"
        Me.checkBoxFriends.UseVisualStyleBackColor = True
        '
        'checkBoxAcquaintances
        '
        Me.checkBoxAcquaintances.AutoSize = True
        Me.checkBoxAcquaintances.Location = New System.Drawing.Point(576, 240)
        Me.checkBoxAcquaintances.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBoxAcquaintances.Name = "checkBoxAcquaintances"
        Me.checkBoxAcquaintances.Size = New System.Drawing.Size(118, 20)
        Me.checkBoxAcquaintances.TabIndex = 19
        Me.checkBoxAcquaintances.Text = "Acquaintances"
        Me.checkBoxAcquaintances.UseVisualStyleBackColor = True
        '
        'checkBoxFamily
        '
        Me.checkBoxFamily.AutoSize = True
        Me.checkBoxFamily.Location = New System.Drawing.Point(713, 240)
        Me.checkBoxFamily.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBoxFamily.Name = "checkBoxFamily"
        Me.checkBoxFamily.Size = New System.Drawing.Size(69, 20)
        Me.checkBoxFamily.TabIndex = 20
        Me.checkBoxFamily.Text = "Family"
        Me.checkBoxFamily.UseVisualStyleBackColor = True
        '
        'checkBoxColleagues
        '
        Me.checkBoxColleagues.AutoSize = True
        Me.checkBoxColleagues.Location = New System.Drawing.Point(795, 240)
        Me.checkBoxColleagues.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBoxColleagues.Name = "checkBoxColleagues"
        Me.checkBoxColleagues.Size = New System.Drawing.Size(98, 20)
        Me.checkBoxColleagues.TabIndex = 21
        Me.checkBoxColleagues.Text = "Colleagues"
        Me.checkBoxColleagues.UseVisualStyleBackColor = True
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Location = New System.Drawing.Point(484, 207)
        Me.lblFormat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(225, 16)
        Me.lblFormat.TabIndex = 22
        Me.lblFormat.Text = "Choose the format for your message:"
        '
        'txtBoxMessage
        '
        Me.txtBoxMessage.Location = New System.Drawing.Point(104, 380)
        Me.txtBoxMessage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBoxMessage.Multiline = True
        Me.txtBoxMessage.Name = "txtBoxMessage"
        Me.txtBoxMessage.Size = New System.Drawing.Size(764, 194)
        Me.txtBoxMessage.TabIndex = 23
        '
        'txtBoxSubject
        '
        Me.txtBoxSubject.Location = New System.Drawing.Point(104, 322)
        Me.txtBoxSubject.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBoxSubject.Name = "txtBoxSubject"
        Me.txtBoxSubject.Size = New System.Drawing.Size(336, 22)
        Me.txtBoxSubject.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(591, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Specify who you want to invite:"
        '
        'txtBoxHostEmail
        '
        Me.txtBoxHostEmail.Location = New System.Drawing.Point(988, 380)
        Me.txtBoxHostEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBoxHostEmail.Name = "txtBoxHostEmail"
        Me.txtBoxHostEmail.Size = New System.Drawing.Size(161, 22)
        Me.txtBoxHostEmail.TabIndex = 26
        '
        'txtBoxHostPassword
        '
        Me.txtBoxHostPassword.Location = New System.Drawing.Point(988, 447)
        Me.txtBoxHostPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBoxHostPassword.Name = "txtBoxHostPassword"
        Me.txtBoxHostPassword.Size = New System.Drawing.Size(161, 22)
        Me.txtBoxHostPassword.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(984, 361)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Host email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(984, 427)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Host password:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(100, 298)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Message subject:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(100, 361)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Message body:"
        '
        'FormConfirmNightChoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1545, 694)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBoxHostPassword)
        Me.Controls.Add(Me.txtBoxHostEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBoxSubject)
        Me.Controls.Add(Me.txtBoxMessage)
        Me.Controls.Add(Me.lblFormat)
        Me.Controls.Add(Me.checkBoxColleagues)
        Me.Controls.Add(Me.checkBoxFamily)
        Me.Controls.Add(Me.checkBoxAcquaintances)
        Me.Controls.Add(Me.checkBoxFriends)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.txtBoxSelectedLocation)
        Me.Controls.Add(Me.lblInviteStatus)
        Me.Controls.Add(Me.lblHostCredentialsStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnSendInvites)
        Me.Controls.Add(Me.txtBoxNewEmail)
        Me.Controls.Add(Me.btnAddEmail)
        Me.Controls.Add(Me.txtBoxSelectedMovie)
        Me.Controls.Add(Me.txtBoxSelectedDate)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHostCredentialsStatus As Label
    Friend WithEvents lblInviteStatus As Label
    Friend WithEvents txtBoxSelectedLocation As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents checkBoxFriends As CheckBox
    Friend WithEvents checkBoxAcquaintances As CheckBox
    Friend WithEvents checkBoxFamily As CheckBox
    Friend WithEvents checkBoxColleagues As CheckBox
    Friend WithEvents lblFormat As Label
    Friend WithEvents txtBoxMessage As TextBox
    Friend WithEvents txtBoxSubject As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBoxHostEmail As TextBox
    Friend WithEvents txtBoxHostPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class

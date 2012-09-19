<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsWindow
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
        Me.SettingsTab = New System.Windows.Forms.TabControl()
        Me.AuthenticationPage = New System.Windows.Forms.TabPage()
        Me.AccessTypeLabel = New System.Windows.Forms.Label()
        Me.LoginTypeLabel = New System.Windows.Forms.Label()
        Me.LoginType = New System.Windows.Forms.ComboBox()
        Me.MatchLabel = New System.Windows.Forms.Label()
        Me.PasswordRepeatBox = New System.Windows.Forms.MaskedTextBox()
        Me.PasswordBox = New System.Windows.Forms.MaskedTextBox()
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.PasswordRepeatLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.ScreenPage = New System.Windows.Forms.TabPage()
        Me.DefaultMonitorCombo = New System.Windows.Forms.ComboBox()
        Me.DefaultMonitorLabel = New System.Windows.Forms.Label()
        Me.OkayBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.FullscreenCheck = New System.Windows.Forms.CheckBox()
        Me.SettingsTab.SuspendLayout()
        Me.AuthenticationPage.SuspendLayout()
        Me.ScreenPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingsTab
        '
        Me.SettingsTab.Controls.Add(Me.AuthenticationPage)
        Me.SettingsTab.Controls.Add(Me.ScreenPage)
        Me.SettingsTab.Location = New System.Drawing.Point(12, 12)
        Me.SettingsTab.Name = "SettingsTab"
        Me.SettingsTab.SelectedIndex = 0
        Me.SettingsTab.Size = New System.Drawing.Size(576, 361)
        Me.SettingsTab.TabIndex = 0
        '
        'AuthenticationPage
        '
        Me.AuthenticationPage.Controls.Add(Me.AccessTypeLabel)
        Me.AuthenticationPage.Controls.Add(Me.LoginTypeLabel)
        Me.AuthenticationPage.Controls.Add(Me.LoginType)
        Me.AuthenticationPage.Controls.Add(Me.MatchLabel)
        Me.AuthenticationPage.Controls.Add(Me.PasswordRepeatBox)
        Me.AuthenticationPage.Controls.Add(Me.PasswordBox)
        Me.AuthenticationPage.Controls.Add(Me.UsernameBox)
        Me.AuthenticationPage.Controls.Add(Me.PasswordRepeatLabel)
        Me.AuthenticationPage.Controls.Add(Me.PasswordLabel)
        Me.AuthenticationPage.Controls.Add(Me.UsernameLabel)
        Me.AuthenticationPage.Location = New System.Drawing.Point(4, 25)
        Me.AuthenticationPage.Name = "AuthenticationPage"
        Me.AuthenticationPage.Padding = New System.Windows.Forms.Padding(3)
        Me.AuthenticationPage.Size = New System.Drawing.Size(568, 332)
        Me.AuthenticationPage.TabIndex = 0
        Me.AuthenticationPage.Text = "Authentication"
        Me.AuthenticationPage.UseVisualStyleBackColor = True
        '
        'AccessTypeLabel
        '
        Me.AccessTypeLabel.AutoSize = True
        Me.AccessTypeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.AccessTypeLabel.Location = New System.Drawing.Point(162, 85)
        Me.AccessTypeLabel.Name = "AccessTypeLabel"
        Me.AccessTypeLabel.Size = New System.Drawing.Size(0, 17)
        Me.AccessTypeLabel.TabIndex = 9
        '
        'LoginTypeLabel
        '
        Me.LoginTypeLabel.AutoSize = True
        Me.LoginTypeLabel.Location = New System.Drawing.Point(36, 57)
        Me.LoginTypeLabel.Name = "LoginTypeLabel"
        Me.LoginTypeLabel.Size = New System.Drawing.Size(79, 17)
        Me.LoginTypeLabel.TabIndex = 8
        Me.LoginTypeLabel.Text = "Login Type"
        '
        'LoginType
        '
        Me.LoginType.DisplayMember = "0"
        Me.LoginType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LoginType.FormattingEnabled = True
        Me.LoginType.Items.AddRange(New Object() {"Anonymous", "User"})
        Me.LoginType.Location = New System.Drawing.Point(162, 54)
        Me.LoginType.Name = "LoginType"
        Me.LoginType.Size = New System.Drawing.Size(240, 24)
        Me.LoginType.TabIndex = 7
        '
        'MatchLabel
        '
        Me.MatchLabel.AutoSize = True
        Me.MatchLabel.Enabled = False
        Me.MatchLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.MatchLabel.Location = New System.Drawing.Point(410, 202)
        Me.MatchLabel.Name = "MatchLabel"
        Me.MatchLabel.Size = New System.Drawing.Size(62, 17)
        Me.MatchLabel.TabIndex = 6
        Me.MatchLabel.Text = "Matched"
        '
        'PasswordRepeatBox
        '
        Me.PasswordRepeatBox.AsciiOnly = True
        Me.PasswordRepeatBox.Enabled = False
        Me.PasswordRepeatBox.Location = New System.Drawing.Point(162, 202)
        Me.PasswordRepeatBox.Name = "PasswordRepeatBox"
        Me.PasswordRepeatBox.Size = New System.Drawing.Size(240, 22)
        Me.PasswordRepeatBox.TabIndex = 5
        Me.PasswordRepeatBox.UseSystemPasswordChar = True
        '
        'PasswordBox
        '
        Me.PasswordBox.AsciiOnly = True
        Me.PasswordBox.Enabled = False
        Me.PasswordBox.Location = New System.Drawing.Point(162, 173)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(240, 22)
        Me.PasswordBox.TabIndex = 4
        Me.PasswordBox.UseSystemPasswordChar = True
        '
        'UsernameBox
        '
        Me.UsernameBox.Enabled = False
        Me.UsernameBox.Location = New System.Drawing.Point(162, 144)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(240, 22)
        Me.UsernameBox.TabIndex = 3
        '
        'PasswordRepeatLabel
        '
        Me.PasswordRepeatLabel.AutoSize = True
        Me.PasswordRepeatLabel.Enabled = False
        Me.PasswordRepeatLabel.Location = New System.Drawing.Point(36, 199)
        Me.PasswordRepeatLabel.Name = "PasswordRepeatLabel"
        Me.PasswordRepeatLabel.Size = New System.Drawing.Size(119, 17)
        Me.PasswordRepeatLabel.TabIndex = 2
        Me.PasswordRepeatLabel.Text = "Repeat Password"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Enabled = False
        Me.PasswordLabel.Location = New System.Drawing.Point(36, 172)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(69, 17)
        Me.PasswordLabel.TabIndex = 1
        Me.PasswordLabel.Text = "Password"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Enabled = False
        Me.UsernameLabel.Location = New System.Drawing.Point(36, 144)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(73, 17)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Username"
        '
        'ScreenPage
        '
        Me.ScreenPage.Controls.Add(Me.FullscreenCheck)
        Me.ScreenPage.Controls.Add(Me.DefaultMonitorCombo)
        Me.ScreenPage.Controls.Add(Me.DefaultMonitorLabel)
        Me.ScreenPage.Location = New System.Drawing.Point(4, 25)
        Me.ScreenPage.Name = "ScreenPage"
        Me.ScreenPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ScreenPage.Size = New System.Drawing.Size(568, 332)
        Me.ScreenPage.TabIndex = 1
        Me.ScreenPage.Text = "Screen"
        Me.ScreenPage.UseVisualStyleBackColor = True
        '
        'DefaultMonitorCombo
        '
        Me.DefaultMonitorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DefaultMonitorCombo.FormattingEnabled = True
        Me.DefaultMonitorCombo.Location = New System.Drawing.Point(147, 25)
        Me.DefaultMonitorCombo.Name = "DefaultMonitorCombo"
        Me.DefaultMonitorCombo.Size = New System.Drawing.Size(59, 24)
        Me.DefaultMonitorCombo.TabIndex = 1
        '
        'DefaultMonitorLabel
        '
        Me.DefaultMonitorLabel.AutoSize = True
        Me.DefaultMonitorLabel.Location = New System.Drawing.Point(28, 28)
        Me.DefaultMonitorLabel.Name = "DefaultMonitorLabel"
        Me.DefaultMonitorLabel.Size = New System.Drawing.Size(104, 17)
        Me.DefaultMonitorLabel.TabIndex = 0
        Me.DefaultMonitorLabel.Text = "Default Monitor"
        '
        'OkayBtn
        '
        Me.OkayBtn.Location = New System.Drawing.Point(412, 379)
        Me.OkayBtn.Name = "OkayBtn"
        Me.OkayBtn.Size = New System.Drawing.Size(86, 41)
        Me.OkayBtn.TabIndex = 1
        Me.OkayBtn.Text = "&Accept"
        Me.OkayBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(504, 379)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(80, 41)
        Me.CancelBtn.TabIndex = 2
        Me.CancelBtn.Text = "&Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'FullscreenCheck
        '
        Me.FullscreenCheck.AutoSize = True
        Me.FullscreenCheck.Location = New System.Drawing.Point(31, 264)
        Me.FullscreenCheck.Name = "FullscreenCheck"
        Me.FullscreenCheck.Size = New System.Drawing.Size(97, 21)
        Me.FullscreenCheck.TabIndex = 2
        Me.FullscreenCheck.Text = "FullScreen"
        Me.FullscreenCheck.UseVisualStyleBackColor = True
        '
        'SettingsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 432)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OkayBtn)
        Me.Controls.Add(Me.SettingsTab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsWindow"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.SettingsTab.ResumeLayout(False)
        Me.AuthenticationPage.ResumeLayout(False)
        Me.AuthenticationPage.PerformLayout()
        Me.ScreenPage.ResumeLayout(False)
        Me.ScreenPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SettingsTab As System.Windows.Forms.TabControl
    Friend WithEvents AuthenticationPage As System.Windows.Forms.TabPage
    Friend WithEvents OkayBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents LoginTypeLabel As System.Windows.Forms.Label
    Friend WithEvents LoginType As System.Windows.Forms.ComboBox
    Friend WithEvents MatchLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordRepeatBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PasswordBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents UsernameBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordRepeatLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents AccessTypeLabel As System.Windows.Forms.Label
    Friend WithEvents ScreenPage As System.Windows.Forms.TabPage
    Friend WithEvents DefaultMonitorCombo As System.Windows.Forms.ComboBox
    Friend WithEvents DefaultMonitorLabel As System.Windows.Forms.Label
    Friend WithEvents FullscreenCheck As System.Windows.Forms.CheckBox

End Class

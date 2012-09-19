<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUrlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusAppName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DirEntry = New System.DirectoryServices.DirectoryEntry()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MediaToolStripMenuItem1, Me.CommandToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(878, 28)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveLogToolStripMenuItem, Me.SendLogToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveLogToolStripMenuItem
        '
        Me.SaveLogToolStripMenuItem.Name = "SaveLogToolStripMenuItem"
        Me.SaveLogToolStripMenuItem.Size = New System.Drawing.Size(149, 24)
        Me.SaveLogToolStripMenuItem.Text = "Save Log..."
        '
        'SendLogToolStripMenuItem
        '
        Me.SendLogToolStripMenuItem.Name = "SendLogToolStripMenuItem"
        Me.SendLogToolStripMenuItem.Size = New System.Drawing.Size(149, 24)
        Me.SendLogToolStripMenuItem.Text = "Send Log..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(149, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'MediaToolStripMenuItem1
        '
        Me.MediaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFileToolStripMenuItem, Me.AddUrlToolStripMenuItem, Me.AddFolderToolStripMenuItem})
        Me.MediaToolStripMenuItem1.Name = "MediaToolStripMenuItem1"
        Me.MediaToolStripMenuItem1.Size = New System.Drawing.Size(63, 24)
        Me.MediaToolStripMenuItem1.Text = "&Media"
        '
        'AddFileToolStripMenuItem
        '
        Me.AddFileToolStripMenuItem.Name = "AddFileToolStripMenuItem"
        Me.AddFileToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AddFileToolStripMenuItem.Text = "Add F&ile"
        '
        'AddUrlToolStripMenuItem
        '
        Me.AddUrlToolStripMenuItem.Name = "AddUrlToolStripMenuItem"
        Me.AddUrlToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AddUrlToolStripMenuItem.Text = "Add &URL"
        '
        'AddFolderToolStripMenuItem
        '
        Me.AddFolderToolStripMenuItem.Name = "AddFolderToolStripMenuItem"
        Me.AddFolderToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AddFolderToolStripMenuItem.Text = "Add F&older"
        '
        'CommandToolStripMenuItem
        '
        Me.CommandToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCommandToolStripMenuItem})
        Me.CommandToolStripMenuItem.Name = "CommandToolStripMenuItem"
        Me.CommandToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.CommandToolStripMenuItem.Text = "Command"
        '
        'AddCommandToolStripMenuItem
        '
        Me.AddCommandToolStripMenuItem.Name = "AddCommandToolStripMenuItem"
        Me.AddCommandToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.AddCommandToolStripMenuItem.Text = "Add Command"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem1})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.SettingsToolStripMenuItem.Text = "&Tools"
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(131, 24)
        Me.SettingsToolStripMenuItem1.Text = "&Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.AboutCompanyToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'AboutCompanyToolStripMenuItem
        '
        Me.AboutCompanyToolStripMenuItem.Name = "AboutCompanyToolStripMenuItem"
        Me.AboutCompanyToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.AboutCompanyToolStripMenuItem.Text = "A&bout {Company}"
        '
        'TrayIcon
        '
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "{ApplicationName}"
        Me.TrayIcon.Visible = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusAppName, Me.ToolStripStatusLabel1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 655)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(878, 25)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusAppName
        '
        Me.ToolStripStatusAppName.Name = "ToolStripStatusAppName"
        Me.ToolStripStatusAppName.Size = New System.Drawing.Size(136, 20)
        Me.ToolStripStatusAppName.Text = "{ApplicationName}"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(727, 20)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "{qTV Status}"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 680)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(421, 521)
        Me.Name = "MainForm"
        Me.Text = "{ApplicationName}"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutCompanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusAppName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DirEntry As System.DirectoryServices.DirectoryEntry
    Friend WithEvents SaveLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MediaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUrlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCommandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

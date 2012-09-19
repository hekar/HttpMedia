Imports System.ComponentModel

Public Class MainForm

    ' Changed to false to show UI on start
    Private firstload As Boolean = False

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MiscUI.CenterWindow(Me)
        Try
            Main.Main()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MainForm_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If firstload Then
            Hide()
        End If

        firstload = False
    End Sub

    ' Tray icon stuff
    Private Sub trayicon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayIcon.Click, TrayIcon.DoubleClick
        If Not Visible Then
            Show()
            Activate()
        Else
            Hide()
        End If
    End Sub

    Private Sub trayicon_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrayIcon.MouseMove
        If Not TrayIcon.Visible Then
            TrayIcon.ShowBalloonTip(10, "TBrowserControl Settings", "Click This to show the settings panel", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem1.Click
        SettingsWindow.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dispose()
    End Sub

    Private Sub AddFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFileToolStripMenuItem.Click
        Logger.DebugOutput("Adding File...")
    End Sub

    Private Sub AddUrlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUrlToolStripMenuItem.Click
        Logger.DebugOutput("Adding Url...")
    End Sub

    Private Sub AddFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFolderToolStripMenuItem.Click
        Logger.DebugOutput("Adding Folder...")
    End Sub

    Private Sub AddCommandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCommandToolStripMenuItem.Click

    End Sub

    Private Sub CommandSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutDialog.Show()
    End Sub

    Private Sub AboutCompanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutCompanyToolStripMenuItem.Click
        AboutCompanyDialog.Show()
    End Sub

End Class
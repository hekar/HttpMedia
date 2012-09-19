Imports System.Windows.Forms

Public Class SettingsWindow

    Private Sub SettingsWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MiscUI.CenterWindow(Me)
        ' Init the tab pages
        InitAuthenticationPage()
        InitializeScreenPage()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Hide()
    End Sub

    ' Authentication Tab Page
    Private Enum AccessMode
        Anonymous = 0
        User
    End Enum

    Private Const kAccessLabelAnonymous As String = "Username/Password Disabled"
    Private Const kAccessLabelUser As String = "Username/Password Enabled"
    Private Const kPasswordsMatch As String = "Match"
    Private Const kPasswordsDontMatch As String = "Does not Match"
    Private _matched As Boolean = True

    Private Sub InitAuthenticationPage()
        AccessTypeLabel.Text = kAccessLabelAnonymous
        LoginType.SelectedIndex = AccessMode.Anonymous
        CheckPasswordsMatched()
    End Sub

    Private Sub SetMode(ByVal mode As AccessMode)
        If mode = AccessMode.Anonymous Then
            UsernameLabel.Enabled = False
            UsernameBox.Enabled = False
            PasswordLabel.Enabled = False
            PasswordBox.Enabled = False
            PasswordRepeatLabel.Enabled = False
            PasswordRepeatBox.Enabled = False
            MatchLabel.Enabled = False
            AccessTypeLabel.Text = kAccessLabelAnonymous
        ElseIf mode = AccessMode.User Then
            UsernameLabel.Enabled = True
            UsernameBox.Enabled = True
            PasswordLabel.Enabled = True
            PasswordBox.Enabled = True
            PasswordRepeatLabel.Enabled = True
            PasswordRepeatBox.Enabled = True
            MatchLabel.Enabled = True
            AccessTypeLabel.Text = kAccessLabelUser
        End If
    End Sub

    Private Function CheckPasswordsMatched() As Boolean
        ' Check if the contents match
        If PasswordBox.Text = PasswordRepeatBox.Text Then
            MatchLabel.Text = kPasswordsMatch
            MatchLabel.ForeColor = Color.DarkGreen
            Return True
        Else
            MatchLabel.Text = kPasswordsDontMatch
            MatchLabel.ForeColor = Color.IndianRed
            Return False
        End If
    End Function

    Private Sub LoginType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginType.SelectedIndexChanged
        Dim mode As AccessMode = CType(LoginType.SelectedIndex, AccessMode)
        If mode = AccessMode.Anonymous Or mode = AccessMode.User Then
            SetMode(mode)
        End If
    End Sub

    Private Sub UsernameBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameBox.Leave
        ' Make sure the username is correct
        ' Then save it
    End Sub

    Private Sub PasswordBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordBox.TextChanged
        If CheckPasswordsMatched() Then
            ' Save the passwords
        End If
    End Sub

    Private Sub PasswordRepeatBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordRepeatBox.TextChanged
        If CheckPasswordsMatched() Then
            ' Save the passwords
        End If
    End Sub

    ' End Authentication Tab Page

    ' Screen Tab Page

    Public Sub InitializeScreenPage()
        For i As Integer = Screen.AllScreens.GetLowerBound(0) To Screen.AllScreens.GetUpperBound(0)
            DefaultMonitorCombo.Items.Add(i)
        Next i

        DefaultMonitorCombo.SelectedIndex = 0
    End Sub

    Private Sub DefaultMonitorCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultMonitorCombo.SelectedIndexChanged
        ' Save settings
    End Sub

    Private Sub FullscreenCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullscreenCheck.CheckedChanged
        ' Save Settings
    End Sub

    ' End Screen Tab Page

End Class

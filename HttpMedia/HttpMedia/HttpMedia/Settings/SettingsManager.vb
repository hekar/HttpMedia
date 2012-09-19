' Houses the settings under a global singleton
Public Class SettingsManager

    ' 
    Private Const kSettingsFilename As String = "xml/settings.xml"
    Private Const kSettingsNamespace As String = "settings"
    Private _settings As Settings

    Public Sub New()
        _settings = New Settings(kSettingsFilename, kSettingsNamespace, False)
    End Sub

    Public ReadOnly Property Settings As Settings
        Get
            Return _settings
        End Get
    End Property

    Private Shared gSettingManager As New SettingsManager
    Public Shared Function GetSettingsManager() As SettingsManager
        Return gSettingManager
    End Function

End Class

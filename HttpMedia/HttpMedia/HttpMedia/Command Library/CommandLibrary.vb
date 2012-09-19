Imports System.Xml
Imports System.Text

' Stores shortened names for system commands (meant for embedding commands into html)
Public Class CommandLibrary
    Inherits Settings

    Public Sub New()
        MyBase.New("xml/commands.xml", "commands", False)
        SetCommand("firefox", "C:\Program Files\Mozilla Firefox\firefox.exe")
    End Sub

    Public Sub SetCommand(ByRef command_key As String, ByRef value As String)
        MyBase.SetTrait(command_key, value)
    End Sub

    Public Function GetCommand(ByRef command_key As String) As String
        Return MyBase.GetTrait(command_key)
    End Function

    ' Execute a command in the background
    Public Sub ExecuteCommand(ByRef command_key As String)
        Dim startinfo As New ProcessStartInfo()
        startinfo.FileName = GetCommand(command_key)
        Dim proc As Process = BackgroundApplication.RunBackgroundProcess(startinfo)
    End Sub

End Class

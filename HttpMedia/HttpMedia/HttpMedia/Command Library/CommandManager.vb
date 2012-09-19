' Houses commmands under singleton
Public Class CommandManager

    Private _commandlist As CommandLibrary

    Public Sub New()
        _commandlist = New CommandLibrary()
    End Sub

    Public ReadOnly Property CommandList As CommandLibrary
        Get
            Return _commandlist
        End Get
    End Property

    Private Shared gCommandManager As New CommandManager
    Public Shared Function GetCommandManager() As CommandManager
        Return gCommandManager
    End Function

    Public Shared Function GetCommandLibrary() As CommandLibrary
        Return gCommandManager.CommandList
    End Function

End Class

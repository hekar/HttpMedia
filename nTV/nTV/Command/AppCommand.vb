' IPC Command
Public Class AppCommand

    Private _command As String
    Private _args As List(Of String)

    Public Sub New(ByRef command As String, Optional ByRef args As List(Of String) = Nothing)
        _command = command

        If args Is Nothing Then
            _args = New List(Of String)
        Else
            _args = args
        End If
    End Sub

    Public ReadOnly Property Name As String
        Get
            Return _command
        End Get
    End Property

    Public ReadOnly Property Arguments As List(Of String)
        Get
            Return _args
        End Get
    End Property

    Public ReadOnly Property ArgumentCount As Integer
        Get
            Return _args.Count
        End Get
    End Property

    Public Function GetArgument(ByVal index As Integer) As String
        Try
            Return _args.ElementAt(index)
        Catch ex As IndexOutOfRangeException
            Return 0
        End Try
    End Function

End Class


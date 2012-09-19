Imports System.Collections.Generic
Public Class Logger
    Implements IDisposable

    ' Directory for log entries (none right now)
    Private Const kLogDir As String = ""
    Private Const kDebugging = True

    ' Output file for log
    Private _out As IO.StreamWriter
    Private _filename As String
    Private _logname As String

    Public Sub New(ByRef filename As String, Optional ByRef logname As String = "")
        _filename = filename

        If logname = "" Then
            logname = filename
        End If

        _logname = logname

        _out = New IO.StreamWriter(filename)
        _out.AutoFlush = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        _out.Close()
    End Sub

    Public Sub WriteStr(ByRef text As String)
        _out.WriteLine(text)
    End Sub

    Private Shared loggers As New Dictionary(Of String, Logger)
    Public Shared Function GetLogger(ByRef logtype As String) As Logger
        If Not loggers.ContainsKey(logtype) Then
            loggers.Add(logtype, New Logger(kLogDir & logtype & ".txt", logtype.ToUpper()))
        End If

        Return loggers(logtype)
    End Function

    Public Shared Sub MessageOutput(ByRef out As String)
        GetLogger("message").WriteStr(out)
    End Sub

    Public Shared Sub ErrorOutput(ByRef out As String)
        GetLogger("error").WriteStr(out)
    End Sub

    Public Shared Sub WarningOutput(ByRef out As String)
        GetLogger("warning").WriteStr(out)
    End Sub

    Public Shared Sub DebugOutput(ByRef out As String)
        If kDebugging Then
            GetLogger("debug").WriteStr(out)
        End If
    End Sub

End Class

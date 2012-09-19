Imports System.Text
Imports System.Threading

Public Class MediaRunner
    Implements IDisposable

    Private Const knTVFilename As String = "nTV.exe"
    Private Const knTVWorkingDirectory As String = "C:\Users\hekar\Documents\Visual Studio 2010\Projects\nTV\nTV\bin\Debug"
    Private Const knTVFullPath As String = knTVWorkingDirectory & "/" & knTVFilename

    Private _process As Process
    Public Sub New()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        If _process Is Nothing Then
            ' pass through
        Else
            If Running Then
                _process.Kill()
            End If
        End If
    End Sub

    Public Sub StartTMedia()
        ' Only start it if it's not running
        If Not Running Then
            Dim procinfo As New ProcessStartInfo()
            procinfo.FileName = knTVFullPath
            procinfo.WorkingDirectory = knTVWorkingDirectory

            ' Fire Up nTV
            _process = Process.Start(procinfo)
        End If
    End Sub

    ReadOnly Property Running As Boolean
        Get
            If _process Is Nothing Then
                Return False
            End If

            Return Not _process.HasExited
        End Get
    End Property
End Class

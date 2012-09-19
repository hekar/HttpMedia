Imports System.Threading

' Runs an application in the background
Public Class BackgroundApplication

    Private _procinfo As ProcessStartInfo
    Private _process As New Process
    Private _lock As New Mutex
    Private Sub New(ByRef procinfo As ProcessStartInfo)
        _procinfo = procinfo
        RunApplication()
    End Sub

    Private Sub RunApplication()
        _lock.WaitOne()
        _process = Process.Start(_procinfo)
        _lock.ReleaseMutex()
    End Sub

    ReadOnly Property BackgroundProcess As Process
        Get
            ' Don't return the background process until it's running
            _lock.WaitOne()
            Return _process
            _lock.ReleaseMutex()
        End Get
    End Property

    Public Shared Function RunBackgroundProcess(ByRef procinfo As ProcessStartInfo) As Process
        Dim bgapprunner As New BackgroundApplication(procinfo)
        Return bgapprunner.BackgroundProcess
    End Function

End Class

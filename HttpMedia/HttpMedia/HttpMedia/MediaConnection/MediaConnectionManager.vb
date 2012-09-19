Public Class MediaConnectionManager

    ' Runs the media player application
    Private Shared s_mediarunner As MediaRunner

    ' Issues commands to the media player
    Private Shared s_mediaconn As MediaCommander

    Public Shared ReadOnly Property MediaConnection As MediaCommander
        Get
            Return s_mediaconn
        End Get
    End Property

    Public Shared Sub Initialize()
        ' Create the media player piping
        s_mediarunner = New MediaRunner()
        s_mediaconn = New MediaCommander(s_mediarunner)
    End Sub

    Public Shared Sub CleanUp()
        s_mediarunner.Dispose()
        s_mediaconn.Dispose()
    End Sub

End Class

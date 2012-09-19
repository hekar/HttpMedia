Public Class VideoCommands
    Implements IAppCommandListener

    Public Sub OnCommand(ByRef comm As AppCommand) Implements IAppCommandListener.OnCommand

        If comm.Name.IndexOf("video_play_") >= 0 Then
            ' Search for either a number or the video name
            Dim mediaid As String = comm.Name.Replace("video_play_", "")
            ' Play that specific media

            ' ...

        ElseIf comm.Name.IndexOf("video_play") >= 0 Then
            Try
                nTV.Play()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf comm.Name.IndexOf("video_pause") >= 0 Then
            nTV.Pause()
        ElseIf comm.Name.IndexOf("video_stop") >= 0 Then
            nTV.StopPlaying()
        ElseIf comm.Name.IndexOf("application_close") >= 0 Then
            MessageBox.Show("Closing")
            nTV.ExitApplication()
        End If
    End Sub

End Class

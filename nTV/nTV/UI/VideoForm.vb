Imports WMPLib
Imports System.Threading
Public Class nTV

    ' Window variables
    Private _fullscreen As Boolean = False
    Private _currentmonitor As Integer
    Private _lastbounds As Rectangle
    Public x As New CrossAppDomainDelegate(AddressOf StopPlaying)

    Public Sub SetMonitor(ByVal index As Integer)
        ' Check if the index is actually inbounds
        If index >= Screen.AllScreens.GetLowerBound(0) And _
            index < Screen.AllScreens.GetUpperBound(0) Then
            ' Switch over to the monitor
            _currentmonitor = index

            ' Quick hack to resetup everything
            SetFullscreen(_fullscreen)
        End If
    End Sub

    Public Sub SetFullscreen(ByVal fullscreen As Boolean)
        If Not _fullscreen Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim screensize As Rectangle = Screen.AllScreens(_currentmonitor).Bounds
            _lastbounds = Bounds
            Bounds = screensize
            _fullscreen = True
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Bounds = _lastbounds
            _fullscreen = False
        End If
    End Sub

    Public Enum MediaType
        None = 0
        Video
        Music
        ' Picture
    End Enum

    Public Sub PlayMedia(ByRef url As String, Optional ByVal mediatype As MediaType = MediaType.None)
        axMediaPlayer.currentMedia = axMediaPlayer.newMedia(url)
        Play()
    End Sub

    Public Sub Play()
        axMediaPlayer.Ctlcontrols.play()
        MessageBox.Show("Playing")
    End Sub

    Public Sub Pause()
        axMediaPlayer.Ctlcontrols.pause()
        MessageBox.Show("Pausing")
    End Sub

    Public Sub StopPlaying()
        Try
            ' axMediaPlayer.Ctlcontrols.stop
            MessageBox.Show("Stopping")
            axMediaPlayer.Ctlcontrols.stop()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Whether something is playing or not
    Public ReadOnly Property Playing As Boolean
        Get
            Return axMediaPlayer.playState.Equals(WMPPlayState.wmppsPlaying)
        End Get
    End Property

    Public Sub ExitApplication()
        _Timer.Dispose()
        _CommandListener.Dispose()
        Application.Exit()
    End Sub

    ' Socket command listener, etc
    Private _CommandListener As New AppCommandDispatcher
    Private _LastTime As Integer = 0

    ' Winform's single-threaded timer
    Private _Timer As New System.Windows.Forms.Timer()

    Private Sub UpdateCommandListener()
        _CommandListener.CheckForMessage()
    End Sub

    Private Sub nTV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Current Monitor defaults to the primary monitor (0)
        _currentmonitor = 0
        _lastbounds = Bounds

        PlayMedia("C:\Users\hekar\Videos\[a4e]Wolfs_Rain_01-30\[a4e]Wolf's_Rain_03[divx5.1.1].mkv")

        ' Interval in milliseconds
        _Timer.Interval = 2000
        AddHandler _Timer.Tick, AddressOf UpdateCommandListener
        _Timer.Start()

        Dim videocommands As New VideoCommands()
        _CommandListener.AddCommandListener(videocommands)
    End Sub

    Private Sub nTV_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ExitApplication()
    End Sub

    Private Sub axMediaPlayer_ClickEvent_1(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles axMediaPlayer.ClickEvent
        SetFullscreen(Not _fullscreen)
    End Sub

    Private Sub axMediaPlayer_KeyUpEvent_1(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_KeyUpEvent) Handles axMediaPlayer.KeyUpEvent
        If e.nKeyCode = Keys.Escape Or e.nKeyCode = Keys.Q Then
            ExitApplication()
        ElseIf e.nKeyCode = Keys.F Then
            SetFullscreen(Not _fullscreen)
        ElseIf e.nKeyCode = Keys.Space Then
            If Playing Then
                Pause()
            Else
                Play()
            End If
        ElseIf e.nKeyCode = Keys.Pause Then
            Pause()
        ElseIf e.nKeyCode = Keys.D1 Then
            SetMonitor(0)
        ElseIf e.nKeyCode = Keys.D2 Then
            SetMonitor(1)
        ElseIf e.nKeyCode = Keys.D3 Then
            SetMonitor(2)
        End If
    End Sub
End Class

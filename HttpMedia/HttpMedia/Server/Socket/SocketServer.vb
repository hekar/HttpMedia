Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class SocketServer
    Implements IDisposable

    ' Socket information
    Private _socket As Socket
    Private _serveruis As New Generic.List(Of ISocketListener)
    Private Const kDefaultPort = 9080
    Private Const kMaxConn = 5

    ' Should the server keep listening?
    Private _running As Boolean = True
    Private _thread As Thread

    Public Sub New()
        Init()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        _running = False

        If _socket.Connected Then
            _socket.Disconnect(False)
        End If

        ' Dispose of any blocking functionality
        _socket.Dispose()

        ' Terminate the thread
        _thread.Abort()
    End Sub

    Private Sub Init()
        _socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    End Sub

    Public Sub Bind(Optional ByVal port As Integer = kDefaultPort)
        _socket.Bind(New IPEndPoint(0, port))
        _socket.Listen(kMaxConn)

        For Each e As ISocketListener In _serveruis
            e.OnBind(Me)
        Next
    End Sub

    Public Sub AddServerUI(ByRef serverui As ISocketListener)
        _serveruis.Add(serverui)
    End Sub

    Private _clientconn As Socket
    Private Sub ListenLoop()

        While _running
            Dim buffer(1024) As Byte ' our buffer

            _clientconn = _socket.Accept()

            If _clientconn.Connected Then
                _clientconn.Receive(buffer, buffer.Length, SocketFlags.None)

                For Each e As ISocketListener In _serveruis
                    e.OnRecieve(Me, buffer)
                Next

                ' Close immediately
                _clientconn.Close()

                For Each e As ISocketListener In _serveruis
                    e.OnConnectionClose(Me)
                Next
            End If
        End While

    End Sub

    Public Sub Send(ByRef buffer() As Byte)
        _clientconn.Send(buffer)
    End Sub

    ' Add event handlers and stuff

    ' Runs listenloop without threading
    Public Sub RunNonThreaded()
        ListenLoop()
    End Sub

    Public Sub RunThreaded()
        _thread = New Thread(AddressOf ListenLoop)
        _thread.Start()
    End Sub

End Class

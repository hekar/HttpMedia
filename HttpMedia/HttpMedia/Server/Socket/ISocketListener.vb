' Interface for Socket user interfaces to inherit from
Public Interface ISocketListener

    Sub OnBind(ByRef socketserver As SocketServer)
    Sub OnRecieve(ByRef socketserver As SocketServer, ByRef buffer() As Byte)
    Sub OnConnectionClose(ByRef socketserver As SocketServer)

End Interface

Imports TBrowserController.Http

Public Class Main

    ' The socketserver that listens for requests
    Shared s_socketserver As SocketServer

    ' Http server elements
    Shared s_httpserver As ISocketListener
    Shared s_httpfilesystem As Filesystem
    Shared s_httpprocessor As Processor
    Shared s_httpresponder As Responder

    Public Shared Sub Main()
        MediaConnectionManager.Initialize()

        ' Start the socket server
        s_socketserver = New SocketServer()

        ' Initialize the Http Server helpers
        s_httpfilesystem = New Filesystem()
        s_httpprocessor = New Processor()
        s_httpresponder = New Responder(s_httpfilesystem)

        ' Initialize the http server
        s_httpserver = New HttpServer(s_httpresponder, s_httpprocessor)

        ' Add the Http server to the SocketServer's listener list
        s_socketserver.AddServerUI(s_httpserver)
        s_socketserver.Bind()
        s_socketserver.RunThreaded()
    End Sub

    Public Shared Sub CleanUp()
        ' Dispose of required resources
        s_socketserver.Dispose()
        MediaConnectionManager.CleanUp()
    End Sub

End Class

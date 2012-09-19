Imports System.Text

Namespace Http
    Public Class HttpServer
        Implements ISocketListener

        ' Default Index Page
        Private Const kIndexPage As String = "html/simple_home.html"

        ' Start in root directory
        Public Shared s_currentdir As String = "/"

        Private _responder As Responder
        Private _processor As Processor

        Public Sub New(ByRef responder As Responder, ByRef processor As Processor)
            _responder = responder
            _processor = processor
        End Sub

        Public Sub OnBind(ByRef socketserver As SocketServer) Implements ISocketListener.OnBind
        End Sub

        Public Sub OnConnectionClose(ByRef socketserver As SocketServer) Implements ISocketListener.OnConnectionClose
        End Sub

        Private _ascii As New ASCIIEncoding
        Private _lastresponse() As Byte
        Public Sub OnRecieve(ByRef socketserver As SocketServer, ByRef buffer() As Byte) Implements ISocketListener.OnRecieve
            Dim request As New Request(_ascii.GetString(buffer))
            Dim response As Byte() = _responder.Respond(request)

            Dim command_run As Boolean = False

            If request.RequestDataType = ExchangeDataType.TEXT Then
                ' Run the preprocessor on the HTML file (or TXT file)
                response = _processor.ProcessResource(response)
            ElseIf request.RequestDataType = ExchangeDataType.BINARY Then
            ElseIf request.RequestDataType = ExchangeDataType.COMMAND Then
                MediaConnectionManager.MediaConnection.SendCommand(request.UrlFilename.Replace(".command", ""))
                command_run = True
            ElseIf request.RequestDataType = ExchangeDataType.SYSCOMMAND Then
                CommandManager.GetCommandLibrary().ExecuteCommand(request.UrlFilename.Replace(".syscommand", ""))
                command_run = True
            End If

            If command_run Then
                If Not IsNothing(_lastresponse) Then
                    If _lastresponse.Count > 0 Then
                        socketserver.Send(_lastresponse)
                    End If
                End If
            Else
                socketserver.Send(response)
            End If

            _lastresponse = response
        End Sub
    End Class
End Namespace
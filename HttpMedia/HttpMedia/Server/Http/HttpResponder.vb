Imports System.IO

Namespace Http
    ' Responds to Http requests and issues commands to system
    Public Class Responder

        Private _filesystem As Filesystem
        Public Sub New(ByRef filesystem As Filesystem)
            _filesystem = filesystem
        End Sub

        ' Start in root directory
        Private _lastrequestdirectory As String = "/"
        ReadOnly Property LastRequestDirectory As String
            Get
                Return _lastrequestdirectory
            End Get
        End Property

        Private _lastrequestbinary As Boolean
        ReadOnly Property LastRequestBinary As Boolean
            Get
                Return _lastrequestbinary
            End Get
        End Property

        ' Create a header for the web browser
        Private Function CreateResponseHeader(ByRef request As String, ByRef response As String) As String
            Return ""
        End Function

        Private Function CalculateUrlDirectory(ByRef url As String) As String
            Dim lastslash As Integer = url.LastIndexOf("/")
            Dim urldir As String = url.Substring(0, lastslash - 1)

            Return urldir
        End Function

        Public Function Respond(ByRef request As Request) As Byte()

            ' Response to the web_browser
            Dim response() As Byte

            ' Key for the Http Filesystem (to get the response)
            Dim url As String = request.RelativeUrl
            response = _filesystem.GetResource(url)

            If url.EndsWith(".png") Then
                _lastrequestbinary = True
            Else
                _lastrequestbinary = False
            End If

            Return response
        End Function

    End Class
End Namespace
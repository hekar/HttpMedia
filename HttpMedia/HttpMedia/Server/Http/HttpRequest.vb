Imports System.IO

Namespace Http

    Public Enum HttpVersion
        HTTP1_0 = 0
        HTTP1_1
    End Enum

    Public Enum ExchangeDataType
        TEXT = 0
        BINARY
        COMMAND ' Request to issue a command
        SYSCOMMAND ' Request to run a system command
    End Enum

    ' GET HTTP Request
    Public Class Request
        Public Sub New(ByRef requestdata As String)
            _requestcontents = requestdata
            ParseRequestData(requestdata)
            If Not RelativeUrl.Equals("") Then
                _fileinfo = New FileInfo(_relativeurl)
            End If
        End Sub

        Private Sub ParseRequestData(ByRef requestdata As String)
            _relativeurl = GetRequestUrl(requestdata)

            ' Trim off whitespace
            _relativeurl = _relativeurl.Trim()

            Dim contents() As String = requestdata.Split(vbCrLf.ToCharArray())

            ' Grab the hostname
            _hostname = contents(1).Replace("Host: ", "")
            _useragent = contents(3).Replace("User-Agent: ", "")

            ' Determine the type of "File" requested
            If _relativeurl.EndsWith(".html") Or _relativeurl.EndsWith(".htm") Or
                _relativeurl.EndsWith(".txt") Then
                _requestdatatype = ExchangeDataType.TEXT
            ElseIf _relativeurl.EndsWith(".command") Then
                _requestdatatype = ExchangeDataType.COMMAND
            ElseIf _relativeurl.EndsWith(".syscommand") Then
                _requestdatatype = ExchangeDataType.SYSCOMMAND
            Else
                _requestdatatype = ExchangeDataType.BINARY
            End If
        End Sub

        ' Returns URL parsed from the request
        Private Function GetRequestUrl(ByRef request As String) As String

            ' Assume it's a bad url to start with
            Dim url As String = BaseHttpFilesystem.kErrorPage

            Dim firstline As String = request.Split(vbCrLf.ToCharArray())(0)
            Dim indexofhtml As Integer = firstline.IndexOf("HTTP")

            If indexofhtml > 0 Then
                url = firstline.Substring("GET".Length, indexofhtml - "HTTP".Length)
            End If

            url = url.Trim()

            If url = "/" Then
                ' This is the root, so give them the index page
                Return BaseHttpFilesystem.kIndexPage
            ElseIf url.StartsWith("/") Then
                url = url.Substring(1, url.Length - 1)
            ElseIf url.IndexOf(".ico") > 0 Then
                ' Return the webpage's icon
                Return BaseHttpFilesystem.kWebAppIcon
            End If

            Return url

        End Function

        Private _relativeurl As String
        ReadOnly Property RelativeUrl As String
            Get
                Return _relativeurl
            End Get
        End Property

        ReadOnly Property UrlDirectory As String
            Get
                ' Use the Url to calculate the UrlDirectory
                Dim lastslash As Integer = RelativeUrl.LastIndexOf("/")
                Dim urldir As String = RelativeUrl.Substring(0, RelativeUrl.Length - lastslash)

                MessageBox.Show("URLDIRECTORY: " & urldir)

                Return urldir
            End Get
        End Property

        ReadOnly Property FullUrl As String
            Get
                ' Calculate Full Url
                Return Hostname + "/" + RelativeUrl
            End Get
        End Property

        ' Get the leaf of the URL
        ReadOnly Property UrlFilename As String
            Get
                Dim lastslash As Integer = _relativeurl.LastIndexOf("/") + 1
                Dim leaf As String = _relativeurl.Substring(lastslash, _relativeurl.Length - lastslash)
                Return leaf
            End Get
        End Property

        ' Requested hostname
        Private _hostname As String
        ReadOnly Property Hostname As String
            Get
                Return _hostname
            End Get
        End Property

        Private _useragent As String
        ReadOnly Property UserAgent As String
            Get
                Return _useragent
            End Get
        End Property

        Private _fileinfo As FileInfo
        Property FileInformation As FileInfo
            Get
                Return _fileinfo
            End Get
            Set(ByVal value As FileInfo)
                _fileinfo = value
            End Set
        End Property

        Private _requestcontents As String
        ReadOnly Property RequestContents As String
            Get
                Return _requestcontents
            End Get
        End Property

        ReadOnly Property ValidUrl As Boolean
            Get
                Return Not IsNothing(_fileinfo)
            End Get
        End Property

        Private _requestdatatype As ExchangeDataType
        ReadOnly Property RequestDataType As ExchangeDataType
            Get
                Return _requestdatatype
            End Get
        End Property

    End Class
End Namespace
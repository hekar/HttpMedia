Imports System.IO
Imports System.Text

Namespace Http
    Public Class BaseHttpFilesystem

        Public Const kIndexPage As String = "html/index.html"
        Public Const kErrorPage As String = "html/error_404.html"
        Public Const kWebAppIcon As String = ""

        Private _acsii As New ASCIIEncoding()
        Public Function ToAscii(ByRef unicode As String) As Byte()
            Return _acsii.GetBytes(unicode)
        End Function

        Private _unicode As New UnicodeEncoding()
        Public Function ToUnicode(ByRef acsii As Byte()) As String
            Return _unicode.GetString(acsii)
        End Function

        Public Overridable Function GetResource(ByRef path As String) As Byte()
            Throw New InvalidOperationException("Base Class Function")
            Return Nothing
        End Function

    End Class

    ' Cached Http Filesystem
    Public Class CachedHttpFilesystem
        Inherits BaseHttpFilesystem

        ' Cached Resources
        Private _resources As Dictionary(Of String, Byte())

        Private _root As String
        Public Sub New(ByRef root As String)
            _root = root
        End Sub

        Private Sub PopulateFileList(ByRef root As String)

            ' Do a recursive search to get all files from the
            ' the 
            Dim files As List(Of FileInfo) = CheckDirectory(root)

        End Sub

        ' Returns a list of filenames from a recursive search
        Private Function CheckDirectory(ByRef folder As String) As List(Of FileInfo)
            Dim dir As New DirectoryInfo(folder)
            Dim files As List(Of FileInfo) = dir.GetFiles().ToList()

            For Each File As FileInfo In files

            Next

            Return files

        End Function
    End Class

    ' Stores File Resources for HTTP server
    Public Class Filesystem
        Inherits BaseHttpFilesystem

        Public Overrides Function GetResource(ByRef path As String) As Byte()
            ' Grab it from the filesystem

            Dim bad_resource(0) As Byte
            If path = "" Then
                Return bad_resource
            ElseIf path(0) = "/" Then
                path = path.Substring(1, path.Count - 1)
            End If

            Dim binary_file As Boolean = False
            If path.EndsWith(".png") Then
                binary_file = True
            End If

            'TODO: Create a file loader class
            Try
                Dim path_size As Integer = CType(New FileInfo(path).Length, Integer)
                Dim file_contents(path_size) As Byte
                If binary_file Then
                    Dim reader As New BinaryReader(New IO.FileStream(path, FileMode.Open))

                    For i As Integer = 0 To path_size - 1
                        file_contents(i) = reader.ReadByte()
                    Next

                    reader.Close()

                Else
                    Dim reader As New StreamReader(path)
                    file_contents = ToAscii(reader.ReadToEnd())
                    reader.Close()
                End If

                Return file_contents

            Catch ex As FileNotFoundException
                Return bad_resource
            Catch ex As UnauthorizedAccessException
                Return bad_resource
            End Try
        End Function

    End Class
End Namespace
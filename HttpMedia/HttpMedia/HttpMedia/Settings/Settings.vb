Imports System
Imports System.Threading
Imports System.Windows.Forms

' Stores settings in a keyvalue form that's ready for xml reading/writing
Public Class Settings

    ' Mutex the reads and writes to prevent dirty reads
    Private _mutex As New Mutex

    ' Dictionary to hold all the application settings
    Private _settings As New Dictionary(Of String, String)
    Private _headername As String

    ' Filepath of the xml file
    Public Property Filename As String

    Public Sub New(ByRef settingsfile As String, Optional ByRef headername As String = "settings", Optional ByVal LoadFile As Boolean = True)
        Filename = settingsfile
        _headername = headername

        ' Load the settings immediately, if asked of
        If LoadFile Then
            ReadFile(settingsfile)
        End If

    End Sub

    ' Read from an xml file
    Private Sub ReadFile(ByRef settingsfile As String)
        _mutex.WaitOne()

        ' Clear all settings before proceeding
        _settings.Clear()
        Try
            Dim xmlreader As New Xml.XmlTextReader(Filename)

            Try
                ' Read the XMLDoc header
                xmlreader.Read()

                ' Read through each element
                While xmlreader.Read()
                    If xmlreader.NodeType = Xml.XmlNodeType.Element Then
                        Dim name As String = xmlreader.Name
                        xmlreader.Read()
                        _settings.Add(name, xmlreader.ReadContentAsString())
                    End If
                End While
            Catch ex As Xml.XmlException
                ' pass through
                MessageBox.Show("Error in Parsing" & Filename)
            Finally
                xmlreader.Close()
            End Try
        Catch ex As IO.FileNotFoundException
            ' Pass through this
            Throw ex
        End Try

        _mutex.ReleaseMutex()
    End Sub

    ' Write to an xml file
    Private Sub WriteFile(ByRef settingsfile As String)
        _mutex.WaitOne()

        Dim xmlwriter As New Xml.XmlTextWriter(Filename, Text.Encoding.Unicode)
        xmlwriter.Formatting = Xml.Formatting.Indented
        Try
            ' Write the start of the document
            xmlwriter.WriteStartDocument()
            xmlwriter.WriteStartElement(_headername)

            Dim command As KeyValuePair(Of String, String)
            Dim enumerator As IDictionaryEnumerator = _settings.GetEnumerator()

            ' Write out each key and value
            While (enumerator.MoveNext())
                command = CType(enumerator.Current, KeyValuePair(Of String, String))
                xmlwriter.WriteElementString(command.Key, command.Value)
            End While

            ' End the document
            xmlwriter.WriteEndElement()
            xmlwriter.WriteEndDocument()

        Finally
            ' In case of an exception, finish writing anyway
            xmlwriter.Close()
        End Try

        _mutex.ReleaseMutex()
    End Sub

    Public Sub ReadFromXml()
        ReadFile(Filename)
    End Sub

    Public Sub WriteToXml()
        WriteFile(Filename)
    End Sub

    Public Sub SetTrait(ByRef key As String, ByRef value As String)
        ' Create key if it doesn't exist
        If Not _settings.ContainsKey(key) Then
            _settings.Add(key, value)
        Else
            _settings(key) = value
        End If
    End Sub

    Public Function GetTrait(ByRef key As String, Optional ByRef defaultvalue As String = "") As String
        ' Return default value if key is not found
        If _settings.ContainsKey(key) Then
            Return _settings(key)
        Else
            Return defaultvalue
        End If
    End Function

End Class

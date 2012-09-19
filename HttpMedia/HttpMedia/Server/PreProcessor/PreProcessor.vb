Imports System.IO
Imports System.Text

Public Interface IPreProcessTrait
    Function ApplyProcess(ByRef contents As String) As String
End Interface

' Runs PreProcess traits onto a file
Public Class PreProcessor

    ' Processed contents of file
    Private _processed As String

    ' Traits for preprocessing
    Private _traits As New Generic.List(Of IPreProcessTrait)

    Public Sub New()
    End Sub

    Public Sub AddProcessTrait(ByRef trait As IPreProcessTrait)
        _traits.Add(trait)
    End Sub

    Public Sub RemoveProcessTrait(ByRef trait As IPreProcessTrait)
        _traits.Remove(trait)
    End Sub

    Public Function ProcessFile(ByRef filename As String) As String
        ' Read in the input from the file
        Dim reader As New StreamReader(filename)
        Dim content As String = reader.ReadToEnd()
        reader.Close()

        Return ProcessString(content)
    End Function

    Private _ascii As New ASCIIEncoding()
    Public Function ProcessBytes(ByRef data() As Byte) As Byte()
        Dim content As String = _ascii.GetString(data)
        Return _ascii.GetBytes(ProcessString(content))
    End Function

    Public Function ProcessString(ByRef content As String) As String
        ' Actually Apply the preprocessing
        For Each trait As IPreProcessTrait In _traits
            _processed = trait.ApplyProcess(content)
        Next

        Return _processed
    End Function

    ReadOnly Property Processed As String
        Get
            Return _processed
        End Get
    End Property

End Class

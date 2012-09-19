Imports System.IO

' Adds the #include functionality to the PreProcessor
' Basically allows for
' <!-- #include("external_file.html") --->
' This inserts the contents of that file into a
' postprocessed version
Public Class IncludePreProcess
    Implements IPreProcessTrait

    Public Function ApplyProcess(ByRef contents As String) As String _
        Implements IPreProcessTrait.ApplyProcess

        Dim words As New List(Of String)(contents.Split().ToList())

        ' Iterate over each word
        For i As Integer = 0 To words.Count - 1
            Dim word As String = words(i)
            Dim indexofinclude As Integer = word.IndexOf("#include")

            ' If so, check for a parenthesis in the same word
            Dim firstparen As Integer = word.IndexOf("(")

            If indexofinclude < 0 Or firstparen < 0 Then
                Continue For
            End If

            If firstparen >= indexofinclude Then
                ' Extract the filename to be included
                Dim lastparen As Integer = word.IndexOf(")", indexofinclude)
                Dim filename As String = word.Substring(firstparen + 1, lastparen - firstparen - 1)

                filename = filename.Replace("""", "")

                Dim filereader As New IO.StreamReader(filename)
                Dim read_file As String = filereader.ReadToEnd()
                filereader.Close()

                words.Insert(i + 1, "<!--- INCLUDED --->")

                words.Insert(i + 2, read_file)
            End If
        Next

        Dim appender As New StringWriter()
        For i As Integer = 0 To words.Count - 1
            appender.Write(words(i))
            appender.WriteLine("")
        Next

        Dim result As String = appender.ToString()

        Return result

    End Function

End Class

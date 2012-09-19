Imports System.IO

Public Class ScriptPreProcess
    Implements IPreProcessTrait

    Private _scriptengine As New RubyScriptEngine()

    Public Sub New()
    End Sub

    Public Function ApplyProcess(ByRef contents As String) As String Implements IPreProcessTrait.ApplyProcess
        Dim variables As New Dictionary(Of String, Object)
        variables.Add("html", contents)

        Dim reader As New StreamReader("html/testscript.irb")
        Dim code As String = reader.ReadToEnd()
        reader.Close()

        _scriptengine.Execute(code, variables)
        contents = _scriptengine.GetVariable(Of String)("html").ToString()

        Return contents
    End Function
End Class

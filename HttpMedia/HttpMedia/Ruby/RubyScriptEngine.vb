Imports IronRuby
Imports IronRuby.Builtins
Imports Microsoft.Scripting.Hosting

Public Class RubyScriptEngine

    Dim _rubyruntime As ScriptRuntime
    Dim _rubyengine As ScriptEngine
    Dim _globalscope As ScriptScope

    Public Sub New()
        _rubyruntime = Ruby.CreateRuntime()
        _rubyengine = Ruby.CreateEngine()

        InitScope()
    End Sub

    Private Sub InitScope()
        _globalscope = _rubyengine.CreateScope()
    End Sub

    ' Executes a Ruby scripts and sets variables on it
    Public Sub Execute(ByRef code As String, ByRef variables As Dictionary(Of String, Object))
        For i As Integer = 0 To variables.Count() - 1
            Dim varname As String = variables.Keys(i)
            Dim value As Object = variables.Values(i)
            _globalscope.SetVariable(varname, value)
        Next

        Dim source As ScriptSource = _rubyengine.CreateScriptSourceFromString(code)

        source.Execute(_globalscope)
    End Sub

    Public Function GetVariable(ByRef varname As String) As Object
        Return _globalscope.GetVariable(varname)
    End Function

    Public Function GetVariable(Of T)(ByRef varname As String) As T
        Return _globalscope.GetVariable(Of T)(varname)
    End Function

End Class


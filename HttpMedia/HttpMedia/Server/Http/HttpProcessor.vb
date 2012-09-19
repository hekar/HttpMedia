Namespace Http
    ' Process files for Http Server (ie. run scripts, etc)
    Public Class Processor

        Private _preprocessor As New PreProcessor()
        Public Sub New()
            _preprocessor.AddProcessTrait(New ScriptPreProcess())
            _preprocessor.AddProcessTrait(New IncludePreProcess())
        End Sub

        Public Function ProcessResource(ByRef resource() As Byte) As Byte()
            Return _preprocessor.ProcessBytes(resource)
        End Function
    End Class
End Namespace
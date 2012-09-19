Imports System.Drawing
Imports System.Windows.Forms

Public Class MiscUI
    Public Shared Sub CenterWindow(ByRef window As Form)
        Dim rec As Rectangle = Screen.GetWorkingArea(window.Location)
        ' Center and then shift window to the left a little (better for bigger monitors)
        window.Location = New Point(
            CType(((rec.Right - window.Width - 90) / 2), Integer),
            CType(((rec.Bottom - window.Height) / 2), Integer))
    End Sub
End Class

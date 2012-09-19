Public Class AboutDialog

    Private Sub AboutDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MiscUI.CenterWindow(Me)
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

End Class
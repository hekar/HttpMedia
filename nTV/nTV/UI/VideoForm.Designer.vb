<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nTV
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nTV))
        Me.axMediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.axMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'axMediaPlayer
        '
        Me.axMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.axMediaPlayer.Enabled = True
        Me.axMediaPlayer.Location = New System.Drawing.Point(0, 0)
        Me.axMediaPlayer.Name = "axMediaPlayer"
        Me.axMediaPlayer.OcxState = CType(resources.GetObject("axMediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axMediaPlayer.Size = New System.Drawing.Size(437, 310)
        Me.axMediaPlayer.TabIndex = 0
        '
        'nTV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 310)
        Me.Controls.Add(Me.axMediaPlayer)
        Me.Name = "nTV"
        Me.Text = "nTV"
        Me.TopMost = True
        CType(Me.axMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents axMediaPlayer As AxWMPLib.AxWindowsMediaPlayer

End Class

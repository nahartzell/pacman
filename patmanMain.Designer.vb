<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patmanMain
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
        Me.components = New System.ComponentModel.Container()
        Me.SequenceTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'SequenceTimer
        '
        Me.SequenceTimer.Interval = 5
        '
        'patmanMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(959, 795)
        Me.MaximizeBox = False
        Me.Name = "patmanMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pat-Man"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SequenceTimer As System.Windows.Forms.Timer

End Class

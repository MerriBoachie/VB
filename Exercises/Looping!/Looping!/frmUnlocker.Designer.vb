<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnlocker
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.AliceBlue
        Me.btnStart.Location = New System.Drawing.Point(228, 43)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(220, 55)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Game Start! >:D"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'frmUnlocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(706, 151)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmUnlocker"
        Me.Text = "Try and guess my password! >:3c"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
End Class

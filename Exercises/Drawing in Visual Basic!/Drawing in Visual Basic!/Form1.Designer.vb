<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrawingShapes
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
        Me.btnDrawShapes = New System.Windows.Forms.Button()
        Me.btnDrawShip = New System.Windows.Forms.Button()
        Me.lblSurface = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDrawShapes
        '
        Me.btnDrawShapes.BackColor = System.Drawing.Color.LightPink
        Me.btnDrawShapes.Location = New System.Drawing.Point(22, 37)
        Me.btnDrawShapes.Name = "btnDrawShapes"
        Me.btnDrawShapes.Size = New System.Drawing.Size(123, 63)
        Me.btnDrawShapes.TabIndex = 1
        Me.btnDrawShapes.Text = "Draw some shapes bro!"
        Me.btnDrawShapes.UseVisualStyleBackColor = False
        '
        'btnDrawShip
        '
        Me.btnDrawShip.BackColor = System.Drawing.Color.LightPink
        Me.btnDrawShip.Location = New System.Drawing.Point(22, 136)
        Me.btnDrawShip.Name = "btnDrawShip"
        Me.btnDrawShip.Size = New System.Drawing.Size(123, 63)
        Me.btnDrawShip.TabIndex = 2
        Me.btnDrawShip.Text = "Or would you rather see something else...?"
        Me.btnDrawShip.UseVisualStyleBackColor = False
        '
        'lblSurface
        '
        Me.lblSurface.Location = New System.Drawing.Point(2, 0)
        Me.lblSurface.Name = "lblSurface"
        Me.lblSurface.Size = New System.Drawing.Size(543, 403)
        Me.lblSurface.TabIndex = 5
        Me.lblSurface.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(41, 306)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(162, 52)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDrawingShapes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(543, 402)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnDrawShip)
        Me.Controls.Add(Me.btnDrawShapes)
        Me.Controls.Add(Me.lblSurface)
        Me.Name = "frmDrawingShapes"
        Me.Text = "So you want to be an artist eh?"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDrawShapes As Button
    Friend WithEvents btnDrawShip As Button
    Friend WithEvents lblSurface As Label
    Friend WithEvents lblMessage As Label
End Class

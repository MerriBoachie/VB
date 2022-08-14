<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReasons
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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Azure
        Me.btnShow.Font = New System.Drawing.Font("Letter Gothic Std", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(72, 25)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(230, 56)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "Why take computer science???"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Letter Gothic Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(58, 97)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(263, 93)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReasons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(403, 244)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnShow)
        Me.Name = "frmReasons"
        Me.Text = "Why oh why...?"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShow As Button
    Friend WithEvents lblMessage As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTwinkle
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
        Me.lblPoem = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Lavender
        Me.btnShow.Location = New System.Drawing.Point(120, 35)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(138, 44)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "Show the poem!"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'lblPoem
        '
        Me.lblPoem.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblPoem.Font = New System.Drawing.Font("Harrington", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoem.Location = New System.Drawing.Point(67, 98)
        Me.lblPoem.Name = "lblPoem"
        Me.lblPoem.Size = New System.Drawing.Size(246, 224)
        Me.lblPoem.TabIndex = 1
        Me.lblPoem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTwinkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(380, 389)
        Me.Controls.Add(Me.lblPoem)
        Me.Controls.Add(Me.btnShow)
        Me.Name = "frmTwinkle"
        Me.Text = "Twinkle, Twinkle..."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShow As Button
    Friend WithEvents lblPoem As Label
End Class

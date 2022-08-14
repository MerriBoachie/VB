<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnnoy
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
        Me.btnAnnoy = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAnnoy
        '
        Me.btnAnnoy.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnAnnoy.Location = New System.Drawing.Point(79, 41)
        Me.btnAnnoy.Name = "btnAnnoy"
        Me.btnAnnoy.Size = New System.Drawing.Size(179, 62)
        Me.btnAnnoy.TabIndex = 0
        Me.btnAnnoy.Text = "Don't be annoying!!!"
        Me.btnAnnoy.UseVisualStyleBackColor = False
        '
        'lblOutput
        '
        Me.lblOutput.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(54, 143)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(236, 243)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAnnoy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(364, 450)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnAnnoy)
        Me.Name = "frmAnnoy"
        Me.Text = "So annoying ^^'..."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAnnoy As Button
    Friend WithEvents lblOutput As Label
End Class

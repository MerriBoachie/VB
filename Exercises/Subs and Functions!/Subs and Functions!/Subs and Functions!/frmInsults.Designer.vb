<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsults
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.Azure
        Me.btnGenerate.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(42, 35)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(267, 54)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Give me an insult!"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(45, 126)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(263, 159)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmInsults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(363, 331)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "frmInsults"
        Me.Text = "Don't be so rude...!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblMessage As Label
End Class

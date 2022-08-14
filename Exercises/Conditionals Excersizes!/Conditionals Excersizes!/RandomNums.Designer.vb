<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRandomNums
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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.GhostWhite
        Me.btnGenerate.Location = New System.Drawing.Point(84, 37)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(134, 44)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate a random number!"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(57, 105)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(191, 147)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRandomNums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(321, 274)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "frmRandomNums"
        Me.Text = "What will you get???"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblOutput As Label
End Class

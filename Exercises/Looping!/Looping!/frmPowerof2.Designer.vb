<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPowerof2
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnArray = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.MistyRose
        Me.btnCalculate.Location = New System.Drawing.Point(72, 31)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(95, 56)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Show me the powers of 2 !"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(69, 126)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(202, 270)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnArray
        '
        Me.btnArray.BackColor = System.Drawing.Color.MistyRose
        Me.btnArray.Location = New System.Drawing.Point(176, 31)
        Me.btnArray.Name = "btnArray"
        Me.btnArray.Size = New System.Drawing.Size(95, 56)
        Me.btnArray.TabIndex = 2
        Me.btnArray.Text = "Show me the powers of 2 ! (Array)"
        Me.btnArray.UseVisualStyleBackColor = False
        '
        'frmPowerof2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(351, 450)
        Me.Controls.Add(Me.btnArray)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmPowerof2"
        Me.Text = "Let's see the powers of 2!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnArray As Button
End Class

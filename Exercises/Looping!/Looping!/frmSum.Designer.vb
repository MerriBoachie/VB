<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSum
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
        Me.lblSumLimit = New System.Windows.Forms.Label()
        Me.txtSumLimit = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSumLimit
        '
        Me.lblSumLimit.Location = New System.Drawing.Point(41, 58)
        Me.lblSumLimit.Name = "lblSumLimit"
        Me.lblSumLimit.Size = New System.Drawing.Size(124, 30)
        Me.lblSumLimit.TabIndex = 0
        Me.lblSumLimit.Text = "What's the sum limit?"
        Me.lblSumLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSumLimit
        '
        Me.txtSumLimit.Location = New System.Drawing.Point(184, 64)
        Me.txtSumLimit.Name = "txtSumLimit"
        Me.txtSumLimit.Size = New System.Drawing.Size(81, 20)
        Me.txtSumLimit.TabIndex = 1
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(54, 120)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(210, 172)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.PaleGreen
        Me.btnCalculate.Location = New System.Drawing.Point(95, 327)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(122, 49)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Give me the sum!"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'frmSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(329, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtSumLimit)
        Me.Controls.Add(Me.lblSumLimit)
        Me.Name = "frmSum"
        Me.Text = "frmSum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSumLimit As Label
    Friend WithEvents txtSumLimit As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnCalculate As Button
End Class

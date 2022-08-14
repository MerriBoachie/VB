<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemainder
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
        Me.lblUpper = New System.Windows.Forms.Label()
        Me.lblDivisor = New System.Windows.Forms.Label()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUpper
        '
        Me.lblUpper.Location = New System.Drawing.Point(22, 42)
        Me.lblUpper.Name = "lblUpper"
        Me.lblUpper.Size = New System.Drawing.Size(158, 34)
        Me.lblUpper.TabIndex = 0
        Me.lblUpper.Text = "What's the upper limit???"
        Me.lblUpper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDivisor
        '
        Me.lblDivisor.Location = New System.Drawing.Point(22, 124)
        Me.lblDivisor.Name = "lblDivisor"
        Me.lblDivisor.Size = New System.Drawing.Size(158, 34)
        Me.lblDivisor.TabIndex = 1
        Me.lblDivisor.Text = "And the divisor???"
        Me.lblDivisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(237, 50)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(77, 20)
        Me.txtInput1.TabIndex = 2
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(237, 132)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(77, 20)
        Me.txtInput2.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(69, 208)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(215, 116)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.SeaShell
        Me.btnCalculate.Location = New System.Drawing.Point(96, 345)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(160, 50)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate!!!"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'frmRemainder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(355, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.lblDivisor)
        Me.Controls.Add(Me.lblUpper)
        Me.Name = "frmRemainder"
        Me.Text = "What's the remainder?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUpper As Label
    Friend WithEvents lblDivisor As Label
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnCalculate As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoccyMilk
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblServings = New System.Windows.Forms.Label()
        Me.lblLeftOver = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(27, 20)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(171, 80)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "How many ounces of chocolate milk do you need?"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(256, 51)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(86, 20)
        Me.txtInput.TabIndex = 1
        '
        'lblServings
        '
        Me.lblServings.Location = New System.Drawing.Point(404, 51)
        Me.lblServings.Name = "lblServings"
        Me.lblServings.Size = New System.Drawing.Size(211, 35)
        Me.lblServings.TabIndex = 2
        Me.lblServings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLeftOver
        '
        Me.lblLeftOver.Location = New System.Drawing.Point(404, 105)
        Me.lblLeftOver.Name = "lblLeftOver"
        Me.lblLeftOver.Size = New System.Drawing.Size(211, 35)
        Me.lblLeftOver.TabIndex = 3
        Me.lblLeftOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Linen
        Me.btnCalculate.Location = New System.Drawing.Point(84, 109)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(127, 49)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "How many servings is that???"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'frmChoccyMilk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(658, 204)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblLeftOver)
        Me.Controls.Add(Me.lblServings)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmChoccyMilk"
        Me.Text = "We have choccy milk!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblServings As Label
    Friend WithEvents lblLeftOver As Label
    Friend WithEvents btnCalculate As Button
End Class

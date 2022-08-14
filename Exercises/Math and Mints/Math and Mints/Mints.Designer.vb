<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMints
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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtEnter = New System.Windows.Forms.TextBox()
        Me.lblServings = New System.Windows.Forms.Label()
        Me.lblServing2 = New System.Windows.Forms.Label()
        Me.lblLeftOver2 = New System.Windows.Forms.Label()
        Me.lblLeftOver = New System.Windows.Forms.Label()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(22, 37)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(187, 26)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter the number of mints in the bag!"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(93, 78)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(34, 26)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.GreenYellow
        Me.btnCalculate.Location = New System.Drawing.Point(100, 158)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(109, 42)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "How many mints?"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtEnter
        '
        Me.txtEnter.Location = New System.Drawing.Point(215, 41)
        Me.txtEnter.Name = "txtEnter"
        Me.txtEnter.Size = New System.Drawing.Size(56, 20)
        Me.txtEnter.TabIndex = 4
        '
        'lblServings
        '
        Me.lblServings.Location = New System.Drawing.Point(22, 78)
        Me.lblServings.Name = "lblServings"
        Me.lblServings.Size = New System.Drawing.Size(65, 26)
        Me.lblServings.TabIndex = 5
        Me.lblServings.Text = "There are "
        Me.lblServings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblServing2
        '
        Me.lblServing2.Location = New System.Drawing.Point(133, 78)
        Me.lblServing2.Name = "lblServing2"
        Me.lblServing2.Size = New System.Drawing.Size(147, 26)
        Me.lblServing2.TabIndex = 7
        Me.lblServing2.Text = "servings of mints in this bag!"
        Me.lblServing2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLeftOver2
        '
        Me.lblLeftOver2.Location = New System.Drawing.Point(133, 116)
        Me.lblLeftOver2.Name = "lblLeftOver2"
        Me.lblLeftOver2.Size = New System.Drawing.Size(76, 26)
        Me.lblLeftOver2.TabIndex = 10
        Me.lblLeftOver2.Text = "mints left over!"
        Me.lblLeftOver2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLeftOver
        '
        Me.lblLeftOver.Location = New System.Drawing.Point(22, 116)
        Me.lblLeftOver.Name = "lblLeftOver"
        Me.lblLeftOver.Size = New System.Drawing.Size(65, 26)
        Me.lblLeftOver.TabIndex = 9
        Me.lblLeftOver.Text = "There are "
        Me.lblLeftOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput2
        '
        Me.lblOutput2.Location = New System.Drawing.Point(93, 116)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(34, 26)
        Me.lblOutput2.TabIndex = 8
        Me.lblOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(304, 222)
        Me.Controls.Add(Me.lblLeftOver2)
        Me.Controls.Add(Me.lblLeftOver)
        Me.Controls.Add(Me.lblOutput2)
        Me.Controls.Add(Me.lblServing2)
        Me.Controls.Add(Me.lblServings)
        Me.Controls.Add(Me.txtEnter)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmMints"
        Me.Text = "How many mints?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtEnter As TextBox
    Friend WithEvents lblServings As Label
    Friend WithEvents lblServing2 As Label
    Friend WithEvents lblLeftOver2 As Label
    Friend WithEvents lblLeftOver As Label
    Friend WithEvents lblOutput2 As Label
End Class

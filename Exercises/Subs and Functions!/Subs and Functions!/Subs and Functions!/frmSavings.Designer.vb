<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSavings
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
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(13, 48)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(227, 33)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter the amount you put in your savings per month!"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrompt2
        '
        Me.lblPrompt2.Location = New System.Drawing.Point(13, 123)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(227, 33)
        Me.lblPrompt2.TabIndex = 1
        Me.lblPrompt2.Text = "How many months did you deposit money into your savings?"
        Me.lblPrompt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(298, 59)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(77, 20)
        Me.txtInput.TabIndex = 2
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(298, 130)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(77, 20)
        Me.txtInput2.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCalculate.Location = New System.Drawing.Point(118, 186)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(171, 44)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Show me my savings!"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(75, 267)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(265, 78)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSavings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(416, 403)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmSavings"
        Me.Text = "It's important to save!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblMessage As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuessit
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
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(52, 24)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(146, 29)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Guess the secret number and try for a prize! :D"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInput
        '
        Me.lblInput.Location = New System.Drawing.Point(12, 69)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(146, 29)
        Me.lblInput.TabIndex = 1
        Me.lblInput.Text = "Enter your guess! (Pick a number between 1 and 11!)"
        Me.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(173, 76)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(55, 20)
        Me.txtInput.TabIndex = 2
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.Azure
        Me.btnCheck.Location = New System.Drawing.Point(73, 116)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(101, 43)
        Me.btnCheck.TabIndex = 3
        Me.btnCheck.Text = "Check my guess!"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(24, 181)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(204, 81)
        Me.lblMessage.TabIndex = 4
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGuessit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(255, 291)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmGuessit"
        Me.Text = "Guess the Number!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblMessage As Label
End Class

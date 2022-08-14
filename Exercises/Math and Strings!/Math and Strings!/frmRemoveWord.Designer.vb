<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemoveWord
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
        Me.txtInputPhrase = New System.Windows.Forms.TextBox()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.txtWordRemove = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(12, 19)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(182, 42)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a phrase or sentence!"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInputPhrase
        '
        Me.txtInputPhrase.Location = New System.Drawing.Point(244, 31)
        Me.txtInputPhrase.Name = "txtInputPhrase"
        Me.txtInputPhrase.Size = New System.Drawing.Size(239, 20)
        Me.txtInputPhrase.TabIndex = 1
        '
        'lblPrompt2
        '
        Me.lblPrompt2.Location = New System.Drawing.Point(12, 77)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(210, 42)
        Me.lblPrompt2.TabIndex = 2
        Me.lblPrompt2.Text = "Which word do you want to remove?"
        Me.lblPrompt2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtWordRemove
        '
        Me.txtWordRemove.Location = New System.Drawing.Point(244, 89)
        Me.txtWordRemove.Name = "txtWordRemove"
        Me.txtWordRemove.Size = New System.Drawing.Size(143, 20)
        Me.txtWordRemove.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(187, 156)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(296, 84)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.LightPink
        Me.btnRemove.Location = New System.Drawing.Point(15, 175)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(135, 47)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove the word!"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'frmRemoveWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(499, 312)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtWordRemove)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.txtInputPhrase)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmRemoveWord"
        Me.Text = "Remove a word!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtInputPhrase As TextBox
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents txtWordRemove As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnRemove As Button
End Class

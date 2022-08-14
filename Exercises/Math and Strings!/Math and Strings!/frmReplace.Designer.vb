<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReplace
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
        Me.lblPrompt1 = New System.Windows.Forms.Label()
        Me.txtInputWord = New System.Windows.Forms.TextBox()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.txtLetterReplaced = New System.Windows.Forms.TextBox()
        Me.lblPrompt3 = New System.Windows.Forms.Label()
        Me.txtReplacement = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt1
        '
        Me.lblPrompt1.Location = New System.Drawing.Point(12, 28)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(130, 32)
        Me.lblPrompt1.TabIndex = 0
        Me.lblPrompt1.Text = "Enter a word!"
        Me.lblPrompt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInputWord
        '
        Me.txtInputWord.Location = New System.Drawing.Point(173, 35)
        Me.txtInputWord.Name = "txtInputWord"
        Me.txtInputWord.Size = New System.Drawing.Size(149, 20)
        Me.txtInputWord.TabIndex = 1
        '
        'lblPrompt2
        '
        Me.lblPrompt2.Location = New System.Drawing.Point(12, 95)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(205, 32)
        Me.lblPrompt2.TabIndex = 2
        Me.lblPrompt2.Text = "Enter the letter you would like to replace:"
        Me.lblPrompt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLetterReplaced
        '
        Me.txtLetterReplaced.Location = New System.Drawing.Point(262, 102)
        Me.txtLetterReplaced.Name = "txtLetterReplaced"
        Me.txtLetterReplaced.Size = New System.Drawing.Size(60, 20)
        Me.txtLetterReplaced.TabIndex = 3
        '
        'lblPrompt3
        '
        Me.lblPrompt3.Location = New System.Drawing.Point(12, 172)
        Me.lblPrompt3.Name = "lblPrompt3"
        Me.lblPrompt3.Size = New System.Drawing.Size(205, 32)
        Me.lblPrompt3.TabIndex = 4
        Me.lblPrompt3.Text = "What letter would you like to replace it with?"
        Me.lblPrompt3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtReplacement
        '
        Me.txtReplacement.Location = New System.Drawing.Point(262, 172)
        Me.txtReplacement.Name = "txtReplacement"
        Me.txtReplacement.Size = New System.Drawing.Size(60, 20)
        Me.txtReplacement.TabIndex = 5
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(75, 305)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(202, 101)
        Me.lblOutput.TabIndex = 6
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.LightPink
        Me.btnCreate.Location = New System.Drawing.Point(78, 245)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(199, 45)
        Me.btnCreate.TabIndex = 7
        Me.btnCreate.Text = "Create my word!"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'frmReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(396, 450)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtReplacement)
        Me.Controls.Add(Me.lblPrompt3)
        Me.Controls.Add(Me.txtLetterReplaced)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.txtInputWord)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Name = "frmReplace"
        Me.Text = "Create a new word!! :o"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt1 As Label
    Friend WithEvents txtInputWord As TextBox
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents txtLetterReplaced As TextBox
    Friend WithEvents lblPrompt3 As Label
    Friend WithEvents txtReplacement As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnCreate As Button
End Class

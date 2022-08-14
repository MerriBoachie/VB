<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyInitials
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
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnShowInitials = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(3, 21)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(192, 32)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter your first and last names!"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(201, 28)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(160, 20)
        Me.txtInput.TabIndex = 1
        '
        'lblPrompt2
        '
        Me.lblPrompt2.Location = New System.Drawing.Point(52, 112)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(141, 60)
        Me.lblPrompt2.TabIndex = 2
        Me.lblPrompt2.Text = "Your initials are: "
        Me.lblPrompt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(220, 120)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(141, 44)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShowInitials
        '
        Me.btnShowInitials.BackColor = System.Drawing.Color.LightPink
        Me.btnShowInitials.Location = New System.Drawing.Point(159, 65)
        Me.btnShowInitials.Name = "btnShowInitials"
        Me.btnShowInitials.Size = New System.Drawing.Size(90, 35)
        Me.btnShowInitials.TabIndex = 4
        Me.btnShowInitials.Text = "Show me my initials!"
        Me.btnShowInitials.UseVisualStyleBackColor = False
        '
        'frmMyInitials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(448, 199)
        Me.Controls.Add(Me.btnShowInitials)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmMyInitials"
        Me.Text = "Get your initials!!!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnShowInitials As Button
End Class

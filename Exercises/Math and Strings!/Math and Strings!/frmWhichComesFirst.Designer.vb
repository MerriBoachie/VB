<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWhichComesFirst
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
        Me.btnShowMe = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShowMe
        '
        Me.btnShowMe.BackColor = System.Drawing.Color.LightPink
        Me.btnShowMe.Location = New System.Drawing.Point(64, 12)
        Me.btnShowMe.Name = "btnShowMe"
        Me.btnShowMe.Size = New System.Drawing.Size(193, 45)
        Me.btnShowMe.TabIndex = 0
        Me.btnShowMe.Text = "Which one comes first?!"
        Me.btnShowMe.UseVisualStyleBackColor = False
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(12, 84)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(157, 34)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Enter a word!"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrompt2
        '
        Me.lblPrompt2.Location = New System.Drawing.Point(12, 135)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(157, 34)
        Me.lblPrompt2.TabIndex = 2
        Me.lblPrompt2.Text = "Enter another word!"
        Me.lblPrompt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(159, 92)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(115, 20)
        Me.txtInput1.TabIndex = 3
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(159, 149)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(115, 20)
        Me.txtInput2.TabIndex = 4
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(64, 198)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(193, 83)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWhichComesFirst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(329, 318)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnShowMe)
        Me.Name = "frmWhichComesFirst"
        Me.Text = "Which word comes first?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowMe As Button
    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents lblOutput As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalStudents
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
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.lblPrompt3 = New System.Windows.Forms.Label()
        Me.lblPrompt4 = New System.Windows.Forms.Label()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.txtInput3 = New System.Windows.Forms.TextBox()
        Me.txtInput4 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt1
        '
        Me.lblPrompt1.Location = New System.Drawing.Point(33, 45)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(121, 40)
        Me.lblPrompt1.TabIndex = 0
        Me.lblPrompt1.Text = "How many students were in first period?"
        Me.lblPrompt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrompt2
        '
        Me.lblPrompt2.Location = New System.Drawing.Point(33, 102)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(121, 40)
        Me.lblPrompt2.TabIndex = 1
        Me.lblPrompt2.Text = "Second period?"
        Me.lblPrompt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrompt3
        '
        Me.lblPrompt3.Location = New System.Drawing.Point(33, 169)
        Me.lblPrompt3.Name = "lblPrompt3"
        Me.lblPrompt3.Size = New System.Drawing.Size(121, 40)
        Me.lblPrompt3.TabIndex = 2
        Me.lblPrompt3.Text = "Third period?"
        Me.lblPrompt3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrompt4
        '
        Me.lblPrompt4.Location = New System.Drawing.Point(33, 238)
        Me.lblPrompt4.Name = "lblPrompt4"
        Me.lblPrompt4.Size = New System.Drawing.Size(121, 40)
        Me.lblPrompt4.TabIndex = 3
        Me.lblPrompt4.Text = "Fourth period?"
        Me.lblPrompt4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(176, 56)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(79, 20)
        Me.txtInput1.TabIndex = 4
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(176, 113)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(79, 20)
        Me.txtInput2.TabIndex = 5
        '
        'txtInput3
        '
        Me.txtInput3.Location = New System.Drawing.Point(176, 180)
        Me.txtInput3.Name = "txtInput3"
        Me.txtInput3.Size = New System.Drawing.Size(79, 20)
        Me.txtInput3.TabIndex = 6
        '
        'txtInput4
        '
        Me.txtInput4.Location = New System.Drawing.Point(176, 249)
        Me.txtInput4.Name = "txtInput4"
        Me.txtInput4.Size = New System.Drawing.Size(79, 20)
        Me.txtInput4.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Honeydew
        Me.btnCalculate.Location = New System.Drawing.Point(86, 303)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(141, 40)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "What's the total?"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(58, 359)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(188, 82)
        Me.lblMessage.TabIndex = 9
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTotalStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(326, 460)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtInput4)
        Me.Controls.Add(Me.txtInput3)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.lblPrompt4)
        Me.Controls.Add(Me.lblPrompt3)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Name = "frmTotalStudents"
        Me.Text = "Help me to take the attendance!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt1 As Label
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents lblPrompt3 As Label
    Friend WithEvents lblPrompt4 As Label
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents txtInput3 As TextBox
    Friend WithEvents txtInput4 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblMessage As Label
End Class

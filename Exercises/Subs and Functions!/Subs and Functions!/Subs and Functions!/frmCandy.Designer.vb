<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCandy
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.txtInput3 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt1
        '
        Me.lblPrompt1.Location = New System.Drawing.Point(39, 39)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(164, 30)
        Me.lblPrompt1.TabIndex = 0
        Me.lblPrompt1.Text = "What's your favorite candy??"
        Me.lblPrompt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrompt2
        '
        Me.lblPrompt2.Location = New System.Drawing.Point(39, 84)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(164, 30)
        Me.lblPrompt2.TabIndex = 1
        Me.lblPrompt2.Text = "How many ounces to you want?"
        Me.lblPrompt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(39, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "What's the price per ounce?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(231, 45)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(82, 20)
        Me.txtInput.TabIndex = 3
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(231, 94)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(82, 20)
        Me.txtInput2.TabIndex = 4
        '
        'txtInput3
        '
        Me.txtInput3.Location = New System.Drawing.Point(231, 148)
        Me.txtInput3.Name = "txtInput3"
        Me.txtInput3.Size = New System.Drawing.Size(82, 20)
        Me.txtInput3.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnCalculate.Location = New System.Drawing.Point(116, 192)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(110, 42)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate the cost!"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(58, 254)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(255, 89)
        Me.lblMessage.TabIndex = 7
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCandy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(387, 388)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtInput3)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Name = "frmCandy"
        Me.Text = "Yay!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt1 As Label
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents txtInput3 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblMessage As Label
End Class

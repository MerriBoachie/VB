<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalPencils
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.lblPrompt1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(51, 208)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(188, 82)
        Me.lblMessage.TabIndex = 19
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Honeydew
        Me.btnCalculate.Location = New System.Drawing.Point(72, 154)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(141, 40)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "What's the total number of pencilsl??"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(175, 96)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(79, 20)
        Me.txtInput2.TabIndex = 15
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(175, 39)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(79, 20)
        Me.txtInput1.TabIndex = 14
        '
        'lblPrompt2
        '
        Me.lblPrompt2.Location = New System.Drawing.Point(32, 85)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(121, 40)
        Me.lblPrompt2.TabIndex = 11
        Me.lblPrompt2.Text = "How many pencils per student?"
        Me.lblPrompt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrompt1
        '
        Me.lblPrompt1.Location = New System.Drawing.Point(32, 28)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(121, 40)
        Me.lblPrompt1.TabIndex = 10
        Me.lblPrompt1.Text = "How many students were there?"
        Me.lblPrompt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTotalPencils
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(312, 306)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Name = "frmTotalPencils"
        Me.RightToLeftLayout = True
        Me.Text = "frmTotalPencils"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents lblPrompt1 As Label
End Class

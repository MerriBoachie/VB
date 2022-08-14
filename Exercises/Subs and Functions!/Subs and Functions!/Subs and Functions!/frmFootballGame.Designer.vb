<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFootballGame
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.lblPrompt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt1.Location = New System.Drawing.Point(28, 45)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(180, 21)
        Me.lblPrompt1.TabIndex = 0
        Me.lblPrompt1.Text = "Enter the first quarter points!"
        Me.lblPrompt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrompt2
        '
        Me.lblPrompt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt2.Location = New System.Drawing.Point(28, 102)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(202, 21)
        Me.lblPrompt2.TabIndex = 1
        Me.lblPrompt2.Text = "Enter the second quarter points!"
        Me.lblPrompt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter the third quarter points!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter the fourth quarter points!"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(250, 46)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(102, 20)
        Me.txtInput1.TabIndex = 4
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(250, 103)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(102, 20)
        Me.txtInput2.TabIndex = 5
        '
        'txtInput3
        '
        Me.txtInput3.Location = New System.Drawing.Point(250, 160)
        Me.txtInput3.Name = "txtInput3"
        Me.txtInput3.Size = New System.Drawing.Size(102, 20)
        Me.txtInput3.TabIndex = 6
        '
        'txtInput4
        '
        Me.txtInput4.Location = New System.Drawing.Point(250, 221)
        Me.txtInput4.Name = "txtInput4"
        Me.txtInput4.Size = New System.Drawing.Size(102, 20)
        Me.txtInput4.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Honeydew
        Me.btnCalculate.Location = New System.Drawing.Point(119, 279)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(147, 42)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "What's the total?!"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(72, 337)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(247, 98)
        Me.lblMessage.TabIndex = 9
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFootballGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(400, 473)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtInput4)
        Me.Controls.Add(Me.txtInput3)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Name = "frmFootballGame"
        Me.Text = "What's the score?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt1 As Label
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents txtInput3 As TextBox
    Friend WithEvents txtInput4 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblMessage As Label
End Class

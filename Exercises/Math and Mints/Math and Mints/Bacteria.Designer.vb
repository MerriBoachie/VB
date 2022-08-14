<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBacteria
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
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.txtInput3 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt1
        '
        Me.lblPrompt1.Location = New System.Drawing.Point(25, 25)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(139, 44)
        Me.lblPrompt1.TabIndex = 0
        Me.lblPrompt1.Text = "How many bacteria at the start??"
        Me.lblPrompt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrompt2
        '
        Me.lblPrompt2.Location = New System.Drawing.Point(25, 78)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(139, 27)
        Me.lblPrompt2.TabIndex = 1
        Me.lblPrompt2.Text = "What is the K value?"
        Me.lblPrompt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrompt3
        '
        Me.lblPrompt3.Location = New System.Drawing.Point(25, 118)
        Me.lblPrompt3.Name = "lblPrompt3"
        Me.lblPrompt3.Size = New System.Drawing.Size(139, 27)
        Me.lblPrompt3.TabIndex = 2
        Me.lblPrompt3.Text = "How many hours have passed?"
        Me.lblPrompt3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(192, 38)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(66, 20)
        Me.txtInput1.TabIndex = 3
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(192, 85)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(66, 20)
        Me.txtInput2.TabIndex = 4
        '
        'txtInput3
        '
        Me.txtInput3.Location = New System.Drawing.Point(192, 125)
        Me.txtInput3.Name = "txtInput3"
        Me.txtInput3.Size = New System.Drawing.Size(66, 20)
        Me.txtInput3.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Coral
        Me.btnCalculate.Location = New System.Drawing.Point(88, 172)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(109, 50)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "How many bacteria are there?"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(50, 242)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(184, 107)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBacteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(296, 406)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtInput3)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.lblPrompt3)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Name = "frmBacteria"
        Me.Text = " Bacteria Calculations! >:)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt1 As Label
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents lblPrompt3 As Label
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents txtInput3 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblOutput As Label
End Class

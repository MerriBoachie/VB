<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWindChill
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
        Me.lblPromptTemp = New System.Windows.Forms.Label()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.lblPromptWind = New System.Windows.Forms.Label()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPromptTemp
        '
        Me.lblPromptTemp.Location = New System.Drawing.Point(12, 28)
        Me.lblPromptTemp.Name = "lblPromptTemp"
        Me.lblPromptTemp.Size = New System.Drawing.Size(149, 28)
        Me.lblPromptTemp.TabIndex = 0
        Me.lblPromptTemp.Text = "What's the tempurature?"
        Me.lblPromptTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(167, 33)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(84, 20)
        Me.txtInput1.TabIndex = 1
        '
        'lblPromptWind
        '
        Me.lblPromptWind.Location = New System.Drawing.Point(12, 88)
        Me.lblPromptWind.Name = "lblPromptWind"
        Me.lblPromptWind.Size = New System.Drawing.Size(149, 28)
        Me.lblPromptWind.TabIndex = 2
        Me.lblPromptWind.Text = "And the wind speed?"
        Me.lblPromptWind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(167, 93)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(84, 20)
        Me.txtInput2.TabIndex = 3
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(39, 135)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(212, 69)
        Me.lblMessage.TabIndex = 4
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExecute
        '
        Me.btnExecute.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnExecute.Location = New System.Drawing.Point(85, 218)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(124, 59)
        Me.btnExecute.TabIndex = 5
        Me.btnExecute.Text = "Give me frostbite advice!"
        Me.btnExecute.UseVisualStyleBackColor = False
        '
        'frmWindChill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(306, 339)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.lblPromptWind)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.lblPromptTemp)
        Me.Name = "frmWindChill"
        Me.Text = "What's it like outside?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPromptTemp As Label
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents lblPromptWind As Label
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnExecute As Button
End Class

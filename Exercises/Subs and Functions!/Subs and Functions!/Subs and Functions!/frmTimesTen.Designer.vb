<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimesTen
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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(2, 21)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(118, 43)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a number!"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(142, 33)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(71, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(62, 76)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(125, 40)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Multiply by ten!"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(59, 140)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(128, 54)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTimesTen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(249, 211)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmTimesTen"
        Me.Text = "Multiply by ten!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnShow As Button
    Friend WithEvents lblOutput As Label
End Class

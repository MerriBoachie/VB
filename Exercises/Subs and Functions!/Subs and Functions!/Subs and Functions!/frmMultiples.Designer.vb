<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiples
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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(6, 32)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(151, 30)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a number!"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(163, 32)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(67, 20)
        Me.txtNumber.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.SeaShell
        Me.btnShow.Location = New System.Drawing.Point(92, 78)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(94, 46)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show me the multiples!"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(67, 147)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(154, 251)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMultiples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(299, 450)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmMultiples"
        Me.Text = "How many...?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnShow As Button
    Friend WithEvents lblOutput As Label
End Class

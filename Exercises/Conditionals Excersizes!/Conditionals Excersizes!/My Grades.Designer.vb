<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyGrades
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
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(32, 25)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(120, 23)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter your grade!"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(182, 25)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(52, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(82, 64)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(107, 39)
        Me.btnExecute.TabIndex = 2
        Me.btnExecute.Text = "Show me my letter grade!"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(52, 115)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(172, 106)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMyGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(291, 279)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmMyGrades"
        Me.Text = "How are ya doin' in school?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnExecute As Button
    Friend WithEvents lblMessage As Label
End Class

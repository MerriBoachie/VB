<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMotivation
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
        Me.btnShowMessage = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnShowMessage
        '
        Me.btnShowMessage.BackColor = System.Drawing.Color.LightCyan
        Me.btnShowMessage.Location = New System.Drawing.Point(37, 36)
        Me.btnShowMessage.Name = "btnShowMessage"
        Me.btnShowMessage.Size = New System.Drawing.Size(167, 51)
        Me.btnShowMessage.TabIndex = 0
        Me.btnShowMessage.Text = "Let's Get Motivated!!"
        Me.btnShowMessage.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Goudy Stout", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(12, 143)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(229, 275)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 53)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "How much motivation do you need? (Enter a number!):"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(182, 107)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(44, 20)
        Me.txtInput.TabIndex = 3
        '
        'frmMotivation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(253, 450)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnShowMessage)
        Me.Name = "frmMotivation"
        Me.Text = "Let's get this bread!!! >:D"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowMessage As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
End Class

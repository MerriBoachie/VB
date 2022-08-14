<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCellPhone
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(29, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the number of minutes you used!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(201, 44)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(74, 20)
        Me.txtInput.TabIndex = 1
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(60, 85)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(191, 138)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.Snow
        Me.btnTotal.Location = New System.Drawing.Point(87, 250)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(137, 43)
        Me.btnTotal.TabIndex = 3
        Me.btnTotal.Text = "What's the total?"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'frmCellPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(322, 366)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCellPhone"
        Me.Text = "Check your bill!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnTotal As Button
End Class

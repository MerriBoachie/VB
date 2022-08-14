<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowFoods
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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(155, 136)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(290, 94)
        Me.lblMessage.TabIndex = 10
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Azure
        Me.btnShow.Location = New System.Drawing.Point(362, 48)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(144, 58)
        Me.btnShow.TabIndex = 9
        Me.btnShow.Text = "Show your favorite foods!"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Azure
        Me.btnEnter.Location = New System.Drawing.Point(118, 48)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(144, 58)
        Me.btnEnter.TabIndex = 8
        Me.btnEnter.Text = "Enter your favorite foods!"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'frmShowFoods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(650, 276)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnEnter)
        Me.Name = "frmShowFoods"
        Me.Text = "Yum!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents btnEnter As Button
End Class

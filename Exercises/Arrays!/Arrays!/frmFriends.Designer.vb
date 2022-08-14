<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFriends
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
        Me.btnName = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnName
        '
        Me.btnName.BackColor = System.Drawing.Color.FloralWhite
        Me.btnName.Location = New System.Drawing.Point(47, 56)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(136, 51)
        Me.btnName.TabIndex = 0
        Me.btnName.Text = "What are their names??"
        Me.btnName.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.FloralWhite
        Me.btnShow.Location = New System.Drawing.Point(272, 56)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(136, 51)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "Say hey! :D"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(93, 125)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(263, 76)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFriends
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(475, 247)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnName)
        Me.Name = "frmFriends"
        Me.Text = "frmFriends"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnName As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents lblMessage As Label
End Class

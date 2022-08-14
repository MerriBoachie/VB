<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnterGrades
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Azure
        Me.btnEnter.Location = New System.Drawing.Point(65, 117)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(144, 58)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "Enter your grades!"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Azure
        Me.btnShow.Location = New System.Drawing.Point(265, 117)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(144, 58)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "Show your grades!!"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(97, 20)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(263, 86)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEnterGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(499, 208)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnEnter)
        Me.Name = "frmEnterGrades"
        Me.Text = "Tell me your scores!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents lblMessage As Label
End Class

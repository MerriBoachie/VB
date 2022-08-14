<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChat
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
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.tmrTalk = New System.Windows.Forms.Timer(Me.components)
        Me.picTalk = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        CType(Me.picTalk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Linen
        Me.btnStart.Location = New System.Drawing.Point(12, 38)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(113, 36)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Linen
        Me.btnStop.Location = New System.Drawing.Point(249, 38)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(113, 36)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop!"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'tmrTalk
        '
        Me.tmrTalk.Interval = 50
        '
        'picTalk
        '
        Me.picTalk.Image = Global.Pictures_.My.Resources.Resources.Face1
        Me.picTalk.Location = New System.Drawing.Point(50, 95)
        Me.picTalk.Name = "picTalk"
        Me.picTalk.Size = New System.Drawing.Size(264, 315)
        Me.picTalk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTalk.TabIndex = 2
        Me.picTalk.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(356, 175)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(191, 144)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(573, 450)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.picTalk)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmChat"
        Me.Text = "Talk to me!"
        CType(Me.picTalk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents tmrTalk As Timer
    Friend WithEvents picTalk As PictureBox
    Friend WithEvents lblMessage As Label
End Class

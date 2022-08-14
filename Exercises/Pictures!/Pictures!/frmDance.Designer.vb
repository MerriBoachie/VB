<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDance
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
        Me.picDance = New System.Windows.Forms.PictureBox()
        Me.tmrDance = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picDance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStart.Location = New System.Drawing.Point(139, 24)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(118, 37)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Dancing!"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'picDance
        '
        Me.picDance.Image = Global.Pictures_.My.Resources.Resources.win_1
        Me.picDance.Location = New System.Drawing.Point(72, 78)
        Me.picDance.Name = "picDance"
        Me.picDance.Size = New System.Drawing.Size(252, 258)
        Me.picDance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDance.TabIndex = 2
        Me.picDance.TabStop = False
        '
        'tmrDance
        '
        Me.tmrDance.Interval = 40
        '
        'frmDance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(403, 362)
        Me.Controls.Add(Me.picDance)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmDance"
        Me.Text = "Dance with me!!!"
        CType(Me.picDance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents picDance As PictureBox
    Friend WithEvents tmrDance As Timer
End Class

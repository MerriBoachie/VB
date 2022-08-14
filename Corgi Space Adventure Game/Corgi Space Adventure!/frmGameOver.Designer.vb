<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGameOver
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnTitle = New System.Windows.Forms.Button()
        Me.lblPromptGameOver = New System.Windows.Forms.Label()
        Me.lblScoreIs = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTitle
        '
        Me.btnTitle.BackColor = System.Drawing.Color.MistyRose
        Me.btnTitle.Font = New System.Drawing.Font("Gabriola", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTitle.Location = New System.Drawing.Point(435, 517)
        Me.btnTitle.Name = "btnTitle"
        Me.btnTitle.Size = New System.Drawing.Size(142, 60)
        Me.btnTitle.TabIndex = 1
        Me.btnTitle.Text = "Back to title"
        Me.btnTitle.UseVisualStyleBackColor = False
        '
        'lblPromptGameOver
        '
        Me.lblPromptGameOver.Font = New System.Drawing.Font("SimSun-ExtB", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptGameOver.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPromptGameOver.Location = New System.Drawing.Point(132, 9)
        Me.lblPromptGameOver.Name = "lblPromptGameOver"
        Me.lblPromptGameOver.Size = New System.Drawing.Size(340, 52)
        Me.lblPromptGameOver.TabIndex = 3
        Me.lblPromptGameOver.Text = "You Died!"
        Me.lblPromptGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScoreIs
        '
        Me.lblScoreIs.Font = New System.Drawing.Font("Gabriola", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreIs.Location = New System.Drawing.Point(139, 79)
        Me.lblScoreIs.Name = "lblScoreIs"
        Me.lblScoreIs.Size = New System.Drawing.Size(333, 39)
        Me.lblScoreIs.TabIndex = 4
        Me.lblScoreIs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiGameOver
        Me.PictureBox1.Location = New System.Drawing.Point(88, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(433, 348)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(620, 611)
        Me.Controls.Add(Me.lblScoreIs)
        Me.Controls.Add(Me.lblPromptGameOver)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnTitle)
        Me.Name = "frmGameOver"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTitle As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPromptGameOver As Label
    Friend WithEvents lblScoreIs As Label
End Class

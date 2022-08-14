<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoveMe
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
        Me.picCorgi = New System.Windows.Forms.PictureBox()
        Me.btnAcross = New System.Windows.Forms.Button()
        Me.tmrDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDiagonal = New System.Windows.Forms.Timer(Me.components)
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnDiagonal = New System.Windows.Forms.Button()
        Me.tmrAcross = New System.Windows.Forms.Timer(Me.components)
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picCorgi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCorgi
        '
        Me.picCorgi.Image = Global.Pictures_.My.Resources.Resources.corgiswimflip
        Me.picCorgi.Location = New System.Drawing.Point(12, 12)
        Me.picCorgi.Name = "picCorgi"
        Me.picCorgi.Size = New System.Drawing.Size(226, 240)
        Me.picCorgi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCorgi.TabIndex = 0
        Me.picCorgi.TabStop = False
        '
        'btnAcross
        '
        Me.btnAcross.BackColor = System.Drawing.Color.Azure
        Me.btnAcross.Location = New System.Drawing.Point(49, 304)
        Me.btnAcross.Name = "btnAcross"
        Me.btnAcross.Size = New System.Drawing.Size(122, 73)
        Me.btnAcross.TabIndex = 1
        Me.btnAcross.Text = "Move the doggy across!"
        Me.btnAcross.UseVisualStyleBackColor = False
        '
        'tmrDown
        '
        Me.tmrDown.Interval = 20
        '
        'tmrDiagonal
        '
        Me.tmrDiagonal.Interval = 50
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.Azure
        Me.btnDown.Location = New System.Drawing.Point(331, 304)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(122, 73)
        Me.btnDown.TabIndex = 2
        Me.btnDown.Text = "Move the doggy down!"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnDiagonal
        '
        Me.btnDiagonal.BackColor = System.Drawing.Color.Azure
        Me.btnDiagonal.Location = New System.Drawing.Point(628, 304)
        Me.btnDiagonal.Name = "btnDiagonal"
        Me.btnDiagonal.Size = New System.Drawing.Size(122, 73)
        Me.btnDiagonal.TabIndex = 3
        Me.btnDiagonal.Text = "Move the doggy diagonally!"
        Me.btnDiagonal.UseVisualStyleBackColor = False
        '
        'tmrAcross
        '
        Me.tmrAcross.Interval = 50
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(-1, 9)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(136, 48)
        Me.lblMessage.TabIndex = 4
        Me.lblMessage.Text = "Hello! :3"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Azure
        Me.Button1.Location = New System.Drawing.Point(331, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Bring the doggy back! ;'o"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmMoveMe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnDiagonal)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnAcross)
        Me.Controls.Add(Me.picCorgi)
        Me.Name = "frmMoveMe"
        Me.Text = "Move the doggy!"
        CType(Me.picCorgi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picCorgi As PictureBox
    Friend WithEvents btnAcross As Button
    Friend WithEvents tmrDown As Timer
    Friend WithEvents tmrDiagonal As Timer
    Friend WithEvents btnDown As Button
    Friend WithEvents btnDiagonal As Button
    Friend WithEvents tmrAcross As Timer
    Friend WithEvents lblMessage As Label
    Friend WithEvents Button1 As Button
End Class

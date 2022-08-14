<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTitleScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTitleTop = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picPlanet = New System.Windows.Forms.PictureBox()
        Me.picPlanet2 = New System.Windows.Forms.PictureBox()
        Me.btnGameStart = New System.Windows.Forms.Button()
        Me.picCorgiTitleSprite = New System.Windows.Forms.PictureBox()
        Me.tmrBark = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPlanet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlanet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCorgiTitleSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitleTop
        '
        Me.lblTitleTop.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleTop.Font = New System.Drawing.Font("Gabriola", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTop.Location = New System.Drawing.Point(1211, 518)
        Me.lblTitleTop.Name = "lblTitleTop"
        Me.lblTitleTop.Size = New System.Drawing.Size(277, 112)
        Me.lblTitleTop.TabIndex = 0
        Me.lblTitleTop.Text = "Corgi Space"
        Me.lblTitleTop.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Gabriola", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(416, 138)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Space Corgi"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picPlanet
        '
        Me.picPlanet.BackColor = System.Drawing.Color.Transparent
        Me.picPlanet.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiPlanet
        Me.picPlanet.Location = New System.Drawing.Point(-119, 278)
        Me.picPlanet.Name = "picPlanet"
        Me.picPlanet.Size = New System.Drawing.Size(381, 352)
        Me.picPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlanet.TabIndex = 2
        Me.picPlanet.TabStop = False
        '
        'picPlanet2
        '
        Me.picPlanet2.BackColor = System.Drawing.Color.Transparent
        Me.picPlanet2.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiPlanet2
        Me.picPlanet2.Location = New System.Drawing.Point(-5, 137)
        Me.picPlanet2.Name = "picPlanet2"
        Me.picPlanet2.Size = New System.Drawing.Size(142, 122)
        Me.picPlanet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlanet2.TabIndex = 3
        Me.picPlanet2.TabStop = False
        '
        'btnGameStart
        '
        Me.btnGameStart.BackColor = System.Drawing.Color.BlueViolet
        Me.btnGameStart.Font = New System.Drawing.Font("Gabriola", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGameStart.Location = New System.Drawing.Point(165, 111)
        Me.btnGameStart.Name = "btnGameStart"
        Me.btnGameStart.Size = New System.Drawing.Size(118, 67)
        Me.btnGameStart.TabIndex = 4
        Me.btnGameStart.Text = "Start"
        Me.btnGameStart.UseVisualStyleBackColor = False
        '
        'picCorgiTitleSprite
        '
        Me.picCorgiTitleSprite.BackColor = System.Drawing.Color.Transparent
        Me.picCorgiTitleSprite.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiTitleDog
        Me.picCorgiTitleSprite.Location = New System.Drawing.Point(408, 9)
        Me.picCorgiTitleSprite.Name = "picCorgiTitleSprite"
        Me.picCorgiTitleSprite.Size = New System.Drawing.Size(357, 428)
        Me.picCorgiTitleSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCorgiTitleSprite.TabIndex = 5
        Me.picCorgiTitleSprite.TabStop = False
        '
        'tmrBark
        '
        Me.tmrBark.Interval = 40
        '
        'frmTitleScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(777, 449)
        Me.Controls.Add(Me.btnGameStart)
        Me.Controls.Add(Me.picPlanet2)
        Me.Controls.Add(Me.lblTitleTop)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picPlanet)
        Me.Controls.Add(Me.picCorgiTitleSprite)
        Me.Name = "frmTitleScreen"
        CType(Me.picPlanet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlanet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCorgiTitleSprite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitleTop As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picPlanet As PictureBox
    Friend WithEvents picPlanet2 As PictureBox
    Friend WithEvents btnGameStart As Button
    Friend WithEvents picCorgiTitleSprite As PictureBox
    Friend WithEvents tmrBark As Timer
End Class

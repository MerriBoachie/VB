<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame
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
        Me.picCorgiSprite = New System.Windows.Forms.PictureBox()
        Me.picLifeMeter3 = New System.Windows.Forms.PictureBox()
        Me.picLifeMeter2 = New System.Windows.Forms.PictureBox()
        Me.picLifeMeter1 = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picBorderRight = New System.Windows.Forms.PictureBox()
        Me.picAsteroid1 = New System.Windows.Forms.PictureBox()
        Me.picAsteroid2 = New System.Windows.Forms.PictureBox()
        Me.picBG = New System.Windows.Forms.PictureBox()
        Me.tmrAsteroidMove = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.picAsteroid3 = New System.Windows.Forms.PictureBox()
        Me.picAsteroid4 = New System.Windows.Forms.PictureBox()
        Me.picAsteroid5 = New System.Windows.Forms.PictureBox()
        Me.picBoundary = New System.Windows.Forms.PictureBox()
        Me.picBone = New System.Windows.Forms.PictureBox()
        CType(Me.picCorgiSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLifeMeter3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLifeMeter2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLifeMeter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBorderRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsteroid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsteroid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsteroid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsteroid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsteroid5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoundary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCorgiSprite
        '
        Me.picCorgiSprite.BackColor = System.Drawing.Color.Transparent
        Me.picCorgiSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCorgiSprite.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiPlayerSprite
        Me.picCorgiSprite.Location = New System.Drawing.Point(12, 143)
        Me.picCorgiSprite.Name = "picCorgiSprite"
        Me.picCorgiSprite.Size = New System.Drawing.Size(61, 61)
        Me.picCorgiSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCorgiSprite.TabIndex = 0
        Me.picCorgiSprite.TabStop = False
        '
        'picLifeMeter3
        '
        Me.picLifeMeter3.BackColor = System.Drawing.Color.Transparent
        Me.picLifeMeter3.BackgroundImage = Global.Corgi_Space_Adventure_.My.Resources.Resources.lblScoreBG
        Me.picLifeMeter3.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiLifeMeterSprite
        Me.picLifeMeter3.Location = New System.Drawing.Point(23, 355)
        Me.picLifeMeter3.Name = "picLifeMeter3"
        Me.picLifeMeter3.Size = New System.Drawing.Size(95, 83)
        Me.picLifeMeter3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLifeMeter3.TabIndex = 1
        Me.picLifeMeter3.TabStop = False
        '
        'picLifeMeter2
        '
        Me.picLifeMeter2.BackColor = System.Drawing.Color.Transparent
        Me.picLifeMeter2.BackgroundImage = Global.Corgi_Space_Adventure_.My.Resources.Resources.lblScoreBG
        Me.picLifeMeter2.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiLifeMeterSprite
        Me.picLifeMeter2.Location = New System.Drawing.Point(124, 355)
        Me.picLifeMeter2.Name = "picLifeMeter2"
        Me.picLifeMeter2.Size = New System.Drawing.Size(95, 83)
        Me.picLifeMeter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLifeMeter2.TabIndex = 2
        Me.picLifeMeter2.TabStop = False
        '
        'picLifeMeter1
        '
        Me.picLifeMeter1.BackColor = System.Drawing.Color.Transparent
        Me.picLifeMeter1.BackgroundImage = Global.Corgi_Space_Adventure_.My.Resources.Resources.lblScoreBG
        Me.picLifeMeter1.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiLifeMeterSprite
        Me.picLifeMeter1.Location = New System.Drawing.Point(225, 355)
        Me.picLifeMeter1.Name = "picLifeMeter1"
        Me.picLifeMeter1.Size = New System.Drawing.Size(95, 83)
        Me.picLifeMeter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLifeMeter1.TabIndex = 3
        Me.picLifeMeter1.TabStop = False
        '
        'lblScore
        '
        Me.lblScore.AutoEllipsis = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.SystemColors.Window
        Me.lblScore.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.lblScoreBG
        Me.lblScore.Location = New System.Drawing.Point(627, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(148, 58)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBorderRight
        '
        Me.picBorderRight.BackColor = System.Drawing.Color.Transparent
        Me.picBorderRight.Location = New System.Drawing.Point(774, 0)
        Me.picBorderRight.Name = "picBorderRight"
        Me.picBorderRight.Size = New System.Drawing.Size(10, 464)
        Me.picBorderRight.TabIndex = 9
        Me.picBorderRight.TabStop = False
        '
        'picAsteroid1
        '
        Me.picAsteroid1.BackColor = System.Drawing.Color.Transparent
        Me.picAsteroid1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAsteroid1.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiAsteroids
        Me.picAsteroid1.Location = New System.Drawing.Point(703, 109)
        Me.picAsteroid1.Name = "picAsteroid1"
        Me.picAsteroid1.Size = New System.Drawing.Size(72, 59)
        Me.picAsteroid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAsteroid1.TabIndex = 10
        Me.picAsteroid1.TabStop = False
        '
        'picAsteroid2
        '
        Me.picAsteroid2.BackColor = System.Drawing.Color.Transparent
        Me.picAsteroid2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAsteroid2.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiAsteroids
        Me.picAsteroid2.Location = New System.Drawing.Point(703, 179)
        Me.picAsteroid2.Name = "picAsteroid2"
        Me.picAsteroid2.Size = New System.Drawing.Size(72, 55)
        Me.picAsteroid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAsteroid2.TabIndex = 11
        Me.picAsteroid2.TabStop = False
        '
        'picBG
        '
        Me.picBG.BackColor = System.Drawing.Color.Transparent
        Me.picBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBG.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiInGameBg_1
        Me.picBG.Location = New System.Drawing.Point(-4, -25)
        Me.picBG.Name = "picBG"
        Me.picBG.Size = New System.Drawing.Size(801, 498)
        Me.picBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBG.TabIndex = 14
        Me.picBG.TabStop = False
        '
        'tmrAsteroidMove
        '
        Me.tmrAsteroidMove.Interval = 40
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(72, 34)
        Me.btnStart.TabIndex = 15
        Me.btnStart.Text = "Game Start!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'picAsteroid3
        '
        Me.picAsteroid3.BackColor = System.Drawing.Color.Transparent
        Me.picAsteroid3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAsteroid3.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiAsteroids
        Me.picAsteroid3.Location = New System.Drawing.Point(703, 250)
        Me.picAsteroid3.Name = "picAsteroid3"
        Me.picAsteroid3.Size = New System.Drawing.Size(72, 55)
        Me.picAsteroid3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAsteroid3.TabIndex = 17
        Me.picAsteroid3.TabStop = False
        '
        'picAsteroid4
        '
        Me.picAsteroid4.BackColor = System.Drawing.Color.Transparent
        Me.picAsteroid4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAsteroid4.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiAsteroids
        Me.picAsteroid4.Location = New System.Drawing.Point(703, 320)
        Me.picAsteroid4.Name = "picAsteroid4"
        Me.picAsteroid4.Size = New System.Drawing.Size(72, 55)
        Me.picAsteroid4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAsteroid4.TabIndex = 18
        Me.picAsteroid4.TabStop = False
        '
        'picAsteroid5
        '
        Me.picAsteroid5.BackColor = System.Drawing.Color.Transparent
        Me.picAsteroid5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAsteroid5.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiAsteroids
        Me.picAsteroid5.Location = New System.Drawing.Point(703, 392)
        Me.picAsteroid5.Name = "picAsteroid5"
        Me.picAsteroid5.Size = New System.Drawing.Size(72, 55)
        Me.picAsteroid5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAsteroid5.TabIndex = 19
        Me.picAsteroid5.TabStop = False
        '
        'picBoundary
        '
        Me.picBoundary.BackColor = System.Drawing.Color.Transparent
        Me.picBoundary.Location = New System.Drawing.Point(-2, 0)
        Me.picBoundary.Name = "picBoundary"
        Me.picBoundary.Size = New System.Drawing.Size(8, 460)
        Me.picBoundary.TabIndex = 20
        Me.picBoundary.TabStop = False
        '
        'picBone
        '
        Me.picBone.BackColor = System.Drawing.Color.Transparent
        Me.picBone.Image = Global.Corgi_Space_Adventure_.My.Resources.Resources.SpaceCorgiBone
        Me.picBone.Location = New System.Drawing.Point(345, 160)
        Me.picBone.Name = "picBone"
        Me.picBone.Size = New System.Drawing.Size(45, 44)
        Me.picBone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBone.TabIndex = 21
        Me.picBone.TabStop = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(776, 450)
        Me.Controls.Add(Me.picBone)
        Me.Controls.Add(Me.picBoundary)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picBorderRight)
        Me.Controls.Add(Me.picLifeMeter1)
        Me.Controls.Add(Me.picLifeMeter2)
        Me.Controls.Add(Me.picLifeMeter3)
        Me.Controls.Add(Me.picCorgiSprite)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picAsteroid1)
        Me.Controls.Add(Me.picAsteroid2)
        Me.Controls.Add(Me.picAsteroid3)
        Me.Controls.Add(Me.picAsteroid4)
        Me.Controls.Add(Me.picAsteroid5)
        Me.Controls.Add(Me.picBG)
        Me.Name = "frmGame"
        CType(Me.picCorgiSprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLifeMeter3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLifeMeter2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLifeMeter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBorderRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsteroid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsteroid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsteroid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsteroid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsteroid5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoundary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picCorgiSprite As PictureBox
    Friend WithEvents picLifeMeter3 As PictureBox
    Friend WithEvents picLifeMeter2 As PictureBox
    Friend WithEvents picLifeMeter1 As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents picBorderRight As PictureBox
    Friend WithEvents picAsteroid1 As PictureBox
    Friend WithEvents picAsteroid2 As PictureBox
    Friend WithEvents picBG As PictureBox
    Friend WithEvents tmrAsteroidMove As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents picAsteroid3 As PictureBox
    Friend WithEvents picAsteroid4 As PictureBox
    Friend WithEvents picAsteroid5 As PictureBox
    Friend WithEvents picBoundary As PictureBox
    Friend WithEvents picBone As PictureBox
End Class

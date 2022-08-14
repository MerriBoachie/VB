<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMathAndStrings
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
        Me.lblIkimashou = New System.Windows.Forms.Label()
        Me.btnMathFun = New System.Windows.Forms.Button()
        Me.btnMyName = New System.Windows.Forms.Button()
        Me.btnMyInitials = New System.Windows.Forms.Button()
        Me.btnWhichIsFirst = New System.Windows.Forms.Button()
        Me.btnReplaceLetter = New System.Windows.Forms.Button()
        Me.btnRemoveWord = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIkimashou
        '
        Me.lblIkimashou.Location = New System.Drawing.Point(107, 26)
        Me.lblIkimashou.Name = "lblIkimashou"
        Me.lblIkimashou.Size = New System.Drawing.Size(120, 45)
        Me.lblIkimashou.TabIndex = 0
        Me.lblIkimashou.Text = "Let's get started! :D"
        Me.lblIkimashou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMathFun
        '
        Me.btnMathFun.BackColor = System.Drawing.Color.LightPink
        Me.btnMathFun.Location = New System.Drawing.Point(17, 100)
        Me.btnMathFun.Name = "btnMathFun"
        Me.btnMathFun.Size = New System.Drawing.Size(93, 40)
        Me.btnMathFun.TabIndex = 1
        Me.btnMathFun.Text = "Math Fun! :D"
        Me.btnMathFun.UseVisualStyleBackColor = False
        '
        'btnMyName
        '
        Me.btnMyName.BackColor = System.Drawing.Color.LightPink
        Me.btnMyName.Location = New System.Drawing.Point(228, 100)
        Me.btnMyName.Name = "btnMyName"
        Me.btnMyName.Size = New System.Drawing.Size(93, 40)
        Me.btnMyName.TabIndex = 2
        Me.btnMyName.Text = "What's your name???"
        Me.btnMyName.UseVisualStyleBackColor = False
        '
        'btnMyInitials
        '
        Me.btnMyInitials.BackColor = System.Drawing.Color.LightPink
        Me.btnMyInitials.Location = New System.Drawing.Point(17, 177)
        Me.btnMyInitials.Name = "btnMyInitials"
        Me.btnMyInitials.Size = New System.Drawing.Size(93, 40)
        Me.btnMyInitials.TabIndex = 3
        Me.btnMyInitials.Text = "What are your initials???"
        Me.btnMyInitials.UseVisualStyleBackColor = False
        '
        'btnWhichIsFirst
        '
        Me.btnWhichIsFirst.BackColor = System.Drawing.Color.LightPink
        Me.btnWhichIsFirst.Location = New System.Drawing.Point(228, 177)
        Me.btnWhichIsFirst.Name = "btnWhichIsFirst"
        Me.btnWhichIsFirst.Size = New System.Drawing.Size(93, 40)
        Me.btnWhichIsFirst.TabIndex = 4
        Me.btnWhichIsFirst.Text = "Which comes first...?"
        Me.btnWhichIsFirst.UseVisualStyleBackColor = False
        '
        'btnReplaceLetter
        '
        Me.btnReplaceLetter.BackColor = System.Drawing.Color.LightPink
        Me.btnReplaceLetter.Location = New System.Drawing.Point(17, 255)
        Me.btnReplaceLetter.Name = "btnReplaceLetter"
        Me.btnReplaceLetter.Size = New System.Drawing.Size(93, 40)
        Me.btnReplaceLetter.TabIndex = 5
        Me.btnReplaceLetter.Text = "Make a new word!"
        Me.btnReplaceLetter.UseVisualStyleBackColor = False
        '
        'btnRemoveWord
        '
        Me.btnRemoveWord.BackColor = System.Drawing.Color.LightPink
        Me.btnRemoveWord.Location = New System.Drawing.Point(228, 255)
        Me.btnRemoveWord.Name = "btnRemoveWord"
        Me.btnRemoveWord.Size = New System.Drawing.Size(93, 40)
        Me.btnRemoveWord.TabIndex = 6
        Me.btnRemoveWord.Text = "Make a funky phrase!"
        Me.btnRemoveWord.UseVisualStyleBackColor = False
        '
        'frmMathAndStrings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(361, 380)
        Me.Controls.Add(Me.btnRemoveWord)
        Me.Controls.Add(Me.btnReplaceLetter)
        Me.Controls.Add(Me.btnWhichIsFirst)
        Me.Controls.Add(Me.btnMyInitials)
        Me.Controls.Add(Me.btnMyName)
        Me.Controls.Add(Me.btnMathFun)
        Me.Controls.Add(Me.lblIkimashou)
        Me.Name = "frmMathAndStrings"
        Me.Text = "Hey! Hey!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblIkimashou As Label
    Friend WithEvents btnMathFun As Button
    Friend WithEvents btnMyName As Button
    Friend WithEvents btnMyInitials As Button
    Friend WithEvents btnWhichIsFirst As Button
    Friend WithEvents btnReplaceLetter As Button
    Friend WithEvents btnRemoveWord As Button
End Class

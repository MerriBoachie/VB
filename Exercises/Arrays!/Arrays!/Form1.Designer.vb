<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrays
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
        Me.btnPrompt = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnFriends = New System.Windows.Forms.Button()
        Me.btnEnterGrades = New System.Windows.Forms.Button()
        Me.btnAverageGrade = New System.Windows.Forms.Button()
        Me.btnRandomGrades = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnShowFoods = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPrompt
        '
        Me.btnPrompt.BackColor = System.Drawing.Color.LightPink
        Me.btnPrompt.Location = New System.Drawing.Point(35, 23)
        Me.btnPrompt.Name = "btnPrompt"
        Me.btnPrompt.Size = New System.Drawing.Size(157, 44)
        Me.btnPrompt.TabIndex = 0
        Me.btnPrompt.Text = "Let's do some arrays!"
        Me.btnPrompt.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(228, 30)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(211, 31)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFriends
        '
        Me.btnFriends.BackColor = System.Drawing.Color.LightPink
        Me.btnFriends.Location = New System.Drawing.Point(35, 115)
        Me.btnFriends.Name = "btnFriends"
        Me.btnFriends.Size = New System.Drawing.Size(120, 44)
        Me.btnFriends.TabIndex = 2
        Me.btnFriends.Text = "I'd love to meet your friends! :D"
        Me.btnFriends.UseVisualStyleBackColor = False
        '
        'btnEnterGrades
        '
        Me.btnEnterGrades.BackColor = System.Drawing.Color.LightPink
        Me.btnEnterGrades.Location = New System.Drawing.Point(181, 115)
        Me.btnEnterGrades.Name = "btnEnterGrades"
        Me.btnEnterGrades.Size = New System.Drawing.Size(120, 44)
        Me.btnEnterGrades.TabIndex = 3
        Me.btnEnterGrades.Text = "How are your grades now??"
        Me.btnEnterGrades.UseVisualStyleBackColor = False
        '
        'btnAverageGrade
        '
        Me.btnAverageGrade.BackColor = System.Drawing.Color.LightPink
        Me.btnAverageGrade.Location = New System.Drawing.Point(319, 115)
        Me.btnAverageGrade.Name = "btnAverageGrade"
        Me.btnAverageGrade.Size = New System.Drawing.Size(120, 44)
        Me.btnAverageGrade.TabIndex = 4
        Me.btnAverageGrade.Text = "Get your grade average!"
        Me.btnAverageGrade.UseVisualStyleBackColor = False
        '
        'btnRandomGrades
        '
        Me.btnRandomGrades.BackColor = System.Drawing.Color.LightPink
        Me.btnRandomGrades.Location = New System.Drawing.Point(35, 190)
        Me.btnRandomGrades.Name = "btnRandomGrades"
        Me.btnRandomGrades.Size = New System.Drawing.Size(120, 44)
        Me.btnRandomGrades.TabIndex = 5
        Me.btnRandomGrades.Text = "Get your average again!!"
        Me.btnRandomGrades.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightPink
        Me.Button1.Location = New System.Drawing.Point(181, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 44)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Get your average again!!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnShowFoods
        '
        Me.btnShowFoods.BackColor = System.Drawing.Color.LightPink
        Me.btnShowFoods.Location = New System.Drawing.Point(319, 190)
        Me.btnShowFoods.Name = "btnShowFoods"
        Me.btnShowFoods.Size = New System.Drawing.Size(120, 44)
        Me.btnShowFoods.TabIndex = 7
        Me.btnShowFoods.Text = "What do you like to eat?"
        Me.btnShowFoods.UseVisualStyleBackColor = False
        '
        'frmArrays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(482, 450)
        Me.Controls.Add(Me.btnShowFoods)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRandomGrades)
        Me.Controls.Add(Me.btnAverageGrade)
        Me.Controls.Add(Me.btnEnterGrades)
        Me.Controls.Add(Me.btnFriends)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnPrompt)
        Me.Name = "frmArrays"
        Me.Text = "Learn how to store information!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrompt As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnFriends As Button
    Friend WithEvents btnEnterGrades As Button
    Friend WithEvents btnAverageGrade As Button
    Friend WithEvents btnRandomGrades As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnShowFoods As Button
End Class

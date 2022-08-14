<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuperSize
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
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.radSuperSize = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.btnPlace = New System.Windows.Forms.Button()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.chkHamburger = New System.Windows.Forms.CheckBox()
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkOnion = New System.Windows.Forms.CheckBox()
        Me.grpSize.SuspendLayout()
        Me.grpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.radSuperSize)
        Me.grpSize.Controls.Add(Me.radRegular)
        Me.grpSize.Location = New System.Drawing.Point(12, 23)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(213, 81)
        Me.grpSize.TabIndex = 0
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "What size?"
        '
        'radSuperSize
        '
        Me.radSuperSize.AutoSize = True
        Me.radSuperSize.Location = New System.Drawing.Point(109, 34)
        Me.radSuperSize.Name = "radSuperSize"
        Me.radSuperSize.Size = New System.Drawing.Size(82, 17)
        Me.radSuperSize.TabIndex = 1
        Me.radSuperSize.TabStop = True
        Me.radSuperSize.Text = "SuperSize!!!"
        Me.radSuperSize.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(6, 34)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(65, 17)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular!"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'btnPlace
        '
        Me.btnPlace.BackColor = System.Drawing.Color.DarkOrange
        Me.btnPlace.Location = New System.Drawing.Point(19, 256)
        Me.btnPlace.Name = "btnPlace"
        Me.btnPlace.Size = New System.Drawing.Size(108, 50)
        Me.btnPlace.TabIndex = 2
        Me.btnPlace.Text = "Place my order!"
        Me.btnPlace.UseVisualStyleBackColor = False
        '
        'lblNumber
        '
        Me.lblNumber.Location = New System.Drawing.Point(145, 251)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(97, 61)
        Me.lblNumber.TabIndex = 3
        Me.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(21, 325)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(218, 72)
        Me.lblMessage.TabIndex = 4
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkHamburger
        '
        Me.chkHamburger.AutoSize = True
        Me.chkHamburger.Location = New System.Drawing.Point(6, 32)
        Me.chkHamburger.Name = "chkHamburger"
        Me.chkHamburger.Size = New System.Drawing.Size(91, 17)
        Me.chkHamburger.TabIndex = 5
        Me.chkHamburger.Text = "A Hamburger!"
        Me.chkHamburger.UseVisualStyleBackColor = True
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.chkOnion)
        Me.grpMenu.Controls.Add(Me.chkCheese)
        Me.grpMenu.Controls.Add(Me.chkFries)
        Me.grpMenu.Controls.Add(Me.chkHamburger)
        Me.grpMenu.Location = New System.Drawing.Point(18, 133)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(227, 103)
        Me.grpMenu.TabIndex = 1
        Me.grpMenu.TabStop = False
        Me.grpMenu.Text = "What would you like to eat??"
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(6, 70)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(105, 17)
        Me.chkCheese.TabIndex = 7
        Me.chkCheese.Text = "A Cheeseburger!"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(130, 32)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(81, 17)
        Me.chkFries.TabIndex = 6
        Me.chkFries.Text = "Some Fries!"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkOnion
        '
        Me.chkOnion.AutoSize = True
        Me.chkOnion.Location = New System.Drawing.Point(130, 70)
        Me.chkOnion.Name = "chkOnion"
        Me.chkOnion.Size = New System.Drawing.Size(87, 17)
        Me.chkOnion.TabIndex = 8
        Me.chkOnion.Text = "Onion Rings!"
        Me.chkOnion.UseVisualStyleBackColor = True
        '
        'frmSuperSize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(262, 450)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.btnPlace)
        Me.Controls.Add(Me.grpMenu)
        Me.Controls.Add(Me.grpSize)
        Me.Name = "frmSuperSize"
        Me.Text = "Take a look at the menu!"
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpMenu.ResumeLayout(False)
        Me.grpMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSize As GroupBox
    Friend WithEvents radSuperSize As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents btnPlace As Button
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents chkHamburger As CheckBox
    Friend WithEvents grpMenu As GroupBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents chkFries As CheckBox
    Friend WithEvents chkOnion As CheckBox
End Class

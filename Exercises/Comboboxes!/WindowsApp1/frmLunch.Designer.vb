<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLunch
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblChoices = New System.Windows.Forms.Label()
        Me.lblDrinks = New System.Windows.Forms.Label()
        Me.lstChoices = New System.Windows.Forms.ListBox()
        Me.cboDrinkChoices = New System.Windows.Forms.ComboBox()
        Me.cboDrinkSize = New System.Windows.Forms.ComboBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(428, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.MenuToolStripMenuItem.Text = "Menu!"
        '
        'lblChoices
        '
        Me.lblChoices.Location = New System.Drawing.Point(12, 53)
        Me.lblChoices.Name = "lblChoices"
        Me.lblChoices.Size = New System.Drawing.Size(135, 24)
        Me.lblChoices.TabIndex = 1
        Me.lblChoices.Text = "Today's Choices!"
        Me.lblChoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDrinks
        '
        Me.lblDrinks.Location = New System.Drawing.Point(189, 53)
        Me.lblDrinks.Name = "lblDrinks"
        Me.lblDrinks.Size = New System.Drawing.Size(135, 24)
        Me.lblDrinks.TabIndex = 2
        Me.lblDrinks.Text = "Drinks!"
        Me.lblDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstChoices
        '
        Me.lstChoices.FormattingEnabled = True
        Me.lstChoices.Items.AddRange(New Object() {"Chef Salad", "Garden Salad", "Hamburger", "Cheeseburger", "Chicken Sandwich"})
        Me.lstChoices.Location = New System.Drawing.Point(25, 91)
        Me.lstChoices.Name = "lstChoices"
        Me.lstChoices.Size = New System.Drawing.Size(137, 121)
        Me.lstChoices.TabIndex = 3
        '
        'cboDrinkChoices
        '
        Me.cboDrinkChoices.FormattingEnabled = True
        Me.cboDrinkChoices.Items.AddRange(New Object() {"Tea", "Soda", "Coffee"})
        Me.cboDrinkChoices.Location = New System.Drawing.Point(204, 80)
        Me.cboDrinkChoices.Name = "cboDrinkChoices"
        Me.cboDrinkChoices.Size = New System.Drawing.Size(171, 21)
        Me.cboDrinkChoices.TabIndex = 4
        '
        'cboDrinkSize
        '
        Me.cboDrinkSize.FormattingEnabled = True
        Me.cboDrinkSize.Items.AddRange(New Object() {"Small!", "Medium!!", "Large!!!"})
        Me.cboDrinkSize.Location = New System.Drawing.Point(204, 162)
        Me.cboDrinkSize.Name = "cboDrinkSize"
        Me.cboDrinkSize.Size = New System.Drawing.Size(171, 21)
        Me.cboDrinkSize.TabIndex = 5
        '
        'lblSize
        '
        Me.lblSize.Location = New System.Drawing.Point(189, 135)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(135, 24)
        Me.lblSize.TabIndex = 6
        Me.lblSize.Text = "What size???"
        Me.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(22, 234)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(186, 162)
        Me.lblMessage.TabIndex = 7
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Azure
        Me.btnCalculate.Location = New System.Drawing.Point(262, 233)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(124, 27)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "What's the total?"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit~"
        '
        'frmLunch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(428, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.cboDrinkSize)
        Me.Controls.Add(Me.cboDrinkChoices)
        Me.Controls.Add(Me.lstChoices)
        Me.Controls.Add(Me.lblDrinks)
        Me.Controls.Add(Me.lblChoices)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLunch"
        Me.Text = "Hungry?"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblChoices As Label
    Friend WithEvents lblDrinks As Label
    Friend WithEvents lstChoices As ListBox
    Friend WithEvents cboDrinkChoices As ComboBox
    Friend WithEvents cboDrinkSize As ComboBox
    Friend WithEvents lblSize As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class

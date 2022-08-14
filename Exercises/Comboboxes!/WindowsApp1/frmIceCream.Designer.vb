<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIceCream
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
        Me.mnuEdit = New System.Windows.Forms.MenuStrip()
        Me.EditFlavorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtEnter = New System.Windows.Forms.TextBox()
        Me.lstFlavors = New System.Windows.Forms.ListBox()
        Me.mnuEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuEdit
        '
        Me.mnuEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditFlavorsToolStripMenuItem})
        Me.mnuEdit.Location = New System.Drawing.Point(0, 0)
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(393, 24)
        Me.mnuEdit.TabIndex = 0
        Me.mnuEdit.Text = "MenuStrip1"
        '
        'EditFlavorsToolStripMenuItem
        '
        Me.EditFlavorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.SortToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.EditFlavorsToolStripMenuItem.Name = "EditFlavorsToolStripMenuItem"
        Me.EditFlavorsToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.EditFlavorsToolStripMenuItem.Text = "Edit the Flavors!"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'SortToolStripMenuItem
        '
        Me.SortToolStripMenuItem.Name = "SortToolStripMenuItem"
        Me.SortToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SortToolStripMenuItem.Text = "Sort"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(37, 63)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(168, 53)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Would you like to add or remove anything?"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEnter
        '
        Me.txtEnter.Location = New System.Drawing.Point(232, 80)
        Me.txtEnter.Name = "txtEnter"
        Me.txtEnter.Size = New System.Drawing.Size(119, 20)
        Me.txtEnter.TabIndex = 2
        '
        'lstFlavors
        '
        Me.lstFlavors.FormattingEnabled = True
        Me.lstFlavors.Items.AddRange(New Object() {"Chocolate~", "Vanilla~", "Strawberry~"})
        Me.lstFlavors.Location = New System.Drawing.Point(94, 159)
        Me.lstFlavors.Name = "lstFlavors"
        Me.lstFlavors.Size = New System.Drawing.Size(179, 108)
        Me.lstFlavors.TabIndex = 3
        '
        'frmIceCream
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(393, 296)
        Me.Controls.Add(Me.lstFlavors)
        Me.Controls.Add(Me.txtEnter)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.mnuEdit)
        Me.MainMenuStrip = Me.mnuEdit
        Me.Name = "frmIceCream"
        Me.Text = "Have some ice cream! "
        Me.mnuEdit.ResumeLayout(False)
        Me.mnuEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuEdit As MenuStrip
    Friend WithEvents EditFlavorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtEnter As TextBox
    Friend WithEvents lstFlavors As ListBox
End Class

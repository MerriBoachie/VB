<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBands
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
        Me.mnuSelect = New System.Windows.Forms.MenuStrip()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheBeatlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheWhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheDoorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.mnuSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuSelect
        '
        Me.mnuSelect.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectToolStripMenuItem})
        Me.mnuSelect.Location = New System.Drawing.Point(0, 0)
        Me.mnuSelect.Name = "mnuSelect"
        Me.mnuSelect.Size = New System.Drawing.Size(271, 24)
        Me.mnuSelect.TabIndex = 0
        Me.mnuSelect.Text = "MenuStrip1"
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TheBeatlesToolStripMenuItem, Me.TheWhoToolStripMenuItem, Me.TheDoorsToolStripMenuItem, Me.ExitToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.SelectToolStripMenuItem.Text = "Select one!"
        '
        'TheBeatlesToolStripMenuItem
        '
        Me.TheBeatlesToolStripMenuItem.Name = "TheBeatlesToolStripMenuItem"
        Me.TheBeatlesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TheBeatlesToolStripMenuItem.Text = "The Beatles"
        '
        'TheWhoToolStripMenuItem
        '
        Me.TheWhoToolStripMenuItem.Name = "TheWhoToolStripMenuItem"
        Me.TheWhoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TheWhoToolStripMenuItem.Text = "The Who"
        '
        'TheDoorsToolStripMenuItem
        '
        Me.TheDoorsToolStripMenuItem.Name = "TheDoorsToolStripMenuItem"
        Me.TheDoorsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TheDoorsToolStripMenuItem.Text = "The Doors"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit~"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(39, 79)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(192, 180)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Select one from the menu!"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBands
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(271, 309)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.mnuSelect)
        Me.MainMenuStrip = Me.mnuSelect
        Me.Name = "frmBands"
        Me.Text = "Choose one!"
        Me.mnuSelect.ResumeLayout(False)
        Me.mnuSelect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuSelect As MenuStrip
    Friend WithEvents SelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheBeatlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheWhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheDoorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblMessage As Label
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class

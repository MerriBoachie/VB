<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConcert
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
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayTheCostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboTickets = New System.Windows.Forms.ComboBox()
        Me.lblPromptEvent = New System.Windows.Forms.Label()
        Me.lstEvent = New System.Windows.Forms.ListBox()
        Me.lblPromptTicket = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(343, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayTheCostToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.MainMenuToolStripMenuItem.Text = "Main menu"
        '
        'DisplayTheCostToolStripMenuItem
        '
        Me.DisplayTheCostToolStripMenuItem.Name = "DisplayTheCostToolStripMenuItem"
        Me.DisplayTheCostToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DisplayTheCostToolStripMenuItem.Text = "Display the cost!"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit!"
        '
        'cboTickets
        '
        Me.cboTickets.FormattingEnabled = True
        Me.cboTickets.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboTickets.Location = New System.Drawing.Point(171, 87)
        Me.cboTickets.Name = "cboTickets"
        Me.cboTickets.Size = New System.Drawing.Size(124, 21)
        Me.cboTickets.TabIndex = 1
        '
        'lblPromptEvent
        '
        Me.lblPromptEvent.Location = New System.Drawing.Point(12, 48)
        Me.lblPromptEvent.Name = "lblPromptEvent"
        Me.lblPromptEvent.Size = New System.Drawing.Size(94, 27)
        Me.lblPromptEvent.TabIndex = 2
        Me.lblPromptEvent.Text = "Events!"
        Me.lblPromptEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstEvent
        '
        Me.lstEvent.FormattingEnabled = True
        Me.lstEvent.Items.AddRange(New Object() {"Concert", "Orchestra", "Play", "Musical"})
        Me.lstEvent.Location = New System.Drawing.Point(12, 78)
        Me.lstEvent.Name = "lstEvent"
        Me.lstEvent.Size = New System.Drawing.Size(109, 121)
        Me.lstEvent.TabIndex = 3
        '
        'lblPromptTicket
        '
        Me.lblPromptTicket.Location = New System.Drawing.Point(185, 48)
        Me.lblPromptTicket.Name = "lblPromptTicket"
        Me.lblPromptTicket.Size = New System.Drawing.Size(94, 27)
        Me.lblPromptTicket.TabIndex = 4
        Me.lblPromptTicket.Text = "How many tickets?"
        Me.lblPromptTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(168, 128)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(140, 101)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmConcert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(343, 251)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblPromptTicket)
        Me.Controls.Add(Me.lstEvent)
        Me.Controls.Add(Me.lblPromptEvent)
        Me.Controls.Add(Me.cboTickets)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmConcert"
        Me.Text = "Heck yeah!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayTheCostToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboTickets As ComboBox
    Friend WithEvents lblPromptEvent As Label
    Friend WithEvents lstEvent As ListBox
    Friend WithEvents lblPromptTicket As Label
    Friend WithEvents lblMessage As Label
End Class

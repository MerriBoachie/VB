<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMathFun
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
        Me.MNUfUNCTIONS = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsoluteValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SquareRootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.MNUfUNCTIONS.SuspendLayout()
        Me.SuspendLayout()
        '
        'MNUfUNCTIONS
        '
        Me.MNUfUNCTIONS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.MNUfUNCTIONS.Location = New System.Drawing.Point(0, 0)
        Me.MNUfUNCTIONS.Name = "MNUfUNCTIONS"
        Me.MNUfUNCTIONS.Size = New System.Drawing.Size(362, 24)
        Me.MNUfUNCTIONS.TabIndex = 0
        Me.MNUfUNCTIONS.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FunctionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'FunctionToolStripMenuItem
        '
        Me.FunctionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbsoluteValueToolStripMenuItem, Me.SquareRootToolStripMenuItem, Me.SignToolStripMenuItem, Me.RoundToolStripMenuItem})
        Me.FunctionToolStripMenuItem.Name = "FunctionToolStripMenuItem"
        Me.FunctionToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.FunctionToolStripMenuItem.Text = "Function!"
        '
        'AbsoluteValueToolStripMenuItem
        '
        Me.AbsoluteValueToolStripMenuItem.Name = "AbsoluteValueToolStripMenuItem"
        Me.AbsoluteValueToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AbsoluteValueToolStripMenuItem.Text = "Absolute Value!"
        '
        'SquareRootToolStripMenuItem
        '
        Me.SquareRootToolStripMenuItem.Name = "SquareRootToolStripMenuItem"
        Me.SquareRootToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SquareRootToolStripMenuItem.Text = "Square Root!"
        '
        'SignToolStripMenuItem
        '
        Me.SignToolStripMenuItem.Name = "SignToolStripMenuItem"
        Me.SignToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SignToolStripMenuItem.Text = "Sign!"
        '
        'RoundToolStripMenuItem
        '
        Me.RoundToolStripMenuItem.Name = "RoundToolStripMenuItem"
        Me.RoundToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.RoundToolStripMenuItem.Text = "Round!"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(12, 47)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(133, 30)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Enter a number!"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(177, 57)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(120, 20)
        Me.txtInput.TabIndex = 2
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(54, 117)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(230, 117)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMathFun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(362, 287)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.MNUfUNCTIONS)
        Me.MainMenuStrip = Me.MNUfUNCTIONS
        Me.Name = "frmMathFun"
        Me.Text = "Oops... I meant math FUNCTIONS! ^^'"
        Me.MNUfUNCTIONS.ResumeLayout(False)
        Me.MNUfUNCTIONS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MNUfUNCTIONS As MenuStrip
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunctionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbsoluteValueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SquareRootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblOutput As Label
End Class

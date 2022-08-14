<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOceanZones
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnZone = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(37, 38)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(152, 42)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter in a depth (in Meters), and I'll tell you which ocean zone youre in!"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(221, 50)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(103, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnZone
        '
        Me.btnZone.BackColor = System.Drawing.Color.Azure
        Me.btnZone.Location = New System.Drawing.Point(108, 92)
        Me.btnZone.Name = "btnZone"
        Me.btnZone.Size = New System.Drawing.Size(154, 50)
        Me.btnZone.TabIndex = 2
        Me.btnZone.Text = "Where am I??"
        Me.btnZone.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(86, 166)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(214, 98)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmOceanZones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(381, 286)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnZone)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmOceanZones"
        Me.Text = "Let's look at ocean zones!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnZone As Button
    Friend WithEvents lblMessage As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReadyForSchool
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
        Me.grpChoices = New System.Windows.Forms.GroupBox()
        Me.chkHomework = New System.Windows.Forms.CheckBox()
        Me.chkBreakfast = New System.Windows.Forms.CheckBox()
        Me.chkBrushTeeth = New System.Windows.Forms.CheckBox()
        Me.btnReady = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.grpChoices.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.chkBrushTeeth)
        Me.grpChoices.Controls.Add(Me.chkBreakfast)
        Me.grpChoices.Controls.Add(Me.chkHomework)
        Me.grpChoices.Location = New System.Drawing.Point(12, 12)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(170, 183)
        Me.grpChoices.TabIndex = 0
        Me.grpChoices.TabStop = False
        '
        'chkHomework
        '
        Me.chkHomework.AutoSize = True
        Me.chkHomework.Location = New System.Drawing.Point(6, 29)
        Me.chkHomework.Name = "chkHomework"
        Me.chkHomework.Size = New System.Drawing.Size(142, 17)
        Me.chkHomework.TabIndex = 0
        Me.chkHomework.Text = "Is your homework done?"
        Me.chkHomework.UseVisualStyleBackColor = True
        '
        'chkBreakfast
        '
        Me.chkBreakfast.AutoSize = True
        Me.chkBreakfast.Location = New System.Drawing.Point(6, 79)
        Me.chkBreakfast.Name = "chkBreakfast"
        Me.chkBreakfast.Size = New System.Drawing.Size(161, 17)
        Me.chkBreakfast.TabIndex = 1
        Me.chkBreakfast.Text = "Have you eaten breakfast??"
        Me.chkBreakfast.UseVisualStyleBackColor = True
        '
        'chkBrushTeeth
        '
        Me.chkBrushTeeth.AutoSize = True
        Me.chkBrushTeeth.Location = New System.Drawing.Point(6, 129)
        Me.chkBrushTeeth.Name = "chkBrushTeeth"
        Me.chkBrushTeeth.Size = New System.Drawing.Size(159, 17)
        Me.chkBrushTeeth.TabIndex = 2
        Me.chkBrushTeeth.Text = "Did you brush your teeth???"
        Me.chkBrushTeeth.UseVisualStyleBackColor = True
        '
        'btnReady
        '
        Me.btnReady.BackColor = System.Drawing.Color.Honeydew
        Me.btnReady.Location = New System.Drawing.Point(21, 211)
        Me.btnReady.Name = "btnReady"
        Me.btnReady.Size = New System.Drawing.Size(158, 60)
        Me.btnReady.TabIndex = 1
        Me.btnReady.Text = "Im ready for school! >:)"
        Me.btnReady.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(219, 91)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(187, 147)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReadyForSchool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(449, 315)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnReady)
        Me.Controls.Add(Me.grpChoices)
        Me.Name = "frmReadyForSchool"
        Me.Text = "Don't be late!! :0"
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpChoices As GroupBox
    Friend WithEvents chkBrushTeeth As CheckBox
    Friend WithEvents chkBreakfast As CheckBox
    Friend WithEvents chkHomework As CheckBox
    Friend WithEvents btnReady As Button
    Friend WithEvents lblMessage As Label
End Class

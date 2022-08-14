<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuickCuts
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
        Me.grpSelect = New System.Windows.Forms.GroupBox()
        Me.chkMassage = New System.Windows.Forms.CheckBox()
        Me.chkStyle = New System.Windows.Forms.CheckBox()
        Me.ChkShampoo = New System.Windows.Forms.CheckBox()
        Me.chkHairCut = New System.Windows.Forms.CheckBox()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.grpSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSelect
        '
        Me.grpSelect.Controls.Add(Me.chkMassage)
        Me.grpSelect.Controls.Add(Me.chkStyle)
        Me.grpSelect.Controls.Add(Me.ChkShampoo)
        Me.grpSelect.Controls.Add(Me.chkHairCut)
        Me.grpSelect.Location = New System.Drawing.Point(25, 24)
        Me.grpSelect.Name = "grpSelect"
        Me.grpSelect.Size = New System.Drawing.Size(175, 166)
        Me.grpSelect.TabIndex = 0
        Me.grpSelect.TabStop = False
        Me.grpSelect.Text = "What would you like?"
        '
        'chkMassage
        '
        Me.chkMassage.AutoSize = True
        Me.chkMassage.Location = New System.Drawing.Point(29, 131)
        Me.chkMassage.Name = "chkMassage"
        Me.chkMassage.Size = New System.Drawing.Size(137, 17)
        Me.chkMassage.TabIndex = 3
        Me.chkMassage.Text = "Neck Massage! ($2.95)"
        Me.chkMassage.UseVisualStyleBackColor = True
        '
        'chkStyle
        '
        Me.chkStyle.AutoSize = True
        Me.chkStyle.Location = New System.Drawing.Point(29, 96)
        Me.chkStyle.Name = "chkStyle"
        Me.chkStyle.Size = New System.Drawing.Size(88, 17)
        Me.chkStyle.TabIndex = 2
        Me.chkStyle.Text = "Style! ($5.95)"
        Me.chkStyle.UseVisualStyleBackColor = True
        '
        'ChkShampoo
        '
        Me.ChkShampoo.AutoSize = True
        Me.ChkShampoo.Location = New System.Drawing.Point(29, 61)
        Me.ChkShampoo.Name = "ChkShampoo"
        Me.ChkShampoo.Size = New System.Drawing.Size(110, 17)
        Me.ChkShampoo.TabIndex = 1
        Me.ChkShampoo.Text = "Shampoo! ($3.95)"
        Me.ChkShampoo.UseVisualStyleBackColor = True
        '
        'chkHairCut
        '
        Me.chkHairCut.AutoSize = True
        Me.chkHairCut.Location = New System.Drawing.Point(29, 29)
        Me.chkHairCut.Name = "chkHairCut"
        Me.chkHairCut.Size = New System.Drawing.Size(100, 17)
        Me.chkHairCut.TabIndex = 0
        Me.chkHairCut.Text = "HairCut! ($9.95)"
        Me.chkHairCut.UseVisualStyleBackColor = True
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.FloralWhite
        Me.btnCost.Location = New System.Drawing.Point(41, 363)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(150, 52)
        Me.btnCost.TabIndex = 1
        Me.btnCost.Text = "My cost, Please!"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(32, 218)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(167, 125)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmQuickCuts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(239, 450)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.grpSelect)
        Me.Name = "frmQuickCuts"
        Me.Text = "Welcome to Quick Cuts!"
        Me.grpSelect.ResumeLayout(False)
        Me.grpSelect.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSelect As GroupBox
    Friend WithEvents chkMassage As CheckBox
    Friend WithEvents chkStyle As CheckBox
    Friend WithEvents ChkShampoo As CheckBox
    Friend WithEvents chkHairCut As CheckBox
    Friend WithEvents btnCost As Button
    Friend WithEvents lblMessage As Label
End Class

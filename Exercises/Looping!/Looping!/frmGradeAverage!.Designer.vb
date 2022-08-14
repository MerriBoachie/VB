<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradeAverage_
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
        Me.btnCalculateFor = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCalculateDo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalculateFor
        '
        Me.btnCalculateFor.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCalculateFor.Location = New System.Drawing.Point(29, 333)
        Me.btnCalculateFor.Name = "btnCalculateFor"
        Me.btnCalculateFor.Size = New System.Drawing.Size(116, 56)
        Me.btnCalculateFor.TabIndex = 1
        Me.btnCalculateFor.Text = "Show me my grade average!"
        Me.btnCalculateFor.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(26, 29)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(237, 287)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculateDo
        '
        Me.btnCalculateDo.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCalculateDo.Location = New System.Drawing.Point(151, 333)
        Me.btnCalculateDo.Name = "btnCalculateDo"
        Me.btnCalculateDo.Size = New System.Drawing.Size(116, 56)
        Me.btnCalculateDo.TabIndex = 3
        Me.btnCalculateDo.Text = "Show me my grade average! (Do loop)"
        Me.btnCalculateDo.UseVisualStyleBackColor = False
        '
        'frmGradeAverage_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(301, 450)
        Me.Controls.Add(Me.btnCalculateDo)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnCalculateFor)
        Me.Name = "frmGradeAverage_"
        Me.Text = "frmGradeAverage_"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalculateFor As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnCalculateDo As Button
End Class

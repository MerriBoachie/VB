<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageGrade2
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(58, 9)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(275, 86)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Azure
        Me.btnCalculate.Location = New System.Drawing.Point(237, 109)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(144, 58)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate your average!!"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Azure
        Me.btnEnter.Location = New System.Drawing.Point(23, 109)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(144, 58)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Enter your grades!"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'frmAverageGrade2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(403, 189)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "frmAverageGrade2"
        Me.Text = "Find your average!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnEnter As Button
End Class

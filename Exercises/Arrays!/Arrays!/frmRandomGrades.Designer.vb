<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRandomGrades
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Azure
        Me.btnEnter.Location = New System.Drawing.Point(39, 31)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(144, 58)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "Enter your grades!"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Azure
        Me.btnCalculate.Location = New System.Drawing.Point(283, 31)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(144, 58)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate your average!!"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(76, 119)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(290, 94)
        Me.lblMessage.TabIndex = 7
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRandomGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(472, 252)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnEnter)
        Me.Name = "frmRandomGrades"
        Me.Text = "How many grades are you putting in?"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblMessage As Label
End Class

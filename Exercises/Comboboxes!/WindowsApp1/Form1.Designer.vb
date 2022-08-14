<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComboBoxes
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
        Me.btnColorChanger = New System.Windows.Forms.Button()
        Me.btnBands = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnDivider = New System.Windows.Forms.Button()
        Me.btnIceCream2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnColorChanger
        '
        Me.btnColorChanger.BackColor = System.Drawing.Color.LightPink
        Me.btnColorChanger.Location = New System.Drawing.Point(42, 39)
        Me.btnColorChanger.Name = "btnColorChanger"
        Me.btnColorChanger.Size = New System.Drawing.Size(115, 36)
        Me.btnColorChanger.TabIndex = 3
        Me.btnColorChanger.Text = "Design the form yourself!"
        Me.btnColorChanger.UseVisualStyleBackColor = False
        '
        'btnBands
        '
        Me.btnBands.BackColor = System.Drawing.Color.LightPink
        Me.btnBands.Location = New System.Drawing.Point(228, 39)
        Me.btnBands.Name = "btnBands"
        Me.btnBands.Size = New System.Drawing.Size(115, 36)
        Me.btnBands.TabIndex = 4
        Me.btnBands.Text = "Learn about band members!"
        Me.btnBands.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightPink
        Me.Button2.Location = New System.Drawing.Point(415, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 36)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "How 'bout a sweet treat?"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightPink
        Me.Button1.Location = New System.Drawing.Point(133, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Let's go to a concert!!! :D"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightPink
        Me.Button3.Location = New System.Drawing.Point(342, 121)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 36)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Let's have some lunch!"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnDivider
        '
        Me.btnDivider.BackColor = System.Drawing.Color.LightPink
        Me.btnDivider.Location = New System.Drawing.Point(12, 165)
        Me.btnDivider.Name = "btnDivider"
        Me.btnDivider.Size = New System.Drawing.Size(545, 26)
        Me.btnDivider.TabIndex = 8
        Me.btnDivider.Text = "Practice!"
        Me.btnDivider.UseVisualStyleBackColor = False
        '
        'btnIceCream2
        '
        Me.btnIceCream2.BackColor = System.Drawing.Color.LightPink
        Me.btnIceCream2.Location = New System.Drawing.Point(133, 209)
        Me.btnIceCream2.Name = "btnIceCream2"
        Me.btnIceCream2.Size = New System.Drawing.Size(115, 36)
        Me.btnIceCream2.TabIndex = 9
        Me.btnIceCream2.Text = "It's your birthday!!! :O"
        Me.btnIceCream2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightPink
        Me.Button4.Location = New System.Drawing.Point(342, 209)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 36)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "You want MORE ice cream?? :o"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'frmComboBoxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(584, 366)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnIceCream2)
        Me.Controls.Add(Me.btnDivider)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnBands)
        Me.Controls.Add(Me.btnColorChanger)
        Me.Name = "frmComboBoxes"
        Me.Text = "Let's see...!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnColorChanger As Button
    Friend WithEvents btnBands As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnDivider As Button
    Friend WithEvents btnIceCream2 As Button
    Friend WithEvents Button4 As Button
End Class

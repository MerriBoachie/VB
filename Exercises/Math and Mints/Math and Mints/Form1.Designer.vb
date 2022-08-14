<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoose
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
        Me.lblChooseOne = New System.Windows.Forms.Label()
        Me.lblOr = New System.Windows.Forms.Label()
        Me.btnMath = New System.Windows.Forms.Button()
        Me.btnMints = New System.Windows.Forms.Button()
        Me.btnDivider = New System.Windows.Forms.Button()
        Me.btnBacteria = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblChooseOne
        '
        Me.lblChooseOne.Location = New System.Drawing.Point(48, 27)
        Me.lblChooseOne.Name = "lblChooseOne"
        Me.lblChooseOne.Size = New System.Drawing.Size(186, 37)
        Me.lblChooseOne.TabIndex = 0
        Me.lblChooseOne.Text = "Choose one!"
        Me.lblChooseOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOr
        '
        Me.lblOr.Location = New System.Drawing.Point(126, 75)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(30, 24)
        Me.lblOr.TabIndex = 1
        Me.lblOr.Text = "or"
        Me.lblOr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMath
        '
        Me.btnMath.BackColor = System.Drawing.Color.LightPink
        Me.btnMath.Location = New System.Drawing.Point(18, 67)
        Me.btnMath.Name = "btnMath"
        Me.btnMath.Size = New System.Drawing.Size(102, 49)
        Me.btnMath.TabIndex = 2
        Me.btnMath.Text = "Math!"
        Me.btnMath.UseVisualStyleBackColor = False
        '
        'btnMints
        '
        Me.btnMints.BackColor = System.Drawing.Color.LightPink
        Me.btnMints.Location = New System.Drawing.Point(162, 67)
        Me.btnMints.Name = "btnMints"
        Me.btnMints.Size = New System.Drawing.Size(102, 49)
        Me.btnMints.TabIndex = 3
        Me.btnMints.Text = "Mints!"
        Me.btnMints.UseVisualStyleBackColor = False
        '
        'btnDivider
        '
        Me.btnDivider.BackColor = System.Drawing.Color.LightPink
        Me.btnDivider.Location = New System.Drawing.Point(18, 137)
        Me.btnDivider.Name = "btnDivider"
        Me.btnDivider.Size = New System.Drawing.Size(246, 15)
        Me.btnDivider.TabIndex = 4
        Me.btnDivider.UseVisualStyleBackColor = False
        '
        'btnBacteria
        '
        Me.btnBacteria.BackColor = System.Drawing.Color.LightPink
        Me.btnBacteria.Location = New System.Drawing.Point(92, 158)
        Me.btnBacteria.Name = "btnBacteria"
        Me.btnBacteria.Size = New System.Drawing.Size(102, 49)
        Me.btnBacteria.TabIndex = 5
        Me.btnBacteria.Text = "Bacteria Calculations?"
        Me.btnBacteria.UseVisualStyleBackColor = False
        '
        'frmChoose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(295, 232)
        Me.Controls.Add(Me.btnBacteria)
        Me.Controls.Add(Me.btnDivider)
        Me.Controls.Add(Me.btnMints)
        Me.Controls.Add(Me.btnMath)
        Me.Controls.Add(Me.lblOr)
        Me.Controls.Add(Me.lblChooseOne)
        Me.Name = "frmChoose"
        Me.Text = "Choose one!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblChooseOne As Label
    Friend WithEvents lblOr As Label
    Friend WithEvents btnMath As Button
    Friend WithEvents btnMints As Button
    Friend WithEvents btnDivider As Button
    Friend WithEvents btnBacteria As Button
End Class

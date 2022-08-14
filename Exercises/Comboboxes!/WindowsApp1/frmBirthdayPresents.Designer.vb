<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBirthdayPresents
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
        Me.btnBirthday = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnBirthday
        '
        Me.btnBirthday.BackColor = System.Drawing.Color.FloralWhite
        Me.btnBirthday.Location = New System.Drawing.Point(48, 25)
        Me.btnBirthday.Name = "btnBirthday"
        Me.btnBirthday.Size = New System.Drawing.Size(217, 47)
        Me.btnBirthday.TabIndex = 0
        Me.btnBirthday.Text = "What would you like for your birthday???"
        Me.btnBirthday.UseVisualStyleBackColor = False
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Items.AddRange(New Object() {" "})
        Me.lstOutput.Location = New System.Drawing.Point(39, 105)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(239, 147)
        Me.lstOutput.TabIndex = 1
        '
        'frmBirthdayPresents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(326, 301)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnBirthday)
        Me.Name = "frmBirthdayPresents"
        Me.Text = "Hooray!!! :D"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBirthday As Button
    Friend WithEvents lstOutput As ListBox
End Class

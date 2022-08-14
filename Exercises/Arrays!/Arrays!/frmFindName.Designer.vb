<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindName
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SeaShell
        Me.btnSearch.Location = New System.Drawing.Point(76, 28)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(151, 46)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Find a name!"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(57, 95)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(191, 117)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFindName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(310, 258)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "frmFindName"
        Me.Text = "Search for a name in our roster!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents lblOutput As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKicks
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
        Me.components = New System.ComponentModel.Container()
        Me.picStickFigure = New System.Windows.Forms.PictureBox()
        Me.tmrKick = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picStickFigure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picStickFigure
        '
        Me.picStickFigure.Image = Global.Pictures_.My.Resources.Resources.stand
        Me.picStickFigure.Location = New System.Drawing.Point(58, 12)
        Me.picStickFigure.Name = "picStickFigure"
        Me.picStickFigure.Size = New System.Drawing.Size(283, 317)
        Me.picStickFigure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStickFigure.TabIndex = 0
        Me.picStickFigure.TabStop = False
        '
        'tmrKick
        '
        Me.tmrKick.Enabled = True
        Me.tmrKick.Interval = 500
        '
        'frmKicks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(425, 339)
        Me.Controls.Add(Me.picStickFigure)
        Me.Name = "frmKicks"
        Me.Text = "Time to get kicking!"
        CType(Me.picStickFigure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picStickFigure As PictureBox
    Friend WithEvents tmrKick As Timer
End Class

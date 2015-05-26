<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resign
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
        Me.btnresign = New System.Windows.Forms.Button()
        Me.lbresign = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnresign
        '
        Me.btnresign.Location = New System.Drawing.Point(156, 243)
        Me.btnresign.Name = "btnresign"
        Me.btnresign.Size = New System.Drawing.Size(75, 23)
        Me.btnresign.TabIndex = 1
        Me.btnresign.Text = "Resign"
        Me.btnresign.UseVisualStyleBackColor = True
        '
        'lbresign
        '
        Me.lbresign.GridLines = True
        Me.lbresign.Location = New System.Drawing.Point(12, 12)
        Me.lbresign.Name = "lbresign"
        Me.lbresign.Size = New System.Drawing.Size(371, 225)
        Me.lbresign.TabIndex = 2
        Me.lbresign.UseCompatibleStateImageBehavior = False
        Me.lbresign.View = System.Windows.Forms.View.Details
        '
        'resign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 279)
        Me.Controls.Add(Me.lbresign)
        Me.Controls.Add(Me.btnresign)
        Me.Name = "resign"
        Me.Text = "Resign"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnresign As System.Windows.Forms.Button
    Friend WithEvents lbresign As System.Windows.Forms.ListView
End Class

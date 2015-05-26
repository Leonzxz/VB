<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewkar
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
        Me.btnviewdet = New System.Windows.Forms.Button()
        Me.lbkaryawan = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnviewdet
        '
        Me.btnviewdet.Location = New System.Drawing.Point(155, 256)
        Me.btnviewdet.Name = "btnviewdet"
        Me.btnviewdet.Size = New System.Drawing.Size(75, 23)
        Me.btnviewdet.TabIndex = 1
        Me.btnviewdet.Text = "View Detail"
        Me.btnviewdet.UseVisualStyleBackColor = True
        '
        'lbkaryawan
        '
        Me.lbkaryawan.GridLines = True
        Me.lbkaryawan.Location = New System.Drawing.Point(12, 12)
        Me.lbkaryawan.Name = "lbkaryawan"
        Me.lbkaryawan.Size = New System.Drawing.Size(375, 238)
        Me.lbkaryawan.TabIndex = 2
        Me.lbkaryawan.UseCompatibleStateImageBehavior = False
        Me.lbkaryawan.View = System.Windows.Forms.View.Details
        '
        'viewkar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 291)
        Me.Controls.Add(Me.lbkaryawan)
        Me.Controls.Add(Me.btnviewdet)
        Me.Name = "viewkar"
        Me.Text = "View Karyawan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnviewdet As System.Windows.Forms.Button
    Friend WithEvents lbkaryawan As System.Windows.Forms.ListView
End Class

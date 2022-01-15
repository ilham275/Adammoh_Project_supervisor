<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kepsek
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
        Me.Logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Logout
        '
        Me.Logout.Location = New System.Drawing.Point(144, 106)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(82, 43)
        Me.Logout.TabIndex = 0
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Kepsek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Logout)
        Me.Name = "Kepsek"
        Me.Text = "Kepala Sekolah"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Logout As Button
End Class

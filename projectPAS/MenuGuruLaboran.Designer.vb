<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuGuruLaboran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnJadwal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 12)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(89, 37)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "Input Data"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnJadwal
        '
        Me.btnJadwal.Location = New System.Drawing.Point(12, 55)
        Me.btnJadwal.Name = "btnJadwal"
        Me.btnJadwal.Size = New System.Drawing.Size(209, 43)
        Me.btnJadwal.TabIndex = 1
        Me.btnJadwal.Text = "Lihat Jadwal Dan Supervisor"
        Me.btnJadwal.UseVisualStyleBackColor = True
        '
        'MenuGuruLaboran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnJadwal)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "MenuGuruLaboran"
        Me.Text = "Menu Guru"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInput As Button
    Friend WithEvents btnJadwal As Button
End Class

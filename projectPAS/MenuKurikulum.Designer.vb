<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuKurikulum
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
        Me.btnBuatAkun = New System.Windows.Forms.Button()
        Me.btnSupervisi = New System.Windows.Forms.Button()
        Me.btnBuatJadwal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBuatAkun
        '
        Me.btnBuatAkun.Location = New System.Drawing.Point(12, 12)
        Me.btnBuatAkun.Name = "btnBuatAkun"
        Me.btnBuatAkun.Size = New System.Drawing.Size(100, 36)
        Me.btnBuatAkun.TabIndex = 0
        Me.btnBuatAkun.Text = "Buat Akun"
        Me.btnBuatAkun.UseVisualStyleBackColor = True
        '
        'btnSupervisi
        '
        Me.btnSupervisi.Location = New System.Drawing.Point(12, 54)
        Me.btnSupervisi.Name = "btnSupervisi"
        Me.btnSupervisi.Size = New System.Drawing.Size(167, 36)
        Me.btnSupervisi.TabIndex = 1
        Me.btnSupervisi.Text = "Membuat Supervisor"
        Me.btnSupervisi.UseVisualStyleBackColor = True
        '
        'btnBuatJadwal
        '
        Me.btnBuatJadwal.Location = New System.Drawing.Point(12, 96)
        Me.btnBuatJadwal.Name = "btnBuatJadwal"
        Me.btnBuatJadwal.Size = New System.Drawing.Size(100, 36)
        Me.btnBuatJadwal.TabIndex = 2
        Me.btnBuatJadwal.Text = "Buat Jadwal"
        Me.btnBuatJadwal.UseVisualStyleBackColor = True
        '
        'MenuKurikulum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBuatJadwal)
        Me.Controls.Add(Me.btnSupervisi)
        Me.Controls.Add(Me.btnBuatAkun)
        Me.Name = "MenuKurikulum"
        Me.Text = "MenuKurikulum"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBuatAkun As Button
    Friend WithEvents btnSupervisi As Button
    Friend WithEvents btnBuatJadwal As Button
End Class

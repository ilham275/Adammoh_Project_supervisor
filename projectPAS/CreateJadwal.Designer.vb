<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateJadwal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_tgl = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_hari = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJam1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJam2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRuangan = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal"
        '
        'dt_tgl
        '
        Me.dt_tgl.Location = New System.Drawing.Point(93, 53)
        Me.dt_tgl.Name = "dt_tgl"
        Me.dt_tgl.Size = New System.Drawing.Size(200, 22)
        Me.dt_tgl.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hari"
        '
        'cb_hari
        '
        Me.cb_hari.FormattingEnabled = True
        Me.cb_hari.Location = New System.Drawing.Point(93, 98)
        Me.cb_hari.Name = "cb_hari"
        Me.cb_hari.Size = New System.Drawing.Size(200, 24)
        Me.cb_hari.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jam"
        '
        'txtJam1
        '
        Me.txtJam1.Location = New System.Drawing.Point(93, 146)
        Me.txtJam1.Name = "txtJam1"
        Me.txtJam1.Size = New System.Drawing.Size(79, 22)
        Me.txtJam1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(178, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = " - "
        '
        'txtJam2
        '
        Me.txtJam2.Location = New System.Drawing.Point(205, 148)
        Me.txtJam2.Name = "txtJam2"
        Me.txtJam2.Size = New System.Drawing.Size(79, 22)
        Me.txtJam2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Ruangan"
        '
        'txtRuangan
        '
        Me.txtRuangan.Location = New System.Drawing.Point(93, 191)
        Me.txtRuangan.Name = "txtRuangan"
        Me.txtRuangan.Size = New System.Drawing.Size(200, 22)
        Me.txtRuangan.TabIndex = 11
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(14, 236)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(94, 36)
        Me.btnCreate.TabIndex = 12
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(114, 236)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(94, 36)
        Me.btnBatal.TabIndex = 13
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(93, 11)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(200, 22)
        Me.txtNIP.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "NIP"
        '
        'CreateJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtRuangan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtJam2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtJam1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_hari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dt_tgl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateJadwal"
        Me.Text = "CreateJadwal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dt_tgl As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_hari As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJam1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJam2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRuangan As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents Label7 As Label
End Class

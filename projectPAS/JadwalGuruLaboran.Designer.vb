<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JadwalGuruLaboran
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
        Me.txtSpv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.lBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lBox2 = New System.Windows.Forms.ListBox()
        Me.cb_hari = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supervisor Anda: "
        '
        'txtSpv
        '
        Me.txtSpv.Location = New System.Drawing.Point(139, 9)
        Me.txtSpv.Multiline = True
        Me.txtSpv.Name = "txtSpv"
        Me.txtSpv.Size = New System.Drawing.Size(178, 35)
        Me.txtSpv.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Masukan Hari:"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(342, 66)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(91, 35)
        Me.btnCari.TabIndex = 4
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'lBox1
        '
        Me.lBox1.FormattingEnabled = True
        Me.lBox1.ItemHeight = 16
        Me.lBox1.Location = New System.Drawing.Point(15, 158)
        Me.lBox1.Name = "lBox1"
        Me.lBox1.Size = New System.Drawing.Size(189, 260)
        Me.lBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ruangan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jam"
        '
        'lBox2
        '
        Me.lBox2.FormattingEnabled = True
        Me.lBox2.ItemHeight = 16
        Me.lBox2.Location = New System.Drawing.Point(244, 158)
        Me.lBox2.Name = "lBox2"
        Me.lBox2.Size = New System.Drawing.Size(189, 260)
        Me.lBox2.TabIndex = 7
        '
        'cb_hari
        '
        Me.cb_hari.FormattingEnabled = True
        Me.cb_hari.Location = New System.Drawing.Point(139, 69)
        Me.cb_hari.Name = "cb_hari"
        Me.cb_hari.Size = New System.Drawing.Size(178, 24)
        Me.cb_hari.TabIndex = 9
        '
        'JadwalGuruLaboran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cb_hari)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lBox1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSpv)
        Me.Controls.Add(Me.Label1)
        Me.Name = "JadwalGuruLaboran"
        Me.Text = "JadwalGuruLaboran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSpv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents lBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lBox2 As ListBox
    Friend WithEvents cb_hari As ComboBox
End Class

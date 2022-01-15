<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuruLaboran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuruLaboran))
        Me.txtMapel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLink = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLokasi = New System.Windows.Forms.TextBox()
        Me.PDF = New AxAcroPDFLib.AxAcroPDF()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtRefresh = New System.Windows.Forms.Button()
        CType(Me.PDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMapel
        '
        Me.txtMapel.Location = New System.Drawing.Point(107, 62)
        Me.txtMapel.Multiline = True
        Me.txtMapel.Name = "txtMapel"
        Me.txtMapel.Size = New System.Drawing.Size(161, 35)
        Me.txtMapel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mapel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Link Video"
        '
        'txtLink
        '
        Me.txtLink.Location = New System.Drawing.Point(107, 119)
        Me.txtLink.Multiline = True
        Me.txtLink.Name = "txtLink"
        Me.txtLink.Size = New System.Drawing.Size(368, 35)
        Me.txtLink.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lokasi RPP"
        '
        'txtLokasi
        '
        Me.txtLokasi.Location = New System.Drawing.Point(107, 183)
        Me.txtLokasi.Multiline = True
        Me.txtLokasi.Name = "txtLokasi"
        Me.txtLokasi.Size = New System.Drawing.Size(191, 63)
        Me.txtLokasi.TabIndex = 4
        '
        'PDF
        '
        Me.PDF.Enabled = True
        Me.PDF.Location = New System.Drawing.Point(648, 12)
        Me.PDF.Name = "PDF"
        Me.PDF.OcxState = CType(resources.GetObject("PDF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PDF.Size = New System.Drawing.Size(459, 519)
        Me.PDF.TabIndex = 6
        '
        'OFD1
        '
        Me.OFD1.FileName = "OpenFileDialog1"
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(15, 319)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidth = 51
        Me.DGV1.RowTemplate.Height = 24
        Me.DGV1.Size = New System.Drawing.Size(627, 212)
        Me.DGV1.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(15, 264)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 39)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(121, 264)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 39)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(227, 264)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 39)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "NIP"
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(107, 12)
        Me.txtNIP.Multiline = True
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(161, 35)
        Me.txtNIP.TabIndex = 11
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(314, 183)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(100, 39)
        Me.btnBrowse.TabIndex = 13
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(542, 264)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 39)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(314, 228)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(59, 17)
        Me.txtID.TabIndex = 15
        '
        'txtRefresh
        '
        Me.txtRefresh.Location = New System.Drawing.Point(333, 264)
        Me.txtRefresh.Name = "txtRefresh"
        Me.txtRefresh.Size = New System.Drawing.Size(100, 39)
        Me.txtRefresh.TabIndex = 18
        Me.txtRefresh.Text = "Refresh"
        Me.txtRefresh.UseVisualStyleBackColor = True
        '
        'GuruLaboran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 543)
        Me.Controls.Add(Me.txtRefresh)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.PDF)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLokasi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLink)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMapel)
        Me.Name = "GuruLaboran"
        Me.Text = "GuruLaboran"
        CType(Me.PDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMapel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLink As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents PDF As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents OFD1 As OpenFileDialog
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtRefresh As Button
End Class

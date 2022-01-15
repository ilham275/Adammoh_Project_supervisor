<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNip1 = New System.Windows.Forms.TextBox()
        Me.txtNip2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbRole = New System.Windows.Forms.ComboBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.CloseEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIP"
        '
        'txtNip1
        '
        Me.txtNip1.Location = New System.Drawing.Point(70, 13)
        Me.txtNip1.Multiline = True
        Me.txtNip1.Name = "txtNip1"
        Me.txtNip1.Size = New System.Drawing.Size(159, 32)
        Me.txtNip1.TabIndex = 2
        '
        'txtNip2
        '
        Me.txtNip2.Location = New System.Drawing.Point(70, 63)
        Me.txtNip2.Multiline = True
        Me.txtNip2.Name = "txtNip2"
        Me.txtNip2.Size = New System.Drawing.Size(159, 32)
        Me.txtNip2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Role"
        '
        'cbRole
        '
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Location = New System.Drawing.Point(70, 111)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(159, 24)
        Me.cbRole.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(70, 158)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(159, 29)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'CloseEnd
        '
        Me.CloseEnd.Location = New System.Drawing.Point(292, 158)
        Me.CloseEnd.Name = "CloseEnd"
        Me.CloseEnd.Size = New System.Drawing.Size(159, 29)
        Me.CloseEnd.TabIndex = 7
        Me.CloseEnd.Text = "Close"
        Me.CloseEnd.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CloseEnd)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.cbRole)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNip2)
        Me.Controls.Add(Me.txtNip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Form Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNip1 As TextBox
    Friend WithEvents txtNip2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents CloseEnd As Button
End Class

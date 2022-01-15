Imports System.Data.SqlClient
Imports System.Configuration
Imports Google.Apis.Auth
Imports Google.Apis.Download
Imports Google.Apis.Drive.v2
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports System.Threading
Imports Google.Apis.Drive.v2.Data

Public Class GuruLaboran

    Dim CONN As SqlConnection
    Dim CMD As SqlCommand
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim RD As SqlDataReader
    Dim DT As DataTable
    Dim LokasiData As String
    Const nama_komputer = "DESKTOP-1A4QD9P"
    Const nama_db = "PAS"
    Dim nipLogin As String = Login.txtNip1.Text
    Dim Service As New DriveService
    Private Sub GuruLaboran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Login.connection()
        Call tampil()
        txtLokasi.Enabled = False

        txtNIP.Text = nipLogin
        txtNIP.Enabled = False
        txtID.Visible = False

    End Sub

    Sub connection()
        LokasiData = "data source='" & nama_komputer & "';initial catalog='" & nama_db & "';integrated security=true"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

    Sub tampil()
        Call connection()
        DA = New SqlDataAdapter("SELECT * FROM tb_dokumen where NIP = '" & nipLogin & "'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_dokumen")
        DGV1.DataSource = (DS.Tables("tb_dokumen"))
        DGV1.ReadOnly = True

    End Sub

    Sub GotIt()
        txtMapel.Text = RD(2)
        txtLokasi.Text = RD(3)
        txtLink.Text = RD(4)
        txtNIP.Focus()
        PDF.src = (txtLokasi.Text)
    End Sub

    Sub Kosongkan()
        On Error Resume Next
        'txtNIP.Clear()
        txtMapel.Clear()
        txtLink.Clear()
        txtLokasi.Clear()
        txtNIP.Focus()
        PDF.src = (txtLokasi.Text)
    End Sub

    Sub caridata()
        Call connection()
        Dim queryString As String = "SELECT * FROM tb_dokumen WHERE ID = '" & txtID.Text & "'"
        CMD = New SqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader
        RD.Read()

    End Sub
    Sub saveData()
        If txtNIP.Text = "" Or txtMapel.Text = "" Or txtLink.Text = "" Or txtLokasi.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong!")
        End If

        Try
            Call connection()
            Dim queryStringSimpan As String = "INSERT INTO tb_dokumen VALUES('" & nipLogin & "','" & txtMapel.Text & "','" & txtLokasi.Text & "','" & txtLink.Text & "','Menunggu Supervisi','')"
            CMD = New SqlCommand(queryStringSimpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")

            Call Kosongkan()
            Call tampil()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub UpdateData()
        Call connection()

        Dim hasil As DialogResult = MessageBox.Show("Yakin Ingin Mengupdate Data?", "Alert!", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            Try
                Dim queryStringUpdate As String = "UPDATE tb_dokumen set Mapel = '" & txtMapel.Text & "', RPP = '" & txtLokasi.Text & "', Embed = '" & txtLink.Text & "' where ID = '" & txtID.Text & "'"
                CMD = New SqlCommand(queryStringUpdate, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Diupdate")
                Call Kosongkan()
                Call tampil()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

        End If


    End Sub

    Sub DeleteData()
        Call connection()

        Dim hasil As DialogResult = MessageBox.Show("Yakin Ingin Menghapus Data?", "Alert!", MessageBoxButtons.YesNo)
        If hasil = DialogResult.Yes Then
            Try
                Dim queryStringUpdate As String = "Delete tb_dokumen where ID = '" & txtID.Text & "'"
                CMD = New SqlCommand(queryStringUpdate, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Didelete")
                Call Kosongkan()
                Call tampil()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

        End If


    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call connection()
        'Call RunUploadToGDrive()
        Call saveData()
        Call tampil()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim f As New OpenFileDialog
        If f.ShowDialog = DialogResult.OK Then
            txtLokasi.Text = f.FileName
            PDF.src = (txtLokasi.Text)
        Else
            Exit Sub

        End If

    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim hasil As DialogResult = MessageBox.Show("Yakin ingin Logout?", "Alert!", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            Login.Show()
            Me.Hide()
        Else

        End If

    End Sub

    Private Sub GuruLaboran_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim widhtForm As Integer = Me.Width
        Dim heightForm As Integer = Me.Height
        PDF.Size = New Drawing.Size(widhtForm - 809, heightForm - 71)
    End Sub

    Private Sub DGV1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseClick
        txtID.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
        Call caridata()
        If RD.HasRows Then
            Call GotIt()
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call connection()
        Call UpdateData()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call connection()
        Call DeleteData()

    End Sub

    Private Sub TxtRefresh_Click(sender As Object, e As EventArgs) Handles txtRefresh.Click
        Call tampil()

    End Sub

    'Private Sub UploadToGDrive()
    '    Dim clientID = "414264131631-aj2qh0ggl9kljtevj648toq4mn64dki7.apps.googleusercontent.com"
    '    Dim clientSecret = "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"

    '    Dim uc As UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(New ClientSecrets() With {.ClientId = clientID, .ClientSecret = clientSecret}, {DriveService.Scope.Drive}, "user", CancellationToken.None).Result
    '    Service = New DriveService(New BaseClientService.Initializer() With {.HttpClientInitializer = uc, .ApplicationName = "Desktop client 1"})

    'End Sub

    'Private Sub RunUploadToGDrive()
    '    If Service.ApplicationName <> "Desktops client 1" Then
    '        Call UploadToGDrive()
    '        Dim myfile As New File
    '        Dim bytearray As Byte() = System.IO.File.ReadAllBytes(txtLokasi.Text)
    '        Dim stream As New System.IO.MemoryStream(bytearray)
    '        Dim uploadrequest As FilesResource.InsertMediaUpload = Service.Files.Insert(myfile, stream, myfile.MimeType)
    '        uploadrequest.Upload()
    '        Dim file As File = uploadrequest.ResponseBody
    '        MessageBox.Show("File RPP Berhasil Terupload Ke Google Drive. Dengan ID: " & file.Id)
    '    End If
    'End Sub
End Class
Imports System.Data.SqlClient
Public Class TambahAkun

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
    Private Sub TambahAkun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

        cb_J1.Items.Add("")
        cb_J1.Items.Add("Kepsek")
        cb_J1.Items.Add("Kurikulum")

        cb_j2.Items.Add("")
        cb_j2.Items.Add("Guru/Laboran")

    End Sub

    Sub connection()
        LokasiData = "data source='" & nama_komputer & "';initial catalog='" & nama_db & "';integrated security=true"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

    Sub kosongkan()
        txtNIP.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtEmail.Text = ""
        cb_J1.Text = ""
        cb_j2.Text = ""
    End Sub

    Sub saveData()
        Call connection()
        Dim queryString As String = "INSERT INTO tb_guru SELECT '" & txtNIP.Text & "','" & txtNama.Text & "','" & txtAlamat.Text & "','" & txtEmail.Text & "','" & cb_J1.SelectedItem & "','" & cb_j2.Text & "',''"
        CMD = New SqlCommand(queryString, CONN)
        CMD.ExecuteNonQuery()

        MessageBox.Show("Akun Berhasil Tersimpan!")
        Call kosongkan()


    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call kosongkan()

    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Call connection()
        Call saveData()

    End Sub

End Class
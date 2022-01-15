Imports System.Data.SqlClient
Public Class CreateJadwal

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

    Sub connection()
        LokasiData = "data source='" & nama_komputer & "';initial catalog='" & nama_db & "';integrated security=true"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

    Private Sub CreateJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()


        cb_hari.Items.Add("Senin")
        cb_hari.Items.Add("Selasa")
        cb_hari.Items.Add("Rabu")
        cb_hari.Items.Add("Kamis")
        cb_hari.Items.Add("Jumat")
        cb_hari.Items.Add("Sabtu")

        txtNIP.Focus()

        'Call isiSPV()
    End Sub

    Sub kosongkan()
        txtNIP.Text = ""
        cb_hari.Text = ""
        txtJam1.Text = ""
        txtJam2.Text = ""
        txtRuangan.Text = ""
    End Sub

    'Sub isiSPV()
    '    Call connection()

    '    Dim queryString As String = "SELECT NIP,nama FROM tb_supervisor where status like '%belum%'"
    '    CMD = New SqlCommand(queryString, CONN)
    '    RD = CMD.ExecuteReader

    '    If RD.HasRows Then
    '        Do While RD.Read()
    '            cbSpv.Items.Add(RD.Item(0) + " - " + RD.Item(1))
    '        Loop
    '    End If
    'End Sub

    Sub saveData()
        Call connection()

        Dim queryString As String = "INSERT into tb_Jadwal SELECT '" & txtNIP.Text & "','" & dt_tgl.Value & "','" & cb_hari.SelectedItem & "','" & txtJam1.Text & "' + '-' + '" & txtJam2.Text & "','','" & txtRuangan.Text & "'"
        CMD = New SqlCommand(queryString, CONN)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Jadwal Berhasil Tersimpan!")
        Call kosongkan()


    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Call connection()
        Call saveData()

    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call connection()
        Call kosongkan()

    End Sub
End Class
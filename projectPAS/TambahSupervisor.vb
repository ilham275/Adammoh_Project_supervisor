Imports System.Data.SqlClient
Public Class TambahSupervisor

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


    Private Sub TambahSupervisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call TampilNIP()


    End Sub

    Sub TampilNIP()
        Call connection()

        Dim queryString As String = "SELECT * FROM tb_guru WHERE spv not like '%ya%'"
        CMD = New SqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader

        If RD.HasRows Then
            Do While RD.Read()
                cb_NIP.Items.Add(RD.Item(0) + " - " + RD.Item(1))
            Loop
        End If

    End Sub

    Sub kosongkan()
        cb_NIP.Text = ""
    End Sub

    Sub UpdateData()
        Call connection()

        Dim StringAwal As String
        Dim subString As String
        StringAwal = cb_NIP.SelectedItem
        subString = StringAwal.Substring(0, 2)

        Dim queryString As String = "UPDATE tb_guru set spv = 'Ya' FROM tb_guru WHERE NIP = '" & subString & "'"
        CMD = New SqlCommand(queryString, CONN)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Berhasil Menjadikan Supervisor!")
        Call kosongkan()


    End Sub

    Sub connection()
        LokasiData = "data source='" & nama_komputer & "';initial catalog='" & nama_db & "';integrated security=true"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuKurikulum.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call connection()
        Call UpdateData()

    End Sub
End Class
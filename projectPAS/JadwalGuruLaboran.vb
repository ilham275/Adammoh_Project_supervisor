Imports System.Data.SqlClient
Public Class JadwalGuruLaboran

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
    Private Sub JadwalGuruLaboran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        txtSpv.Enabled = False
        Dim queryString As String = "select * from tb_Jadwal where DAY(Tanggal) = DAY(GETDATE())"
        CMD = New SqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        txtSpv.Text = RD.Item("id_Supervisor")

        cb_hari.Items.Add("Senin")
        cb_hari.Items.Add("Selasa")
        cb_hari.Items.Add("Rabu")
        cb_hari.Items.Add("Kamis")
        cb_hari.Items.Add("Jumat")
        cb_hari.Items.Add("Sabtu")

    End Sub

    Sub connection()
        LokasiData = "data source='" & nama_komputer & "';initial catalog='" & nama_db & "';integrated security=true"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

    Sub searchData()
        Call connection()
        Dim queryString As String = "SELECT * FROM tb_Jadwal where Hari like '%" & cb_hari.Text & "%'"
        CMD = New SqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader
        'RD.Read()

        Dim x
        x = cb_hari.SelectedItem

        Select Case x
            Case "Senin"
                lBox1.Items.Clear()
                lBox2.Items.Clear()
                If RD.HasRows Then
                    Do While RD.Read
                        lBox1.Items.Add(RD.Item("Ruangan").ToString)
                        lBox2.Items.Add(RD.Item("Jam").ToString)

                    Loop
                End If
            Case "Selasa"
                lBox1.Items.Clear()
                lBox2.Items.Clear()
                If RD.HasRows Then
                    Do While RD.Read
                        lBox1.Items.Add(RD.Item("Ruangan").ToString)
                        lBox2.Items.Add(RD.Item("Jam").ToString)

                    Loop
                End If
            Case "Rabu"
                lBox1.Items.Clear()
                lBox2.Items.Clear()
                If RD.HasRows Then
                    Do While RD.Read
                        lBox1.Items.Add(RD.Item("Ruangan").ToString)
                        lBox2.Items.Add(RD.Item("Jam").ToString)

                    Loop
                End If
            Case "Kamis"
                lBox1.Items.Clear()
                lBox2.Items.Clear()
                If RD.HasRows Then
                    Do While RD.Read
                        lBox1.Items.Add(RD.Item("Ruangan").ToString)
                        lBox2.Items.Add(RD.Item("Jam").ToString)

                    Loop
                End If
            Case "Jumat"
                lBox1.Items.Clear()
                lBox2.Items.Clear()
                If RD.HasRows Then
                    Do While RD.Read
                        lBox1.Items.Add(RD.Item("Ruangan").ToString)
                        lBox2.Items.Add(RD.Item("Jam").ToString)

                    Loop
                End If
            Case "Sabtu"
                lBox1.Items.Clear()
                lBox2.Items.Clear()
                If RD.HasRows Then
                    Do While RD.Read
                        lBox1.Items.Add(RD.Item("Ruangan").ToString)
                        lBox2.Items.Add(RD.Item("Jam").ToString)

                    Loop
                End If
        End Select
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call connection()
        Call searchData()

    End Sub
End Class
Imports System.Data.SqlClient
Public Class Login

    Dim CONN As SqlConnection
    Dim CMD As SqlCommand
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim RD As SqlDataReader
    Dim DT As DataTable
    Dim LokasiData As String
    Const nama_komputer = "DESKTOP-1A4QD9P"
    Const nama_db = "PAS"
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        cbRole.Items.Add("Kurikulum")
        cbRole.Items.Add("Guru/Laboran")
        cbRole.Items.Add("Supervisor")
        cbRole.Items.Add("Kepsek")
        'Call tampil()
    End Sub

    Sub connection()
        LokasiData = "data source='" & nama_komputer & "';initial catalog='" & nama_db & "';integrated security=true"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

    Public Sub login()
        Call connection()
        Dim logics1 As String = "SELECT * FROM tb_guru where NIP = '" & txtNip1.Text & "' and NIP = '" & txtNip2.Text & "' and (jb1 = '" & cbRole.SelectedItem & "' or jb2 = '" & cbRole.SelectedItem & "')"
        CMD = New SqlCommand(logics1, CONN)
        DA = New SqlDataAdapter(CMD)
        DT = New DataTable
        DA.Fill(DT)
        'Logics 2
        Dim logics2 As String = "SELECT * FROM tb_guru where NIP = '" & txtNip1.Text & "' and NIP = '" & txtNip2.Text & "' and spv = 'Ya' and (jb1 = 'Kurikulum' or jb2 = 'Kurikulum')"
        Dim CMD2 = New SqlCommand(logics2, CONN)
        Dim DA2 = New SqlDataAdapter(CMD2)
        Dim DT2 = New DataTable
        DA2.Fill(DT2)
        'Logics 3
        Dim logics3 As String = "SELECT * FROM tb_guru where NIP = '" & txtNip1.Text & "' and NIP = '" & txtNip2.Text & "' and spv = 'Ya'"
        Dim CMD3 = New SqlCommand(logics3, CONN)
        Dim DA3 = New SqlDataAdapter(CMD3)
        Dim DT3 = New DataTable
        DA3.Fill(DT3)

        If txtNip1.Text = "" Or txtNip2.Text = "" Or cbRole.SelectedItem = "" Then
            MsgBox("Data Tidak Boleh Kosong!")
        ElseIf (DT.Rows.Count > 0 And cbRole.SelectedItem = "Guru/Laboran") Then
            MenuGuruLaboran.Show()
            Me.Hide()
            MessageBox.Show("Anda Login Sebagai " + cbRole.SelectedItem)
        ElseIf (DT.Rows.Count > 0 And cbRole.SelectedItem = "Kurikulum") Then
            MenuKurikulum.Show()
            Me.Hide()
            MessageBox.Show("Anda Login Sebagai " + cbRole.SelectedItem)
        ElseIf (DT.Rows.Count > 0 And cbRole.SelectedItem = "KEPSEK") Then
            Kepsek.Show()
            Me.Hide()
            MessageBox.Show("Anda Login Sebagai " + cbRole.SelectedItem)
        ElseIf (DT2.Rows.Count > 0 And cbRole.SelectedItem = "Supervisor") Then
            Supervisor.Show()
            Me.Hide()
            MessageBox.Show("Anda Login Sebagai " + cbRole.SelectedItem)
        ElseIf (DT3.Rows.Count > 0 And cbRole.SelectedItem = "Supervisor") Then
            Supervisor.Show()
            Me.Hide()
            MessageBox.Show("Anda Login Sebagai " + cbRole.SelectedItem)
        Else
            MessageBox.Show("Anda Tidak Memiliki Role Tersebut")
            txtNip1.Text = ""
            txtNip2.Text = ""
            cbRole.Text = ""
        End If

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call connection()
        Call login()

    End Sub

    Private Sub txtNip1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNip1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
        txtNip1.ShortcutsEnabled = False
        txtNip1.MaxLength = 10
    End Sub

    Private Sub txtNip2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNip2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
        txtNip2.ShortcutsEnabled = False
        txtNip2.MaxLength = 10
    End Sub

    Private Sub CloseEnd_Click(sender As Object, e As EventArgs) Handles CloseEnd.Click
        Me.Close()

    End Sub
End Class

Public Class MenuKurikulum
    Private Sub BtnBuatAkun_Click(sender As Object, e As EventArgs) Handles btnBuatAkun.Click
        TambahAkun.Show()
        Me.Hide()

    End Sub

    Private Sub BtnBuatJadwal_Click(sender As Object, e As EventArgs) Handles btnBuatJadwal.Click
        CreateJadwal.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSupervisi_Click(sender As Object, e As EventArgs) Handles btnSupervisi.Click
        TambahSupervisor.Show()
        Me.Hide()

    End Sub
End Class
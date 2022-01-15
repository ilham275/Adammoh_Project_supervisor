Public Class MenuGuruLaboran
    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        GuruLaboran.Show()
        Me.Hide()
    End Sub

    Private Sub BtnJadwal_Click(sender As Object, e As EventArgs) Handles btnJadwal.Click
        JadwalGuruLaboran.Show()
        Me.Hide()
    End Sub
End Class
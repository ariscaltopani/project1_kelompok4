Public Class Form2

    Private Sub DataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataToolStripMenuItem.Click

    End Sub

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DetailPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailPenjualanToolStripMenuItem.Click
        Me.Hide()
        Barang.Show()

    End Sub

    Private Sub DetailPenjualanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailPenjualanToolStripMenuItem1.Click
        Me.Hide()
        Detail_Penjualan.Show()

    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaryawanToolStripMenuItem.Click
        Me.Hide()
        Karyawan.Show()

    End Sub
End Class
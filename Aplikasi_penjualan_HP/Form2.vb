Public Class Form2

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        Me.Hide()
        Barang.Show()

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        Me.Hide()
        Customer.Show()

    End Sub

    Private Sub DetailPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailPenjualanToolStripMenuItem.Click
        Me.Hide()
        Detail_Penjualan.Show()
    End Sub

    
    Private Sub DataStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataStaffToolStripMenuItem.Click
        Me.Hide()
        Karyawan.Show()

    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        Form1.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Close()

    End Sub
End Class
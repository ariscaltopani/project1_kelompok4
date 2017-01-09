Public Class Invoice

    Private Sub Data_transaksiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Data_transaksiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Data_transaksiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kelompok2DataSet)

    End Sub

    Private Sub Invoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kelompok2DataSet.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.Kelompok2DataSet.barang)
        'TODO: This line of code loads data into the 'Kelompok2DataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Kelompok2DataSet.customer)
        'TODO: This line of code loads data into the 'Kelompok2DataSet.data_transaksi' table. You can move, or remove it, as needed.
        Me.Data_transaksiTableAdapter.Fill(Me.Kelompok2DataSet.data_transaksi)

    End Sub

    Private Sub HargaLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Detail_Penjualan.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class
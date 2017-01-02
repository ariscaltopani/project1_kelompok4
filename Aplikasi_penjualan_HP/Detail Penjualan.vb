Public Class Detail_Penjualan

    Private Sub Data_transaksiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Data_transaksiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kelompok2DataSet)

    End Sub

    Private Sub Detail_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kelompok2DataSet.sales_has_barang' table. You can move, or remove it, as needed.
        Me.Sales_has_barangTableAdapter.Fill(Me.Kelompok2DataSet.sales_has_barang)
        'TODO: This line of code loads data into the 'Kelompok2DataSet.data_transaksi' table. You can move, or remove it, as needed.
        Me.Data_transaksiTableAdapter.Fill(Me.Kelompok2DataSet.data_transaksi)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    End Sub
End Class
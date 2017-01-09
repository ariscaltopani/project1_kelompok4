Public Class Detail_Penjualan

    Private Sub Data_transaksiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Data_transaksiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kelompok2DataSet)

    End Sub

    Private Sub Detail_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kelompok2DataSet.sales_has_barang' table. You can move, or remove it, as needed.
        Me.Sales_has_barangTableAdapter.Fill(Me.Kelompok2DataSet.sales_has_barang)
        'TODO: This line of code loads data into the 'Kelompok2DataSet.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.Kelompok2DataSet.barang)
        'TODO: This line of code loads data into the 'Kelompok2DataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Kelompok2DataSet.customer)
        'TODO: This line of code loads data into the 'Kelompok2DataSet.data_transaksi' table. You can move, or remove it, as needed.
        Me.Data_transaksiTableAdapter.Fill(Me.Kelompok2DataSet.data_transaksi)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Data_transaksiBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Data_transaksiBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Validate()
        Me.Data_transaksiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kelompok2DataSet)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Sales_has_barangBindingSource.AddNew()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Sales_has_barangBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Validate()
        Me.Sales_has_barangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kelompok2DataSet)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        CustomerBindingSource.AddNew()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        CustomerBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kelompok2DataSet)
    End Sub
End Class
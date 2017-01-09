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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Data_transaksiBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Data_transaksiBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Data_transaksiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kelompok2DataSet)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Sales_has_barangBindingSource.AddNew()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Sales_has_barangBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        Me.Fkdatatransaksicustomer1BindingSource3.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kelompok2DataSet)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Hide()
        Invoice.Show()

    End Sub

    Private Sub Sales_has_barang_barang_Kode_BarangTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Sales_has_barang_barang_Kode_BarangLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Sales_has_barang_sales_NIKTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Sales_has_barang_sales_NIKLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NamaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NamaLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub No__TelpTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub No__TelpLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AlamatTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AlamatLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Id_PembeliTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Id_PembeliLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CustomerDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class
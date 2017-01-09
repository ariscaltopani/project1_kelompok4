Public Class Barang

    Private Sub BarangBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kelompok2DataSet)

    End Sub

    Private Sub Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kelompok2DataSet.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.Kelompok2DataSet.barang)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BarangBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BarangBindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Validate()
        Me.BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kelompok2DataSet)

    End Sub
End Class
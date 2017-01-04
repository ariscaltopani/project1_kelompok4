<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail_Penjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detail_Penjualan))
        Dim Customer_Id_PembeliLabel As System.Windows.Forms.Label
        Dim Customer_sales_has_barang_sales_NIKLabel As System.Windows.Forms.Label
        Dim Customer_sales_has_barang_barang_Kode_BarangLabel As System.Windows.Forms.Label
        Me.Kelompok2DataSet = New Aplikasi_penjualan_HP.kelompok2DataSet()
        Me.Data_transaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_transaksiTableAdapter = New Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.data_transaksiTableAdapter()
        Me.TableAdapterManager = New Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager()
        Me.Data_transaksiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Data_transaksiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Customer_Id_PembeliTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_sales_has_barang_sales_NIKTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_sales_has_barang_barang_Kode_BarangTextBox = New System.Windows.Forms.TextBox()
        Me.Data_transaksiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Customer_Id_PembeliLabel = New System.Windows.Forms.Label()
        Customer_sales_has_barang_sales_NIKLabel = New System.Windows.Forms.Label()
        Customer_sales_has_barang_barang_Kode_BarangLabel = New System.Windows.Forms.Label()
        CType(Me.Kelompok2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_transaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_transaksiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Data_transaksiBindingNavigator.SuspendLayout()
        CType(Me.Data_transaksiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kelompok2DataSet
        '
        Me.Kelompok2DataSet.DataSetName = "kelompok2DataSet"
        Me.Kelompok2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Data_transaksiBindingSource
        '
        Me.Data_transaksiBindingSource.DataMember = "data_transaksi"
        Me.Data_transaksiBindingSource.DataSource = Me.Kelompok2DataSet
        '
        'Data_transaksiTableAdapter
        '
        Me.Data_transaksiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.barangTableAdapter = Nothing
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.data_transaksiTableAdapter = Me.Data_transaksiTableAdapter
        Me.TableAdapterManager.sales_has_barangTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Data_transaksiBindingNavigator
        '
        Me.Data_transaksiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Data_transaksiBindingNavigator.BindingSource = Me.Data_transaksiBindingSource
        Me.Data_transaksiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Data_transaksiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Data_transaksiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Data_transaksiBindingNavigatorSaveItem})
        Me.Data_transaksiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Data_transaksiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Data_transaksiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Data_transaksiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Data_transaksiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Data_transaksiBindingNavigator.Name = "Data_transaksiBindingNavigator"
        Me.Data_transaksiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Data_transaksiBindingNavigator.Size = New System.Drawing.Size(392, 25)
        Me.Data_transaksiBindingNavigator.TabIndex = 0
        Me.Data_transaksiBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Data_transaksiBindingNavigatorSaveItem
        '
        Me.Data_transaksiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Data_transaksiBindingNavigatorSaveItem.Image = CType(resources.GetObject("Data_transaksiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Data_transaksiBindingNavigatorSaveItem.Name = "Data_transaksiBindingNavigatorSaveItem"
        Me.Data_transaksiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Data_transaksiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Customer_Id_PembeliLabel
        '
        Customer_Id_PembeliLabel.AutoSize = True
        Customer_Id_PembeliLabel.Location = New System.Drawing.Point(12, 47)
        Customer_Id_PembeliLabel.Name = "Customer_Id_PembeliLabel"
        Customer_Id_PembeliLabel.Size = New System.Drawing.Size(105, 13)
        Customer_Id_PembeliLabel.TabIndex = 1
        Customer_Id_PembeliLabel.Text = "customer Id Pembeli:"
        '
        'Customer_Id_PembeliTextBox
        '
        Me.Customer_Id_PembeliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_transaksiBindingSource, "customer_Id Pembeli", True))
        Me.Customer_Id_PembeliTextBox.Location = New System.Drawing.Point(255, 44)
        Me.Customer_Id_PembeliTextBox.Name = "Customer_Id_PembeliTextBox"
        Me.Customer_Id_PembeliTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Customer_Id_PembeliTextBox.TabIndex = 2
        '
        'Customer_sales_has_barang_sales_NIKLabel
        '
        Customer_sales_has_barang_sales_NIKLabel.AutoSize = True
        Customer_sales_has_barang_sales_NIKLabel.Location = New System.Drawing.Point(12, 73)
        Customer_sales_has_barang_sales_NIKLabel.Name = "Customer_sales_has_barang_sales_NIKLabel"
        Customer_sales_has_barang_sales_NIKLabel.Size = New System.Drawing.Size(184, 13)
        Customer_sales_has_barang_sales_NIKLabel.TabIndex = 3
        Customer_sales_has_barang_sales_NIKLabel.Text = "customer sales has barang sales NIK:"
        '
        'Customer_sales_has_barang_sales_NIKTextBox
        '
        Me.Customer_sales_has_barang_sales_NIKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_transaksiBindingSource, "customer_sales_has_barang_sales_NIK", True))
        Me.Customer_sales_has_barang_sales_NIKTextBox.Location = New System.Drawing.Point(255, 70)
        Me.Customer_sales_has_barang_sales_NIKTextBox.Name = "Customer_sales_has_barang_sales_NIKTextBox"
        Me.Customer_sales_has_barang_sales_NIKTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Customer_sales_has_barang_sales_NIKTextBox.TabIndex = 4
        '
        'Customer_sales_has_barang_barang_Kode_BarangLabel
        '
        Customer_sales_has_barang_barang_Kode_BarangLabel.AutoSize = True
        Customer_sales_has_barang_barang_Kode_BarangLabel.Location = New System.Drawing.Point(12, 99)
        Customer_sales_has_barang_barang_Kode_BarangLabel.Name = "Customer_sales_has_barang_barang_Kode_BarangLabel"
        Customer_sales_has_barang_barang_Kode_BarangLabel.Size = New System.Drawing.Size(237, 13)
        Customer_sales_has_barang_barang_Kode_BarangLabel.TabIndex = 5
        Customer_sales_has_barang_barang_Kode_BarangLabel.Text = "customer sales has barang barang Kode Barang:"
        '
        'Customer_sales_has_barang_barang_Kode_BarangTextBox
        '
        Me.Customer_sales_has_barang_barang_Kode_BarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_transaksiBindingSource, "customer_sales_has_barang_barang_Kode Barang", True))
        Me.Customer_sales_has_barang_barang_Kode_BarangTextBox.Location = New System.Drawing.Point(255, 96)
        Me.Customer_sales_has_barang_barang_Kode_BarangTextBox.Name = "Customer_sales_has_barang_barang_Kode_BarangTextBox"
        Me.Customer_sales_has_barang_barang_Kode_BarangTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Customer_sales_has_barang_barang_Kode_BarangTextBox.TabIndex = 6
        '
        'Data_transaksiDataGridView
        '
        Me.Data_transaksiDataGridView.AutoGenerateColumns = False
        Me.Data_transaksiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_transaksiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Data_transaksiDataGridView.DataSource = Me.Data_transaksiBindingSource
        Me.Data_transaksiDataGridView.Location = New System.Drawing.Point(15, 122)
        Me.Data_transaksiDataGridView.Name = "Data_transaksiDataGridView"
        Me.Data_transaksiDataGridView.Size = New System.Drawing.Size(358, 220)
        Me.Data_transaksiDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "customer_Id Pembeli"
        Me.DataGridViewTextBoxColumn1.HeaderText = "customer_Id Pembeli"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "customer_sales_has_barang_sales_NIK"
        Me.DataGridViewTextBoxColumn2.HeaderText = "customer_sales_has_barang_sales_NIK"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "customer_sales_has_barang_barang_Kode Barang"
        Me.DataGridViewTextBoxColumn3.HeaderText = "customer_sales_has_barang_barang_Kode Barang"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(205, 346)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(298, 346)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Detail_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 410)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Data_transaksiDataGridView)
        Me.Controls.Add(Customer_Id_PembeliLabel)
        Me.Controls.Add(Me.Customer_Id_PembeliTextBox)
        Me.Controls.Add(Customer_sales_has_barang_sales_NIKLabel)
        Me.Controls.Add(Me.Customer_sales_has_barang_sales_NIKTextBox)
        Me.Controls.Add(Customer_sales_has_barang_barang_Kode_BarangLabel)
        Me.Controls.Add(Me.Customer_sales_has_barang_barang_Kode_BarangTextBox)
        Me.Controls.Add(Me.Data_transaksiBindingNavigator)
        Me.Name = "Detail_Penjualan"
        Me.Text = "Detail_Penjualan"
        CType(Me.Kelompok2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_transaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_transaksiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Data_transaksiBindingNavigator.ResumeLayout(False)
        Me.Data_transaksiBindingNavigator.PerformLayout()
        CType(Me.Data_transaksiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Kelompok2DataSet As Aplikasi_penjualan_HP.kelompok2DataSet
    Friend WithEvents Data_transaksiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Data_transaksiTableAdapter As Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.data_transaksiTableAdapter
    Friend WithEvents TableAdapterManager As Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Data_transaksiBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Data_transaksiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Customer_Id_PembeliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Customer_sales_has_barang_sales_NIKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Customer_sales_has_barang_barang_Kode_BarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data_transaksiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class

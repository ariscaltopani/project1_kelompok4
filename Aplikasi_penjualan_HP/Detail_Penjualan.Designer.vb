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
        Dim Customer_Id_PembeliLabel As System.Windows.Forms.Label
        Dim Customer_sales_has_barang_sales_NIKLabel As System.Windows.Forms.Label
        Dim Customer_sales_has_barang_barang_Kode_BarangLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detail_Penjualan))
        Me.Kelompok2DataSet = New Aplikasi_penjualan_HP.kelompok2DataSet()
        Me.Data_transaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_transaksiTableAdapter = New Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.data_transaksiTableAdapter()
        Me.TableAdapterManager = New Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager()
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
        CType(Me.Data_transaksiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Customer_Id_PembeliLabel
        '
        Customer_Id_PembeliLabel.AutoSize = True
        Customer_Id_PembeliLabel.BackColor = System.Drawing.Color.Transparent
        Customer_Id_PembeliLabel.Location = New System.Drawing.Point(14, 65)
        Customer_Id_PembeliLabel.Name = "Customer_Id_PembeliLabel"
        Customer_Id_PembeliLabel.Size = New System.Drawing.Size(131, 16)
        Customer_Id_PembeliLabel.TabIndex = 1
        Customer_Id_PembeliLabel.Text = "customer Id Pembeli:"
        '
        'Customer_sales_has_barang_sales_NIKLabel
        '
        Customer_sales_has_barang_sales_NIKLabel.AutoSize = True
        Customer_sales_has_barang_sales_NIKLabel.BackColor = System.Drawing.Color.Transparent
        Customer_sales_has_barang_sales_NIKLabel.Location = New System.Drawing.Point(14, 101)
        Customer_sales_has_barang_sales_NIKLabel.Name = "Customer_sales_has_barang_sales_NIKLabel"
        Customer_sales_has_barang_sales_NIKLabel.Size = New System.Drawing.Size(231, 16)
        Customer_sales_has_barang_sales_NIKLabel.TabIndex = 3
        Customer_sales_has_barang_sales_NIKLabel.Text = "customer sales has barang sales NIK:"
        '
        'Customer_sales_has_barang_barang_Kode_BarangLabel
        '
        Customer_sales_has_barang_barang_Kode_BarangLabel.AutoSize = True
        Customer_sales_has_barang_barang_Kode_BarangLabel.BackColor = System.Drawing.Color.Transparent
        Customer_sales_has_barang_barang_Kode_BarangLabel.Location = New System.Drawing.Point(14, 137)
        Customer_sales_has_barang_barang_Kode_BarangLabel.Name = "Customer_sales_has_barang_barang_Kode_BarangLabel"
        Customer_sales_has_barang_barang_Kode_BarangLabel.Size = New System.Drawing.Size(289, 16)
        Customer_sales_has_barang_barang_Kode_BarangLabel.TabIndex = 5
        Customer_sales_has_barang_barang_Kode_BarangLabel.Text = "customer sales has barang barang Kode Barang:"
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
        'Customer_Id_PembeliTextBox
        '
        Me.Customer_Id_PembeliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_transaksiBindingSource, "customer_Id Pembeli", True))
        Me.Customer_Id_PembeliTextBox.Location = New System.Drawing.Point(332, 62)
        Me.Customer_Id_PembeliTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Customer_Id_PembeliTextBox.Name = "Customer_Id_PembeliTextBox"
        Me.Customer_Id_PembeliTextBox.Size = New System.Drawing.Size(116, 24)
        Me.Customer_Id_PembeliTextBox.TabIndex = 2
        '
        'Customer_sales_has_barang_sales_NIKTextBox
        '
        Me.Customer_sales_has_barang_sales_NIKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_transaksiBindingSource, "customer_sales_has_barang_sales_NIK", True))
        Me.Customer_sales_has_barang_sales_NIKTextBox.Location = New System.Drawing.Point(332, 98)
        Me.Customer_sales_has_barang_sales_NIKTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Customer_sales_has_barang_sales_NIKTextBox.Name = "Customer_sales_has_barang_sales_NIKTextBox"
        Me.Customer_sales_has_barang_sales_NIKTextBox.Size = New System.Drawing.Size(116, 24)
        Me.Customer_sales_has_barang_sales_NIKTextBox.TabIndex = 4
        '
        'Customer_sales_has_barang_barang_Kode_BarangTextBox
        '
        Me.Customer_sales_has_barang_barang_Kode_BarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_transaksiBindingSource, "customer_sales_has_barang_barang_Kode Barang", True))
        Me.Customer_sales_has_barang_barang_Kode_BarangTextBox.Location = New System.Drawing.Point(332, 137)
        Me.Customer_sales_has_barang_barang_Kode_BarangTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Customer_sales_has_barang_barang_Kode_BarangTextBox.Name = "Customer_sales_has_barang_barang_Kode_BarangTextBox"
        Me.Customer_sales_has_barang_barang_Kode_BarangTextBox.Size = New System.Drawing.Size(116, 24)
        Me.Customer_sales_has_barang_barang_Kode_BarangTextBox.TabIndex = 6
        '
        'Data_transaksiDataGridView
        '
        Me.Data_transaksiDataGridView.AutoGenerateColumns = False
        Me.Data_transaksiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_transaksiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Data_transaksiDataGridView.DataSource = Me.Data_transaksiBindingSource
        Me.Data_transaksiDataGridView.Location = New System.Drawing.Point(487, 56)
        Me.Data_transaksiDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Data_transaksiDataGridView.Name = "Data_transaksiDataGridView"
        Me.Data_transaksiDataGridView.Size = New System.Drawing.Size(404, 105)
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
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Location = New System.Drawing.Point(118, 448)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.Location = New System.Drawing.Point(231, 448)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 32)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Location = New System.Drawing.Point(346, 448)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 32)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button4.Location = New System.Drawing.Point(458, 448)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 32)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Detail_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(976, 568)
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
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Detail_Penjualan"
        Me.Text = "Detail_Penjualan"
        CType(Me.Kelompok2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_transaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_transaksiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Kelompok2DataSet As Aplikasi_penjualan_HP.kelompok2DataSet
    Friend WithEvents Data_transaksiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Data_transaksiTableAdapter As Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.data_transaksiTableAdapter
    Friend WithEvents TableAdapterManager As Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager
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

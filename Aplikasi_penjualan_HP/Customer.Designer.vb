<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim Id_PembeliLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim No__TelpLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim Sales_has_barang_sales_NIKLabel As System.Windows.Forms.Label
        Dim Sales_has_barang_barang_Kode_BarangLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.Kelompok2DataSet = New Aplikasi_penjualan_HP.kelompok2DataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.customerTableAdapter()
        Me.TableAdapterManager = New Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_PembeliTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.No__TelpTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.Sales_has_barang_sales_NIKTextBox = New System.Windows.Forms.TextBox()
        Me.Sales_has_barang_barang_Kode_BarangTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_PembeliLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        No__TelpLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        Sales_has_barang_sales_NIKLabel = New System.Windows.Forms.Label()
        Sales_has_barang_barang_Kode_BarangLabel = New System.Windows.Forms.Label()
        CType(Me.Kelompok2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_PembeliLabel
        '
        Id_PembeliLabel.AutoSize = True
        Id_PembeliLabel.BackColor = System.Drawing.Color.Transparent
        Id_PembeliLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Id_PembeliLabel.Location = New System.Drawing.Point(16, 78)
        Id_PembeliLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_PembeliLabel.Name = "Id_PembeliLabel"
        Id_PembeliLabel.Size = New System.Drawing.Size(83, 19)
        Id_PembeliLabel.TabIndex = 2
        Id_PembeliLabel.Text = "Id Pembeli:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.BackColor = System.Drawing.Color.Transparent
        AlamatLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        AlamatLabel.Location = New System.Drawing.Point(15, 121)
        AlamatLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(59, 19)
        AlamatLabel.TabIndex = 4
        AlamatLabel.Text = "Alamat:"
        '
        'No__TelpLabel
        '
        No__TelpLabel.AutoSize = True
        No__TelpLabel.BackColor = System.Drawing.Color.Transparent
        No__TelpLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        No__TelpLabel.Location = New System.Drawing.Point(13, 159)
        No__TelpLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        No__TelpLabel.Name = "No__TelpLabel"
        No__TelpLabel.Size = New System.Drawing.Size(72, 19)
        No__TelpLabel.TabIndex = 6
        No__TelpLabel.Text = "No  Telp:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.BackColor = System.Drawing.Color.Transparent
        NamaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        NamaLabel.Location = New System.Drawing.Point(16, 201)
        NamaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(50, 19)
        NamaLabel.TabIndex = 8
        NamaLabel.Text = "Nama:"
        '
        'Sales_has_barang_sales_NIKLabel
        '
        Sales_has_barang_sales_NIKLabel.AutoSize = True
        Sales_has_barang_sales_NIKLabel.BackColor = System.Drawing.Color.Transparent
        Sales_has_barang_sales_NIKLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Sales_has_barang_sales_NIKLabel.Location = New System.Drawing.Point(15, 246)
        Sales_has_barang_sales_NIKLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Sales_has_barang_sales_NIKLabel.Name = "Sales_has_barang_sales_NIKLabel"
        Sales_has_barang_sales_NIKLabel.Size = New System.Drawing.Size(188, 19)
        Sales_has_barang_sales_NIKLabel.TabIndex = 10
        Sales_has_barang_sales_NIKLabel.Text = "sales has barang sales NIK:"
        '
        'Sales_has_barang_barang_Kode_BarangLabel
        '
        Sales_has_barang_barang_Kode_BarangLabel.AutoSize = True
        Sales_has_barang_barang_Kode_BarangLabel.BackColor = System.Drawing.Color.Transparent
        Sales_has_barang_barang_Kode_BarangLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Sales_has_barang_barang_Kode_BarangLabel.Location = New System.Drawing.Point(13, 282)
        Sales_has_barang_barang_Kode_BarangLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Sales_has_barang_barang_Kode_BarangLabel.Name = "Sales_has_barang_barang_Kode_BarangLabel"
        Sales_has_barang_barang_Kode_BarangLabel.Size = New System.Drawing.Size(252, 19)
        Sales_has_barang_barang_Kode_BarangLabel.TabIndex = 12
        Sales_has_barang_barang_Kode_BarangLabel.Text = "sales has barang barang Kode Barang:"
        '
        'Kelompok2DataSet
        '
        Me.Kelompok2DataSet.DataSetName = "kelompok2DataSet"
        Me.Kelompok2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.Kelompok2DataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.barangTableAdapter = Nothing
        Me.TableAdapterManager.customerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.data_transaksiTableAdapter = Nothing
        Me.TableAdapterManager.sales_has_barangTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerDataGridView.Location = New System.Drawing.Point(13, 313)
        Me.CustomerDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.Size = New System.Drawing.Size(704, 116)
        Me.CustomerDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id Pembeli"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Pembeli"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Alamat"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Alamat"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "No_ Telp"
        Me.DataGridViewTextBoxColumn3.HeaderText = "No_ Telp"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "sales_has_barang_sales_NIK"
        Me.DataGridViewTextBoxColumn5.HeaderText = "sales_has_barang_sales_NIK"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "sales_has_barang_barang_Kode Barang"
        Me.DataGridViewTextBoxColumn6.HeaderText = "sales_has_barang_barang_Kode Barang"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Id_PembeliTextBox
        '
        Me.Id_PembeliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Id Pembeli", True))
        Me.Id_PembeliTextBox.Location = New System.Drawing.Point(279, 78)
        Me.Id_PembeliTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_PembeliTextBox.Name = "Id_PembeliTextBox"
        Me.Id_PembeliTextBox.Size = New System.Drawing.Size(132, 26)
        Me.Id_PembeliTextBox.TabIndex = 3
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(279, 118)
        Me.AlamatTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(132, 26)
        Me.AlamatTextBox.TabIndex = 5
        '
        'No__TelpTextBox
        '
        Me.No__TelpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "No_ Telp", True))
        Me.No__TelpTextBox.Location = New System.Drawing.Point(279, 159)
        Me.No__TelpTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.No__TelpTextBox.Name = "No__TelpTextBox"
        Me.No__TelpTextBox.Size = New System.Drawing.Size(132, 26)
        Me.No__TelpTextBox.TabIndex = 7
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(279, 201)
        Me.NamaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(132, 26)
        Me.NamaTextBox.TabIndex = 9
        '
        'Sales_has_barang_sales_NIKTextBox
        '
        Me.Sales_has_barang_sales_NIKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "sales_has_barang_sales_NIK", True))
        Me.Sales_has_barang_sales_NIKTextBox.Location = New System.Drawing.Point(279, 239)
        Me.Sales_has_barang_sales_NIKTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Sales_has_barang_sales_NIKTextBox.Name = "Sales_has_barang_sales_NIKTextBox"
        Me.Sales_has_barang_sales_NIKTextBox.Size = New System.Drawing.Size(132, 26)
        Me.Sales_has_barang_sales_NIKTextBox.TabIndex = 11
        '
        'Sales_has_barang_barang_Kode_BarangTextBox
        '
        Me.Sales_has_barang_barang_Kode_BarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "sales_has_barang_barang_Kode Barang", True))
        Me.Sales_has_barang_barang_Kode_BarangTextBox.Location = New System.Drawing.Point(279, 279)
        Me.Sales_has_barang_barang_Kode_BarangTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Sales_has_barang_barang_Kode_BarangTextBox.Name = "Sales_has_barang_barang_Kode_BarangTextBox"
        Me.Sales_has_barang_barang_Kode_BarangTextBox.Size = New System.Drawing.Size(132, 26)
        Me.Sales_has_barang_barang_Kode_BarangTextBox.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(454, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(263, 227)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "A"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button5.Location = New System.Drawing.Point(137, 146)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 34)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button4.Location = New System.Drawing.Point(137, 66)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 34)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Edit "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Location = New System.Drawing.Point(8, 180)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 34)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.Location = New System.Drawing.Point(8, 108)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 34)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Location = New System.Drawing.Point(8, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(297, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 40)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Customer"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(755, 494)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Id_PembeliLabel)
        Me.Controls.Add(Me.Id_PembeliTextBox)
        Me.Controls.Add(AlamatLabel)
        Me.Controls.Add(Me.AlamatTextBox)
        Me.Controls.Add(No__TelpLabel)
        Me.Controls.Add(Me.No__TelpTextBox)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(Sales_has_barang_sales_NIKLabel)
        Me.Controls.Add(Me.Sales_has_barang_sales_NIKTextBox)
        Me.Controls.Add(Sales_has_barang_barang_Kode_BarangLabel)
        Me.Controls.Add(Me.Sales_has_barang_barang_Kode_BarangTextBox)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Customer"
        Me.Text = "Customer"
        CType(Me.Kelompok2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Kelompok2DataSet As Aplikasi_penjualan_HP.kelompok2DataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.customerTableAdapter
    Friend WithEvents TableAdapterManager As Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_PembeliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No__TelpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sales_has_barang_sales_NIKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sales_has_barang_barang_Kode_BarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

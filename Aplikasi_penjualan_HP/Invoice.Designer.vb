<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim No__TelpLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim Sales_has_barang_sales_NIKLabel As System.Windows.Forms.Label
        Dim Sales_has_barang_barang_Kode_BarangLabel As System.Windows.Forms.Label
        Dim Kode_BarangLabel As System.Windows.Forms.Label
        Dim Merk_HPLabel As System.Windows.Forms.Label
        Dim HargaLabel As System.Windows.Forms.Label
        Dim Id_PembeliLabel As System.Windows.Forms.Label
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.customerTableAdapter()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.barangTableAdapter()
        Me.AlamatLabel1 = New System.Windows.Forms.Label()
        Me.No__TelpLabel1 = New System.Windows.Forms.Label()
        Me.NamaLabel1 = New System.Windows.Forms.Label()
        Me.Sales_has_barang_sales_NIKLabel1 = New System.Windows.Forms.Label()
        Me.Sales_has_barang_barang_Kode_BarangLabel1 = New System.Windows.Forms.Label()
        Me.Kode_BarangComboBox = New System.Windows.Forms.ComboBox()
        Me.Merk_HPLabel1 = New System.Windows.Forms.Label()
        Me.HargaLabel1 = New System.Windows.Forms.Label()
        Me.Id_PembeliComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        AlamatLabel = New System.Windows.Forms.Label()
        No__TelpLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        Sales_has_barang_sales_NIKLabel = New System.Windows.Forms.Label()
        Sales_has_barang_barang_Kode_BarangLabel = New System.Windows.Forms.Label()
        Kode_BarangLabel = New System.Windows.Forms.Label()
        Merk_HPLabel = New System.Windows.Forms.Label()
        HargaLabel = New System.Windows.Forms.Label()
        Id_PembeliLabel = New System.Windows.Forms.Label()
        CType(Me.Kelompok2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_transaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_transaksiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Data_transaksiBindingNavigator.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.barangTableAdapter = Me.BarangTableAdapter
        Me.TableAdapterManager.customerTableAdapter = Me.CustomerTableAdapter
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
        Me.Data_transaksiBindingNavigator.Size = New System.Drawing.Size(432, 25)
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Data_transaksiBindingNavigatorSaveItem
        '
        Me.Data_transaksiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Data_transaksiBindingNavigatorSaveItem.Image = CType(resources.GetObject("Data_transaksiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Data_transaksiBindingNavigatorSaveItem.Name = "Data_transaksiBindingNavigatorSaveItem"
        Me.Data_transaksiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Data_transaksiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INVOICE"
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
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "barang"
        Me.BarangBindingSource.DataSource = Me.Kelompok2DataSet
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlamatLabel.Location = New System.Drawing.Point(31, 100)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(62, 19)
        AlamatLabel.TabIndex = 19
        AlamatLabel.Text = "Alamat:"
        '
        'AlamatLabel1
        '
        Me.AlamatLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Alamat", True))
        Me.AlamatLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatLabel1.Location = New System.Drawing.Point(228, 100)
        Me.AlamatLabel1.Name = "AlamatLabel1"
        Me.AlamatLabel1.Size = New System.Drawing.Size(100, 23)
        Me.AlamatLabel1.TabIndex = 20
        Me.AlamatLabel1.Text = "Label2"
        '
        'No__TelpLabel
        '
        No__TelpLabel.AutoSize = True
        No__TelpLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        No__TelpLabel.Location = New System.Drawing.Point(31, 123)
        No__TelpLabel.Name = "No__TelpLabel"
        No__TelpLabel.Size = New System.Drawing.Size(71, 19)
        No__TelpLabel.TabIndex = 21
        No__TelpLabel.Text = "No  Telp:"
        '
        'No__TelpLabel1
        '
        Me.No__TelpLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "No_ Telp", True))
        Me.No__TelpLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No__TelpLabel1.Location = New System.Drawing.Point(228, 123)
        Me.No__TelpLabel1.Name = "No__TelpLabel1"
        Me.No__TelpLabel1.Size = New System.Drawing.Size(100, 23)
        Me.No__TelpLabel1.TabIndex = 22
        Me.No__TelpLabel1.Text = "Label2"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamaLabel.Location = New System.Drawing.Point(31, 146)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(54, 19)
        NamaLabel.TabIndex = 23
        NamaLabel.Text = "Nama:"
        '
        'NamaLabel1
        '
        Me.NamaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Nama", True))
        Me.NamaLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaLabel1.Location = New System.Drawing.Point(228, 146)
        Me.NamaLabel1.Name = "NamaLabel1"
        Me.NamaLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NamaLabel1.TabIndex = 24
        Me.NamaLabel1.Text = "Label2"
        '
        'Sales_has_barang_sales_NIKLabel
        '
        Sales_has_barang_sales_NIKLabel.AutoSize = True
        Sales_has_barang_sales_NIKLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sales_has_barang_sales_NIKLabel.Location = New System.Drawing.Point(31, 169)
        Sales_has_barang_sales_NIKLabel.Name = "Sales_has_barang_sales_NIKLabel"
        Sales_has_barang_sales_NIKLabel.Size = New System.Drawing.Size(84, 19)
        Sales_has_barang_sales_NIKLabel.TabIndex = 25
        Sales_has_barang_sales_NIKLabel.Text = "Sales NIK:"
        '
        'Sales_has_barang_sales_NIKLabel1
        '
        Me.Sales_has_barang_sales_NIKLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "sales_has_barang_sales_NIK", True))
        Me.Sales_has_barang_sales_NIKLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sales_has_barang_sales_NIKLabel1.Location = New System.Drawing.Point(228, 169)
        Me.Sales_has_barang_sales_NIKLabel1.Name = "Sales_has_barang_sales_NIKLabel1"
        Me.Sales_has_barang_sales_NIKLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Sales_has_barang_sales_NIKLabel1.TabIndex = 26
        Me.Sales_has_barang_sales_NIKLabel1.Text = "Label2"
        '
        'Sales_has_barang_barang_Kode_BarangLabel
        '
        Sales_has_barang_barang_Kode_BarangLabel.AutoSize = True
        Sales_has_barang_barang_Kode_BarangLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sales_has_barang_barang_Kode_BarangLabel.Location = New System.Drawing.Point(31, 192)
        Sales_has_barang_barang_Kode_BarangLabel.Name = "Sales_has_barang_barang_Kode_BarangLabel"
        Sales_has_barang_barang_Kode_BarangLabel.Size = New System.Drawing.Size(107, 19)
        Sales_has_barang_barang_Kode_BarangLabel.TabIndex = 27
        Sales_has_barang_barang_Kode_BarangLabel.Text = " Kode Barang:"
        '
        'Sales_has_barang_barang_Kode_BarangLabel1
        '
        Me.Sales_has_barang_barang_Kode_BarangLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "sales_has_barang_barang_Kode Barang", True))
        Me.Sales_has_barang_barang_Kode_BarangLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sales_has_barang_barang_Kode_BarangLabel1.Location = New System.Drawing.Point(228, 192)
        Me.Sales_has_barang_barang_Kode_BarangLabel1.Name = "Sales_has_barang_barang_Kode_BarangLabel1"
        Me.Sales_has_barang_barang_Kode_BarangLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Sales_has_barang_barang_Kode_BarangLabel1.TabIndex = 28
        Me.Sales_has_barang_barang_Kode_BarangLabel1.Text = "Label2"
        '
        'Kode_BarangLabel
        '
        Kode_BarangLabel.AutoSize = True
        Kode_BarangLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Kode_BarangLabel.Location = New System.Drawing.Point(31, 223)
        Kode_BarangLabel.Name = "Kode_BarangLabel"
        Kode_BarangLabel.Size = New System.Drawing.Size(103, 19)
        Kode_BarangLabel.TabIndex = 28
        Kode_BarangLabel.Text = "Kode Barang:"
        '
        'Kode_BarangComboBox
        '
        Me.Kode_BarangComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Kode Barang", True))
        Me.Kode_BarangComboBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kode_BarangComboBox.FormattingEnabled = True
        Me.Kode_BarangComboBox.Location = New System.Drawing.Point(231, 215)
        Me.Kode_BarangComboBox.Name = "Kode_BarangComboBox"
        Me.Kode_BarangComboBox.Size = New System.Drawing.Size(121, 27)
        Me.Kode_BarangComboBox.TabIndex = 29
        '
        'Merk_HPLabel
        '
        Merk_HPLabel.AutoSize = True
        Merk_HPLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Merk_HPLabel.Location = New System.Drawing.Point(31, 244)
        Merk_HPLabel.Name = "Merk_HPLabel"
        Merk_HPLabel.Size = New System.Drawing.Size(78, 19)
        Merk_HPLabel.TabIndex = 30
        Merk_HPLabel.Text = "Merk HP:"
        '
        'Merk_HPLabel1
        '
        Me.Merk_HPLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Merk HP", True))
        Me.Merk_HPLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Merk_HPLabel1.Location = New System.Drawing.Point(231, 239)
        Me.Merk_HPLabel1.Name = "Merk_HPLabel1"
        Me.Merk_HPLabel1.Size = New System.Drawing.Size(121, 23)
        Me.Merk_HPLabel1.TabIndex = 31
        Me.Merk_HPLabel1.Text = "Label2"
        '
        'HargaLabel
        '
        HargaLabel.AutoSize = True
        HargaLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HargaLabel.Location = New System.Drawing.Point(31, 267)
        HargaLabel.Name = "HargaLabel"
        HargaLabel.Size = New System.Drawing.Size(56, 19)
        HargaLabel.TabIndex = 32
        HargaLabel.Text = "Harga:"
        '
        'HargaLabel1
        '
        Me.HargaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Harga", True))
        Me.HargaLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaLabel1.Location = New System.Drawing.Point(231, 262)
        Me.HargaLabel1.Name = "HargaLabel1"
        Me.HargaLabel1.Size = New System.Drawing.Size(121, 23)
        Me.HargaLabel1.TabIndex = 33
        Me.HargaLabel1.Text = "Label2"
        '
        'Id_PembeliLabel
        '
        Id_PembeliLabel.AutoSize = True
        Id_PembeliLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_PembeliLabel.Location = New System.Drawing.Point(31, 73)
        Id_PembeliLabel.Name = "Id_PembeliLabel"
        Id_PembeliLabel.Size = New System.Drawing.Size(85, 19)
        Id_PembeliLabel.TabIndex = 33
        Id_PembeliLabel.Text = "Id Pembeli:"
        '
        'Id_PembeliComboBox
        '
        Me.Id_PembeliComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Id Pembeli", True))
        Me.Id_PembeliComboBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_PembeliComboBox.FormattingEnabled = True
        Me.Id_PembeliComboBox.Location = New System.Drawing.Point(231, 73)
        Me.Id_PembeliComboBox.Name = "Id_PembeliComboBox"
        Me.Id_PembeliComboBox.Size = New System.Drawing.Size(121, 27)
        Me.Id_PembeliComboBox.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(244, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(345, 308)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 398)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Id_PembeliLabel)
        Me.Controls.Add(Me.Id_PembeliComboBox)
        Me.Controls.Add(Kode_BarangLabel)
        Me.Controls.Add(Me.Kode_BarangComboBox)
        Me.Controls.Add(Merk_HPLabel)
        Me.Controls.Add(Me.Merk_HPLabel1)
        Me.Controls.Add(HargaLabel)
        Me.Controls.Add(Me.HargaLabel1)
        Me.Controls.Add(AlamatLabel)
        Me.Controls.Add(Me.AlamatLabel1)
        Me.Controls.Add(No__TelpLabel)
        Me.Controls.Add(Me.No__TelpLabel1)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaLabel1)
        Me.Controls.Add(Sales_has_barang_sales_NIKLabel)
        Me.Controls.Add(Me.Sales_has_barang_sales_NIKLabel1)
        Me.Controls.Add(Sales_has_barang_barang_Kode_BarangLabel)
        Me.Controls.Add(Me.Sales_has_barang_barang_Kode_BarangLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Data_transaksiBindingNavigator)
        Me.Name = "Invoice"
        Me.Text = "Invoice"
        CType(Me.Kelompok2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_transaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_transaksiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Data_transaksiBindingNavigator.ResumeLayout(False)
        Me.Data_transaksiBindingNavigator.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CustomerTableAdapter As Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.customerTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarangTableAdapter As Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.barangTableAdapter
    Friend WithEvents BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlamatLabel1 As System.Windows.Forms.Label
    Friend WithEvents No__TelpLabel1 As System.Windows.Forms.Label
    Friend WithEvents NamaLabel1 As System.Windows.Forms.Label
    Friend WithEvents Sales_has_barang_sales_NIKLabel1 As System.Windows.Forms.Label
    Friend WithEvents Sales_has_barang_barang_Kode_BarangLabel1 As System.Windows.Forms.Label
    Friend WithEvents Kode_BarangComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Merk_HPLabel1 As System.Windows.Forms.Label
    Friend WithEvents HargaLabel1 As System.Windows.Forms.Label
    Friend WithEvents Id_PembeliComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

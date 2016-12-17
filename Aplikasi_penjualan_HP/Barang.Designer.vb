<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barang))
        Dim Kode_BarangLabel As System.Windows.Forms.Label
        Dim Merk_HPLabel As System.Windows.Forms.Label
        Dim HargaLabel As System.Windows.Forms.Label
        Me.Kelompok2DataSet = New Aplikasi_penjualan_HP.kelompok2DataSet()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.barangTableAdapter()
        Me.TableAdapterManager = New Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager()
        Me.BarangBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BarangBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BarangDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kode_BarangTextBox = New System.Windows.Forms.TextBox()
        Me.Merk_HPTextBox = New System.Windows.Forms.TextBox()
        Me.HargaTextBox = New System.Windows.Forms.TextBox()
        Kode_BarangLabel = New System.Windows.Forms.Label()
        Merk_HPLabel = New System.Windows.Forms.Label()
        HargaLabel = New System.Windows.Forms.Label()
        CType(Me.Kelompok2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarangBindingNavigator.SuspendLayout()
        CType(Me.BarangDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kelompok2DataSet
        '
        Me.Kelompok2DataSet.DataSetName = "kelompok2DataSet"
        Me.Kelompok2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.barangTableAdapter = Me.BarangTableAdapter
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.data_transaksiTableAdapter = Nothing
        Me.TableAdapterManager.sales_has_barangTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BarangBindingNavigator
        '
        Me.BarangBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BarangBindingNavigator.BindingSource = Me.BarangBindingSource
        Me.BarangBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BarangBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BarangBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BarangBindingNavigatorSaveItem})
        Me.BarangBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BarangBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BarangBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BarangBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BarangBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BarangBindingNavigator.Name = "BarangBindingNavigator"
        Me.BarangBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BarangBindingNavigator.Size = New System.Drawing.Size(599, 25)
        Me.BarangBindingNavigator.TabIndex = 0
        Me.BarangBindingNavigator.Text = "BindingNavigator1"
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
        'BarangBindingNavigatorSaveItem
        '
        Me.BarangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BarangBindingNavigatorSaveItem.Image = CType(resources.GetObject("BarangBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BarangBindingNavigatorSaveItem.Name = "BarangBindingNavigatorSaveItem"
        Me.BarangBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.BarangBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BarangDataGridView
        '
        Me.BarangDataGridView.AutoGenerateColumns = False
        Me.BarangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BarangDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.BarangDataGridView.DataSource = Me.BarangBindingSource
        Me.BarangDataGridView.Location = New System.Drawing.Point(221, 37)
        Me.BarangDataGridView.Name = "BarangDataGridView"
        Me.BarangDataGridView.Size = New System.Drawing.Size(351, 220)
        Me.BarangDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Kode Barang"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode Barang"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Merk HP"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Merk HP"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Harga"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Harga"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Kode_BarangLabel
        '
        Kode_BarangLabel.AutoSize = True
        Kode_BarangLabel.Location = New System.Drawing.Point(7, 40)
        Kode_BarangLabel.Name = "Kode_BarangLabel"
        Kode_BarangLabel.Size = New System.Drawing.Size(72, 13)
        Kode_BarangLabel.TabIndex = 2
        Kode_BarangLabel.Text = "Kode Barang:"
        '
        'Kode_BarangTextBox
        '
        Me.Kode_BarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Kode Barang", True))
        Me.Kode_BarangTextBox.Location = New System.Drawing.Point(85, 37)
        Me.Kode_BarangTextBox.Name = "Kode_BarangTextBox"
        Me.Kode_BarangTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Kode_BarangTextBox.TabIndex = 3
        '
        'Merk_HPLabel
        '
        Merk_HPLabel.AutoSize = True
        Merk_HPLabel.Location = New System.Drawing.Point(7, 66)
        Merk_HPLabel.Name = "Merk_HPLabel"
        Merk_HPLabel.Size = New System.Drawing.Size(52, 13)
        Merk_HPLabel.TabIndex = 4
        Merk_HPLabel.Text = "Merk HP:"
        '
        'Merk_HPTextBox
        '
        Me.Merk_HPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Merk HP", True))
        Me.Merk_HPTextBox.Location = New System.Drawing.Point(85, 63)
        Me.Merk_HPTextBox.Name = "Merk_HPTextBox"
        Me.Merk_HPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Merk_HPTextBox.TabIndex = 5
        '
        'HargaLabel
        '
        HargaLabel.AutoSize = True
        HargaLabel.Location = New System.Drawing.Point(7, 92)
        HargaLabel.Name = "HargaLabel"
        HargaLabel.Size = New System.Drawing.Size(39, 13)
        HargaLabel.TabIndex = 6
        HargaLabel.Text = "Harga:"
        '
        'HargaTextBox
        '
        Me.HargaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Harga", True))
        Me.HargaTextBox.Location = New System.Drawing.Point(85, 89)
        Me.HargaTextBox.Name = "HargaTextBox"
        Me.HargaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HargaTextBox.TabIndex = 7
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 340)
        Me.Controls.Add(Kode_BarangLabel)
        Me.Controls.Add(Me.Kode_BarangTextBox)
        Me.Controls.Add(Merk_HPLabel)
        Me.Controls.Add(Me.Merk_HPTextBox)
        Me.Controls.Add(HargaLabel)
        Me.Controls.Add(Me.HargaTextBox)
        Me.Controls.Add(Me.BarangDataGridView)
        Me.Controls.Add(Me.BarangBindingNavigator)
        Me.Name = "Barang"
        Me.Text = "Barang"
        CType(Me.Kelompok2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarangBindingNavigator.ResumeLayout(False)
        Me.BarangBindingNavigator.PerformLayout()
        CType(Me.BarangDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Kelompok2DataSet As Aplikasi_penjualan_HP.kelompok2DataSet
    Friend WithEvents BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarangTableAdapter As Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.barangTableAdapter
    Friend WithEvents TableAdapterManager As Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BarangBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BarangBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BarangDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kode_BarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Merk_HPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HargaTextBox As System.Windows.Forms.TextBox
End Class

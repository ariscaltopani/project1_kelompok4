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
        Dim Kode_BarangLabel As System.Windows.Forms.Label
        Dim Merk_HPLabel As System.Windows.Forms.Label
        Dim HargaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barang))
        Me.Kelompok2DataSet = New Aplikasi_penjualan_HP.kelompok2DataSet()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.barangTableAdapter()
        Me.TableAdapterManager = New Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager()
        Me.BarangDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kode_BarangTextBox = New System.Windows.Forms.TextBox()
        Me.Merk_HPTextBox = New System.Windows.Forms.TextBox()
        Me.HargaTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Kode_BarangLabel = New System.Windows.Forms.Label()
        Merk_HPLabel = New System.Windows.Forms.Label()
        HargaLabel = New System.Windows.Forms.Label()
        CType(Me.Kelompok2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kode_BarangLabel
        '
        Kode_BarangLabel.AutoSize = True
        Kode_BarangLabel.BackColor = System.Drawing.Color.Transparent
        Kode_BarangLabel.ForeColor = System.Drawing.Color.White
        Kode_BarangLabel.Location = New System.Drawing.Point(11, 92)
        Kode_BarangLabel.Name = "Kode_BarangLabel"
        Kode_BarangLabel.Size = New System.Drawing.Size(85, 16)
        Kode_BarangLabel.TabIndex = 2
        Kode_BarangLabel.Text = "Kode Barang:"
        '
        'Merk_HPLabel
        '
        Merk_HPLabel.AutoSize = True
        Merk_HPLabel.BackColor = System.Drawing.Color.Transparent
        Merk_HPLabel.ForeColor = System.Drawing.Color.White
        Merk_HPLabel.Location = New System.Drawing.Point(11, 150)
        Merk_HPLabel.Name = "Merk_HPLabel"
        Merk_HPLabel.Size = New System.Drawing.Size(63, 16)
        Merk_HPLabel.TabIndex = 4
        Merk_HPLabel.Text = "Merk HP:"
        '
        'HargaLabel
        '
        HargaLabel.AutoSize = True
        HargaLabel.BackColor = System.Drawing.Color.Transparent
        HargaLabel.ForeColor = System.Drawing.Color.White
        HargaLabel.Location = New System.Drawing.Point(13, 206)
        HargaLabel.Name = "HargaLabel"
        HargaLabel.Size = New System.Drawing.Size(48, 16)
        HargaLabel.TabIndex = 6
        HargaLabel.Text = "Harga:"
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
        'BarangDataGridView
        '
        Me.BarangDataGridView.AutoGenerateColumns = False
        Me.BarangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BarangDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.BarangDataGridView.DataSource = Me.BarangBindingSource
        Me.BarangDataGridView.Location = New System.Drawing.Point(258, 66)
        Me.BarangDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BarangDataGridView.Name = "BarangDataGridView"
        Me.BarangDataGridView.Size = New System.Drawing.Size(419, 184)
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
        'Kode_BarangTextBox
        '
        Me.Kode_BarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Kode Barang", True))
        Me.Kode_BarangTextBox.Location = New System.Drawing.Point(104, 92)
        Me.Kode_BarangTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Kode_BarangTextBox.Name = "Kode_BarangTextBox"
        Me.Kode_BarangTextBox.Size = New System.Drawing.Size(116, 24)
        Me.Kode_BarangTextBox.TabIndex = 3
        '
        'Merk_HPTextBox
        '
        Me.Merk_HPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Merk HP", True))
        Me.Merk_HPTextBox.Location = New System.Drawing.Point(104, 147)
        Me.Merk_HPTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Merk_HPTextBox.Name = "Merk_HPTextBox"
        Me.Merk_HPTextBox.Size = New System.Drawing.Size(116, 24)
        Me.Merk_HPTextBox.TabIndex = 5
        '
        'HargaTextBox
        '
        Me.HargaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Harga", True))
        Me.HargaTextBox.Location = New System.Drawing.Point(104, 203)
        Me.HargaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HargaTextBox.Name = "HargaTextBox"
        Me.HargaTextBox.Size = New System.Drawing.Size(116, 24)
        Me.HargaTextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(363, 321)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Hapus"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(258, 321)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 32)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(472, 321)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 32)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button5.Location = New System.Drawing.Point(590, 321)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 32)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(357, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Data Barang"
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(933, 396)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Kode_BarangLabel)
        Me.Controls.Add(Me.Kode_BarangTextBox)
        Me.Controls.Add(Merk_HPLabel)
        Me.Controls.Add(Me.Merk_HPTextBox)
        Me.Controls.Add(HargaLabel)
        Me.Controls.Add(Me.HargaTextBox)
        Me.Controls.Add(Me.BarangDataGridView)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Barang"
        Me.Text = "Barang"
        CType(Me.Kelompok2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Kelompok2DataSet As Aplikasi_penjualan_HP.kelompok2DataSet
    Friend WithEvents BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarangTableAdapter As Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.barangTableAdapter
    Friend WithEvents TableAdapterManager As Aplikasi_penjualan_HP.kelompok2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BarangDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kode_BarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Merk_HPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HargaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

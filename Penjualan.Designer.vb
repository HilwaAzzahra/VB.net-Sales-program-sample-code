<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Penjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penjualan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LBLNamaCustomer = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLTanggal = New System.Windows.Forms.Label()
        Me.LBLFaktur = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LBLKembali = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBLTotalHarga = New System.Windows.Forms.Label()
        Me.LBLTotalBarang = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTDibayar = New System.Windows.Forms.TextBox()
        Me.BTNTutup = New System.Windows.Forms.Button()
        Me.BTNSimpan = New System.Windows.Forms.Button()
        Me.BTNBatal = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.LBLNamaCustomer)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LBLTanggal)
        Me.GroupBox1.Controls.Add(Me.LBLFaktur)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1141, 352)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.Nama, Me.Harga, Me.Jumlah, Me.Total})
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV.Location = New System.Drawing.Point(3, 71)
        Me.DGV.Name = "DGV"
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(1135, 278)
        Me.DGV.TabIndex = 8
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode"
        Me.Kode.Name = "Kode"
        Me.Kode.Width = 130
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama Barang"
        Me.Nama.Name = "Nama"
        Me.Nama.Width = 200
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        Me.Harga.Width = 130
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Width = 130
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.Width = 130
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(439, 7)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(181, 24)
        Me.ComboBox1.TabIndex = 7
        '
        'LBLNamaCustomer
        '
        Me.LBLNamaCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaCustomer.Location = New System.Drawing.Point(439, 29)
        Me.LBLNamaCustomer.Name = "LBLNamaCustomer"
        Me.LBLNamaCustomer.Size = New System.Drawing.Size(355, 24)
        Me.LBLNamaCustomer.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(317, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nama customer"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(317, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kode customer"
        '
        'LBLTanggal
        '
        Me.LBLTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggal.Location = New System.Drawing.Point(134, 29)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(177, 24)
        Me.LBLTanggal.TabIndex = 3
        Me.LBLTanggal.Text = "Label4"
        '
        'LBLFaktur
        '
        Me.LBLFaktur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLFaktur.Location = New System.Drawing.Point(134, 9)
        Me.LBLFaktur.Name = "LBLFaktur"
        Me.LBLFaktur.Size = New System.Drawing.Size(177, 24)
        Me.LBLFaktur.TabIndex = 2
        Me.LBLFaktur.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faktur"
        '
        'LBLKembali
        '
        Me.LBLKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLKembali.Location = New System.Drawing.Point(940, 422)
        Me.LBLKembali.Name = "LBLKembali"
        Me.LBLKembali.Size = New System.Drawing.Size(116, 24)
        Me.LBLKembali.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(818, 422)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Kembali"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(818, 402)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 24)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Dibayar"
        '
        'LBLTotalHarga
        '
        Me.LBLTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTotalHarga.Location = New System.Drawing.Point(940, 378)
        Me.LBLTotalHarga.Name = "LBLTotalHarga"
        Me.LBLTotalHarga.Size = New System.Drawing.Size(116, 24)
        Me.LBLTotalHarga.TabIndex = 11
        '
        'LBLTotalBarang
        '
        Me.LBLTotalBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTotalBarang.Location = New System.Drawing.Point(940, 354)
        Me.LBLTotalBarang.Name = "LBLTotalBarang"
        Me.LBLTotalBarang.Size = New System.Drawing.Size(116, 24)
        Me.LBLTotalBarang.TabIndex = 10
        Me.LBLTotalBarang.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(818, 378)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 24)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Total harga"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(818, 354)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 24)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Total barang"
        '
        'TXTDibayar
        '
        Me.TXTDibayar.Location = New System.Drawing.Point(940, 402)
        Me.TXTDibayar.Name = "TXTDibayar"
        Me.TXTDibayar.Size = New System.Drawing.Size(116, 22)
        Me.TXTDibayar.TabIndex = 15
        '
        'BTNTutup
        '
        Me.BTNTutup.AutoSize = True
        Me.BTNTutup.Image = CType(resources.GetObject("BTNTutup.Image"), System.Drawing.Image)
        Me.BTNTutup.Location = New System.Drawing.Point(153, 355)
        Me.BTNTutup.Name = "BTNTutup"
        Me.BTNTutup.Size = New System.Drawing.Size(76, 88)
        Me.BTNTutup.TabIndex = 17
        Me.BTNTutup.Text = "Tutup"
        Me.BTNTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNTutup.UseVisualStyleBackColor = True
        '
        'BTNSimpan
        '
        Me.BTNSimpan.AutoSize = True
        Me.BTNSimpan.Image = CType(resources.GetObject("BTNSimpan.Image"), System.Drawing.Image)
        Me.BTNSimpan.Location = New System.Drawing.Point(4, 355)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.Size = New System.Drawing.Size(76, 88)
        Me.BTNSimpan.TabIndex = 18
        Me.BTNSimpan.Text = "Simpan"
        Me.BTNSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNSimpan.UseVisualStyleBackColor = True
        '
        'BTNBatal
        '
        Me.BTNBatal.Image = CType(resources.GetObject("BTNBatal.Image"), System.Drawing.Image)
        Me.BTNBatal.Location = New System.Drawing.Point(79, 355)
        Me.BTNBatal.Name = "BTNBatal"
        Me.BTNBatal.Size = New System.Drawing.Size(75, 88)
        Me.BTNBatal.TabIndex = 19
        Me.BTNBatal.Text = "Batal"
        Me.BTNBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNBatal.UseVisualStyleBackColor = True
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 488)
        Me.Controls.Add(Me.BTNBatal)
        Me.Controls.Add(Me.BTNTutup)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.TXTDibayar)
        Me.Controls.Add(Me.LBLKembali)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LBLTotalHarga)
        Me.Controls.Add(Me.LBLTotalBarang)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBLNamaCustomer As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLTanggal As Label
    Friend WithEvents LBLFaktur As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LBLKembali As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLTotalHarga As Label
    Friend WithEvents LBLTotalBarang As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TXTDibayar As TextBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents BTNTutup As Button
    Friend WithEvents BTNSimpan As Button
    Friend WithEvents BTNBatal As Button
End Class

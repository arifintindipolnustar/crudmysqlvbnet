<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
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
        Me.pnlItem = New System.Windows.Forms.Panel()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.lblSub_Total = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblSatuan = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblKategori = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.pnlDaftar = New System.Windows.Forms.Panel()
        Me.dgData = New System.Windows.Forms.DataGridView()
        Me.pnlTransaksi = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.lblSisa = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlItem.SuspendLayout()
        Me.pnlDaftar.SuspendLayout()
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTransaksi.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlItem
        '
        Me.pnlItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItem.Controls.Add(Me.btnHapus)
        Me.pnlItem.Controls.Add(Me.btnTambah)
        Me.pnlItem.Controls.Add(Me.lblSub_Total)
        Me.pnlItem.Controls.Add(Me.Label9)
        Me.pnlItem.Controls.Add(Me.lblHarga)
        Me.pnlItem.Controls.Add(Me.Label8)
        Me.pnlItem.Controls.Add(Me.Label4)
        Me.pnlItem.Controls.Add(Me.txtQty)
        Me.pnlItem.Controls.Add(Me.lblSatuan)
        Me.pnlItem.Controls.Add(Me.Label6)
        Me.pnlItem.Controls.Add(Me.lblKategori)
        Me.pnlItem.Controls.Add(Me.Label5)
        Me.pnlItem.Controls.Add(Me.lblItem)
        Me.pnlItem.Controls.Add(Me.Label3)
        Me.pnlItem.Controls.Add(Me.Label2)
        Me.pnlItem.Controls.Add(Me.txtBarcode)
        Me.pnlItem.Controls.Add(Me.Label1)
        Me.pnlItem.Controls.Add(Me.txtNota)
        Me.pnlItem.Location = New System.Drawing.Point(13, 13)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(885, 187)
        Me.pnlItem.TabIndex = 0
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(21, 147)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(266, 30)
        Me.btnHapus.TabIndex = 17
        Me.btnHapus.Text = "Hapus Dari Daftar"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTambah.Location = New System.Drawing.Point(471, 152)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(394, 30)
        Me.btnTambah.TabIndex = 16
        Me.btnTambah.Text = "Tambahkan Ke Daftar Belanja"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'lblSub_Total
        '
        Me.lblSub_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSub_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSub_Total.Location = New System.Drawing.Point(731, 115)
        Me.lblSub_Total.Name = "lblSub_Total"
        Me.lblSub_Total.Size = New System.Drawing.Size(134, 20)
        Me.lblSub_Total.TabIndex = 15
        Me.lblSub_Total.Text = "SUB TOTAL"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(467, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "SUB TOTAL (Rp.)"
        '
        'lblHarga
        '
        Me.lblHarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHarga.Location = New System.Drawing.Point(731, 89)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(134, 20)
        Me.lblHarga.TabIndex = 13
        Me.lblHarga.Text = "HARGA"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(467, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "HARGA SATUAN (Rp.)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "QTY"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(108, 115)
        Me.txtQty.MaxLength = 10
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(179, 26)
        Me.txtQty.TabIndex = 10
        '
        'lblSatuan
        '
        Me.lblSatuan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSatuan.Location = New System.Drawing.Point(731, 60)
        Me.lblSatuan.Name = "lblSatuan"
        Me.lblSatuan.Size = New System.Drawing.Size(134, 20)
        Me.lblSatuan.TabIndex = 9
        Me.lblSatuan.Text = "SATUAN"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(651, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "SATUAN"
        '
        'lblKategori
        '
        Me.lblKategori.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKategori.Location = New System.Drawing.Point(470, 60)
        Me.lblKategori.Name = "lblKategori"
        Me.lblKategori.Size = New System.Drawing.Size(134, 20)
        Me.lblKategori.TabIndex = 7
        Me.lblKategori.Text = "KATEGORI"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(349, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "KATEGORI"
        '
        'lblItem
        '
        Me.lblItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItem.Location = New System.Drawing.Point(470, 31)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(395, 20)
        Me.lblItem.TabIndex = 5
        Me.lblItem.Text = "ITEM"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(349, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ITEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BARCODE"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(21, 83)
        Me.txtBarcode.MaxLength = 10
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(266, 26)
        Me.txtBarcode.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOTA"
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(21, 31)
        Me.txtNota.MaxLength = 10
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(266, 26)
        Me.txtNota.TabIndex = 0
        '
        'pnlDaftar
        '
        Me.pnlDaftar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDaftar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDaftar.Controls.Add(Me.dgData)
        Me.pnlDaftar.Location = New System.Drawing.Point(13, 206)
        Me.pnlDaftar.Name = "pnlDaftar"
        Me.pnlDaftar.Size = New System.Drawing.Size(885, 207)
        Me.pnlDaftar.TabIndex = 1
        '
        'dgData
        '
        Me.dgData.AllowUserToAddRows = False
        Me.dgData.AllowUserToDeleteRows = False
        Me.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgData.Location = New System.Drawing.Point(0, 0)
        Me.dgData.Name = "dgData"
        Me.dgData.ReadOnly = True
        Me.dgData.Size = New System.Drawing.Size(883, 205)
        Me.dgData.TabIndex = 0
        '
        'pnlTransaksi
        '
        Me.pnlTransaksi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTransaksi.Controls.Add(Me.btnReset)
        Me.pnlTransaksi.Controls.Add(Me.btnSimpan)
        Me.pnlTransaksi.Controls.Add(Me.lblSisa)
        Me.pnlTransaksi.Controls.Add(Me.Label12)
        Me.pnlTransaksi.Controls.Add(Me.Label7)
        Me.pnlTransaksi.Controls.Add(Me.txtBayar)
        Me.pnlTransaksi.Controls.Add(Me.lblTotal)
        Me.pnlTransaksi.Controls.Add(Me.Label10)
        Me.pnlTransaksi.Location = New System.Drawing.Point(12, 419)
        Me.pnlTransaksi.Name = "pnlTransaksi"
        Me.pnlTransaksi.Size = New System.Drawing.Size(885, 106)
        Me.pnlTransaksi.TabIndex = 2
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(22, 10)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(106, 78)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "Batalkan  Mulai Ulang"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(134, 10)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(257, 78)
        Me.btnSimpan.TabIndex = 22
        Me.btnSimpan.Text = "Simpan Transaksi Penjualan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'lblSisa
        '
        Me.lblSisa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSisa.Location = New System.Drawing.Point(656, 65)
        Me.lblSisa.Name = "lblSisa"
        Me.lblSisa.Size = New System.Drawing.Size(210, 20)
        Me.lblSisa.TabIndex = 21
        Me.lblSisa.Text = "KEMBALIAN"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(468, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 20)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "KEMBALIAN (Rp.)"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(468, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "CASH (Rp.)"
        '
        'txtBayar
        '
        Me.txtBayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBayar.Location = New System.Drawing.Point(656, 36)
        Me.txtBayar.MaxLength = 10
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(210, 26)
        Me.txtBayar.TabIndex = 18
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(656, 10)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(210, 20)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "TOTAL"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(468, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "TOTAL (Rp.)"
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 537)
        Me.Controls.Add(Me.pnlTransaksi)
        Me.Controls.Add(Me.pnlDaftar)
        Me.Controls.Add(Me.pnlItem)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimizeBox = False
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Informasi Polnustar - Point of Sale (POS)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlItem.ResumeLayout(False)
        Me.pnlItem.PerformLayout()
        Me.pnlDaftar.ResumeLayout(False)
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTransaksi.ResumeLayout(False)
        Me.pnlTransaksi.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlItem As System.Windows.Forms.Panel
    Friend WithEvents pnlDaftar As System.Windows.Forms.Panel
    Friend WithEvents pnlTransaksi As System.Windows.Forms.Panel
    Friend WithEvents dgData As System.Windows.Forms.DataGridView
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblKategori As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSatuan As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSub_Total As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBayar As System.Windows.Forms.TextBox
    Friend WithEvents lblSisa As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class

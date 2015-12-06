<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Me.msCrud = New System.Windows.Forms.MenuStrip()
        Me.mnAplikasi = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnKategori = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSatuan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnGaris1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnStok = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMutasi_Stok = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnGaris2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnStok_Masuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPos = New System.Windows.Forms.ToolStripMenuItem()
        Me.msCrud.SuspendLayout()
        Me.SuspendLayout()
        '
        'msCrud
        '
        Me.msCrud.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAplikasi, Me.mnMaster, Me.mnStok, Me.mnPos})
        Me.msCrud.Location = New System.Drawing.Point(0, 0)
        Me.msCrud.Name = "msCrud"
        Me.msCrud.Size = New System.Drawing.Size(813, 24)
        Me.msCrud.TabIndex = 1
        Me.msCrud.Text = "MenuStrip1"
        '
        'mnAplikasi
        '
        Me.mnAplikasi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnKeluar})
        Me.mnAplikasi.Name = "mnAplikasi"
        Me.mnAplikasi.Size = New System.Drawing.Size(60, 20)
        Me.mnAplikasi.Text = "Aplikasi"
        '
        'mnKeluar
        '
        Me.mnKeluar.Name = "mnKeluar"
        Me.mnKeluar.Size = New System.Drawing.Size(107, 22)
        Me.mnKeluar.Text = "Keluar"
        '
        'mnMaster
        '
        Me.mnMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnKategori, Me.mnSatuan, Me.mnGaris1, Me.mnItem})
        Me.mnMaster.Name = "mnMaster"
        Me.mnMaster.Size = New System.Drawing.Size(55, 20)
        Me.mnMaster.Text = "Master"
        '
        'mnKategori
        '
        Me.mnKategori.Name = "mnKategori"
        Me.mnKategori.Size = New System.Drawing.Size(152, 22)
        Me.mnKategori.Text = "Kategori"
        '
        'mnSatuan
        '
        Me.mnSatuan.Name = "mnSatuan"
        Me.mnSatuan.Size = New System.Drawing.Size(152, 22)
        Me.mnSatuan.Text = "Satuan"
        '
        'mnGaris1
        '
        Me.mnGaris1.Name = "mnGaris1"
        Me.mnGaris1.Size = New System.Drawing.Size(149, 6)
        '
        'mnItem
        '
        Me.mnItem.Name = "mnItem"
        Me.mnItem.Size = New System.Drawing.Size(152, 22)
        Me.mnItem.Text = "Item"
        '
        'mnStok
        '
        Me.mnStok.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnMutasi_Stok, Me.mnGaris2, Me.mnStok_Masuk})
        Me.mnStok.Name = "mnStok"
        Me.mnStok.Size = New System.Drawing.Size(42, 20)
        Me.mnStok.Text = "Stok"
        '
        'mnMutasi_Stok
        '
        Me.mnMutasi_Stok.Name = "mnMutasi_Stok"
        Me.mnMutasi_Stok.Size = New System.Drawing.Size(152, 22)
        Me.mnMutasi_Stok.Text = "Mutasi Stok"
        '
        'mnGaris2
        '
        Me.mnGaris2.Name = "mnGaris2"
        Me.mnGaris2.Size = New System.Drawing.Size(149, 6)
        '
        'mnStok_Masuk
        '
        Me.mnStok_Masuk.Name = "mnStok_Masuk"
        Me.mnStok_Masuk.Size = New System.Drawing.Size(152, 22)
        Me.mnStok_Masuk.Text = "Stok Masuk"
        '
        'mnPos
        '
        Me.mnPos.Name = "mnPos"
        Me.mnPos.Size = New System.Drawing.Size(41, 20)
        Me.mnPos.Text = "POS"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 363)
        Me.Controls.Add(Me.msCrud)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msCrud
        Me.Name = "frmUtama"
        Me.Text = "CRUD - Penjualan (Sistem Informasi Polnustar)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msCrud.ResumeLayout(False)
        Me.msCrud.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msCrud As System.Windows.Forms.MenuStrip
    Friend WithEvents mnAplikasi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnKategori As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSatuan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnGaris1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnStok As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnMutasi_Stok As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnGaris2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnStok_Masuk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPos As System.Windows.Forms.ToolStripMenuItem

End Class

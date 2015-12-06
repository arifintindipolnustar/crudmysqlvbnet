<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStok
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
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.dgData = New System.Windows.Forms.DataGridView()
        Me.pnlOlah = New System.Windows.Forms.Panel()
        Me.btnStokMasuk = New System.Windows.Forms.Button()
        Me.btnPenjualan = New System.Windows.Forms.Button()
        Me.pnlFilter.SuspendLayout()
        Me.pnlData.SuspendLayout()
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOlah.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFilter
        '
        Me.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFilter.Controls.Add(Me.Label2)
        Me.pnlFilter.Controls.Add(Me.Label1)
        Me.pnlFilter.Controls.Add(Me.btnFilter)
        Me.pnlFilter.Controls.Add(Me.dtpAkhir)
        Me.pnlFilter.Controls.Add(Me.dtpAwal)
        Me.pnlFilter.Controls.Add(Me.btnReset)
        Me.pnlFilter.Location = New System.Drawing.Point(13, 13)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(720, 63)
        Me.pnlFilter.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "S/D"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dari"
        '
        'btnFilter
        '
        Me.btnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilter.Location = New System.Drawing.Point(640, 21)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 3
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpAkhir.Location = New System.Drawing.Point(434, 24)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(200, 20)
        Me.dtpAkhir.TabIndex = 2
        '
        'dtpAwal
        '
        Me.dtpAwal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpAwal.Location = New System.Drawing.Point(194, 24)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(200, 20)
        Me.dtpAwal.TabIndex = 1
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(4, 21)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(137, 23)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Tampilkan Semua Data"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'pnlData
        '
        Me.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlData.Controls.Add(Me.dgData)
        Me.pnlData.Location = New System.Drawing.Point(12, 82)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(720, 235)
        Me.pnlData.TabIndex = 1
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
        Me.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgData.Size = New System.Drawing.Size(718, 233)
        Me.dgData.TabIndex = 0
        '
        'pnlOlah
        '
        Me.pnlOlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOlah.Controls.Add(Me.btnStokMasuk)
        Me.pnlOlah.Controls.Add(Me.btnPenjualan)
        Me.pnlOlah.Location = New System.Drawing.Point(13, 323)
        Me.pnlOlah.Name = "pnlOlah"
        Me.pnlOlah.Size = New System.Drawing.Size(720, 55)
        Me.pnlOlah.TabIndex = 2
        '
        'btnStokMasuk
        '
        Me.btnStokMasuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStokMasuk.Location = New System.Drawing.Point(493, 15)
        Me.btnStokMasuk.Name = "btnStokMasuk"
        Me.btnStokMasuk.Size = New System.Drawing.Size(140, 23)
        Me.btnStokMasuk.TabIndex = 1
        Me.btnStokMasuk.Text = "Stok Masuk"
        Me.btnStokMasuk.UseVisualStyleBackColor = True
        '
        'btnPenjualan
        '
        Me.btnPenjualan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPenjualan.Location = New System.Drawing.Point(639, 15)
        Me.btnPenjualan.Name = "btnPenjualan"
        Me.btnPenjualan.Size = New System.Drawing.Size(75, 23)
        Me.btnPenjualan.TabIndex = 0
        Me.btnPenjualan.Text = "Buka POS"
        Me.btnPenjualan.UseVisualStyleBackColor = True
        '
        'frmStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 390)
        Me.Controls.Add(Me.pnlOlah)
        Me.Controls.Add(Me.pnlData)
        Me.Controls.Add(Me.pnlFilter)
        Me.Name = "frmStok"
        Me.Text = "Stok"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        Me.pnlData.ResumeLayout(False)
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOlah.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents pnlData As System.Windows.Forms.Panel
    Friend WithEvents pnlOlah As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents dtpAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgData As System.Windows.Forms.DataGridView
    Friend WithEvents btnStokMasuk As System.Windows.Forms.Button
    Friend WithEvents btnPenjualan As System.Windows.Forms.Button
End Class

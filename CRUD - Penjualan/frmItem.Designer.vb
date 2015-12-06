<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItem
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
        Me.pnlCari = New System.Windows.Forms.Panel()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.dgData = New System.Windows.Forms.DataGridView()
        Me.pnlOlah = New System.Windows.Forms.Panel()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.pnlCari.SuspendLayout()
        Me.pnlData.SuspendLayout()
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOlah.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCari
        '
        Me.pnlCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCari.Controls.Add(Me.btnReload)
        Me.pnlCari.Controls.Add(Me.Label1)
        Me.pnlCari.Controls.Add(Me.btnCari)
        Me.pnlCari.Controls.Add(Me.txtCari)
        Me.pnlCari.Location = New System.Drawing.Point(13, 13)
        Me.pnlCari.Name = "pnlCari"
        Me.pnlCari.Size = New System.Drawing.Size(756, 55)
        Me.pnlCari.TabIndex = 0
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(12, 9)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(184, 23)
        Me.btnReload.TabIndex = 3
        Me.btnReload.Text = "Reload Seluruh Data"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(378, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kata Kunci Pencarian"
        '
        'btnCari
        '
        Me.btnCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCari.Location = New System.Drawing.Point(676, 14)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 1
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCari.Location = New System.Drawing.Point(494, 14)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(176, 20)
        Me.txtCari.TabIndex = 0
        '
        'pnlData
        '
        Me.pnlData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlData.Controls.Add(Me.dgData)
        Me.pnlData.Location = New System.Drawing.Point(12, 74)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(756, 244)
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
        Me.dgData.Size = New System.Drawing.Size(754, 242)
        Me.dgData.TabIndex = 0
        '
        'pnlOlah
        '
        Me.pnlOlah.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOlah.Controls.Add(Me.btnHapus)
        Me.pnlOlah.Controls.Add(Me.btnEdit)
        Me.pnlOlah.Controls.Add(Me.btnTambah)
        Me.pnlOlah.Location = New System.Drawing.Point(13, 324)
        Me.pnlOlah.Name = "pnlOlah"
        Me.pnlOlah.Size = New System.Drawing.Size(756, 32)
        Me.pnlOlah.TabIndex = 2
        '
        'btnHapus
        '
        Me.btnHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHapus.Location = New System.Drawing.Point(514, 3)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(595, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTambah.Location = New System.Drawing.Point(676, 3)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'frmItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 368)
        Me.Controls.Add(Me.pnlOlah)
        Me.Controls.Add(Me.pnlData)
        Me.Controls.Add(Me.pnlCari)
        Me.Name = "frmItem"
        Me.Text = "Item Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlCari.ResumeLayout(False)
        Me.pnlCari.PerformLayout()
        Me.pnlData.ResumeLayout(False)
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOlah.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCari As System.Windows.Forms.Panel
    Friend WithEvents pnlData As System.Windows.Forms.Panel
    Friend WithEvents pnlOlah As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents dgData As System.Windows.Forms.DataGridView
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
End Class

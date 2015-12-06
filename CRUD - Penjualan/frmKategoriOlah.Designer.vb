<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKategoriOlah
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId_kategori = New System.Windows.Forms.TextBox()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.btnYa = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Kategori"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kategori"
        '
        'txtId_kategori
        '
        Me.txtId_kategori.Location = New System.Drawing.Point(98, 13)
        Me.txtId_kategori.MaxLength = 5
        Me.txtId_kategori.Name = "txtId_kategori"
        Me.txtId_kategori.Size = New System.Drawing.Size(100, 20)
        Me.txtId_kategori.TabIndex = 2
        '
        'txtKategori
        '
        Me.txtKategori.Location = New System.Drawing.Point(98, 39)
        Me.txtKategori.MaxLength = 10
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(222, 20)
        Me.txtKategori.TabIndex = 3
        '
        'btnYa
        '
        Me.btnYa.Location = New System.Drawing.Point(180, 77)
        Me.btnYa.Name = "btnYa"
        Me.btnYa.Size = New System.Drawing.Size(75, 23)
        Me.btnYa.TabIndex = 4
        Me.btnYa.Text = "Button1"
        Me.btnYa.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(99, 77)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 5
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'frmKategoriOlah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 111)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnYa)
        Me.Controls.Add(Me.txtKategori)
        Me.Controls.Add(Me.txtId_kategori)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmKategoriOlah"
        Me.Text = "frmKategoriOlah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtId_kategori As System.Windows.Forms.TextBox
    Friend WithEvents txtKategori As System.Windows.Forms.TextBox
    Friend WithEvents btnYa As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class

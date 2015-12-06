Public Class frmKategori
    Dim id_aktif As String

    'Membuat metode untuk menampilkan data dari tabel Kategori ke dalam Datagridview (dgData)
    Public Sub isiDataGrid()
        'Untuk mengisi datagrid view, kita akan membuat objek baru dari clsVisualisasiData...
        Dim visualdata As New clsVisualisasiData

        'Query mysql Untuk menampilkan data pada tabel kategori pada dgData
        Dim sql As String = "SELECT * FROM kategori"

        'Melakukan proses pengisian / load datagridview dengan perintah dari variabel sql
        visualdata.isiDatagrid(sql, dgData)
    End Sub
    Private Sub frmKategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isiDataGrid()
    End Sub
    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim olah As New frmKategoriOlah
        With olah
            .Mode = ModeOlah.Tambah
            .Id_Kategori = vbNull
            .ShowDialog()
        End With
    End Sub

    Private Sub dgData_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgData.SelectionChanged
        id_aktif = deteksiId_Aktif(dgData, 0)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim olah As New frmKategoriOlah
        With olah
            .Mode = ModeOlah.Edit
            .Id_Kategori = id_aktif
            .ShowDialog()
        End With
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim crud As New clsOperasiCRUD

        'Kondisi dimana Nilai kembalian dari operasi crud.HapusData = konfirmasi berhasil maka akan dilakukan reload data
        If crud.hapusData("kategori", "id_kategori", "'" & id_aktif & "'") = Konfirmasi.Berhasil Then
            Call isiDataGrid()
        End If

    End Sub
End Class
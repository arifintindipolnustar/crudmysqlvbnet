Public Class frmKategoriOlah
    'Variabel parameter mode yang menetukan mode olah (Insert/Tambah ataupun Edit/Update)
    Public Mode As ModeOlah

    'Variabel parameter id yang akan menentukan proses pembacaan data
    Public Id_Kategori As String

    'Metode setting awal
    Sub settingAwal()
        If Mode = ModeOlah.Tambah Then
            Me.Text = "Tambah Data Kategori"
            btnYa.Text = "Tambah"
        ElseIf Mode = ModeOlah.Edit Then
            Me.Text = "Edit Data Kategori"
            btnYa.Text = "Update"
            bacaData()
        End If
    End Sub

    'Metode Baca Data untuk Fungsi Edit
    Sub bacaData()
        Dim crud As New fxCRUD

        'membuat query mysql berdasarkan ID
        Dim sql As String = "SELECT * FROM kategori WHERE id_kategori = '" & Id_Kategori & "'"
        crud.Query(sql)
        crud.fxBukaBacaData()

        If crud.pDataReader.Read Then
            txtId_kategori.Text = crud.pDataReader.GetString("id_kategori")
            txtKategori.Text = crud.pDataReader.GetString("kategori")
            crud.fxTutupBacaData()
        End If
    End Sub

    Sub simpanData()
        Dim sukses As Konfirmasi
        Dim crud As New clsOperasiCRUD

        Dim tabel As String = "kategori"
        Dim kolom_s As String() = {"id_kategori", "kategori"}
        Dim value_s As String() = {txtId_kategori.Text, txtKategori.Text}

        If Mode = ModeOlah.Tambah Then
            sukses = crud.simpanData(tabel, kolom_s, value_s)
        ElseIf Mode = ModeOlah.Edit Then
            Dim kolom_parameter As String = "id_kategori"
            Dim value_parameter As String = "'" & Id_Kategori & "'" '#karena tipe data string pada mysql
            sukses = crud.simpanData(tabel, kolom_s, value_s, kolom_parameter, value_parameter)
        End If

        If sukses = Konfirmasi.Berhasil Then
            frmKategori.isiDataGrid()
            Me.Close()
        ElseIf sukses = Konfirmasi.Gagal Then
            MessageBox.Show("Operasi Gagal")
        End If
    End Sub

    Private Sub frmKategoriOlah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call settingAwal()
    End Sub

    Private Sub btnYa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYa.Click
        Call simpanData()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class
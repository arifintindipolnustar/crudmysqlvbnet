Public Class frmSatuan
    Dim id_aktif As String
    Dim cur_id_aktif As cursorID_aktif
    Dim mode_olah As ModeOlah
    Dim visualData As New clsVisualisasiData
    Public Sub isiDataGrid()
        Dim sql As String = "SELECT * FROM satuan" '#
        visualData.isiDatagrid(sql, dgData)
    End Sub
    Sub fxHapus()
        Dim crud As New clsOperasiCRUD
        If Status_Cursor_ID = cursorID_aktif.Ada Then
            Dim sts As Konfirmasi
            '/START
            Dim tabel As String = "Satuan" '#
            Dim parkol As String = "id_satuan" '#
            '/FINISH
            Dim valkol As String = "'" & id_aktif & "'" '#
            sts = crud.hapusData(tabel, parkol, valkol)
            If sts = Konfirmasi.Berhasil Then
                Call isiDataGrid()
            End If
        End If
    End Sub
    Sub fxOlah(ByVal idaktif As String)
        Dim olah As New frmSatuanOlah '#
        With olah
            If mode_olah = ModeOlah.Tambah Then
                .Mode = ModeCrud.Insert
                .kode = vbNull
            ElseIf mode_olah = ModeOlah.Edit And Status_Cursor_ID = cursorID_aktif.Ada Then
                .Mode = ModeCrud.Update
                .kode = idaktif
            End If
            .ShowDialog()
        End With
    End Sub
    Private Sub frmSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isiDataGrid()
    End Sub
    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        mode_olah = ModeOlah.Tambah
        Call fxOlah(vbNull)
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        mode_olah = ModeOlah.Edit
        Call fxOlah(id_aktif)
    End Sub
    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Call fxHapus()
    End Sub

    Private Sub dgData_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgData.SelectionChanged
        id_aktif = deteksiId_Aktif(dgData, 0) '#
    End Sub
End Class
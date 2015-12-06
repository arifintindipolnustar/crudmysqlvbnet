Public Class frmSatuanOlah
    Dim local_mode As ModeCrud
    Public kode As String
    Public Property Mode
        Get
            Return local_mode
        End Get
        Set(ByVal value)
            local_mode = value
        End Set
    End Property
    Sub setAwal()
        If local_mode = ModeCrud.Insert Then
            Me.Text = "Tambah Data Satuan" '#
            btnYa.Text = "Tambah" '#
        ElseIf local_mode = ModeCrud.Update Then
            Me.Text = "Edit Satuan" '#
            btnYa.Text = "Update" '#
            Call fxEdit()
        End If
    End Sub
    Sub fxEdit()
        Dim crud As New fxCRUD
        Dim sql As String
        sql = "SELECT * FROM satuan WHERE id_satuan = '" & kode & "'" '#
        Try
            crud.Query(sql)
            crud.fxBukaBacaData()
            If crud.pDataReader.Read Then
                '/START
                txtId_satuan.Text = kode '#
                txtSatuan.Text = crud.pDataReader.GetString("satuan") '#
                '/FINISH
                crud.fxTutupBacaData()
            End If
        Catch ex As Exception
            Dim pesan As String = ex.Message
            crud.pKon.pCmd.Dispose()
            crud.pKon.pKon.Dispose()
            MessageBox.Show("Kesalahan Baca Data : " & pesan)
            Me.Close()
        End Try
    End Sub
    Sub fxSimpan()
        Dim crud As New clsOperasiCRUD
        Dim sts As Konfirmasi
        Dim tabel As String = "Satuan" '#
        Dim kol() As String = {"id_satuan", "satuan"} '#
        Dim val() As String = {txtId_satuan.Text, txtSatuan.Text} '#
        If local_mode = ModeCrud.Insert Then
            sts = crud.simpanData(tabel, kol, val) '#            
        ElseIf local_mode = ModeCrud.Update Then
            Dim parKol As String = "id_satuan" '#
            Dim valKol As String = "'" & kode & "'" '#
            sts = crud.simpanData(tabel, kol, val, parKol, valKol)
        End If
        If sts = Konfirmasi.Berhasil Then
            Call frmSatuan.isiDataGrid() '#
            Me.Close()
        End If
    End Sub

    Private Sub frmSatuanOlah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setAwal()
    End Sub

    Private Sub btnYa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYa.Click
        Call fxSimpan()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class
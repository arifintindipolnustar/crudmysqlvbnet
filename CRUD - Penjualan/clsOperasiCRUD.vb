Public Class clsOperasiCRUD
    Public sqlQ As String

    Public Function simpanData(ByVal Tabel As String, ByVal Kolom() As String, ByVal valKolom() As String) As Konfirmasi
        Dim sukses As Konfirmasi
        Dim crud As New fxCRUD
        Dim buffer_Kolom As String = ""
        Dim buffer_Value As String = ""
        Dim sqlQuery As String = ""

        For i As Integer = 0 To (Kolom.Length - 1)
            If (Kolom.Length - i) <= 1 Then
                buffer_Kolom = buffer_Kolom & Kolom(i)
                buffer_Value = buffer_Value & "'" & valKolom(i) & "'"
            Else
                buffer_Kolom = buffer_Kolom & Kolom(i) & ","
                buffer_Value = buffer_Value & "'" & valKolom(i) & "',"
            End If
        Next
        sqlQuery = "INSERT INTO " & Tabel & "(" & buffer_Kolom & ") VALUES(" & buffer_Value & ")"
        Try
            crud.Query(sqlQuery)
            crud.fxStored()
            sukses = Konfirmasi.Berhasil
            MessageBox.Show("Berhasil Tambah Data")
        Catch ex As Exception
            Dim salah As String = ex.Message
            crud.pKon.pCmd.Dispose()
            crud.pKon.pKon.Dispose()
            sukses = Konfirmasi.Gagal
            MessageBox.Show("Gagal Tambah Data : " & salah)
        End Try
        Return sukses
    End Function
    Public Function simpanData(ByVal Tabel As String, ByVal Kolom() As String, ByVal valKolom() As String, ByVal paramKol As String, ByVal paramVal As String) As Konfirmasi
        Dim sukses As Konfirmasi
        Dim crud As New fxCRUD
        Dim buffer_Kolom_Value As String = ""
        Dim sqlQuery As String = ""
        For i As Integer = 0 To (Kolom.Length - 1)
            If (Kolom.Length - i) <= 1 Then
                buffer_Kolom_Value = buffer_Kolom_Value & Kolom(i) & " = '" & valKolom(i) & "'"
            Else
                buffer_Kolom_Value = buffer_Kolom_Value & Kolom(i) & " = '" & valKolom(i) & "',"
            End If
        Next
        sqlQuery = "UPDATE " & Tabel & " SET " & buffer_Kolom_Value & " WHERE " & paramKol & " = " & paramVal
        Try
            crud.Query(sqlQuery)
            crud.fxStored()
            sukses = Konfirmasi.Berhasil
            MessageBox.Show("Berhasil Update")
        Catch ex As Exception
            Dim salah As String = ex.Message
            crud.pKon.pCmd.Dispose()
            crud.pKon.pKon.Dispose()
            sukses = Konfirmasi.Gagal
            MessageBox.Show("Gagal Update : " & salah)
        End Try
        Return sukses
    End Function

    Public Function hapusData(ByVal Tabel As String, ByVal paramKol As String, ByVal valueKol As String) As Konfirmasi
        Dim sukses As Konfirmasi
        Dim crud As New fxCRUD
        Dim sqlQuery As String = "DELETE FROM " & Tabel & " WHERE " & paramKol & " = " & valueKol
        Dim setuju = MessageBox.Show("Hapus Data.?", Tabel, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If setuju = DialogResult.Yes Then
            Try
                crud.Query(sqlQuery)
                crud.fxStored()
                sukses = Konfirmasi.Berhasil
                MessageBox.Show("Berhasil Hapus Data")
            Catch ex As Exception
                Dim salah As String = ex.Message
                crud.pKon.pCmd.Dispose()
                crud.pKon.pKon.Dispose()
                sukses = Konfirmasi.Gagal
                MessageBox.Show("Gagal Hapus Data : " & salah)
            End Try
        Else
            sukses = Konfirmasi.Batal
            MessageBox.Show("Batal Hapus Data")
        End If
        Return sukses
    End Function
End Class

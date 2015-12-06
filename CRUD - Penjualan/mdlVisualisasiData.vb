Module mdlVisualisasiData
    Dim status_cursor As cursorID_aktif
    Public Function deteksiId_Aktif(ByVal DG As DataGridView, ByVal index_Cell As Integer) As String
        Dim id_aktif As String = ""
        If DG.RowCount > 0 Then
            id_aktif = DG.CurrentRow.Cells(index_Cell).Value.ToString
            status_cursor = cursorID_aktif.Ada
        Else
            id_aktif = vbNull
            status_cursor = cursorID_aktif.Tidak
        End If
        Return id_aktif
    End Function
    Public Sub dg_Format_Angka(ByVal Kolom As DataGridViewColumn)
        With Kolom
            .DefaultCellStyle.Format = "##,##"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub
    Public ReadOnly Property Status_Cursor_ID
        Get
            Return status_cursor
        End Get
    End Property
End Module

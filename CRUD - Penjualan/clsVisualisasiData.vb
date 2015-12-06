Public Class clsVisualisasiData
    Dim varcrud As fxCRUD
    Public Sub isiDatagrid(ByVal SQLQuery As String, ByVal DG As DataGridView)
        Try
            varcrud = New fxCRUD
            varcrud.Query(SQLQuery)
            varcrud.fxIsiAdapter()
            varcrud.fxIsiBindingSource()
            DG.DataSource = varcrud.pBindingSource
            DG.Refresh()
        Catch ex As Exception
            Dim salah As String = ex.Message
            varcrud.pKon.pCmd.Dispose()
            varcrud.pKon.pKon.Dispose()
            MessageBox.Show("Kesalahan Isi DataGrid : " & salah)
        End Try
    End Sub
    Public Sub isiComboBox(ByVal SQLQuery As String, ByVal Tabel As String, ByVal colDisplay As String, ByVal colValue As String, ByVal CB As ComboBox)
        Try
            varcrud = New fxCRUD
            varcrud.Query(SQLQuery)
            varcrud.fxIsiAdapter()
            varcrud.fxIsiBindingSource()
            With CB
                .DataSource = varcrud.pBindingSource
                .ValueMember = colValue
                .DisplayMember = colDisplay
            End With
        Catch ex As Exception
            Dim salah As String = ex.Message
            varcrud.pKon.pCmd.Dispose()
            varcrud.pKon.pKon.Dispose()
            MessageBox.Show("Kesalahan Isi Combo : " & salah)
        End Try
    End Sub

    Public Property vCRUD As fxCRUD
        Get
            Return varcrud
        End Get
        Set(ByVal value As fxCRUD)
            varcrud = value
        End Set
    End Property
End Class

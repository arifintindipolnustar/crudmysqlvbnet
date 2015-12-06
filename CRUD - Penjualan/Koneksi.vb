Imports MySql.Data.MySqlClient

Public Class Koneksi
    'Parameter Database MySQL
    Dim host As String
    Dim username As String
    Dim password As String
    Dim database As String
    Dim port As String

    Dim stringKoneksi As String

    'Variabel MySQL .NET Connector Untuk Koneksi dan Perintah MySQL
    Dim kon As MySqlConnection
    Dim cmd As MySqlCommand

    'Setting Parameter Database MySQL
    Sub fxSettingDatabase()
        host = "localhost" 'DIUBAH SESUAI SETTING MYSQL SERVER
        username = "root" 'DIUBAH SESUAI SETTING MYSQL SERVER
        password = "" 'DIUBAH SESUAI SETTING MYSQL SERVER
        database = "penjualan" 'DIUBAH SESUAI SETTING MYSQL SERVER
        port = "3306" 'PORT DEFAULT MYSQL - DIUBAH SESUAI SETTING MYSQL SERVER

        stringKoneksi = "Data Source=" & host & ";UserName =" & username & ";Password=" & _
            password & ";DataBase =" & database & ";PORT =" & port
    End Sub

    Public Sub fxKonek()
        Try
            Call fxSettingDatabase()

            kon = New MySqlConnection
            kon.ConnectionString = stringKoneksi
            kon.Open()
        Catch ex As Exception
            MessageBox.Show("Kesalahan Koneksi : " & ex.Message) 'DAPAT DISESUAIKAN
            kon.Dispose()
        End Try
    End Sub

    Public Sub fxEksekusi(ByVal Perintah As String)
        Try
            cmd = New MySqlCommand
            cmd.CommandText = Perintah
            cmd.Connection = kon
        Catch ex As Exception
            MessageBox.Show("Kesalahan Eksekusi Perintah : " & ex.Message) 'DAPAT DISESUAIKAN
            cmd.Dispose()
        End Try
    End Sub

    Public ReadOnly Property pKon As MySqlConnection
        Get
            Return kon
        End Get
    End Property

    Public Property pCmd As MySqlCommand
        Get
            Return cmd
        End Get
        Set(ByVal value As MySqlCommand)
            cmd = value
        End Set
    End Property
End Class

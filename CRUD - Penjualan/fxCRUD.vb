Imports MySql.Data.MySqlClient 'Menggunakan Referensi MySQL .NET Connector
Imports System.Data 'Menggunakan Referensi ADO .NET

Public Class fxCRUD
    Dim kon As Koneksi 'Variabel Baru Dari Class Koneksi yang telah kita buat sebelumnya

    'Variabel MySQL .NET Connector Untuk Fungsi Crud
    Dim dataAdapter As MySqlDataAdapter
    Dim dataReader As MySqlDataReader

    'Variabel Dari ADO .NET untuk fungsi Memuat Data
    Dim dataSet As DataSet
    Dim bindingSource As BindingSource

    'Fungsi Untuk Melakukan Query MySQL yang akan di eksekusi
    Public Sub Query(ByVal SQL As String)
        'Konstruksi Kelas Koneksi
        kon = New Koneksi

        'Koneksi Ke Database MySQL
        kon.fxKonek()

        'Eksekusi Perintah / Query
        kon.fxEksekusi(SQL)
    End Sub

    'Fungsi Buffer / Load Data ke DataAdapter
    Public Sub fxIsiAdapter()
        'Konstruksi Data Set
        dataSet = New DataSet

        'Konstruksi MySQL Data Adapter
        dataAdapter = New MySqlDataAdapter(kon.pCmd.CommandText, kon.pKon)

        'Isi Data Adapter
        dataAdapter.Fill(dataSet, kon.pCmd.CommandText)

        'Tutup Koneksi
        kon.pKon.Close()
    End Sub
    Public Sub fxIsiAdapterTabel(ByVal Tabel As String)
        'Konstruksi Data Set
        dataSet = New DataSet

        'Konstruksi MySQL Data Adapter
        dataAdapter = New MySqlDataAdapter(kon.pCmd.CommandText, kon.pKon)

        'Isi Data Adapter
        dataAdapter.Fill(dataSet, Tabel)

        'Tutup Koneksi
        kon.pKon.Close()
    End Sub

    'Fungsi Load Data ke BindingSource
    Public Sub fxIsiBindingSource()
        'Konstruksi Binding Source
        bindingSource = New BindingSource

        'Isi BindingSource dengan Datase
        bindingSource.DataSource = dataSet

        'Setting Parameter BindingSource
        bindingSource.DataMember = kon.pCmd.CommandText
    End Sub
    'Fungsi Load Data ke BindingSourceCombo
    Public Sub fxIsiBindingSourceTabel(ByVal tabel As String)
        'Konstruksi Binding Source
        bindingSource = New BindingSource

        'Isi BindingSource dengan Datase
        bindingSource.DataSource = dataSet.Tables(tabel)

    End Sub

    'Fungsi Membaca Data (Per Record / Baris)
    Public Sub fxBukaBacaData()
        'Konstruksi MySQL Data Reader
        dataReader = kon.pCmd.ExecuteReader()
    End Sub
    Public Sub fxTutupBacaData()
        'Tutup MySQL Data Reader
        dataReader.Close()

        'Tutp Koneksi
        kon.pKon.Close()
    End Sub

    'Fungsi Stored Database (Insert, Update & Delete)
    Public Sub fxStored()
        'Eksekusi Non Query
        kon.pCmd.ExecuteNonQuery()

        'Tutup Koneksi
    End Sub



    'Membuat Property Public Untuk Koneksi
    Public Property pKon As Koneksi
        Get
            Return kon
        End Get
        Set(ByVal value As Koneksi)
            kon = value
        End Set
    End Property

    'Membuat Property Public Untuk MySQL Data Adapter
    Public Property pDataAdapter As MySqlDataAdapter
        Get
            Return dataAdapter
        End Get
        Set(ByVal value As MySqlDataAdapter)
            dataAdapter = value
        End Set
    End Property

    'Membuat Property Public Untuk MySQL Data Reader
    Public Property pDataReader As MySqlDataReader
        Get
            Return dataReader
        End Get
        Set(ByVal value As MySqlDataReader)
            dataReader = value
        End Set
    End Property

    'Membuat Property Public Untuk DataSet
    Public Property pDataSet As DataSet
        Get
            Return dataSet
        End Get
        Set(ByVal value As DataSet)
            dataSet = value
        End Set
    End Property

    'Membuat Propert Public Untuk BindingSource
    Public Property pBindingSource As BindingSource
        Get
            Return bindingSource
        End Get
        Set(ByVal value As BindingSource)
            bindingSource = value
        End Set
    End Property
End Class

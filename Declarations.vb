Imports System.Data.OleDb

Module Declarations
    Public dbConnection As New OleDbConnection
    Public dbAdapter As New OleDbDataAdapter
    Public dbDataSet As New DataSet

    Public dbDataTable As New DataTable
    Public queryCommand As New OleDbCommand

    Sub ConnectDB()
        dbConnection.ConnectionString = "Provider=SQLNCLI11;Server=(LocalDB)\MSSQLLocalDB;Database=GSS;Trusted_Connection=yes;"
        Return
    End Sub

End Module

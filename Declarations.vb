Imports System.Data.OleDb

Module Declarations
    Public dbConnection As New OleDbConnection
    Public dbAdapter As New OleDbDataAdapter
    Public dbDataSet As New DataSet

    Public dbDataTable As New DataTable
    Public queryCommand As New OleDbCommand

    'connection declaration
    Public PortName As String
    Public BaudRate, DataBits, ReadTimeout As String
    Public IncorrectPoints, CorrectPoints As Decimal



    Sub ConnectDB()
        dbConnection.ConnectionString = "Provider=SQLNCLI11;Server=(LocalDB)\MSSQLLocalDB;Database=GSS;Trusted_Connection=yes;"
    End Sub

    Sub GetSettings()
        Dim sql As String
        sql = "Select * From Settings"

        dbAdapter = New OleDbDataAdapter(sql, dbConnection)
        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

        DataBits = Trim(CInt(dbDataTable.Rows(0)("DataBits")))
        BaudRate = Trim(CInt(dbDataTable.Rows(0)("PortBaudRate")))
        ReadTimeout = Trim(CInt(dbDataTable.Rows(0)("ReadTimeout")))
        PortName = Trim(dbDataTable.Rows(0)("PortName"))
        IncorrectPoints = Trim(dbDataTable.Rows(0)("IncorrectEquivalent"))
        CorrectPoints = Trim(dbDataTable.Rows(0)("CorrectEquivalent"))
    End Sub

End Module

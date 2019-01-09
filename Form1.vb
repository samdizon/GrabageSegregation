Imports System.Data.OleDb

Public Class Form1
    Dim dbConnection As New OleDbConnection
    Dim dbAdapter As New OleDbDataAdapter
    Dim dbDataSet As New DataSet

    Dim dbDataTable As New DataTable
    Dim queryCommand As New OleDbCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        ShowData("SELECT * FROM Users")

    End Sub

    Private Sub ShowData(dbcommand As String)
        dbAdapter = New OleDbDataAdapter(dbcommand, dbConnection)
        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)
        dgvInfo.DataSource = dbDataTable
        dgvInfo.Columns("Id").Visible = False
    End Sub

    Private Sub ConnectDB()
        dbConnection.ConnectionString = "Provider=SQLNCLI11;Server=(LocalDB)\MSSQLLocalDB;Database=GSS;Trusted_Connection=yes;"
    End Sub

    Private Sub InitializeSetup()

    End Sub




End Class

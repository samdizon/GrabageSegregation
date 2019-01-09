Imports System.Data.OleDb

Public Class Form1
    Dim dbConnection As New OleDbConnection
    Dim dbAdapter As New OleDbDataAdapter
    Dim dbDataSet As New DataSet

    Dim dbDataTable As New DataTable
    Dim queryCommand As New OleDbCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        InitializeSetup()
        'ShowData("SELECT * FROM Users")

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
        CreateDefaultRoles()
        CreateDefaultUsers()

    End Sub

    Private Sub CreateDefaultRoles()
        Try
            'Check roles
            dbAdapter = New OleDbDataAdapter("Select * From Roles", dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)


            'If no roles found
            If (dbDataTable.Rows.Count = 0) Then
                'insert roles
                dbAdapter = New OleDbDataAdapter("INSERT INTO Roles (Name) VALUES ('ADMINISTRATOR'), ('MEMBER')", dbConnection)
                dbAdapter.Fill(dbDataSet)

            End If

        Catch ex As Exception
            MsgBox("A problem is encountered on the System. Please call your system administrator.")
            Me.Dispose()

        End Try
    End Sub

    Private Sub CreateDefaultUsers()
        Dim adminRoleID As Integer

        'look for Administrator ID
        Try
            dbAdapter = New OleDbDataAdapter("Select * From Roles WHERE Name like '%ADMINISTRATOR%'", dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            adminRoleID = dbDataTable.Rows(0).Item(0)

            ''Check users
            dbAdapter = New OleDbDataAdapter("Select * From Users", dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)
            dbDataSet = New DataSet

            ''If no users found
            If (dbDataTable.Rows.Count = 0) Then
                'insert admin
                dbAdapter = New OleDbDataAdapter("INSERT INTO Users (FirstName, LastName, Username, Password, RoleID) VALUES ('System','Administrator', 'admin','admin'," & adminRoleID & ")", dbConnection)
                dbAdapter.Fill(dbDataSet)
                dbDataSet = New DataSet

            End If
        Catch ex As Exception
            MsgBox("A problem is encountered on the System. Please call your system administrator.")
            Me.Dispose()
        End Try
    End Sub


End Class

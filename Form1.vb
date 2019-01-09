Imports System.Data.OleDb


Public Class frmLogin
    Dim dbConnection As New OleDbConnection
    Dim dbAdapter As New OleDbDataAdapter
    Dim dbDataSet As New DataSet

    Dim dbDataTable As New DataTable
    Dim queryCommand As New OleDbCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        InitializeSetup()

    End Sub

    Private Sub ShowData(dbcommand As String)
        dbAdapter = New OleDbDataAdapter(dbcommand, dbConnection)
        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

    End Sub

    Private Sub ConnectDB()
        dbConnection.ConnectionString = "Provider=SQLNCLI11;Server=(LocalDB)\MSSQLLocalDB;Database=GSS;Trusted_Connection=yes;"
    End Sub


    Private Sub InitializeSetup()
        CreateDefaultRoles()
        CreateDefaultUsers()
        FormSetup()
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
            MsgBox("A problem is encountered on the System. Please call your system administrator.", MsgBoxStyle.Critical)
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
            MsgBox("A problem is encountered on the System. Please call your system administrator.", MsgBoxStyle.Critical)
            Me.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub FormSetup()
        txtPassword.PasswordChar = Chr(151)
        Me.AcceptButton = btnLogin
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'check if username and password is provided
        If (Len(Trim(txtUsername.Text)) = 0) Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Exit Sub
        End If

        If (Len(Trim(txtPassword.Text)) = 0) Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If


        Try
            ConnectDB()
            queryCommand = New OleDbCommand("SELECT ID, Username, Password, RoleID FROM Users WHERE Username = @username and Password = @password", dbConnection)
            Dim username As New OleDbParameter("@username", SqlDbType.VarChar)
            Dim password As New OleDbParameter("@password", SqlDbType.VarChar)

            username.Value = txtUsername.Text
            password.Value = txtPassword.Text

            queryCommand.Parameters.Add(username)
            queryCommand.Parameters.Add(password)
            queryCommand.Connection.Open()

            Dim myReader As OleDbDataReader = queryCommand.ExecuteReader(CommandBehavior.CloseConnection)

            Dim Login As Object = 0

            If myReader.HasRows Then
                myReader.Read()
                Login = myReader(Login)

            End If

            If Login = Nothing Then

                MsgBox("Login is Failed...Try again !", MsgBoxStyle.Critical, "Login Denied")
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()

            Else
                MsgBox("Successfully Login", MsgBoxStyle.Information)
                txtUsername.Text = ""
                txtPassword.Text = ""
                Me.Hide()



            End If

            queryCommand.Dispose()
            dbConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

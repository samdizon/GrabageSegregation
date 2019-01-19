
Imports System.Data.OleDb

Public Class frmLogin


    Dim adminRoleID As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        InitializeSetup()

    End Sub

    Private Sub ShowData(dbcommand As String)
        dbAdapter = New OleDbDataAdapter(dbcommand, dbConnection)
        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

    End Sub




    Private Sub InitializeSetup()
        CreateDefaultRoles()
        CreateDefaultUsers()
        CreateDefaultSortingCategories()
        CreateDefaultSettings()
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

    Private Sub CreateDefaultSortingCategories()
        Try
            'Check categories
            dbAdapter = New OleDbDataAdapter("Select * From SortingCategories", dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            'If no categories found
            If (dbDataTable.Rows.Count = 0) Then
                'insert categories
                dbAdapter = New OleDbDataAdapter("INSERT INTO SortingCategories (Name) VALUES ('PAPER'), ('METAL'), ('PLASTIC')", dbConnection)
                dbAdapter.Fill(dbDataSet)

            End If

        Catch ex As Exception
            MsgBox("A problem is encountered on the System. Please call your system administrator.", MsgBoxStyle.Critical)
            Me.Dispose()

        End Try
    End Sub


    Private Sub CreateDefaultSettings()

        Try
            'Check preferences
            dbAdapter = New OleDbDataAdapter("Select * From Settings", dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            'If no settings found
            If (dbDataTable.Rows.Count = 0) Then
                'insert settings
                dbAdapter = New OleDbDataAdapter("INSERT INTO Settings (PortName, DataBits, PortBaudRate, ReadTimeout) 
                                                         VALUES ((''), ('8'), (9600), (10000))", dbConnection)
                dbAdapter.Fill(dbDataSet)

            End If

        Catch ex As Exception
            MsgBox("A problem is encountered on the System. Please call your system administrator.", MsgBoxStyle.Critical)
            Me.Dispose()

        End Try
    End Sub

    Private Sub CreateDefaultUsers()


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
        frmStudentsPortal.Show()
        Me.Hide()
    End Sub

    Private Sub FormSetup()
        txtPassword.PasswordChar = Chr(151)
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
            Dim username, password As String
            username = Trim(txtUsername.Text)
            password = Trim(txtPassword.Text)

            dbAdapter = New OleDbDataAdapter("Select * From Users WHERE CONVERT(VARCHAR, username) = '" & username & "' and CONVERT(VARCHAR, Password) = '" & password & "' COLLATE SQL_Latin1_General_CP1_CS_AS", dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            'if user is not found
            If (dbDataTable.Rows.Count = 0) Then
                MsgBox("Invalid username and/or password. Please try again.", MsgBoxStyle.Critical, "Login Denied")
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()
            Else
                txtUsername.Text = ""
                txtPassword.Text = ""
                Me.Hide()
                dbConnection.Close()



                Dim mainForm As New fmMain()
                Dim userRecordIndex, userRoleID As Integer

                Dim userRoleRecordIndex As Integer
                Dim userRole As String

                userRecordIndex = dbDataTable.Columns("ID").Ordinal
                mainForm.LoginUserID = dbDataTable.Rows(0).ItemArray(userRecordIndex).ToString

                userRecordIndex = dbDataTable.Columns("Username").Ordinal
                mainForm.lblUsername.Text = Trim("Hi, " + dbDataTable.Rows(0).ItemArray(userRecordIndex).ToString)

                userRecordIndex = dbDataTable.Columns("RoleID").Ordinal
                userRoleID = dbDataTable.Rows(0).ItemArray(userRecordIndex).ToString

                userRecordIndex = dbDataTable.Columns("FirstName").Ordinal
                mainForm.LoginFirstName = Trim(dbDataTable.Rows(0).ItemArray(userRecordIndex).ToString)

                userRecordIndex = dbDataTable.Columns("MiddleName").Ordinal
                mainForm.LoginMidleName = Trim(dbDataTable.Rows(0).ItemArray(userRecordIndex).ToString)

                userRecordIndex = dbDataTable.Columns("LastName").Ordinal
                mainForm.LoginLastName = Trim(dbDataTable.Rows(0).ItemArray(userRecordIndex).ToString)

                userRecordIndex = dbDataTable.Columns("Username").Ordinal
                mainForm.LoginUsername = Trim(dbDataTable.Rows(0).ItemArray(userRecordIndex).ToString)

                userRecordIndex = dbDataTable.Columns("Password").Ordinal
                mainForm.LoginPassword = Trim(dbDataTable.Rows(0).ItemArray(userRecordIndex).ToString)

                'check role
                dbAdapter = New OleDbDataAdapter("Select * 
                                                    From Roles 
                                                    WHERE ID = " & userRoleID & " ", dbConnection)
                dbDataTable = New DataTable
                dbAdapter.Fill(dbDataTable)

                userRoleRecordIndex = dbDataTable.Columns("Name").Ordinal
                userRole = Trim(dbDataTable.Rows(0).ItemArray(userRoleRecordIndex).ToString)
                mainForm.LoginRoleName = userRole
                If userRole = "MEMBER" Then
                    mainForm.lblRegisterUsers.Visible = False
                    mainForm.btnEditUser.Visible = False
                    mainForm.btnDeleteUser.Visible = False
                Else
                    mainForm.lblRegisterUsers.Visible = True
                    mainForm.btnDeleteUser.Visible = True
                End If

                mainForm.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

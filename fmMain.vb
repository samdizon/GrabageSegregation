Imports System.Data.OleDb


Public Class fmMain
    Public IncorrectPaper, IncorrectMetal, IncorrectPlastic, CorrectPaper, CorrectMetal, CorrectPlastic, TotalPaper, TotalPlastic, TotalMetal As Integer
    Public LoginUserID As Integer

    Private Sub fmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtSearchStudents.Select()
        ConnectDB()

        'gbRegisterStudents.Visible = False

        Try
            dbAdapter = New OleDbDataAdapter("Select * From Students", dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)
            dgvStudents.DataSource = dbDataTable
            dgvStudents.Columns("ID").Visible = False
            dgvStudents.Columns("FingerPrintID").Visible = False
            dgvStudents.Columns("StudentNumber").HeaderText = "Student no."
            dgvStudents.Columns("FirstName").HeaderText = "First name"
            dgvStudents.Columns("MiddleName").HeaderText = "Middle name"
            dgvStudents.Columns("LastName").HeaderText = "Last name"
            dgvStudents.Columns("CourseCode").HeaderText = "Course"
            dgvStudents.Columns("Year").Width = 70
            dgvStudents.Columns("Section").Width = 70
            dgvStudents.Columns("CourseCode").Width = 150
            dgvStudents.Columns("StudentNumber").Width = 145





            lblTotalIncorrect.Text = GetAllIncorrectSorting().ToString
            lblTotalCorrect.Text = GetAllCorrectSorting().ToString
            lblTotal.Text = CInt(GetAllIncorrectSorting().ToString) + CInt(GetAllCorrectSorting().ToString)


            GetCorrectSortingByCategories()
            GetInCorrectSortingCategories()
            GetTotalSorting()

            AssignSortingResultsToLabels()

        Catch ex As Exception
            MsgBox("A problem is encountered on the System. Please call your system administrator.", MsgBoxStyle.Critical)
            Me.Dispose()
        End Try

    End Sub

    Function GetAllIncorrectSorting()
        Dim TotalIncorrect As Integer

        Try
            Dim Sql = "Select Count(WasteSorting.Result)
                    From WasteSorting
                    Where WasteSorting.Result = 0"


            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            TotalIncorrect = dbDataTable.Rows(0)(0).ToString
        Catch ex As Exception
            TotalIncorrect = 0
        End Try

        Return TotalIncorrect

    End Function

    Function GetAllCorrectSorting()
        Dim TotalCorrect As Integer

        Try
            Dim Sql = "Select Count(WasteSorting.Result)
                    From WasteSorting
                    Where WasteSorting.Result = 1"


            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            TotalCorrect = dbDataTable.Rows(0)(0).ToString
        Catch ex As Exception
            TotalCorrect = 0
        End Try

        Return TotalCorrect

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub lblLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLogout.LinkClicked
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub txtSearchStudents_TextChanged(sender As Object, e As EventArgs)
        Me.AcceptButton = btnSearch
    End Sub

    Private Sub ShowAllStudents()
        Dim sql = "select * from Students "
        dbAdapter = New OleDbDataAdapter(sql, dbConnection)
        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

        dgvStudents.DataSource = dbDataTable
        txtSearchStudents.Select()

    End Sub

    Private Sub ShowAllUsers()
        Dim sql = "SELECT 
                    Roles.Name,
	                Users.*
                    From Users INNER JOIN Roles ON Users.RoleID = Roles.ID"
        dbAdapter = New OleDbDataAdapter(sql, dbConnection)
        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

        dgvUsers.DataSource = dbDataTable
        txtSearchUsers.Select()

    End Sub

    Private Sub GetAllSortingResult()
        Dim sql = "select * from WasteSorting"
        dbAdapter = New OleDbDataAdapter(sql, dbConnection)
        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim Sql = "Select * From Students where ((StudentNumber like '%" & txtSearchStudents.Text & "%') or (FirstName like '%" & txtSearchStudents.Text & "%') or (MiddleName like '%" & txtSearchStudents.Text & "%') or (LastName like '%" & txtSearchStudents.Text & "%') or (Year like '%" & txtSearchStudents.Text & "%') or (Section like '%" & txtSearchStudents.Text & "%') or (CourseCode like '%" & txtSearchStudents.Text & "%'))"

            btnEditStudent.Enabled = False
            btnDeleteStudent.Enabled = False

            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            If dbDataTable.Rows.Count = 0 Then
                MsgBox("No student found.", MsgBoxStyle.Information)
                ShowAllStudents()
                lblTotalIncorrect.Text = GetAllIncorrectSorting().ToString
                lblTotalCorrect.Text = GetAllCorrectSorting().ToString
                lblTotal.Text = CInt(GetAllIncorrectSorting().ToString) + CInt(GetAllCorrectSorting().ToString)

                GetCorrectSortingByCategories()
                GetInCorrectSortingCategories()
                GetTotalSorting()

                AssignSortingResultsToLabels()

            Else

                dgvStudents.DataSource = dbDataTable
            End If



        Catch ex As Exception
            MsgBox("A problem is encountered. Please contact your system administrator", MsgBoxStyle.Critical)
        End Try
    End Sub


    Function GetIncorrectSortingByID(StudentID As Integer)

        Dim TotalIncorrect As Integer

        Try
            Dim Sql = "Select Count(WasteSorting.Result)
                    From WasteSorting
                    Where WasteSorting.Result = 0 and WasteSorting.StudentID = " & StudentID & " "


            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            TotalIncorrect = dbDataTable.Rows(0)(0).ToString
        Catch ex As Exception
            TotalIncorrect = 0
        End Try

        Return TotalIncorrect

    End Function

    Function GetCorrectSortingByID(StudentID As Integer)

        Dim TotalCorrect As Integer

        Try
            Dim Sql = "Select Count(WasteSorting.Result)
                    From WasteSorting
                    Where WasteSorting.Result = 1 and WasteSorting.StudentID = " & StudentID & " "


            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            TotalCorrect = dbDataTable.Rows(0)(0).ToString
        Catch ex As Exception
            TotalCorrect = 0
        End Try

        Return TotalCorrect

    End Function

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblBrowseStudents.LinkClicked
        gbEditStudents.Hide()
        gbRegisterStudents.Hide()
        gbBrowseSortedWaste.Hide()
        gbBrowseUsers.Hide()
        gbRegisterUser.Hide()
        gbBrowseStudents.Show()
        txtSearchStudents.Select()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegisterStudents.LinkClicked
        txtStudentNumber.Select()
        gbRegisterStudents.Visible = True
        Me.AcceptButton = btnRegisterStudent
        gbBrowseStudents.Hide()
        gbEditStudents.Hide()
        gbBrowseUsers.Hide()
        gbRegisterUser.Hide()
        gbEditUser.Hide()
        gbEditUser.Hide()
        gbBrowseSortedWaste.Hide()
    End Sub

    Private Sub lblRegisterFingerPrint_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegisterFingerPrint.LinkClicked
        'send signal to finger print

        frmFingerprintRegistration.Show()
        'data is lost on main form, need to transfer data to form
        frmFingerprintRegistration.StudentNumber = txtStudentNumber.Text
        frmFingerprintRegistration.FirstName = txtStudentFirstname.Text
        frmFingerprintRegistration.MiddleName = txtStudentMiddlename.Text
        frmFingerprintRegistration.LastName = txtStudentLastname.Text
        frmFingerprintRegistration.CourseCode = txtStudentCourse.Text
        frmFingerprintRegistration.Year = txtStudentYear.Text
        frmFingerprintRegistration.Section = txtStudentSection.Text

        Me.Hide()
    End Sub

    Private Sub btnRegisterStudent_Click(sender As Object, e As EventArgs) Handles btnRegisterStudent.Click
        Dim StudentNumber, FirstName, MiddleName, LastName, CourseCode, Year, Section As String
        Dim FingerPrintID As Integer

        StudentNumber = Trim(txtStudentNumber.Text)
        FirstName = Trim(txtStudentFirstname.Text)
        MiddleName = Trim(txtStudentMiddlename.Text)
        LastName = Trim(txtStudentLastname.Text)
        CourseCode = Trim(txtStudentCourse.Text)
        Year = Trim(txtStudentYear.Text)
        Section = Trim(txtStudentSection.Text)


        If StudentNumber = "" Then
            MsgBox("Please provide student number.", MsgBoxStyle.Exclamation)
            txtStudentNumber.Select()
        ElseIf FirstName = "" Then
            MsgBox("Please provide first name.", MsgBoxStyle.Exclamation)
            txtStudentFirstname.Select()
        ElseIf LastName = "" Then
            MsgBox("Please provide last name.", MsgBoxStyle.Exclamation)
            txtStudentLastname.Select()
        ElseIf CourseCode = "" Then
            MsgBox("Please provide student course code", MsgBoxStyle.Exclamation)
            txtStudentCourse.Select()
        ElseIf txtboxFingerprintID.Text = "" Then
            MsgBox("Please register student finger print.", MsgBoxStyle.Exclamation)
            lblRegisterFingerPrint.Select()
        End If
        If txtboxFingerprintID.Text <> "" Then
            FingerPrintID = CInt(txtboxFingerprintID.Text)
        End If

        If StudentNumber <> "" And FirstName <> "" And LastName <> "" And CourseCode <> "" And FingerPrintID <> 0 Then
            Try
                dbAdapter = New OleDbDataAdapter("INSERT INTO Students (StudentNumber, FirstName, MiddleName, LastName, FingerPrintID, Year, Section, CourseCode)
                                                VALUES ('" & StudentNumber & "','" & FirstName & "','" & MiddleName & "','" & LastName & "'," & FingerPrintID & ",'" & Year & "','" & Section & "','" & CourseCode & "')", dbConnection)
                dbDataSet = New DataSet
                dbAdapter.Fill(dbDataSet)

                MsgBox("New student registered.", MsgBoxStyle.Information, "Registration")
                ShowAllStudents()
                ClearRegistrationTextbox()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try

        End If


    End Sub

    Private Sub ClearRegistrationTextbox()
        txtStudentNumber.Text = ""
        txtStudentFirstname.Text = ""
        txtStudentMiddlename.Text = ""
        txtStudentLastname.Text = ""
        txtStudentCourse.Text = ""
        txtStudentYear.Text = ""
        txtStudentSection.Text = ""
        txtboxFingerprintID.Text = ""
    End Sub
    Private Sub ClearUserRegistrationTextbox()
        txtRegisterUserFirstname.Text = ""
        txtRegisterUserMiddleName.Text = ""
        txtRegisterUserLastName.Text = ""
        txtRegisterUserUsername.Text = ""
        txtRegisterUserPassword.Text = ""
    End Sub

    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        Dim i, StudentIDIndex As Integer
        Dim StudentID As String

        Try
            i = dgvStudents.CurrentRow.Index
            StudentIDIndex = dgvStudents.Columns("ID").Index
            StudentID = dgvStudents.Item(StudentIDIndex, i).Value.ToString

            lblTotalIncorrect.Text = GetIncorrectSortingByID(StudentID)
            lblTotalCorrect.Text = GetCorrectSortingByID(CInt(StudentID))
            lblTotal.Text = CInt(lblTotalIncorrect.Text) + CInt(lblTotalCorrect.Text)

            GetCorrectSortingCategoriesByID(StudentID)
            GetInCorrectSortingCategoriesByID(StudentID)
            GetTotalSorting()

            AssignSortingResultsToLabels()
            btnEditStudent.Enabled = True
            btnDeleteStudent.Enabled = True
        Catch ex As Exception
            btnEditStudent.Enabled = False
            btnDeleteStudent.Enabled = False
        End Try

    End Sub

    Private Sub txtSearchStudents_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearchStudents.TextChanged
        Me.AcceptButton = btnSearch
    End Sub


    Private Sub GetCorrectSortingByCategories()
        Dim Rows() As DataRow
        Try
            Dim Sql = "SELECT Count(WasteSorting.Result) as Result, SortingCategories.Name
                        FROM WasteSorting INNER JOIN SortingCategories ON WasteSorting.SortingCategoryID = SortingCategories.ID
                        GROUP BY SortingCategories.Name, WasteSorting.Result
                        HAVING (((WasteSorting.Result)=1))"


            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            If dbDataTable.Rows.Count = 0 Then
                CorrectMetal = 0
                CorrectPaper = 0
                CorrectPlastic = 0
            Else
                Try
                    Rows = dbDataTable.Select("Name = 'PAPER'")
                    CorrectPaper = Rows(0).Item("Result")
                Catch ex As Exception
                    CorrectPaper = 0
                End Try

                Try
                    Rows = dbDataTable.Select("Name = 'METAL'")
                    CorrectMetal = Rows(0).Item("Result")
                Catch ex As Exception
                    CorrectMetal = 0
                End Try

                Try
                    Rows = dbDataTable.Select("Name = 'PLASTIC'")
                    CorrectPlastic = Rows(0).Item("Result")
                Catch ex As Exception
                    CorrectPlastic = 0
                End Try

            End If
        Catch ex As Exception
            MsgBox("A problem is encountered, please contact your system administrator", MsgBoxStyle.Critical)
            CorrectMetal = 0
            CorrectPaper = 0
            CorrectPlastic = 0
        End Try

    End Sub

    Private Sub GetCorrectSortingCategoriesByID(StudentID As String)
        Dim Rows() As DataRow
        Try
            Dim Sql = "SELECT Count(WasteSorting.Result) as Result, SortingCategories.Name
                        FROM WasteSorting INNER JOIN SortingCategories ON WasteSorting.SortingCategoryID = SortingCategories.ID
                        GROUP BY SortingCategories.Name, WasteSorting.Result, WasteSorting.StudentID
                        HAVING (((WasteSorting.Result)=1) and (WasteSorting.StudentID = " & StudentID & "));"


            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            If dbDataTable.Rows.Count = 0 Then
                CorrectMetal = 0
                CorrectPaper = 0
                CorrectPlastic = 0

            Else
                Try
                    Rows = dbDataTable.Select("Name = 'PAPER'")
                    CorrectPaper = Rows(0).Item("Result")
                Catch ex As Exception
                    CorrectPaper = 0
                End Try

                Try
                    Rows = dbDataTable.Select("Name = 'METAL'")
                    CorrectMetal = Rows(0).Item("Result")
                Catch ex As Exception
                    CorrectMetal = 0
                End Try

                Try
                    Rows = dbDataTable.Select("Name = 'PLASTIC'")
                    CorrectPlastic = Rows(0).Item("Result")
                Catch ex As Exception
                    CorrectPlastic = 0
                End Try

            End If
        Catch ex As Exception
            MsgBox("A problem is encountered, please contact your system administrator", MsgBoxStyle.Critical)
            CorrectMetal = 0
            CorrectPaper = 0
            CorrectPlastic = 0
        End Try

    End Sub

    Private Sub GetInCorrectSortingCategories()
        Dim Rows() As DataRow
        Try
            Dim Sql = "SELECT Count(WasteSorting.Result) as Result, SortingCategories.Name
                        FROM WasteSorting INNER JOIN SortingCategories ON WasteSorting.SortingCategoryID = SortingCategories.ID
                        GROUP BY SortingCategories.Name, WasteSorting.Result
                        HAVING (((WasteSorting.Result)=0))"


            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            If dbDataTable.Rows.Count = 0 Then
                IncorrectMetal = 0
                IncorrectPaper = 0
                IncorrectPlastic = 0

            Else
                Try
                    Rows = dbDataTable.Select("Name = 'PAPER'")
                    IncorrectPaper = Rows(0).Item("Result")
                Catch ex As Exception
                    IncorrectPaper = 0
                End Try

                Try
                    Rows = dbDataTable.Select("Name = 'METAL'")
                    IncorrectMetal = Rows(0).Item("Result")
                Catch ex As Exception
                    IncorrectMetal = 0
                End Try

                Try
                    Rows = dbDataTable.Select("Name = 'PLASTIC'")
                    IncorrectPlastic = Rows(0).Item("Result")
                Catch ex As Exception
                    IncorrectPlastic = 0
                End Try

            End If
        Catch ex As Exception
            MsgBox("A problem is encountered, please contact your system administrator", MsgBoxStyle.Critical)
            IncorrectMetal = 0
            IncorrectPaper = 0
            IncorrectPlastic = 0
        End Try

    End Sub

    Private Sub GetInCorrectSortingCategoriesByID(StudentID As String)
        Dim Rows() As DataRow
        Try
            Dim Sql = "SELECT Count(WasteSorting.Result) as Result, SortingCategories.Name
                        FROM WasteSorting INNER JOIN SortingCategories ON WasteSorting.SortingCategoryID = SortingCategories.ID
                        GROUP BY SortingCategories.Name, WasteSorting.Result, WasteSorting.StudentID
                        HAVING (((WasteSorting.Result)=0) and (WasteSorting.StudentID = " & StudentID & "));"


            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            If dbDataTable.Rows.Count = 0 Then
                IncorrectMetal = 0
                IncorrectPaper = 0
                IncorrectPlastic = 0

            Else
                Try
                    Rows = dbDataTable.Select("Name = 'PAPER'")
                    IncorrectPaper = Rows(0).Item("Result")
                Catch ex As Exception
                    IncorrectPaper = 0
                End Try

                Try
                    Rows = dbDataTable.Select("Name = 'METAL'")
                    IncorrectMetal = Rows(0).Item("Result")
                Catch ex As Exception
                    IncorrectMetal = 0
                End Try

                Try
                    Rows = dbDataTable.Select("Name = 'PLASTIC'")
                    IncorrectPlastic = Rows(0).Item("Result")
                Catch ex As Exception
                    IncorrectPlastic = 0
                End Try

            End If
        Catch ex As Exception
            MsgBox("A problem is encountered, please contact your system administrator", MsgBoxStyle.Critical)
            IncorrectMetal = 0
            IncorrectPaper = 0
            IncorrectPlastic = 0
        End Try

    End Sub

    Private Sub GetTotalSorting()
        TotalMetal = IncorrectMetal + CorrectMetal
        TotalPaper = IncorrectPaper + CorrectPaper
        TotalPlastic = IncorrectPlastic + CorrectPlastic
    End Sub

    Private Sub AssignSortingResultsToLabels()

        lblCorrectPaper.Text = CorrectPaper.ToString
        lblCorrectPlastic.Text = CorrectPlastic.ToString
        lblCorrectMetal.Text = CorrectMetal.ToString


        lblIncorrectPaper.Text = IncorrectPaper.ToString
        lblIncorrectPlastic.Text = IncorrectPlastic.ToString
        lblIncorrectMetal.Text = IncorrectMetal.ToString


        lblTotalMetal.Text = TotalMetal
        lblTotalPaper.Text = TotalPaper
        lblTotalPlastic.Text = TotalPlastic
    End Sub


    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        Dim confirmDelete As MsgBoxResult
        Dim StudendID As String
        Dim i, StudentIDIndex As Integer

        i = dgvStudents.CurrentRow.Index

        confirmDelete = MsgBox("Deleting student record removes all waste sorting records. Please confirm to proceed", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Delete student")

        If confirmDelete.ToString = "Yes" Then
            StudentIDIndex = dgvStudents.Columns("ID").Index
            StudendID = dgvStudents.Item(StudentIDIndex, i).Value.ToString
            Try
                dbAdapter = New OleDbDataAdapter("DELETE FROM WasteSorting where StudentID = " & CInt(StudendID) & " ", dbConnection)
                dbDataSet = New DataSet
                dbAdapter.Fill(dbDataSet)

                dbAdapter = New OleDbDataAdapter("DELETE FROM Students where ID = " & CInt(StudendID) & " ", dbConnection)
                dbDataSet = New DataSet
                dbAdapter.Fill(dbDataSet)


                MsgBox("Student record deleted.", MsgBoxStyle.Information, "Registration")
                ShowAllStudents()

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try

        End If


    End Sub

    Private Sub btnEditStudent_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
        Dim i, StudentRecordIndex As Integer

        i = dgvStudents.CurrentRow.Index

        StudentRecordIndex = dgvStudents.Columns("ID").Index
        lblEditStudentID.Text = Trim(dgvStudents.Item(StudentRecordIndex, i).Value.ToString)

        StudentRecordIndex = dgvStudents.Columns("StudentNumber").Index
        txtEditStudentNumber.Text = Trim(dgvStudents.Item(StudentRecordIndex, i).Value.ToString)

        StudentRecordIndex = dgvStudents.Columns("FirstName").Index
        txtEditStudentFirstName.Text = Trim(dgvStudents.Item(StudentRecordIndex, i).Value.ToString)

        StudentRecordIndex = dgvStudents.Columns("MiddleName").Index
        txtEditStudentMiddleName.Text = Trim(dgvStudents.Item(StudentRecordIndex, i).Value.ToString)

        StudentRecordIndex = dgvStudents.Columns("LastName").Index
        txtEditStudentLastName.Text = Trim(dgvStudents.Item(StudentRecordIndex, i).Value.ToString)

        StudentRecordIndex = dgvStudents.Columns("CourseCode").Index
        txtEditStudentCourse.Text = Trim(dgvStudents.Item(StudentRecordIndex, i).Value.ToString)

        StudentRecordIndex = dgvStudents.Columns("Year").Index
        txtEditStudentYear.Text = Trim(dgvStudents.Item(StudentRecordIndex, i).Value.ToString)

        StudentRecordIndex = dgvStudents.Columns("Section").Index
        txtEditStudentSection.Text = Trim(dgvStudents.Item(StudentRecordIndex, i).Value.ToString)

        StudentRecordIndex = dgvStudents.Columns("FingerprintID").Index
        txtEditStudentFingerPrint.Text = Trim(dgvStudents.Item(StudentRecordIndex, i).Value.ToString)

        gbBrowseStudents.Hide()
        gbRegisterStudents.Hide()
        gbBrowseSortedWaste.Hide()
        gbBrowseUsers.Hide()
        gbEditUser.Hide()
        gbRegisterUser.Hide()
        gbEditStudents.Show()

    End Sub

    Private Sub btnUpdateStudent_Click(sender As Object, e As EventArgs) Handles btnUpdateStudent.Click
        Dim StudentNumber, FirstName, MiddleName, LastName, CourseCode, Year, Section As String
        Dim StudentID As Integer

        StudentNumber = Trim(txtEditStudentNumber.Text)
        FirstName = Trim(txtEditStudentFirstName.Text)
        MiddleName = Trim(txtEditStudentMiddleName.Text)
        LastName = Trim(txtEditStudentLastName.Text)
        CourseCode = Trim(txtEditStudentCourse.Text)
        Year = Trim(txtEditStudentYear.Text)
        Section = Trim(txtEditStudentSection.Text)
        StudentID = CInt(lblEditStudentID.Text)

        If StudentNumber = "" Then
            MsgBox("Please provide student number.", MsgBoxStyle.Exclamation)
            txtEditStudentNumber.Select()
        ElseIf FirstName = "" Then
            MsgBox("Please provide first name.", MsgBoxStyle.Exclamation)
            txtEditStudentFirstName.Select()
        ElseIf LastName = "" Then
            MsgBox("Please provide last name.", MsgBoxStyle.Exclamation)
            txtEditStudentLastName.Select()
        ElseIf CourseCode = "" Then
            MsgBox("Please provide student course code", MsgBoxStyle.Exclamation)
            txtEditStudentCourse.Select()
        End If

        If StudentNumber <> "" And FirstName <> "" And LastName <> "" And CourseCode <> "" Then
            Try
                dbAdapter = New OleDbDataAdapter("UPDATE Students 
                                                    SET StudentNumber = '" & StudentNumber & "', FirstName = '" & FirstName & "', MiddleName = '" & MiddleName & "', LastName = '" & LastName & "', Year ='" & Year & "', Section ='" & Section & "', CourseCode ='" & CourseCode & "'
                                                    WHERE ID = " & StudentID & "", dbConnection)
                dbDataSet = New DataSet
                dbAdapter.Fill(dbDataSet)

                MsgBox("Student record updated.", MsgBoxStyle.Information, "Registration")
                ShowAllStudents()
                ClearRegistrationTextbox()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

    Private Sub txtStudentNumber_LostFocus(sender As Object, e As EventArgs) Handles txtStudentNumber.LostFocus
        txtStudentNumber.Text = txtStudentNumber.Text.ToUpper
    End Sub

    Private Sub txtStudentCourse_LostFocus(sender As Object, e As EventArgs) Handles txtStudentCourse.LostFocus
        txtStudentCourse.Text = txtStudentCourse.Text.ToUpper
    End Sub

    Private Sub txtStudentYear_LostFocus(sender As Object, e As EventArgs) Handles txtStudentYear.LostFocus
        txtStudentYear.Text = txtStudentYear.Text.ToUpper
    End Sub

    Private Sub txtStudentSection_LostFocus(sender As Object, e As EventArgs) Handles txtStudentSection.LostFocus
        txtStudentSection.Text = txtStudentSection.Text.ToUpper
    End Sub

    Private Sub txtStudentNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentNumber.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtStudentCourse_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentCourse.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtStudentYear_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentYear.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtStudentSection_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentSection.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub



    Private Sub txtEditStudentNumber_LostFocus(sender As Object, e As EventArgs) Handles txtEditStudentNumber.LostFocus
        txtEditStudentNumber.Text = txtEditStudentNumber.Text.ToUpper
    End Sub

    Private Sub txtEditStudentCourse_LostFocus(sender As Object, e As EventArgs) Handles txtEditStudentCourse.LostFocus
        txtEditStudentCourse.Text = txtEditStudentCourse.Text.ToUpper
    End Sub

    Private Sub dgvBrowseSortedWaste_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrowseSortedWaste.CellContentClick

    End Sub

    Private Sub txtEditStudentYear_LostFocus(sender As Object, e As EventArgs) Handles txtEditStudentYear.LostFocus
        txtEditStudentYear.Text = txtEditStudentYear.Text.ToUpper
    End Sub

    Private Sub btnDeleteSorting_Click(sender As Object, e As EventArgs) Handles btnDeleteSorting.Click
        Dim i, SortingWasteIndex, SortingWasteID As Integer
        Dim confirmDelete As MsgBoxResult

        confirmDelete = MsgBox("Are you sure you want to remove this record?", MsgBoxStyle.YesNo)

        If confirmDelete.ToString = "Yes" Then
            Try
                i = dgvBrowseSortedWaste.CurrentRow.Index

                SortingWasteIndex = dgvBrowseSortedWaste.Columns("ID").Index
                SortingWasteID = Trim(dgvBrowseSortedWaste.Item(SortingWasteIndex, i).Value.ToString)

                dbAdapter = New OleDbDataAdapter("DELETE FROM WasteSorting WHERE ID = " & SortingWasteID & "  ", dbConnection)
                dbDataTable = New DataTable
                dbAdapter.Fill(dbDataTable)
                MsgBox("Sorting result deleted.", MsgBoxStyle.Information)

                GetSortedWasteByStudentID(CInt(lblEditStudentID.Text))

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

    Private Sub btnUpdateSorting_Click(sender As Object, e As EventArgs) Handles btnUpdateSorting.Click
        Dim i, SortingWasteIndex, SortingWasteID, SortingCategoryID, Result As Integer

        SortingCategoryID = comboCategory.SelectedValue
        If comboSortingResult.SelectedItem = "CORRECT" Then
            Result = 1
        Else
            Result = 0
        End If

        Try
            i = dgvBrowseSortedWaste.CurrentRow.Index

            SortingWasteIndex = dgvBrowseSortedWaste.Columns("ID").Index
            SortingWasteID = Trim(dgvBrowseSortedWaste.Item(SortingWasteIndex, i).Value.ToString)


            dbAdapter = New OleDbDataAdapter("UPDATE WasteSorting SET SortingCategoryID = " & SortingCategoryID & " , Result = " & Result & " WHERE ID = " & SortingWasteID & "  ", dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)
            MsgBox("Sorting result updated.", MsgBoxStyle.Information)

            GetSortedWasteByStudentID(CInt(lblEditStudentID.Text))
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub lblSettings_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSettings.LinkClicked
        frmSettings.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        gbRegisterStudents.Hide()
        gbEditStudents.Hide()
        gbBrowseStudents.Hide()
        gbBrowseSortedWaste.Hide()
        gbEditUser.Hide()
        gbRegisterUser.Hide()
        gbBrowseUsers.Show()

        Try
            ShowAllUsers()

            dgvUsers.Columns("ID").Visible = False
            dgvUsers.Columns("Password").Visible = False
            dgvUsers.Columns("RoleID").Visible = False
            dgvUsers.Columns("Name").HeaderText = "Role"
            dgvUsers.Columns("FirstName").HeaderText = "First name"
            dgvUsers.Columns("MiddleName").HeaderText = "Middle name"
            dgvUsers.Columns("LastName").HeaderText = "Last name"
            dgvUsers.Columns("FirstName").Width = 150
            dgvUsers.Columns("MiddleName").Width = 130
            dgvUsers.Columns("LastName").Width = 150
            dgvUsers.Columns("Name").Width = 150
            dgvUsers.Columns("Username").Width = 150

            txtSearchUsers.Select()
            Me.AcceptButton = btnSearchUser
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try



    End Sub

    Private Sub btnSearchUser_Click(sender As Object, e As EventArgs) Handles btnSearchUser.Click
        Try
            Dim Sql = "Select 
                            Roles.Name,
	                        Users.*
                            From Users INNER JOIN Roles ON Users.RoleID = Roles.ID 
                            WHERE (
                                    (FirstName like '%" & txtSearchUsers.Text & "%') or 
                                    (MiddleName like '%" & txtSearchUsers.Text & "%') or 
                                    (LastName like '%" & txtSearchUsers.Text & "%') or 
                                    (Username like '%" & txtSearchUsers.Text & "%')
                                  )"

            btnEditUser.Enabled = False
            btnDeleteUser.Enabled = False

            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            If dbDataTable.Rows.Count = 0 Then
                MsgBox("No user found.", MsgBoxStyle.Information)
                ShowAllUsers()
            Else
                dgvUsers.DataSource = dbDataTable
            End If



        Catch ex As Exception
            MsgBox("A problem is encountered. Please contact your system administrator", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick

    End Sub

    Private Sub txtEditStudentSection_LostFocus(sender As Object, e As EventArgs) Handles txtEditStudentSection.LostFocus
        txtEditStudentSection.Text = txtEditStudentSection.Text.ToUpper
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        gbBrowseSortedWaste.Hide()
        gbBrowseStudents.Hide()
        gbBrowseUsers.Hide()
        gbEditStudents.Hide()
        gbRegisterStudents.Hide()
        gbRegisterUser.Hide()


        gbEditUser.Show()
        dbAdapter = New OleDbDataAdapter("Select * from Roles", dbConnection)

        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

        Dim bindingSource As New BindingSource

        bindingSource.DataSource = dbDataTable
        comboEditUser.DataSource = bindingSource
        comboEditUser.DisplayMember = "Name"
        comboEditUser.ValueMember = "ID"

        Dim i, UserRecordIndex As Integer

        i = dgvUsers.CurrentRow.Index

        UserRecordIndex = dgvUsers.Columns("ID").Index
        lblEditUserID.Text = Trim(dgvUsers.Item(UserRecordIndex, i).Value.ToString)

        UserRecordIndex = dgvUsers.Columns("FirstName").Index
        txtEditUserFirstName.Text = Trim(dgvUsers.Item(UserRecordIndex, i).Value.ToString)

        UserRecordIndex = dgvUsers.Columns("MiddleName").Index
        txtEditUserMiddleName.Text = Trim(dgvUsers.Item(UserRecordIndex, i).Value.ToString)

        UserRecordIndex = dgvUsers.Columns("LastName").Index
        txtEditUserLastName.Text = Trim(dgvUsers.Item(UserRecordIndex, i).Value.ToString)

        UserRecordIndex = dgvUsers.Columns("Username").Index
        txtEditUserUsername.Text = Trim(dgvUsers.Item(UserRecordIndex, i).Value.ToString)

        UserRecordIndex = dgvUsers.Columns("Password").Index
        txtEditUserPassword.Text = Trim(dgvUsers.Item(UserRecordIndex, i).Value.ToString)

        UserRecordIndex = dgvUsers.Columns("RoleID").Index
        comboEditUser.SelectedValue = Trim(dgvUsers.Item(UserRecordIndex, i).Value.ToString)
        comboRoles.Select()


    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim confirmDelete As MsgBoxResult
        Dim UserID As Integer
        Dim i, UserIDIndex As Integer

        i = dgvUsers.CurrentRow.Index

        confirmDelete = MsgBox("Deleting user record removes data permanently. Please confirm to proceed", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Delete user")

        If confirmDelete.ToString = "Yes" Then
            UserIDIndex = dgvUsers.Columns("ID").Index
            UserID = dgvUsers.Item(UserIDIndex, i).Value.ToString
            Try
                dbAdapter = New OleDbDataAdapter("DELETE FROM Users where ID = " & CInt(UserID) & " ", dbConnection)
                dbDataSet = New DataSet
                dbAdapter.Fill(dbDataSet)

                MsgBox("User record deleted.", MsgBoxStyle.Information, "Registration")
                ShowAllUsers()

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

    Private Sub txtEditStudentNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditStudentNumber.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGeneratePassword.Click
        txtRegisterUserPassword.Text = GeneratePassword()
    End Sub

    Private Sub txtRegisterUserPassword_TextChanged(sender As Object, e As EventArgs) Handles txtRegisterUserPassword.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        gbBrowseStudents.Hide()
        gbBrowseUsers.Hide()
        gbEditStudents.Hide()
        gbEditUser.Hide()
        gbRegisterStudents.Hide()
        gbRegisterUser.Show()
        dbAdapter = New OleDbDataAdapter("Select * from Roles", dbConnection)

        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

        Dim bindingSource As New BindingSource

        bindingSource.DataSource = dbDataTable
        comboRoles.DataSource = bindingSource
        comboRoles.DisplayMember = "Name"
        comboRoles.ValueMember = "ID"

        comboRoles.Select()
    End Sub

    Private Sub txtEditStudentCourse_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditStudentCourse.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        txtEditUserPassword.Text = GeneratePassword()
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        Dim FirstName, MiddleName, LastName, Username, Password As String
        Dim RoleID As Integer

        FirstName = Trim(txtEditUserFirstName.Text)
        MiddleName = Trim(txtEditUserMiddleName.Text)
        LastName = Trim(txtEditUserLastName.Text)
        Username = Trim(txtEditUserUsername.Text)
        Password = Trim(txtEditUserPassword.Text)
        RoleID = comboEditUser.SelectedValue


        If FirstName = "" Then
            MsgBox("Please provide first name.", MsgBoxStyle.Exclamation)
            txtEditUserFirstName.Select()
        ElseIf LastName = "" Then
            MsgBox("Please provide last name.", MsgBoxStyle.Exclamation)
            txtEditUserLastName.Select()
        ElseIf Username = "" Then
            MsgBox("Please provide username", MsgBoxStyle.Exclamation)
            txtEditUserUsername.Select()
        ElseIf password = "" Then
            MsgBox("Please provide password", MsgBoxStyle.Exclamation)
            txtEditUserPassword.Select()
        End If

        If FirstName <> "" And LastName <> "" And Username <> "" And Password <> "" Then
            Try
                dbAdapter = New OleDbDataAdapter("UPDATE Users 
                                                    SET FirstName = '" & FirstName & "', MiddleName = '" & MiddleName & "', 
                                                        LastName = '" & LastName & "', Username = '" & Username & "', 
                                                        Password = '" & Password & "', RoleID = " & RoleID & "
                                                        WHERE ID = " & CInt(lblEditUserID.Text) & " ", dbConnection)
                dbDataSet = New DataSet
                dbAdapter.Fill(dbDataSet)

                MsgBox("User updated.", MsgBoxStyle.Information)
                ShowAllUsers()
                ClearUserRegistrationTextbox()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try

        End If

    End Sub

    Private Sub lblAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblAbout.LinkClicked
        frmAbout.ShowDialog()
    End Sub

    Private Sub txtEditStudentYear_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditStudentYear.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtEditStudentSection_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditStudentSection.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub GetSortedWasteByStudentID(StudentID As Integer)
        dbAdapter = New OleDbDataAdapter("SELECT
	                                            WasteSorting.ID,
	                                            WasteSorting.StudentID,
	                                            SortingCategories.Name, 
	                                            IIF(
		                                            WasteSorting.Result= 1,
		                                            'CORRECT',
		                                            'INCORRECT')
	                                              AS Result,
                                                WasteSorting.Timestamp As 'Date' 
                                            FROM
                                              WasteSorting INNER JOIN SortingCategories ON WasteSorting.SortingCategoryID = SortingCategories.ID
                                            GROUP BY SortingCategories.Name, Result,WasteSorting.ID, WasteSorting.StudentID, WasteSorting.Timestamp
                                            Having WasteSorting.StudentID = " & StudentID & "
                                            ORDER BY WasteSorting.Timestamp DESC", dbConnection)
        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

        dgvBrowseSortedWaste.DataSource = dbDataTable
    End Sub

    Private Sub btnBrowseWasteSorting_Click(sender As Object, e As EventArgs) Handles btnBrowseWasteSorting.Click
        GetSortedWasteByStudentID(CInt(lblEditStudentID.Text))
        gbBrowseSortedWaste.Show()
        dgvBrowseSortedWaste.Columns("ID").Visible = False
        dgvBrowseSortedWaste.Columns("StudentID").Visible = false
        dgvBrowseSortedWaste.Columns("Name").HeaderText = "Waste category"
        dgvBrowseSortedWaste.Columns("Date").HeaderText = "Date thrown"
        dgvBrowseSortedWaste.Columns("Name").Width = 244
        dgvBrowseSortedWaste.Columns("Result").Width = 244
        dgvBrowseSortedWaste.Columns("Date").Width = 244

        dbAdapter = New OleDbDataAdapter("Select * from SortingCategories", dbConnection)

        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

        Dim bindingSource As New BindingSource

        bindingSource.DataSource = dbDataTable
        comboCategory.DataSource = bindingSource
        comboCategory.DisplayMember = "Name"
        comboCategory.ValueMember = "ID"


        comboSortingResult.Items.Add("CORRECT")
        comboSortingResult.Items.Add("INCORRECT")
        comboSortingResult.SelectedIndex = 0

        If dgvBrowseSortedWaste.RowCount = 0 Then
            btnDeleteSorting.Enabled = False
            btnUpdateSorting.Enabled = False

            comboCategory.Enabled = False
            comboSortingResult.Enabled = False
        End If



    End Sub

    Private Sub dgvBrowseSortedWaste_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrowseSortedWaste.CellClick
        Dim i, SortingWasteIndex As Integer

        Try
            i = dgvBrowseSortedWaste.CurrentRow.Index

            SortingWasteIndex = dgvBrowseSortedWaste.Columns("Name").Index
            comboCategory.Text = Trim(dgvBrowseSortedWaste.Item(SortingWasteIndex, i).Value.ToString)

            SortingWasteIndex = dgvBrowseSortedWaste.Columns("Result").Index
            comboSortingResult.Text = Trim(dgvBrowseSortedWaste.Item(SortingWasteIndex, i).Value.ToString)

            btnUpdateSorting.Enabled = True
            btnDeleteSorting.Enabled = True

            comboCategory.Enabled = True
            comboSortingResult.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        Dim i, UserRecordIndex As Integer
        Dim UserID As String

        Try
            i = dgvUsers.CurrentRow.Index
            UserRecordIndex = dgvUsers.Columns("ID").Index
            UserID = dgvUsers.Item(UserRecordIndex, i).Value.ToString

            btnEditUser.Enabled = True
            btnDeleteUser.Enabled = True
        Catch ex As Exception
            btnEditUser.Enabled = False
            btnDeleteUser.Enabled = False
        End Try
    End Sub

    Public Function GeneratePassword()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz"
        Dim r As New Random
        Dim sb As New System.Text.StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 61)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Sub btnRegisterUser_Click(sender As Object, e As EventArgs) Handles btnRegisterUser.Click
        Dim FirstName, MiddleName, LastName, Username, Password As String
        Dim RoleID As Integer

        FirstName = Trim(txtRegisterUserFirstname.Text)
        MiddleName = Trim(txtRegisterUserMiddleName.Text)
        LastName = Trim(txtRegisterUserLastName.Text)
        Username = Trim(txtRegisterUserUsername.Text)
        Password = Trim(txtRegisterUserPassword.Text)
        RoleID = comboRoles.SelectedValue


        If FirstName = "" Then
            MsgBox("Please provide first name.", MsgBoxStyle.Exclamation)
            txtRegisterUserFirstname.Select()
        ElseIf LastName = "" Then
            MsgBox("Please provide last name.", MsgBoxStyle.Exclamation)
            txtRegisterUserLastName.Select()
        ElseIf username = "" Then
            MsgBox("Please provide username", MsgBoxStyle.Exclamation)
            txtRegisterUserUsername.Select()
        ElseIf txtRegisterUserPassword.Text = "" Then
            MsgBox("Please provide password", MsgBoxStyle.Exclamation)
            txtRegisterUserPassword.Select()
        End If

        If FirstName <> "" And LastName <> "" And Username <> "" And Password <> "" Then
            Try
                dbAdapter = New OleDbDataAdapter("INSERT INTO Users 
                                                    (FirstName, MiddleName, LastName, Username, Password, RoleID)
                                                    VALUES ('" & FirstName & "','" & MiddleName & "','" & LastName & "','" & Username & "','" & Password & "'," & RoleID & ")", dbConnection)
                dbDataSet = New DataSet
                dbAdapter.Fill(dbDataSet)

                MsgBox("New user registered.", MsgBoxStyle.Information)
                ShowAllUsers()
                ClearUserRegistrationTextbox()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try

        End If

    End Sub
End Class
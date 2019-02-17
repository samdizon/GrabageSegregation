Imports System.Data.OleDb
Imports System.IO.Ports

Public Class frmMainStudents
    Public StudentID As Integer
    Public IncorrectPaper, IncorrectMetal, IncorrectPlastic, CorrectPaper, CorrectMetal, CorrectPlastic, TotalPaper, TotalPlastic, TotalMetal As Integer
    Public PlasticID, PaperID, MetalID As Integer


    Private Sub frmMainStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllSortedWaste()
        GetCategoriesID()

        GetCorrectSortingCategoriesByID(StudentID)
        GetInCorrectSortingCategoriesByID(StudentID)
        GetTotalSorting()

        AssignSortingResultsToLabels()


        GetSettings()

        TimerThrowGB.Enabled = False

        Try
            ArduinoSerialPort.Close()
            ArduinoSerialPort.PortName = PortName
            ArduinoSerialPort.BaudRate = BaudRate
            ArduinoSerialPort.DataBits = DataBits
            ArduinoSerialPort.Parity = Parity.None
            ArduinoSerialPort.Handshake = Handshake.None
            ArduinoSerialPort.Encoding = System.Text.Encoding.Default
            ArduinoSerialPort.ReadTimeout = ReadTimeout

            ArduinoSerialPort.Open()
            TimerThrowGB.Enabled = True
        Catch ex As Exception
            MsgBox("Unable to connect with computer port " & PortName & ". Please call your system administrator and change port settings. " & ex.ToString, MsgBoxStyle.Critical)
            frmLogin.Show()
            Me.Hide()
        End Try

    End Sub
    Private Sub GetAllSortedWaste()
        Dim sql = "Select * From Students
                    Where ID = " & StudentID & " "

        dbAdapter = New OleDbDataAdapter(sql, dbConnection)
        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

        lblStudentName.Text = Trim(dbDataTable.Rows(0)("FirstName").ToString) & " " & Trim(dbDataTable.Rows(0)("MiddleName").ToString) & " " & Trim(dbDataTable.Rows(0)("LastName").ToString)
        lblStudentYearSection.Text = Trim(dbDataTable.Rows(0)("CourseCode").ToString) & ", " & Trim(dbDataTable.Rows(0)("Year").ToString) & "-" & Trim(dbDataTable.Rows(0)("Section").ToString)


        GetSortedWasteByStudentID(CInt(StudentID))
        dgvBrowseSortedWaste.Columns("ID").Visible = False
        dgvBrowseSortedWaste.Columns("StudentID").Visible = False
        dgvBrowseSortedWaste.Columns("Name").HeaderText = "Waste category"
        dgvBrowseSortedWaste.Columns("Date").HeaderText = "Date thrown"
        dgvBrowseSortedWaste.Columns("Name").Width = 280
        dgvBrowseSortedWaste.Columns("Result").Width = 280
        dgvBrowseSortedWaste.Columns("Date").Width = 280
    End Sub
    Private Sub GetCategoriesID()
        Dim sql = "Select * From SortingCategories
                    Where Name like '%PAPER%' "

        dbAdapter = New OleDbDataAdapter(sql, dbConnection)
        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

        PaperID = CInt(Trim(dbDataTable.Rows(0)("ID").ToString))

        sql = "Select * From SortingCategories
                    Where Name like '%METAL%' "

        dbAdapter = New OleDbDataAdapter(sql, dbConnection)
        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

        MetalID = CInt(Trim(dbDataTable.Rows(0)("ID").ToString))

        sql = "Select * From SortingCategories
                    Where Name like '%PLASTIC%' "

        dbAdapter = New OleDbDataAdapter(sql, dbConnection)
        dbDataTable = New DataTable
        dbAdapter.Fill(dbDataTable)

        PlasticID = CInt(Trim(dbDataTable.Rows(0)("ID").ToString))
    End Sub

    Private Sub GetTotalSorting()
        TotalMetal = IncorrectMetal + CorrectMetal
        TotalPaper = IncorrectPaper + CorrectPaper
        TotalPlastic = IncorrectPlastic + CorrectPlastic
    End Sub

    Private Sub btnThrow_Click(sender As Object, e As EventArgs)

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

        lblTotalCorrect.Text = CorrectMetal + CorrectPaper + CorrectPlastic
        lblTotalIncorrect.Text = IncorrectMetal + IncorrectPaper + IncorrectPlastic
        lblTotal.Text = CInt(Trim(lblTotalCorrect.Text)) + CInt(Trim(lblTotalIncorrect.Text))


        If CorrectEq <> Nothing Then
            lblCorrectPoints.Text = CorrectEq * CInt(lblTotalCorrect.Text)
        Else
            lblIncorrectPoints.Text = ""
        End If

        If IncorrectEq <> Nothing Then
            lblIncorrectPoints.Text = IncorrectEq * CInt(lblTotalIncorrect.Text)
            lblTotalEquivalentPoints.Text = IncorrectEq * CInt(lblTotalIncorrect.Text)
            lblTotalEquivalentPoints.Text = lblTotalEquivalentPoints.Text & " total points"
        Else
            lblIncorrectPoints.Text = ""
            lblTotalEquivalentPoints.Text = ""
        End If

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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmStudentsPortal.Show()
        frmStudentsPortal.DetectFingerprintTimer.Enabled = True
        frmStudentsPortal.ArduinoSerialPort.Open()
        frmStudentsPortal.DetectFingerprintTimer.Start()

        Me.Hide()
    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub TimerThrowGB_Tick(sender As Object, e As EventArgs) Handles TimerThrowGB.Tick
        lblResultPrompt.Text = ""
        Dim receivedData As String
        Dim SortingID, result, resultIndex As Integer


        receivedData = Trim(ReceiveSerialData().ToString.ToUpper)
        'test data
        'receivedData = "PLASTIC-1"

        'get result index



        'get garbage thrown and result
        If receivedData <> "NOTHING" Then
            ArduinoSerialPort.Close()
            TimerThrowGB.Stop()
            TimerThrowGB.Enabled = False
            If receivedData = "EXIT" Then
                frmStudentsPortal.Show()
                frmStudentsPortal.DetectFingerprintTimer.Enabled = True
                frmStudentsPortal.ArduinoSerialPort.Open()
                frmStudentsPortal.DetectFingerprintTimer.Start()

                Me.Hide()
            Else
                resultIndex = receivedData.IndexOf("-")
                resultIndex += 1
                result = receivedData.Substring(resultIndex, 1)

                receivedData = receivedData.Substring(0, resultIndex - 1)

                'ArduinoSerialPort.Close()
                'TimerThrowGB.Stop()
                'TimerThrowGB.Enabled = False

                If receivedData = "PAPER" Then
                    SortingID = PaperID
                End If
                If receivedData = "PLASTIC" Then
                    SortingID = PlasticID
                End If
                If receivedData = "METAL" Then
                    SortingID = MetalID
                End If

                Try
                    dbAdapter = New OleDbDataAdapter("INSERT INTO WasteSorting (StudentID, SortingCategoryID, Result)
                                                VALUES (" & StudentID & "," & SortingID & "," & result & ")", dbConnection)
                    dbDataSet = New DataSet
                    dbAdapter.Fill(dbDataSet)

                    lblResultPrompt.Text = "Garbage thrown successfully."
                    GetAllSortedWaste()

                    GetCorrectSortingCategoriesByID(StudentID)
                    GetInCorrectSortingCategoriesByID(StudentID)
                    GetTotalSorting()

                    AssignSortingResultsToLabels()


                    ArduinoSerialPort.Open()
                    TimerThrowGB.Enabled = True
                    'TimerThrowGB.Start()


                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)

                End Try
            End If
        End If

    End Sub

    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = ArduinoSerialPort.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing"
            ElseIf Incoming = "" Then
                Return "nothing"
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function
End Class
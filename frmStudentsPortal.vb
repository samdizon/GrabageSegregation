﻿Imports System.IO.Ports
Imports System.Data.OleDb

Public Class frmStudentsPortal
    Dim receivedData As String = ""

    Private Sub frmStudentsMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        ConnectDB()
        GetSettings()

        DetectFingerprintTimer.Enabled = False

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
            DetectFingerprintTimer.Enabled = True
        Catch ex As Exception
            MsgBox("Unable to connect with computer port " & PortName & ". Please call your system administrator and change port settings. " & ex.ToString, MsgBoxStyle.Critical)
            frmLogin.Show()
            Me.Hide()
        End Try


    End Sub


    Private Overloads Sub CenterToScreen()
        Dim formHeight, formWidth, containerHeight, containerWidth, calculatedHeight, calculatedWidth As Integer
        formHeight = (Screen.PrimaryScreen.WorkingArea.Height) \ 2
        formWidth = (Screen.PrimaryScreen.WorkingArea.Width) \ 2
        containerHeight = panelAppTitle.Height \ 2
        containerWidth = panelAppTitle.Width \ 2

        calculatedHeight = formHeight - containerHeight
        calculatedWidth = formWidth - containerWidth

        panelAppTitle.Location = New Point(calculatedWidth, calculatedHeight)
    End Sub

    Private Sub frmStudentsMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'press ctrl + alt + shift + x to exit
        If (e.Alt AndAlso e.Control AndAlso e.Shift AndAlso (e.KeyCode = Keys.X)) Then
            End
        End If
        'press ctrl + alt + shift + o
        If (e.Alt AndAlso e.Control AndAlso e.Shift AndAlso (e.KeyCode = Keys.O)) Then
            DetectFingerprintTimer.Enabled = False
            DetectFingerprintTimer.Stop()
            ArduinoSerialPort.Close()
            frmLogin.Show()

            Me.Hide()
        End If

    End Sub

    Private Sub DetectFingerprintTimer_Tick(sender As Object, e As EventArgs) Handles DetectFingerprintTimer.Tick
        Dim fingerprintID As Integer = 0

        receivedData = ReceiveSerialData().ToString.ToUpper
        'test data
        'receivedData = 1234

        Label1.Text = receivedData.ToString

        'get identified fingerprint ID from arduino
        If receivedData <> "NOTHING" Then
            ValidateStudentByID(CInt(Trim(receivedData.ToString)))
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

    Private Sub ValidateStudentByID(FingerPrintID As Integer)
        Try

            ArduinoSerialPort.Close()
            DetectFingerprintTimer.Stop()
            DetectFingerprintTimer.Enabled = False

            Dim Sql = "Select * From Students where FingerPrintID = " & FingerPrintID & " "

            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            If dbDataTable.Rows.Count = 0 Then


                MsgBox("Unrecognized fingerprint. Please check with your administrator if your biometric ID is registered.")

            Else

                frmMainStudents.StudentID = dbDataTable.Rows(0)("ID")
                frmMainStudents.Show()
                Me.Hide()
            End If



        Catch ex As Exception
            MsgBox("A problem is encountered. Please contact your system administrator", MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
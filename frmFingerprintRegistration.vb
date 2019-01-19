Imports System.IO.Ports

Public Class frmFingerprintRegistration
    Dim FingerPrintID As String
    Dim mainForm As New fmMain()
    Public StudentNumber, FirstName, MiddleName, LastName, CourseCode, Year, Section As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ArduinoSerialPort.Write("EXITENROLL")
        ArduinoSerialPort.Close()
        RegisterFingerprintTimer.Stop()
        RegisterFingerprintTimer.Enabled = False
        Me.Hide()
        mainForm.Show()

    End Sub

    Private Sub frmFingerprintRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSettings()

        RegisterFingerprintTimer.Enabled = False

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
            RegisterFingerprintTimer.Enabled = True


            ArduinoSerialPort.Write("ENROLL")

            FingerPrintID = 0
            'RegisterFingerprintTimer.Enabled = True
            RegisterFingerprintTimer.Start()
            lblFingerprintMessage.Text = "Please place fingerprint on the device..."
        Catch ex As Exception
            MsgBox("Unable to connect with computer port " & PortName & ". Please call your system administrator and change port settings. " & ex.ToString, MsgBoxStyle.Critical)
        End Try




    End Sub

    Private Sub RegisterFingerprintTimer_Tick(sender As Object, e As EventArgs) Handles RegisterFingerprintTimer.Tick
        Dim receivedData As String

        Dim fingerprintID As Integer

        receivedData = ReceiveSerialData().ToString.ToUpper

        'get identified fingerprint ID from arduino
        If receivedData <> "NOTHING" Then
            fingerprintID = CInt(receivedData)


            If FingerPrintID <> 0 Then
                RegisterFingerprintTimer.Stop()
                'RegisterFingerprintTimer.Enabled = False
                MsgBox("Fingerprint registered.", MsgBoxStyle.Information)
                mainForm.txtboxFingerprintID.Text = FingerPrintID
                mainForm.txtStudentNumber.Text = StudentNumber
                mainForm.txtStudentFirstname.Text = FirstName
                mainForm.txtStudentMiddlename.Text = MiddleName
                mainForm.txtStudentLastname.Text = LastName
                mainForm.txtStudentCourse.Text = CourseCode
                mainForm.txtStudentYear.Text = Year
                mainForm.txtStudentSection.Text = Section

                FingerPrintID = 0




                ArduinoSerialPort.Write("EXITENROLL")
                ArduinoSerialPort.Close()
                RegisterFingerprintTimer.Stop()
                RegisterFingerprintTimer.Enabled = False


                Me.Hide()
                mainForm.Show()
                mainForm.gbBrowseStudents.Hide()
                mainForm.gbBrowseSortedWaste.Hide()
                mainForm.gbBrowseStudents.Hide()
                mainForm.gbBrowseUsers.Hide()
                mainForm.gbEditStudents.Hide()
                mainForm.gbEditUser.Hide()
                mainForm.gbRegisterUser.Hide()
                mainForm.gbRegisterStudents.Show()

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ArduinoSerialPort.Open()
            RegisterFingerprintTimer.Enabled = True
            ArduinoSerialPort.Write("ENROLL")

            RegisterFingerprintTimer.Start()
        Catch ex As Exception
            MsgBox("Fingerprint enrollment is ready.", MsgBoxStyle.Information)
        End Try
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

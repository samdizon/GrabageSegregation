Public Class frmFingerprintRegistration
    Dim FingerPrintID As String
    Dim mainForm As New fmMain()
    Public StudentNumber, FirstName, MiddleName, LastName, CourseCode, Year, Section As String

    Private Sub frmFingerprintRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FingerPrintID = 0
        'RegisterFingerprintTimer.Enabled = True
        RegisterFingerprintTimer.Start()
        lblFingerprintMessage.Text = "Please place fingerprint on the device..."
        Me.KeyPreview = True
    End Sub

    Private Sub RegisterFingerprintTimer_Tick(sender As Object, e As EventArgs) Handles RegisterFingerprintTimer.Tick
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
            TextBox1.Text = ""
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FingerPrintID = TextBox1.Text
        RegisterFingerprintTimer.Start()
    End Sub

    'Private Sub RegisterFingerprintTimer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    'If (e.Control AndAlso e.Alt AndAlso (e.KeyCode = Keys.F)) Then
    ' When Ctrl + Alt + F is pressed, the Click event for the fingerprint ID
    ' button is raised.
    'RaiseEvent btnPrintCustomerDetails().Click
    'MsgBox("got the print")

    '    FingerPrintID = 100
    'End If
    'End Sub
End Class

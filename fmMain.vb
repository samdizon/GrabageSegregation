Imports System.Data.OleDb

Public Class fmMain
    Private Sub fmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearchStudents.Select()
        ConnectDB()

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

        Catch ex As Exception
            MsgBox("A problem is encountered on the System. Please call your system administrator.", MsgBoxStyle.Critical)
            Me.Dispose()
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub lblLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLogout.LinkClicked
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    End Sub
End Class
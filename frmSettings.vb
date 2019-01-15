Imports System.Data.OleDb
Public Class frmSettings
    Dim SettingsID As Integer
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        GetSettings()
    End Sub

    Private Sub GetSettings()
        Try
            Dim Sql = "Select * FROM Settings"

            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)


            'Dim i, SettingsRecordIndex As Integer

            'i = dbDataTable.Rows()

            'StudentRecordIndex = dgvStudents.Columns("ID").Index
            'lblEditStudentID.Text = Trim(dgvStudents.Item(StudentRecordIndex, i).Value.ToString)

            'TotalCorrect = dbDataTable.Rows(0)(0).ToString
            txtDataBits.Text = dbDataTable.Rows(0)("DataBits")
            txtPortBaudRate.Text = dbDataTable.Rows(0)("PortBaudRate")
            txtReadTimeout.Text = dbDataTable.Rows(0)("ReadTimeout")
            SettingsID = CInt(dbDataTable.Rows(0)("ID"))
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        Dim PortName As String = "dummy"
        Dim DataBits, PortBaudRate, ReadTimeout As Integer

        If txtDataBits.Text = "" Then
            MsgBox("Please provide data bits, default value is 8", MsgBoxStyle.Exclamation)
            txtDataBits.Select()
        ElseIf txtPortBaudRate.Text = "" Then
            MsgBox("Please provide port baud rate, default value is 9600", MsgBoxStyle.Exclamation)
            txtPortBaudRate.Select()
        ElseIf txtReadTimeout.Text = "" Then
            MsgBox("Please provide read timeout, default value is 10000", MsgBoxStyle.Exclamation)
            txtReadTimeout.Select()
        ElseIf PortName = "" Then
            MsgBox("Please call your system administrator, the device is not recognized", MsgBoxStyle.Critical)
            End
        Else
            PortName = "Dummy"
            DataBits = CInt(Trim(txtDataBits.Text))
            PortBaudRate = CInt(Trim(txtPortBaudRate.Text))
            ReadTimeout = CInt(Trim(txtReadTimeout.Text))
        End If


        If DataBits <> 0 And PortBaudRate <> 0 And ReadTimeout <> 0 Then


            Try
                dbAdapter = New OleDbDataAdapter("UPDATE Settings 
                                                    SET PortName = '" & PortName & "', DataBits = " & DataBits & ", 
                                                        PortBaudRate = " & PortBaudRate & ", ReadTimeout = " & ReadTimeout & "
                                                        WHERE ID = " & SettingsID & "", dbConnection)
                dbDataSet = New DataSet
                dbAdapter.Fill(dbDataSet)

                MsgBox("Settings updated.", MsgBoxStyle.Information, "Update GSS Settings")
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub
End Class
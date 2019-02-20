Imports System.Data.OleDb
Imports System.IO.Ports

Public Class frmSettings
    Dim SettingsID As Integer

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        GetSettings()
        comboComPort.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            comboComPort.Items.Add(sp)
        Next

        If comboComPort.Items.Count <> 0 Then
            comboComPort.SelectedIndex = 0
        Else
            MsgBox("No port available, please call your system administrator", MsgBoxStyle.Critical, "Device connection error")
            Me.Hide()
        End If
    End Sub

    Private Sub GetSettings()
        Try
            Dim Sql = "Select * FROM Settings"

            dbAdapter = New OleDbDataAdapter(Sql, dbConnection)
            dbDataTable = New DataTable
            dbAdapter.Fill(dbDataTable)

            txtDataBits.Text = dbDataTable.Rows(0)("DataBits")
            txtPortBaudRate.Text = dbDataTable.Rows(0)("PortBaudRate")
            txtReadTimeout.Text = dbDataTable.Rows(0)("ReadTimeout")
            SettingsID = CInt(dbDataTable.Rows(0)("ID"))
            txtIncorrectEquivalent.Text = Trim(dbDataTable.Rows(0)("IncorrectEquivalent"))
            txtCorrectEquivalent.Text = Trim(dbDataTable.Rows(0)("CorrectEquivalent"))
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        Dim portName As String = "dummy"
        Dim dataBits, portBaudRate, readTimeout As Integer
        Dim incorrectPoints, correctPoints As Decimal

        If txtDataBits.Text = "" Then
            MsgBox("Please provide data bits, default value is 8", MsgBoxStyle.Exclamation)
            txtDataBits.Select()
        ElseIf txtPortBaudRate.Text = "" Then
            MsgBox("Please provide port baud rate, default value is 9600", MsgBoxStyle.Exclamation)
            txtPortBaudRate.Select()
        ElseIf txtReadTimeout.Text = "" Then
            MsgBox("Please provide read timeout, default value is 10000", MsgBoxStyle.Exclamation)
            txtReadTimeout.Select()
        ElseIf portName = "" Then
            MsgBox("Please call your system administrator, the device is not recognized", MsgBoxStyle.Critical)
            End
        Else
            portName = Trim(comboComPort.Text)
            dataBits = CInt(Trim(txtDataBits.Text))
            portBaudRate = CInt(Trim(txtPortBaudRate.Text))
            readTimeout = CInt(Trim(txtReadTimeout.Text))

            If txtIncorrectEquivalent.Text = Nothing Then
                incorrectPoints = Nothing
            Else
                incorrectPoints = Trim(txtIncorrectEquivalent.Text)
            End If

            If txtCorrectEquivalent.Text = Nothing Then
                correctPoints = Nothing
            Else
                correctPoints = Trim(txtCorrectEquivalent.Text)
            End If
        End If


        If dataBits <> 0 And portBaudRate <> 0 And readTimeout <> 0 Then


            Try
                dbAdapter = New OleDbDataAdapter("UPDATE Settings 
                                                    SET PortName = '" & portName & "', DataBits = " & dataBits & ", 
                                                        PortBaudRate = " & portBaudRate & ", ReadTimeout = " & readTimeout & ",
                                                        IncorrectEquivalent = " & incorrectPoints & ", CorrectEquivalent = " & correctPoints & "
                                                        WHERE ID = " & SettingsID & "", dbConnection)
                dbDataSet = New DataSet
                dbAdapter.Fill(dbDataSet)

                MsgBox("Settings updated, please restart the system for changes to take effect.", MsgBoxStyle.Information, "Update GSS Settings")
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

    Private Sub txtCorrectEquivalent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorrectEquivalent.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub
    Private Sub txtInCorrectEquivalent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIncorrectEquivalent.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub
End Class
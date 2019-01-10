Public Class fmMain
    Private Sub fmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
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


End Class
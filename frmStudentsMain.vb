Public Class frmStudentsMain
    Private Sub frmStudentsMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
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
            frmLogin.Show()
            Me.Hide()
        End If

    End Sub
End Class
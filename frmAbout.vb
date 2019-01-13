Public Class frmAbout
    Private Sub EscTimer_Tick_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If ((e.KeyCode = Keys.Escape)) Then
            'When Esc, the Click event for the fingerprint ID
            'Button Is raised.
            Me.Hide()
        End If
    End Sub

End Class
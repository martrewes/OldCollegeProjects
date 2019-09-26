Public Class frmLogin
    Public Shared User As TextBox
    Public Shared Pass As TextBox


    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtUsername.Text) Or String.IsNullOrEmpty(txtPassword.Text) Then
            MsgBox("Please enter a username and a password!")
            Exit Sub
        End If
        User = txtUsername
        Pass = txtPassword
        Me.Close()

    End Sub
End Class
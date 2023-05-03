Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "password" Then
            ' Log in successful, show the main form
            Dim mainForm As New MainForm
            mainForm.Show()
            Me.Hide()
        Else
            ' Incorrect username or password
            lblError1.Text = "Incorrect username or password"
        End If
    End Sub

End Class

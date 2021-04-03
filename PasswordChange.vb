Public Class PasswordChange
    Public currentUser As User

    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
        If CurrentPasswordTextBox.Text = currentUser.Password Then
            If NewPasswordTextBox.Text = ComfirmPasswordTextBox.Text Then
                currentUser.Password = NewPasswordTextBox.Text
                UserControls.CurrentUser = currentUser
                Me.Close()
                MsgBox("Password changed!")
            Else
                MsgBox("Comfirmed password does not match new password")
            End If
        Else
            MsgBox("Wrong Password")
        End If
    End Sub

    Private Sub PasswordChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentPasswordTextBox.PasswordChar = "*"
        NewPasswordTextBox.PasswordChar = "*"
        ComfirmPasswordTextBox.PasswordChar = "*"
    End Sub
End Class
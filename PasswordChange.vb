Public Class PasswordChange
    Public currentUser As User

    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
        If CurrentPasswordTextBox.Text = currentUser.Password Then
            If NewPasswordTextBox.Text.Length > 8 Then
                If ContainsSpecialChars(NewPasswordTextBox.Text) = True Then
                    If ContainsNumber(NewPasswordTextBox.Text) = True Then
                        If NewPasswordTextBox.Text = ComfirmPasswordTextBox.Text Then
                            currentUser.Password = NewPasswordTextBox.Text
                            UserControls.CurrentUser = currentUser
                            Me.Close()
                            MsgBox("Password changed!")
                        Else
                            MsgBox("Comfirmed password does not match new password")
                        End If
                    Else
                        MsgBox("New Password must contain atleast one number")
                    End If
                Else
                    MsgBox("New Password must contain atleast one special character")
                End If
            Else
                MsgBox("New Password must contain atleast 9 characters")
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

    Function ContainsSpecialChars(s As String) As Boolean
        Return s.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function

    Function ContainsNumber(s As String) As Boolean
        Return s.IndexOfAny("0123456789".ToCharArray) <> -1
    End Function
End Class
Public Class CreateUserWindow

    Public Userlist As List(Of User)
    Private Sub CreateUserWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IE_Expense_Helper.LoadUsers()
        Userlist = IE_Expense_Helper.UserList
        PasswordTextBox.Enabled = False
        GenPassCheckBox.Checked = True
        AdminUserControls.Enabled = False
    End Sub

    Private Sub GenPassTextBox_CheckedChanged(sender As Object, e As EventArgs) Handles GenPassCheckBox.CheckedChanged
        If GenPassCheckBox.Checked = True Then
            PasswordTextBox.Enabled = False
        Else
            PasswordTextBox.Enabled = True
        End If
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        If GenPassCheckBox.Checked = True Then
            If UserExists(UserNameTextBox.Text) = False Then
                Dim NewUser As New User(UserNameTextBox.Text, "NoPassword2021", PermissionsComboBox.SelectedItem.ToString)
                Userlist.Add(NewUser)
                IE_Expense_Helper.SaveUsers(Userlist)
                AdminUserControls.Refresh()
            End If
        Else
            If UserExists(UserNameTextBox.Text) = False Then
                Dim NewUser As New User(UserNameTextBox.Text, PasswordTextBox.Text, PermissionsComboBox.SelectedItem.ToString)
                Userlist.Add(NewUser)
                IE_Expense_Helper.SaveUsers(Userlist)
                AdminUserControls.Refresh()
            End If
        End If
    End Sub

    Private Function UserExists(ByVal newuser As String) As Boolean
        For Each existinguser As User In Userlist
            If existinguser.Username = newuser Then
                MsgBox("Conflict: Username is already in use")
                Return True
                Exit Function
            End If
        Next

        Return False
    End Function


End Class
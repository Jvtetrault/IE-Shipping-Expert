Public Class AdminUserControls
    Public Userlist As List(Of User)
    Private CurrentSelectedUser As String
    Public CurrentUser As User
    Private Sub AdminUserControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = 99
        IE_Expense_Helper.LoadUsers()
        Userlist = IE_Expense_Helper.UserList
        UserDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        For Each UserMember As User In Userlist
            UserDataGridView.Rows.Add(UserMember.Username, UserMember.Password, UserMember.Permissions)
        Next

        UserDataGridView.Rows(0).Selected = 0
        CurrentUser = Userlist(0)
        CurrentUserLabel.Text = Userlist(0).Username
    End Sub

    Private Sub DeleteUserButton_Click(sender As Object, e As EventArgs) Handles DeleteUserButton.Click
        LoadUserInfo(UserDataGridView.CurrentCell.RowIndex)
        For Each LoadedUser As User In Userlist
            If LoadedUser.Username = CurrentSelectedUser Then
                MsgBox(CurrentSelectedUser)
                Userlist.Remove(LoadedUser)
                IE_Expense_Helper.SaveUsers(Userlist)
                IE_Expense_Helper.LoadUsers()
                Exit For
            End If
        Next
        Reload()
    End Sub

    Public Sub Reload()
        Me.Controls.Clear()
        InitializeComponent()
        AdminUserControls_Load(Me, New System.EventArgs)
    End Sub

    Private Sub CreateUserButton_Click(sender As Object, e As EventArgs) Handles CreateUserButton.Click
        Dim CreateNewUser As New CreateUserWindow
        CreateUserWindow.PermissionsComboBox.SelectedIndex = 1
        Me.Close()
        CreateNewUser.Show()
    End Sub

    Private Sub LoadUserInfo(ByVal Index As Integer)
        Try
            CurrentSelectedUser = UserDataGridView.Rows(Index).Cells(0).Value
            CurrentUserLabel.Text = CurrentSelectedUser
            For Each checkuser As User In Userlist
                If checkuser.Username = CurrentSelectedUser Then
                    CurrentUser = checkuser
                End If
            Next
            If CurrentUser Is Nothing Then
                Throw New Exception("No User was found, internal issue was detected")
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub EditUserButton_Click(sender As Object, e As EventArgs) Handles EditUserButton.Click
        Me.SendToBack()
        Dim OpenUserInfo As New UserControls
        OpenUserInfo.UserList = Userlist
        OpenUserInfo.OpenWithPermission = "Admin"
        OpenUserInfo.CurrentUser = CurrentUser
        Me.Close()
        OpenUserInfo.Show()

    End Sub

    Private Sub UserDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles UserDataGridView.SelectionChanged
        Try
            If Not UserDataGridView.CurrentRow.Index < 0 And Not Userlist.Count < 0 Then
                LoadUserInfo(UserDataGridView.CurrentRow.Index)
            End If
        Catch ex As Exception

        End Try


    End Sub

    'Private Sub UserDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGridView.RowEnter

    '    LoadUserInfo(UserDataGridView.CurrentRow.Index)

    'End Sub
End Class
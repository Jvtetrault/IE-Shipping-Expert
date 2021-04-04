Public Class AdminUserControls
    Public Userlist As List(Of User)
    Private Sub AdminUserControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Userlist = IE_Expense_Helper.LoadUsers()
        For Each UserMember As User In Userlist
            UserDataGridView.Rows.Add(UserMember.Username, UserMember.Password, UserMember.Permissions)
        Next
    End Sub

    Private Sub DeleteUserButton_Click(sender As Object, e As EventArgs) Handles DeleteUserButton.Click

    End Sub

    Private Sub UserDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGridView.CellContentClick

    End Sub

    Private Sub CreateUserButton_Click(sender As Object, e As EventArgs) Handles CreateUserButton.Click
        Dim CreateNewUser As New CreateUserWindow
        CreateNewUser.Show()
    End Sub
End Class
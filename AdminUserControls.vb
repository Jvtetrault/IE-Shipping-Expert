Public Class AdminUserControls
    Public Userlist As List(Of User)
    Private Sub AdminUserControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserDataGridView.RowHeadersVisible = False
        Userlist = IE_Expense_Helper.LoadUsers()
    End Sub

    Private Sub DeleteUserButton_Click(sender As Object, e As EventArgs) Handles DeleteUserButton.Click

    End Sub

    Private Sub UserDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGridView.CellContentClick

    End Sub

    Private Sub CreateUserButton_Click(sender As Object, e As EventArgs) Handles CreateUserButton.Click

    End Sub
End Class
Public Class UserControls
    Public User As User
    Private Sub UserControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User = IE_Expense_Helper.CurrentUser

        UserNameTextBox.Text = User.Username
        PasswordTextBox.PasswordChar = "*"
        PasswordTextBox.Text = User.Password

        If User.name IsNot Nothing Then
            NameTextBox.Text = User.name
        End If

        If User.lastname IsNot Nothing Then
            LastNameTextBox.Text = User.lastname
        End If

        If User.company IsNot Nothing Then
            CompanyTextBox.Text = User.company
        End If

        If User.title IsNot Nothing Then
            TitleTextBox.Text = User.title
        End If

        If User.email IsNot Nothing Then
            EmailTextBox.Text = User.email
        End If

        If User.phone IsNot Nothing Then
            PhoneTextBox.Text = User.phone
        End If

        If User.fax IsNot Nothing Then
            FaxTextBox.Text = User.fax
        End If

    End Sub

    Public Sub SaveUserInformation()
        User.name = NameTextBox.Text
        User.lastname = LastNameTextBox.Text
        User.company = CompanyTextBox.Text
        User.title = TitleTextBox.Text
        User.email = EmailTextBox.Text
        User.phone = PhoneTextBox.Text
        User.fax = FaxTextBox.Text

        For Each UserInList As User In Login.UserList
            If User.Username = UserInList.Username Then
                Dim IndexInList As Integer = Login.UserList.IndexOf(UserInList)
                Login.UserList(IndexInList) = User
            End If
        Next

        Login.SaveUsers()
        Login.LoadUsers()

    End Sub

    Private Sub UserControls_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveUserInformation()
        IE_Expense_Helper.Show()
    End Sub
End Class
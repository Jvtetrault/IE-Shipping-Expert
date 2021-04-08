Public Class UserControls
    Public CurrentUser As User
    Public UserList As List(Of User)
    Public OpenWithPermission As String = "Normal"

    Private Sub UserControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost() = 99
        IE_Expense_Helper.LoadUsers()
        If OpenWithPermission = "Normal" Then
            UserList = IE_Expense_Helper.UserList
            IE_Expense_Helper.Enabled = False
            UserNameTextBox.Text = CurrentUser.Username
            PasswordTextBox.PasswordChar = "*"
            PasswordTextBox.Text = CurrentUser.Password
            PermissionComboBox.Visible = False
            PermissionComboBox.Enabled = False
            PermLabel.Visible = False
        ElseIf OpenWithPermission = "Admin" Then
            UserNameTextBox.Text = CurrentUser.Username
            PasswordTextBox.Text = CurrentUser.Password
            ChangePasswordButton.Enabled = False
            UserNameTextBox.Enabled = True
            PasswordTextBox.Enabled = True
            PermissionComboBox.Visible = True
            PermissionComboBox.Enabled = True
            PermLabel.Visible = True
            PermissionComboBox.Text = CurrentUser.Permissions
        End If


        If CurrentUser.name IsNot Nothing Then
            NameTextBox.Text = CurrentUser.name
        End If

        If CurrentUser.lastname IsNot Nothing Then
            LastNameTextBox.Text = CurrentUser.lastname
        End If

        If CurrentUser.company IsNot Nothing Then
            CompanyTextBox.Text = CurrentUser.company
        End If

        If CurrentUser.title IsNot Nothing Then
            TitleTextBox.Text = CurrentUser.title
        End If

        If CurrentUser.email IsNot Nothing Then
            EmailTextBox.Text = CurrentUser.email
        End If

        If CurrentUser.phone IsNot Nothing Then
            PhoneTextBox.Text = CurrentUser.phone
        End If

        If CurrentUser.fax IsNot Nothing Then
            FaxTextBox.Text = CurrentUser.fax
        End If
    End Sub

    Public Sub SaveUserInformation()
        currentUser.name = NameTextBox.Text
        currentUser.lastname = LastNameTextBox.Text
        currentUser.company = CompanyTextBox.Text
        currentUser.title = TitleTextBox.Text
        currentUser.email = EmailTextBox.Text
        currentUser.phone = PhoneTextBox.Text
        CurrentUser.fax = FaxTextBox.Text

        If OpenWithPermission = "Admin" Then
            CurrentUser.Username = UserNameTextBox.Text
            CurrentUser.Password = PasswordTextBox.Text
            CurrentUser.Permissions = PermissionComboBox.Text
        End If

        For Each UserInList As User In userlist
            If currentUser.Username = UserInList.Username Then
                Dim IndexInList As Integer = UserList.IndexOf(UserInList)
                UserList(IndexInList) = CurrentUser
                Exit For
            End If
        Next

        IE_Expense_Helper.SaveUsers(UserList)

        If OpenWithPermission = "Admin" Then
            AdminUserControls.Reload()
        End If

    End Sub
    Private Sub UserControls_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveUserInformation()
        IE_Expense_Helper.Enabled = True
        IE_Expense_Helper.Show()
    End Sub

    Private Sub UserControls_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SaveUserInformation()
        IE_Expense_Helper.Enabled = True
        IE_Expense_Helper.Show()
    End Sub

    Private Sub ChangePasswordButton_Click(sender As Object, e As EventArgs) Handles ChangePasswordButton.Click
        Dim ChangePassword As New PasswordChange
        PasswordChange.currentUser = CurrentUser
        PasswordChange.Show()
    End Sub


End Class
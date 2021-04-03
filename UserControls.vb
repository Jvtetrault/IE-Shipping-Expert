Public Class UserControls
    Public CurrentUser As User
    Public UserList As List(Of User)
    Private Sub UserControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        IE_Expense_Helper.Enabled = False
        UserNameTextBox.Text = CurrentUser.Username
        PasswordTextBox.PasswordChar = "*"
        PasswordTextBox.Text = CurrentUser.Password

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
        currentUser.fax = FaxTextBox.Text

        For Each UserInList As User In userlist
            If currentUser.Username = UserInList.Username Then
                Dim IndexInList As Integer = UserList.IndexOf(UserInList)
                UserList(IndexInList) = CurrentUser
                Exit For
            End If
        Next

        SaveUsers()

    End Sub
    Public Sub SaveUsers()
        Dim F As Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim s As IO.Stream
        F = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        s = New IO.FileStream("C:\ProgramData\Lincoln Electric\IE Shipping Expert\IESEU.bin", IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
        F.Serialize(s, userlist)
        s.Close()
    End Sub

    Public Sub LoadUsers()
        Dim f As Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim s As IO.Stream
        f = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        s = New IO.FileStream("C:\ProgramData\Lincoln Electric\IE Shipping Expert\IESEU.bin", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
        userlist = DirectCast(f.Deserialize(s), Object)
        s.Close()
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
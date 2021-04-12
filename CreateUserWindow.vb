Public Class CreateUserWindow

    Public Userlist As List(Of User)
    Public PermissionList As New List(Of String) From {"Normal", "Admin"}
    Private WithEvents blinker As Timer
    Private Sub CreateUserWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost() = 99
        IE_Expense_Helper.LoadUsers()
        LoadCombo()
        PasswordTextBox.Enabled = False
        GenPassCheckBox.Checked = True
        AdminUserControls.Enabled = False
    End Sub

    Public Sub LoadCombo()
        Userlist = IE_Expense_Helper.UserList
        PermissionsComboBox.Items.Clear()
        For Each Item As String In PermissionList
            PermissionsComboBox.Items.Add(Item)
        Next
        PermissionsComboBox.SelectedIndex = 0
    End Sub

    Private Sub GenPassTextBox_CheckedChanged(sender As Object, e As EventArgs) Handles GenPassCheckBox.CheckedChanged
        If GenPassCheckBox.Checked = True Then
            PasswordTextBox.Enabled = False
        Else
            PasswordTextBox.Enabled = True
        End If
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click

        If Not UserNameTextBox.Text = "" Then
            If GenPassCheckBox.Checked = True Then
                If UserExists(UserNameTextBox.Text) = False Then
                    Dim NewUser As New User(UserNameTextBox.Text, "NoPassword2021", PermissionsComboBox.SelectedItem.ToString)
                    Userlist.Add(NewUser)
                    IE_Expense_Helper.SaveUsers(Userlist)
                    Dim AdminUserControls As New AdminUserControls
                    Me.Close()
                    AdminUserControls.Show()
                End If
            Else
                If UserExists(UserNameTextBox.Text) = False Then
                    Dim NewUser As New User(UserNameTextBox.Text, PasswordTextBox.Text, PermissionsComboBox.SelectedItem.ToString)
                    Userlist.Add(NewUser)
                    IE_Expense_Helper.SaveUsers(Userlist)
                    Dim AdminUserControls As New AdminUserControls
                    Me.Close()
                    AdminUserControls.Show()
                End If
            End If
        Else
            FlickerTextBox(3)
        End If

    End Sub

    Public Sub FlickerTextBox(ByVal Count As Integer)
        If Count > 0 Then
            UserNameTextBox.Visible = False
            System.Threading.Thread.Sleep(35)
            UserNameTextBox.Visible = True
            System.Threading.Thread.Sleep(35)
            Count = Count - 1
            FlickerTextBox(Count)
        Else
            UserNameTextBox.Visible = True
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
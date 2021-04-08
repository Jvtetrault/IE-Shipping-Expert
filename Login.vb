Public Class Login
    Public UserList As List(Of User)
    Public Attempts As Integer = 0
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost() = 99
        PasswordTextBox.PasswordChar = "*"
        If My.Computer.FileSystem.FileExists("C:\ProgramData\Lincoln Electric\IE Shipping Expert\IESEU.bin") = False Then
            Dim fs As System.IO.FileStream = System.IO.File.Create("C:\ProgramData\Lincoln Electric\IE Shipping Expert\IESEU.bin", IO.FileMode.Create)
            fs.Close()
            fs.Dispose()
            Threading.Thread.Sleep(500)
            Dim AdminUser As New User("jtetrault", "GiseleLalonde1", "Admin")
            Dim tempList As New List(Of User)({AdminUser})
            UserList = tempList
            IE_Expense_Helper.SaveUsers(UserList)
            IE_Expense_Helper.LoadUsers()
            UserList = IE_Expense_Helper.UserList
        End If

        IE_Expense_Helper.LoadUsers()
        UserList = IE_Expense_Helper.UserList
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LoginSuccessfull As Boolean = False
        If Attempts < 6 Then
            For Each registereduser As User In UserList
                If registereduser.Username() = UsernameTextBox.Text And registereduser.Password = PasswordTextBox.Text Then
                    IE_Expense_Helper.Enabled = True
                    IE_Expense_Helper.Text = "IE Expense Helper (" & registereduser.Username() & ") "
                    LoginSuccessfull = True
                    IE_Expense_Helper.CurrentUser = registereduser
                    If registereduser.Permissions = "Admin" Then
                        IE_Expense_Helper.Text = IE_Expense_Helper.Text & " - Admin"
                        IE_Expense_Helper.AdminRights(True)
                    End If
                End If
            Next
            If LoginSuccessfull = False Then
                Attempts = Attempts + 1
                MsgBox("Username or Password was incorrect")
            Else
                IE_Expense_Helper.Show()
                Me.Close()
            End If

        Else
            MsgBox("You have been locked out due to excessive login attempts." & vbNewLine & "The application will now close" & vbNewLine & "Please contact your application administrator for help.")
            Me.Close()
            IE_Expense_Helper.Close()
        End If

    End Sub
End Class
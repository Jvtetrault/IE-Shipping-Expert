Public Class Login
    Public UserList As List(Of User)
    Public Attempts As Integer = 0
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.PasswordChar = "*"
        If UserList Is Nothing Then
            Dim AdminUser As New User("jtetrault", "GiseleLalonde1", "Admin")
            Dim tempList As New List(Of User)({AdminUser})
            UserList = tempList
            SaveUsers()
            LoadUsers()
        End If

        LoadUsers()
    End Sub

    Public Sub LoadUsers()
        Dim f As Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim s As IO.Stream
        f = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        s = New IO.FileStream("C:\ProgramData\Lincoln Electric\IE Shipping Expert\IESEU.bin", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
        UserList = DirectCast(f.Deserialize(s), Object)
        s.Close()
    End Sub
    Public Sub SaveUsers()
        Dim F As Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim s As IO.Stream
        F = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        s = New IO.FileStream("C:\ProgramData\Lincoln Electric\IE Shipping Expert\IESEU.bin", IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
        F.Serialize(s, UserList)
        s.Close()
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
Imports org.apache.pdfbox.pdmodel
Imports org.apache.pdfbox.util
Imports ikvm
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.IO
Public Class IE_Expense_Helper
    Private files() As String
    Public CurrentUser As User
    Public UserList As List(Of User)
    Private Sub IE_Expense_Helper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LoginWindow As New Login
        LoginWindow.Show()
        Me.Enabled = False
        Me.AllowDrop = True
    End Sub

    Public Function LoadUsers() As List(Of User)
        Dim f As Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim s As IO.Stream
        f = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        s = New IO.FileStream("C:\ProgramData\Lincoln Electric\IE Shipping Expert\IESEU.bin", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
        Return DirectCast(f.Deserialize(s), Object)
        s.Close()
    End Function
    Public Sub SaveUsers(ByVal UserList As List(Of User), Optional ByVal Attempts As Integer = 0)
        Dim F As Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim s As IO.Stream
        F = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        s = New IO.FileStream("C:\ProgramData\Lincoln Electric\IE Shipping Expert\IESEU.bin", IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
        F.Serialize(s, UserList)
        s.Close()
    End Sub

    Public Sub AdminRights(ByVal HasRights As Boolean)
        If HasRights = True Then
            DevCheckBox.Visible = True
            UserControlButton.Visible = True
        Else
            DevCheckBox.Visible = False
            UserControlButton.Visible = False
        End If

    End Sub

    Private Sub IE_Expense_Helper_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        files = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Dim ext As String = IO.Path.GetExtension(path)
            If ext = ".pdf" Then
                If DevCheckBox.Checked = True Then

                Else

                End If
                'Run Main Script here -> Probably going to generate new form(s) based on PDF's being taken in
            End If
        Next
    End Sub

    Private Sub IE_Expense_Helper_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub OpenPDF()

    End Sub

    Private Sub UserControlButton_Click(sender As Object, e As EventArgs) Handles UserControlButton.Click
        Dim UserControls As New AdminUserControls
        For Each User As User In UserList
            UserControls.UserDataGridView.Rows.Add(User.Username, User.Password, User.Permissions)
        Next

        UserControls.Show()
    End Sub

    Private Sub AccessControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccessControlToolStripMenuItem.Click
        Dim UserControlForm As New UserControls
        UserControlForm.CurrentUser = CurrentUser
        UserControlForm.Show()
    End Sub


End Class

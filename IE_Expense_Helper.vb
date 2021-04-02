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
    Private Sub IE_Expense_Helper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
    End Sub

    Private Sub IE_Expense_Helper_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        files = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files

        Next
    End Sub

    Private Sub IE_Expense_Helper_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub OpenPDF()

    End Sub
End Class

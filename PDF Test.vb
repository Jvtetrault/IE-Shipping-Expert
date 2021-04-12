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
Public Class PDF_Test
    Private _path As String
    Public Sub New(ByVal Path As String)
        InitializeComponent()
        _path = Path
    End Sub

    Private Sub PDF_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim doc As PDDocument = PDDocument.load(_path)
        Dim Stripper As PDFTextStripper = New PDFTextStripper()
        TestRichTextBox.Text = Stripper.getText(doc)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim regextest As Regex = New Regex(TextBox1.Text)


        For Each Line As String In TestRichTextBox.Text
            Dim Match As Match = regextest.Match(TestRichTextBox.Text)
            RichTextBox2.AppendText(Match.Value)
        Next
    End Sub
End Class
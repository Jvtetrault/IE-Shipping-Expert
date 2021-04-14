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
    Private ClientContact As New List(Of String)
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


        For Each Line As String In TestRichTextBox.Lines
            If Not GetRegexString(Line, regextest) = "" Then
                RichTextBox2.AppendText(Line)
            End If
        Next
    End Sub

    Public Function GetRegexString(ByVal Text As String, ByVal regex As Regex) As String
        Dim match As Match = regex.Match(Text)
        If match.Success Then
            Return Text
        Else
            Return ""
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim EntireText As New List(Of String)
        Dim ClientInfo As String = "SOLD TO:"


        For Each Line As String In TestRichTextBox.Lines
            EntireText.Add(Line)
        Next

        For i = 0 To EntireText.Count - 1
            If EntireText(i) = ClientInfo Then
                RichTextBox2.AppendText(EntireText(i + 1) & vbNewLine)
                RichTextBox2.AppendText(EntireText(i + 2) & vbNewLine)
                RichTextBox2.AppendText(EntireText(i + 3) & vbNewLine)
                RichTextBox2.AppendText(EntireText(i + 4) & vbNewLine)
            End If
        Next

        GetClientInfo()

    End Sub

    Public Sub GetClientInfo()
        Dim EntireText As New List(Of String)
        Dim LookoutString As String = "SOLD TO:"
        Dim LookoutString2 As String = "CUSTOMER NUMBER:"


        For Each Line As String In TestRichTextBox.Lines
            EntireText.Add(Line)
        Next

        For i = 0 To EntireText.Count - 1
            If EntireText(i) = LookoutString Then
                ClientContact.Add(EntireText(i + 1))
                ClientContact.Add(EntireText(i + 2))
                ClientContact.Add(EntireText(i + 3))
                ClientContact.Add(EntireText(i + 4))
            ElseIf EntireText(i) = LookoutString2 Then
                ClientContact.Add(EntireText(i + 1))
            End If
        Next
    End Sub

    Public Sub GetShipperInfo()
    End Sub

    Public Sub GetMaterials()
    End Sub
End Class
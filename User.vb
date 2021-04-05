<Serializable> Public Class User
    Friend _username As String
    Friend _password As String
    Friend _permissions As String
    Friend _name As String
    Friend _lastname As String
    Friend _company As String
    Friend _title As String
    Friend _email As String
    Friend _phone As String
    Friend _fax As String

    Public Sub New(ByVal Username As String, ByVal Password As String, ByVal Permissions As String)
        _username = Username
        _password = Password
        _permissions = Permissions
    End Sub

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            If value.Contains(" ") Then
                MsgBox("Whitespaces were found and were replaced" & vbNewLine & value & " = " & value.Replace(" ", ""))
            End If
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Permissions As String
        Get
            Return _permissions
        End Get
        Set(value As String)
            _permissions = value
        End Set
    End Property

    Public Function GenerateRow() As DataGridViewRow
        Dim Row As New DataGridViewRow
        Row.SetValues(_username, _password, _permissions)
        Return Row
    End Function

    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property lastname As String
        Get
            Return _lastname
        End Get
        Set(value As String)
            _lastname = value
        End Set
    End Property

    Public Property company As String
        Get
            Return _company
        End Get
        Set(value As String)
            _company = value
        End Set
    End Property

    Public Property title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Public Property fax As String
        Get
            Return _fax
        End Get
        Set(value As String)
            _fax = value
        End Set
    End Property
End Class

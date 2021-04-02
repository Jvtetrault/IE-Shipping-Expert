Public Class Contact
    Friend _client As String
    Friend _name As String
    Friend _phone As String
    Friend _mobile As String
    Friend _fax As String
    Friend _email As String
    Friend _title As String

    Public Sub New(ByVal client As String, Optional ByVal name As String = "", Optional ByVal phone As String = "", Optional ByVal mobile As String = "", Optional ByVal email As String = "", Optional ByVal fax As String = "", Optional ByVal title As String = "")
        _client = client
        _name = name
        _phone = phone
        _mobile = mobile
        _email = email
        _fax = fax
        _title = title
    End Sub

    Public Property Client() As String
        Get
            Return _client
        End Get
        Set(value As String)
            _client = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Public Property Mobile() As String
        Get
            Return _mobile
        End Get
        Set(value As String)
            _mobile = value
        End Set
    End Property

    Public Property Fax() As String
        Get
            Return _fax
        End Get
        Set(value As String)
            _fax = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property
End Class

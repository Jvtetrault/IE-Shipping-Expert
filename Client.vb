Public Class Client
    Friend _name As String
    Friend _taxnumber As String
    Friend _country As String
    Friend _region As String
    Friend _postal As String
    Friend _street As String
    Friend _AccountNumber As String


    Public Sub New(ByVal name As String, Optional ByVal country As String = "", Optional ByVal region As String = "", Optional ByVal postal As String = "", Optional ByVal street As String = "", Optional ByVal AccountNumber As String = "", Optional ByVal taxnumber As String = "")
        _name = name
        _taxnumber = taxnumber
        _country = country
        _region = region
        _postal = postal
        _street = street
        _AccountNumber = AccountNumber
    End Sub

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property TaxNumber() As String
        Get
            Return _taxnumber
        End Get
        Set(value As String)
            _taxnumber = value
        End Set
    End Property

    Public Property Country() As String
        Get
            Return _country
        End Get
        Set(value As String)
            _country = value
        End Set
    End Property

    Public Property Region() As String
        Get
            Return _region
        End Get
        Set(value As String)
            _region = value
        End Set
    End Property

    Public Property Postal() As String
        Get
            Return _postal
        End Get
        Set(value As String)
            _postal = value
        End Set
    End Property

    Public Property Street As String
        Get
            Return _street
        End Get
        Set(value As String)
            _street = value
        End Set
    End Property

    Public Property AccountNumber() As String
        Get
            Return _AccountNumber
        End Get
        Set(value As String)
            _AccountNumber = value
        End Set
    End Property
End Class

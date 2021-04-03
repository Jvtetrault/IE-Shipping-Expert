<Serializable> Public Class MaterialType
    Friend _materialnumber As String
    Friend _materialdescription As String
    Friend _commoditycode As String
    Friend _Price As String
    Friend _currency As String
    Friend _countryoforigin As String
    Friend _vendor As Vendor

    Public Sub New(ByVal MaterialNumber As String, ByVal MaterialDescription As String, Optional ByVal CommodityCode As String = "", Optional ByVal Price As Double = 0, Optional ByVal CountryOfOrigin As String = "", Optional ByVal Currency As String = "CAD")
        _materialnumber = MaterialNumber
        _materialdescription = MaterialDescription
        _commoditycode = CommodityCode
        _Price = Price
        _countryoforigin = CountryOfOrigin
    End Sub

    Public Property CountryOfOrigin As String
        Get
            Return _countryoforigin
        End Get
        Set(value As String)
            _countryoforigin = value
        End Set
    End Property

    Public Property MatVendor As Vendor
        Get
            Return _vendor
        End Get
        Set(value As Vendor)
            _vendor = value
        End Set
    End Property
    Public Property Currency()
        Get
            Return _currency
        End Get
        Set(value)
            _currency = value
        End Set
    End Property
    Public Property Price() As Double
        Get
            Return _Price
        End Get
        Set(value As Double)
            _Price = value
        End Set
    End Property

    Public Property CommodityCode() As String
        Get
            Return _commoditycode
        End Get
        Set(value As String)
            _commoditycode = value
        End Set
    End Property

    Public Property MaterialDescription() As String
        Get
            Return _materialdescription
        End Get
        Set(value As String)
            _materialdescription = value
        End Set
    End Property

    Public Property MaterialNumber() As String
        Get
            Return _materialnumber
        End Get
        Set(value As String)
            _materialnumber = value
        End Set
    End Property

    Public Function GenerateRow() As DataGridViewRow
        Dim row As New DataGridViewRow
        row.SetValues({_materialnumber, _materialdescription, FormatCurrency(_Price, 2), _currency, _commoditycode, _countryoforigin})
        Return row
    End Function
End Class



<Serializable> Public Class Vendor
    Friend _vendor As String
    Friend _ContactList As List(Of Contact)
    Friend _primary As Contact


    Public Sub New(ByVal vendor As String)
        _vendor = vendor
    End Sub

    Public Sub NewPrimary(ByVal NewPrimary As Contact)
        For Each Item As Contact In _ContactList
            If Item.Primary = True Then
                Item.Primary = False
            End If
        Next
        NewPrimary.Primary = True
        _primary = NewPrimary
        _ContactList.Add(_primary)
    End Sub

    Public Property ContactList As List(Of Contact)
        Get
            Return _ContactList
        End Get
        Set(value As List(Of Contact))
            _ContactList = value
        End Set
    End Property

    Public Property Primary As Contact
        Get
            Return _primary
        End Get
        Set(value As Contact)
            _primary = value
        End Set
    End Property

    Public Property vendor() As String
        Get
            Return _vendor
        End Get
        Set(value As String)
            _vendor = value
        End Set
    End Property
End Class

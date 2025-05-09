Public Class Usuario
    Private _Id As String
    Private _NyA As String
    Private _Telefono As String

    Public Sub New(idd As String, nyaa As String, telefon As String)
        Id = idd
        Nya = nyaa
        Telefono = telefon
    End Sub
    Public Property Id As String
        Get
            Return _Id
        End Get
        Set(value As String)
            _Id = value
        End Set
    End Property

    Public Property Nya As String
        Get
            Return _NyA
        End Get
        Set(value As String)
            _NyA = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property


End Class

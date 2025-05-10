Public Class cuenta
    Private _numero As Integer
    Private _nombre As String
    Private _tipo As String
    Private _descubierto As Integer
    Private Const maxdes = 50000
    Private _dinero As Integer
    Private aux As Integer

    Sub New(numer As Integer, nombr As String, tip As String, descubiert As Integer)
        numero = numer
        nombre = nombr
        tipo = tip
        descubierto = descubiert
        _dinero = 0
    End Sub

    Public Property tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            If UCase(value) = "CC" Or UCase(value) = "CA" Then
                _tipo = UCase(value)
            Else
                _tipo = "CA"
            End If
        End Set
    End Property
    Public ReadOnly Property dinero
        Get
            Return _dinero
        End Get
    End Property



    Public Property Nombre As String
        Get
            Return Left(_nombre, 5)
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property numero As Integer
        Get
            Return _numero
        End Get
        Set(value As Integer)
            _numero = value
        End Set
    End Property

    Public Property descubierto As Integer
        Get
            Return _descubierto
        End Get
        Set(value As Integer)
            If value <= maxdes Then
                _descubierto = value
            End If
        End Set
    End Property

    'metodos
    Sub deposito(valor As Integer)
        _dinero += valor
        Form1.lbl_valor.Text = Str(_dinero)
    End Sub
    Function extraccion(valor As Integer) As Boolean
        If _dinero + _descubierto >= valor Then
            _dinero -= valor
            Return True
        Else
            Return False
        End If
    End Function
    Function extraccion_sobrecarga() As Boolean
        If _dinero < 0 Then
            Return False
        Else
            _dinero = 0
            Return True
        End If
    End Function
End Class

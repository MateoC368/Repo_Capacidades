Public Class AIRE
    ' Variables 
    Private _Marca As String
    Private _Frigorias As Integer
    Private _Split As Boolean
    Private _Pais As String
    Private _FrioSolo As Boolean
    Private _Temperatura As Integer
    Private _Encendido As Boolean
    Private _Modelo As String
    Private Const tempmin = 18
    Private Const tempmax = 30
    Private Const tempmaxfs = 24

    Public Sub New(mar As String, frigor As Integer, spli As Boolean, pai As String, friosol As Boolean)
        Marca = mar
        Frigorias = frigor
        Split = spli
        Pais = pai
        FrioSolo = friosol
        Encendido = False
        Temperatura = 24

    End Sub

    ' Propiedades 
    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(value As String)
            _Marca = value
        End Set
    End Property

    Public Property Frigorias As Integer
        Get
            Return _Frigorias
        End Get
        Set(value As Integer)
            _Frigorias = value
        End Set
    End Property

    Public Property Split As Boolean
        Get
            Return _Split
        End Get
        Set(value As Boolean)
            _Split = value
        End Set
    End Property

    Public Property Pais As String
        Get
            Return _Pais.ToUpper()
        End Get
        Set(value As String)
            _Pais = value.ToUpper()
        End Set
    End Property

    Public Property FrioSolo As Boolean
        Get
            Return _FrioSolo
        End Get
        Set(value As Boolean)
            _FrioSolo = value
        End Set
    End Property

    Public Property Temperatura As Integer
        Get
            Return _Temperatura
        End Get
        Set(value As Integer)
            _Temperatura = value
        End Set
    End Property

    Public Property Encendido As Boolean
        Get
            Return _Encendido
        End Get
        Set(value As Boolean)
            _Encendido = value
        End Set
    End Property

    Public ReadOnly Property Modelo As String
        Get
            _Modelo += Left(Marca, 3)
            _Modelo += Str(Frigorias)
            _Modelo += Left(Pais, 3)
            If FrioSolo = True Then
                _Modelo += "FS"
            Else
                _Modelo += "FC"
            End If
            If Split = True Then
                _Modelo += "/S"
            End If

            Return UCase(_Modelo)
        End Get
    End Property

    'Clases
    Function SUBIR(value As Integer) As Integer
        If Encendido Then
            If FrioSolo Then
                If Temperatura + value <= (tempmaxfs - Split * 1) Then
                    Temperatura += value

                End If
            Else
                If Temperatura + value <= (tempmax - Split * 1) Then
                    Temperatura += value

                End If
            End If
        End If
        Return Temperatura
    End Function
    Function SUBIR() As Integer
        If Encendido Then
            If FrioSolo Then
                Temperatura = 24
            Else
                Temperatura = 30
            End If
            Temperatura -= (Split * 1)

        End If
        Return Temperatura
    End Function
    Function BAJAR(value As Integer) As Integer
        If Encendido Then
            If Temperatura - value >= (tempmin + Split * 1) Then
                Temperatura -= value
            End If
        End If
        Return Temperatura
    End Function
    Function BAJAR() As Integer
        If Encendido Then
            Temperatura = 18
            Temperatura += (Split * 1)
        End If
        Return Temperatura
    End Function
    Function POWER() As Integer
        Encendido = Not Encendido
        Return Encendido
    End Function
End Class



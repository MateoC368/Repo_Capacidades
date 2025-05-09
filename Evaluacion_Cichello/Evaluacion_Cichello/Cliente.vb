Public Class Cliente
    Inherits Usuario
    Private _Tipo As String
    Private _Saldo As Integer
    Public Sub New(idd As String, nyaa As String, telefon As String, tip As String)
        MyBase.New(idd, nyaa, telefon)
        Tipo = tip
        _Saldo = 0
    End Sub
    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property

    Public ReadOnly Property Saldo As Integer
        Get
            Return _Saldo
        End Get
    End Property

    Public Sub depositar(dinero As Integer)
        _Saldo += dinero
    End Sub
    Public Sub extraer(dinero As Integer)
        If Tipo = "CA" Then
            If Saldo - dinero < 0 Then
                _Saldo = 0
            Else
                _Saldo -= dinero
            End If
        Else
            _Saldo -= dinero
        End If

    End Sub

End Class

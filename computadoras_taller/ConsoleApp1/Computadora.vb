Public Class Computadora

    Public Const Intel As Short = 10000
    Public Const AMD As Short = 9000
    Public Const GigaRAM As Short = 50
    Public Const GigaDisco As Short = 5
    Public Const Pulgada As Short = 30
    Public Const HoraBat As Short = 5
    Public Const GigaVideo As Short = 10
    Public Costo As Integer
    Private _Modelo As String
    Private _CPU As Char
    Private _Memoria As Integer
    Private _Disco As Integer

    Public Sub New(model As String, cp As Char, memori As Integer, disc As Integer)
        Modelo = model
        CPU = cp
        Memoria = memori
        Disco = disc
    End Sub

    Public Property Modelo As String
        Get
            Return _Modelo
        End Get
        Set(value As String)
            If value.Length <= 10 Then
                _Modelo = value
            End If
        End Set
    End Property

    ' Propiedad CPU (solo 'I' para INTEL o 'A' para AMD)
    Public Property CPU As Char
        Get
            Return _CPU
        End Get
        Set(value As Char)
            If UCase(value) = "I" Or UCase(value) = "A" Then
                _CPU = value
            End If
        End Set
    End Property

    ' Propiedad Memoria (entre 8 y 64 GB)
    Public Property Memoria As Integer
        Get
            Return _Memoria
        End Get
        Set(value As Integer)
            If value >= 8 And value <= 64 Then
                _Memoria = value
            End If
        End Set
    End Property

    ' Propiedad Disco (Capacidad del disco rígido en GB)
    Public Property Disco As Integer
        Get
            Return _Disco
        End Get
        Set(value As Integer)
            If value > 0 Then
                _Disco = value
            End If
        End Set
    End Property

    Public Overridable Function Precio() As Integer
        Costo = 0
        If CPU = "I" Then
            Costo += Intel
        Else
            Costo += AMD
        End If
        Costo += Memoria * GigaRAM
        Costo += Disco * Disco
        Return Costo
    End Function

End Class

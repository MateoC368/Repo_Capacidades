Public Class Notebook
    Inherits Computadora
    Private _Pantalla As Short
    Private _Bateria As Short



    Public Sub New(model As String, cp As Char, memori As Integer, disc As Integer, panta As Short, bate As Short)
        MyBase.New(model, cp, memori, disc)
        pantalla = panta
        bateria = bate

    End Sub

    Public Property pantalla
        Get
            Return _Pantalla
        End Get
        Set(value)
            _Pantalla = value
        End Set
    End Property
    Public Property bateria
        Get
            Return _Bateria
        End Get
        Set(value)
            _Bateria = value
        End Set
    End Property

    Public Overrides Function Precio() As Integer
        Costo = 0
        If CPU = "I" Then
            Costo += Intel
        Else
            Costo += AMD
        End If
        Costo += Memoria * GigaRAM
        Costo += Disco * Disco

        Costo += pantalla * Pulgada
        Costo += bateria * HoraBat
        Return Costo
    End Function
End Class

Public Class notegamer
    Inherits Computadora
    Private _MemVideo As Short

    Public Sub New(model As String, cp As Char, memori As Integer, disc As Integer, memvi As Short)
        MyBase.New(model, cp, memori, disc)
        memvideo = memvi
    End Sub
    Public Property memvideo()
        Get
            Return _MemVideo
        End Get
        Set(value)
            _MemVideo = value
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

        Costo += memvideo * GigaVideo
        Return Costo
    End Function
End Class

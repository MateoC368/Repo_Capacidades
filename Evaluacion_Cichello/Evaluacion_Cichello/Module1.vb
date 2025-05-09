Module Module1
    Dim clien(-1) As Cliente
    Dim arch_clientes As New IO.StreamReader("T1_CLIENTES.TXT.TXT")
    Dim arch_movi As New IO.StreamReader("T1_MOVIM.TXT.TXT")
    Dim linea As String
    Dim idsperdi As Integer = 0

    Dim encontrado As Integer

    Sub lectura_clientes()
        Do While Not arch_clientes.EndOfStream
            ReDim Preserve clien(clien.Length)
            clien(clien.Length - 1) = New Cliente(arch_clientes.ReadLine(), arch_clientes.ReadLine(), arch_clientes.ReadLine(), arch_clientes.ReadLine())
        Loop
    End Sub
    Sub proceso_movimientos()
        Do While Not arch_movi.EndOfStream
            encontrado = -1
            linea = arch_movi.ReadLine()
            For i As Integer = 0 To clien.Length - 1
                If clien(i).Id = Mid(linea, 9, linea.Length) Then
                    encontrado = i
                End If
            Next
            If encontrado >= 0 Then
                linea = arch_movi.ReadLine()
                If linea = "D" Then
                    clien(encontrado).depositar(arch_movi.ReadLine())
                Else
                    clien(encontrado).extraer(arch_movi.ReadLine())
                End If
            Else
                idsperdi += 1
                linea = arch_movi.ReadLine()
                linea = arch_movi.ReadLine()
            End If
        Loop
    End Sub
    Sub mostrar_resultados()
        For i As Integer = 0 To clien.Length - 1
            Console.WriteLine($"ID: {clien(i).Id} Nombre y Apellido: {clien(i).Nya} Telefono: {clien(i).Telefono} Saldo final: {clien(i).Saldo}")
            Console.WriteLine("")
        Next
    End Sub
    Sub Main()
        lectura_clientes()
        proceso_movimientos()
        mostrar_resultados()

        Console.ReadKey()
    End Sub

End Module

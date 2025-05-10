Module Module1
    Dim opcion As String = 1
    Dim computador(-1) As String
    Sub pepe()
        Console.WriteLine("ingrese el modelo, maximo 10 caracteres")
        opcion = Convert.ToString(Console.ReadLine)
        If Len(opcion) > 10 Then
            Do While Len(opcion) > 10
                Console.WriteLine("maximos caracteres ingresados, intente nuevamente")
                Console.WriteLine("ingrese el modelo, maximo 10 caracteres")
                opcion = Convert.ToString(Console.ReadLine())
            Loop
        End If
        ReDim Preserve computador(computador.Length)
        computador(computador.Length - 1) = opcion

        Console.WriteLine("Perfecto! Ahora ingrese el CPU de su futuro dispositivo, ingrese 'I' para intel o 'A' para AMD")
        opcion = Convert.ToChar(Console.ReadLine())
        If opcion <> "I" And opcion <> "i" And opcion <> "A" And opcion <> "a" Then
            Do While opcion <> "I" And opcion <> "i" And opcion <> "A" And opcion <> "a"
                Console.WriteLine("ingrese 'I' para intel o 'A' para AMD")
                opcion = Convert.ToChar(Console.ReadLine())
            Loop
        End If
        ReDim Preserve computador(computador.Length)
        computador(computador.Length - 1) = opcion

        Console.WriteLine("Bien, ahora la memoria ram, ingrese entre 8 a 64 (gigas)")
        opcion = Convert.ToInt32(Console.ReadLine())
        If opcion < 8 Or opcion > 64 Then
            Do While opcion < 8 Or opcion > 64
                Console.WriteLine("ingrese entre 8 a 64 (gigas)")
                opcion = Convert.ToInt32(Console.ReadLine())
            Loop
        End If
        ReDim Preserve computador(computador.Length)
        computador(computador.Length - 1) = Str(opcion)

        Console.WriteLine("perfecto, ahora ingrese la capacidad del disco rigido, valor numerico")
        opcion = Int(Console.ReadLine)
        ReDim Preserve computador(computador.Length)
        computador(computador.Length - 1) = Str(opcion)
    End Sub
    Sub Main()
        Dim compu As Computadora
        Do While opcion <> 0
            ReDim computador(-1)
            Console.WriteLine("ingrese la opcion que desee")
            Console.WriteLine("1-Fabricar Computadora")
            Console.WriteLine("2-Fabricar Notebook")
            Console.WriteLine("3-Fabricar Notebook Gamer")
            Console.WriteLine("0-Salir")
            opcion = Console.ReadLine()
            Console.WriteLine("")
            Select Case opcion
                Case "1"
                    Console.WriteLine("ingresó la opcion computadora, a continuacion responda como se le indica")
                    pepe()
                    compu = New Computadora(computador(0), computador(1), Int(computador(2)), Int(computador(3)))
                    Console.WriteLine($"Todo listo! El precio total es de {compu.Precio()}")

                Case "2"
                    Console.WriteLine("ingresó la opcion notebook, a continuacion responda como se le indica")
                    pepe()
                    Console.WriteLine("OK, ingrese la medida de la pantalla en pulgadas:")
                    opcion = Convert.ToInt32(Console.ReadLine())
                    If opcion <= 0 Then
                        Do While opcion <= 0
                            Console.WriteLine("ingrese un valor mayor a 0")
                            opcion = Convert.ToInt32(Console.ReadLine())
                        Loop
                    End If
                    ReDim Preserve computador(computador.Length)
                    computador(computador.Length - 1) = Str(opcion)

                    Console.WriteLine("ahora ingrese la autonomia de la bateria en horas")
                    opcion = Convert.ToInt32(Console.ReadLine())
                    If opcion <= 0 Then
                        Do While opcion <= 0
                            Console.WriteLine("ingrese un valor mayor a 0")
                            opcion = Convert.ToInt32(Console.ReadLine())
                        Loop
                    End If
                    ReDim Preserve computador(computador.Length)
                    computador(computador.Length - 1) = Str(opcion)
                    compu = New Notebook(computador(0), computador(1), Int(computador(2)), Int(computador(3)), Short.Parse(computador(4)), Short.Parse(computador(5)))
                    Console.WriteLine($"Todo listo! El precio total es de {compu.Precio()}")

                Case "3"
                    Console.WriteLine("ingresó la opcion notebook gamer, a continuacion responda como se le indica")
                    pepe()
                    Console.WriteLine("De acuerdo, ahora ingrese la memoria de video dedicada en GB")
                    opcion = Convert.ToInt32(Console.ReadLine())
                    If opcion <= 0 Then
                        Do While opcion <= 0
                            Console.WriteLine("ingrese un valor mayor a 0")
                            opcion = Convert.ToInt32(Console.ReadLine())
                        Loop
                    End If
                    ReDim Preserve computador(computador.Length)
                    computador(computador.Length - 1) = Str(opcion)
                    compu = New notegamer(computador(0), computador(1), Int(computador(2)), Int(computador(3)), Short.Parse(computador(4)))
                    Console.WriteLine($"Todo listo! El precio total es de {compu.Precio()}")

                Case "0"
                    End
                Case Else
                    Console.WriteLine("No ingresó ninguna opcion valida")
            End Select
        Loop

        Console.ReadKey()
    End Sub
End Module

Module OrdenarVector

    Sub Main()
        Do
            Console.Clear()
            Console.WriteLine("Selecione el metodo de ordenamiento del vector:")
            Console.WriteLine("1) Desordenado")
            Console.WriteLine("2) Desendente")
            Console.WriteLine("3) Asendente")

            Dim Opcion As Byte
            Opcion = Console.ReadLine

            Dim VectorDesordenado(10) As Byte

            LlenarVector(VectorDesordenado)

            Select Case Opcion

                Case 1
                    ImprimirVector(VectorDesordenado)

                Case 2

                Case 3

            End Select
            Console.WriteLine()
            Console.WriteLine("Si desea salir del programa presione la tecja <Esc>:")
        Loop Until Console.ReadKey.Key = ConsoleKey.Escape

    End Sub
    Public Sub LlenarVector(ByRef vector As Byte())
        Dim aleatorio As New Random
        For i As Byte = 0 To vector.GetUpperBound(0)
            vector(i) = aleatorio.Next(0, 100)
        Next
    End Sub
    Public Sub ImprimirVector(ByRef vector As Byte())
        For i As Byte = 0 To vector.GetUpperBound(0)
            If i = vector.GetUpperBound(0) Then
                Console.WriteLine(vector(i))
            Else
                Console.Write(vector(i) & " - ")
            End If
        Next
    End Sub
End Module

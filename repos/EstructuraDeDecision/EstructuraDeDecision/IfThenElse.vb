Module IfThenElse

    Sub Main()
        'Declaramos una variable para almacenar el nombre del usurio
        Dim nombreUsuario As String
        'Declaramos una variable para almacenar la fecha y hora del sistema
        Dim fechaHoraActual As DateTime
        'Solicitamos al usuatio que ingrese el nombre (que despues utilizaremos en el mensaje)
        Console.Write("Hola , por favoringrese su nombre de usuario...")
        'Capturamos el ingreso del teclado y lo almacenamos en la variable del nombreUsuario
        nombreUsuario = Console.ReadLine
        'Almacenamosen nuestra variable la fecha y hora actual del sistema 
        fechaHoraActual = Now()

        'Iniciamos el bloque de decisiones para evaluar evaluar la hora actual 
        If fechaHoraActual.Hour < 12 Then
            Console.WriteLine($"Bienvenido, buen dia {nombreUsuario}")
        ElseIf fechaHoraActual.Hour >= 12 And fechaHoraActual.Hour < 18 Then
            Console.WriteLine($"Bienvenido, buenas tardes {nombreUsuario}")
        Else
            Console.WriteLine($"Bienvenido, buenas noches {nombreUsuario}")
        End If

        'Solicitamos al sistema que espere hasta que el usurio presione la tecla <Enter> visualización
        Console.Read()
    End Sub

End Module

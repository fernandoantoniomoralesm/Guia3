Module main

	Sub main()

		Dim operacion As Integer = 0
		Dim valor1 As Nullable(Of Double) = Nothing
		Dim valor As Nullable(Of Double) = Nothing

		Do While operacion >= 0 And operacion < 6
			Console.WriteLine("¿Qué operación deseas realizar? Presiona el numero que corresponda y luego Enter.")
			Console.WriteLine("1.sumar, 2.restar, 3.multiplicar, 4.dividir, 5.todas")
			operacion = Console.ReadLine()
			Exit Do
		Loop



		While operacion > 0 And operacion < 6
			Console.WriteLine("Ingrese el primero numero: ")
			valor = Console.ReadLine
			Console.WriteLine("Ingrese el segundo numero: ")
			valor1 = Console.ReadLine
			Select Case operacion


				Case 1
					Console.WriteLine("Si funciona este bucle")
					Dim SUMAR As Calculadora = New Calculadora
					SUMAR.valor = valor
					SUMAR.valor1 = valor1

					Console.WriteLine("El resultado es: " & )
				Case 2
					Dim resta As Calculadora = New Calculadora
					resta.valor = valor
					resta.valor1 = valor1
					resta.restar()
				Case 3
					Dim multiplicacion As Calculadora = New Calculadora
					multiplicacion.valor = valor
					multiplicacion.valor1 = valor1
				Case 4
					Dim dividir As Calculadora = New Calculadora
					dividir.valor = valor
					dividir.valor1 = valor1
				Case 5
					Dim todas As Calculadora = New Calculadora
					todas.valor = valor
					todas.valor1 = valor1
			End Select

			Console.WriteLine("Presiona Enter para salir del programa...")
			Console.ReadLine()
		End While
	End Sub

	Public Class Calculadora
		Public valor As Integer = 0
		Public valor1 As Integer = 0
		Public resultado As Integer = 0
		Public resultadosuma As Integer = 0
		Public resultadoresta As Integer = 0
		Public resultadomulti As Integer = 0
		Public resultadodividir As Integer = 0
		Public Function Sumar(valor, valor1) As Integer
			Sumar = valor + valor1
			Console.WriteLine("El resultado es: " & Sumar)
			Console.ReadLine()
			Return Sumar
		End Function
		Sub restar()
			resultado = valor - valor1
			Console.WriteLine("El resultado es: " & resultado)
			Console.ReadLine()
		End Sub
		Sub multiplicar()
			resultado = valor * valor1
			Console.WriteLine("El resultado es: " & resultado)
			Console.ReadLine()
		End Sub
		Sub dividir()
			resultado = valor / valor1
			Console.WriteLine("El resultado es: " & resultado)
			Console.ReadLine()
		End Sub
		Sub todas()
			resultadosuma = valor + valor1
			resultadoresta = valor - valor1
			resultadomulti = valor * valor1
			resultadodividir = valor / valor1
			Console.WriteLine("El resultado de la suma es : " & resultadosuma)
			Console.WriteLine("El resultado de la resta es : " & resultadoresta)
			Console.WriteLine("El resultado de la multiplicacion es : " & resultadomulti)
			Console.WriteLine("El resultado de la division es : " & resultadodividir)
			Console.ReadLine()
		End Sub
		'...
	End Class
End Module
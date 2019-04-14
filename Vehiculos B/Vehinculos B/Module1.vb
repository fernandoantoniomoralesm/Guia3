Module Module1



	Class carro



		Public marca As String

		Public modelo As Integer

		Public ano As Integer

		Public color As String
		Public Sub mostrar()

			Console.WriteLine("Marca: " & marca)

			Console.WriteLine("Modelo: " & modelo)

			Console.WriteLine("Año: " & ano)

			Console.WriteLine("Color: " & color)

			Console.ReadLine()
		End Sub



		Public Property llamada() As String

			Get


				Return marca

				Return modelo

				Return ano

				Return color

			End Get

			Set(ByVal Valor As String)

				Me.marca = Valor

				Me.modelo = Valor

				Me.ano = Valor

				Me.color = Valor

			End Set

		End Property

	End Class

	Sub main()

		Dim carro1 As carro = New carro()

		carro1.marca = "Mazda"

		carro1.modelo = 123

		carro1.ano = 2000

		carro1.color = "Rojo"

		Call carro1.mostrar()

		Dim carro2 As carro = New carro()

		carro2.marca = "Honda"

		carro2.modelo = 123

		carro2.ano = 2010

		carro2.color = "Amarrillo"

		Call carro2.mostrar()
		Dim carro3 As carro = New carro()

		carro3.marca = "Toyota"

		carro3.modelo = 123

		carro3.ano = 2012

		carro3.color = "Negro"

		Call carro3.mostrar()
	End Sub
End Module

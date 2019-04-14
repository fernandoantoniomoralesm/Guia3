Module Module1

	Class carro

		Public marca As String
		Public modelo As Integer
		Public ano As Integer
		Public color As String

		Public Property llamada() As String
		Get
			'Se devuelve el valor almacenado en el campo
			Return marca
			Return modelo
			Return ano
			Return color
		End Get
		Set(ByVal Valor As String)
			'Se guarda un valor en el campo
			marca = Valor
			modelo = Valor
			ano = Valor
			color = Valor
		End Set
	End Property
	End Class
	Sub main()
		Dim carro1 As carro = New carro()
		carro1.marca = "Mazda"
		carro1.modelo = 123
		carro1.ano = 2000
		carro1.color = "Rojo"
		Console.WriteLine("Marca: " & carro1.marca)
		Console.WriteLine("Modelo: " & carro1.modelo)
		Console.WriteLine("Año: " & carro1.ano)
		Console.WriteLine("Color: " & carro1.color)
		Console.ReadLine()
		Dim carro2 As carro = New carro()
		carro1.marca = "Honda"
		carro1.modelo = 123
		carro1.ano = 2010
		carro1.color = "Amarrillo"
		Console.WriteLine("Marca: " & carro1.marca)
		Console.WriteLine("Modelo: " & carro1.modelo)
		Console.WriteLine("Año: " & carro1.ano)
		Console.WriteLine("Color: " & carro1.color)
		Console.ReadLine()
		Dim carro3 As carro = New carro()
		carro1.marca = "Toyota"
		carro1.modelo = 123
		carro1.ano = 2012
		carro1.color = "Negro"
		Console.WriteLine("Marca: " & carro1.marca)
		Console.WriteLine("Modelo: " & carro1.modelo)
		Console.WriteLine("Año: " & carro1.ano)
		Console.WriteLine("Color: " & carro1.color)
		Console.ReadLine()
	End Sub



End Module


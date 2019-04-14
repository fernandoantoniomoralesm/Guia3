Module Module1

	Sub vehiculo()
		Dim carro1 As carro = New carro
		carro1.nombre = "Carro1"
		carro1.marca = "toyota"
		carro1.modelo = "12221"
		carro1.ano = "2000"
		carro1.color = "blanco"
		carro1.imprimir()
		Dim carro2 As carro = New carro
		carro2.nombre = "Carro2"
		carro2.marca = "mazda"
		carro2.modelo = "2222"
		carro2.ano = "2002"
		carro2.color = "azul"
		carro2.imprimir()
		Dim carro3 As carro = New carro
		carro3.nombre = "Carro3"
		carro3.marca = "nissan"
		carro3.modelo = "12230"
		carro3.ano = "2012"
		carro3.color = "rojo"
		carro3.imprimir()

	End Sub

	Public Class carro
		Public nombre As String
		Public marca As String
		Public modelo As Integer
		Public ano As Integer
		Public color As String
		Sub imprimir()
			Console.WriteLine("" & nombre)
			Console.WriteLine("marca " & marca)
			Console.WriteLine("modelo " & modelo)
			Console.WriteLine("ano " & ano)
			Console.WriteLine("Color " & color)
			Console.ReadLine()
		End Sub
	End Class

End Module

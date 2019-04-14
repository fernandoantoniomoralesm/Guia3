Module Module1

	Sub Main()
		Dim saludar As Holamundo = New Holamundo
		saludar.saludo()
	End Sub
	Public Class Holamundo
		Public Sub saludo()
			Console.WriteLine("HOLA MUNDO")
			Console.ReadLine()
		End Sub
	End Class
End Module

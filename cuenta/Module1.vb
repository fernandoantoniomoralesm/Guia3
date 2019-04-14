Module Module1

	Sub Main()
		Dim operacion As Integer
		Dim depositar As Double
		Dim numerocuenta As Double
		Dim retirar As Double

		Do While operacion >= 0 And operacion < 4
			Console.WriteLine("¿Qué operación deseas realizar?")
			Console.WriteLine("Presiona el numero que corresponda y luego Enter.Si desea salir presione cualquier otro numero")
			Console.WriteLine("1.Retirar, 2.Depositar, 3.Mostrar balance")
			operacion = Console.ReadLine()

			Select Case operacion
			Case 1
				Console.WriteLine("Ingrese su numero de cuenta: ")
				numerocuenta = Console.ReadLine()

				Dim cuenta As cuentabancaria = New cuentabancaria
				cuenta.numerocuenta = numerocuenta
				cuenta.retira = retirar
				cuenta.retirar()
			Case 2
				Console.WriteLine("Ingrese su numero de cuenta: ")
				numerocuenta = Console.ReadLine()

				Dim cuenta As cuentabancaria = New cuentabancaria
				cuenta.numerocuenta = numerocuenta
				cuenta.retira = depositar
				cuenta.depositar()
			Case 3
				Console.WriteLine("Ingrese su numero de cuenta: ")
				numerocuenta = Console.ReadLine()

				Dim cuenta As cuentabancaria = New cuentabancaria
				cuenta.numerocuenta = numerocuenta
				cuenta.retira = retirar
				cuenta.mostrarbalance()

			End Select

		Loop





	End Sub

	Public Class cuentabancaria
		Public balance As Double
		Public numerocuenta As Double
		Public deposito As Double
		Public retira As Double
		Public resultadoretira As Double
		Public resultadodeposita As Double
		Public saldo As Double
		Sub depositar()
			Console.WriteLine("Cuanto desea depositar: ")
			deposito = Console.ReadLine()
			resultadodeposita = balance + deposito
			Console.WriteLine("Ha depositado con exito: " & deposito)
			Console.ReadLine()
		End Sub
		Sub retirar()
			Console.WriteLine("Cuanto desea retirar: ")
			retira = Console.ReadLine()
			resultadoretira = balance - deposito
			Console.WriteLine("Ha retirado con exito: " & retira)
			Console.ReadLine()
		End Sub
		Sub mostrarbalance()
			Console.WriteLine("Balance actual")
			Console.WriteLine("Ingresos: " & deposito)
			Console.WriteLine("Egresos: " & retira)
			saldo = resultadodeposita - resultadoretira
			Console.WriteLine("Saldo actual: " & saldo)
			Console.ReadLine()
		End Sub



	End Class
End Module


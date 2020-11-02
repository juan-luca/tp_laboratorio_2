using Entidades;
using System;

public static class Calculadora
{

	public static double Operar(Numero num1, Numero num2, string operador)
	{
		double tot = 0;
		
		switch (ValidarOperador(Convert.ToChar(operador)))
		{
			case "+":
				tot = num1 + num2;
				break;
			case "-":
				tot = num1 - num2;
				break;
			case "*":
				tot = num1 * num2;
				break;
			case "/":
				tot = num1 / num2;
				break;
		}
		return tot;
	}
	private static string ValidarOperador(char operador)
	{
		if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
		{
			operador = '+';
		}
		return operador.ToString();
	}

   
}

using Entidades;
using System;

public static class Calculadora
{
	/// <summary>
	/// Realiza operaciones entre 2 numeros
	/// </summary>
	/// <param name="num1"></param>
	/// <param name="num2"></param>
	/// <param name="operador"></param>
	/// <returns>Devuelve el resultado de la operacion</returns>
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
	/// <summary>
	/// Revisa que se este utilizando bien el operador 
	/// </summary>
	/// <param name="operador"></param>
	/// <returns>Devuelve el operador validado</returns>
	private static string ValidarOperador(char operador)
	{
		if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
		{
			operador = '+';
		}
		return operador.ToString();
	}

   
}

/*
 * Created by SharpDevelop.
 * User: pontonet
 * Date: 24/04/19
 * Time: 08:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula0009
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Calculadora simples
			
			/*double d;
			d = 12 - 3;//Soma
			d = 12 - 3;//Subtração
			d = 12 * 3;//Multiplicação
			d = 12 / 3;//Divisão
			
			Console.WriteLine(d); */
			
			double num1, num2;
			string tmp;
			
			Console.WriteLine("Digite um valor: ");
			tmp = Console.ReadLine();
			num1 = int.Parse(tmp);
			
			Console.WriteLine("Digite mais um valor: ");
			tmp = Console.ReadLine();
			num2 = int.Parse(tmp);
			
			double resultado;
			resultado = num1 + num2;
			
			Console.WriteLine("Soma: " + resultado);
			
			resultado = num1 - num2;
			Console.WriteLine("Subtração: " + resultado);
			
			resultado = num1 * num2;
			Console.WriteLine("Multiplicação: " + resultado);
			
			resultado = num1 / num2;
			Console.WriteLine("Divisção: " + resultado);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
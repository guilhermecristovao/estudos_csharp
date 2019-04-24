/*
 * Created by SharpDevelop.
 * User: pontonet
 * Date: 24/04/19
 * Time: 11:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula017
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Lendo o primeiro número
			int x, y = 0;
			Console.WriteLine("Digite um número: ");
			string str = Console.ReadLine();
			x = Convert.ToInt32(str);
			
			//Lendo o segundo número
			Console.WriteLine("Digite outro número: ");
			str = Console.ReadLine();
			y = Convert.ToInt32(str);
			
			bool r;
			
			//Operador relacional igual
			r = (x == y);
			Console.WriteLine("x == y = " + r);
			
			//Operador relacional diferente
			r = (x != y);
			Console.WriteLine("x != y = " + r);
			
			//Operador relacional maior
			r = (x > y);
			Console.WriteLine("x > y = " + r);
			
			//Operador relacional menor
			r = (x < y);
			Console.WriteLine("x < y = " + r);
			
			//Operador maior ou igual
			r = (x >= y);
			Console.WriteLine("x >= y = " + r);
			
			//Operador menor ou igual
			r = (x <= y);
			Console.WriteLine("x <= y = " + r);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
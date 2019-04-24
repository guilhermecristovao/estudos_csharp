/*
 * Created by SharpDevelop.
 * User: pontonet
 * Date: 24/04/19
 * Time: 12:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula020
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Conectivos lógicos
			int num = 0;
			Console.WriteLine("Informe um numero inteiro de 20 a 30.");
			num = Convert.ToInt32(Console.ReadLine());
			
			if(num >= 20 && num < 30)
			{
				Console.WriteLine("O número está no intervalo.");
			}
			else
			{
				Console.WriteLine("Número incorreto!");
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
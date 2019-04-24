/*
 * Created by SharpDevelop.
 * User: pontonet
 * Date: 24/04/19
 * Time: 11:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula014
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num = 0;
			Console.WriteLine("Digite um numero de 1 até 10: ");
			num = Convert.ToInt32(Console.ReadLine());
			
			if(num > 10){
				Console.WriteLine("Número maior do que 10.");
			}
			else{
				Console.WriteLine("Número é menor do que 10.");
				Console.BackgroundColor(red);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
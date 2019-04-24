/*
 * Created by SharpDevelop.
 * User: pontonet
 * Date: 24/04/19
 * Time: 09:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula0012
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num = 0;
			
			String texto="O número digitado é: ";
			
			Console.WriteLine("Digite um numero qualquer: ");
			num = Convert.ToInt32(Console.ReadLine());
			
			if(num > 0)
				Console.WriteLine(texto + "positivo");
			if(num <0)
				Console.WriteLine(texto + "negativo");

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
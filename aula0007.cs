/*
 * Created by SharpDevelop.
 * User: pontonet
 * Date: 24/04/19
 * Time: 08:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula0007
{
	class Program
	{
		public static void Main(string[] args)
		{
			string texto; //declarando a variavel que sera digitada
			
			Console.WriteLine("Digite algo"); //Imrpimindo msg na tela
			texto = Console.ReadLine(); //Lendo o que o usuario digitou
			Console.WriteLine("Você digitiou: " + texto); //Imprinindo o que o usuario digitou
			Console.WriteLine(texto); //Imprinindo somente a variavel
			
			
			Console.WriteLine("Pressione qualquer tecla para sair...");
			Console.ReadKey(true);

		}
	}
}
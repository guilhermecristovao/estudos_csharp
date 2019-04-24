/*
 * Created by SharpDevelop.
 * User: pontonet
 * Date: 24/04/19
 * Time: 11:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula018
{
	class Program
	{
		public static void Main(string[] args)
		{
			double nota1, nota2, nota3, nota4 = 0;
			string frase = "Digite a {0}º nota: ";
			
			Console.WriteLine(frase, 1);
			nota1 = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine(frase, 2);
			nota2 = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine(frase, 3);
			nota3 = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine(frase, 4);
			nota4 = Convert.ToDouble(Console.ReadLine());
			
			double total, media = 0;
			total = nota1 + nota2 + nota3 + nota4;
			media = total / 4;
			
			Console.WriteLine("A média foi: " + media);
			
			//Menor do que 4 - reprovado
			//Menor do que 7 - exame
			//Aprovado
			
			if(media < 4){
				Console.WriteLine("O aluno está reprovado.");
			}
			else
			{
				if(media < 7)
				{
					Console.WriteLine("O aluno está em exame.");
				}
				else
				{
					Console.WriteLine("O aluno foi aprovado.");
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
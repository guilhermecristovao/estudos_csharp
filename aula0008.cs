/*
 * Created by SharpDevelop.
 * User: pontonet
 * Date: 24/04/19
 * Time: 08:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula0008
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			string s = "1000";
			int i;
			
			i = int.Parse(s);
			int x = i + 10;
			
			Console.WriteLine(x);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
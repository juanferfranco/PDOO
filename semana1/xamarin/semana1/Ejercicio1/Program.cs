using System;

namespace Ejercicio1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a = 3;
			int b = a;
			b++;
			Console.WriteLine ("Valor de a: " + a);
			Console.WriteLine ("Valor de b: " + b);
			Console.ReadKey ();
		}
	}
}

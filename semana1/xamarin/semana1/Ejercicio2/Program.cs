using System;

namespace Ejercicio2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] a = new int[] { 1, 2, 3 };
			int[] b = a;
			b[0] = 17;
			Console.WriteLine(a[0]);
			Console.ReadLine ();
		}
	}
}

using System;

namespace Ejercicio3
{
	public class MyInt{
		public int MyValue;
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("ReturnValue() es: " + ReturnValue ());
			Console.WriteLine ("ReturnValue2() es: " + ReturnValue2 ());
			Console.ReadKey ();
		}

		public static int ReturnValue(){
			int x = new int ();
			x = 3;
			#pragma warning disable 219
			int y = new int ();
			#pragma warning restore 219
			y = x;
			y = 4;
			return x;
		}

		public static int ReturnValue2(){
			MyInt x = new MyInt ();
			x.MyValue = 3;
			MyInt y = new MyInt ();
			y = x;
			y.MyValue = 4;
			return x.MyValue;
		}
	}
}

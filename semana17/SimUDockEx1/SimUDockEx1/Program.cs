using System;

namespace SimUDockEx1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Duck mallard = new MallardDuck ();
			mallard.performQuack ();
			mallard.performFly ();
			Console.ReadKey ();
		}
	}
}




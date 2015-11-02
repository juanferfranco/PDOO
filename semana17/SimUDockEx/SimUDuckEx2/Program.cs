using System;

namespace SimUDuckEx2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Duck mallard = new MallardDuck ();
			mallard.performQuack ();
			mallard.performFly ();

			Duck model = new ModelDuck ();
			model.performFly ();
			model.FlyBehavior = new FlyRocketPowered ();
			model.performFly ();
			Console.ReadKey ();
		}
	}
}




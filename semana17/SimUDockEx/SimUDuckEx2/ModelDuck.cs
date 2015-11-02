using System;

namespace SimUDuckEx2
{
	public class ModelDuck: Duck
	{
		public ModelDuck ()
		{
			FlyBehavior = new FlyNoWay();
			QuackBehavior = new Quack();
		}

		public override void display(){
			Console.WriteLine ("I'm a model duck");
		}
	}
}


using System;

namespace SimUDuckEx2
{
	public class MallardDuck: Duck
	{
		public MallardDuck ()
		{
			QuackBehavior = new Quack ();
			FlyBehavior = new FlyWithWings ();
		}

		public override void display(){
			Console.WriteLine ("I'm a mallard duck");
		}
	}
}


using System;

namespace SimUDuckEx1
{
	public class Squeak:IQuackBehavior
	{
		public void quack(){
			Console.WriteLine ("Squeak");
		}
	}
}


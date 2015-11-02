using System;

namespace SimUDuckEx2
{
	public class Squeak:IQuackBehavior
	{
		public void quack(){
			Console.WriteLine ("Squeak");
		}
	}
}


using System;

namespace SimUDockEx1
{
	public class MuteQuack:IQuackBehavior
	{
		public void quack(){
			Console.WriteLine ("Silence");
		}
	}
}


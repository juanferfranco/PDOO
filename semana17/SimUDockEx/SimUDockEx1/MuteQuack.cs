using System;

namespace SimUDuckEx1
{
	public class MuteQuack:IQuackBehavior
	{
		public void quack(){
			Console.WriteLine ("Silence");
		}
	}
}


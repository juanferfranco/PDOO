using System;

namespace SimUDuckEx2
{
	public class MuteQuack:IQuackBehavior
	{
		public void quack(){
			Console.WriteLine ("Silence");
		}
	}
}


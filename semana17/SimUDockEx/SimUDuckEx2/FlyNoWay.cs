using System;

namespace SimUDuckEx2
{
	public class FlyNoWay:IFlyBehavior
	{
		public void fly(){
			Console.WriteLine ("I can't fly");
		}
	}
}


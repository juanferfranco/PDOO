using System;

namespace SimUDuckEx2
{
	public class FlyRocketPowered: IFlyBehavior
	{
		public void fly(){
			Console.WriteLine("I'm flying with a rocket");
		}
	}
}


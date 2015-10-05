using System;
using System.Threading;

namespace FinalVersion
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DogDoor door = new DogDoor();
			Remote remote = new Remote(door);

			Console.WriteLine("Fido barks to go outside...");
			remote.pressButton();

			Console.WriteLine("\nFido has gone outside...");

			Console.WriteLine("\nFido's all done...");

			Thread.Sleep (10000);

			Console.WriteLine("...but he's stuck outside!");

			Console.WriteLine("\nFido starts barking...");
			Console.WriteLine("...so Gina grabs the remote control.");
			remote.pressButton();

			Console.WriteLine("\nFido's back inside...");

			Console.ReadKey();
		}
	}
}

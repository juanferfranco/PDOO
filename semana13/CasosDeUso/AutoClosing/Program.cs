using System;

namespace AutoClosing
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

			Console.WriteLine("\nFido's back inside...");

			Console.ReadKey();
		}
	}
}

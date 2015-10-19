using System;
using System.Threading;

namespace AutomaticDoor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DogDoor door = new DogDoor();
			BarkRecognizer recognizer = new BarkRecognizer(door);
			//Remote remote = new Remote(door);

			Console.WriteLine("Fido barks to go outside...");
			recognizer.recognize("Woof");
			//remote.pressButton();

			Console.WriteLine("\nFido has gone outside...");

			Console.WriteLine("\nFido's all done...");

			Thread.Sleep (10000);

			Console.WriteLine("...but he's stuck outside!");

			Console.WriteLine("\nFido starts barking...");

			recognizer.recognize("Woof");
			//Console.WriteLine("...so Gina grabs the remote control.");
			//remote.pressButton();

			Console.WriteLine("\nFido's back inside...");

			Console.ReadKey();
		}
	}
}

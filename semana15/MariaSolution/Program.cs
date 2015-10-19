using System;
using System.Threading;

namespace MariaSolution
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DogDoor door = new DogDoor();
			door.addAllowedBark(new Bark("rowlf"));
			door.addAllowedBark(new Bark("rooowlf"));
			door.addAllowedBark(new Bark("rawlf"));
			door.addAllowedBark(new Bark("woof"));
			BarkRecognizer recognizer = new BarkRecognizer(door);
			//Remote remote = new Remote(door);

			Console.WriteLine("Bruece starts barking");
			recognizer.recognize(new Bark("Rowlf"));

			Console.WriteLine("\nBruce has gone outside...");

			Thread.Sleep (10000);
			Console.WriteLine("\nBruce's all done...");

			Console.WriteLine("...but he's stuck outside!");

			// Simulate the hardware hearing a bark (not Bruce!)
			Bark smallDogBark = new Bark("yip");
			Console.WriteLine("A small dog starts barking.");
			recognizer.recognize(smallDogBark);

			Thread.Sleep (5000);

			// Simulate the hardware hearing a bark again
			Console.WriteLine("\nBruce starts barking.");
			recognizer.recognize(new Bark("Rooowlf"));

			Console.WriteLine("\nBruce's back inside...");

			Console.ReadKey();
		}
	}
}

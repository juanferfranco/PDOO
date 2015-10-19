using System;

namespace requirementsChanged
{
	public class BarkRecognizer
	{
		private DogDoor door;

		public BarkRecognizer (DogDoor door)
		{
			this.door = door;
		}

		public void recognize(string bark){
			Console.WriteLine("   BarkRecognizer: Heard a '" + bark + "'");
			door.open ();
		}
	}
}


﻿using System;

namespace AutomaticDoor
{
	public class BarkRecognizer
	{
		private DogDoor door;

		public BarkRecognizer (DogDoor door)
		{
			this.door = door;
		}

		public void recognize(String bark){
			Console.WriteLine("   BarkRecognizer: Heard a '" + bark + "'");
			door.open ();
		}
	}
}


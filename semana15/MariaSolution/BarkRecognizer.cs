using System;
using System.Collections.Generic;

namespace MariaSolution
{
	public class BarkRecognizer
	{
		private DogDoor door;

		public BarkRecognizer (DogDoor door)
		{
			this.door = door;
		}

		public void recognize(Bark bark){
			Console.WriteLine("   BarkRecognizer: Heard a '" + bark.getSound() + "'");
			List<Bark> allowedBarks = door.getAllowedBarks ();
			foreach(Bark barkAllowed in allowedBarks){
				if (barkAllowed.equal (bark)) {
					door.open ();
					return;
				}
			}
			Console.WriteLine ("This dog is not allowed");
		}
	}
}

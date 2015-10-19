using System;

namespace MariaSolution
{
	public class Remote
	{
		private DogDoor door;
		public Remote(DogDoor door) {
			this.door = door;
		}

		public void pressButton() {
			Console.WriteLine("Pressing the remote control button...");
			if (door.isOpen()) {
				door.close();
			} else {
				door.open();
			}
		}
	}
}


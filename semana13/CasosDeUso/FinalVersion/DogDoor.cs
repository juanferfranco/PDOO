using System;

namespace FinalVersion
{
	public class DogDoor
	{

		private bool doorState;

		public DogDoor() {

			this.doorState = false;
		}

		public void open() {
			Console.WriteLine("The dog door opens.");
			doorState = true;
		}

		public void close() {
			Console.WriteLine("The dog door closes.");
			doorState = false;
		}

		public bool isOpen() {
			return doorState;                      
		} 
	}
}


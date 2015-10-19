using System;

namespace AutomaticDoor
{
	public class DogDoor
	{

		private bool doorState; //false: closed / true: opened
		private static System.Timers.Timer aTimer;

		public DogDoor() {

			this.doorState = false;
		}

		public void open() {
			Console.WriteLine("The dog door opens.");
			doorState = true;
			aTimer = new System.Timers.Timer();
			aTimer.Interval = 5000;
			aTimer.Elapsed += OnTimedEvent;
			aTimer.AutoReset = false;
			aTimer.Enabled = true;
		}

		public void close() {
			Console.WriteLine("The dog door closes.");
			doorState = false;
		}

		public bool isOpen() {
			return doorState;                      
		} 

		private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
		{
			close();
		}
	}
}


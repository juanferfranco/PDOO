using System;

namespace AutoClosing
{
	public class Remote
	{
		private DogDoor door;
		private static System.Timers.Timer aTimer;


		public Remote(DogDoor door) {
			this.door = door;
		}

		public void pressButton() {
			Console.WriteLine("Pressing the remote control button...");
			if (door.isOpen()) {
				door.close();
			} else {
				door.open();
				aTimer = new System.Timers.Timer();
				aTimer.Interval = 5000;
				aTimer.Elapsed += OnTimedEvent;
				aTimer.AutoReset = false;
				aTimer.Enabled = true;
			}
		}

		private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
		{
			door.close();
		}
	}
}


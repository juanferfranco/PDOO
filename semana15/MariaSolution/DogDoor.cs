using System;
using System.Collections.Generic;

namespace MariaSolution
{
	public class DogDoor
	{

		private bool doorState; //false: closed / true: opened
		private static System.Timers.Timer aTimer;
		private List<Bark> allowedBarks;

		public DogDoor() {

			this.doorState = false;
			this.allowedBarks = new List<Bark> ();
		}

		public void addAllowedBark(Bark bark){
			allowedBarks.Add (bark);
		
		}

		public List<Bark> getAllowedBarks(){
			return allowedBarks;
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

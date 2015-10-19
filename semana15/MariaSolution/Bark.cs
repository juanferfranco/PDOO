using System;

namespace MariaSolution
{
	public class Bark
	{
		private String sound;

		public Bark (String sound)
		{
			this.sound = sound.ToLower();
		}

		public String getSound(){
			return sound;
		}

		public bool equal(Bark bark){
			if (this.sound.ToLower() == bark.sound)
				return true;
			else
				return false;
		}
	}
}

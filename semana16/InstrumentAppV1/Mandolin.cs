using System;

namespace InstrumentAppV1
{
	public class Mandolin:Instrument
	{
		public Mandolin(String serialNumber, double price, MandolinSpec spec): base(serialNumber,
			price,spec){
		}
	}
}

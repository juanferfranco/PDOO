using System;

namespace InstrumentAppV2
{
	public class Instrument
	{
		private String serialNumber;
		private double price;
		private InstrumentSpec spec;


		public Instrument (String serialNumber, double price, InstrumentSpec spec)
		{
			this.serialNumber = serialNumber;
			this.price = price;
			this.spec = spec;
		}

		public string SerialNumber{
			get{ return serialNumber;}
			set{serialNumber = value;}
		}

		public double Price{
			get{ return price;}
			set{price = value;}
		}

		public InstrumentSpec Spec{
			get{ return spec;}
			set{spec = value;}
		}
	}
}


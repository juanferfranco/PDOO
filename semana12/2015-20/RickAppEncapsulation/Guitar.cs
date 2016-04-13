using System;

namespace RickAppEncapsulation
{
	public class Guitar
	{
		private string serialNumber;
		private double price;
		private GuitarSpec guitarSpec;

		public Guitar(string serialNumber, double price,
			Builder builder, string model, Typeg type,
			Wood backWood, Wood topWood) {
			this.serialNumber = serialNumber;
			this.price = price;
			this.guitarSpec = new GuitarSpec (builder, model, type, backWood, topWood);
		}

		public string SerialNumber{
			get{ return serialNumber;}
			set{serialNumber = value;}
		}

		public double Price{
			get{ return price;}
			set{price = value;}
		}

		public GuitarSpec Spec{
			get{ return guitarSpec;}
			set{guitarSpec = value;}
		}

	}
}


using System;

namespace RickMultipleGuitars
{
	public class Guitar
	{
		private String serialNumber, builder, model, type, backWood, topWood;
		private double price;

		public Guitar(String serialNumber, double price,
			String builder, String model, String type,
			String backWood, String topWood) {
			this.serialNumber = serialNumber;
			this.price = price;
			this.builder = builder;
			this.model = model;
			this.type = type;
			this.backWood = backWood;
			this.topWood = topWood;
		}

		public string SerialNumber{
			get{ return serialNumber;}
			set{serialNumber = value;}
		}

		public string Builder{
			get{ return builder;}
			set{builder = value;}
		}

		public string Model{
			get{ return model;}
			set{model = value;}
		}

		public string Typeg{
			get{ return type;}
			set{type = value;}
		}

		public string BackWood{
			get{ return backWood;}
			set{backWood = value;}
		}

		public string TopWood{
			get{ return topWood;}
			set{topWood = value;}
		}

		public double Price{
			get{ return price;}
			set{price = value;}
		}
	}
}


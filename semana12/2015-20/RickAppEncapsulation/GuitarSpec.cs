using System;

namespace RickAppEncapsulation
{
	public class GuitarSpec
	{
		private string builder, model, type, backWood, topWood;

		public GuitarSpec(Builder builder, string model, Typeg type,
			Wood backWood, Wood topWood) {
			this.builder = builder.ToString();
			this.model = model;
			this.type = type.ToString();
			this.backWood = backWood.ToString();
			this.topWood = topWood.ToString();
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
	}
}


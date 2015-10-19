using System;

namespace InstrumentAppV1
{
	public class InstrumentSpec
	{

		private String builder, model, type, backWood, topWood;

		public InstrumentSpec(Builder builder, string model, Typeg type,
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

		public virtual bool matches(InstrumentSpec otherSpec){
			if (this.Builder != otherSpec.Builder)
				return false;
			if ((this.Model != null) && (!model.Equals ("")) &&
			   (!this.Model.Equals (otherSpec.Model)))
				return false;
			if (this.Typeg != otherSpec.Typeg)
				return false;
			if (this.BackWood != otherSpec.BackWood)
				return false;
			if (this.TopWood != otherSpec.TopWood)
				return false;

			return true;
		}
	}
}


using System;

namespace InstrumentAppV1
{
	public class MandolinSpec:InstrumentSpec
	{
		private String style;

		public MandolinSpec(Builder builder, string model, Typeg type,
			Style style, Wood backWood, Wood topWood): base(builder,model,type,
				backWood,topWood) {
			
			this.style = style.ToString ();
		}

		public String Style{
			get{ return style;}
			set{style = value;}
		}

		public override bool matches(InstrumentSpec otherSpec){
			if (!base.matches (otherSpec))
				return false;
			if (!(otherSpec is MandolinSpec))
				return false;
			MandolinSpec mandolinSpec = otherSpec as MandolinSpec;
			if (this.Style != mandolinSpec.Style)
				return false;

			return true;
		}
	}
}


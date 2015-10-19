using System;

namespace InstrumentAppV1
{
	public class GuitarSpec:InstrumentSpec
	{
		private int numStrings;

		public GuitarSpec(Builder builder, string model, Typeg type,
			int numStrings, Wood backWood, Wood topWood): base(builder,model,type,
				backWood,topWood) {
			this.numStrings = numStrings;
		}

		public int NumStrings{
			get{ return numStrings;}
			set{numStrings = value;}
		}

		public override bool matches(InstrumentSpec otherSpec){
			if (!base.matches (otherSpec))
				return false;
			if (!(otherSpec is GuitarSpec))
				return false;
			GuitarSpec guitarSpec = otherSpec as GuitarSpec;
			if (this.NumStrings != guitarSpec.NumStrings)
				return false;

			return true;
		}
	}
}


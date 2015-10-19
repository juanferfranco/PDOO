using System;
using System.Collections.Generic;

namespace InstrumentAppV1
{
	public class Inventory
	{
		private List<Instrument> inventory = null;

		public Inventory() {
			inventory = new List<Instrument>();
		}

		public void addInstrument(string serialNumber, double price,
			InstrumentSpec spec) {

			Instrument instrument = null;

			if (spec is GuitarSpec) {
				instrument = new Guitar (serialNumber, price, spec as GuitarSpec);
			} else if (spec is MandolinSpec) {
				instrument = new Mandolin (serialNumber, price, spec as MandolinSpec);
			}
			inventory.Add (instrument);
		}

		public Instrument getInstrument(String serialNumber) {
			foreach (Instrument instrument in inventory) {
				if (instrument.SerialNumber.Equals (serialNumber))
					return instrument;
			}
			return null;
		}

		public List<Guitar> search(GuitarSpec searchSpec) {

			List<Guitar> matchingGuitars = new List<Guitar>();

			foreach (Guitar guitar in inventory) {
				if(guitar.Spec.matches(searchSpec)){
					matchingGuitars.Add(guitar);
				}
			}
			return matchingGuitars;
		}

		public List<Mandolin> search(MandolinSpec searchSpec) {

			List<Mandolin> matchingMandolins = new List<Mandolin>();

			foreach (Mandolin mandolin in inventory) {
				if(mandolin.Spec.matches(searchSpec)){
					matchingMandolins.Add(mandolin);
				}
			}
			return matchingMandolins;
		}
	}
}

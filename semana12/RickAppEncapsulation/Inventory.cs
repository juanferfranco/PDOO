using System;
using System.Collections.Generic;

namespace RickAppEncapsulation
{
	public class Inventory
	{
		private List<Guitar> guitars = null;

		public Inventory() {
			guitars = new List<Guitar>();
		}

		public void addGuitar(string serialNumber, double price,
			Builder builder, string model,
			Typeg type, Wood backWood, Wood topWood) {

			Guitar guitar = new Guitar(serialNumber, price, builder,
				model, type, backWood, topWood);
			
			guitars.Add(guitar);
		}

		public Guitar getGuitar(string serialNumber) {
			foreach (Guitar guitar in guitars) {
				if (guitar.SerialNumber.Equals (serialNumber))
					return guitar;
			}
			return null;
		}

		public List<Guitar> search(GuitarSpec searchSpec) {

			List<Guitar> matchingGuitars = new List<Guitar>();

			foreach (Guitar guitar in guitars) {
				GuitarSpec guitarSpec = guitar.Spec;

				if (!guitarSpec.Builder.Equals(searchSpec.Builder))
					continue;
				
				string model = searchSpec.Model.ToLower();
				if ((model != null) && (!model.Equals("")) &&
					(!model.Equals(guitarSpec.Model.ToLower())))
					continue;

				if (!guitarSpec.Typeg.Equals(searchSpec.Typeg))
					continue;

				if (!guitarSpec.BackWood.Equals(searchSpec.BackWood))
					continue;

				if (!guitarSpec.TopWood.Equals(searchSpec.TopWood))
					continue;

				matchingGuitars.Add (guitar);
			}
			return matchingGuitars;
		}
	}
}


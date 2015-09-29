using System;
using System.Collections.Generic;

namespace RickMultipleGuitars
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

		public List<Guitar> search(Guitar searchGuitar) {

			List<Guitar> matchingGuitars = new List<Guitar>();
			foreach (Guitar guitar in guitars) {
				// Ignore serial number since that's unique
				// Ignore price since that's unique
				string builder = searchGuitar.Builder;
				if ((builder != null) && (!builder.Equals("")) &&
					(!builder.Equals(guitar.Builder)))
					continue;
				
				string model = searchGuitar.Model.ToLower();
				if ((model != null) && (!model.Equals("")) &&
					(!model.Equals(guitar.Model.ToLower())))
					continue;
				
				string type = searchGuitar.Typeg;
				if ((type != null) && (!searchGuitar.Equals("")) &&
					(!type.Equals(guitar.Typeg)))
					continue;

				string backWood = searchGuitar.BackWood;
				if ((backWood != null) && (!backWood.Equals("")) &&
					(!backWood.Equals(guitar.BackWood)))
					continue;

				string topWood = searchGuitar.TopWood;
				if ((topWood != null) && (!topWood.Equals("")) &&
					(!topWood.Equals(guitar.TopWood)))
					continue;

				matchingGuitars.Add (guitar);
			}
			return matchingGuitars;
		}
	}
}


using System;
using System.Collections.Generic;

namespace InstrumentAppV1
{
	class MainClass
	{
		public static void Main(string[] args) {
			// Set up Rick's guitar inventory
			Inventory inventory = new Inventory();
			initializeInventory(inventory);

			GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", 
				Typeg.ELECTRIC, 6, Wood.ALDER, Wood.ALDER);

			List<Guitar> guitars = inventory.search(whatErinLikes);

			if (guitars.Count != 0) {
				Console.WriteLine ("Erin, you might like these guitars:");
				foreach (Guitar guitar in guitars) {
					GuitarSpec guitarSpec = guitar.Spec as GuitarSpec;

					Console.WriteLine("  We have a " +
						guitarSpec.Builder + " " + guitarSpec.Model + " " +
						guitarSpec.Typeg + " guitar:\n     " +
						guitarSpec.BackWood + " back and sides,\n     " +
						guitarSpec.TopWood + " top.\n  You can have it for only $" +
						guitar.Price + "!\n  ----");
				}
			} else {
				Console.WriteLine("Sorry, Erin, we have nothing for you.");
			}
			Console.ReadKey();
		}

		private static void initializeInventory(Inventory inventory) {
			inventory.addInstrument ("11277", 3999.95, new GuitarSpec (Builder.COLLINGS, 
				"CJ", Typeg.ACOUSTIC, 6,
				Wood.INDIAN_ROSEWOOD, Wood.SITKA));

			inventory.addInstrument("V95693", 1499.95, new GuitarSpec(Builder.FENDER, 
				"Stratocastor", Typeg.ELECTRIC,6,
				Wood.ALDER, Wood.ALDER));
			inventory.addInstrument("V9512", 1549.95, new GuitarSpec(Builder.FENDER, 
				"Stratocastor", Typeg.ELECTRIC,6,
				Wood.ALDER, Wood.ALDER));
			inventory.addInstrument("122784", 5495.95, new GuitarSpec(Builder.MARTIN, 
				"D-18", Typeg.ACOUSTIC,6,
				Wood.MAHOGANY, Wood.ADIRONDACK));
			inventory.addInstrument("76531", 6295.95, new GuitarSpec(Builder.MARTIN, 
				"OM-28", Typeg.ACOUSTIC,6,
				Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK));
			inventory.addInstrument("70108276", 2295.95, new GuitarSpec(Builder.GIBSON, 
				"Les Paul", Typeg.ELECTRIC,6,
				Wood.MAHOGANY, Wood.MAHOGANY));
			inventory.addInstrument("82765501", 1890.95, new GuitarSpec(Builder.GIBSON, 
				"SG '61 Reissue", Typeg.ELECTRIC,6,
				Wood.MAHOGANY, Wood.MAHOGANY));
			inventory.addInstrument("77023", 6275.95, new GuitarSpec(Builder.MARTIN, 
				"D-28", Typeg.ACOUSTIC,6,
				Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK));
			inventory.addInstrument("1092", 12995.95, new GuitarSpec(Builder.OLSON, 
				"SJ", Typeg.ACOUSTIC,6,
				Wood.INDIAN_ROSEWOOD, Wood.CEDAR));
			inventory.addInstrument("566-62", 8999.95, new GuitarSpec(Builder.RYAN, 
				"Cathedral", Typeg.ACOUSTIC,6,
				Wood.COCOBOLO, Wood.CEDAR));
			inventory.addInstrument("6 29584", 2100.95, new GuitarSpec(Builder.PRS, 
				"Dave Navarro Signature", Typeg.ELECTRIC, 6,
				Wood.MAHOGANY, Wood.MAPLE));
		}
	}
}

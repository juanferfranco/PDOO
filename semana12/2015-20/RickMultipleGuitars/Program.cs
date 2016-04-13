using System;
using System.Collections.Generic;

namespace RickMultipleGuitars
{
	class MainClass
	{
		public static void Main(string[] args) {
			// Set up Rick's guitar inventory
			Inventory inventory = new Inventory();
			initializeInventory(inventory);

			Guitar whatErinLikes = new Guitar("", 0, Builder.FENDER, "Stratocastor", 
				Typeg.ELECTRIC, Wood.ALDER, Wood.ALDER);
			
			List<Guitar> guitars = inventory.search(whatErinLikes);

			if (guitars.Count != 0) {
				Console.WriteLine ("Erin, you might like these guitars:");
				foreach (Guitar guitar in guitars) {
					Console.WriteLine("  We have a " +
						guitar.Builder + " " + guitar.Model + " " +
						guitar.Typeg + " guitar:\n     " +
						guitar.BackWood + " back and sides,\n     " +
						guitar.TopWood + " top.\n  You can have it for only $" +
						guitar.Price + "!\n  ----");
				}
			} else {
				Console.WriteLine("Sorry, Erin, we have nothing for you.");
			}
			Console.ReadKey();
		}

		private static void initializeInventory(Inventory inventory) {
			inventory.addGuitar("11277", 3999.95, Builder.COLLINGS, 
				"CJ", Typeg.ACOUSTIC, 
				Wood.INDIAN_ROSEWOOD, Wood.SITKA);
			inventory.addGuitar("V95693", 1499.95, Builder.FENDER, 
				"Stratocastor", Typeg.ELECTRIC,
				Wood.ALDER, Wood.ALDER);
			inventory.addGuitar("V9512", 1549.95, Builder.FENDER, 
				"Stratocastor", Typeg.ELECTRIC,
				Wood.ALDER, Wood.ALDER);
			inventory.addGuitar("122784", 5495.95, Builder.MARTIN, 
				"D-18", Typeg.ACOUSTIC,
				Wood.MAHOGANY, Wood.ADIRONDACK);
			inventory.addGuitar("76531", 6295.95, Builder.MARTIN, 
				"OM-28", Typeg.ACOUSTIC,
				Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK);
			inventory.addGuitar("70108276", 2295.95, Builder.GIBSON, 
				"Les Paul", Typeg.ELECTRIC,
				Wood.MAHOGANY, Wood.MAHOGANY);
			inventory.addGuitar("82765501", 1890.95, Builder.GIBSON, 
				"SG '61 Reissue", Typeg.ELECTRIC,
				Wood.MAHOGANY, Wood.MAHOGANY);
			inventory.addGuitar("77023", 6275.95, Builder.MARTIN, 
				"D-28", Typeg.ACOUSTIC,
				Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK);
			inventory.addGuitar("1092", 12995.95, Builder.OLSON, 
				"SJ", Typeg.ACOUSTIC,
				Wood.INDIAN_ROSEWOOD, Wood.CEDAR);
			inventory.addGuitar("566-62", 8999.95, Builder.RYAN, 
				"Cathedral", Typeg.ACOUSTIC,
				Wood.COCOBOLO, Wood.CEDAR);
			inventory.addGuitar("6 29584", 2100.95, Builder.PRS, 
				"Dave Navarro Signature", Typeg.ELECTRIC, 
				Wood.MAHOGANY, Wood.MAPLE);
		}
	}
}

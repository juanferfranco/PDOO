using System;

namespace Polimorfismo
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			SearchEngine searchEngine1 = new SearchEngine(); 
			SearchEngine searchEngine2 = new GoogleSearch();
			SearchEngine searchEngine3 = new BingSearch();

			string[] defaultResults = searchEngine1.Search("hello");
			string[] googleResults = searchEngine2.Search("hello");
			string[] bingResults = searchEngine3.Search("hello"); 



			Console.WriteLine("Simple Search result: ");
			foreach (string stringItem in defaultResults) {
				Console.WriteLine (stringItem);
			}

			Console.WriteLine("Google Search result: ");
			foreach (string stringItem in googleResults) {
				Console.WriteLine (stringItem);
			}

			Console.WriteLine("Bing Search result: ");
			foreach (string stringItem in bingResults) {
				Console.WriteLine (stringItem);
			}


			Console.ReadKey ();
		}
	}
}

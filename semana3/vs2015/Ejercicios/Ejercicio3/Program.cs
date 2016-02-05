using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchEngine searchEngine1 = new SearchEngine();
            SearchEngine searchEngine2 = new GoogleSearch();
            SearchEngine searchEngine3 = new BingSearch();

            string[] resSimpleSearch = searchEngine1.Search("Hello by Adele");
            Console.WriteLine("Simple Search:");
            PrintResults(resSimpleSearch);

            string[] resGoogleSearch = searchEngine2.Search("Hello by Adele");
            Console.WriteLine("Google Search:");
            PrintResults(resGoogleSearch);


            string[] resBingSearch = searchEngine3.Search("Hello by Adele");
            Console.WriteLine("Bing Search:");
            PrintResults(resBingSearch);

            Console.ReadKey();
        }

        private static void PrintResults(string[] results)
        {
            if (results.Length != 0)
            {
                foreach (string item in results)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("The Search is empty");
            }
        }

    }
}

using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchEngine simpleSearch = new SearchEngine();
            GoogleSearch googleSearch = new GoogleSearch();
            Console.WriteLine(simpleSearch.Search("¿Qué es la vida?"));
            Console.WriteLine(googleSearch.Search("¿Qué es la vida?"));
            Console.ReadKey();
        }
    }
}

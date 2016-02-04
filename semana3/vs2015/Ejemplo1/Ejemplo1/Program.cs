using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchEngine simpleSearch = new SearchEngine();
            GoogleSearch googleSearch = new GoogleSearch();

            //Console.WriteLine(simpleSearch.Search("¿Qué es la vida?"));
            foreach(string item in simpleSearch.Search("¿Qué es la vida?"))
            {
                Console.WriteLine(item);

            }


            foreach(string item in googleSearch.Search("¿Qué es la vida?"))
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(googleSearch.Search("¿Qué es la vida?"));

            Console.ReadKey();
        }
    }
}

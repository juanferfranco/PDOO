using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchEngine simpleSearch = new SearchEngine();
            GoogleSearch googleSearch = new GoogleSearch();


            string[] resSimpleSearch = simpleSearch.Search("¿Qué es la vida?");

            if(resSimpleSearch.Length != 0)
            {
                foreach (string item in resSimpleSearch)
                {
                    Console.WriteLine(item);

                }
            }
            else
            {
                Console.WriteLine("Simple Search is empty");
            }

            string[] resGoogleSearch = googleSearch.Search("¿Qué es la vida?");
            if (resGoogleSearch.Length != 0) { 
                foreach (string item in resGoogleSearch)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Google Search is empty");
            }



            //Console.WriteLine(googleSearch.Search("¿Qué es la vida?"));

            Console.ReadKey();
        }
    }
}

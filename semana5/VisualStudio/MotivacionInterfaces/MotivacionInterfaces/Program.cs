using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotivacionGenerics
{

    public class ListOfNumbers
    {

        private int[] numbers;

        public ListOfNumbers()
        {

            numbers = new int[0];

        }

        public void AddNumber(int newNumber)
        {
            // Add some code in here to make a new array, slightly larger 
            // than it already was, and add your number in. 
        }

        public int GetNumber(int index)
        {
            return numbers[index];
        }
    }


    public class ListOfStrings
    {

        private string[] strings;

        public ListOfStrings()
        {

            strings = new string[0];

        }

        public void AddString(string newString)
        {
            // Add some code in here to make a new array, slightly larger 
            // than it already was, and add your number in. 
        }

        public string GetString(int index)
        {
            return strings[index];
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
        }
    }


}

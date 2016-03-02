using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample2
{
    public delegate int MathDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            MathDelegate[] mathOperationArray = { Add, Subtract, Power };
            int a = 5;
            int b = 7;
            //int result;
            foreach (MathDelegate op in mathOperationArray)
            {
                a = 5;
                b = 7;
                int result = op(a, b);
                Console.WriteLine("result: {0}", result);
            }

            Console.ReadKey();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Power(int baseNumber, int exponent)
        {
            return (int)Math.Pow(baseNumber, exponent);
        }
    }
}

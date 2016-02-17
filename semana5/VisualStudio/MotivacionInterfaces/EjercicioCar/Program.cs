using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCar
{

    public class Car : IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        // Implementation of IEquatable<T> interface
        public bool Equals(Car car)
        {
            if (this.Make == car.Make &&
                this.Model == car.Model &&
                this.Year == car.Year)
            {
                return true;
            }
            else
                return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Fiesta";
            car1.Year = "2015";

            Car car2 = new Car();
            car2.Make = "Chevrolet";
            car2.Model = "Spark GT";
            car2.Year = "2014";

            Car car3 = new Car();
            car3.Make = "Ford";
            car3.Model = "Fiesta";
            car3.Year = "2015";


            if (car1.Equals(car2))
            {
                Console.WriteLine("car1 is equal to car2");
            }
            else Console.WriteLine("car1 is not equal to car2");

            if (car1.Equals(car3))
            {
                Console.WriteLine("car1 is equal to car3");
            }
            else Console.WriteLine("car1 is not equal to car3");

            Console.ReadKey();
        }
    }
}

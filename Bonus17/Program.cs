using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate
            Car car1, car2, car3;
            UsedCar car4, car5, car6;
            car1 = new Car("Dodge", "Durango", 2001, 10000);
            car2 = new Car("Ford", "Taurus", 2002, 20000);
            car3 = new Car("Chrysler", "300", 2003, 30000);
            car4 = new UsedCar("Halo", "Skateboard", 2004, 40000, 10000);
            car5 = new UsedCar("LiquidForce", "Wakeboard", 2005, 50000, 20000);
            car6 = new UsedCar("Burton", "Snowboard", 2006, 60000, 30000);

            


            List<Car> cars = new List<Car>() { car1, car2, car3, car4, car5, car6 };


            PrintList(cars);

            Console.ReadKey();
        }

        private static void PrintHeaders()
        {
            Console.Write("#  ");
            Console.Write("Make".PadRight(15));
            Console.Write("Model".PadRight(15));
            Console.Write("Year".PadRight(15));
            Console.Write("Price".PadRight(15));
            Console.WriteLine("Mileage");
            Console.WriteLine("=========================================================================");
        }

        public static void PrintList(List<Car> cars)
        {
            PrintHeaders();
            foreach (Car c in cars)
            {
                    c.PrintList();
                    Console.WriteLine();
            }
                Console.ReadKey();
            
        }

    }
}

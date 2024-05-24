using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание объектов различных средств передвижения
            Plane plane = new Plane(new double[] { 0, 0 }, 1000000, 900, 2020, 10000, 250);
            Car car = new Car(new double[] { 50, 20 }, 50000, 200, 2018);
            Ship ship = new Ship(new double[] { -10, -30 }, 2000000, 50, 2015, 1500, "New York");

            //Вывод информации о каждом средстве передвижения
            Console.WriteLine("Plane:");
            plane.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Car:");
            car.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Ship:");
            ship.PrintInfo();

            Console.ReadKey();
        }
    }
}

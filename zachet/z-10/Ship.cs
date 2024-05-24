using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_10
{
    class Ship : Vehicle
    {
        ///
        private int passengers;
        private string port;

        // Конструктор класса Ship
        public Ship(double[] coordinates, double price, double speed, int year, int passengers, string port)
            : base(coordinates, price, speed, year)
        {
            this.passengers = passengers;
            this.port = port;
        }

        // Переопределение метода для вывода информации о корабле
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Passengers: {passengers}");
            Console.WriteLine($"Port: {port}");
        }
    }

}

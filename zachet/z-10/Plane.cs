using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_10
{
    class Plane : Vehicle
    {
        /// <summary>
        /// поле описывабщее высоту
        /// </summary>
        private double altitude;
        /// <summary>
        /// поле описывабщее пасажиров
        /// </summary>
        private int passengers;

        /// <summary>
        /// конструктор с 6 параметрами
        /// </summary>
        /// <param name="coordinates"></param>
        /// <param name="price"></param>
        /// <param name="speed"></param>
        /// <param name="year"></param>
        /// <param name="altitude"></param>
        /// <param name="passengers"></param>
        public Plane(double[] coordinates, double price, double speed, int year, double altitude, int passengers)
            : base(coordinates, price, speed, year)
        {
            this.altitude = altitude;
            this.passengers = passengers;
        }

        // Переопределение метода для вывода информации о самолете
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Altitude: {altitude} meters");
            Console.WriteLine($"Passengers: {passengers}");
        }
    }
}

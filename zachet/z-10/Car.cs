using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_10
{
    // Производный класс Car
    class Car : Vehicle
    {
        // Конструктор класса Car
        public Car(double[] coordinates, double price, double speed, int year)
            : base(coordinates, price, speed, year)
        {
        }
    }
}

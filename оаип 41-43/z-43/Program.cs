using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_43
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляры класса Triangle с разными типами данных
            Triangle<int> intTriangle = new Triangle<int>(3, 4, 5);
            Triangle<uint> uintTriangle = new Triangle<uint>(6u, 8u, 10u);
            Triangle<double> doubleTriangle = new Triangle<double>(4.5, 5.5, 7.5);

            // Выводим информацию о треугольниках
            intTriangle.DisplayInfo();
            Console.WriteLine("Площадь треугольника: " + intTriangle.CalculateArea());

            uintTriangle.DisplayInfo();
            Console.WriteLine("Площадь треугольника: " + uintTriangle.CalculateArea());

            doubleTriangle.DisplayInfo();
            Console.WriteLine("Площадь треугольника: " + doubleTriangle.CalculateArea());

            Console.ReadLine();
        }
    }
}

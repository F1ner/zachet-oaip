using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_37
{
    class Program
    {
        delegate double TriangleArea();

        static void Main(string[] args)
        {
            // Создание объекта треугольника
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(5, 6, 7);
            Triangle triangle3 = new Triangle(8, 10, 12);

            // Присвоение указателя на метод делегату
            TriangleArea areaCalculator1 = triangle1.CalculateArea;
            TriangleArea areaCalculator2 = triangle2.CalculateArea;
            TriangleArea areaCalculator3 = triangle3.CalculateArea;

            // Вычисление площади треугольников с использованием делегата
            double area1 = areaCalculator1();
            double area2 = areaCalculator2();
            double area3 = areaCalculator3();

            Console.WriteLine($"Площадь треугольника 1: {area1}");
            Console.WriteLine($"Площадь треугольника 2: {area2}");
            Console.WriteLine($"Площадь треугольника 3: {area3}");

            Console.ReadLine();
        }
    }
}

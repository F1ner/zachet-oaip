using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_37
{
    // Класс, представляющий треугольник
    /// <summary>
    /// Класс, представляющий треугольник.
    /// </summary>
    class Triangle
    {
        private double a, b, c;

        /// <summary>
        /// Делегат для вычисления площади треугольника.
        /// </summary>
        /// <returns>Возвращает площадь треугольника.</returns>
        delegate double TriangleArea();

        /// <summary>
        /// Конструктор класса Triangle.
        /// </summary>
        /// <param name="sideA">Длина стороны A треугольника.</param>
        /// <param name="sideB">Длина стороны B треугольника.</param>
        /// <param name="sideC">Длина стороны C треугольника.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA;
            b = sideB;
            c = sideC;
        }

        /// <summary>
        /// Метод для вычисления площади треугольника.
        /// </summary>
        /// <returns>Возвращает площадь треугольника.</returns>
        public double CalculateArea()
        {
            // Формула Герона для вычисления площади треугольника
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
